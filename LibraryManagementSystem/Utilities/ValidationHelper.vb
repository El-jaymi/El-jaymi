Option Strict On
Option Explicit On

Imports System.Text.RegularExpressions

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Common input validation helpers.
    ''' </summary>
    Public NotInheritable Class ValidationHelper
        Private Sub New()
        End Sub

        Private Shared ReadOnly EmailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
        Private Shared ReadOnly PhoneRegex As New Regex("^[0-9\-\+\s\(\)]{7,20}$", RegexOptions.Compiled)
        Private Shared ReadOnly RegNumberRegex As New Regex("^[A-Za-z0-9\-]{4,50}$", RegexOptions.Compiled)
        Private Shared ReadOnly IsbnRegex As New Regex("^(97(8|9))?\d{9}(\d|X)$", RegexOptions.Compiled)

        Public Shared Function IsValidEmail(email As String) As Boolean
            If String.IsNullOrWhiteSpace(email) Then Return False
            Return EmailRegex.IsMatch(email.Trim())
        End Function

        Public Shared Function IsValidPhone(phone As String) As Boolean
            If String.IsNullOrWhiteSpace(phone) Then Return False
            Return PhoneRegex.IsMatch(phone.Trim())
        End Function

        Public Shared Function IsValidRegistrationNumber(regNo As String) As Boolean
            If String.IsNullOrWhiteSpace(regNo) Then Return False
            Return RegNumberRegex.IsMatch(regNo.Trim())
        End Function

        Public Shared Function IsValidIsbn(isbn As String) As Boolean
            If String.IsNullOrWhiteSpace(isbn) Then Return False
            Dim candidate As String = isbn.Replace("-", "").Replace(" ", "").ToUpperInvariant()
            Return IsbnRegex.IsMatch(candidate)
        End Function
    End Class
End Namespace
