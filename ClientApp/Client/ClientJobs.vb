Public Class ClientJobs

    Public Shared ClientID As String
    Private SendJob As New JobRequestSender
    Private GetIPAddr As WebTextGrabber
    Private Send As Boolean

#Region "Form"

    Private Sub ClientJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSystem.SQLConnection.Connect()
        Control.CheckForIllegalCrossThreadCalls = False
        ClientSystem.SQLConnection.SelectClientRow(LogIn.AuthUsr, True)
        ClientID = ClientSystem.SQLConnection.ClientID
        WelcomeMessage.Text = ClientSystem.SQLConnection.WelcomeMessage
        BackgroundWorker1.RunWorkerAsync()
    End Sub

#End Region

#Region "ClientSettingsOpen"

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        ClientSettings.Show()
    End Sub

#End Region

#Region "Check Job"

    Private Sub CheckANDSetInfo()

        Dim ButtonSelect As Boolean = False
        Send = True
        For Each ButtonSelected As MaterialFlatButton In TableLayoutPanel3.Controls
            If ButtonSelected.BackColor = Color.Gray Then
                ButtonSelect = True
                Exit For
            Else
                ButtonSelect = False
            End If
        Next

        If (ComboBox1.SelectedItem IsNot Nothing) AndAlso Not (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox1.Text)) Then
            SendJob.ExtraJobTitle = ComboBox1.SelectedItem.ToString
            SendJob.ExtraJobProblems = TextBox1.Text
        ElseIf (ComboBox1.SelectedItem IsNot Nothing) AndAlso (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox1.Text)) Then
            MsgBox("Please enter you issue in detail")
            Send = False
            Exit Sub
        ElseIf (ComboBox1.SelectedItem = Nothing) AndAlso Not (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox1.Text)) Then
            MsgBox("Please pick a category of your issue")
            Send = False
            Exit Sub
        Else
            If ButtonSelect = False Then
                MsgBox("Please select an issue from the list or enter manually on the text field")
                Send = False
                Exit Sub
            End If
        End If

        For Each Button As MaterialFlatButton In TableLayoutPanel3.Controls
            If Button.BackColor = Color.Gray And Button.Location.X + 1 = MaterialFlatButton1.Location.X Then
                SendJob.JobProblems = SendJob.JobProblems & "TP/SA=" & Button.Text & ", "
            ElseIf Button.BackColor = Color.Gray And Button.Location.X + 1 = MaterialFlatButton2.Location.X Then
                SendJob.JobProblems = SendJob.JobProblems & "CP/B=" & Button.Text & ", "
            ElseIf Button.BackColor = Color.Gray And Button.Location.X + 1 = MaterialFlatButton3.Location.X Then
                SendJob.JobProblems = SendJob.JobProblems & "DR/B=" & Button.Text & ", "
            ElseIf Button.BackColor = Color.Gray And Button.Location.X + 1 = MaterialFlatButton4.Location.X Then
                SendJob.JobProblems = SendJob.JobProblems & "CN=" & Button.Text & ", "
            ElseIf Button.BackColor = Color.Gray And Button.Location.X + 1 = MaterialFlatButton5.Location.X Then
                SendJob.JobProblems = SendJob.JobProblems & "CS/VTM=" & Button.Text & ", "
            End If
        Next

        SendJob.JobProblems = SendJob.JobProblems.Replace("'", "\'")
        SendJob.JobProblems = SendJob.JobProblems.TrimEnd
        SendJob.JobProblems = SendJob.JobProblems.TrimEnd(",")

    End Sub

#End Region

#Region "Send Job"

    Private Sub MaterialFlatButton31_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton31.Click
        CheckANDSetInfo()
        If Send = True Then
            Try
                Dim IPGrabber As New WebTextGrabber(Nothing)
                Settings.IPAd = IPGrabber.GetIPAddress
                Settings.SaveIP()
                SendJob.Send()
                MsgBox("Sent Successfully")
            Catch ex As Exception
                'SendJob.JobTitle = ""
                SendJob.JobProblems = ""
                SendJob.ExtraJobTitle = ""
                SendJob.ExtraJobProblems = ""
                MsgBox("Server is currently offline")
                Exit Sub
            End Try
            WaitingForReply.Show()
            Me.Close()
        End If
    End Sub

#End Region

#Region "CheckForOtherProcesses"

    Dim nProcessID As Integer = Process.GetCurrentProcess().Id

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.WorkerSupportsCancellation = True
        If Not BackgroundWorker1.CancellationPending Then
            Try
                Do
                    For Each p As Process In Process.GetProcesses
                        If p.ProcessName = "Client" And Not p.Id = nProcessID Then
                            Threading.Thread.Sleep(1000)
                            p.Kill()
                            If Not p.HasExited Then
                                p.Kill()
                            End If
                        End If
                    Next
                Loop
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If
    End Sub

#End Region

End Class