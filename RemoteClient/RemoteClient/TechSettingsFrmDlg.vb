Public Class TechSettingsFrmDlg

    Public Sub New(UsrControl As UserControl, FormTxt As String)
        InitializeComponent()
        Me.Text = FormTxt
        Me.Width = UsrControl.Width
        Me.Height = UsrControl.Height + 35
        With UsrControl
            .Dock = DockStyle.Fill
        End With
        Me.Controls.Add(UsrControl)
    End Sub

End Class