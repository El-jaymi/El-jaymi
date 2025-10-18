Option Strict On
Option Explicit On

Imports System.Data
Imports MySql.Data.MySqlClient
Imports LibraryManagement.Utilities
Imports LibraryManagement.Models

Namespace LibraryManagement.DataAccess
    ''' <summary>
    ''' CRUD operations for Books table.
    ''' </summary>
    Public Class BookRepository
        Public Function GetAll() As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT BookID, Title, Author, ISBN, PublishYear, Genre, Available FROM Books ORDER BY Title"
                Using cmd = DbConnectionManager.CreateCommand(conn, sql)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Books")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Search(keyword As String) As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT BookID, Title, Author, ISBN, PublishYear, Genre, Available FROM Books WHERE Title LIKE @kw OR Author LIKE @kw OR ISBN LIKE @kw ORDER BY Title"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@kw", "%" & keyword & "%")
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Books")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Insert(book As Book) As Integer
            Dim errors = book.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "INSERT INTO Books (Title, Author, ISBN, PublishYear, Genre, Available) VALUES (@Title, @Author, @ISBN, @PublishYear, @Genre, @Available); SELECT LAST_INSERT_ID();"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@Title", book.Title),
                    DbConnectionManager.CreateParameter("@Author", book.Author),
                    DbConnectionManager.CreateParameter("@ISBN", book.ISBN),
                    DbConnectionManager.CreateParameter("@PublishYear", If(book.PublishYear.HasValue, CType(book.PublishYear.Value, Object), DBNull.Value)),
                    DbConnectionManager.CreateParameter("@Genre", book.Genre),
                    DbConnectionManager.CreateParameter("@Available", If(book.Available, 1, 0))
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Dim newId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return newId
                End Using
            End Using
        End Function

        Public Sub Update(book As Book)
            Dim errors = book.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))
            If book.BookID <= 0 Then Throw New ArgumentException("BookID is required for update")

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "UPDATE Books SET Title=@Title, Author=@Author, ISBN=@ISBN, PublishYear=@PublishYear, Genre=@Genre, Available=@Available WHERE BookID=@BookID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@Title", book.Title),
                    DbConnectionManager.CreateParameter("@Author", book.Author),
                    DbConnectionManager.CreateParameter("@ISBN", book.ISBN),
                    DbConnectionManager.CreateParameter("@PublishYear", If(book.PublishYear.HasValue, CType(book.PublishYear.Value, Object), DBNull.Value)),
                    DbConnectionManager.CreateParameter("@Genre", book.Genre),
                    DbConnectionManager.CreateParameter("@Available", If(book.Available, 1, 0)),
                    DbConnectionManager.CreateParameter("@BookID", book.BookID)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(bookId As Integer)
            If bookId <= 0 Then Throw New ArgumentException("Invalid BookID")
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "DELETE FROM Books WHERE BookID=@BookID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@BookID", bookId)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class
End Namespace
