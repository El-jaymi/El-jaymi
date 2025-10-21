Option Strict On
Option Explicit On

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Helpers for user preferences storage.
    ''' </summary>
    Public NotInheritable Class PreferencesHelper
        Private Sub New()
        End Sub

        Public Shared Sub RememberUsername(username As String)
            Try
                My.Settings.RememberedUsername = username
                My.Settings.Save()
            Catch
            End Try
        End Sub

        Public Shared Function GetRememberedUsername() As String
            Try
                Return My.Settings.RememberedUsername
            Catch
                Return String.Empty
            End Try
        End Function
    End Class
End Namespace