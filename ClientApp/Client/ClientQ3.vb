Public Class ClientQ3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            FindForm.Close()
        ElseIf CheckBox2.Checked Then
            Me.Controls.Clear()
            Dim RemoveJobS As New RemoveJobScreen
            With RemoveJobS
                .Dock = DockStyle.Fill
            End With
            Me.Controls.Add(RemoveJobS)
        Else
            MsgBox("Both checkboxes are either checked or unchecked. Please select only one.")
        End If
    End Sub

End Class
