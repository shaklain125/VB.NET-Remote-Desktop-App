Imports System.IO

Public Class FTPSaveDialogue

    Private FTP As New FTPFileManager

    Private Sub UploadFiles()
        Me.Cursor = Cursors.WaitCursor
        For Each file As String In Server.FTPFilenames
            Dim P = Path.GetFileName(file)
            Try
                FTP.UploadFile(file, "ftp://remotewebserver.hol.es/" & P, "u145546434", "remoteadminconn")
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

    Private Sub TextBox1_Keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not DirectoryFieldIsEmpty() Then
                SendFiles()
                Server.FTPSaveDlgVisible = False
                Me.Close()
            End If
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

End Class