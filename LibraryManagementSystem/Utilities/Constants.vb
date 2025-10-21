Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Configuration

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Centralized constants, theme colors, fonts, and configuration accessors.
    ''' </summary>
    Public NotInheritable Class Constants
        Private Sub New()
        End Sub

        ' Theme colors
        Public Shared ReadOnly Property CreamBackground As Color
            Get
                Return ColorTranslator.FromHtml("#FFF8E7")
            End Get
        End Property

        Public Shared ReadOnly Property CreamBackgroundAlt As Color
            Get
                Return ColorTranslator.FromHtml("#FFFEF2")
            End Get
        End Property

        Public Shared ReadOnly Property SageGreen As Color
            Get
                Return ColorTranslator.FromHtml("#8FBC8F")
            End Get
        End Property

        Public Shared ReadOnly Property SageGreenAlt As Color
            Get
                Return ColorTranslator.FromHtml("#98D8A0")
            End Get
        End Property

        Public Shared ReadOnly Property ForestGreen As Color
            Get
                Return ColorTranslator.FromHtml("#2D5016")
            End Get
        End Property

        Public Shared ReadOnly Property ForestGreenAlt As Color
            Get
                Return ColorTranslator.FromHtml("#4A7C3C")
            End Get
        End Property

        Public Shared ReadOnly Property TextDark As Color
            Get
                Return ColorTranslator.FromHtml("#2C2C2C")
            End Get
        End Property

        Public Shared ReadOnly Property BorderOlive As Color
            Get
                Return ColorTranslator.FromHtml("#C1D5A4")
            End Get
        End Property

        ' Fonts
        Public Shared ReadOnly Property BodyFont As Font
            Get
                Return New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
            End Get
        End Property

        Public Shared ReadOnly Property HeaderFont As Font
            Get
                Return New Font("Segoe UI Semibold", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
            End Get
        End Property

        Public Shared ReadOnly Property SubHeaderFont As Font
            Get
                Return New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            End Get
        End Property

        ' Configuration keys
        Public Const AppSettingDefaultBorrowingDays As String = "DefaultBorrowingDays"
        Public Const AppSettingMaxRenewals As String = "MaxRenewals"
        Public Const AppSettingFinePerDay As String = "FinePerDay"
        Public Const AppSettingMaxBorrowingLimit As String = "MaxBorrowingLimit"
        Public Const AppSettingReservationHoldHours As String = "ReservationHoldHours"

        Public Shared Function GetIntSetting(key As String, defaultValue As Integer) As Integer
            Dim raw As String = ConfigurationManager.AppSettings(key)
            Dim parsed As Integer
            If Integer.TryParse(raw, parsed) Then
                Return parsed
            End If
            Return defaultValue
        End Function

        Public Shared Function GetDecimalSetting(key As String, defaultValue As Decimal) As Decimal
            Dim raw As String = ConfigurationManager.AppSettings(key)
            Dim parsed As Decimal
            If Decimal.TryParse(raw, parsed) Then
                Return parsed
            End If
            Return defaultValue
        End Function

        Public Shared Function GetStringSetting(key As String, defaultValue As String) As String
            Dim raw As String = ConfigurationManager.AppSettings(key)
            If String.IsNullOrWhiteSpace(raw) Then
                Return defaultValue
            End If
            Return raw
        End Function

        ' Business constants
        Public Shared ReadOnly Property DefaultBorrowDays As Integer
            Get
                Return GetIntSetting(AppSettingDefaultBorrowingDays, 14)
            End Get
        End Property

        Public Shared ReadOnly Property MaxRenewals As Integer
            Get
                Return GetIntSetting(AppSettingMaxRenewals, 2)
            End Get
        End Property

        Public Shared ReadOnly Property FinePerDay As Decimal
            Get
                Return GetDecimalSetting(AppSettingFinePerDay, 0.5D)
            End Get
        End Property

        Public Shared ReadOnly Property MaxBorrowLimit As Integer
            Get
                Return GetIntSetting(AppSettingMaxBorrowingLimit, 5)
            End Get
        End Property

        Public Shared ReadOnly Property ReservationHoldHours As Integer
            Get
                Return GetIntSetting(AppSettingReservationHoldHours, 48)
            End Get
        End Property

        Public Const DateFormat As String = "yyyy-MM-dd"
        Public Const TimestampFormat As String = "yyyy-MM-dd HH:mm:ss"
    End Class
End Namespace