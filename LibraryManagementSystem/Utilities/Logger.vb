Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Threading

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Simple thread-safe file logger with daily roll-over.
    ''' </summary>
    Public NotInheritable Class Logger
        Private Shared ReadOnly logLock As New ReaderWriterLockSlim()

        Public Shared Sub Info(message As String)
            Write("INFO", message, Nothing)
        End Sub

        Public Shared Sub [Error](message As String, ex As Exception)
            Write("ERROR", message, ex)
        End Sub

        Public Shared Sub Warn(message As String)
            Write("WARN", message, Nothing)
        End Sub

        Private Shared Sub Write(level As String, message As String, ex As Exception)
            Dim logDir As String = Path.GetDirectoryName(Config.AppLogPath)
            If Not String.IsNullOrEmpty(logDir) AndAlso Not Directory.Exists(logDir) Then
                Directory.CreateDirectory(logDir)
            End If

            Dim basePath As String = Config.AppLogPath
            Dim datedPath As String = Path.Combine(Path.GetDirectoryName(basePath), $"{Path.GetFileNameWithoutExtension(basePath)}_{Date.Now:yyyyMMdd}.log")

            Dim sb As New StringBuilder()
            sb.Append(Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")).Append(" [").Append(level).Append("] ")
            sb.Append(message)
            If ex IsNot Nothing Then
                sb.AppendLine().Append(ex.ToString())
            End If

            logLock.EnterWriteLock()
            Try
                File.AppendAllText(datedPath, sb.ToString() & Environment.NewLine)
            Finally
                logLock.ExitWriteLock()
            End Try
        End Sub
    End Class
End Namespace
