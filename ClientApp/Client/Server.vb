Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Media
Imports System.Diagnostics
Imports System.Threading
Imports System.Net.Sockets
Imports System.Text

Public Class Server

#Region "Declaration of variables"

#Region "Screen Variables"

    Private ScreenClientX As Integer = 1920
    'Sizes of the client and our screen
    Private ScreenClientY As Integer = 1080
    Private ScreenServerX As Integer = 1920
    Private ScreenServerY As Integer = 1080

    Private Padding As Integer = 3

    Private ImageResoloution As PixelFormat = PixelFormat.Format16bppRgb555
    Private BrushWait As Brush = Brushes.Black

#End Region

#Region "Encryption Variables"

    Private Encrypted As Boolean = False

#End Region

#Region "Connection Variables"

    Private ServerSocket As Socket
    Private Port As Integer
    Private CStream As Stream

#End Region

#Region "Event Variables"

    Private THEvents As Thread = Nothing
    Private THServer As Thread = Nothing
    Private LastEventTime As DateTime = DateTime.Now

#End Region

#Region "Status Variables"

    Public Running As Boolean = False
    Private LoggedIn As Boolean = False
    Private HadEvent As Boolean = False

#End Region

#Region "Sleep Variables"

    Public imageDelay As Integer
    Private Sleep As Boolean = False
    Private SleepCount As Integer = 0

#End Region

#Region "Clipboard Variables"

    Private LastClipboardText As String = ""

#End Region

#Region "FileTransfer Variables"

    Private FTP As New FTPFileManager
    Private FTPSaveTo As String
    Private FTPFiles As New ArrayList

    Private Dropbox As New DropBoxManager
    Private DBXSaveTo As String
    Private DBXFile As String
    Private DBXURL As String

#End Region

#End Region

#Region "Start/Stop Server"

    Public Sub Start(port As Integer, serverSocket__1 As Socket, ScreenX As Integer, ScreenY As Integer)
        'Start new threads to send the desktop image and another to wait for keyboard/mouse commands to come in
        imageDelay = 2000
        Sleep = False
        ScreenServerX = ScreenX
        ScreenServerY = ScreenY
        ScreenClientX = Screen.PrimaryScreen.Bounds.Width
        ScreenClientY = Screen.PrimaryScreen.Bounds.Height
        ImageResoloution = PixelFormat.Format16bppRgb555
        Running = True
        LoggedIn = False
        SleepCount = 0
        ServerSocket = serverSocket__1
        Settings.Port = port
        port = port
        CStream = New NetworkStream(ServerSocket)
        LastClipboardText = ClipboardAsync.GetText()
        THEvents = New Thread(New ThreadStart(AddressOf WaitForCommands))
        THEvents.Start()
        Thread.Sleep(300)
        'Give the command thread a chance to start
        THServer = New Thread(New ThreadStart(AddressOf PushTheDesktopToClients))
        THServer.Start()
    End Sub

    Public Sub [Stop]()
        Wallpaper.RestoreWallpaper()
        Running = False
        Thread.Sleep(200)
        'Try to let things close down for the threads
        If ServerSocket.IsBound Then
            ServerSocket.Close()
        End If
        CStream = Nothing
        If THEvents IsNot Nothing Then
            THEvents.Abort()
        End If
        If THServer IsNot Nothing Then
            THServer.Abort()
        End If
    End Sub

#End Region

#Region "Password Checker"

    Private Sub TestPassword(PassWord As String)
        If PassWord.Trim() = Settings.PassWord.ToLower() OrElse Settings.PassWord.Length = 0 Then
            LoggedIn = True
        Else
            Listener.printDebug("Bad password", True)
            [Stop]()
        End If
    End Sub

#End Region

#Region "Screen"

#Region "ScreenData"

    Private Sub SendScreenInfo(Data As String)
        'The screen sizes need sending to the client
        Data = "#INFO#" & Data
        If Encrypted Then
            Dim bFormat As New BinaryFormatter()
            Dim BClip As Byte() = UTF8Encoding.UTF8.GetBytes(Helper.XorString(Data, 34, True))
            Dim MS As New MemoryStream(BClip)
            bFormat.Serialize(CStream, MS)
            Listener.printDebug("INFO << Length=" & (Data.Length - 6), True)
        Else
            'When sent like this the client will catch an error and inform this service to lock, fixes the error and then tells this service to unlock
            'Client will send unlock message
            Dim B As Byte() = UTF8Encoding.UTF8.GetBytes("                                  " & Helper.XorString(Data.Replace(Environment.NewLine, "#NL#").Replace(vbLf, "#NL#").Replace("'", "#SQ#"), 34, True))
            CStream.Flush()
            CStream.Write(B, 0, B.Length)
            CStream.Flush()
            Listener.printDebug("INFO << Length=" & (Data.Length - 6), True)
        End If
    End Sub

    Private Sub WriteScreenSize()
        SendScreenInfo("SCREEN_" & Screen.PrimaryScreen.Bounds.Width & "_" & Screen.PrimaryScreen.Bounds.Height)
        ScreenClientX = Screen.PrimaryScreen.Bounds.Width
        ScreenClientY = Screen.PrimaryScreen.Bounds.Height
        ScreenServerX = Screen.PrimaryScreen.Bounds.Width
        ScreenServerY = Screen.PrimaryScreen.Bounds.Height
    End Sub

#End Region

#Region "SendScreen"

    Private Sub PushTheDesktopToClients()
        'Keep pushing the screen destop image to any clients that are awake
        Dim Stage As String = "Start"
        'Used so we know where things went wrong if something crashes 
        Try
            While Running
                Dim TS As TimeSpan = DateTime.Now - LastEventTime
                If TS.TotalMinutes > 10 Then
                    KeepMachineAwake()
                End If
                If Not Sleep AndAlso LoggedIn Then
                    'Sleep if the client has minimized the form
                    Dim bFormat As New BinaryFormatter()
                    Try
                        If ScreenClientX <> Screen.PrimaryScreen.Bounds.Width OrElse ScreenClientY <> Screen.PrimaryScreen.Bounds.Height Then
                            WriteScreenSize()
                        End If
                        SleepCount = 0
                        SendClipboard()
                        Dim screeny As New Bitmap(ScreenServerX + Padding, ScreenServerY + Padding, ImageResoloution)
                        Dim theShot As Graphics = Graphics.FromImage(screeny)
                        Stage = "Got Screen"
                        Dim Sz As New System.Drawing.Size(ScreenServerX + Padding, ScreenServerY + Padding)
                        theShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, Padding, Padding, Sz, CopyPixelOperation.SourceCopy)
                        Stage = "Copy Screen"
                        Dim X As Integer = 0
                        Dim Y As Integer = 0
                        Dim CursorColor As Color = WinCursor.CaptureCursor(X, Y, theShot, ScreenServerX, ScreenServerY)
                        screeny.SetPixel(0, 0, CursorColor)
                        'Embed the cursor type in the image sent back to the cleint but need to be coded as a colour
                        If Encrypted Then
                            'Send as a encrypted memory stream
                            Dim MS As MemoryStream = Encrypt(screeny)
                            bFormat.Serialize(CStream, MS)
                        Else
                            'Send as a bit-map
                            bFormat.Serialize(CStream, screeny)
                            'This is a bit faster i think, hence the option
                        End If
                        Stage = "Serialize Screen"
                        SleepDelay()
                        'Pause for a bit but wake up early if the client sends a mouse click or something so we can send the desktop back early
                        theShot.Dispose()
                        screeny.Dispose()
                    Catch Ex1 As Exception
                        If Not Running Then
                            Return
                        End If
                        If Ex1.Message.StartsWith("Unable to write data to the transport connection") OrElse Not ServerSocket.Connected Then
                            'Client may have closed without letting us know first 
                            THServer = Nothing
                            [Stop]()
                            Return
                        ElseIf Ex1.Message.StartsWith("The handle is invalid") Then
                            'Cannot get the screen when it is locked so flash a image
                            Dim screeny As Bitmap = DirectCast(Listener.ImgWinbackground, Bitmap)
                            Dim G As Graphics = Graphics.FromImage(screeny)
                            G.FillEllipse(BrushWait, 170, 100, 60, 60)
                            screeny.SetPixel(0, 0, Color.Fuchsia)
                            If Encrypted Then
                                'Send as a encrypted memory stream
                                Dim MS As MemoryStream = Encrypt(screeny)
                                bFormat.Serialize(CStream, MS)
                            Else
                                'Send as a bit-map
                                bFormat.Serialize(CStream, screeny)
                            End If
                            Thread.Sleep(3000)
                        Else
                            Listener.printDebug((Convert.ToString("Screen Error ") & Stage) & " " & Ex1.Message, True)
                        End If

                        Thread.Sleep(50)
                    End Try
                Else
                    'In sleep mode or not logged in so do nothing
                    SleepCount += 1
                    Thread.Sleep(500)
                    If Not LoggedIn AndAlso SleepCount > 25 Then
                        'We did not get a password sent
                        Listener.printDebug("NO LOGIN", True)
                        [Stop]()
                    ElseIf SleepCount > 7200 Then
                        'One hour then we kill the session to save servers CPU
                        Listener.printDebug("Session timeout", True)
                        [Stop]()
                    End If
                End If
            End While
        Catch Ex As Exception
            Listener.printDebug("Error Stop " & Ex.Message, True)
            [Stop]()
        End Try
    End Sub

    Public Shared Function Encrypt(Img As Bitmap) As MemoryStream
        'We just remove the start of the PNG and replace with an image
        Dim Seed As String = DateTime.Now.Millisecond.ToString() & DateTime.Now.Hour & DateTime.Now.Second & "aqf"
        Dim ImgByte As Byte() = UTF8Encoding.UTF8.GetBytes(Seed.Substring(0, 6))
        Dim MSin As New MemoryStream()
        Img.Save(MSin, ImageFormat.Png)
        MSin.Position = 0
        MSin.Position = 0
        MSin.Write(ImgByte, 0, 6)
        Return MSin
    End Function

#End Region

#Region "ScreenOn"

    Private Sub KeepMachineAwake()
        'Fake key-move to keep the machine awake
        LastEventTime = DateTime.Now
        SendKeys.SendWait("{DOWN}")
        Thread.Sleep(50)
        SendKeys.SendWait("{UP}")
    End Sub

#End Region

#Region "ScreenDelay"

    Public Sub SleepDelay()
        'Sleep a bit so the network and the local CPU does not get over worked
        For f As Integer = 0 To imageDelay / 100
            Thread.Sleep(100)
            If HadEvent Then
                'The client sent a mouse move or something so wake up and send the desktop back a bit early
                HadEvent = False
                Return
            End If
        Next
    End Sub

#End Region

#End Region

#Region "Commands"

    Private Sub WaitForCommands()
        'Runs on its own thread and we just wait for the client to send us commands for the keyboard or mouse.
        Dim reader As New StreamReader(CStream)
        While Running AndAlso Not Listener.Closing
            If Sleep Then
                Thread.Sleep(1000)
            End If
            Try
                If ScreenClientX <> Screen.PrimaryScreen.Bounds.Width OrElse ScreenClientY <> Screen.PrimaryScreen.Bounds.Height Then
                    WriteScreenSize()
                End If
                Dim Shift As Integer = 45
                Dim temp As String = reader.ReadLine()
                If temp.Length = 1 Then
                    Shift = 77
                End If
                'Change our encryption shift if it's just a keystroke
                temp = Helper.XorString(temp, Shift, False)
                If temp = "C33C" Then
                    temp = " "
                End If
                LastEventTime = DateTime.Now
                If temp IsNot Nothing Then
                    ReadCommandValues(temp)
                    'Processs the command we just got
                    HadEvent = True
                End If
            Catch Ex As Exception
                If Not ServerSocket.Connected AndAlso Not Listener.Closing AndAlso Running Then
                    Listener.printDebug("Error waitForKeys " & Ex.Message, True)
                    THEvents = Nothing
                    [Stop]()
                    Return
                End If
            End Try
        End While
    End Sub

    Private Sub ReadCommandValues(temp As String)

        'Could be a key-stroke or a mouse move/click or a cammon to do something else
        If temp.StartsWith("CDELAY") Then
            Listener.printDebug(temp, False)
            imageDelay = Integer.Parse(temp.Substring(6, temp.Length - 6))
        ElseIf temp.StartsWith("CMD ") Then
            Dim Force As Boolean = False
            Dim Cmd As String = temp.Substring(3).Trim()
            If Cmd = "OK" Then
                Return
            End If
            If Cmd.StartsWith("PASSWORD ") Then
                TestPassword(Cmd.Substring(9).ToLower())
                Cmd = "PASSWORD *******"
                Force = True
            End If
            If Cmd.StartsWith("KEYSYNC ") Then
                Helper.SyncKeys(Cmd)
            End If
            If Cmd = "SHOWSTART" Then
                Helper.ShowStart()
            End If

            If Cmd.StartsWith("PADDING ") Then
                Padding = Integer.Parse(Cmd.Replace("PADDING ", "").Trim())
            End If
            If Cmd.StartsWith("SLEEP TRUE") Then
                Sleep = True
            End If
            If Cmd.StartsWith("SLEEP FALSE") Then
                Sleep = False
            End If
            Listener.printDebug(Cmd, Force)
            If Cmd.StartsWith("RESOLUTION TRUE") Then
                ImageResoloution = PixelFormat.Format32bppArgb
            End If
            If Cmd.StartsWith("RESOLUTION FALSE") Then
                ImageResoloution = PixelFormat.Format16bppRgb555
            End If
            If Cmd.StartsWith("WALLPAPER TRUE") Then
                Wallpaper.SetWallpaper()
            End If
            If Cmd.StartsWith("WALLPAPER FALSE") Then
                Wallpaper.RestoreWallpaper()
            End If
            If Cmd.StartsWith("CLOSE") Then
                [Stop]()
            End If
        ElseIf temp.StartsWith("FTP ") Then
            Dim FTPCMD As String = temp.Substring(3).Trim()
            If FTPCMD.StartsWith("FTPLOC#") Then
                FTPSaveTo = FTPCMD.Substring(("FTPLOC#").Length)
                'MsgBox(FTPSaveTo)
            End If
            If Not Directory.Exists(FTPSaveTo) Then
                MsgBox("File transfer failed due to incorrect directory path")
            Else
                If FTPCMD.StartsWith("FTPF#") Then
                    FTPFiles.Add(FTPCMD.Substring(("FTPF#").Length))
                End If
                If FTPCMD.StartsWith("FTPDOWNLOAD") Then
                    For Each FTPFile As String In FTPFiles
                        'MsgBox(FTPFile)
                        FTP.DownloadFile(FTPSaveTo & FTPFile, "ftp://remotewebserver.hol.es/" & FTPFile, "u145546434", "remoteadminconn")
                        FTP.RemoveFile("ftp://remotewebserver.hol.es/" & FTPFile, "u145546434", "remoteadminconn")
                    Next
                    FTPFiles.Clear()
                End If
            End If
        ElseIf temp.StartsWith("DBX ") Then
            Dim DBXCMD As String = temp.Substring(3).Trim()
            If DBXCMD.StartsWith("DBXLOC#") Then
                DBXSaveTo = DBXCMD.Substring(("DBXLOC#").Length)
                'MsgBox(FTPSaveTo)
            End If
            If Not Directory.Exists(DBXSaveTo) Then
                MsgBox("File transfer failed due to incorrect directory path")
            Else
                If DBXCMD.StartsWith("DBXFName#") Then
                    DBXFile = DBXCMD.Substring(("DBXFName#").Length)
                End If
                If DBXCMD.StartsWith("DBXFURL#") Then
                    DBXURL = DBXCMD.Substring(("DBXFURL#").Length)
                End If
                If DBXCMD.StartsWith("DBXDOWNLOAD") Then
                    FTP.DownloadNormal(DBXSaveTo & DBXFile, DBXURL)
                    Dropbox.DeleteFile(DBXFile)
                End If
            End If

        ElseIf temp.StartsWith("CLIPBOARD ") Then
            LastClipboardText = temp.Substring(10).Replace("#NL#", Environment.NewLine).Replace("#SQ#", "'")
            Listener.printDebug("CLIPBOARD >> Length=" & LastClipboardText.Length, False)
            ClipboardAsync.SetText(LastClipboardText)
        ElseIf temp.StartsWith("SCREEN ") Then
            Listener.printDebug(temp, False)
            ScreenServerX = Integer.Parse(temp.Split(" "c)(1))
            ScreenServerY = Integer.Parse(temp.Split(" "c)(2))
            Settings.ScreenServerX = ScreenServerX
            Settings.ScreenServerY = ScreenServerY
        ElseIf temp.StartsWith("BEEP") Then
            Listener.printDebug(temp, False)
            SystemSounds.Asterisk.Play()
        ElseIf temp.StartsWith("SHUTDOWN") Then
            Listener.printDebug(temp, False)
            Listener.ListenStop(True)
        ElseIf temp.StartsWith("{CAPSLOCK}") Then
            Helper.CapsLock()
            Return
        ElseIf temp.StartsWith("{NUMLOCK}") Then
            Helper.NumLock()
            Return
            'mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            'printDebug(temp, false);
        ElseIf temp.StartsWith("LCLICK") Then
            'mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            'printDebug(temp, false);
        ElseIf temp.StartsWith("RCLICK") Then
        ElseIf temp.StartsWith("LDOWN") Then
            Helper.mouse_event(Helper.MouseEventFlags.MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0)
        ElseIf temp.StartsWith("LUP") Then
            Helper.mouse_event(Helper.MouseEventFlags.MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0)
        ElseIf temp.StartsWith("RCLICK") Then
            Helper.mouse_event(Helper.MouseEventFlags.MOUSEEVENTF_RIGHTDOWN Or Helper.MouseEventFlags.MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0)
        ElseIf temp.StartsWith("RDOWN") Then
            Helper.mouse_event(Helper.MouseEventFlags.MOUSEEVENTF_RIGHTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0)
        ElseIf temp.StartsWith("RUP") Then
            Helper.mouse_event(Helper.MouseEventFlags.MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0)
        ElseIf temp.StartsWith("M") Then
            Dim xPos As Integer = 0, yPos As Integer = 0
            Try
                xPos = Integer.Parse(temp.Substring(1, temp.IndexOf(" "c)))
                yPos = Integer.Parse(temp.Substring(temp.IndexOf(" "c), temp.Length - temp.IndexOf(" "c)))
                Cursor.Position = New Point(xPos, yPos)
            Catch Ex As Exception
                Listener.printDebug("Error Mouse " & Ex.Message, True)
            End Try
        Else
            If temp = "^c" Then
                Listener.printDebug("{COPY}", True)
            ElseIf temp = "^v" Then
                Listener.printDebug("{PASTE}", True)
            ElseIf temp.Length > 1 Then
                Listener.printDebug(temp, True)
            End If
            SendKeys.SendWait(temp)
        End If
    End Sub

#End Region

#Region "Clipboard"

    Public Sub SendClipboard()
        Dim Text As String = ClipboardAsync.GetText()
        If Text IsNot Nothing AndAlso Text = LastClipboardText Then
            Return
        End If
        LastClipboardText = Text
        If Encrypted AndAlso LastClipboardText.Length > 0 Then
            Dim bFormat As New BinaryFormatter()
            Dim BClip As Byte() = UTF8Encoding.UTF8.GetBytes(Helper.XorString(Convert.ToString("#CLIPBOARD#") & LastClipboardText, 34, True))
            Dim MS As New MemoryStream(BClip)
            bFormat.Serialize(CStream, MS)
            Listener.printDebug("CLIPBOARD << Length=" & Text.Length, True)
        ElseIf LastClipboardText.Length > 0 Then
            'When sent like this the client will catch an error and inform this service to lock, fixes the error and then tells this service to unlock
            'Client will send unlock message
            Dim B As Byte() = UTF8Encoding.UTF8.GetBytes("                                  " & Helper.XorString("#CLIPBOARD#" & LastClipboardText.Replace(Environment.NewLine, "#NL#").Replace(vbLf, "#NL#").Replace("'", "#SQ#"), 34, True))
            CStream.Flush()
            CStream.Write(B, 0, B.Length)
            CStream.Flush()
            Listener.printDebug("CLIPBOARD << Length=" & Text.Length, True)
        End If
    End Sub

#End Region

End Class