Namespace LibraryManagementSystem
    Public Class BorrowBookForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
    End Class
End Namespace
