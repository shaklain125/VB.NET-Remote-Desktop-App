#Region "References"
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Runtime
Imports System.Threading
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
#End Region

Public Class Server

    Public Desktop As New ClientScreen
    Public ConnectionIO As New Connection
    Public SendCommandOrData As New SendCommands
    Public DScreen As New ScreenReadAndDecrypt

    Private SRecorder As New ScreenRecorder

    Public StartServiceDateTime As DateTime
    Public EndServiceDateTime As DateTime

    Public FTPFilenames As New ArrayList
    Public Shared FTPSaveDlgVisible As Boolean = False
    Public Shared FTPTransferFrmVisible As Boolean = False

#Region "Form"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConn.Connect()
        If Not Directory.Exists(SRecorder.ScreenRecordLocation) Then
            Directory.CreateDirectory(SRecorder.ScreenRecordLocation)
        End If
        MaximizeBox = False
        LiveChatPanel.Visible = False
        LChat.Label3.Text = Computers.ClientID
        AddLiveChat()
        ChangeChatPanelLocation()
        CurrentScreen_btn.PerformClick()
        Desktop.tbl_ConnStatus.Visible = True
        Desktop.lbl_ConnStatus.Text = "Not Connected"
        Computers.Pass = Settings.PassWord
        Form1_Resize(Nothing, Nothing)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ConnectionIO.IsClosing = True
            If Settings.Connected Then
                DisconnectToolStripMenuItem_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Settings.Connected AndAlso Settings.SendKeysAndMouse Then
            Dim TH As New Thread(AddressOf SendCommandOrData.SendKeySync)
            TH.Start()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None And Me.WindowState = FormWindowState.Maximized Then
            Desktop.MaterialFlatButton1.Visible = True
            Panel1.BackColor = Color.Black
            ServiceTime_lbl.ForeColor = Color.White
            Desktop_pb.Padding = New Padding(0, 0, 0, 0)
        ElseIf Not Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None And Me.WindowState = FormWindowState.Maximized Then
            FullScreen_btn.Hide()
            Panel1.BackColor = Color.White
            ServiceTime_lbl.ForeColor = Color.Black
            Desktop_pb.Padding = New Padding(50, 0, 50, 0)
        Else
            FullScreen_btn.Show()
            Panel1.BackColor = Color.White
            ServiceTime_lbl.ForeColor = Color.Black
            Desktop.MaterialFlatButton1.Visible = False
            Desktop_pb.Padding = New Padding(50, 0, 50, 0)
        End If
        If Me.WindowState = FormWindowState.Minimized Then
            'Stop the server from keep sending us the desktop, chill out and have a sleep because we are
            If Settings.Connected Then
                Settings.Sleep = True
                SendCommandOrData.SendCommand("SLEEP TRUE")
            End If
            Return
        End If

        If Settings.Connected AndAlso Settings.Sleep Then
            Settings.Sleep = False
            SendCommandOrData.SendCommand("SLEEP FALSE")
        End If
    End Sub

    Public Sub Form1Resize(sender As Object, e As EventArgs)
        Form1_Resize(sender, e)
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        CentreButtonsMenu()
        ChangeChatPanelLocation()
    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        ChangeChatPanelLocation()
    End Sub

    Private Sub CentreButtonsMenu()
        Dim tab As Integer = CurrentScreen_btn.Width + FileTransfer_btn.Width + ScreenRecording_btn.Width + LiveChat_btn.Width + Settings_btn.Width + EndSession_btn.Width + Extra_btn.Width
        Dim x As Integer = (CentreButtonsContainer.Width / 2) - (tab / 2)
        CentreButtonsContainer.Padding = New Padding(x, 0, x, 0)
    End Sub

#Region "FileTransferDragDrop"

    Private Sub Server_DragEnter(sender As System.Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Server_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        FTPSaveDlgVisible = True
        Dim FullFnames() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each SFile As String In FullFnames
            FTPFilenames.Add(SFile)
        Next
        Dim FTPSave As New FTPSaveDialogue
        FTPSave.Show()
    End Sub

#End Region

#End Region

#Region "DesktopScreenMaker"

    Public resolutionX As Integer
    Public resolutionY As Integer
    Private Frame As Integer = 0
    Public DateMTitle As DateTime = DateTime.Now.AddDays(-1)

    Public Sub StartRead()
        'Runs on its own thread and keeps looping to read anything that the server sends us
        Try
            Thread.Sleep(500)
            While Settings.Connected
                Dim TS As TimeSpan = DateTime.Now - DateMTitle
                If TS.TotalSeconds > 15 AndAlso ((LiveChatPanel.Visible = False) OrElse (LiveChatPanel.Visible = True AndAlso LChat.Label2.Text = "❐")) AndAlso FTPSaveDlgVisible = False AndAlso FTPTransferFrmVisible = False Then
                    Me.Invoke(DirectCast(Sub()
                                             Desktop.FocusCmd(True)
                                         End Sub, MethodInvoker))
                End If
                If Settings.SendKeysAndMouse Then
                    SendCommandOrData.SendClipboard()
                End If
                Try
                    Dim inImage As Bitmap = BitmapFromStream(Settings.Encrypted)
                    If inImage Is Nothing Then
                        inImage = BitmapFromStream(Not Settings.Encrypted)
                    End If
                    resolutionX = inImage.Width
                    resolutionY = inImage.Height
                    If resolutionX > 5 AndAlso ((LiveChatPanel.Visible = False) OrElse (LiveChatPanel.Visible = True AndAlso LChat.Label2.Text = "❐")) AndAlso FTPSaveDlgVisible = False AndAlso FTPTransferFrmVisible = False Then
                        RecordScreen(inImage)
                        Desktop.NewImage(inImage)
                        KeepScreenRatio(inImage)
                    End If
                Catch Ex As Exception
                    StartReadErrorHandler()
                End Try
            End While
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RecordScreen(inImage As Bitmap)
        If ScreenRecordCommand = True Then
            If Not Directory.Exists(SRecorder.TempImagesLocation) Then
                Directory.CreateDirectory(SRecorder.TempImagesLocation)
            End If
            inImage.Save(SRecorder.TempImagesLocation & "\" & Frame.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Frame = Frame + 1
        End If
    End Sub

    Private Sub KeepScreenRatio(inImage As Bitmap)
        Desktop.MaintainAspectRatio(inImage)
        AddHandler Me.Resize, AddressOf Desktop.ServerResize
    End Sub

    Private Sub StartReadErrorHandler()
        'This data would not convert to a image so empty the stream if we can 
        If ConnectionIO.IsClosing Then
            Return
        End If
        Dim Data As String = ""
        Dim Count As Integer = 0
        If Not Settings.Connected Then
            Return
        End If

        While ConnectionIO.Tcpclient.Available > 0 AndAlso Count < 10
            Count += 1
            Dim Buffer As Byte() = New Byte(ConnectionIO.Tcpclient.Available - 1) {}
            ConnectionIO.stream.Read(Buffer, 0, Buffer.Length)
            Data += UTF8Encoding.UTF8.GetString(Buffer)
        End While
        Data = Data.Trim()
        'Let the server send more data
        If Settings.SendKeysAndMouse AndAlso Data.Length < 100000 AndAlso Data.Length > 0 Then
            'Looks like clipboard or screen info data so set the local clipboard or set screen sizes
            Dim ClipboardText As String = Helper.XorString(Data, 34, False).Replace("#NL#", Environment.NewLine).Replace("#SQ#", "'")
            If ClipboardText.StartsWith("#CLIPBOARD#") Then
                ConnectionIO.LastClipboardText = ClipboardText.Substring(11)
                ClipboardAsync.SetText(ConnectionIO.LastClipboardText)
            ElseIf ClipboardText.StartsWith("#INFO#") Then
                DScreen.ReadInfo(ClipboardText)
            End If
        End If
    End Sub

    Private Function BitmapFromStream(Encrypted As Boolean) As Bitmap
        'Here we wait for a new screen-shot or clip-board text to come in from the server
        Dim Image As Bitmap = Nothing
        Dim bFormat As New BinaryFormatter()
        Dim MSin As MemoryStream = Nothing
        Try

            If Encrypted Then
                MSin = TryCast(bFormat.Deserialize(ConnectionIO.stream), MemoryStream)
                If MSin Is Nothing OrElse MSin.Length < 200 Then
                    If MSin IsNot Nothing Then
                        Dim Data As String = UTF8Encoding.UTF8.GetString(MSin.ToArray())
                        Dim ClipboardText As String = Helper.XorString(Data.Replace("#NL#", Environment.NewLine), 34, False)
                        If ClipboardText.StartsWith("#CLIPBOARD#") Then
                            'Yes the server sent the clip-board text
                            ConnectionIO.LastClipboardText = ClipboardText.Substring(11)
                            ClipboardAsync.SetText(ConnectionIO.LastClipboardText)
                        ElseIf ClipboardText.StartsWith("#INFO#") Then
                            DScreen.ReadInfo(ClipboardText)
                        End If
                        'Looks like the screen resolution on the server has been changed 
                        Return New Bitmap(1, 1)
                    End If
                End If
                Dim MSout As MemoryStream = DScreen.Decrypt(MSin)
                'Well OK it's not full on encryption
                Image = New Bitmap(MSout)
                Settings.Encrypted = True
            Else
                'Not encrypted so just read the image and if its clip-board text then error trap later will catch it
                Image = TryCast(bFormat.Deserialize(ConnectionIO.stream), Bitmap)
                Settings.Encrypted = False
            End If
            Return Image
        Catch Ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region "Notification"

    Public Sub NewNotification(Message As String)
        Notification.NotifyMessage.Text = Message
        Notification.Show()
    End Sub

#End Region

#Region "TabButtons"

#Region "TabButtonClick"

    Private Sub MainMenu_btn_Click(sender As Object, e As EventArgs) Handles MainMenu_btn.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub FullScreen_btn_Click(sender As Object, e As EventArgs) Handles FullScreen_btn.Click
        If Me.WindowState = FormWindowState.Normal Then
            AllButtonsContainer.Hide()
            Desktop_pb.Padding = New Padding(0, 0, 0, 0)
            Me.MaximumSize = New Size(0, 0)
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub CurrentScreen_btn_Click(sender As Object, e As EventArgs) Handles CurrentScreen_btn.Click
        With Desktop
            Desktop.Dock = DockStyle.Fill
        End With
        Desktop_pb.Controls.Add(Desktop)
        CurrentScreen_btn.BackColor = Color.White
        CurrentScreen_btn.ForeColor = Color.Black
    End Sub

    Private Sub EndSession_btn_Click(sender As Object, e As EventArgs) Handles EndSession_btn.Click
        EndSessionMenu.Show(EndSession_btn, New Point(0, 44))
    End Sub

    Private Sub ScreenRecording_btn_Click(sender As Object, e As EventArgs) Handles ScreenRecording_btn.Click
        SRecordMenu.Show(ScreenRecording_btn, New Point(0, 44))
    End Sub

    Private Sub Extra_btn_Click(sender As Object, e As EventArgs) Handles Extra_btn.Click
        ExtraMenu.Show(Extra_btn, New Point(0, 44))
    End Sub

    Private Sub FileTransfer_btn_Click(sender As Object, e As EventArgs) Handles FileTransfer_btn.Click
        If Not Application.OpenForms.OfType(Of FileTransferFrm).Any Then
            FTPTransferFrmVisible = True
            Dim FileTransfer As New FileTransferFrm
            FileTransfer.Show()
        End If
    End Sub

    Private Sub LiveChat_btn_Click(sender As Object, e As EventArgs) Handles LiveChat_btn.Click
        If LiveChatPanel.Visible Then
            LiveChatPanel.Visible = False
            ControlKeyboardToolStripMenuItem.PerformClick()
        Else
            LiveChatPanel.Visible = True
            Desktop.ChatEnvironmentImg(True)
            ControlKeyboardToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub Complete_btn_Click(sender As Object, e As EventArgs) Handles Complete_btn.Click
        If MessageBox.Show("Is the job successfully completed?", "Comfirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            SqlConn.JobComplete(Computers.JobID)
            Me.Close()
        End If
    End Sub

#End Region

#Region "TabMouseHover"
    Private Sub EndSession_btn_MouseHover(sender As Object, e As EventArgs) Handles EndSession_btn.MouseHover
        TabMouseHover("EndSession_btn", True)
    End Sub

    Private Sub ScreenRecording_btn_MouseHover(sender As Object, e As EventArgs) Handles ScreenRecording_btn.MouseHover
        TabMouseHover("ScreenRecording_btn", True)
    End Sub

    Private Sub Extra_btn_MouseHover(sender As Object, e As EventArgs) Handles Extra_btn.MouseHover
        TabMouseHover("Extra_btn", True)
    End Sub

    Private Sub Settings_btn_MouseHover(sender As Object, e As EventArgs) Handles Settings_btn.MouseHover
        TabMouseHover("Settings_btn", True)
    End Sub

    Private Sub LiveChat_btn_MouseHover(sender As Object, e As EventArgs) Handles LiveChat_btn.MouseHover
        TabMouseHover("LiveChat_btn", True)
    End Sub

    Private Sub FileTransfer_btn_MouseHover(sender As Object, e As EventArgs) Handles FileTransfer_btn.MouseHover
        TabMouseHover("FileTransfer_btn", True)
    End Sub

    Private Sub Complete_btn_MouseHover(sender As Object, e As EventArgs) Handles Complete_btn.MouseHover
        TabMouseHover("Complete_btn", True)
    End Sub

#End Region

#Region "TabMouseLeave"

    Private Sub EndSession_btn_MouseLeave(sender As Object, e As EventArgs) Handles EndSession_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub ScreenRecording_btn_MouseLeave(sender As Object, e As EventArgs) Handles ScreenRecording_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub Extra_btn_MouseLeave(sender As Object, e As EventArgs) Handles Extra_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub Settings_btn_MouseLeave(sender As Object, e As EventArgs) Handles Settings_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub LiveChat_btn_MouseLeave(sender As Object, e As EventArgs) Handles LiveChat_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub FileTransfer_btn_MouseLeave(sender As Object, e As EventArgs) Handles FileTransfer_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

    Private Sub Complete_btn_MouseLeave(sender As Object, e As EventArgs) Handles Complete_btn.MouseLeave
        TabMouseHover(Nothing, False)
    End Sub

#End Region

    Private Sub TabMouseHover(Button As String, Hover As Boolean)
        Dim y As Color = Color.White
        Dim n As Color = Color.Gray
        If Hover Then
            If Button = "Settings_btn" Then
                SelectedButton(y, n, n, n, n, n, n)
            ElseIf Button = "LiveChat_btn" Then
                SelectedButton(n, y, n, n, n, n, n)
            ElseIf Button = "ScreenRecording_btn" Then
                SelectedButton(n, n, y, n, n, n, n)
            ElseIf Button = "FileTransfer_btn" Then
                SelectedButton(n, n, n, y, n, n, n)
            ElseIf Button = "EndSession_btn" Then
                SelectedButton(n, n, n, n, y, n, n)
            ElseIf Button = "Extra_btn" Then
                SelectedButton(n, n, n, n, n, y, n)
            ElseIf Button = "Complete_btn" Then
                SelectedButton(n, n, n, n, n, n, y)
            End If
        Else
            SelectedButton(n, n, n, n, n, n, n)
        End If
    End Sub

    Private Sub SelectedButton(Settings As Color, LiveChat As Color, ScreenRecord As Color, FileTransfer As Color, EndSession As Color, Extra As Color, Complete As Color)
        Settings_btn.BackColor = Settings
        LiveChat_btn.BackColor = LiveChat
        ScreenRecording_btn.BackColor = ScreenRecord
        FileTransfer_btn.BackColor = FileTransfer
        EndSession_btn.BackColor = EndSession
        Extra_btn.BackColor = Extra
        Complete_btn.BackColor = Complete
    End Sub

#End Region

#Region "ContextMenuStrips"

#Region "End Session"

    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        ConnectionIO.Disconnect(Computers.IPAddr, Computers.Port, Computers.Pass)
        ServiceTimeRecord()
        Me.Close()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        ConnectionIO.Shutdown(Computers.IPAddr, Computers.Port, Computers.Pass)
        ServiceTimeRecord()
    End Sub

#End Region

#Region "ExtraMenu"

    Private Sub ShowWindowsStartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowWindowsStartToolStripMenuItem.Click
        SendCommandOrData.SendCommand("SHOWSTART")
        Desktop.FocusCmd(True)
    End Sub

    Public Sub SendWindowsStart(sender As Object, e As EventArgs)
        ShowWindowsStartToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ControlKeyboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlKeyboardToolStripMenuItem.Click
        If ControlKeyboardToolStripMenuItem.Text = "Control Mouse and Keyboard" Then
            Settings.SendKeysAndMouse = True
            ControlKeyboardToolStripMenuItem.Text = "Disable Mouse and Keyboard"
        ElseIf ControlKeyboardToolStripMenuItem.Text = "Disable Mouse and Keyboard" Then
            Settings.SendKeysAndMouse = False
            ControlKeyboardToolStripMenuItem.Text = "Control Mouse and Keyboard"
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        SendCommandOrData.SafeSendValue(My.Computer.Clipboard.GetText)
    End Sub

#End Region

#Region "Screen Recording"

    Private SqlConn As New MySQLStaffConnection
    Private ScreenRecordCommand As Boolean = False

    Private Sub StartRecordingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartRecordingToolStripMenuItem.Click
        If StartRecordingToolStripMenuItem.Text = "Start Recording" Then
            Desktop.Label1.Visible = True
            StartRecordingToolStripMenuItem.Text = "Stop Recording"
            My.Computer.FileSystem.CreateDirectory(SRecorder.TempImagesLocation)
            ScreenRecordCommand = True
            Desktop.FocusCmd(True)
        Else
            Desktop.Label1.Visible = False
            ScreenRecordCommand = False
            StartRecordingToolStripMenuItem.Text = "Start Recording"
            SRecorder.SaveVideo()
        End If
    End Sub

#End Region

#End Region

#Region "Live Chat"

    Public LChat As New LiveChatUC(Computers.IPAddr)
    Private Chat1DefaultHeight As Integer
    Private Chat1DefaultWidth As Integer
    Private ClickCount As Integer = 0
    Private XCo As Integer
    Private Yco As Integer

    Private Sub AddLiveChat()
        With LChat
            .Dock = DockStyle.Fill
        End With
        LiveChatPanel.Size = New Size(LChat.Width, LChat.Height)
        LiveChatPanel.Controls.Add(LChat)
        ChangeChatPanelLocation()
        AddHandler LChat.LocationChanged, AddressOf LPanelLocationChanged
        AddHandler LChat.Label2.Click, AddressOf LChatMinimizeRestoreclick
        AddHandler LChat.Label1.Click, AddressOf LChatCloseclick
    End Sub

    Private Sub LPanelLocationChanged(sender As Object, e As EventArgs)
        ChangeChatPanelLocation()
    End Sub

    Private Sub ChangeChatPanelLocation()
        XCo = ((Me.Width - LChat.Width - 16))
        Yco = ((Me.Height - LChat.Height - 40))
        LiveChatPanel.Location = New Point(XCo, Yco)
    End Sub

    Private Sub LChatCloseclick(sender As Object, e As EventArgs)
        LiveChatPanel.Visible = False
        Settings_btn.BackColor = Color.Gray
        LiveChat_btn.BackColor = Color.Gray
        ScreenRecording_btn.BackColor = Color.Gray
        FileTransfer_btn.BackColor = Color.Gray
        Extra_btn.BackColor = Color.Gray
        EndSession_btn.BackColor = Color.Gray
        'ConnectionIO.theThread = New Thread(New ThreadStart(AddressOf startRead))
        'ConnectionIO.theThread.Start()
        ControlKeyboardToolStripMenuItem.PerformClick()
    End Sub

    Private Sub LChatMinimizeRestoreclick(sender As Object, e As EventArgs)
        ClickCount = ClickCount + 1
        If ClickCount = 1 Then
            Chat1DefaultHeight = LChat.Height
            Chat1DefaultWidth = LChat.Width
        Else
            ClickCount = 0
        End If
        If LChat.Visible = True Then
            If LChat.Label2.Text = "_" Then
                LiveChatPanel.Size = New Size(LChat.Width - 140, 26)
                ChangeChatPanelLocation()
                LChat.Label2.Text = "❐"
                ControlKeyboardToolStripMenuItem.PerformClick()
            Else
                LiveChatPanel.Size = New Size(Chat1DefaultWidth, Chat1DefaultHeight)
                ChangeChatPanelLocation()
                LChat.Label2.Text = "_"
                Desktop.ChatEnvironmentImg(True)
                ControlKeyboardToolStripMenuItem.PerformClick()
            End If
        End If
    End Sub

#End Region

#Region "ServiceTime"

    Private Seconds As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Seconds = Seconds + 1
        Dim STime As TimeSpan = TimeSpan.FromSeconds(Seconds)
        ServiceTime_lbl.Text = STime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub ServiceTimeRecord()
        EndServiceDateTime = DateTime.Now
        Dim Elapsed As TimeSpan = EndServiceDateTime.Subtract(StartServiceDateTime)
        Dim ServiceTimeFormat As String = Elapsed.ToString("hh\:mm\:ss")
        SqlConn.RecordServiceTime(ServiceTimeFormat, EndServiceDateTime.ToString("yyyy-MM-dd HH:mm:ss"), Computers.JobID)
        SqlConn.AddScreenID(Computers.JobID, SqlConn.GetScreenRID)
    End Sub

#End Region

End Class