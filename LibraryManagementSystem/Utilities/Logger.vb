Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Diagnostics

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Simple thread-safe file logger with rolling by size.
    ''' </summary>
    Public NotInheritable Class Logger
        Private Shared ReadOnly LogDirectory As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs")
        Private Shared ReadOnly LogFilePath As String = Path.Combine(LogDirectory, "application.log")
        Private Shared ReadOnly Sync As New Object()
        Private Const MaxBytesBeforeRoll As Long = 5L * 1024L * 1024L ' 5 MB

        Private Sub New()
        End Sub

        Public Shared Sub LogInfo(message As String)
            WriteEntry("INFO", message, Nothing)
        End Sub

        Public Shared Sub LogWarn(message As String)
            WriteEntry("WARN", message, Nothing)
        End Sub

        Public Shared Sub LogError(message As String, ex As Exception)
            WriteEntry("ERROR", message, ex)
        End Sub

        Private Shared Sub WriteEntry(level As String, message As String, ex As Exception)
            Try
                SyncLock Sync
                    If Not Directory.Exists(LogDirectory) Then
                        Directory.CreateDirectory(LogDirectory)
                    End If

                    If File.Exists(LogFilePath) Then
                        Dim length As Long = New FileInfo(LogFilePath).Length
                        If length > MaxBytesBeforeRoll Then
                            Dim rolled As String = Path.Combine(LogDirectory, $"application_{DateTime.Now:yyyyMMdd_HHmmss}.log")
                            File.Move(LogFilePath, rolled)
                        End If
                    End If

                    Dim sb As New StringBuilder()
                    sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")).Append(" ")
                    sb.Append("[").Append(level).Append("] ")
                    sb.AppendLine(message)
                    If ex IsNot Nothing Then
                        sb.AppendLine(ex.ToString())
                    End If
                    File.AppendAllText(LogFilePath, sb.ToString())
                End SyncLock
            Catch
                ' No-op: avoid throwing from logger
            End Try
        End Sub
    End Class
End Namespace