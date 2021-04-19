Public Class Notification


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 15
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Timer1.Start()
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        CloseNotify.Close()
        System.Threading.Thread.Sleep(10)
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 15
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width
            x = x + 1
            Me.Location = New Point(x, y)
        Loop
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.Gray
        CloseNotify.Show()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.White
        CloseNotify.Close()
    End Sub

    Dim count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 30 Then
            Timer1.Stop()

            Me.Close()
        End If
    End Sub
End Class