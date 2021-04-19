Imports System.ComponentModel
Imports System.Net
Imports System.IO

Public Class WaitingForReply

    Private MySQLC As New MySQLClientConnection
    Private JobApproved As Boolean
    Private JobDeclined As Boolean
    Private JobReply As Boolean
    Private RDCServiceOnPath As String = Application.StartupPath & "\RDCServiceOn.exe"
    Private Msg As String
    Private PrMsg As String

    Private Sub WaitingForReply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Continue_btn.Visible = False
        TextBox1.Cursor = Cursors.Arrow
        MySQLC.Connect()
        TextBox1.Text = "Waiting for job approval. A member of staff will reply to you shortly."
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Dim JID As String = MySQLC.LookForJobID(JobRequestSender.ClientID, JobRequestSender.SentDateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Do
                MySQLC.SelectJobRow(JID, True)
                JobApproved = MySQLC.JobApproved
                JobDeclined = MySQLC.JobDeclined
                TextBox1.Cursor = Cursors.WaitCursor
                JobDelayNote()
            Loop Until JobApproved Or JobDeclined
            TextBox1.Cursor = Cursors.Arrow
            If JobApproved Then
                Process.Start(RDCServiceOnPath)
                TextBox1.Text = "Your job has been accepted. Waiting for a member of staff to aid with your computer issues. Please keep your machine awake as it enables remote connections."
                Settings.JobID = JID
                Settings.SaveJobID()
                JobReply = True
                Continue_btn.Visible = True
                Timer1.Stop()
            ElseIf JobDeclined Then
                Dim ClientEmail As String = MySQLC.GetClientEmail(JID)
                TextBox1.Text = "Your job has been declined. A mail will be sent on email: " & ClientEmail & " to inform you the possible reasons why the job has been declined." & _
                                 Environment.NewLine & _
                                "Please contact us for more information:" & _
                                 Environment.NewLine & _
                                 "Mobile: xxxxxxxxxx"
                Settings.JobID = JID
                Settings.SaveJobID()
                JobReply = False
                Continue_btn.Visible = True
                Timer1.Stop()
            End If
    End Sub

    Private Sub JobDelayNote()
        Try
            If Not String.IsNullOrEmpty(MySQLC.JobDelayNote) OrElse Not String.IsNullOrWhiteSpace(MySQLC.JobDelayNote) Then
                Msg = MySQLC.JobDelayNote
                If Msg = PrMsg Then
                    Return
                End If
                Dim JobDelayMsg As String = String.Format("[{0}] Message sent by the technician:{1}'{2}'", DateTime.Now, Environment.NewLine(), Msg)
                TextBox2.Text = JobDelayMsg
                PrMsg = Msg
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Continue_btn_Click(sender As Object, e As EventArgs) Handles Continue_btn.Click
        If JobReply = True Then
            ServerFrm.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub


End Class