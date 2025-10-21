Option Strict On
Option Explicit On

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Central place for application constants to avoid magic numbers/strings.
    ''' </summary>
    Public NotInheritable Class Constants
        Private Sub New()
        End Sub

        ' Roles
        Public Const RoleStudent As String = "Student"
        Public Const RoleLibrarian As String = "Librarian"
        Public Const RoleAdmin As String = "Admin"

        ' Business rules defaults (may be overridden by App.config)
        Public Const DefaultBorrowDays As Integer = 14
        Public Const DefaultMaxRenewals As Integer = 2
        Public Const DefaultFinePerDay As Decimal = 0.5D
        Public Const DefaultMaxBorrowingLimit As Integer = 5
        Public Const DefaultReservationHoldHours As Integer = 48

        ' Colors (HEX as comments)
        ' Primary background: Milky cream (#FFF8E7 / #FFFEF2)
        ' Accent: Soft sage green (#8FBC8F / #98D8A0)
        ' Secondary green: Forest green (#2D5016 / #4A7C3C)
        ' Text: Dark charcoal (#2C2C2C)
        ' Border accents: Light olive green (#C1D5A4)

        ' Logging
        Public Const DefaultLogPath As String = "logs/app.log"

        ' Borrowing status
        Public Const StatusActive As String = "Active"
        Public Const StatusReturned As String = "Returned"
        Public Const StatusOverdue As String = "Overdue"
        Public Const StatusLost As String = "Lost"

        ' Reservation status
        Public Const ReservationActive As String = "Active"
        Public Const ReservationFulfilled As String = "Fulfilled"
        Public Const ReservationCancelled As String = "Cancelled"
        Public Const ReservationExpired As String = "Expired"
    End Class
End Namespace
