Imports System.Threading

Public Class SendCommands

    Public Function SafeSendValue(Text As String) As Boolean
        Dim Shift As Integer = 45
        If Text.Length = 1 Then
            Shift = 77
        End If
        'Change the shift for a single key press
        If Not Settings.Connected Then
            Return False
        End If
        Try
            Dim T As String = Helper.XorString(Text, Shift, True)
            Server.ConnectionIO.eventSender.Write(T & Convert.ToString(vbLf))
            Server.ConnectionIO.eventSender.Flush()
            Return True
        Catch Ex As Exception
            Return False
        End Try
    End Function

    Public Sub SendClipboard()
        Dim Text As String = ClipboardAsync.GetText()
        If Text IsNot Nothing AndAlso Text.Length > 0 AndAlso Text <> Server.ConnectionIO.LastClipboardText Then
            SafeSendValue("CLIPBOARD " & Text.Replace(Environment.NewLine, "#NL#").Replace(vbLf, "#NL#").Replace("'", "#SQ#"))
            Server.ConnectionIO.LastClipboardText = Text
        End If
    End Sub

    Public Sub SendScreenSize()
        SafeSendValue("SCREEN " & Settings.ScreenServerX & " " & Settings.ScreenServerY)
    End Sub

    Public Sub SendCommand(Cmd As String)
        SafeSendValue("CMD " & Cmd.ToUpper())
    End Sub

    Public Sub SendCommandFTP(Cmd As String)
        SafeSendValue("FTP " & Cmd)
    End Sub

    Public Sub SendCommandDBX(Cmd As String)
        SafeSendValue("DBX " & Cmd)
    End Sub

    Public Sub SendDefaults(FirstConnect As Boolean)
        If FirstConnect Then
            SendScreenSize()
        End If
        If Settings.BlackWallpaper = True Then
            SendCommand("WALLPAPER TRUE")
        Else
            SendCommand("WALLPAPER FALSE")
        End If
    End Sub

    Public Sub SendKeySync()
        'Deals with cap-lock, num-lock and keeps the server/client in sync with these keys
        If Settings.SendKeysAndMouse AndAlso Settings.Connected Then
            SendCommand("KEYSYNC " & Control.IsKeyLocked(Keys.CapsLock).ToString() & " " & Control.IsKeyLocked(Keys.NumLock).ToString() & " " & Control.IsKeyLocked(Keys.Scroll).ToString())
        End If
        Thread.Sleep(20)
    End Sub

    Public Sub sendShutdown()
        SafeSendValue("SHUTDOWN")
        Server.Close()
    End Sub

End Class
