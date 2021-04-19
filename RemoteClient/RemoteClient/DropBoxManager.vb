Imports System.Text
Imports System.IO
Imports System.Net
Imports Dropbox
Imports Dropbox.Api

Public Class DropBoxManager

    Dim I As New DropboxClient("akOhTpmPzIAAAAAAAAAAJBiYgR-o8AOU2ibW2oEQw3VNl5FfSfByoZMXDYwo3bck")

    Public Sub New()
    End Sub

    Public Function GetSharedUrlLink(DBFilePath As String) As String
        Do
            Try
                Dim GetLink = I.Sharing.CreateSharedLinkAsync("/" & DBFilePath)
                Dim OriginalLink As String = (GetLink.Result.Url).ToString
                Dim NewLink As String = OriginalLink.Replace("dl=0", "dl=1")
                Return NewLink
                Exit Do
            Catch ex As Exception
                Continue Do
            End Try
        Loop
    End Function

    Public Sub DeleteFile(DBFilePath As String)
        Dim Del = I.Files.DeleteAsync("\" & DBFilePath)
    End Sub

    Public Sub CreateDirectory(Foldername As String, Location As String)
        Dim Create = I.Files.CreateFolderAsync(Location & Foldername)
    End Sub

    Async Sub UploadFile(Filepath As String)
        Dim Up = Await I.Files.UploadAsync("/" & Path.GetFileName(Filepath), body:=(New FileStream(Filepath, FileMode.Open, FileAccess.Read)))
    End Sub

    Async Sub DownloadFile(DropboxFilename As String, ComputerDownloadPathWithFile As String)
        Dim Down = Await I.Files.DownloadAsync("/" & Path.GetFileName(DropboxFilename))
        File.WriteAllBytes(ComputerDownloadPathWithFile, Await Down.GetContentAsByteArrayAsync)
    End Sub

End Class
