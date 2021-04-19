Public Class SignUpKeysHandlers

    Public Shared ReadOnly FNLNValidChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public Shared ReadOnly EmailValidChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ._-1234567890"
    Public Shared ReadOnly PhoneNumberValidChars As String = "+1234567890"

    Public Shared Sub tb_FirstName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                StaffSignUp.tb_LastName.Focus()
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) FNLNValidChars.Contains(c))
            Case Else
                e.Handled = Not FNLNValidChars.Contains(e.KeyChar)
        End Select
    End Sub

    Public Shared Sub tb_LastName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                StaffSignUp.tb_Email.Focus()
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) FNLNValidChars.Contains(c))
            Case Else
                e.Handled = Not FNLNValidChars.Contains(e.KeyChar)
        End Select
    End Sub

    Public Shared Sub tb_Email_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                StaffSignUp.cb_MailService.Focus()
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) EmailValidChars.Contains(c))
            Case Else
                e.Handled = Not EmailValidChars.Contains(e.KeyChar)
        End Select
    End Sub

    Public Shared Sub cb_MailService_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                StaffSignUp.tb_MobileNo.Focus()
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) EmailValidChars.Contains(c))
            Case Else
                e.Handled = Not EmailValidChars.Contains(e.KeyChar)
        End Select
    End Sub

    Public Shared Sub tb_MobileNo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                StaffSignUp.tb_Password.Focus()
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) PhoneNumberValidChars.Contains(c))
            Case Else
                e.Handled = Not PhoneNumberValidChars.Contains(e.KeyChar)
        End Select
    End Sub

    Public Shared Sub tb_password_keydown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Enter Then
            StaffSignUp.tb_re_enterPass.Focus()
        End If
    End Sub

End Class
