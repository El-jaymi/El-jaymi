Option Strict On
Option Explicit On

Imports System.Security.Cryptography
Imports System.Text

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Password hashing using PBKDF2 (Rfc2898). Format: {iterations}.{saltBase64}.{hashBase64}
    ''' </summary>
    Public NotInheritable Class PasswordHasher
        Private Const SaltSize As Integer = 16 ' 128-bit salt
        Private Const HashSize As Integer = 32 ' 256-bit hash
        Private Const DefaultIterations As Integer = 100000

        Private Sub New()
        End Sub

        Public Shared Function HashPassword(plainText As String) As String
            If plainText Is Nothing Then Throw New ArgumentNullException(NameOf(plainText))

            Dim salt(SaltSize - 1) As Byte
            Using rng As New RNGCryptoServiceProvider()
                rng.GetBytes(salt)
            End Using

            Dim hash As Byte()
            Using derive As New Rfc2898DeriveBytes(plainText, salt, DefaultIterations, HashAlgorithmName.SHA256)
                hash = derive.GetBytes(HashSize)
            End Using

            Return $"{DefaultIterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}"
        End Function

        Public Shared Function VerifyPassword(plainText As String, stored As String) As Boolean
            If String.IsNullOrWhiteSpace(plainText) OrElse String.IsNullOrWhiteSpace(stored) Then Return False

            Dim parts As String() = stored.Split("."c)
            If parts.Length <> 3 Then Return False

            Dim iterations As Integer
            If Not Integer.TryParse(parts(0), iterations) Then Return False

            Dim salt As Byte() = Convert.FromBase64String(parts(1))
            Dim storedHash As Byte() = Convert.FromBase64String(parts(2))

            Dim testHash As Byte()
            Using derive As New Rfc2898DeriveBytes(plainText, salt, iterations, HashAlgorithmName.SHA256)
                testHash = derive.GetBytes(storedHash.Length)
            End Using

            Return ConstantTimeEquals(storedHash, testHash)
        End Function

        Private Shared Function ConstantTimeEquals(a As Byte(), b As Byte()) As Boolean
            If a Is Nothing OrElse b Is Nothing OrElse a.Length <> b.Length Then Return False
            Dim diff As Integer = 0
            For i As Integer = 0 To a.Length - 1
                diff = diff Or (a(i) Xor b(i))
            Next
            Return diff = 0
        End Function
    End Class
End Namespace
