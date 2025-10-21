Option Strict On
Option Explicit On

Namespace My

    'NOTE: This file is auto-generated; do not modify directly.
    <Global.Microsoft.VisualBasic.HideModuleName()> _
    Module MyApplication

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Friend Class MyApplication
            Inherits Global.Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase

            Public Sub New()
                MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
                Me.IsSingleInstance = False
                Me.EnableVisualStyles = True
                Me.SaveMySettingsOnExit = True
                Me.ShutdownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
            End Sub

            <Global.System.Diagnostics.DebuggerStepThrough()> _
            Protected Overrides Sub OnCreateMainForm()
                Me.MainForm = LibraryManagementSystem.LoginForm
            End Sub
        End Class

        Private applicationObject As MyApplication

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.Microsoft.VisualBasic.CompilerServices.Singleton()> _
        Public ReadOnly Property Application() As MyApplication
            Get
                If applicationObject Is Nothing Then
                    applicationObject = New MyApplication()
                End If
                Return applicationObject
            End Get
        End Property

    End Module
End Namespace
