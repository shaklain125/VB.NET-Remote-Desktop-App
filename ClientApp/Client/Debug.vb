Public Class Debug

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub printDebug(Msg As String, Force As Boolean)
        'This will be called on this forms thread
        If Settings.Debug OrElse Force Then
            TextBox1.Text = Msg + Environment.NewLine + TextBox1.Text
            If TextBox1.Text.Length > 20000 Then
                TextBox1.Text = TextBox1.Text.Substring(10000)
            End If
        End If
    End Sub

End Class
