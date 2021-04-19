Public Class ChangePass

#Region "Load"

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSettings.MysqlConn.Connect()
        Label4.Text = ""
        Label5.Text = ""
    End Sub

#End Region

#Region "Focus Handlers"

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        CheckPasswordStrength()
    End Sub

    Private Sub TextBox2_OnFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Label4.Text = ""
    End Sub

    Private Sub tb_re_enterPass_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If CheckPasswordSecondAttempt() = True Then
            If TextBox2.Text.Trim.Length = 0 And TextBox3.Text.Trim.Length = 0 Then
                Label5.Text = "Empty field"
            Else
                Label5.Text = "Passwords match: Yes"
            End If
        Else
            Label5.Text = "Passwords match: No"
        End If
    End Sub

    Private Sub TextBox3_OnFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        Label5.Text = ""
    End Sub

#End Region

#Region "Check Procedures"

    Private Function CheckIfPass(EnteredPass As String)
        If EnteredPass = ClientSettings.MysqlConn.ClientPassword Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckPasswordSecondAttempt() As Boolean
        If TextBox3.Text = TextBox2.Text Then
            Return True
        End If
        Return False
    End Function

#End Region

#Region "Password Strength"

    Private Sub CheckPasswordStrength()
        If IsWeak(TextBox2.Text) And IsMedium(TextBox2.Text) = False And IsMedium(TextBox2.Text) = False Then
            Label4.Text = "Strength: Weak"
        ElseIf IsWeak(TextBox2.Text) And IsMedium(TextBox2.Text) And IsStrong(TextBox2.Text) = False Then
            Label4.Text = "Strength: Medium"
        ElseIf IsWeak(TextBox2.Text) And IsMedium(TextBox2.Text) And IsStrong(TextBox2.Text) = True Then
            Label4.Text = "Strength: Strong"
        Else
            Label4.Text = "Empty field"
        End If
    End Sub

    Private Function IsWeak(ByVal pwd As String,
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

    Private Function IsMedium(ByVal pwd As String,
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

    Private Function IsStrong(ByVal pwd As String,
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

#End Region

#Region "Apply"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ClientSettings.MysqlConn.SelectClientRow(ClientJobs.ClientID, True) = True Then
            If Not TextBox3.Text = TextBox2.Text Then
                MsgBox("New password does not match.")
            Else
                If CheckIfPass(TextBox1.Text) Then
                    Dim ClientID As String = ClientSettings.MysqlConn.ClientID
                    ClientSettings.MysqlConn.UpdatePass(TextBox3.Text, ClientID)
                    MsgBox("Your password has been changed successfully")
                Else
                    MsgBox("Incorrect Password. Please try again")
                End If
            End If
        End If
    End Sub

#End Region

End Class
