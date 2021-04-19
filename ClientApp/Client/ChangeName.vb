Public Class ChangeName

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ClientSettings.MysqlConn.SelectClientRow(ClientJobs.ClientID, True) = True Then
            If CheckIfPass(TextBox3.Text) Then
                Dim ClientID As String = ClientSettings.MysqlConn.ClientID
                CheckIfFNLNEmpty(ClientID)
                ClientSystem.SQLConnection.SelectClientRow(LogIn.AuthUsr, True)
                ClientJobs.WelcomeMessage.Text = ClientSystem.SQLConnection.WelcomeMessage
            Else
                MsgBox("Incorrect Password. Please try again")
            End If
        End If
    End Sub

    Private Sub CheckIfFNLNEmpty(ClientID As String)
        If (String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox1.Text)) AndAlso (Not String.IsNullOrEmpty(TextBox2.Text) OrElse Not String.IsNullOrWhiteSpace(TextBox2.Text)) Then
            ClientSettings.MysqlConn.UpdateLName(TextBox2.Text, ClientID)
            MsgBox("Your last name has been updated successfully")
        ElseIf (String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text)) AndAlso (Not String.IsNullOrEmpty(TextBox1.Text) OrElse Not String.IsNullOrWhiteSpace(TextBox1.Text)) Then
            ClientSettings.MysqlConn.UpdateFName(TextBox1.Text, ClientID)
            MsgBox("Your first name has been updated successfully")
        ElseIf (Not String.IsNullOrEmpty(TextBox1.Text) OrElse Not String.IsNullOrWhiteSpace(TextBox1.Text)) AndAlso (Not String.IsNullOrEmpty(TextBox2.Text) OrElse Not String.IsNullOrWhiteSpace(TextBox2.Text)) Then
            ClientSettings.MysqlConn.UpdateFName(TextBox1.Text, ClientID)
            ClientSettings.MysqlConn.UpdateLName(TextBox2.Text, ClientID)
            MsgBox("Your first name and last name have been updated successfully")
        Else
            MsgBox("First Name and Last Name are empty")
        End If
    End Sub

    Private Function CheckIfPass(EnteredPass As String)
        If EnteredPass = ClientSettings.MysqlConn.ClientPassword Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ChangeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSettings.MysqlConn.Connect()
    End Sub

End Class
