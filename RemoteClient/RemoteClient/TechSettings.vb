Public Class TechSettings

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Me.Controls.Clear()
        Dim StaffSettings As New StaffManagementUC
        With StaffSettings
            .Dock = DockStyle.Fill
        End With
        Me.Controls.Add(StaffSettings)
    End Sub

    Private Sub TechSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WelcomeScreen.StaffManagement = False Then
            MaterialFlatButton2.Enabled = False
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Me.Controls.Clear()
        Dim ClientSettings As New ClientsManagementUC
        With ClientSettings
            .Dock = DockStyle.Fill
        End With
        Me.Controls.Add(ClientSettings)
    End Sub

End Class
