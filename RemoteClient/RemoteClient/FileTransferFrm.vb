Imports System.Runtime.InteropServices
Imports System.IO

Public Class FileTransferFrm

    Private FTP As New FTPFileManager
    Private nIndex As Integer = 0
    Private shinfo As SHFILEINFO = New SHFILEINFO()

    Public Structure SHFILEINFO
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> Public szTypeName As String
    End Structure

#Region "Form"

    Private Sub FileTransferFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Server.FTPTransferFrmVisible = False
    End Sub

    Private Sub FileTransferFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewProperties()
    End Sub

#End Region

#Region "ListView"

    Private Sub ListViewProperties()
        ListView1.Columns.Add("File Name", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Size", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Date", 120, HorizontalAlignment.Left)
        ListView1.View = View.Details
        ListView1.LabelEdit = True
        ListView1.CheckBoxes = True
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Sorting = SortOrder.Ascending
    End Sub

    Private Sub listView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.A AndAlso e.Control Then
            ListView1.MultiSelect = True
            For Each item As ListViewItem In ListView1.Items
                item.Selected = True
                item.Checked = True
            Next
        ElseIf e.KeyCode = Keys.D AndAlso e.Control Then
            For Each item As ListViewItem In ListView1.Items
                item.Selected = False
                item.Checked = False
            Next
        ElseIf e.KeyCode = Keys.Delete Then
            For Each item As ListViewItem In ListView1.Items
                item.Remove()
            Next
        End If

    End Sub

    Private Sub listView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        Dim FullFnames() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim ctdate As Date
        Dim x As Integer
        nIndex = 0
        For Each SFile As String In FullFnames
            AddFile(SFile, ctdate, x)
        Next
    End Sub

    Private Sub listView1_DragEnter(sender As System.Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region

#Region "Add/Remove Files"

    Private Sub AddItems()

        OpenFileDialog1.ShowDialog()
        Dim ctdate As Date
        Dim x As Integer
        nIndex = 0
        For Each SFile As String In OpenFileDialog1.FileNames
            AddFile(SFile, ctdate, x)
        Next
    End Sub

    Public Sub AddFile(SFile As String, ctdate As Date, x As Integer)
        ctdate = IO.File.GetCreationTime(SFile)
        shinfo.szDisplayName = New String(Chr(0), 260)
        shinfo.szTypeName = New String(Chr(0), 80)
        For Each item As ListViewItem In ListView1.Items
            If SFile = item.SubItems(0).Text Then
                x = 1
                Exit For
            End If
        Next
        ListView1.Items.Add(New ListViewItem(New String() {SFile, CStr(FileLen(SFile)), ctdate.ToString}, nIndex))
        For Each item As ListViewItem In ListView1.Items
            If SFile = item.SubItems(0).Text Then
                If x = 1 Then
                    item.Remove()
                    Exit For
                Else
                    Exit For
                End If
            End If
        Next
        nIndex = nIndex + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddItems()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For Each item As ListViewItem In ListView1.Items
            If item.Checked And item.Selected Then
                item.Remove()
            End If
        Next

    End Sub

#End Region

#Region "Upload & Send"

    Private Sub UploadFiles()
        Me.Cursor = Cursors.WaitCursor
        For Each file As ListViewItem In ListView1.Items
            Dim P = Path.GetFileName(file.SubItems(0).Text)
            Try
                FTP.UploadFile(file.SubItems(0).Text, "ftp://remotewebserver.hol.es/" & P, "u145546434", "remoteadminconn")
                Server.SendCommandOrData.SendCommandFTP("FTPF#" & P)
                Server.SendCommandOrData.SendCommandFTP("FTPDOWNLOAD")
            Catch ex As Exception
                MsgBox(P & " could not be sent due to large file size")
                Continue For
            End Try
        Next
        Me.Cursor = Cursors.Arrow
        MsgBox("Sent")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not DirectoryFieldIsEmpty() Then
            SendFiles()
            MsgBox("File(s) Sent Successfully")
        End If
    End Sub

    Private Sub SendFiles()
        SendStringFTPInfo()
        UploadFiles()
    End Sub

    Private Function DirectoryFieldIsEmpty() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("The directory is null")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SendStringFTPInfo()
        If Not TextBox1.Text.EndsWith("\") Then
            Server.SendCommandOrData.SendCommandFTP("FTPLOC#" & TextBox1.Text & "\")
        Else
            Server.SendCommandOrData.SendCommandFTP("FTPLOC#" & TextBox1.Text)
        End If
    End Sub

#End Region

End Class