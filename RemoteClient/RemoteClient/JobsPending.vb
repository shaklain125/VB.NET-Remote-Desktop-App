Public Class JobsPending

    Private MySQLC As New MySQLStaffConnection

    Private ApprovalComboBx As New DataGridViewComboBoxColumn
    Private CompleteButton As New DataGridViewButtonColumn

    Private Sub JobsPending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQLC.Connect()
        MySQLC.GetJobsPending()
        DGVProperties()
        With ApprovalComboBx
            .HeaderText = "Approval"
            .Name = "ApprovalCombobx"
            .Items.Add("Accept")
            .Items.Add("Decline")
            DataGridView1.Columns.Add(ApprovalComboBx)
        End With
        With CompleteButton
            .HeaderText = ""
            .Name = "ProceedBtn"
            .Text = "Proceed"
            .UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(CompleteButton)
        End With
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
            .BackgroundColor = Color.White
            .Width = Me.Width
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        End With

    End Sub

    Private Sub AddRow(JobID As String, ClientID As String, DateR As String)
        Dim row As String() = New String() {JobID, ClientID, DateR}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = ApprovalComboBx.Index Then
                DataGridView1.ReadOnly = False
                DataGridView1.BeginEdit(True)
                Dim com As ComboBox = DirectCast(DataGridView1.EditingControl, ComboBox)
                com.DroppedDown = True
            ElseIf e.ColumnIndex < ApprovalComboBx.Index Then
                DataGridView1.ReadOnly = True
            ElseIf e.ColumnIndex = CompleteButton.Index AndAlso e.RowIndex <> -1 Then
                DataGridView1.ReadOnly = False
                If CheckForJobStatus(DataGridView1.Rows(e.RowIndex).Cells(0).Value) = False Then
                    If DataGridView1.Rows(e.RowIndex).Cells(ApprovalComboBx.Index).Value = "" Then
                        MsgBox("Please Approve or Decline")
                    ElseIf DataGridView1.Rows(e.RowIndex).Cells(ApprovalComboBx.Index).Value = "Accept" Then
                        Accept(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    ElseIf DataGridView1.Rows(e.RowIndex).Cells(ApprovalComboBx.Index).Value = "Decline" Then
                        Decline(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    End If
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub RefreshDGV()
        DataGridView1.DataSource = MySQLC.SQLDS.Tables(0)
        MySQLC.UpdateCommand()
        DataGridView1.Focus()
    End Sub

    Private Function CheckForJobStatus(JobID As String) As Boolean
        MySQLC.GetJobStatus(JobID)

        Dim JobStatus As String = ""
        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
            If i.item("JobApproval") = 1 Then
                JobStatus = "Accepted"
            ElseIf i.item("JobDeclined") = 1 Then
                JobStatus = "Declined"
            End If
        Next
        If Not JobStatus = "" Then
            MsgBox("Job has been already {0}", JobStatus)
            RefreshDGV()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Accept(JobID As String)
        MySQLC.JobApprove(JobID)
        MySQLC.SetStafftoClient(JobID)
    End Sub

    Private Sub Decline(JobID As String)
        Dim Mail As New SendMailFrm(JobID, "Decline")
        Mail.ShowDialog()
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
