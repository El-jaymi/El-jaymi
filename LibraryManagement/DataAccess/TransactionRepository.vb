Option Strict On
Option Explicit On

Imports System.Data
Imports MySql.Data.MySqlClient
Imports LibraryManagement.Models

Namespace LibraryManagement.DataAccess
    ''' <summary>
    ''' CRUD operations for Transactions table.
    ''' </summary>
    Public Class TransactionRepository
        Public Function GetAll() As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT TransactionID, BookID, MemberID, BorrowDate, ReturnDate, Status FROM Transactions ORDER BY BorrowDate DESC"
                Using cmd = DbConnectionManager.CreateCommand(conn, sql)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Transactions")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Search(keyword As String) As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT t.TransactionID, t.BookID, t.MemberID, t.BorrowDate, t.ReturnDate, t.Status FROM Transactions t WHERE t.Status LIKE @kw ORDER BY t.BorrowDate DESC"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@kw", "%" & keyword & "%")
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Transactions")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Insert(trx As Transaction) As Integer
            Dim errors = trx.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "INSERT INTO Transactions (BookID, MemberID, BorrowDate, ReturnDate, Status) VALUES (@BookID, @MemberID, @BorrowDate, @ReturnDate, @Status); SELECT LAST_INSERT_ID();"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@BookID", trx.BookID),
                    DbConnectionManager.CreateParameter("@MemberID", trx.MemberID),
                    DbConnectionManager.CreateParameter("@BorrowDate", trx.BorrowDate),
                    DbConnectionManager.CreateParameter("@ReturnDate", If(trx.ReturnDate.HasValue, CType(trx.ReturnDate.Value, Object), DBNull.Value)),
                    DbConnectionManager.CreateParameter("@Status", trx.Status)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Dim newId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return newId
                End Using
            End Using
        End Function

        Public Sub Update(trx As Transaction)
            Dim errors = trx.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))
            If trx.TransactionID <= 0 Then Throw New ArgumentException("TransactionID is required for update")

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "UPDATE Transactions SET BookID=@BookID, MemberID=@MemberID, BorrowDate=@BorrowDate, ReturnDate=@ReturnDate, Status=@Status WHERE TransactionID=@TransactionID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@BookID", trx.BookID),
                    DbConnectionManager.CreateParameter("@MemberID", trx.MemberID),
                    DbConnectionManager.CreateParameter("@BorrowDate", trx.BorrowDate),
                    DbConnectionManager.CreateParameter("@ReturnDate", If(trx.ReturnDate.HasValue, CType(trx.ReturnDate.Value, Object), DBNull.Value)),
                    DbConnectionManager.CreateParameter("@Status", trx.Status),
                    DbConnectionManager.CreateParameter("@TransactionID", trx.TransactionID)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(transactionId As Integer)
            If transactionId <= 0 Then Throw New ArgumentException("Invalid TransactionID")
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "DELETE FROM Transactions WHERE TransactionID=@TransactionID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@TransactionID", transactionId)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class
End Namespace
