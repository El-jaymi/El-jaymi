Namespace LibraryManagementSystem
    Public Class Fine
        Public Property FineID As Integer
        Public Property TransactionID As Integer
        Public Property StudentID As Integer
        Public Property Amount As Decimal
        Public Property Reason As String
        Public Property DateIssued As DateTime
        Public Property DatePaid As DateTime?
        Public Property PaymentMethod As String
        Public Property Status As String
        Public Property ProcessedBy As String
        Public Property Notes As String
    End Class
End Namespace
