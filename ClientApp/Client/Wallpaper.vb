Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.IO
Imports Microsoft.Win32

Public Class Wallpaper

    'Used to set a black wallpaper for the desktop
    Const SPI_SETDESKWALLPAPER As Integer = 20
    Const SPIF_UPDATEINIFILE As Integer = &H1
    Const SPIF_SENDWININICHANGE As Integer = &H2

    Private Shared WallpaperStyle As String = ""
    Private Shared WallpaperFileName As String = ""
    Private Shared TileWallpaper As String = ""
    Public Shared BackGround As String = ""
    Public Shared Switched As Boolean = False

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SystemParametersInfo(uAction As Integer, uParam As Integer, lpvParam As String, fuWinIni As Integer) As Integer
    End Function

    Public Enum Style As Integer
        Tiled
        Centered
        Stretched
    End Enum

    Public Shared Sub SaveWallpaper()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
        WallpaperStyle = key.GetValue("WallpaperStyle", "").ToString()
        WallpaperFileName = key.GetValue("Wallpaper", "").ToString()
        TileWallpaper = key.GetValue("TileWallpaper", "").ToString()
        key = Registry.CurrentUser.OpenSubKey("Control Panel\Colors", True)
        BackGround = key.GetValue("BackGround", "").ToString()
    End Sub

    Public Shared Sub SetWallpaper()
        If WallpaperStyle.Length = 0 Then
            Return
        End If
        'Has not been saved 
        Switched = True
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
        key.SetValue("Wallpaper", "")
        key = Registry.CurrentUser.OpenSubKey("Control Panel\Colors", True)
        key.SetValue("BackGround", "0 0 0")
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "", SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
    End Sub

    Public Shared Sub RestoreWallpaper()
        If WallpaperStyle.Length = 0 OrElse Not Switched Then
            Return
        End If
        'Has not been saved 
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
        key.SetValue("WallpaperStyle", WallpaperStyle)
        key.SetValue("Wallpaper", WallpaperFileName)
        key.SetValue("TileWallpaper", TileWallpaper)
        key = Registry.CurrentUser.OpenSubKey("Control Panel\Colors", True)
        key.SetValue("BackGround", BackGround)
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, WallpaperFileName, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
        Switched = True
    End Sub

End Class