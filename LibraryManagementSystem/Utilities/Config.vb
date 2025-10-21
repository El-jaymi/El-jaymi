Option Strict On
Option Explicit On

Imports System.Configuration

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Helper to read strongly-typed values from App.config.
    ''' </summary>
    Public NotInheritable Class Config
        Private Sub New()
        End Sub

        Public Shared ReadOnly Property ConnectionString As String
            Get
                Return ConfigurationManager.ConnectionStrings("LibraryDB").ConnectionString
            End Get
        End Property

        Public Shared ReadOnly Property DefaultBorrowingDays As Integer
            Get
                Return ReadInt("DefaultBorrowingDays", Constants.DefaultBorrowDays)
            End Get
        End Property

        Public Shared ReadOnly Property MaxRenewals As Integer
            Get
                Return ReadInt("MaxRenewals", Constants.DefaultMaxRenewals)
            End Get
        End Property

        Public Shared ReadOnly Property FinePerDay As Decimal
            Get
                Return ReadDecimal("FinePerDay", Constants.DefaultFinePerDay)
            End Get
        End Property

        Public Shared ReadOnly Property MaxBorrowingLimit As Integer
            Get
                Return ReadInt("MaxBorrowingLimit", Constants.DefaultMaxBorrowingLimit)
            End Get
        End Property

        Public Shared ReadOnly Property ReservationHoldHours As Integer
            Get
                Return ReadInt("ReservationHoldHours", Constants.DefaultReservationHoldHours)
            End Get
        End Property

        Public Shared ReadOnly Property SmtpServer As String
            Get
                Return ReadString("SMTPServer", "")
            End Get
        End Property

        Public Shared ReadOnly Property SmtpPort As Integer
            Get
                Return ReadInt("SMTPPort", 587)
            End Get
        End Property

        Public Shared ReadOnly Property SmtpUsername As String
            Get
                Return ReadString("SMTPUsername", "")
            End Get
        End Property

        Public Shared ReadOnly Property SmtpPassword As String
            Get
                Return ReadString("SMTPPassword", "")
            End Get
        End Property

        Public Shared ReadOnly Property AppLogPath As String
            Get
                Return ReadString("AppLogPath", Constants.DefaultLogPath)
            End Get
        End Property

        Private Shared Function ReadString(key As String, defaultValue As String) As String
            Dim value As String = ConfigurationManager.AppSettings(key)
            If String.IsNullOrWhiteSpace(value) Then Return defaultValue
            Return value
        End Function

        Private Shared Function ReadInt(key As String, defaultValue As Integer) As Integer
            Dim value As String = ConfigurationManager.AppSettings(key)
            Dim result As Integer
            If Not Integer.TryParse(value, result) Then Return defaultValue
            Return result
        End Function

        Private Shared Function ReadDecimal(key As String, defaultValue As Decimal) As Decimal
            Dim value As String = ConfigurationManager.AppSettings(key)
            Dim result As Decimal
            If Not Decimal.TryParse(value, result) Then Return defaultValue
            Return result
        End Function
    End Class
End Namespace
