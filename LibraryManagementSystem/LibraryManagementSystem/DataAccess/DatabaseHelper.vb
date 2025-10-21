Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Data

Namespace LibraryManagementSystem
    Public NotInheritable Class DatabaseHelper
        Private Sub New()
        End Sub

        Private Shared ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("LibraryDb").ConnectionString

        Public Shared Function GetConnection() As MySqlConnection
            Dim conn As New MySqlConnection(connectionString)
            Return conn
        End Function

        Public Shared Function ExecuteQuery(sql As String, parameters As Dictionary(Of String, Object)) As DataTable
            Dim table As New DataTable()
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    AddParameters(cmd, parameters)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
            Return table
        End Function

        Public Shared Function ExecuteNonQuery(sql As String, parameters As Dictionary(Of String, Object)) As Integer
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    AddParameters(cmd, parameters)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        End Function

        Public Shared Function ExecuteScalar(Of T)(sql As String, parameters As Dictionary(Of String, Object)) As T
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    AddParameters(cmd, parameters)
                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing OrElse result Is DBNull.Value Then
                        Return Nothing
                    End If
                    Return CType(result, T)
                End Using
            End Using
        End Function

        Public Shared Sub ExecuteInTransaction(action As Action(Of MySqlTransaction))
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using tx As MySqlTransaction = conn.BeginTransaction()
                    Try
                        action(tx)
                        tx.Commit()
                    Catch
                        Try
                            tx.Rollback()
                        Catch
                        End Try
                        Throw
                    End Try
                End Using
            End Using
        End Sub

        Public Shared Sub AddParameters(cmd As MySqlCommand, parameters As Dictionary(Of String, Object))
            If parameters Is Nothing Then Return
            For Each kvp In parameters
                cmd.Parameters.AddWithValue(kvp.Key, If(kvp.Value, DBNull.Value))
            Next
        End Sub
    End Class
End Namespace
