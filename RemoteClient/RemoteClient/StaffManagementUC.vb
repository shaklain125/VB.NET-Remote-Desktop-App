Public Class StaffManagementUC

    Private MySQLConn As New MySQLStaffConnection
    Private StaffID As String
    Private FirstName As String
    Private LastName As String
    Private Email As String
    Private StaffPass As String
    Private PhoneNo As String
    Private IsAdmin As String
    Private Loaded As Boolean
    Private RowChanged As Boolean

#Region "Form"

    Private Sub StaffManagementUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaded = False
        StaffID = ""
        FirstName = ""
        LastName = ""
        Email = ""
        StaffPass = ""
        PhoneNo = ""
        IsAdmin = ""
        MySQLConn.Connect()
        MySQLConn.GetStaff()
        DisplayAllStaff()
        ComboBox1.SelectedIndex = 0
        'DataGridView1.Rows(rIndex).Cells(0).Selected = True
        Loaded = True
    End Sub

#End Region

#Region "Display"

    Private Sub DisplayAllStaff()
        DataGridView1.DataSource = MySQLConn.SQLDS.Tables(0)
        MySQLConn.UpdateCommand()
        UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        DataGridView1.Focus()
    End Sub

    Private Sub DisplayInfo()
        Try
            StaffID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            FirstName = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            LastName = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Email = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            StaffPass = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            PhoneNo = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            IsAdmin = DataGridView1.SelectedRows(0).Cells(6).Value.ToString

            StaffIDTxt.Text = StaffID
            StaffFNTxt.Text = FirstName
            StaffLNTxt.Text = LastName
            StaffEmailTxt.Text = Email
            StaffPassTxt.Text = StaffPass
            StaffPhoneTxt.Text = PhoneNo
            If IsAdmin = "0" Then
                StaffAdminTxt.SelectedIndex = 1
            Else
                StaffAdminTxt.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Live Search"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Search()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Search()
    End Sub

    Private Sub Search()
        If (ComboBox1.SelectedItem IsNot Nothing) Then
            Dim DV As New DataView(MySQLConn.SQLDS.Tables(0))
            If ComboBox1.SelectedItem.ToString = "FirstName" Then
                DV.RowFilter = String.Format("FirstName like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "LastName" Then
                DV.RowFilter = String.Format("LastName like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "StaffID" Then
                DV.RowFilter = String.Format("CONVERT(StaffID, System.String) like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "Email" Then
                DV.RowFilter = String.Format("EmailAddress like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "PhoneNO." Then
                DV.RowFilter = String.Format("CONVERT(PhoneNumber, System.String) like '%{0}%'", TextBox1.Text)
            End If
            DataGridView1.DataSource = DV
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
            If DataGridView1.RowCount = 0 Then
                StaffIDTxt.Clear()
                StaffFNTxt.Clear()
                StaffLNTxt.Clear()
                StaffEmailTxt.Clear()
                StaffPassTxt.Clear()
                StaffPhoneTxt.Clear()
                StaffAdminTxt.SelectedIndex = -1
            End If
        Else
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        End If
    End Sub

#End Region

#Region "Add&RemoveStaff"

    Private Sub AddStaffToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim AddStaffUC As New AddStaff
        Dim AddStaffFrm As New TechSettingsFrmDlg(AddStaffUC, "Add New Member")
        AddStaffFrm.ShowDialog()
    End Sub

    Private Sub RemoveStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveStaffToolStripMenuItem.Click

        Dim rowToDelete As Integer = DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If rowToDelete < 0 Then
            Return
        End If
        If MessageBox.Show("Are you sure you want to remove this member from the database?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
        DataGridView1.Rows.RemoveAt(rowToDelete)
        UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        UpdateStaffTable()
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Dim hti = DataGridView1.HitTest(e.X, e.Y)
                DataGridView1.ClearSelection()
                DataGridView1.Rows(hti.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim rowToDelete As Integer = DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
            If MessageBox.Show("Are you sure you want to remove this member from the database?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return
            End If
            DataGridView1.Rows.RemoveAt(rowToDelete)
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
            UpdateStaffTable()
            DataGridView1.Focus()
        End If
    End Sub

#End Region

#Region "Live Update"

#Region "Update"

    Private Sub CancelUpdate()
        Dim Rowindex As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows(Rowindex).Cells(0).Value = StaffID
        DataGridView1.Rows(Rowindex).Cells(1).Value = FirstName
        DataGridView1.Rows(Rowindex).Cells(2).Value = LastName
        DataGridView1.Rows(Rowindex).Cells(3).Value = Email
        DataGridView1.Rows(Rowindex).Cells(4).Value = StaffPass
        DataGridView1.Rows(Rowindex).Cells(5).Value = PhoneNo
        DataGridView1.Rows(Rowindex).Cells(6).Value = IsAdmin
    End Sub

    Private Sub UpdateStaffTable()
        MySQLConn.SQLDA.Update(MySQLConn.SQLDS)
        DisplayAllStaff()
    End Sub

    Private Sub UpdateDGV()

        Dim Rowindex As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows(Rowindex).Cells(0).Value = StaffIDTxt.Text
        DataGridView1.Rows(Rowindex).Cells(1).Value = StaffFNTxt.Text
        DataGridView1.Rows(Rowindex).Cells(2).Value = StaffLNTxt.Text
        DataGridView1.Rows(Rowindex).Cells(3).Value = StaffEmailTxt.Text
        DataGridView1.Rows(Rowindex).Cells(4).Value = StaffPassTxt.Text
        DataGridView1.Rows(Rowindex).Cells(5).Value = StaffPhoneTxt.Text
        If StaffAdminTxt.SelectedItem.ToString = "True" Then
            DataGridView1.Rows(Rowindex).Cells(6).Value = "1"
        Else
            DataGridView1.Rows(Rowindex).Cells(6).Value = "0"
        End If
    End Sub

#End Region

    Private Sub StaffAdminTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StaffAdminTxt.SelectedIndexChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub StaffPassTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffPassTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub StaffLNTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffLNTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub StaffPhoneTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffPhoneTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub StaffFNTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffFNTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub StaffEmailTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffEmailTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        RowChanged = False
        DisplayInfo()
        RowChanged = True
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        UpdateStaffTable()
        UpdateStaffTable()
        MsgBox("Updated Successfully")
        UpdateBtn.Enabled = False
    End Sub

    Private Sub EnableUpdateBtn()
        If UpdateBtn.Enabled = False Then
            UpdateBtn.Enabled = True
        End If
    End Sub

    'Function FindRow(DT As DataTable, ColumnNme As String, Text As String) As Integer
    '    For i As Integer = 0 To DT.Rows.Count
    '        If DT.Rows(i)(ColumnNme) = Text Then Return i
    '    Next
    '    Return -1
    'End Function

#End Region

End Class
