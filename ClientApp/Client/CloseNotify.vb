Public Class CloseNotify

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(65, 28)
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 1
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Do Until y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 75
            y = y - 1
            Me.Location = New Point(x, y)
        Loop
    End Sub

End Class