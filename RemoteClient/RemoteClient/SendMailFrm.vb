Public Class SendMailFrm

    Private MySQLConn As New MySQLStaffConnection
    Private ClientEmail As String
    Private ClientId As String
    Private MSender As New MailSender
    Private PurposeMail As String
    Private JID As String

    Public Sub New(JobID As String, Purpose As String)
        InitializeComponent()
        MySQLConn.Connect()
        PurposeMail = Purpose
        JID = JobID
        Me.Text = String.Format("JobID > {0}", JobID)
        ClientEmail = MySQLConn.GetClientEmail(JobID)
        ClientId = MySQLConn.GetClientID(JobID)
        MySQLConn.SelectClientRow(ClientId, True)
        Label2.Text = String.Format("{0} {1} <<'{2}'>>", MySQLConn.ClientFirstName, MySQLConn.ClientLastName, ClientEmail)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("Please fill in the subject area.")
        ElseIf String.IsNullOrEmpty(RichTextBox1.Text) OrElse String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
            MsgBox("Please fill in the body area.")
        ElseIf String.IsNullOrEmpty(RichTextBox1.Text) OrElse String.IsNullOrWhiteSpace(RichTextBox1.Text) AndAlso _
            String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("All fields are empty")
        Else
            MSender.ToEmail(ClientEmail)
            MSender.SetSubject(TextBox2.Text)
            MSender.SetBodyOnly(RichTextBox1.Text)
            MSender.SendMail()
            If PurposeMail = "Decline" Then
                MySQLConn.JobDecline(JID)
            End If
            MySQLConn.SetStafftoClient(JID)
            MsgBox("Mail sent successfully")
            Me.Close()
        End If
    End Sub

End Class