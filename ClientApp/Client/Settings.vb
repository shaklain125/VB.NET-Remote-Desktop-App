Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Text
Imports Microsoft.Win32

Public Class Settings

    Public Shared MainProgramName As String = "RDS Remote desktop server"
    Public Shared PassWord As String = "remoteadminconn"
    Public Shared FormService As ServerFrm = Nothing
    Public Shared DebugPrint As New Debug
    Public Shared Port As Integer = 4000
    Public Shared Debug As Boolean = False
    Public Shared ScreenServerX As Integer = 1920
    Public Shared ScreenServerY As Integer = 1080
    Public Shared JobID As Integer
    Public Shared IPAd As String

    Public Shared Sub LoadSettings()
        Settings.ScreenServerX = Screen.PrimaryScreen.Bounds.Width + 5
        Settings.ScreenServerY = Screen.PrimaryScreen.Bounds.Height + 5
        Settings.ScreenServerX = Integer.Parse(LoadSetting("ScreenServerX", Settings.ScreenServerX.ToString()))
        Settings.ScreenServerY = Integer.Parse(LoadSetting("ScreenServerY", Settings.ScreenServerY.ToString()))
    End Sub

    Public Shared Sub SaveSettings()
        SaveSetting("ScreenServerX", Settings.ScreenServerX.ToString())
        SaveSetting("ScreenServerY", Settings.ScreenServerY.ToString())
    End Sub

    Public Shared Sub SaveJobID()
        SaveSetting("JobID", Settings.JobID.ToString())
    End Sub

    Public Shared Sub LoadJobID()
        Settings.JobID = Integer.Parse(LoadSetting("JobID", Settings.JobID.ToString()))
    End Sub

    Public Shared Sub SaveIP()
        SaveSetting("IPAddress", IPAd)
    End Sub

    Public Shared Sub LoadIP()
        IPAd = LoadSetting("IPAddress", IPAd)
    End Sub

    Public Shared Sub SaveSetting(Name As String, Value As String)
        Try
            Dim Root As RegistryKey = Registry.CurrentUser.CreateSubKey(MainProgramName)
            Root.SetValue(Name, Value)
        Catch


        End Try
    End Sub

    Public Shared Function LoadSetting(Name As String, [Default] As String) As String
        Dim Root As RegistryKey = Registry.CurrentUser.CreateSubKey(MainProgramName)
        Try
            Return Root.GetValue(Name).ToString()
        Catch
            SaveSetting(Name, [Default])
            Return [Default]
        End Try
    End Function

End Class