Public Class SignUpCheck

    Public Shared Function CheckAllcompleted() As Boolean
        If ClientSign_up.Label9.Text = "Ok" And ClientSign_up.Label10.Text = "Ok" And _
            ClientSign_up.Label11.Text = "Ok" And ClientSign_up.Label12.Text = "Ok" And (ClientSign_up.Label13.Text = "Strength: Medium" Or ClientSign_up.Label13.Text = "Strength: Strong") And ClientSign_up.Label14.Text = "Passwords match: Yes" Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function CheckClientExsts() As Boolean
        If ClientSign_up.SQLConnection.SelectClientRow(ClientSign_up.tb_Email.Text, False) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub CheckCharFirstName()
        If ClientSign_up.tb_FirstName.Text.Trim.Length > 30 Then
            ClientSign_up.Label9.Text = "Text too long"
            ClientSign_up.tb_FirstName.BackColor = Color.DarkRed
            ClientSign_up.tb_FirstName.ForeColor = Color.White
        ElseIf ClientSign_up.tb_FirstName.Text.Trim.Length = 1 Or ClientSign_up.tb_FirstName.Text.Trim.Length = 2 Then
            ClientSign_up.Label9.Text = "Text too short"
            ClientSign_up.tb_FirstName.BackColor = Color.Red
            ClientSign_up.tb_FirstName.ForeColor = Color.White
        ElseIf ClientSign_up.tb_FirstName.Text.Trim.Length = 0 Then
            ClientSign_up.Label9.Text = "Empty field"
            ClientSign_up.tb_FirstName.BackColor = Color.LightGray
        Else
            ClientSign_up.Label9.Text = "Ok"
            ClientSign_up.tb_FirstName.BackColor = Color.LightGreen
        End If
    End Sub

    Public Shared Sub CheckCharLastName()

        If ClientSign_up.tb_LastName.Text.Trim.Length > 30 Then
            ClientSign_up.Label10.Text = "Text too long"
            ClientSign_up.tb_LastName.BackColor = Color.DarkRed
            ClientSign_up.tb_LastName.ForeColor = Color.White
        ElseIf ClientSign_up.tb_LastName.Text.Trim.Length = 1 Or ClientSign_up.tb_LastName.Text.Trim.Length = 2 Then
            ClientSign_up.Label10.Text = "Text too short"
            ClientSign_up.tb_LastName.BackColor = Color.Red
            ClientSign_up.tb_LastName.ForeColor = Color.White
        ElseIf ClientSign_up.tb_LastName.Text.Trim.Length = 0 Then
            ClientSign_up.Label10.Text = "Empty field"
            ClientSign_up.tb_LastName.BackColor = Color.LightGray
        Else
            ClientSign_up.Label10.Text = "Ok"
            ClientSign_up.tb_LastName.BackColor = Color.LightGreen
        End If

    End Sub

    Public Shared Sub CheckEmail()
        If ClientSign_up.cb_MailService.Text.Trim.Length = 0 Then
            ClientSign_up.Label11.Text = "Mail service not specified"
            ClientSign_up.cb_MailService.BackColor = Color.LightGray
        ElseIf ClientSign_up.tb_Email.Text.Trim.Length = 0 Then
            ClientSign_up.Label11.Text = "Invalid email"
            ClientSign_up.tb_Email.BackColor = Color.LightGray
        ElseIf Not ClientSign_up.cb_MailService.Text.Contains(".") Then
            ClientSign_up.Label11.Text = "Invalid mail service"
            ClientSign_up.cb_MailService.BackColor = Color.Red
        ElseIf ClientSign_up.tb_Email.Text.Trim.Length + 1 + ClientSign_up.cb_MailService.Text.Trim.Length > 40 Then
            ClientSign_up.Label11.Text = "Email address too long"
            ClientSign_up.tb_Email.BackColor = Color.DarkRed
            ClientSign_up.cb_MailService.BackColor = Color.DarkRed
        ElseIf ClientSign_up.tb_Email.Text.Trim.Length < 4 Then
            ClientSign_up.Label11.Text = "Email address too short"
            ClientSign_up.tb_Email.BackColor = Color.Red
        Else
            ClientSign_up.Label11.Text = "Ok"
            ClientSign_up.tb_Email.BackColor = Color.LightGreen
        End If
    End Sub

    Public Shared Sub CheckMobileNumbber()
        If (ClientSign_up.tb_MobileNo.Text.StartsWith("07") And ClientSign_up.tb_MobileNo.Text.Trim.Length = 11) Or (ClientSign_up.tb_MobileNo.Text.StartsWith("+44") And ClientSign_up.tb_MobileNo.Text.Trim.Length = 13) Then
            ClientSign_up.Label12.Text = "Ok"
            ClientSign_up.tb_MobileNo.BackColor = Color.LightGreen
        ElseIf ClientSign_up.tb_MobileNo.Text.Trim.Length = 0 Then
            ClientSign_up.Label12.Text = "Empty field"
            ClientSign_up.tb_MobileNo.BackColor = Color.LightGray
        ElseIf (ClientSign_up.tb_MobileNo.Text.StartsWith("+44") And ClientSign_up.tb_MobileNo.Text.Trim.Length > 13) Or (ClientSign_up.tb_MobileNo.Text.StartsWith("07") And ClientSign_up.tb_MobileNo.Text.Trim.Length > 11) Then
            ClientSign_up.Label12.Text = "UK mobile number too long"
            ClientSign_up.tb_MobileNo.BackColor = Color.DarkRed
            ClientSign_up.tb_MobileNo.ForeColor = Color.White
        ElseIf (ClientSign_up.tb_MobileNo.Text.StartsWith("+44") And ClientSign_up.tb_MobileNo.Text.Trim.Length < 13) Or (ClientSign_up.tb_MobileNo.Text.StartsWith("07") And ClientSign_up.tb_MobileNo.Text.Trim.Length < 11) Then
            ClientSign_up.Label12.Text = "UK mobile number too short"
            ClientSign_up.tb_MobileNo.BackColor = Color.Red
            ClientSign_up.tb_MobileNo.ForeColor = Color.White
        Else
            ClientSign_up.Label12.Text = "Invalid mobile number, start with '07' or '+44'"
            ClientSign_up.tb_MobileNo.BackColor = Color.Red
            ClientSign_up.tb_MobileNo.ForeColor = Color.White
        End If
    End Sub

    Public Shared Sub CheckPasswordStrength()
        If IsWeak(ClientSign_up.tb_Password.Text) And IsMedium(ClientSign_up.tb_Password.Text) = False And IsMedium(ClientSign_up.tb_Password.Text) = False Then
            ClientSign_up.Label13.Text = "Strength: Weak"
            ClientSign_up.tb_Password.BackColor = Color.Red
        ElseIf IsWeak(ClientSign_up.tb_Password.Text) And IsMedium(ClientSign_up.tb_Password.Text) And IsStrong(ClientSign_up.tb_Password.Text) = False Then
            ClientSign_up.Label13.Text = "Strength: Medium"
            ClientSign_up.tb_Password.BackColor = Color.LightGreen
        ElseIf IsWeak(ClientSign_up.tb_Password.Text) And IsMedium(ClientSign_up.tb_Password.Text) And IsStrong(ClientSign_up.tb_Password.Text) = True Then
            ClientSign_up.Label13.Text = "Strength: Strong"
            ClientSign_up.tb_Password.BackColor = Color.YellowGreen
        Else
            ClientSign_up.Label13.Text = "Empty field"
            ClientSign_up.tb_Password.BackColor = Color.LightGray
        End If
    End Sub

    Public Shared Function IsWeak(ByVal pwd As String,
Optional ByVal minLength As Integer = 1,
Optional ByVal numLower As Integer = 0,
Optional ByVal numNumbers As Integer = 0) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Shared Function IsMedium(ByVal pwd As String,
Optional ByVal minLength As Integer = 6,
Optional ByVal numLower As Integer = 1,
Optional ByVal numNumbers As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Shared Function IsStrong(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Shared Function CheckPasswordSecondAttempt() As Boolean
        If ClientSign_up.tb_re_enterPass.Text = ClientSign_up.tb_Password.Text Then
            Return True
        End If
        Return False
    End Function

End Class
