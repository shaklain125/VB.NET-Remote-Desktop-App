Public Class JobInfoDetails

    Private JID As String
    Private CID As String
    Private DateT As String
    Private MysqlConn As New MySQLStaffConnection
    Private JobProbs As String

    Public Sub New(JobID As String, ClientID As String, DateTime As String)
        InitializeComponent()
        JID = JobID
        CID = ClientID
        DateT = DateTime
    End Sub

    Private Sub JobInfoDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn.Connect()
        MysqlConn.GetJobStatus(JID)
        Dim JobStatus As String = ""
        For Each i As Object In MysqlConn.SQLDS.Tables(0).Rows
            If i.item("JobCompletion") = 1 Then
                JobStatus = "Completed"
            ElseIf i.item("JobDeclined") = 1 Then
                JobStatus = "Declined"
            Else
                JobStatus = "Pending"
            End If
        Next
        Me.Text = "Job ID: " & JID & " -> Status: " & JobStatus
        If JobStatus = "Completed" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            TextBox1.Visible = False
            Button1.Visible = False
            MaterialFlatButton1.Visible = False
            MaterialFlatButton2.Visible = False
        End If
        If JobStatus = "Declined" Then
            TextBox1.Visible = False
            Button1.Visible = False
            MaterialFlatButton1.Enabled = False
            MaterialFlatButton1.BackColor = Color.DarkGray
        End If
        Label2.Text = "Client ID = " & CID
        Label3.Text = "Date/Time = " & DateT
        MysqlConn.GetClientIP(JID)
        Label4.Text = "IP = " & MysqlConn.SQLDS.Tables(0).Rows(0).Item("IPAddress")
        MysqlConn.GetClientEmail(JID)
        Label5.Text = "Email = " & MysqlConn.SQLDS.Tables(0).Rows(0).Item("EmailAddress")
        MysqlConn.GetJobProblems(JID)
        For Each i As Object In MysqlConn.SQLDS.Tables(0).Rows
            JobProbs = i.item("JobProblems")
        Next
        Dim JobProbsList As New ArrayList
        For Each Problem As String In Split(JobProbs, ", ")
            If Not String.IsNullOrEmpty(Problem) OrElse Not String.IsNullOrWhiteSpace(Problem) Then
                JobProbsList.Add(Problem)
            End If
        Next
        For Each Prob As String In JobProbsList
            If Prob.StartsWith("TP/SA") Then
                ListBox1.Items.Add(Prob.Substring(("TP/SA=").Length))
            ElseIf Prob.StartsWith("CP/B") Then
                ListBox2.Items.Add(Prob.Substring(("CP/B=").Length))
            ElseIf Prob.StartsWith("DR/B") Then
                ListBox3.Items.Add(Prob.Substring(("DR/B=").Length))
            ElseIf Prob.StartsWith("CN") Then
                ListBox4.Items.Add(Prob.Substring(("CN=").Length))
            ElseIf Prob.StartsWith("CS/VTM") Then
                ListBox5.Items.Add(Prob.Substring(("CS/VTM=").Length))
            End If
        Next
    End Sub

#Region "DisplayItemOnTextbox"

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Text = ListBox1.SelectedItem
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox2.Text = ListBox2.SelectedItem
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        TextBox2.Text = ListBox3.SelectedItem
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        TextBox2.Text = ListBox4.SelectedItem
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        TextBox2.Text = ListBox5.SelectedItem
    End Sub

#End Region

#Region "Accept/Decline"

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        If MaterialFlatButton1.Enabled = True Then
            MysqlConn.JobApprove(JID)
            Me.Close()
        Else
            MysqlConn.JobReAccept(JID)
            Me.Close()
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim Mail As New SendMailFrm(JID, "Decline")
        Mail.ShowDialog()
        Me.Close()
    End Sub

#End Region

#Region "SendJobDelayNote"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) OrElse Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MysqlConn.SetJobDelayNote(JID, TextBox1.Text)
            MsgBox("Message Sent")
        Else
            MsgBox("Field is empty")
        End If
    End Sub

#End Region

End Class