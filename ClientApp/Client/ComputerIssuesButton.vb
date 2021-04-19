Public Class ComputerIssuesButton
    Inherits MaterialFlatButton

    Public Sub New()
        Me.FlatStyle = Windows.Forms.FlatStyle.Popup
        Me.FlatAppearance.BorderSize = 3
        Me.FlatAppearance.BorderColor = Color.Black
        Me.Font = New System.Drawing.Font("Calibri", 9, FontStyle.Regular)
        Me.MouseLFColor = Color.Empty
        Me.MouseDFColor = Color.Empty
        Me.MouseHFColor = Color.Empty
        Me.FlatAppearance.MouseDownBackColor = Color.Empty
        Me.FlatAppearance.MouseOverBackColor = Color.Empty
        Me.Margin = New Padding(0)
        Me.Dock = DockStyle.Fill
    End Sub

    Dim ClickCount As Integer = 0

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        ClickCount = ClickCount + 1
        If ClickCount = 1 Then
            Me.BackColor = Color.Gray
        Else
            Me.BackColor = Color.White
            ClickCount = 0
        End If
    End Sub

End Class
