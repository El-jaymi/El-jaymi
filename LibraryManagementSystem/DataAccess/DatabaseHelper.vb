Option Strict On
Option Explicit On

Imports System.Data
Imports MySql.Data.MySqlClient
Imports LibraryManagementSystem.Utilities

Namespace LibraryManagementSystem.DataAccess
    ''' <summary>
    ''' MySQL helper for parameterized queries, transactions, and connection pooling.
    ''' </summary>
    Public Class DatabaseHelper
        Implements IDisposable

        Private ReadOnly connection As MySqlConnection
        Private currentTransaction As MySqlTransaction

        Public Sub New()
            connection = New MySqlConnection(Config.ConnectionString)
            connection.Open()
        End Sub

        Public Function CreateCommand(sql As String, Optional commandType As CommandType = CommandType.Text) As MySqlCommand
            Dim cmd As New MySqlCommand(sql, connection)
            cmd.CommandType = commandType
            If currentTransaction IsNot Nothing Then
                cmd.Transaction = currentTransaction
            End If
            Return cmd
        End Function

        Public Sub AddParameter(cmd As MySqlCommand, name As String, value As Object)
            Dim p As MySqlParameter = cmd.Parameters.AddWithValue(name, If(value, DBNull.Value))
            If TypeOf value Is String Then p.DbType = DbType.String
        End Sub

        Public Function ExecuteNonQuery(sql As String, parameters As Dictionary(Of String, Object)) As Integer
            Using cmd As MySqlCommand = CreateCommand(sql)
                For Each kvp In parameters
                    AddParameter(cmd, kvp.Key, kvp.Value)
                Next
                Return cmd.ExecuteNonQuery()
            End Using
        End Function

        Public Function ExecuteScalar(Of T)(sql As String, parameters As Dictionary(Of String, Object)) As T
            Using cmd As MySqlCommand = CreateCommand(sql)
                For Each kvp In parameters
                    AddParameter(cmd, kvp.Key, kvp.Value)
                Next
                Dim result As Object = cmd.ExecuteScalar()
                If result Is Nothing OrElse result Is DBNull.Value Then Return Nothing
                Return CType(result, T)
            End Using
        End Function

        Public Function ExecuteReader(sql As String, parameters As Dictionary(Of String, Object)) As IDataReader
            Dim cmd As MySqlCommand = CreateCommand(sql)
            For Each kvp In parameters
                AddParameter(cmd, kvp.Key, kvp.Value)
            Next
            Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
        End Function

        Public Sub BeginTransaction()
            If currentTransaction Is Nothing Then
                currentTransaction = connection.BeginTransaction()
            End If
        End Sub

        Public Sub Commit()
            If currentTransaction IsNot Nothing Then
                currentTransaction.Commit()
                currentTransaction.Dispose()
                currentTransaction = Nothing
            End If
        End Sub

        Public Sub Rollback()
            If currentTransaction IsNot Nothing Then
                currentTransaction.Rollback()
                currentTransaction.Dispose()
                currentTransaction = Nothing
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Try
                If currentTransaction IsNot Nothing Then
                    currentTransaction.Dispose()
                    currentTransaction = Nothing
                End If
            Catch ex As Exception
                Logger.Error("Error disposing transaction", ex)
            End Try

            Try
                If connection IsNot Nothing Then
                    connection.Dispose()
                End If
            Catch ex As Exception
                Logger.Error("Error disposing connection", ex)
            End Try
        End Sub
    End Class
End Namespace
