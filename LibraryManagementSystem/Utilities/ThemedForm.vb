Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Base form that applies the cream/green theme and rounded corners.
    ''' </summary>
    Public Class ThemedForm
        Inherits Form

        Public Sub New()
            Me.Font = Constants.BodyFont
            Me.BackColor = Constants.CreamBackground
            Me.ForeColor = Constants.TextDark
            Me.Padding = New Padding(16)
            Me.DoubleBuffered = True
            Me.StartPosition = FormStartPosition.CenterScreen
            ApplyRoundedCorners(Me, 12)
        End Sub

        Protected Sub StyleHeaderLabel(lbl As Label)
            lbl.Font = Constants.HeaderFont
            lbl.ForeColor = Constants.ForestGreenAlt
        End Sub

        Protected Sub StyleSubHeaderLabel(lbl As Label)
            lbl.Font = Constants.SubHeaderFont
            lbl.ForeColor = Constants.ForestGreen
        End Sub

        Protected Sub StyleAccentButton(btn As Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Constants.SageGreen
            btn.ForeColor = Color.White
            btn.Padding = New Padding(8)
            ApplyRoundedCorners(btn, 8)
        End Sub

        Protected Sub StyleSecondaryButton(btn As Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 1
            btn.FlatAppearance.BorderColor = Constants.BorderOlive
            btn.BackColor = Constants.CreamBackgroundAlt
            btn.ForeColor = Constants.ForestGreen
            btn.Padding = New Padding(8)
            ApplyRoundedCorners(btn, 8)
        End Sub

        Protected Sub StylePanel(p As Panel)
            p.BackColor = Constants.CreamBackgroundAlt
            p.Padding = New Padding(12)
            p.BorderStyle = BorderStyle.FixedSingle
        End Sub

        Private Sub ApplyRoundedCorners(control As Control, radius As Integer)
            Try
                Dim path As New Drawing2D.GraphicsPath()
                Dim rect As Rectangle = control.ClientRectangle
                Dim diameter As Integer = radius * 2
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
                path.CloseAllFigures()
                control.Region = New Region(path)
            Catch
            End Try
        End Sub
    End Class
End Namespace