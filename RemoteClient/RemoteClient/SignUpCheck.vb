Public Class SignUpCheck

    Public Shared Function CheckAllcompleted() As Boolean
        If StaffSignUp.Label9.Text = "Ok" And StaffSignUp.Label10.Text = "Ok" And _
            StaffSignUp.Label11.Text = "Ok" And StaffSignUp.Label12.Text = "Ok" And (StaffSignUp.Label13.Text = "Strength: Medium" Or StaffSignUp.Label13.Text = "Strength: Strong") And StaffSignUp.Label14.Text = "Passwords match: Yes" Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function CheckStaffExsts() As Boolean
        Dim Email As String = StaffSignUp.tb_Email.Text & "@" & StaffSignUp.cb_MailService.Text
        If StaffSignUp.SQLConnection.SelectStaffRow(Email, False) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub CheckCharFirstName()
        If StaffSignUp.tb_FirstName.Text.Trim.Length > 30 Then
            StaffSignUp.Label9.Text = "Text too long"
            StaffSignUp.tb_FirstName.BackColor = Color.DarkRed
            StaffSignUp.tb_FirstName.ForeColor = Color.White
        ElseIf StaffSignUp.tb_FirstName.Text.Trim.Length = 1 Or StaffSignUp.tb_FirstName.Text.Trim.Length = 2 Then
            StaffSignUp.Label9.Text = "Text too short"
            StaffSignUp.tb_FirstName.BackColor = Color.Red
            StaffSignUp.tb_FirstName.ForeColor = Color.White
        ElseIf StaffSignUp.tb_FirstName.Text.Trim.Length = 0 Then
            StaffSignUp.Label9.Text = "Empty field"
            StaffSignUp.tb_FirstName.BackColor = Color.LightGray
        Else
            StaffSignUp.Label9.Text = "Ok"
            StaffSignUp.tb_FirstName.BackColor = Color.LightGreen
        End If
    End Sub

    Public Shared Sub CheckCharLastName()

        If StaffSignUp.tb_LastName.Text.Trim.Length > 30 Then
            StaffSignUp.Label10.Text = "Text too long"
            StaffSignUp.tb_LastName.BackColor = Color.DarkRed
            StaffSignUp.tb_LastName.ForeColor = Color.White
        ElseIf StaffSignUp.tb_LastName.Text.Trim.Length = 1 Or StaffSignUp.tb_LastName.Text.Trim.Length = 2 Then
            StaffSignUp.Label10.Text = "Text too short"
            StaffSignUp.tb_LastName.BackColor = Color.Red
            StaffSignUp.tb_LastName.ForeColor = Color.White
        ElseIf StaffSignUp.tb_LastName.Text.Trim.Length = 0 Then
            StaffSignUp.Label10.Text = "Empty field"
            StaffSignUp.tb_LastName.BackColor = Color.LightGray
        Else
            StaffSignUp.Label10.Text = "Ok"
            StaffSignUp.tb_LastName.BackColor = Color.LightGreen
        End If

    End Sub

    Public Shared Sub CheckEmail()
        If StaffSignUp.cb_MailService.Text.Trim.Length = 0 Then
            StaffSignUp.Label11.Text = "Mail service not specified"
            StaffSignUp.cb_MailService.BackColor = Color.LightGray
        ElseIf StaffSignUp.tb_Email.Text.Trim.Length = 0 Then
            StaffSignUp.Label11.Text = "Invalid email"
            StaffSignUp.tb_Email.BackColor = Color.LightGray
        ElseIf Not StaffSignUp.cb_MailService.Text.Contains(".") Then
            StaffSignUp.Label11.Text = "Invalid mail service"
            StaffSignUp.cb_MailService.BackColor = Color.Red
        ElseIf StaffSignUp.tb_Email.Text.Trim.Length + 1 + StaffSignUp.cb_MailService.Text.Trim.Length > 40 Then
            StaffSignUp.Label11.Text = "Email address too long"
            StaffSignUp.tb_Email.BackColor = Color.DarkRed
            StaffSignUp.cb_MailService.BackColor = Color.DarkRed
        ElseIf StaffSignUp.tb_Email.Text.Trim.Length < 4 Then
            StaffSignUp.Label11.Text = "Email address too short"
            StaffSignUp.tb_Email.BackColor = Color.Red
        Else
            StaffSignUp.Label11.Text = "Ok"
            StaffSignUp.tb_Email.BackColor = Color.LightGreen
        End If
    End Sub

    Public Shared Sub CheckMobileNumbber()
        If (StaffSignUp.tb_MobileNo.Text.StartsWith("07") And StaffSignUp.tb_MobileNo.Text.Trim.Length = 11) Or (StaffSignUp.tb_MobileNo.Text.StartsWith("+44") And StaffSignUp.tb_MobileNo.Text.Trim.Length = 13) Then
            StaffSignUp.Label12.Text = "Ok"
            StaffSignUp.tb_MobileNo.BackColor = Color.LightGreen
        ElseIf StaffSignUp.tb_MobileNo.Text.Trim.Length = 0 Then
            StaffSignUp.Label12.Text = "Empty field"
            StaffSignUp.tb_MobileNo.BackColor = Color.LightGray
        ElseIf (StaffSignUp.tb_MobileNo.Text.StartsWith("+44") And StaffSignUp.tb_MobileNo.Text.Trim.Length > 13) Or (StaffSignUp.tb_MobileNo.Text.StartsWith("07") And StaffSignUp.tb_MobileNo.Text.Trim.Length > 11) Then
            StaffSignUp.Label12.Text = "UK mobile number too long"
            StaffSignUp.tb_MobileNo.BackColor = Color.DarkRed
            StaffSignUp.tb_MobileNo.ForeColor = Color.White
        ElseIf (StaffSignUp.tb_MobileNo.Text.StartsWith("+44") And StaffSignUp.tb_MobileNo.Text.Trim.Length < 13) Or (StaffSignUp.tb_MobileNo.Text.StartsWith("07") And StaffSignUp.tb_MobileNo.Text.Trim.Length < 11) Then
            StaffSignUp.Label12.Text = "UK mobile number too short"
            StaffSignUp.tb_MobileNo.BackColor = Color.Red
            StaffSignUp.tb_MobileNo.ForeColor = Color.White
        Else
            StaffSignUp.Label12.Text = "Invalid mobile number, start with '07' or '+44'"
            StaffSignUp.tb_MobileNo.BackColor = Color.Red
            StaffSignUp.tb_MobileNo.ForeColor = Color.White
        End If
    End Sub

    Public Shared Sub CheckPasswordStrength()
        If IsWeak(StaffSignUp.tb_Password.Text) And IsMedium(StaffSignUp.tb_Password.Text) = False And IsMedium(StaffSignUp.tb_Password.Text) = False Then
            StaffSignUp.Label13.Text = "Strength: Weak"
            StaffSignUp.tb_Password.BackColor = Color.Red
        ElseIf IsWeak(StaffSignUp.tb_Password.Text) And IsMedium(StaffSignUp.tb_Password.Text) And IsStrong(StaffSignUp.tb_Password.Text) = False Then
            StaffSignUp.Label13.Text = "Strength: Medium"
            StaffSignUp.tb_Password.BackColor = Color.LightGreen
        ElseIf IsWeak(StaffSignUp.tb_Password.Text) And IsMedium(StaffSignUp.tb_Password.Text) And IsStrong(StaffSignUp.tb_Password.Text) = True Then
            StaffSignUp.Label13.Text = "Strength: Strong"
            StaffSignUp.tb_Password.BackColor = Color.YellowGreen
        Else
            StaffSignUp.Label13.Text = "Empty field"
            StaffSignUp.tb_Password.BackColor = Color.LightGray
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
        If StaffSignUp.tb_re_enterPass.Text = StaffSignUp.tb_Password.Text Then
            Return True
        End If
        Return False
    End Function

End Class
