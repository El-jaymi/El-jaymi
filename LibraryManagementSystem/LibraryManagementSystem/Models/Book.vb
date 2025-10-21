Namespace LibraryManagementSystem
    Public Class Book
        Public Property BookID As Integer
        Public Property ISBN As String
        Public Property ISBN10 As String
        Public Property Title As String
        Public Property Author As String
        Public Property Publisher As String
        Public Property PublicationYear As Integer?
        Public Property Edition As String
        Public Property Category As String
        Public Property Language As String
        Public Property Pages As Integer?
        Public Property Description As String
        Public Property ShelfLocation As String
        Public Property CoverImage As Byte()
        Public Property TotalCopies As Integer
        Public Property AvailableCopies As Integer
        Public Property BookCondition As String
        Public Property DateAdded As DateTime
        Public Property AddedBy As String
        Public Property LastUpdated As DateTime
        Public Property IsActive As Boolean
    End Class
End Namespace
