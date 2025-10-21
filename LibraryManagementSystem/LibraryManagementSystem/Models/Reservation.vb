Namespace LibraryManagementSystem
    Public Class Reservation
        Public Property ReservationID As Integer
        Public Property StudentID As Integer
        Public Property BookID As Integer
        Public Property ReservationDate As DateTime
        Public Property ExpiryDate As DateTime?
        Public Property Status As String
        Public Property NotificationSent As Boolean
        Public Property FulfilledDate As DateTime?
        Public Property Notes As String
    End Class
End Namespace
