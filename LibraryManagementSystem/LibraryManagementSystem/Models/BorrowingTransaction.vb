Namespace LibraryManagementSystem
    Public Class BorrowingTransaction
        Public Property TransactionID As Integer
        Public Property StudentID As Integer
        Public Property BookID As Integer
        Public Property BorrowDate As DateTime
        Public Property DueDate As DateTime
        Public Property ReturnDate As DateTime?
        Public Property Status As String
        Public Property BorrowingPeriodDays As Integer
        Public Property RenewalCount As Integer
        Public Property MaxRenewals As Integer
        Public Property FineAmount As Decimal
        Public Property FinePaid As Boolean
        Public Property IssuedBy As String
        Public Property ReturnedTo As String
        Public Property BookConditionOnReturn As String
        Public Property DaysOverdue As Integer
        Public Property Notes As String
    End Class
End Namespace
