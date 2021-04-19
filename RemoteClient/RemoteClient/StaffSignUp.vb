Public Class StaffSignUp

    Public SQLConnection As New MySQLStaffConnection

    Private Sub StaffSign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLConnection.Connect()
        FocusHandlers()
        KeysHandlers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SignUpCheck.CheckAllcompleted() = True Then
            MsgBox(SignUpCheck.CheckStaffExsts)
            If SignUpCheck.CheckStaffExsts() = True Then
                MsgBox("Cannot sign up as an account was allready registered")
            Else
                AddStaff()
                MsgBox("You have successfully become a Staff")
                WelcomeScreen.AuthUsr = tb_Email.Text & "@" & cb_MailService.Text
                Dashboard.Show()
            End If
        Else
            MsgBox("Not fully completed")
            tb_FirstName.Focus()
            tb_LastName.Focus()
            cb_MailService.Focus()
            tb_Email.Focus()
            tb_MobileNo.Focus()
            tb_Password.Focus()
            tb_re_enterPass.Focus()
            Button1.Focus()
        End If

    End Sub

    Public Sub AddStaff()
        SQLConnection.AddStaff(tb_FirstName.Text, tb_LastName.Text, tb_Email.Text, cb_MailService.Text, tb_MobileNo.Text, tb_Password.Text)
    End Sub

    Private Sub FocusHandlers()

        AddHandler tb_FirstName.GotFocus, AddressOf SignUpFocusHandlers.tb_FirstName_OnFocus
        AddHandler tb_FirstName.LostFocus, AddressOf SignUpFocusHandlers.tb_FirstName_LostFocus

        AddHandler tb_LastName.GotFocus, AddressOf SignUpFocusHandlers.tb_LastName_OnFocus
        AddHandler tb_LastName.LostFocus, AddressOf SignUpFocusHandlers.tb_LastName_LostFocus

        AddHandler tb_Email.GotFocus, AddressOf SignUpFocusHandlers.tb_Email_OnFocus
        AddHandler tb_Email.LostFocus, AddressOf SignUpFocusHandlers.tb_Email_LostFocus

        AddHandler cb_MailService.GotFocus, AddressOf SignUpFocusHandlers.cb_MailService_OnFocus
        AddHandler cb_MailService.LostFocus, AddressOf SignUpFocusHandlers.cb_MailService_LostFocus

        AddHandler tb_MobileNo.GotFocus, AddressOf SignUpFocusHandlers.tb_MobileNo_OnFocus
        AddHandler tb_MobileNo.LostFocus, AddressOf SignUpFocusHandlers.tb_MobileNo_LostFocus

        AddHandler tb_Password.GotFocus, AddressOf SignUpFocusHandlers.tb_Password_OnFocus
        AddHandler tb_Password.LostFocus, AddressOf SignUpFocusHandlers.tb_Password_LostFocus

        AddHandler tb_re_enterPass.GotFocus, AddressOf SignUpFocusHandlers.tb_re_enterPass_OnFocus
        AddHandler tb_re_enterPass.LostFocus, AddressOf SignUpFocusHandlers.tb_re_enterPass_LostFocus

    End Sub

    Private Sub KeysHandlers()
        AddHandler tb_FirstName.KeyPress, AddressOf SignUpKeysHandlers.tb_FirstName_KeyPress
        AddHandler tb_LastName.KeyPress, AddressOf SignUpKeysHandlers.tb_LastName_KeyPress
        AddHandler tb_Email.KeyPress, AddressOf SignUpKeysHandlers.tb_Email_KeyPress
        AddHandler cb_MailService.KeyPress, AddressOf SignUpKeysHandlers.cb_MailService_KeyPress
        AddHandler tb_MobileNo.KeyPress, AddressOf SignUpKeysHandlers.tb_MobileNo_KeyPress
        AddHandler tb_Password.KeyDown, AddressOf SignUpKeysHandlers.tb_password_keydown
    End Sub

End Class