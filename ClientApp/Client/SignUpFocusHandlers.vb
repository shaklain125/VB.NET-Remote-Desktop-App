Public Class SignUpFocusHandlers

    Public Shared Sub tb_FirstName_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckCharFirstName()
    End Sub

    Public Shared Sub tb_FirstName_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.BackColor = Color.White
        ClientSign_up.tb_FirstName.ForeColor = Color.Black
        ClientSign_up.Label9.Text = ""
    End Sub


    Public Shared Sub tb_LastName_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckCharLastName()
    End Sub

    Public Shared Sub tb_LastName_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_LastName.BackColor = Color.White
        ClientSign_up.tb_LastName.ForeColor = Color.Black
        ClientSign_up.Label10.Text = ""
    End Sub


    Public Shared Sub tb_Email_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckEmail()
    End Sub

    Public Shared Sub tb_Email_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_Email.BackColor = Color.White
        ClientSign_up.tb_Email.ForeColor = Color.Black
        ClientSign_up.cb_MailService.BackColor = Color.White
        ClientSign_up.cb_MailService.ForeColor = Color.Black
        ClientSign_up.Label11.Text = ""
    End Sub


    Public Shared Sub cb_MailService_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckEmail()
    End Sub

    Public Shared Sub cb_MailService_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_Email.BackColor = Color.White
        ClientSign_up.tb_Email.ForeColor = Color.Black
        ClientSign_up.cb_MailService.BackColor = Color.White
        ClientSign_up.cb_MailService.ForeColor = Color.Black
        ClientSign_up.Label11.Text = ""
    End Sub


    Public Shared Sub tb_MobileNo_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckMobileNumbber()
    End Sub

    Public Shared Sub tb_MobileNo_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_MobileNo.BackColor = Color.White
        ClientSign_up.tb_MobileNo.ForeColor = Color.Black
        ClientSign_up.Label12.Text = ""
    End Sub


    Public Shared Sub tb_Password_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckPasswordStrength()
    End Sub

    Public Shared Sub tb_Password_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_Password.BackColor = Color.White
        ClientSign_up.tb_Password.ForeColor = Color.Black
        ClientSign_up.Label13.Text = ""
    End Sub


    Public Shared Sub tb_re_enterPass_LostFocus(sender As Object, e As EventArgs)
        If SignUpCheck.CheckPasswordSecondAttempt() = True Then
            If ClientSign_up.tb_Password.Text.Trim.Length = 0 And ClientSign_up.tb_re_enterPass.Text.Trim.Length = 0 Then
                ClientSign_up.Label14.Text = "Empty field"
                ClientSign_up.tb_re_enterPass.BackColor = Color.LightGray
            Else
                ClientSign_up.Label14.Text = "Passwords match: Yes"
                ClientSign_up.tb_re_enterPass.BackColor = Color.LightGreen
            End If
        Else
            ClientSign_up.Label14.Text = "Passwords match: No"
            ClientSign_up.tb_re_enterPass.BackColor = Color.Red
        End If
    End Sub

    Public Shared Sub tb_re_enterPass_OnFocus(sender As Object, e As EventArgs)
        ClientSign_up.tb_re_enterPass.BackColor = Color.White
        ClientSign_up.tb_re_enterPass.ForeColor = Color.Black
        ClientSign_up.Label14.Text = ""
    End Sub

End Class
