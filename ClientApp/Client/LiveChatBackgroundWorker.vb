Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class LiveChatBackgroundWorker

    Private Listening As TcpListener
    Private MessengerClient As MessengerLChat
    Public clientList As New List(Of MessengerLChat)
    Public pReader As StreamReader
    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As Boolean)

#Region "Start/Stop Server"

    Public Sub StartServer()
        Try
            Listening = New TcpListener(IPAddress.Any, 3818)
            Listening.Start()
            Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
        Catch ex As Exception
            Listening.Stop()
        End Try
    End Sub

    Public Sub StopServer()
        If Listening IsNot Nothing Then
            Listening.Server.Close()
            Listening.[Stop]()
        End If
    End Sub

#End Region

#Region "Add/Remove user to/from live chat"

    Private Sub AcceptClient(ByVal ar As IAsyncResult)
        Try
            MessengerClient = New MessengerLChat(Listening.EndAcceptTcpClient(ar))
            AddHandler (MessengerClient.getMessage), AddressOf MessageReceived
            AddHandler (MessengerClient.clientLogout), AddressOf ClientExited
            clientList.Add(MessengerClient)
            Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
        Catch ex As Exception
            Listening.Stop()
        End Try
    End Sub

    Public Sub ClientExited(ByVal client As MessengerLChat)
        clientList.Remove(client)
    End Sub

#End Region

#Region "Message"

    Public Sub send(ByVal str As String)
        For x As Integer = 0 To clientList.Count - 1
            Try
                clientList(x).Send(str)
            Catch ex As Exception
                clientList.RemoveAt(x)
            End Try
        Next
    End Sub

    Public Sub MessageReceived(ByVal str As String)
        UpdateList(str, True)
    End Sub

    Private Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else
            If str = Nothing Then
                Exit Sub
            End If
            ' if relay we will send a string
            If relay Then send(str)
        End If
    End Sub

#End Region

End Class
