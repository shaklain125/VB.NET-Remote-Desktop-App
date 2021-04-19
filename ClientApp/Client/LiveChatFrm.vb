Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Text.RegularExpressions

Public Class LiveChatFrm

    Private LiveChatServer As LiveChatBackgroundWorker
    Delegate Sub _xUpdate(ByVal str As String)

#Region "Form"

    Private XCo As Integer
    Private YCo As Integer
    Private ClickCount As Integer
    Private Chat1DefaultHeight As Integer
    Private Chat1DefaultWidth As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeChatLocation()
        LiveChatServer = New LiveChatBackgroundWorker
        LiveChatServer.StartServer()
        ConnectToServer()
    End Sub

#Region "Form Location"

    Private Sub ChangeChatLocation()
        XCo = ((Screen.PrimaryScreen.WorkingArea.Width - Me.Width))
        YCo = ((Screen.PrimaryScreen.WorkingArea.Height - Me.Height))
        Me.Location = New Point(XCo, YCo)
    End Sub

#End Region

#Region "Form Controls"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Visible = False
    End Sub

    Private Sub LChatMinimizeRestoreclick(sender As Object, e As EventArgs) Handles Label2.Click
        ClickCount = ClickCount + 1
        If ClickCount = 1 Then
            Chat1DefaultHeight = Me.Height
            Chat1DefaultWidth = Me.Width
        Else
            ClickCount = 0
        End If
        If Label2.Text = "_" Then
            Me.Size = New Size(Me.Width - 140, 26)
            ChangeChatLocation()
            Label2.Text = "❐"
        Else

            Me.Size = New Size(Chat1DefaultWidth, Chat1DefaultHeight)
            ChangeChatLocation()
            Label2.Text = "_"

        End If
    End Sub

#End Region

#End Region

#Region "Start/Stop LiveChatServer"

    Private TClient As TcpClient
    Private strHostName As String = System.Net.Dns.GetHostName()
    Private strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

    Private Sub ConnectToServer()
        Try
            TClient = New TcpClient(strIPAddress, 3818)
            TClient.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
            xUpdate("Server Online")
        Catch ex As Exception
            xUpdate("Server NOT FOUND")
        End Try
    End Sub

    Public Sub DisconnectFromServer()
        LiveChatServer.StopServer()
        Me.Close()
    End Sub

#End Region

#Region "Read/Write & Display"

    Private sWriter As StreamWriter

    Private Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(TClient.GetStream).ReadLine)
            TClient.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        Catch ex As Exception
            xUpdate("Program not running on client side. Please use other methods of communication.")
            Exit Sub
        End Try
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(TClient.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("Not Connected to client")
        End Try
    End Sub

    Private Sub xUpdate(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            TextBox1.AppendText(str & vbNewLine)
        End If
    End Sub

#End Region

#Region "Send"

    Private Sub TextBox2_KeyDown(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
                Return
            Else
                send("Client: " & TextBox2.Text)
                TextBox2.Text = ""
            End If
        End If
    End Sub

#End Region

End Class