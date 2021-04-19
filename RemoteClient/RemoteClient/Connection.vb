Imports System.IO
Imports System.Threading
Imports System.Net.Sockets
Imports System.Text
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Connection

    Public IsClosing As Boolean = False
    Public stream As Stream
    Public eventSender As StreamWriter
    Public theThread As Thread
    Public Tcpclient As TcpClient
    Public FirstConnect As Boolean = True
    Public LastClipboardText As String = ""

    Public Sub Connect(IPAddress As String, PortNumber As String, Password As String)
        If FirstConnect Then
            FirstConnect = False
        End If
        RunConnect(IPAddress, PortNumber, Password)
    End Sub

    Private Sub RunConnect(IPAddress As String, PortNumber As String, Password As String)
        Try

            Tcpclient = New TcpClient(IPAddress, Integer.Parse(PortNumber))

            Dim S As Stream = Tcpclient.GetStream()
            Dim SW As New StreamWriter(S)

            Server.Text = IPAddress & ":" & PortNumber

            SW.Write(Helper.XorString("CMD PASSWORD " & Password.Trim(), 45, True) & vbLf)
            SW.Flush()

            Settings.PassWord = Password.Trim()

            Dim Buffer As Byte() = New Byte(1023) {}
            Dim Size As Integer = S.Read(Buffer, 0, Buffer.Length)
            Dim Msg As String = ASCIIEncoding.ASCII.GetString(Buffer, 0, Size).Replace("X=", "").Replace("Y=", "")
            Dim FirstConnect As Boolean = Boolean.Parse(Msg.Split(" "c)(4))

            Settings.ScreenServerX = Integer.Parse(Msg.Split(" "c)(0))
            Settings.ScreenServerY = Integer.Parse(Msg.Split(" "c)(1))
            Settings.ScreenClientX = Integer.Parse(Msg.Split(" "c)(2))
            Settings.ScreenClientY = Integer.Parse(Msg.Split(" "c)(3))

            SW.Write(Helper.XorString("SCREEN " & Settings.ScreenServerX & " " & Settings.ScreenServerY, 45, True) & vbLf)
            SW.Flush()

            Dim Text As String = ClipboardAsync.GetText()
            LastClipboardText = Text
            stream = Tcpclient.GetStream()

            BeginScreenSharing()

        Catch problem As Exception
            MessageBox.Show("Invalid IPAddress, Invalid Port, Failed Internet Connection, or Cannot connect to client for some reason, check firewall in windows and router." & vbLf & vbLf & "Technical Data:" & vbLf & "**************************************************" & vbLf & problem.ToString(), "You're a Failure!")
        End Try

    End Sub

    Private Sub BeginScreenSharing()

        Server.Desktop.tbl_ConnStatus.Visible = False
        Settings.Connected = True
        Server.NewNotification("Session Started")
        eventSender = New StreamWriter(stream)
        theThread = New Thread(New ThreadStart(AddressOf Server.startRead))
        theThread.Start()
        Server.SendCommandOrData.SendDefaults(FirstConnect)
        Server.Desktop.FocusCmd(True)
        Server.StartServiceDateTime = DateTime.Now
        Server.Timer1.Start()

    End Sub

    Public Sub Disconnect(IPAddress As String, PortNumber As String, Password As String)
        If Notification.WindowState = FormWindowState.Normal Then
            Notification.Close()
            Thread.Sleep(1)
            Server.NewNotification("Session Stopped")
        End If
        RunDisconnect(IPAddress, PortNumber, Password)
    End Sub

    Private Sub RunDisconnect(IPAddress As String, PortNumber As String, Password As String)
        Server.Cursor = Cursors.[Default]
        Server.Text = "Remote Client"
        Password = Settings.PassWord
        Server.SendCommandOrData.SendCommand("CLOSE")
        Settings.Connected = False
        Tcpclient.Close()
        If theThread IsNot Nothing AndAlso theThread.IsAlive Then
            theThread.Abort()
        End If
        Server.Desktop.tbl_ConnStatus.Visible = True
        theThread = Nothing
        Server.Form1Resize(Nothing, Nothing)
    End Sub

    Public Sub Shutdown(IPAddress As String, PortNumber As String, Password As String)
        Dim reallyShutdown As DialogResult = MessageBox.Show("!! WARNING !!" & vbLf & vbLf & "Shutting down the server will leave you unable to reconnect until " & "the computer restarts (IF The server is set to run on Startup). You will be unable " & "to reconnect until this occurs." & vbLf & vbLf & "ARE YOU SURE YOU WANT TO SHUTDOWN THE SERVER?", "!! WARNING !!", MessageBoxButtons.YesNo)
        If reallyShutdown = DialogResult.Yes Then
            Server.SendCommandOrData.sendShutdown()
            Disconnect(IPAddress, PortNumber, Password)
            Server.NewNotification("Session Ended")
        End If
    End Sub

End Class
