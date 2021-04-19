Imports System.IO
Imports System.Net
Imports System.Net.WebClient

Public Class WebTextGrabber

    Private GrabbedText As String

    Public Sub New(Url As String)
        If Not Url = Nothing Then
            GrabTextFrom(Url)
        End If
    End Sub

    Public Sub GrabTextFrom(Url As String)
        Dim str As Stream
        Dim strRead As StreamReader
        Try
            Dim req As WebRequest = WebRequest.Create(Url)
            Dim resp As WebResponse = req.GetResponse
            str = resp.GetResponseStream
            strRead = New StreamReader(str)
            GrabbedText = strRead.ReadToEnd
        Catch ex As Exception
        End Try
    End Sub

    Public Function PlaceText() As String
        Return GrabbedText
    End Function

    Public Function GetIPAddress() As String
        Dim Client As New WebClient
        Dim IP As String = Client.DownloadString("https://api.ipify.org")
        Return IP
    End Function

End Class