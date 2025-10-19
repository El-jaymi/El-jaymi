Option Strict On
Option Explicit On

Imports System.Configuration
Imports System.Text

Namespace LibraryManagement.Utilities
    ''' <summary>
    ''' Reads DB settings and constructs a MariaDB connection string.
    ''' </summary>
    Public NotInheritable Class ConfigManager
        Private Sub New()
        End Sub

        ''' <summary>
        ''' Get connection string either directly from connectionStrings or built from appSettings.
        ''' </summary>
        Public Shared Function GetConnectionString() As String
            Dim cs As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MariaDbConnection")
            Dim raw As String = If(cs IsNot Nothing, cs.ConnectionString, Nothing)
            If Not String.IsNullOrWhiteSpace(raw) AndAlso Not raw.Contains("${") Then
                Return raw
            End If

            Dim host As String = GetAppSetting("DbHost", "localhost")
            Dim port As String = GetAppSetting("DbPort", "3306")
            Dim user As String = GetAppSetting("DbUser", "root")
            Dim password As String = GetAppSetting("DbPassword", "password")
            Dim dbName As String = GetAppSetting("DbName", "library_db")

            Dim builder As New StringBuilder()
            builder.Append("server=").Append(host).Append(";")
            builder.Append("port=").Append(port).Append(";")
            builder.Append("user id=").Append(user).Append(";")
            builder.Append("password=").Append(password).Append(";")
            builder.Append("database=").Append(dbName).Append(";")
            builder.Append("SslMode=Preferred;Allow User Variables=True;")

            Return builder.ToString()
        End Function

        ''' <summary>
        ''' Update app settings at runtime; may require admin rights depending on host application.
        ''' </summary>
        Public Shared Sub UpdateAppSetting(key As String, value As String)
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If config.AppSettings.Settings(key) Is Nothing Then
                config.AppSettings.Settings.Add(key, value)
            Else
                config.AppSettings.Settings(key).Value = value
            End If
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
        End Sub

        Private Shared Function GetAppSetting(key As String, defaultValue As String) As String
            Dim v As String = ConfigurationManager.AppSettings(key)
            If String.IsNullOrWhiteSpace(v) Then Return defaultValue
            Return v
        End Function
    End Class
End Namespace
