Option Strict On
Option Explicit On

Imports MySql.Data.MySqlClient
Imports LibraryManagement.Utilities

Namespace LibraryManagement.DataAccess
    ''' <summary>
    ''' Provides MySQL/MariaDB connection creation and management.
    ''' </summary>
    Public NotInheritable Class DbConnectionManager
        Private Sub New()
        End Sub

        ''' <summary>
        ''' Create and open a new MySqlConnection using configured connection string.
        ''' </summary>
        Public Shared Function OpenConnection() As MySqlConnection
            Dim conn As New MySqlConnection(ConfigManager.GetConnectionString())
            conn.Open()
            Return conn
        End Function

        ''' <summary>
        ''' Creates a MySqlCommand with parameters.
        ''' </summary>
        Public Shared Function CreateCommand(connection As MySqlConnection, sql As String, Optional parameters As IEnumerable(Of MySqlParameter) = Nothing) As MySqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim cmd As New MySqlCommand(sql, connection)
            If parameters IsNot Nothing Then
                For Each p In parameters
                    cmd.Parameters.Add(p)
                Next
            End If
            Return cmd
        End Function

        Public Shared Function CreateParameter(name As String, value As Object) As MySqlParameter
            Return New MySqlParameter(name, If(value, DBNull.Value))
        End Function
    End Class
End Namespace
