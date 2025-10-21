Imports System.Drawing
Imports System.Windows.Forms

Namespace LibraryManagementSystem
    Public NotInheritable Class UiStyles
        Private Sub New()
        End Sub

        Public Shared ReadOnly CreamBackground As Color = ColorTranslator.FromHtml("#FFF8E7")
        Public Shared ReadOnly CreamBackgroundAlt As Color = ColorTranslator.FromHtml("#FFFEF2")
        Public Shared ReadOnly Sage As Color = ColorTranslator.FromHtml("#98D8A0")
        Public Shared ReadOnly SageAlt As Color = ColorTranslator.FromHtml("#8FBC8F")
        Public Shared ReadOnly Forest As Color = ColorTranslator.FromHtml("#4A7C3C")
        Public Shared ReadOnly ForestAlt As Color = ColorTranslator.FromHtml("#2D5016")
        Public Shared ReadOnly Charcoal As Color = ColorTranslator.FromHtml("#2C2C2C")
        Public Shared ReadOnly OliveBorder As Color = ColorTranslator.FromHtml("#C1D5A4")
        Public Shared ReadOnly ErrorRed As Color = ColorTranslator.FromHtml("#D9534F")
        Public Shared ReadOnly SuccessGreen As Color = ColorTranslator.FromHtml("#5CB85C")

        Public Shared Sub StylePrimaryButton(button As Button)
            button.BackColor = Sage
            button.ForeColor = Color.White
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderColor = OliveBorder
            button.FlatAppearance.BorderSize = 1
        End Sub

        Public Shared Sub StyleSecondaryButton(button As Button)
            button.BackColor = Forest
            button.ForeColor = Color.White
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderColor = OliveBorder
            button.FlatAppearance.BorderSize = 1
        End Sub

        Public Shared Sub StylePanel(panel As Panel)
            panel.BackColor = CreamBackground
            panel.Padding = New Padding(16)
        End Sub

        Public Shared Sub StyleHeaderLabel(label As Label)
            label.Font = New Font("Segoe UI", 16, FontStyle.Bold)
            label.ForeColor = Forest
        End Sub

        Public Shared Sub StyleBodyLabel(label As Label)
            label.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            label.ForeColor = Charcoal
        End Sub
    End Class
End Namespace
