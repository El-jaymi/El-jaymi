Option Strict On
Option Explicit On

Imports System.Text.RegularExpressions

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Common input validations.
    ''' </summary>
    Public NotInheritable Class ValidationHelper
        Private Sub New()
        End Sub

        Private Shared ReadOnly EmailRegex As New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", RegexOptions.Compiled)
        Private Shared ReadOnly PhoneRegex As New Regex("^[0-9+()\-\s]{7,20}$", RegexOptions.Compiled)
        Private Shared ReadOnly RegNoRegex As New Regex("^[A-Za-z0-9\-]{4,50}$", RegexOptions.Compiled)
        Private Shared ReadOnly StrongPasswordRegex As New Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$", RegexOptions.Compiled)

        Public Shared Function IsValidEmail(value As String) As Boolean
            If String.IsNullOrWhiteSpace(value) Then Return False
            Return EmailRegex.IsMatch(value.Trim())
        End Function

        Public Shared Function IsValidPhone(value As String) As Boolean
            If String.IsNullOrWhiteSpace(value) Then Return False
            Return PhoneRegex.IsMatch(value.Trim())
        End Function

        Public Shared Function IsValidRegistrationNumber(value As String) As Boolean
            If String.IsNullOrWhiteSpace(value) Then Return False
            Return RegNoRegex.IsMatch(value.Trim())
        End Function

        Public Shared Function IsStrongPassword(value As String) As Boolean
            If String.IsNullOrWhiteSpace(value) Then Return False
            Return StrongPasswordRegex.IsMatch(value)
        End Function
    End Class
End Namespace