Public Class RemoveJobScreen

    Private SqlConn As New MySQLClientConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SqlConn.SelectJobRow(TextBox1.Text, False) = True Then
            If SqlConn.GetClientPassword(TextBox1.Text) = TextBox2.Text Then
                SqlConn.RemoveJob(TextBox1.Text)
                MsgBox("Removed")
                ServerFrm.Exit("Session Ended")
            Else
                MsgBox("Incorrect Password")
            End If
        Else
            MsgBox("Incorrect JobID")
        End If
    End Sub

    Private Sub RemoveJobScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConn.Connect()
    End Sub

End Class
