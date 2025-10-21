Imports System
Imports System.Windows.Forms

Namespace LibraryManagementSystem
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            ' Ensure database connectivity early
            Try
                DataAccess.DatabaseHelper.Initialize()
            Catch ex As Exception
                Utilities.Logger.LogError("Startup DB init failed", ex)
            End Try
            Application.Run(New Forms.Authentication.LoginForm())
        End Sub
    End Module
End Namespace