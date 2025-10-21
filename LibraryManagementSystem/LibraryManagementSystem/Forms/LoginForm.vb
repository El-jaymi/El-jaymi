Imports System.Data
Imports MySql.Data.MySqlClient

Namespace LibraryManagementSystem
    Public Class LoginForm
        Private failedAttempts As Integer = 0

        Public Sub New()
            InitializeComponent()
            Me.AcceptButton = btnLogin
        End Sub

        Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtUsername.Text = My.MySettings.Default.RememberedUsername
            ApplyUi()
        End Sub

        Private Sub ApplyUi()
            UiStyles.StyleHeaderLabel(lblTitle)
            UiStyles.StylePrimaryButton(btnLogin)
            Me.BackColor = UiStyles.CreamBackground
            pnlHeader.BackColor = Color.White
        End Sub

        Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
            txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            lblStatus.Visible = False
            Dim user As String = txtUsername.Text.Trim()
            Dim pass As String = txtPassword.Text

            If String.IsNullOrWhiteSpace(user) OrElse String.IsNullOrWhiteSpace(pass) Then
                ShowError("Please enter both username/email and password.")
                Return
            End If

            If rbStudent.Checked AndAlso Not ValidationHelper.IsEmailValid(user) Then
                ShowError("Please enter a valid email address.")
                Return
            End If

            Dim hashed As String = PasswordHasher.HashPassword(pass)

            Try
                If rbStudent.Checked Then
                    LoginStudent(user, hashed)
                Else
                    LoginLibrarian(user, hashed)
                End If
            Catch ex As Exception
                ShowError("Unable to login. Check connection settings.")
            End Try
        End Sub

        Private Sub LoginStudent(email As String, passwordHash As String)
            Dim sql As String = "SELECT StudentID, FirstName, AccountStatus, PasswordHash FROM Students WHERE Email = @Email LIMIT 1"
            Dim p = New Dictionary(Of String, Object) From {{"@Email", email}}
            Dim dt As DataTable = DatabaseHelper.ExecuteQuery(sql, p)
            If dt.Rows.Count = 0 Then
                OnFailedLogin()
                Return
            End If

            Dim row = dt.Rows(0)
            Dim status As String = Convert.ToString(row("AccountStatus"))
            If String.Equals(status, "Suspended", StringComparison.OrdinalIgnoreCase) Then
                ShowError("Account is suspended. Contact library.")
                Return
            End If

            Dim stored As String = Convert.ToString(row("PasswordHash"))
            If Not String.Equals(stored, passwordHash, StringComparison.OrdinalIgnoreCase) Then
                OnFailedLogin(email:=email, forStudent:=True)
                Return
            End If

            My.MySettings.Default.RememberedUsername = If(chkRememberMe.Checked, email, String.Empty)
            My.MySettings.Default.Save()

            Dim firstName As String = Convert.ToString(row("FirstName"))
            Dim dashboard As New StudentDashboard()
            dashboard.Text = $"Student Dashboard - Welcome, {firstName}!"
            Me.Hide()
            AddHandler dashboard.FormClosed, Sub() Me.Close()
            dashboard.Show()
        End Sub

        Private Sub LoginLibrarian(username As String, passwordHash As String)
            Dim sql As String = "SELECT LibrarianID, FullName, IsActive, PasswordHash FROM Librarians WHERE Username = @U LIMIT 1"
            Dim p = New Dictionary(Of String, Object) From {{"@U", username}}
            Dim dt As DataTable = DatabaseHelper.ExecuteQuery(sql, p)
            If dt.Rows.Count = 0 Then
                OnFailedLogin()
                Return
            End If

            Dim row = dt.Rows(0)
            Dim isActive As Boolean = If(row("IsActive") Is DBNull.Value, False, Convert.ToBoolean(row("IsActive")))
            If Not isActive Then
                ShowError("Account is inactive. Contact admin.")
                Return
            End If

            Dim stored As String = Convert.ToString(row("PasswordHash"))
            If Not String.Equals(stored, passwordHash, StringComparison.OrdinalIgnoreCase) Then
                OnFailedLogin()
                Return
            End If

            My.MySettings.Default.RememberedUsername = If(chkRememberMe.Checked, username, String.Empty)
            My.MySettings.Default.Save()

            Dim fullName As String = Convert.ToString(row("FullName"))
            Dim dashboard As New LibrarianDashboard()
            dashboard.Text = $"Librarian Portal - {fullName}"
            Me.Hide()
            AddHandler dashboard.FormClosed, Sub() Me.Close()
            dashboard.Show()
        End Sub

        Private Sub OnFailedLogin(Optional email As String = Nothing, Optional forStudent As Boolean = False)
            failedAttempts += 1
            If failedAttempts >= 3 Then
                If forStudent AndAlso Not String.IsNullOrEmpty(email) Then
                    Try
                        DatabaseHelper.ExecuteNonQuery("UPDATE Students SET AccountStatus = 'Suspended' WHERE Email = @Email", New Dictionary(Of String, Object) From {{"@Email", email}})
                    Catch
                    End Try
                End If
                btnLogin.Enabled = False
                ShowError("Too many failed attempts. Account locked or try later.")
            Else
                ShowError($"Invalid credentials. Attempt {failedAttempts}/3.")
            End If
        End Sub

        Private Sub ShowError(message As String)
            lblStatus.Text = message
            lblStatus.Visible = True
        End Sub

        Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
            Dim frm As New SignUpForm()
            frm.ShowDialog(Me)
        End Sub

        Private Sub lnkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked
            MessageBox.Show("Please contact the librarian to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class
End Namespace
