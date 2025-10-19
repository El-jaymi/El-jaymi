Option Strict On
Option Explicit On

Imports System.Data
Imports MySql.Data.MySqlClient
Imports LibraryManagement.Models

Namespace LibraryManagement.DataAccess
    ''' <summary>
    ''' CRUD operations for Members table.
    ''' </summary>
    Public Class MemberRepository
        Public Function GetAll() As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT MemberID, FirstName, LastName, Email, Phone, JoinDate FROM Members ORDER BY LastName, FirstName"
                Using cmd = DbConnectionManager.CreateCommand(conn, sql)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Members")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Search(keyword As String) As DataTable
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "SELECT MemberID, FirstName, LastName, Email, Phone, JoinDate FROM Members WHERE FirstName LIKE @kw OR LastName LIKE @kw OR Email LIKE @kw ORDER BY LastName, FirstName"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@kw", "%" & keyword & "%")
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable("Members")
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Function Insert(member As Member) As Integer
            Dim errors = member.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "INSERT INTO Members (FirstName, LastName, Email, Phone, JoinDate) VALUES (@FirstName, @LastName, @Email, @Phone, @JoinDate); SELECT LAST_INSERT_ID();"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@FirstName", member.FirstName),
                    DbConnectionManager.CreateParameter("@LastName", member.LastName),
                    DbConnectionManager.CreateParameter("@Email", member.Email),
                    DbConnectionManager.CreateParameter("@Phone", member.Phone),
                    DbConnectionManager.CreateParameter("@JoinDate", member.JoinDate)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    Dim newId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return newId
                End Using
            End Using
        End Function

        Public Sub Update(member As Member)
            Dim errors = member.Validate()
            If errors.Count > 0 Then Throw New ArgumentException(String.Join("; ", errors))
            If member.MemberID <= 0 Then Throw New ArgumentException("MemberID is required for update")

            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "UPDATE Members SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, JoinDate=@JoinDate WHERE MemberID=@MemberID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@FirstName", member.FirstName),
                    DbConnectionManager.CreateParameter("@LastName", member.LastName),
                    DbConnectionManager.CreateParameter("@Email", member.Email),
                    DbConnectionManager.CreateParameter("@Phone", member.Phone),
                    DbConnectionManager.CreateParameter("@JoinDate", member.JoinDate),
                    DbConnectionManager.CreateParameter("@MemberID", member.MemberID)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(memberId As Integer)
            If memberId <= 0 Then Throw New ArgumentException("Invalid MemberID")
            Using conn = DbConnectionManager.OpenConnection()
                Dim sql As String = "DELETE FROM Members WHERE MemberID=@MemberID"
                Dim parameters = New List(Of MySqlParameter) From {
                    DbConnectionManager.CreateParameter("@MemberID", memberId)
                }
                Using cmd = DbConnectionManager.CreateCommand(conn, sql, parameters)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class
End Namespace
