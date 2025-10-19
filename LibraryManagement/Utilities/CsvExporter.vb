Option Strict On
Option Explicit On

Imports System.Data
Imports System.IO
Imports System.Text

Namespace LibraryManagement.Utilities
    ''' <summary>
    ''' Exports DataTable or list-like data to a CSV file.
    ''' </summary>
    Public NotInheritable Class CsvExporter
        Private Sub New()
        End Sub

        ''' <summary>
        ''' Export a DataTable to CSV.
        ''' </summary>
        ''' <param name="dataTable">The DataTable to export.</param>
        ''' <param name="filePath">The destination CSV file path.</param>
        ''' <param name="includeHeaders">Whether to include a header row.</param>
        Public Shared Sub ExportDataTable(dataTable As DataTable, filePath As String, Optional includeHeaders As Boolean = True)
            If dataTable Is Nothing Then Throw New ArgumentNullException(NameOf(dataTable))
            If String.IsNullOrWhiteSpace(filePath) Then Throw New ArgumentException("filePath is required", NameOf(filePath))

            Dim directory As String = Path.GetDirectoryName(filePath)
            If Not String.IsNullOrEmpty(directory) AndAlso Not Directory.Exists(directory) Then
                Directory.CreateDirectory(directory)
            End If

            Dim utf8WithBom As New UTF8Encoding(encoderShouldEmitUTF8Identifier:=True)
            Using writer As New StreamWriter(filePath, append:=False, encoding:=utf8WithBom)
                If includeHeaders Then
                    Dim headers As New List(Of String)()
                    For Each column As DataColumn In dataTable.Columns
                        headers.Add(Escape(column.ColumnName))
                    Next
                    writer.WriteLine(String.Join(",", headers))
                End If

                For Each row As DataRow In dataTable.Rows
                    Dim fields As New List(Of String)()
                    For Each column As DataColumn In dataTable.Columns
                        Dim value As Object = row(column)
                        fields.Add(Escape(If(value Is Nothing, String.Empty, Convert.ToString(value))))
                    Next
                    writer.WriteLine(String.Join(",", fields))
                Next
            End Using
        End Sub

        Private Shared Function Escape(input As String) As String
            If input Is Nothing Then Return ""
            Dim mustQuote As Boolean = input.Contains("\"") OrElse input.Contains(",") OrElse input.Contains("\n") OrElse input.Contains("\r")
            Dim escaped As String = input.Replace("\"", "\"\"")
            If mustQuote Then
                Return "\"" & escaped & "\""
            End If
            Return escaped
        End Function
    End Class
End Namespace
