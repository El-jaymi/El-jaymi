Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Applies consistent color scheme and rounded styling across forms and controls.
    ''' </summary>
    Public NotInheritable Class Theme
        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Cream As Color
            Get
                Return ColorTranslator.FromHtml("#FFF8E7")
            End Get
        End Property

        Public Shared ReadOnly Property CreamAlt As Color
            Get
                Return ColorTranslator.FromHtml("#FFFEF2")
            End Get
        End Property

        Public Shared ReadOnly Property Sage As Color
            Get
                Return ColorTranslator.FromHtml("#8FBC8F")
            End Get
        End Property

        Public Shared ReadOnly Property SageAlt As Color
            Get
                Return ColorTranslator.FromHtml("#98D8A0")
            End Get
        End Property

        Public Shared ReadOnly Property Forest As Color
            Get
                Return ColorTranslator.FromHtml("#2D5016")
            End Get
        End Property

        Public Shared ReadOnly Property ForestAlt As Color
            Get
                Return ColorTranslator.FromHtml("#4A7C3C")
            End Get
        End Property

        Public Shared ReadOnly Property Charcoal As Color
            Get
                Return ColorTranslator.FromHtml("#2C2C2C")
            End Get
        End Property

        Public Shared ReadOnly Property OliveBorder As Color
            Get
                Return ColorTranslator.FromHtml("#C1D5A4")
            End Get
        End Property

        Public Shared Sub ApplyFormTheme(frm As Form)
            frm.BackColor = Cream
            frm.ForeColor = Charcoal
            frm.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        End Sub

        Public Shared Sub StylePrimaryButton(btn As Button)
            btn.BackColor = Sage
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = OliveBorder
            btn.FlatAppearance.BorderSize = 1
            btn.Padding = New Padding(12)
        End Sub

        Public Shared Sub StyleSecondaryButton(btn As Button)
            btn.BackColor = SageAlt
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = OliveBorder
            btn.FlatAppearance.BorderSize = 1
            btn.Padding = New Padding(10)
        End Sub

        Public Shared Sub StyleHeader(lbl As Label)
            lbl.ForeColor = ForestAlt
            lbl.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        End Sub

        Public Shared Sub StyleCard(panel As Panel)
            panel.BackColor = CreamAlt
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.Padding = New Padding(16)
        End Sub
    End Class
End Namespace
