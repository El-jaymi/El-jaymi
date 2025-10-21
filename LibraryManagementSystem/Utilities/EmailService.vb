Option Strict On
Option Explicit On

Imports System.Net
Imports System.Net.Mail
Imports System.Configuration

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' SMTP email sender using appSettings configuration.
    ''' </summary>
    Public NotInheritable Class EmailService
        Private Sub New()
        End Sub

        Public Shared Sub SendEmail(toAddress As String, subject As String, body As String)
            Try
                Dim smtpServer As String = ConfigurationManager.AppSettings("SMTPServer")
                Dim smtpPort As Integer = Integer.Parse(ConfigurationManager.AppSettings("SMTPPort"))
                Dim username As String = ConfigurationManager.AppSettings("SMTPUsername")
                Dim password As String = ConfigurationManager.AppSettings("SMTPPassword")

                Using client As New SmtpClient(smtpServer, smtpPort)
                    client.EnableSsl = True
                    client.Credentials = New NetworkCredential(username, password)
                    Dim mail As New MailMessage()
                    mail.From = New MailAddress(username)
                    mail.To.Add(toAddress)
                    mail.Subject = subject
                    mail.Body = body
                    mail.IsBodyHtml = False
                    client.Send(mail)
                End Using
            Catch ex As Exception
                Logger.LogError("Failed to send email", ex)
                Throw
            End Try
        End Sub
    End Class
End Namespace