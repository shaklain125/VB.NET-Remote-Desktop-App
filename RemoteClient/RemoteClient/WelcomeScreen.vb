Public Class WelcomeScreen

    Public SQLConnection As New MySQLStaffConnection
    Public Shared AuthUsr As String
    Public Shared StaffManagement As Boolean

    Private Sub StaffSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Application.OpenForms().OfType(Of Dashboard).Any Then
                Dashboard.Close()
            End If
        Catch ex As Exception

        End Try
        SQLConnection.Connect()
        If SQLConnection.MySQLConnectionState = True Then
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
        Else
            Label5.Text = "Not connected"
            Label5.ForeColor = Color.Red
        End If
        'btn_LogIn.PerformClick()
    End Sub

    Private Function IsAuthenticated() As Boolean
        If SQLConnection.LogIn(tb_IDorEmail.Text, tb_password.Text) = True Then
            Return True
        Else
            MsgBox("Invalid user credentials.", MsgBoxStyle.Critical, "Log In Failed")
            Return False
        End If
        Return False
    End Function

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Me.Cursor = Cursors.WaitCursor
        If IsAuthenticated() = True Then
            SQLConnection.SelectStaffRow(tb_IDorEmail.Text, True)
            If SQLConnection.StaffIsAdmin = True Then
                Dashboard.ScreenRecord_btn.Visible = True
                StaffManagement = True
            Else
                Dashboard.ScreenRecord_btn.Visible = False
                StaffManagement = False
            End If
            AuthUsr = tb_IDorEmail.Text
            LoadingScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lbl_SignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_SignUp.LinkClicked
        StaffSignUp.Show()
        Me.Close()
    End Sub

    Private Sub tb_password_TextChanged(sender As Object, e As EventArgs) Handles tb_password.TextChanged
        AcceptButton = btn_LogIn
    End Sub

    Private Sub lbl_ForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_ForgotPass.LinkClicked
        MsgBox("Please contact the program's administrator")
    End Sub

End Class