Imports System.IO

Public Class DbxSaveDialogue

    Private Dropbox As New DropBoxManager

    Private MySQLC As New MySQLStaffConnection
    Private JobID As String
    Private IPAddr As String
    Private Port As String
    Private Pass As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TextBox1_Keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not DirectoryFieldIsEmpty() Then
                ConnectToClient()
                SendStringFTPInfo()
                UploadFile()
                MsgBox("Video sent successfully")
            End If
        End If
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
            Server.SendCommandOrData.SendCommandDBX("DBXLOC#" & TextBox1.Text & "\")
        Else
            Server.SendCommandOrData.SendCommandDBX("DBXLOC#" & TextBox1.Text)
        End If
    End Sub

    Private Sub UploadFile()
        Dropbox.UploadFile(ScreenRecords.ScreenRLocation)
        Server.SendCommandOrData.SendCommandDBX("DBXFName#" & Path.GetFileName(ScreenRecords.ScreenRLocation))
        Server.SendCommandOrData.SendCommandDBX("DBXFURL#" & Dropbox.GetSharedUrlLink(Path.GetFileName(ScreenRecords.ScreenRLocation)))
        Server.SendCommandOrData.SendCommandDBX("DBXDOWNLOAD")
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ConnectToClient()

        MySQLC.Connect()
        Me.Cursor = Cursors.WaitCursor
        JobID = Path.GetFileNameWithoutExtension(ScreenRecords.ScreenRLocation)
        MySQLC.GetClientIP(JobID)
        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
            IPAddr = i.item("IPAddress")
        Next
        Port = "4000"
        Pass = "remoteadminconn"
        Server.ConnectionIO.Connect(IPAddr, Port, Pass)

    End Sub

End Class