Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.ComponentModel
Imports System.Threading

Public Class PortForwardService

    Private Path As String = Application.StartupPath
    Private JavaFile As String = Application.StartupPath & "\PortsForwardingService.jar"
    Public Port As Integer

    Public Sub OpenPort()
        Dim args As String = "java -jar " & Path & "\PortsForwardingService.jar -add -internalPort=" & Port & " -externalPort=" & Port & " -protocol=TCP & exit"
        Shell("cmd.exe /k" & args, AppWinStyle.Hide)
    End Sub

    Public Sub ClosePort()
        Dim args As String = "java -jar " & Path & "\PortsForwardingService.jar -delete -externalPort=" & Port & " -protocol=TCP & exit"
        Shell("cmd.exe /k" & args, AppWinStyle.Hide)
    End Sub

    Private Sub HideFile()
        File.SetAttributes(JavaFile, FileAttributes.Hidden)
    End Sub

End Class
