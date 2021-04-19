Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.IO

Public Class JobRequestSender

    Public Shared ClientID As String
    'Public JobTitle As String = ""
    Public JobProblems As String = ""
    Private JobDateTime As DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 'DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Private JobApproval As Boolean = False
    Private JobCompletion As Boolean = False
    Private JobDeclined As Boolean = False
    Private PaymentReceived As Boolean = False
    Public ExtraJobTitle As String = ""
    Public ExtraJobProblems As String = ""
    Public Shared SentDateTime As DateTime

    Public Sub New()

    End Sub

    Public Sub Send()
        ClientID = LogIn.AuthUsr
        ClientSystem.SQLConnection.SelectClientRow(ClientID, True)
        ClientID = ClientSystem.SQLConnection.ClientID
        SentDateTime = JobDateTime
        SendJobRequest(JobProblems, ExtraJobTitle, ExtraJobProblems, JobDateTime, JobApproval, JobCompletion, JobDeclined, PaymentReceived, ClientID)
    End Sub

    Private Sub SendJobRequest(JobProblems As String, ExtraJobTitle As String, ExtraJobProblems As String, JobDateTimes As String, JobApproval As Boolean, JobCompletion As Boolean, JobDeclined As Boolean, PaymentReceived As Boolean, ID As String)
        ClientSystem.SQLConnection.AddJob(JobProblems, ExtraJobTitle, ExtraJobProblems, JobDateTime.ToString("yyyy-MM-dd HH:mm:ss"), JobApproval, JobCompletion, JobDeclined, PaymentReceived, ID)
    End Sub

End Class
