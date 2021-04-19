Public Class Overview

    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSettings.MysqlConn.Connect()
        ClientSettings.MysqlConn.SelectClientRow(ClientJobs.ClientID, True)
        Label2.Text = ClientSettings.MysqlConn.EmailAddress
        Label3.Text = ClientSettings.MysqlConn.FirstName
        Label5.Text = ClientSettings.MysqlConn.LastName
    End Sub

End Class
