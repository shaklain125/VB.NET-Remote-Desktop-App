Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Text

Public Class Listener

    Public Shared ImgWinbackground As Image = Nothing
    Public Shared Closing As Boolean = False
    Private Shared listener As TcpListener = Nothing
    'Used to listen for any new client connections, maximium is 3 at the same time
    Public Shared Service1 As Server = Nothing
    'Servers for 3 client connection, only one used most the time
    Private Shared Service2 As Server = Nothing
    Private Shared Service3 As Server = Nothing
    Private Shared THListen As Thread = Nothing
    'Default one and only main thread used to wait for new connections
    Private Shared FirstConnect As Boolean = True

    Public Shared Sub ListenStart()
        Closing = False
        THListen = New Thread(New ThreadStart(AddressOf Listen))
        THListen.Start()
    End Sub

    Public Shared Sub ListenStop(CloseApp As Boolean)
        Closing = CloseApp
        Dim TH As New Thread(New ThreadStart(AddressOf ListenStopNow))
        TH.Start()
    End Sub

    Private Shared Sub ListenStopNow()
        'Shut down any services and the listener 
        Wallpaper.RestoreWallpaper()
        Dim CloseApp As Boolean = Closing
        Closing = True
        If listener IsNot Nothing Then
            listener.Server.Close()
            listener.[Stop]()
        End If
        If Service1 IsNot Nothing AndAlso Service1.Running Then
            Service1.[Stop]()
        End If
        If Service2 IsNot Nothing AndAlso Service2.Running Then
            Service2.[Stop]()
        End If
        If Service3 IsNot Nothing AndAlso Service3.Running Then
            Service3.[Stop]()
        End If
        If THListen IsNot Nothing Then
            THListen.Abort()
        End If
        If CloseApp Then
            Environment.[Exit](0)
        End If
    End Sub

    Public Shared Function IsClientsConnected() As Boolean
        If Service1 IsNot Nothing AndAlso Service1.Running Then
            Return True
        End If
        If Service2 IsNot Nothing AndAlso Service1.Running Then
            Return True
        End If
        If Service3 IsNot Nothing AndAlso Service1.Running Then
            Return True
        End If
        Return False
    End Function

    Private Shared Sub Listen()
        'Here we are waiting for new conections to come in and can deal with a moximium of 3 clients at the same time
        Dim Soc As Socket = Nothing
        printDebug("Start listen", True)
        Try
            listener = New TcpListener(IPAddress.Any, Settings.Port)
            listener.Start()
            While THListen IsNot Nothing
                Soc = listener.AcceptSocket()
                printDebug("Connect " & Soc.RemoteEndPoint.ToString(), True)
                Dim Msg As String = Settings.ScreenServerX & " " & Settings.ScreenServerY & " " & Screen.PrimaryScreen.Bounds.Width & " " & Screen.PrimaryScreen.Bounds.Height & " " & FirstConnect.ToString()
                FirstConnect = False
                Dim BMsg As Byte() = ASCIIEncoding.ASCII.GetBytes(Msg)
                Soc.Send(BMsg, BMsg.Length, SocketFlags.None)
                If Service1 Is Nothing OrElse Not Service1.Running Then
                    Service1 = New Server()
                    Service1.Start(Settings.Port, Soc, Settings.ScreenServerX, Settings.ScreenServerY)
                ElseIf Service2 Is Nothing OrElse Not Service2.Running Then
                    Service2 = New Server()
                    Service2.Start(Settings.Port, Soc, Settings.ScreenServerX, Settings.ScreenServerY)
                ElseIf Service3 Is Nothing OrElse Not Service3.Running Then
                    Service3 = New Server()
                    Service3.Start(Settings.Port, Soc, Settings.ScreenServerX, Settings.ScreenServerY)
                End If
            End While
            listener.[Stop]()
        Catch Ex As Exception
            printDebug("Error listen " & Ex.Message, True)
        End Try
    End Sub

    Public Shared Sub printDebug(Msg As String, Force As Boolean)
        If Closing Then
            Return
        End If
        If (Settings.Debug OrElse Force) AndAlso Settings.FormService IsNot Nothing Then
            Settings.FormService.Invoke(DirectCast(Sub() Settings.DebugPrint.printDebug(Msg, Force), MethodInvoker))
        End If
    End Sub

End Class
