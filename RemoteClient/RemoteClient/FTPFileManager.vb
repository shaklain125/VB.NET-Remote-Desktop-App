Imports System.IO
Imports System.Net
Imports System.Net.FtpWebRequest
Imports System.Net.WebRequest
Imports System.Net.NetworkCredential
Imports System.Net.WebRequestMethods.Ftp

Public Class FTPFileManager

    Private Request As FtpWebRequest
    Private FTPDelResp As FtpWebResponse

    Public Sub UploadFile(CompFile As String, DestinationFTPUrl As String, FTPUsername As String, FTPPassword As String)

        Request = CType(WebRequest.Create(DestinationFTPUrl), FtpWebRequest)
        Request.Credentials = New NetworkCredential(FTPUsername, FTPPassword)
        Request.Method = WebRequestMethods.Ftp.UploadFile

        Dim CFile() As Byte = File.ReadAllBytes(CompFile)

        Using UploadStream As Stream = Request.GetRequestStream()
            UploadStream.Write(CFile, 0, CFile.Length)
            UploadStream.Close()
        End Using

    End Sub

    Public Sub RemoveFile(FTPFile As String, FTPUsername As String, FTPPassword As String)

        Request = WebRequest.Create(FTPFile)
        Request.Credentials = New NetworkCredential(FTPUsername, FTPPassword)
        Request.Method = WebRequestMethods.Ftp.DeleteFile
        FTPDelResp = Request.GetResponse

    End Sub

    Public Sub DownloadFile(DownloadPath As String, FTPUrl As String, FTPUsername As String, FTPPassword As String)

        Dim WClient As New WebClient()

        WClient.Credentials = New NetworkCredential(FTPUsername, FTPPassword)
        Dim bytes() As Byte = WClient.DownloadData(FTPUrl)
        Dim DownloadStream As FileStream = IO.File.Create(DownloadPath)
        DownloadStream.Write(bytes, 0, bytes.Length)
        DownloadStream.Close()

    End Sub

    Public Sub DownloadNormal(DownloadPath As String, Url As String)

        Dim WClient As New WebClient()

        Dim bytes() As Byte = WClient.DownloadData(Url)
        Dim DownloadStream As FileStream = IO.File.Create(DownloadPath)
        DownloadStream.Write(bytes, 0, bytes.Length)
        DownloadStream.Close()

    End Sub

End Class
