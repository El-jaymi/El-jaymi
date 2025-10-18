Option Strict On
Option Explicit On

Imports System.Text.RegularExpressions

Namespace LibraryManagement.Utilities
    ''' <summary>
    ''' Common validation helpers for models and forms.
    ''' </summary>
    Public NotInheritable Class ValidationHelper
        Private Sub New()
        End Sub

        Public Shared Function IsNullOrWhiteSpace(value As String) As Boolean
            Return value Is Nothing OrElse value.Trim().Length = 0
        End Function

        Public Shared Function IsValidEmail(email As String) As Boolean
            If IsNullOrWhiteSpace(email) Then Return False
            Dim pattern As String = "^[^\s@]+@[^\s@]+\.[^\s@]+$"
            Return Regex.IsMatch(email, pattern)
        End Function

        Public Shared Function IsDigitsOnly(value As String) As Boolean
            If value Is Nothing Then Return False
            For Each c As Char In value
                If Not Char.IsDigit(c) Then Return False
            Next
            Return True
        End Function
    End Class
End Namespace
