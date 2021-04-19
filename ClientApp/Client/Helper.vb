Imports System.IO
Imports System.Windows.Forms
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Drawing

Public Class Helper

#Region "Decryption"

    Public Shared Function XorString(Value As String, Shift As Integer, Outbound As Boolean) As String
        'Shift changes for single keyboard letters
        If Outbound Then
            Value = Value.Replace(" ", "#SS#")
        End If
        Dim Output As String = ""
        Dim Ch As Integer = 0
        For f As Integer = 0 To Value.Length - 1
            Ch = Convert.ToInt32(Value(f))
            If Outbound AndAlso Ch = 113 Then
                Ch = Convert.ToInt32("¬"c)
            ElseIf Not Outbound AndAlso Ch = 172 Then
                Ch = 113
            Else
                Ch = Ch Xor Shift
            End If
            Output += Char.ConvertFromUtf32(Ch)
        Next
        If Not Outbound Then
            Return Output.Replace("#SS#", " ")
        Else
            Return Output
        End If
    End Function

#End Region

#Region "System Mouse&Keyboard Functions"

    Public Const KEYEVENTF_EXTENDEKEY As Integer = 1
    Public Const KEYEVENTF_KEYUP As Integer = 2
    Public Const vbKeyControl As Integer = 17
    Public Const vbKeyEscape As Integer = 27

    <Flags()> _
    Public Enum MouseEventFlags As UInteger
        MOUSEEVENTF_ABSOLUTE = &H8000
        MOUSEEVENTF_LEFTDOWN = &H2
        MOUSEEVENTF_LEFTUP = &H4
        MOUSEEVENTF_MIDDLEDOWN = &H20
        MOUSEEVENTF_MIDDLEUP = &H40
        MOUSEEVENTF_MOVE = &H1
        MOUSEEVENTF_RIGHTDOWN = &H8
        MOUSEEVENTF_RIGHTUP = &H10
        MOUSEEVENTF_XDOWN = &H80
        MOUSEEVENTF_XUP = &H100
        MOUSEEVENTF_WHEEL = &H800
        MOUSEEVENTF_HWHEEL = &H1000
    End Enum

    <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub mouse_event(dwFlags As Long, dx As Long, dy As Long, cButtons As Long, dwExtraInfo As Long)
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function keybd_event(bVk As Byte, bScan As Byte, dwFlags As Integer, dwExtraInfo As Integer) As UInteger
    End Function

#End Region

#Region "Keys"

    Public Shared Sub SyncKeys(Cmd As String)
        'Comes in as Caps , NumLock, Scroll-lock
        Dim Items As String() = Cmd.ToLower().Split(" "c)
        If Control.IsKeyLocked(Keys.CapsLock).ToString().ToLower() <> Items(1) Then
            CapsLock()
        End If
        If Control.IsKeyLocked(Keys.NumLock).ToString().ToLower() <> Items(2) Then
            NumLock()
        End If
    End Sub

    Public Shared Sub ShowStart()
        'shows the windows start button
        keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_EXTENDEKEY, 0)
        keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_EXTENDEKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

    Public Shared Sub CapsLock()
        keybd_event(&H14, &H45, KEYEVENTF_EXTENDEKEY, 0)
        keybd_event(&H14, &H45, KEYEVENTF_EXTENDEKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

    Public Shared Sub NumLock()
        keybd_event(&H90, &H45, KEYEVENTF_EXTENDEKEY, 0)
        keybd_event(&H90, &H45, KEYEVENTF_EXTENDEKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

#End Region

End Class