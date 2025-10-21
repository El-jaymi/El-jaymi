Option Strict On
Option Explicit On

Imports BCryptNet = BCrypt.Net.BCrypt

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Password hashing and verification using BCrypt.
    ''' </summary>
    Public NotInheritable Class PasswordHasher
        Private Sub New()
        End Sub

        Public Shared Function HashPassword(plainText As String) As String
            Return BCryptNet.HashPassword(plainText)
        End Function

        Public Shared Function VerifyPassword(plainText As String, hash As String) As Boolean
            If String.IsNullOrWhiteSpace(hash) Then
                Return False
            End If
            Return BCryptNet.Verify(plainText, hash)
        End Function
    End Class
End Namespace