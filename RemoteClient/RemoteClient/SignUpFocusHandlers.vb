Public Class SignUpFocusHandlers

    Public Shared Sub tb_FirstName_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckCharFirstName()
    End Sub

    Public Shared Sub tb_FirstName_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.BackColor = Color.White
        StaffSignUp.tb_FirstName.ForeColor = Color.Black
        StaffSignUp.Label9.Text = ""
    End Sub


    Public Shared Sub tb_LastName_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckCharLastName()
    End Sub

    Public Shared Sub tb_LastName_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_LastName.BackColor = Color.White
        StaffSignUp.tb_LastName.ForeColor = Color.Black
        StaffSignUp.Label10.Text = ""
    End Sub


    Public Shared Sub tb_Email_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckEmail()
    End Sub

    Public Shared Sub tb_Email_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_Email.BackColor = Color.White
        StaffSignUp.tb_Email.ForeColor = Color.Black
        StaffSignUp.cb_MailService.BackColor = Color.White
        StaffSignUp.cb_MailService.ForeColor = Color.Black
        StaffSignUp.Label11.Text = ""
    End Sub


    Public Shared Sub cb_MailService_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckEmail()
    End Sub

    Public Shared Sub cb_MailService_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_Email.BackColor = Color.White
        StaffSignUp.tb_Email.ForeColor = Color.Black
        StaffSignUp.cb_MailService.BackColor = Color.White
        StaffSignUp.cb_MailService.ForeColor = Color.Black
        StaffSignUp.Label11.Text = ""
    End Sub


    Public Shared Sub tb_MobileNo_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckMobileNumbber()
    End Sub

    Public Shared Sub tb_MobileNo_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_MobileNo.BackColor = Color.White
        StaffSignUp.tb_MobileNo.ForeColor = Color.Black
        StaffSignUp.Label12.Text = ""
    End Sub


    Public Shared Sub tb_Password_LostFocus(sender As Object, e As EventArgs)
        SignUpCheck.CheckPasswordStrength()
    End Sub

    Public Shared Sub tb_Password_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_Password.BackColor = Color.White
        StaffSignUp.tb_Password.ForeColor = Color.Black
        StaffSignUp.Label13.Text = ""
    End Sub


    Public Shared Sub tb_re_enterPass_LostFocus(sender As Object, e As EventArgs)
        If SignUpCheck.CheckPasswordSecondAttempt() = True Then
            If StaffSignUp.tb_Password.Text.Trim.Length = 0 And StaffSignUp.tb_re_enterPass.Text.Trim.Length = 0 Then
                StaffSignUp.Label14.Text = "Empty field"
                StaffSignUp.tb_re_enterPass.BackColor = Color.LightGray
            Else
                StaffSignUp.Label14.Text = "Passwords match: Yes"
                StaffSignUp.tb_re_enterPass.BackColor = Color.LightGreen
            End If
        Else
            StaffSignUp.Label14.Text = "Passwords match: No"
            StaffSignUp.tb_re_enterPass.BackColor = Color.Red
        End If
    End Sub

    Public Shared Sub tb_re_enterPass_OnFocus(sender As Object, e As EventArgs)
        StaffSignUp.tb_re_enterPass.BackColor = Color.White
        StaffSignUp.tb_re_enterPass.ForeColor = Color.Black
        StaffSignUp.Label14.Text = ""
    End Sub

End Class
