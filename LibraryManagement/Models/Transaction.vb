Option Strict On
Option Explicit On

Namespace LibraryManagement.Models
    ''' <summary>
    ''' Represents a borrowing transaction.
    ''' </summary>
    Public Class Transaction
        Inherits NotifyBase

        Private _transactionId As Integer
        Private _bookId As Integer
        Private _memberId As Integer
        Private _borrowDate As Date
        Private _returnDate As Date?
        Private _status As String = "Borrowed"

        Public Property TransactionID As Integer
            Get
                Return _transactionId
            End Get
            Set(value As Integer)
                SetField(_transactionId, value)
            End Set
        End Property

        Public Property BookID As Integer
            Get
                Return _bookId
            End Get
            Set(value As Integer)
                SetField(_bookId, value)
            End Set
        End Property

        Public Property MemberID As Integer
            Get
                Return _memberId
            End Get
            Set(value As Integer)
                SetField(_memberId, value)
            End Set
        End Property

        Public Property BorrowDate As Date
            Get
                Return _borrowDate
            End Get
            Set(value As Date)
                SetField(_borrowDate, value)
            End Set
        End Property

        Public Property ReturnDate As Date?
            Get
                Return _returnDate
            End Get
            Set(value As Date?)
                SetField(_returnDate, value)
            End Set
        End Property

        Public Property Status As String
            Get
                Return _status
            End Get
            Set(value As String)
                SetField(_status, value)
            End Set
        End Property

        Public Function Validate() As List(Of String)
            Dim errors As New List(Of String)()
            If BookID <= 0 Then errors.Add("BookID is required")
            If MemberID <= 0 Then errors.Add("MemberID is required")
            If String.IsNullOrWhiteSpace(Status) Then errors.Add("Status is required")
            If ReturnDate.HasValue AndAlso ReturnDate.Value < BorrowDate Then errors.Add("ReturnDate cannot be before BorrowDate")
            Return errors
        End Function
    End Class
End Namespace
