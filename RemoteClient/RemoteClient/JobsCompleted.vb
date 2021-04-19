Public Class JobsCompleted

    Private MySQLC As New MySQLStaffConnection

    Private Sub JobsCompleted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQLC.Connect()
        MySQLC.GetJobsCompleted()
        DGVProperties()
        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
            AddRow(i.item("JobID"), i.item("ClientID"), i.item("JobRequestDateTime"))
        Next
        For x As Integer = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(x).Width = ((DataGridView1.Width - 20) / DataGridView1.Columns.Count)
        Next
    End Sub

    Private Sub DGVProperties()
        With DataGridView1
            .ColumnCount = 3
            .Columns(0).Name = "Job ID"
            .Columns(1).Name = "Client ID"
            .Columns(2).Name = "Date & Time"
            .AllowUserToAddRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
            .Dock = DockStyle.Fill
            .BackgroundColor = Color.White
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        End With

    End Sub

    Private Sub AddRow(JobID As String, ClientID As String, DateR As String)
        Dim row As String() = New String() {JobID, ClientID, DateR}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim JobIDc As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            Dim ClientIDc As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Dim DateTimec As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Dim JobInfo As New JobInfoDetails(JobIDc, ClientIDc, DateTimec)
            JobInfo.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
