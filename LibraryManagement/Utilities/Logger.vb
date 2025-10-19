Option Strict On
Option Explicit On

Imports System.Diagnostics
Imports System.IO

Namespace LibraryManagement.Utilities
    ''' <summary>
    ''' Simple file and debug logger with timestamped entries.
    ''' </summary>
    Public NotInheritable Class Logger
        Private Sub New()
        End Sub

        Private Shared ReadOnly LogDirectory As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs")
        Private Shared ReadOnly LogFilePath As String = Path.Combine(LogDirectory, "app.log")
        Private Shared ReadOnly SyncRoot As New Object()

        Private Shared Sub EnsureLogDirectory()
            If Not Directory.Exists(LogDirectory) Then
                Directory.CreateDirectory(LogDirectory)
            End If
        End Sub

        Private Shared Sub Write(level As String, message As String, Optional ex As Exception = Nothing)
            Try
                EnsureLogDirectory()
                Dim line As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{level}] {message}"
                If ex IsNot Nothing Then
                    line &= Environment.NewLine & ex.ToString()
                End If
                SyncLock SyncRoot
                    File.AppendAllText(LogFilePath, line & Environment.NewLine)
                End SyncLock
                Debug.WriteLine(line)
            Catch
                ' Swallow logging errors to avoid secondary failures
            End Try
        End Sub

        ''' <summary>
        ''' Log informational message.
        ''' </summary>
        Public Shared Sub Info(message As String)
            Write("INFO", message)
        End Sub

        ''' <summary>
        ''' Log warning message.
        ''' </summary>
        Public Shared Sub Warn(message As String)
            Write("WARN", message)
        End Sub

        ''' <summary>
        ''' Log error message, optionally with exception.
        ''' </summary>
        Public Shared Sub [Error](message As String, Optional ex As Exception = Nothing)
            Write("ERROR", message, ex)
        End Sub

        ''' <summary>
        ''' Log exception with message.
        ''' </summary>
        Public Shared Sub Exception(ex As Exception, Optional message As String = "")
            Write("EXCEPTION", message, ex)
        End Sub
    End Class
End Namespace
