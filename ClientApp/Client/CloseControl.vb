Public Class CloseControl
    Inherits LabelControl

    Public Sub New()
        Label = "X"
        ForXAndMin()
    End Sub

    Private Sub CloseControl1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        FindForm.Close()
    End Sub

End Class
