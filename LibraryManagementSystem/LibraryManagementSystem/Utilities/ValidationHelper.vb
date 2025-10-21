Imports System.Text.RegularExpressions

Namespace LibraryManagementSystem
    Public NotInheritable Class ValidationHelper
        Private Sub New()
        End Sub

        Public Shared Function IsEmailValid(email As String) As Boolean
            If String.IsNullOrWhiteSpace(email) Then Return False
            Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            Return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase)
        End Function

        Public Shared Function IsRegistrationNumberValid(regNo As String) As Boolean
            If String.IsNullOrWhiteSpace(regNo) Then Return False
            Return Regex.IsMatch(regNo, "^REG-\d{4}$")
        End Function

        Public Shared Function EvaluatePasswordStrength(password As String) As Integer
            If password Is Nothing Then Return 0
            Dim score As Integer = 0
            If password.Length >= 8 Then score += 1
            If Regex.IsMatch(password, "[A-Z]") Then score += 1
            If Regex.IsMatch(password, "\d") Then score += 1
            If Regex.IsMatch(password, "[^A-Za-z0-9]") Then score += 1
            Return score
        End Function
    End Class
End Namespace
