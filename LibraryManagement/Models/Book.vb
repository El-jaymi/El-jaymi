Option Strict On
Option Explicit On

Imports System.ComponentModel.DataAnnotations
Imports LibraryManagement.Utilities

Namespace LibraryManagement.Models
    ''' <summary>
    ''' Represents a book in the library.
    ''' </summary>
    Public Class Book
        Inherits NotifyBase

        Private _bookId As Integer
        Private _title As String = ""
        Private _author As String = ""
        Private _isbn As String = ""
        Private _publishYear As Integer?
        Private _genre As String = ""
        Private _available As Boolean = True

        Public Property BookID As Integer
            Get
                Return _bookId
            End Get
            Set(value As Integer)
                SetField(_bookId, value)
            End Set
        End Property

        Public Property Title As String
            Get
                Return _title
            End Get
            Set(value As String)
                SetField(_title, value)
            End Set
        End Property

        Public Property Author As String
            Get
                Return _author
            End Get
            Set(value As String)
                SetField(_author, value)
            End Set
        End Property

        Public Property ISBN As String
            Get
                Return _isbn
            End Get
            Set(value As String)
                SetField(_isbn, value)
            End Set
        End Property

        Public Property PublishYear As Integer?
            Get
                Return _publishYear
            End Get
            Set(value As Integer?)
                SetField(_publishYear, value)
            End Set
        End Property

        Public Property Genre As String
            Get
                Return _genre
            End Get
            Set(value As String)
                SetField(_genre, value)
            End Set
        End Property

        Public Property Available As Boolean
            Get
                Return _available
            End Get
            Set(value As Boolean)
                SetField(_available, value)
            End Set
        End Property

        Public Function Validate() As List(Of String)
            Dim errors As New List(Of String)()
            If ValidationHelper.IsNullOrWhiteSpace(Title) Then errors.Add("Title is required")
            If ValidationHelper.IsNullOrWhiteSpace(Author) Then errors.Add("Author is required")
            If ValidationHelper.IsNullOrWhiteSpace(ISBN) Then errors.Add("ISBN is required")
            If PublishYear.HasValue AndAlso (PublishYear.Value < 0 OrElse PublishYear.Value > DateTime.Now.Year + 1) Then errors.Add("PublishYear is invalid")
            Return errors
        End Function
    End Class
End Namespace
