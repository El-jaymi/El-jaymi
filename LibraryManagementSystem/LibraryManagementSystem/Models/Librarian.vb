Namespace LibraryManagementSystem
    Public Class Librarian
        Public Property LibrarianID As Integer
        Public Property Username As String
        Public Property PasswordHash As String
        Public Property FullName As String
        Public Property Email As String
        Public Property Phone As String
        Public Property Role As String
        Public Property DateCreated As DateTime
        Public Property LastLogin As DateTime?
        Public Property IsActive As Boolean
        Public Property CreatedBy As String
        Public Property ProfilePicture As Byte()
    End Class
End Namespace
