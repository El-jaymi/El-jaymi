Option Strict On
Option Explicit On

Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports System.Data

Namespace LibraryManagementSystem.Utilities
    ''' <summary>
    ''' Simple PDF export helper for tabular data.
    ''' </summary>
    Public NotInheritable Class ReportGenerator
        Private Sub New()
        End Sub

        Public Shared Sub ExportDataTableToPdf(table As DataTable, title As String, outputPath As String)
            Dim document As New PdfDocument()
            document.Info.Title = title
            Dim page As PdfPage = document.AddPage()
            page.Size = PdfSharp.PageSize.A4
            Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
            Dim fontTitle As New XFont("Segoe UI", 14, XFontStyle.Bold)
            Dim fontBody As New XFont("Segoe UI", 10, XFontStyle.Regular)

            Dim y As Double = 40
            gfx.DrawString(title, fontTitle, XBrushes.DarkGreen, New XRect(40, y, page.Width - 80, 30), XStringFormats.TopLeft)
            y += 30

            ' Header row
            Dim x As Double = 40
            For Each col As DataColumn In table.Columns
                gfx.DrawString(col.ColumnName, fontBody, XBrushes.Black, New XRect(x, y, 120, 20), XStringFormats.TopLeft)
                x += 120
            Next
            y += 22

            ' Rows
            For Each row As DataRow In table.Rows
                x = 40
                For Each col As DataColumn In table.Columns
                    Dim text As String = If(row(col) IsNot Nothing, row(col).ToString(), String.Empty)
                    gfx.DrawString(text, fontBody, XBrushes.Black, New XRect(x, y, 120, 18), XStringFormats.TopLeft)
                    x += 120
                Next
                y += 20
                If y > page.Height - 40 Then
                    page = document.AddPage()
                    gfx = XGraphics.FromPdfPage(page)
                    y = 40
                End If
            Next

            document.Save(outputPath)
        End Sub
    End Class
End Namespace