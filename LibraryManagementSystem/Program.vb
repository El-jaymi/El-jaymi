Option Strict On
Option Explicit On

Imports System
Imports System.Windows.Forms

Namespace LibraryManagementSystem
    Public Module Program
        <STAThread>
        Public Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Forms.Authentication.LoginForm())
        End Sub
    End Module
End Namespace
