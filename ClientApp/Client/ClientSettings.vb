Public Class ClientSettings

    Dim storedx As Integer
    Dim storedy As Integer

    Private SelectedButton As Color = Color.DimGray
    Private UnselectedButton As Color = Color.Gray

    Public Shared MysqlConn As New MySQLClientConnection

    'Side Menu buttons
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        DisplayInfo1.ShowOverview()
        OverviewButtonSelected()
        Label1.Text = "Overview"
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        DisplayInfo1.ShowChangeEmail()
        EmailButtonSelected()
        Label1.Text = "E-Mail"
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        DisplayInfo1.ShowChangePass()
        PasswordButtonSelected()
        Label1.Text = "Password"
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        DisplayInfo1.ShowChangeName()
        FullNameButtonSelected()
        Label1.Text = "Full Name"
    End Sub

    Private Sub OverviewButtonSelected()
        MaterialFlatButton1.BackColor = SelectedButton
        MaterialFlatButton2.BackColor = UnselectedButton
        MaterialFlatButton3.BackColor = UnselectedButton
        MaterialFlatButton4.BackColor = UnselectedButton
    End Sub

    Private Sub EmailButtonSelected()
        MaterialFlatButton1.BackColor = UnselectedButton
        MaterialFlatButton2.BackColor = SelectedButton
        MaterialFlatButton3.BackColor = UnselectedButton
        MaterialFlatButton4.BackColor = UnselectedButton
    End Sub

    Private Sub PasswordButtonSelected()
        MaterialFlatButton1.BackColor = UnselectedButton
        MaterialFlatButton2.BackColor = UnselectedButton
        MaterialFlatButton3.BackColor = SelectedButton
        MaterialFlatButton4.BackColor = UnselectedButton
    End Sub

    Private Sub FullNameButtonSelected()
        MaterialFlatButton1.BackColor = UnselectedButton
        MaterialFlatButton2.BackColor = UnselectedButton
        MaterialFlatButton3.BackColor = UnselectedButton
        MaterialFlatButton4.BackColor = SelectedButton
    End Sub

    'Enabling Drag on Form
    Private Sub ClientSettingsTitle_Paint(sender As Object, e As MouseEventArgs) Handles ClientSettingsTitle.MouseDown
        storedx = e.X
        storedy = e.Y
    End Sub

    Private Sub ClientSettingsTitle_Paint1(sender As Object, e As MouseEventArgs) Handles ClientSettingsTitle.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = e.X - storedx + Me.Left
            Me.Top = e.Y - storedy + Me.Top
        End If
    End Sub

    Private Sub ControlBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ControlBox1.MouseDown
        storedx = e.X
        storedy = e.Y
    End Sub

    Private Sub ControlBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ControlBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = e.X - storedx + Me.Left
            Me.Top = e.Y - storedy + Me.Top
        End If
    End Sub

    '
    Private Sub ClientSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSystem.SQLConnection.Connect()
        MaterialFlatButton1.PerformClick()
    End Sub

End Class