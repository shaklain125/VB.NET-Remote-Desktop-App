Public Class ClientsManagementUC

    Private MySQLConn As New MySQLStaffConnection
    Private ClientID As String
    Private FirstName As String
    Private LastName As String
    Private Email As String
    Private ClientPass As String
    Private PhoneNo As String
    Private IP As String
    Private Loaded As Boolean
    Private RowChanged As Boolean

#Region "Form"

    Private Sub ClientManagementUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaded = False
        ClientID = ""
        FirstName = ""
        LastName = ""
        Email = ""
        ClientPass = ""
        PhoneNo = ""
        IP = ""
        MySQLConn.Connect()
        MySQLConn.GetClients()
        DisplayAllClient()
        ComboBox1.SelectedIndex = 0
        'DataGridView1.Rows(rIndex).Cells(0).Selected = True
        Loaded = True
    End Sub

#End Region

#Region "Display"

    Private Sub DisplayAllClient()
        DataGridView1.DataSource = MySQLConn.SQLDS.Tables(0)
        MySQLConn.UpdateCommand()
        UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        DataGridView1.Focus()
    End Sub

    Private Sub DisplayInfo()
        Try
            ClientID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            FirstName = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            LastName = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            IP = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            Email = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            PhoneNo = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            ClientPass = DataGridView1.SelectedRows(0).Cells(6).Value.ToString

            ClientIDTxt.Text = ClientID
            ClientFNTxt.Text = FirstName
            ClientLNTxt.Text = LastName
            ClientEmailTxt.Text = Email
            ClientPassTxt.Text = ClientPass
            ClientPhoneTxt.Text = PhoneNo
            ClientIPTxt.Text = IP
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
            ElseIf ComboBox1.SelectedItem.ToString = "ClientID" Then
                DV.RowFilter = String.Format("CONVERT(ClientID, System.String) like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "Email" Then
                DV.RowFilter = String.Format("EmailAddress like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "PhoneNO." Then
                DV.RowFilter = String.Format("CONVERT(PhoneNumber, System.String) like '%{0}%'", TextBox1.Text)
            ElseIf ComboBox1.SelectedItem.ToString = "IPAddress" Then
                DV.RowFilter = String.Format("IPAddress like '%{0}%'", TextBox1.Text)
            End If
            DataGridView1.DataSource = DV
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
            If DataGridView1.RowCount = 0 Then
                ClientIDTxt.Clear()
                ClientFNTxt.Clear()
                ClientLNTxt.Clear()
                ClientEmailTxt.Clear()
                ClientPassTxt.Clear()
                ClientPhoneTxt.Clear()
                ClientIPTxt.Clear()
            End If
        Else
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        End If
    End Sub

#End Region

#Region "Add&RemoveClient"

    Private Sub AddClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClientToolStripMenuItem.Click
        Dim AddClientUC As New AddClient
        Dim AddClientFrm As New TechSettingsFrmDlg(AddClientUC, "Add New Client")
        AddClientFrm.ShowDialog()
    End Sub

    Private Sub RemoveClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveClientToolStripMenuItem.Click

        Dim rowToDelete As Integer = DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If rowToDelete < 0 Then
            Return
        End If
        If MessageBox.Show("Are you sure you want to remove this member from the database?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
        DataGridView1.Rows.RemoveAt(rowToDelete)
        UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
        UpdateClientTable()
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
            If MessageBox.Show("Are you sure you want to remove this client from the database?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return
            End If
            DataGridView1.Rows.RemoveAt(rowToDelete)
            UsersCountLbl.Text = DataGridView1.RowCount & " Users found"
            UpdateClientTable()
            DataGridView1.Focus()
        End If
    End Sub

#End Region

#Region "Live Update"

#Region "Update"

    Private Sub CancelUpdate()
        Dim Rowindex As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows(Rowindex).Cells(0).Value = ClientID
        DataGridView1.Rows(Rowindex).Cells(1).Value = FirstName
        DataGridView1.Rows(Rowindex).Cells(2).Value = LastName
        DataGridView1.Rows(Rowindex).Cells(3).Value = IP
        DataGridView1.Rows(Rowindex).Cells(4).Value = Email
        DataGridView1.Rows(Rowindex).Cells(5).Value = PhoneNo
        DataGridView1.Rows(Rowindex).Cells(6).Value = ClientPass
    End Sub

    Private Sub UpdateClientTable()
        MySQLConn.SQLDA.Update(MySQLConn.SQLDS)
        DisplayAllClient()
    End Sub

    Private Sub UpdateDGV()

        Dim Rowindex As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows(Rowindex).Cells(0).Value = ClientIDTxt.Text
        DataGridView1.Rows(Rowindex).Cells(1).Value = ClientFNTxt.Text
        DataGridView1.Rows(Rowindex).Cells(2).Value = ClientLNTxt.Text
        DataGridView1.Rows(Rowindex).Cells(3).Value = ClientIPTxt.Text
        DataGridView1.Rows(Rowindex).Cells(4).Value = ClientEmailTxt.Text
        DataGridView1.Rows(Rowindex).Cells(5).Value = ClientPhoneTxt.Text
        DataGridView1.Rows(Rowindex).Cells(6).Value = ClientPassTxt.Text
    End Sub

#End Region

    Private Sub ClientIPTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientIPTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub ClientPassTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientPassTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub ClientLNTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientLNTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub ClientPhoneTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientPhoneTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub ClientFNTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientFNTxt.TextChanged
        If Not RowChanged OrElse DataGridView1.RowCount = 0 Then
            Return
        End If
        If Loaded = True Then
            EnableUpdateBtn()
            UpdateDGV()
        End If
    End Sub

    Private Sub ClientEmailTxt_TextChanged(sender As Object, e As EventArgs) Handles ClientEmailTxt.TextChanged
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
        UpdateClientTable()
        UpdateClientTable()
        MsgBox("Updated Successfully")
        UpdateBtn.Enabled = False
    End Sub

    Private Sub EnableUpdateBtn()
        If UpdateBtn.Enabled = False Then
            UpdateBtn.Enabled = True
        End If
    End Sub

#End Region

End Class

