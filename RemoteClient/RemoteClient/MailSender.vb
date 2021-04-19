Imports System.Net.Mail
Imports System.Text

Public Class MailSender

    Private ToMail As String
    Private Subject As String
    Private Body As String = ""
    Private HtmlNewline As String = "<p></p>"

    Public Sub New()

    End Sub

    Public Sub SendMail()
        Dim objmessage As New MailMessage()
        Dim objSmtpServer As New SmtpClient()
        With objmessage
            .From = New MailAddress("rdcservice.noreply@gmail.com", "RDC Customer Support")
            .To.Add(New MailAddress(ToMail))
            .Subject = Subject
            .Body = Body
            objSmtpServer.Credentials = New Net.NetworkCredential("rdcservice.noreply@gmail.com", "remoteadminconn")
            objSmtpServer.Port = 587
            objSmtpServer.EnableSsl = True
            objSmtpServer.Host = "smtp.gmail.com"
            objSmtpServer.Send(objmessage)
        End With
        objmessage.Dispose()
        objSmtpServer.Dispose()
    End Sub

    Public Sub ToEmail(Email As String)
        ToMail = Email
    End Sub

    Public Sub SetSubject(Subj As String)
        Subject = Subj
    End Sub

    Public Sub AddNewBodyLine(Text As String)
        Body = String.Format("{0}{1}{2}", Body, HtmlNewline, Text)
    End Sub

    Public Sub AddEmptyLine()
        Body = String.Format("{0}{1}", Body, HtmlNewline)
    End Sub

    Public Sub AppendBodyLine(Text As String)
        Body = String.Format("{0}{1}", Body, Text)
    End Sub

    Public Sub SetBodyOnly(BodyText As String)
        Body = BodyText
    End Sub

End Class
