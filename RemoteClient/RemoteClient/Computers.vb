Public Class Computers

    Private MySQLC As New MySQLStaffConnection
    Public Shared IPAddr As String
    Public Shared Port As String
    Public Shared Pass As String
    Public Shared ClientID As String
    Public Shared JobID As String
    Private JobIDList As New ArrayList

    Private Sub Computers_Load(sender As Object, e As EventArgs) Handles Me.Load
        MySQLC.Connect()
        MySQLC.GetJobsApproved()
        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
            JobIDList.Add(i.item("JobID"))
        Next
        JobIDList.Sort()
        For Each item As String In JobIDList
            AddComputer(item)
        Next
    End Sub

    Private Sub AddComputer(JobID As String)
        Dim item As New ListViewItem
        item.Text = JobID
        ImageList1.ImageSize = New Size(100, 100)
        ImageList1.Images.Add("image1", My.Resources.CompIcon)
        item.ImageKey = "image1"
        ListView1.Items.Add(item)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        SelectJob()
    End Sub

    Private Sub SelectJob()
        For Each X As ListViewItem In ListView1.SelectedItems
            MySQLC.GetClientIP(X.Text)
            JobID = X.Text
            For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
                IPAddr = i.item("IPAddress")
            Next
            MySQLC.GetClientID(X.Text)
            For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
                ClientID = i.item("ClientID")
            Next
            Port = "4000"
            Pass = "remoteadminconn"
            Server.Show()
            Server.ConnectionIO.Connect(IPAddr, Port, Pass)
        Next
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectJob()
        End If
    End Sub

End Class
