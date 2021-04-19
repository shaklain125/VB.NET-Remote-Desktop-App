Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Public Class WinCursor

#Region "System Cursor Functions"

    Private Const CURSOR_SHOWING As Int32 = &H1
    Private Const DI_NORMAL As Int32 = &H3

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure CURSORINFO
        Public cbSize As Int32
        Public flags As Int32
        Public hCursor As IntPtr
        Public ptScreenPos As POINTAPI
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function DrawIconEx(hdc As IntPtr, xLeft As Integer, yTop As Integer, hIcon As IntPtr, cxWidth As Integer, cyHeight As Integer, _
        istepIfAniCur As Integer, hbrFlickerFreeDraw As IntPtr, diFlags As Integer) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function GetCursorInfo(ByRef pci As CURSORINFO) As Boolean
    End Function


#End Region

    Public Shared Function CaptureCursor(ByRef X__1 As Integer, ByRef Y As Integer, theShot As Graphics, ScreenServerX As Integer, ScreenServerY As Integer) As Color
        'We return a color so that it can be embeded in a bitmap to be returned to the technician's program
        Dim C As IntPtr = Cursors.Arrow.Handle
        Dim pci As CURSORINFO
        pci.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(GetType(CURSORINFO))
        If GetCursorInfo(pci) Then
            X__1 = pci.ptScreenPos.x
            Y = pci.ptScreenPos.y
            If pci.hCursor = Cursors.[Default].Handle Then
                Return Color.Red
            ElseIf pci.hCursor = Cursors.WaitCursor.Handle Then
                Return Color.Green
            ElseIf pci.hCursor = Cursors.Arrow.Handle Then
                Return Color.Blue
            ElseIf pci.hCursor = Cursors.IBeam.Handle Then
                Return Color.White
            ElseIf pci.hCursor = Cursors.Hand.Handle Then
                Return Color.Violet
            ElseIf pci.hCursor = Cursors.SizeNS.Handle Then
                Return Color.Yellow
            ElseIf pci.hCursor = Cursors.SizeWE.Handle Then
                Return Color.Orange
            ElseIf pci.hCursor = Cursors.SizeNESW.Handle Then
                Return Color.Aqua
            ElseIf pci.hCursor = Cursors.SizeNWSE.Handle Then
                Return Color.Pink
            ElseIf pci.hCursor = Cursors.PanEast.Handle Then
                Return Color.BlueViolet
            ElseIf pci.hCursor = Cursors.HSplit.Handle Then
                Return Color.Cyan
            ElseIf pci.hCursor = Cursors.VSplit.Handle Then
                Return Color.DarkGray
            ElseIf pci.hCursor = Cursors.Help.Handle Then
                Return Color.DarkGreen
            ElseIf pci.hCursor = Cursors.AppStarting.Handle Then
                Return Color.SlateGray
            End If
            If pci.flags = CURSOR_SHOWING Then
                'We need to capture the mouse image and embed it in the screen shot of the desktop because it's a custom mouse cursor
                Dim XReal As Single = pci.ptScreenPos.x * CSng(ScreenServerX) / CSng(Screen.PrimaryScreen.Bounds.Width) - 11
                Dim YReal As Single = pci.ptScreenPos.y * CSng(ScreenServerY) / CSng(Screen.PrimaryScreen.Bounds.Height) - 11
                Dim x__2 As Integer = Screen.PrimaryScreen.Bounds.X
                Dim hdc = theShot.GetHdc()
                DrawIconEx(hdc, CInt(XReal), CInt(YReal), pci.hCursor, 0, 0, _
                    0, IntPtr.Zero, DI_NORMAL)
                theShot.ReleaseHdc()
            End If
            Return Color.Black
        End If
        X__1 = 0
        Y = 0
        Return Color.Black
    End Function

End Class