Imports Mysql.data
Imports MySql.Data.MySqlClient

Public Class MySQLClientConnection

    Private Connection As New MySqlConnection 'creating a new instance of MysSQLconnection
    Private SQLCMD As MySqlCommand
    Public SQLDA As MySqlDataAdapter
    Public SQLDS As DataSet
    Public MyData As MySqlDataReader
    Public MySQLConnectionState As Boolean = False

    Public Sub Connect()

        Dim server As String = "mysql8.db4free.net"
        Dim dbname As String = "remotedc_db"
        Dim username As String = "remotedc_admin"
        Dim password As String = "remoteadminconn"

        If Not Connection Is Nothing Then Connection.Close()
        Connection.ConnectionString = String.Format("server={0};Port=3307; user id={1}; password={2}; database={3}; pooling=False", server, username, password, dbname)

        Try
            Connection.Open()
            If Connection.State = ConnectionState.Open Then
                MySQLConnectionState = True
            End If
        Catch ex As Exception

        End Try

        Connection.Close()

    End Sub

    Public Function LogIn(IDorEmail As String, Password As String) As Boolean
        Dim S As String = "SELECT ClientID FROM Client"
        Dim W As String = String.Format("Where (ClientID='{0}' AND Clientpassword='{1}') or (EmailAddress='{0}' AND Clientpassword='{1}') ", IDorEmail, Password)
        Dim LogInQuery As String = String.Format("{0} {1}", S, W)
        If SelectRow(Nothing, False, Nothing, False, LogInQuery) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function SelectRow(IDorEmail As String, GetClientInfo As Boolean, JobID As String, GetJobInfo As Boolean, Optional NewQuery As String = Nothing) As Boolean
        Dim Query As String
        If NewQuery = Nothing Then
            If JobID = Nothing Then
                Query = String.Format("Select * From Client Where ClientID = '{0}' or EmailAddress = '{0}'", IDorEmail)
            ElseIf JobID = Nothing And IDorEmail = Nothing Then
                Return False
            Else
                Query = String.Format("Select * From Job Where JobID = '{0}'", JobID)
            End If
        Else
            Query = NewQuery
        End If
        RunQuery(Query)
        If SQLDS.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If GetClientInfo = True Then
                IdC = SQLDS.Tables(0).Rows(0).Item("ClientID")
                FirstNameC = SQLDS.Tables(0).Rows(0).Item("FirstName")
                LastNameC = SQLDS.Tables(0).Rows(0).Item("LastName")
                IPAddC = SQLDS.Tables(0).Rows(0).Item("IPAddress")
                EmailC = SQLDS.Tables(0).Rows(0).Item("EmailAddress")
                PhoneC = SQLDS.Tables(0).Rows(0).Item("PhoneNumber")
                PassC = SQLDS.Tables(0).Rows(0).Item("ClientPassword")
            End If
            If GetJobInfo = True Then
                JobIdC = SQLDS.Tables(0).Rows(0).Item("JobID")
                JobApprovedC = SQLDS.Tables(0).Rows(0).Item("JobApproval")
                JobDeclinedC = SQLDS.Tables(0).Rows(0).Item("JobDeclined")
                JobCompletedC = SQLDS.Tables(0).Rows(0).Item("JobCompletion")
                If Not String.IsNullOrEmpty(SQLDS.Tables(0).Rows(0).Item("JobDelayNote")) Then
                    JobDelayNoteC = SQLDS.Tables(0).Rows(0).Item("JobDelayNote")
                Else
                    JobDelayNoteC = ""
                End If
            End If
            Return True
        End If
    End Function

    Private Sub RunQuery(Query As String)
        Try
            Connection.Open()
            SQLCMD = New MySqlCommand(Query, Connection)
            SQLDA = New MySqlDataAdapter(SQLCMD)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
        End Try
    End Sub

#Region "Public IP"

    Private IPGrabber As WebTextGrabber
    Private PublicIPClient As String

    Public Function CheckIPExists() As Boolean
        IPGrabber = New WebTextGrabber(Nothing)
        PublicIPClient = IPGrabber.GetIPAddress
        Dim CheckIPQuery As String = String.Format("SELECT IPAddress FROM Client Where IPAddress='{0}'", PublicIPClient)
        If SelectRow(Nothing, False, Nothing, False, CheckIPQuery) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub UpdateChangedIP(IP As String)
        IPGrabber = New WebTextGrabber(Nothing)
        PublicIPClient = IPGrabber.GetIPAddress()
        Dim Query As String = "UPDATE Client Set IPAddress='" & PublicIPClient & "' Where IPAddress='" & IP & "'"
        RunQuery(Query)
    End Sub

#End Region
    
#Region "Client"

    Private IdC As String
    Private FirstNameC As String
    Private LastNameC As String
    Private EmailC As String
    Private PassC As String
    Private IPAddC As String
    Private PhoneC As String

    Public Function SelectClientRow(ClientID As String, GetClientInfo As Boolean) As Boolean
        If SelectRow(ClientID, GetClientInfo, Nothing, False) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub AddClient(FirstName As String, LastName As String, IPAddr As String, Email As String, MailService As String, MobileNo As String, Password As String)
        Dim InsertInto As String = "INSERT INTO Client(FirstName, LastName, IPAddress, EmailAddress, PhoneNumber, ClientPassword)"
        Dim Values As String = String.Format("Values('{0}','{1}','{2}','{3}@{4}','{5}','{6}') ", FirstName, LastName, IPAddr, Email, MailService, MobileNo, Password)
        Dim Query As String = String.Format("{0} {1}", InsertInto, Values)
        RunQuery(Query)
    End Sub

    Public Function WelcomeMessage() As String
        Return String.Format("Welcome {0}, {1}", FirstNameC, LastNameC)
    End Function

    Public Function ClientID() As String
        Return IdC
    End Function

    Public Function FirstName() As String
        Return FirstNameC
    End Function

    Public Function LastName() As String
        Return LastNameC
    End Function

    Public Function IPAddress() As String
        Return IPAddC
    End Function

    Public Function PhoneNumber() As String
        Return PhoneC
    End Function

    Public Function EmailAddress() As String
        Return EmailC
    End Function

    Public Function ClientPassword() As String
        Return PassC
    End Function

    Public Sub UpdateEmail(Email As String, ClientID As String)
        Dim Query As String = String.Format("UPDATE Client Set EmailAddress='{0}' Where ClientID={1}", Email, ClientID)
        RunQuery(Query)
    End Sub

    Public Sub UpdateFName(FName As String, ClientID As String)
        Dim Query As String = String.Format("UPDATE Client Set FirstName = '{0}' Where ClientID = {1}", FName, ClientID)
        RunQuery(Query)
    End Sub

    Public Sub UpdateLName(LName As String, ClientID As String)
        Dim Query As String = String.Format("UPDATE Client Set LastName = '{0}' Where ClientID = {1}", LName, ClientID)
        RunQuery(Query)
    End Sub

    Public Sub UpdatePass(Password As String, ClientID As String)
        Dim Query As String = String.Format("UPDATE Client Set ClientPassword = '{0}' Where ClientID={1}", Password, ClientID)
        RunQuery(Query)
    End Sub

    Public Sub ReturnJobReAcceptToDefault(JobID As String)
        Dim Query As String = "UPDATE Job Set JobReAccept=0 Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Function GetClientEmail(JobID As String) As String
        Dim Query As String = "Select Client.EmailAddress FROM Job, Client WHERE Job.JobID=" & JobID & " AND Job.ClientID = Client.ClientID"
        RunQuery(Query)
        Return SQLDS.Tables(0).Rows(0).Item("EmailAddress")
    End Function

    Public Function GetClientPassword(JobID As String) As String
        Dim Query As String = String.Format("Select Client.ClientPassword From Job, Client Where JobID={0} AND Job.ClientID = Client.ClientID", JobID)
        RunQuery(Query)
        Return SQLDS.Tables(0).Rows(0).Item("ClientPassword")
    End Function

#End Region

#Region "Job"

    Private JobIdC As String
    Private JobApprovedC As Boolean
    Private JobDeclinedC As Boolean
    Private JobCompletedC As Boolean
    Private JobDelayNoteC As String
    Private JobReAcceptC As Boolean

    Public Sub AddJob(JobProblems As String, ExtraJobTitle As String, ExtraJobProblems As String, JobRequestDateTime As String, JobApproval As Boolean, JobCompletion As Boolean, JobDeclined As Boolean, PaymentReceived As Boolean, ClientID As Integer)
        Dim Query As String = String.Format("INSERT INTO Job(JobProblems, ExtraJobTitle, ExtraJobProblems, JobRequestDateTime, JobApproval, JobCompletion, JobDeclined, PaymentReceived, ClientID)" & _
                                    "Values('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8})", _
                                    JobProblems, ExtraJobTitle, ExtraJobProblems, JobRequestDateTime, JobApproval, JobCompletion, JobDeclined, PaymentReceived, ClientID)
        RunQuery(Query)
    End Sub

    Public Sub RemoveJob(JobID As String)
        Dim Query As String = "DELETE FROM Job WHERE JobID = " & JobID
        RunQuery(Query)
    End Sub

    Public Function LookForJobID(ClientID As String, JDateTime As String) As String
        Dim Query As String = "Select JobID From Job, Client Where Job.JobRequestDateTime='" & JDateTime & "' AND Job.ClientID=" & ClientID & " AND Client.ClientID=" & ClientID
        RunQuery(Query)
        JobIdC = SQLDS.Tables(0).Rows(0).Item("JobID")
        Return JobIdC
    End Function

    Public Function SelectJobRow(JobID As String, GetJobInfo As Boolean) As Boolean
        If SelectRow(Nothing, False, JobID, GetJobInfo) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function JobID() As String
        Return JobIdC
    End Function

    Public Function JobApproved() As Boolean
        Return JobApprovedC
    End Function

    Public Function JobDeclined() As Boolean
        Return JobDeclinedC
    End Function

    Public Function JobCompleted() As Boolean
        Return JobCompletedC
    End Function

    Public Function JobDelayNote() As String
        Return JobDelayNoteC
    End Function

    Public Function JobReAccept() As String
        Return JobReAcceptC
    End Function

#End Region

End Class
