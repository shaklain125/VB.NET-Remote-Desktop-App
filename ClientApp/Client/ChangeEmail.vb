Public Class ChangeEmail

    Private ClientID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientSettings.MysqlConn.SelectClientRow(TextBox1.Text, True)
        If CheckIfPass(TextBox1.Text) Then
            ClientSettings.MysqlConn.UpdateEmail(TextBox2.Text, ClientSettings.MysqlConn.ClientID)
        Else
            MsgBox("Incorrect Password. Please try again")
        End If
    End Sub

    Private Function CheckIfPass(EnteredPass As String)
        If EnteredPass = ClientSettings.MysqlConn.ClientPassword Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ChangeEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSettings.MysqlConn.Connect()
    End Sub

End Class
