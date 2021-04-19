Public Class DashboardPage

    Private MySQLConn As New MySQLStaffConnection

    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQLConn.Connect()
        MySQLConn.SelectStaffRow(WelcomeScreen.AuthUsr, True)
        Label2.Text = MySQLConn.StaffFirstName & " " & MySQLConn.StaffLatName
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        WelcomeScreen.Show()
    End Sub
End Class
