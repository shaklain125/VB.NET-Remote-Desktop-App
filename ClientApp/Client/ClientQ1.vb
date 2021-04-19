Public Class ClientQ1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Me.Controls.Clear()
            Dim clientq2 As New ClientQ2
            With clientq2
                .Dock = DockStyle.Fill
            End With
            Me.Controls.Add(clientq2)
        ElseIf CheckBox2.Checked Then
            Me.Controls.Clear()
            Dim clientq3 As New ClientQ3
            With clientq3
                .Dock = DockStyle.Fill
            End With
            Me.Controls.Add(clientq3)
        Else
            MsgBox("Both checkboxes are either checked or unchecked. Please select only one.")
        End If
    End Sub

End Class
