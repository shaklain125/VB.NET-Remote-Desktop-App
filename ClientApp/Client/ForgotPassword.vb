Public Class ForgotPassword

    Private Mail As New MailSender
    Private MysqlConn As New MySQLClientConnection

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Enabled = False
            If CheckClientExsts() Then
                Dim FirstName As String = MysqlConn.FirstName
                Dim Password As String = MysqlConn.ClientPassword
                ForgottenPasswordMail(TextBox1.Text, FirstName, Password)
                MsgBox("Please check your mail for an incoming message concerning password recovery")
                Me.Close()
            Else
                MsgBox("Email Not Found")
                TextBox1.Enabled = True
            End If
        End If
    End Sub

    Private Function CheckClientExsts() As Boolean
        If MysqlConn.SelectClientRow(TextBox1.Text, True) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ForgottenPasswordMail(Email As String, FirstName As String, Password As String)
        Mail.ToEmail(Email)
        Mail.SetSubject("Account Information")
        Mail.AppendBodyLine("Hello " & FirstName & ",")
        Mail.AddEmptyLine()
        Mail.AddNewBodyLine("Regarding your forgotten passowrd we have sent the following information for your assisstance.")
        Mail.AddEmptyLine()
        Mail.AddNewBodyLine("Password: " & Password)
        Mail.AddEmptyLine()
        Mail.AddNewBodyLine("Sincerely,")
        Mail.AddEmptyLine()
        Mail.AddNewBodyLine("RDC Support")
        Mail.SendMail()
    End Sub

End Class