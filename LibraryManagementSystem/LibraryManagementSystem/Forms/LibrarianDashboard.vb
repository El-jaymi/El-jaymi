Namespace LibraryManagementSystem
    Public Class LibrarianDashboard
        Private Sub LibrarianDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UiStyles.StyleHeaderLabel(lblTitle)
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            Me.Close()
        End Sub
    End Class
End Namespace
