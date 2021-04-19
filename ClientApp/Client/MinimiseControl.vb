Public Class MinimiseControl
    Inherits LabelControl
    Public Sub New()
        Label = "_"
        ForXAndMin()
    End Sub

    Private Sub MinimiseControl1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        FindForm.WindowState = FormWindowState.Minimized
    End Sub
End Class
