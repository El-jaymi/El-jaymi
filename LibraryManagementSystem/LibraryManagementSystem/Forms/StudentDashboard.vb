Namespace LibraryManagementSystem
    Public Class StudentDashboard
        Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UiStyles.StyleBodyLabel(lblWelcome)
            lblDateTime.Text = DateTime.Now.ToString("f")
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            Me.Close()
        End Sub
    End Class
End Namespace
