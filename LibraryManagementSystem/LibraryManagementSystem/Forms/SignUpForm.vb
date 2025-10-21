Imports System.IO
Imports MySql.Data.MySqlClient

Namespace LibraryManagementSystem
    Public Class SignUpForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UiStyles.StyleHeaderLabel(lblHeader)
            UiStyles.StylePrimaryButton(btnCreate)
            btnCreate.Enabled = False
        End Sub

        Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog(Me) = DialogResult.OK Then
                Try
                    picPhoto.Image = Image.FromFile(ofd.FileName)
                Catch
                    MessageBox.Show("Unable to load image.")
                End Try
            End If
        End Sub

        Private Sub ValidateFormChanged(sender As Object, e As EventArgs) _
            Handles txtFirstName.TextChanged, txtLastName.TextChanged, txtReg.TextChanged, txtEmail.TextChanged, txtPassword.TextChanged, txtConfirm.TextChanged, chkTerms.CheckedChanged, cboDepartment.SelectedIndexChanged, cboYear.SelectedIndexChanged
            btnCreate.Enabled = IsFormValid()
        End Sub

        Private Function IsFormValid() As Boolean
            If String.IsNullOrWhiteSpace(txtFirstName.Text) Then Return False
            If String.IsNullOrWhiteSpace(txtLastName.Text) Then Return False
            If Not ValidationHelper.IsRegistrationNumberValid(txtReg.Text.Trim()) Then Return False
            If Not ValidationHelper.IsEmailValid(txtEmail.Text.Trim()) Then Return False
            If txtPassword.Text.Length < 8 Then Return False
            If ValidationHelper.EvaluatePasswordStrength(txtPassword.Text) < 2 Then Return False
            If Not String.Equals(txtPassword.Text, txtConfirm.Text) Then Return False
            If cboDepartment.SelectedIndex < 0 OrElse cboYear.SelectedIndex < 0 Then Return False
            If Not chkTerms.Checked Then Return False
            Return True
        End Function

        Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
            progress.Visible = True
            btnCreate.Enabled = False

            Try
                Dim sql As String = "INSERT INTO Students (RegistrationNumber, FirstName, LastName, Email, Phone, Department, YearOfStudy, PasswordHash, ProfilePicture) VALUES (@Reg, @FN, @LN, @Email, @Phone, @Dept, @Year, @Hash, @Pic)"
                Dim picBytes As Byte() = Nothing
                If picPhoto.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        picPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        picBytes = ms.ToArray()
                    End Using
                End If

                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@Reg", txtReg.Text.Trim()},
                    {"@FN", txtFirstName.Text.Trim()},
                    {"@LN", txtLastName.Text.Trim()},
                    {"@Email", txtEmail.Text.Trim()},
                    {"@Phone", txtPhone.Text.Trim()},
                    {"@Dept", cboDepartment.SelectedItem?.ToString()},
                    {"@Year", cboYear.SelectedItem?.ToString()},
                    {"@Hash", PasswordHasher.HashPassword(txtPassword.Text)},
                    {"@Pic", picBytes}
                }

                Dim rows = DatabaseHelper.ExecuteNonQuery(sql, parameters)
                If rows > 0 Then
                    progress.Visible = False
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    Throw New Exception("No rows affected")
                End If
            Catch ex As MySqlException When ex.Number = 1062
                progress.Visible = False
                MessageBox.Show("Registration number or email already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                progress.Visible = False
                MessageBox.Show("Unable to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                btnCreate.Enabled = True
            End Try
        End Sub

        Private Sub lnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBack.LinkClicked
            Me.Close()
        End Sub
    End Class
End Namespace
