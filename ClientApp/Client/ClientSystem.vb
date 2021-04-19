Public Class ClientSystem

    Public Shared SQLConnection As New MySQLClientConnection
    Private RDCServiceOn As Process() = Process.GetProcessesByName("RDCServiceOn")
    Private ClientSystemService As Process() = Process.GetProcessesByName("Client")
    Public closeForm As Boolean = False
    Private StatusBusy As Boolean = False
    Private ReAccept As Boolean
#Region "Form"

    Private Sub ClientSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SQLConnection.Connect()
        Try
            Settings.LoadIP()
            SQLConnection.UpdateChangedIP(Settings.IPAd)
            Dim IPGrabber As New WebTextGrabber(Nothing)
            Settings.IPAd = IPGrabber.GetIPAddress
            Settings.SaveIP()

            Settings.LoadJobID()
            SQLConnection.SelectJobRow(Settings.JobID, True)
            ReAccept = SQLConnection.JobReAccept
        Catch ex As Exception

        End Try

        If (RDCServiceOn.Length = 1 And ClientSystemService.Length = 1) Or (RDCServiceOn.Length = 1 And ClientSystemService.Length = 2) Then
            StatusBusy = True
            closeForm = False
            Dim NewServer As New ServerFrm
            ShowBusyScreen()
        ElseIf ReAccept = True Then
            StatusBusy = True
            closeForm = False
            Dim NewServer As New ServerFrm
            SQLConnection.ReturnJobReAcceptToDefault(Settings.JobID)
            MsgBox("Technician accepted your job request")
            ShowBusyScreen()
            Me.Close()
        ElseIf RDCServiceOn.Length = 0 And ClientSystemService.Length = 1 Then
            StatusBusy = False
            closeForm = True
            ShowLoginScreen()
        End If
        Timer1.Stop()
    End Sub

    Private Sub ClientSystem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closeForm = False Then
            e.Cancel = True
            Me.Hide()
            Me.ShowInTaskbar = False
        End If
    End Sub

#End Region

#Region "UserControls"

    Private Sub ShowLoginScreen()
        Dim Log As New LogIn
        With Log
            .Dock = DockStyle.Fill
        End With
        Me.Controls.Add(Log)
    End Sub

    Private Sub ShowBusyScreen()
        Me.Controls.Clear()
        Dim ClientQs As New ClientQ1
        With ClientQs
            .Dock = DockStyle.Fill
        End With
        Me.Controls.Add(ClientQs)
    End Sub

#End Region

#Region "BackgroundChecker"

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.WorkerSupportsCancellation = True
        If Not BackgroundWorker1.CancellationPending Then
            Try
                Do
                    Dim RDCService As Process() = Process.GetProcessesByName("RDCServiceOn")
                    Dim RDCServicePath As String = Application.StartupPath & "\RDCServiceOn.exe"
                    If RDCService.Length = 0 And StatusBusy = True Then
                        Process.Start(RDCServicePath)
                    End If
                    If (RDCServiceOn.Length = 1 And ClientSystemService.Length > 2) Then
                        closeForm = True
                        MsgBox("A member of staff is currently repairing your computer. Please Wait until the job is completed.", "Repair process")
                        Me.Close()
                    End If
                Loop
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If
    End Sub

#End Region

#Region "NotifyIconMenu"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click

        If Not Application.OpenForms().OfType(Of LiveChatFrm).Any Then
            LiveChatFrm.Show()
        Else
            If LiveChatFrm.Visible = False Then
                LiveChatFrm.Visible = True
            End If
        End If

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        LiveChatFrm.DisconnectFromServer()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

#End Region

End Class
