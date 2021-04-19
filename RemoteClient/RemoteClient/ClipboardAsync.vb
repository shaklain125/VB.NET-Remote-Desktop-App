Imports System.Collections.Generic
Imports System.Threading
Imports System.Windows.Forms

Public Class ClipboardAsync

    Private _GetText As String
    Private _SetText As String

    Private Sub _thSetText()
        If _SetText.Length = 0 Then
            Return
        End If
        Clipboard.Clear()
        Clipboard.SetText(_SetText)
    End Sub

    Private Sub _thGetText()
        _GetText = Clipboard.GetText()
    End Sub

    Public Shared Function GetText() As String
        Dim instance As New ClipboardAsync()
        Dim staThread As New Thread(AddressOf instance._thGetText)
        staThread.SetApartmentState(ApartmentState.STA)
        staThread.Start()
        staThread.Join()
        Return instance._GetText
    End Function

    Public Shared Sub SetText(Text As String)
        Dim instance As New ClipboardAsync()
        instance._SetText = Text
        Dim staThread As New Thread(AddressOf instance._thSetText)
        staThread.SetApartmentState(ApartmentState.STA)
        staThread.Start()
        staThread.Join()
    End Sub

End Class