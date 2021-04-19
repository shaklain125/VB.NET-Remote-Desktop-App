Public Class LoadingScreen


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width = RectangleShape2.Width + 5
        If RectangleShape2.Width = 345 And Dashboard.Loaded Then
            Dashboard.NormalWindow()
            Me.Close()
        End If
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard.Show()
        RectangleShape2.Width = 0
        Timer1.Start()
    End Sub

End Class