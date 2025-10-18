Option Strict On
Option Explicit On

Imports LibraryManagement.Utilities

Namespace LibraryManagement.Models
    ''' <summary>
    ''' Represents a library member.
    ''' </summary>
    Public Class Member
        Inherits NotifyBase

        Private _memberId As Integer
        Private _firstName As String = ""
        Private _lastName As String = ""
        Private _email As String = ""
        Private _phone As String = ""
        Private _joinDate As Date

        Public Property MemberID As Integer
            Get
                Return _memberId
            End Get
            Set(value As Integer)
                SetField(_memberId, value)
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                SetField(_firstName, value)
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                SetField(_lastName, value)
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                SetField(_email, value)
            End Set
        End Property

        Public Property Phone As String
            Get
                Return _phone
            End Get
            Set(value As String)
                SetField(_phone, value)
            End Set
        End Property

        Public Property JoinDate As Date
            Get
                Return _joinDate
            End Get
            Set(value As Date)
                SetField(_joinDate, value)
            End Set
        End Property

        Public Function Validate() As List(Of String)
            Dim errors As New List(Of String)()
            If ValidationHelper.IsNullOrWhiteSpace(FirstName) Then errors.Add("First name is required")
            If ValidationHelper.IsNullOrWhiteSpace(LastName) Then errors.Add("Last name is required")
            If Not ValidationHelper.IsValidEmail(Email) Then errors.Add("Valid email is required")
            Return errors
        End Function
    End Class
End Namespace
