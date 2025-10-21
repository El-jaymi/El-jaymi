Imports System.Security.Cryptography
Imports System.Text

Namespace LibraryManagementSystem
    Public NotInheritable Class PasswordHasher
        Private Sub New()
        End Sub

        Public Shared Function HashPassword(password As String) As String
            If password Is Nothing Then password = String.Empty
            Using sha As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
                Dim hash As Byte() = sha.ComputeHash(bytes)
                Return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant()
            End Using
        End Function

        Public Shared Function VerifyPassword(password As String, hash As String) As Boolean
            Dim computed As String = HashPassword(password)
            Return String.Equals(computed, hash, StringComparison.OrdinalIgnoreCase)
        End Function
    End Class
End Namespace
