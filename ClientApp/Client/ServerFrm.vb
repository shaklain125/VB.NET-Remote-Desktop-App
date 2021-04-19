Public Class ServerFrm


    Private JobCompleted As Boolean
    Private MySQLC As New MySQLClientConnection

    Private PortForwarding As New PortForwardService
    Private closeForm As Boolean = False

    Public Sub New()
        InitializeComponent()
        Me.Show()
    End Sub

#Region "Form"

    Private Sub ServerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ServerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closeForm = False Then
            e.Cancel = True
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            ClientSystem.NotifyIcon1.Visible = True
        Else
            Settings.SaveSettings()
            Listener.ListenStop(True)
        End If
    End Sub

#End Region

#Region "Notificaton"

    Public Sub NewNotification(Message As String)
        Notification.NotifyMessage.Text = Message
        Notification.Show()
    End Sub

#End Region

#Region "RDCServiceON"

    Private Function RDCServiceNotRunning()
        Dim RDCServiceOn As Process() = Process.GetProcessesByName("RDCServiceOn")
        If RDCServiceOn.Length = 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseRDCServiceON()
        If RDCServiceNotRunning() = False Then
            For Each proc As Process In Process.GetProcesses
                If proc.ProcessName = "RDCServiceOn" Then
                    Threading.Thread.Sleep(1000)
                    proc.Kill()
                    If Not proc.HasExited Then
                        proc.Kill()
                    End If
                End If
            Next
        End If
    End Sub

#End Region

#Region "PortMapper"

    Private Function PortMapperNotRunning()
        Dim p() As Process = Process.GetProcessesByName("cmd")
        If p.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "Job completion check"

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.WorkerSupportsCancellation = True
        If BackgroundWorker1.CancellationPending = False Then
            Try
                Do
                    MySQLC.SelectJobRow(Settings.JobID, True)
                    JobCompleted = MySQLC.JobCompleted
                Loop Until JobCompleted
                If JobCompleted Then
                    [Exit]("Session Complete")
                End If
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If
    End Sub

#End Region

    Public Sub [Exit](NotificationMSG As String)
        NewNotification(NotificationMSG)
        closeForm = True
        My.Computer.FileSystem.RenameFile(Application.StartupPath & "\RDCServiceOn.exe", "rdcso.exe")
        CloseRDCServiceON()
        Me.Close()
        ClientSystem.closeForm = True
        ClientSystem.Close()
        LiveChatFrm.DisconnectFromServer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MySQLC.Connect()
        PortForwarding.Port = 4000
        PortForwarding.OpenPort()
        PortForwarding.Port = 3818
        PortForwarding.OpenPort()

        Do
            If PortMapperNotRunning() = True Then
                Exit Do
            Else
                Continue Do
            End If
        Loop
        Settings.DebugPrint.Dock = DockStyle.Fill
        Panel1.Controls.Add(Settings.DebugPrint)
        Text = Settings.MainProgramName
        Listener.ImgWinbackground = ImgWinbackground.Image
        Wallpaper.SaveWallpaper()
        Settings.LoadSettings()
        Settings.LoadJobID()
        Settings.FormService = Me
        Dim IPGrabber As New WebTextGrabber(Nothing)
        Settings.IPAd = IPGrabber.GetIPAddress
        Settings.SaveIP()
        Listener.ListenStart()
        NewNotification("Session Started")
        Timer2.Stop()

        If Not Application.OpenForms().OfType(Of LiveChatFrm).Any Then
            LiveChatFrm.Show()
        Else
            If LiveChatFrm.Visible = False Then
                LiveChatFrm.Visible = True
            End If
        End If

        Control.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

End Class