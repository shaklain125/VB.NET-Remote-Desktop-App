Public Class RestoreControl
    Inherits LabelControl

    Public Sub New()
        Label = "□"
        ForRestore()
    End Sub

    Private Sub RestoreControl1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If FindForm.WindowState = FormWindowState.Normal Then
            FindForm.WindowState = FormWindowState.Maximized
        Else
            FindForm.WindowState = FormWindowState.Normal
        End If
    End Sub

End Class
