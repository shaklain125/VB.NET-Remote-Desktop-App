Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Text.RegularExpressions

Public Class LiveChatUC

    Private TClient As TcpClient
    Private sWriter As StreamWriter

    Delegate Sub _xUpdate(ByVal str As String)

    Public Sub New(IPAddress As String)
        InitializeComponent()
        RandomColor()
        ConnectToClient(IPAddress)
    End Sub

    Private Sub xUpdate(ByVal str As String)
        Try
            If TClient.Connected Then
                If InvokeRequired Then
                    Invoke(New _xUpdate(AddressOf xUpdate), str)
                Else
                    TextBox1.AppendText(str & vbNewLine)
                End If
            Else
                TClient.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

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

    Private Sub ConnectToClient(IPAddr As String)
        Try
            TClient = New TcpClient(IPAddr, CInt("3818"))
            TClient.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
            xUpdate("Connected")
        Catch ex As Exception
            xUpdate("Client Not Found")
        End Try
    End Sub

    Public Sub DisconnectFromClient()
        TClient.Close()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
                Return
            Else
                send("Technician: " & TextBox2.Text)
                TextBox2.Text = ""
            End If
        End If
    End Sub

    Private Sub RandomColor()
        Dim rand As New Random
        Me.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
    End Sub

End Class