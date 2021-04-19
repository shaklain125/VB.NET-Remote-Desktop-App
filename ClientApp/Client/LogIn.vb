Public Class LogIn

    Public Shared AuthUsr As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSystem.SQLConnection.Connect()
        Label5.Visible = False
        If ClientSystem.SQLConnection.MySQLConnectionState = True Then
            Label5.Visible = True
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
        Else
            Label5.Visible = True
            Label5.Text = "Not connected"
            Label5.ForeColor = Color.Red
        End If
    End Sub

    Private Function IsAuthenticated() As Boolean
        If ClientSystem.SQLConnection.LogIn(tb_IDorEmail.Text, tb_password.Text) = True Then
            Return True
        Else
            MsgBox("Invalid user credentials.", MsgBoxStyle.Critical, "Log In Failed")
            Return False
        End If
    End Function

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If IsAuthenticated() = True Then
            MsgBox("Success")
            AuthUsr = tb_IDorEmail.Text
            Dim IPGrabber As New WebTextGrabber(Nothing)
            Settings.IPAd = IPGrabber.GetIPAddress
            Settings.SaveIP()
            ClientJobs.Show()
            FindForm.Close()
        End If
    End Sub

    Private Sub lbl_SignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_SignUp.LinkClicked
        ClientSign_up.Show()
        FindForm.Close()
    End Sub

    Private Sub tb_password_TextChanged(sender As Object, e As EventArgs) Handles tb_password.TextChanged
        FindForm.AcceptButton = btn_LogIn
    End Sub

    Private Sub lbl_ForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_ForgotPass.LinkClicked
        ForgotPassword.ShowDialog()
    End Sub

End Class
