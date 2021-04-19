Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Text

Public Class ScreenReadAndDecrypt

    Public Sub ReadInfo(Info As String)
        Info = Info.Substring(6)
        If Info.StartsWith("SCREEN_") Then
            'The screen resolution has been changed on the server so do the following
            Dim Data As String() = Info.Split("_"c)
            Settings.ScreenClientX = Integer.Parse(Data(1))
            Settings.ScreenClientY = Integer.Parse(Data(2))
            Settings.ScreenServerX = Settings.ScreenClientX
            Settings.ScreenServerY = Settings.ScreenClientY
            Server.SendCommandOrData.SendScreenSize()
        End If
    End Sub

    Public Function Decrypt(MSin As MemoryStream) As MemoryStream
        'Just add PNG back in to the begining of the image
        Dim Decr As Byte() = UTF8Encoding.UTF8.GetBytes("_PNG" & vbCr & vbLf)
        MSin.Position = 0
        Decr(0) = 137
        MSin.Write(Decr, 0, 6)
        Return MSin
    End Function

End Class
