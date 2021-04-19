Imports Mysql.data
Imports MySql.Data.MySqlClient

Public Class MySQLStaffConnection

    Private Connection As New MySqlConnection 'creating a new instance of MysSQLconnection
    Public SQLCMD As MySqlCommand
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
            MsgBox(ex.Message)
        End Try

        Connection.Close()

    End Sub

    Public Function LogIn(IDorEmail As String, Password As String) As Boolean
        Dim S As String = "SELECT StaffID FROM Staff"
        Dim W As String = String.Format("Where (StaffID='{0}' AND StaffPassword='{1}') or (EmailAddress='{0}' AND StaffPassword='{1}')", IDorEmail, Password)
        Dim LogInQuery As String = String.Format("{0} {1}", S, W)
        If SelectRow(Nothing, False, Nothing, False, LogInQuery) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function SelectRow(StaffIDorEmail As String, GetStaffInfo As Boolean, ClientIDorEmail As String, GetClientInfo As Boolean, Optional NewQuery As String = Nothing) As Boolean
        Dim Query As String
        If NewQuery = Nothing Then
            If ClientIDorEmail = Nothing Then
                Query = String.Format("SELECT * FROM Staff Where StaffID='{0}' or EmailAddress='{0}' ", StaffIDorEmail)
            ElseIf ClientIDorEmail = Nothing AndAlso StaffIDorEmail = Nothing Then
                Return False
            Else
                Query = String.Format("SELECT * FROM Client Where ClientID='{0}' or EmailAddress='{0}' ", ClientIDorEmail)
            End If
        Else
            Query = NewQuery
        End If
        RunQuery(Query)
        If SQLDS.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If GetStaffInfo = True Then
                StaffIDS = SQLDS.Tables(0).Rows(0).Item("StaffID")
                StaffFirstNameS = SQLDS.Tables(0).Rows(0).Item("FirstName")
                StaffLastNameS = SQLDS.Tables(0).Rows(0).Item("LastName")
                StaffEmailS = SQLDS.Tables(0).Rows(0).Item("EmailAddress")
                StaffPhoneNumberS = SQLDS.Tables(0).Rows(0).Item("PhoneNumber")
                StaffPassS = SQLDS.Tables(0).Rows(0).Item("StaffPassword")
                If SQLDS.Tables(0).Rows(0).Item("IsAdmin") = "1" Then
                    IsAdminS = True
                Else
                    IsAdminS = False
                End If
            End If
            If GetClientInfo = True Then
                ClientIDC = SQLDS.Tables(0).Rows(0).Item("ClientID")
                ClientFirstNameC = SQLDS.Tables(0).Rows(0).Item("FirstName")
                ClientLastNameC = SQLDS.Tables(0).Rows(0).Item("LastName")
                ClientEmailC = SQLDS.Tables(0).Rows(0).Item("EmailAddress")
                ClientPhoneNumberC = SQLDS.Tables(0).Rows(0).Item("PhoneNumber")
                ClientPassC = SQLDS.Tables(0).Rows(0).Item("ClientPassword")
                ClientIPC = SQLDS.Tables(0).Rows(0).Item("IPAddress")
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

    Public Sub UpdateCommand()
        SQLDA.UpdateCommand = New MySqlClient.MySqlCommandBuilder(SQLDA).GetUpdateCommand
    End Sub

#Region "Staff"

    Private StaffIDS As String
    Private StaffFirstNameS As String
    Private StaffLastNameS As String
    Private StaffEmailS As String
    Private StaffPassS As String
    Private StaffPhoneNumberS As String
    Private IsAdminS As Boolean

    Public Sub AddStaff(FirstName As String, LastName As String, Email As String, MailService As String, MobileNo As String, Password As String)
        Dim AddStaffQuery As String = "INSERT INTO Staff(FirstName, LastName, EmailAddress, PhoneNumber, StaffPassword)" & _
                               "Values('" & FirstName & "', '" & LastName & "', '" & Email & "@" & MailService & "', '" & MobileNo & "', '" & Password & "') "
        RunQuery(AddStaffQuery)
    End Sub

    Public Function SelectStaffRow(StaffIDorEmail As String, GetStaffInfo As Boolean) As Boolean
        If SelectRow(StaffIDorEmail, GetStaffInfo, Nothing, False) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckifStaffID(StaffIDOrEmail As String) As String
        SelectStaffRow(StaffIDOrEmail, True)
        Return StaffID()
    End Function

    Public Sub GetStaff()
        Dim Query As String = "Select * From Staff"
        RunQuery(Query)
    End Sub

    Public Function StaffID() As String
        Return StaffIDS
    End Function

    Public Function StaffFirstName() As String
        Return StaffFirstNameS
    End Function

    Public Function StaffLatName() As String
        Return StaffLastNameS
    End Function

    Public Function StaffEmail() As String
        Return StaffEmailS
    End Function

    Public Function StaffPassword() As String
        Return StaffPassS
    End Function

    Public Function StaffPhoneNumber() As String
        Return StaffPassS
    End Function

    Public Function StaffIsAdmin() As Boolean
        Return IsAdminS
    End Function

#End Region

#Region "Client"

    Private ClientIDC As String
    Private ClientFirstNameC As String
    Private ClientLastNameC As String
    Private ClientEmailC As String
    Private ClientPassC As String
    Private ClientIPC As String
    Private ClientPhoneNumberC As String

    Public Sub GetClients()
        Dim Query As String = "Select * From Client"
        RunQuery(Query)
    End Sub

    Public Function SelectClientRow(ClientIDorEmail As String, GetClientInfo As Boolean) As Boolean
        If SelectRow(Nothing, False, ClientIDorEmail, GetClientInfo) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub GetClientIP(JobID As String)
        Dim Query As String = "Select Client.IPAddress FROM Job, Client WHERE Job.JobID=" & JobID & " AND Job.ClientID = Client.ClientID"
        RunQuery(Query)
    End Sub

    Public Function GetClientEmail(JobID As String) As String
        Dim Query As String = "Select Client.EmailAddress FROM Job, Client WHERE Job.JobID=" & JobID & " AND Job.ClientID = Client.ClientID"
        RunQuery(Query)
        Return SQLDS.Tables(0).Rows(0).Item("EmailAddress")
    End Function

    Public Function GetClientID(JobID As String) As String
        Dim Query As String = "Select Client.ClientID FROM Job, Client WHERE Job.JobID=" & JobID & " AND Job.ClientID = Client.ClientID"
        RunQuery(Query)
        Return SQLDS.Tables(0).Rows(0).Item("ClientID")
    End Function

    Public Function ClientID() As String
        Return ClientIDC
    End Function

    Public Function ClientFirstName() As String
        Return ClientFirstNameC
    End Function

    Public Function ClientLastName() As String
        Return ClientLastNameC
    End Function

    Public Function ClientEmail() As String
        Return ClientEmailC
    End Function

    Public Function ClientPassword() As String
        Return ClientPassC
    End Function

    Public Function ClientPhoneNumber() As String
        Return ClientPhoneNumberC
    End Function

    Public Function ClientIPAddress() As String
        Return ClientIPC
    End Function

#End Region

#Region "Job"

    Public Sub GetJobsPending()
        Dim Query As String = "Select * From Job Where JobApproval = 0 AND JobCompletion = 0 AND JobDeclined = 0"
        RunQuery(Query)
    End Sub

    Public Sub GetJobsApproved()
        Dim Query As String = "Select * From Job Where JobApproval = 1 AND JobCompletion = 0 AND JobDeclined = 0"
        RunQuery(Query)
    End Sub

    Public Sub GetJobsDeclined()
        Dim Query As String = "Select * From Job Where JobApproval = 0 AND JobCompletion = 0 AND JobDeclined = 1"
        RunQuery(Query)
    End Sub

    Public Sub GetJobsCompleted()
        Dim Query As String = "Select * From Job Where JobApproval = 0 AND JobCompletion = 1 AND JobDeclined = 0"
        RunQuery(Query)
    End Sub

    Public Sub JobApprove(JobID As String)
        Dim Query As String = "UPDATE Job Set JobDeclined=0, JobCompletion=0, JobApproval=1 Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub SetJobDelayNote(JobID As String, Note As String)
        Dim Query As String = "UPDATE Job Set JobDelayNote='" & Note & "' Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub JobReAccept(JobID As String)
        Dim Query As String = "UPDATE Job Set JobReAccept=1 Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub JobComplete(JobID As String)
        Dim Query As String = "UPDATE Job Set JobDeclined=0, JobCompletion=1, JobApproval=0 Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub JobDecline(JobID As String)
        Dim Query As String = "UPDATE Job Set JobDeclined=1, JobCompletion=0, JobApproval=0 Where JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub GetJobStatus(JobID As String)
        Dim Query As String = "Select Job.JobCompletion, Job.JobDeclined, Job.JobApproval FROM Job, Client WHERE Job.JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub GetJobProblems(JobID As String)
        Dim Query As String = "Select Job.JobProblems FROM Job, Client WHERE Job.JobID=" & JobID
        RunQuery(Query)
    End Sub

    Public Sub SetStafftoClient(JobID As String)
        Dim StaffIDOrEmail As String = WelcomeScreen.AuthUsr
        Dim Query As String = "UPDATE Job Set StaffID=" & CheckifStaffID(StaffIDOrEmail) & " Where JobID=" & JobID
        RunQuery(Query)
    End Sub

#End Region

#Region "Screen"

    Private ScreenRID As String

    Public Sub RecordServiceTime(ServiceTime As String, RecordedDateTime As String, JobID As String)
        If CheckServiceTimeExists(JobID, ServiceTime, RecordedDateTime) = False Then
            NewServiceTime(ServiceTime, RecordedDateTime)
            GetScreenID(RecordedDateTime)
        End If
    End Sub

    Private Sub NewServiceTime(ServiceTime As String, RecordedDateTime As String)
        Dim Query As String = String.Format("INSERT INTO ScreenR(ServiceTime,RecordedDateTime) Values('{0}','{1}')", ServiceTime, RecordedDateTime)
        RunQuery(Query)
    End Sub

    Private Sub UpdateServiceTime(ServiceTime As String, RecordedDateTime As String, ScreenRID As String)
        Dim Query As String = String.Format("UPDATE ScreenR Set ServiceTime='{0}', RecordedDateTime='{1}' Where ScreenRID={2}", ServiceTime, RecordedDateTime, ScreenRID)
        RunQuery(Query)
    End Sub

    Private Function CheckServiceTimeExists(JobID As String, ServiceTime As String, RecordedDateTime As String) As Boolean
        Dim Query As String = String.Format("Select Count(Job.ScreenRID), Job.ScreenRID From Job Where JobID={0}", JobID)
        RunQuery(Query)
        Dim ScreenRIDCount As String = SQLDS.Tables(0).Rows(0).Item("Count(Job.ScreenRID)")
        If ScreenRIDCount = "1" Then
            Dim ScreenID As String = SQLDS.Tables(0).Rows(0).Item("ScreenRID")
            UpdateServiceTime(ServiceTime, RecordedDateTime, ScreenID)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub GetScreenID(RecordedDateTime As String)
        Dim GetScreenIDQuery As String = String.Format("Select ScreenRID From ScreenR Where ScreenR.RecordedDateTime='{0}'", RecordedDateTime)
        Try
            Connection.Open()
            SQLCMD = New MySqlCommand(GetScreenIDQuery, Connection)
            SQLDA = New MySqlDataAdapter(SQLCMD)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            ScreenRID = SQLDS.Tables(0).Rows(0).Item("ScreenRID")
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
        End Try
    End Sub

    Public Function GetScreenRID() As String
        Return ScreenRID
    End Function

    Public Sub AddScreenID(JobID As String, ScreenRID As String)
        Dim Query As String = String.Format("UPDATE Job Set ScreenRID={0} Where JobID={1}", ScreenRID, JobID)
        RunQuery(Query)
    End Sub

#End Region

End Class