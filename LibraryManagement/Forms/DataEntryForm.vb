Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.DataAccess
Imports LibraryManagement.Models
Imports LibraryManagement.Utilities

Namespace LibraryManagement.Forms
    Public Class DataEntryForm
        Inherits Form

        Public Enum EntryType
            Book
            Member
            Transaction
        End Enum

        Private ReadOnly entry As EntryType

        ' Common controls
        Private ReadOnly panel As New TableLayoutPanel()
        Private ReadOnly btnSave As New Button()
        Private ReadOnly btnCancel As New Button()
        Private ReadOnly errorProvider As New ErrorProvider()

        ' Book controls
        Private txtTitle As TextBox
        Private txtAuthor As TextBox
        Private txtISBN As TextBox
        Private txtYear As TextBox
        Private txtGenre As TextBox
        Private chkAvailable As CheckBox

        ' Member controls
        Private txtFirstName As TextBox
        Private txtLastName As TextBox
        Private txtEmail As TextBox
        Private txtPhone As TextBox
        Private dtJoinDate As DateTimePicker

        ' Transaction controls
        Private txtBookId As TextBox
        Private txtMemberId As TextBox
        Private dtBorrow As DateTimePicker
        Private dtReturn As DateTimePicker
        Private txtStatus As TextBox

        Public Sub New(t As EntryType)
            entry = t
            Me.Text = "Add " & t.ToString()
            Me.StartPosition = FormStartPosition.CenterParent
            Me.MinimumSize = New Size(600, 400)
            Me.BackColor = ColorTranslator.FromHtml("#F5F5F5")
            Me.Font = New Font("Segoe UI", 9.0F)

            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            panel.ColumnCount = 2
            panel.RowCount = 1
            panel.Dock = DockStyle.Fill
            panel.Padding = New Padding(16)
            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70))
            Controls.Add(panel)

            btnSave.Text = "Save"
            btnSave.BackColor = ColorTranslator.FromHtml("#0078D4")
            btnSave.ForeColor = Color.White
            btnSave.FlatStyle = FlatStyle.Flat
            btnSave.Width = 100
            btnSave.TabIndex = 1000
            AddHandler btnSave.Click, AddressOf OnSave

            btnCancel.Text = "Cancel"
            btnCancel.BackColor = Color.White
            btnCancel.ForeColor = ColorTranslator.FromHtml("#333333")
            btnCancel.FlatStyle = FlatStyle.Flat
            btnCancel.Width = 100
            btnCancel.TabIndex = 1001
            AddHandler btnCancel.Click, Sub(s, e) DialogResult = DialogResult.Cancel

            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink

            Select Case entry
                Case EntryType.Book
                    BuildBookLayout()
                Case EntryType.Member
                    BuildMemberLayout()
                Case EntryType.Transaction
                    BuildTransactionLayout()
            End Select

            Dim buttonPanel As New FlowLayoutPanel() With {
                .Dock = DockStyle.Bottom,
                .FlowDirection = FlowDirection.RightToLeft,
                .Padding = New Padding(16),
                .Height = 60
            }
            buttonPanel.Controls.AddRange(New Control() {btnSave, btnCancel})
            Controls.Add(buttonPanel)
        End Sub

        Private Sub BuildBookLayout()
            txtTitle = CreateTextBox(0)
            txtAuthor = CreateTextBox(1)
            txtISBN = CreateTextBox(2)
            txtYear = CreateTextBox(3)
            txtGenre = CreateTextBox(4)
            chkAvailable = New CheckBox() With {.Text = "Available", .Checked = True, .TabIndex = 5}

            AddRow("Title:", txtTitle)
            AddRow("Author:", txtAuthor)
            AddRow("ISBN:", txtISBN)
            AddRow("Publish Year:", txtYear)
            AddRow("Genre:", txtGenre)
            AddRow("", chkAvailable)
        End Sub

        Private Sub BuildMemberLayout()
            txtFirstName = CreateTextBox(0)
            txtLastName = CreateTextBox(1)
            txtEmail = CreateTextBox(2)
            txtPhone = CreateTextBox(3)
            dtJoinDate = New DateTimePicker() With {.Value = DateTime.Now, .Format = DateTimePickerFormat.Short, .TabIndex = 4}

            AddRow("First Name:", txtFirstName)
            AddRow("Last Name:", txtLastName)
            AddRow("Email:", txtEmail)
            AddRow("Phone:", txtPhone)
            AddRow("Join Date:", dtJoinDate)
        End Sub

        Private Sub BuildTransactionLayout()
            txtBookId = CreateTextBox(0)
            txtMemberId = CreateTextBox(1)
            dtBorrow = New DateTimePicker() With {.Value = DateTime.Now, .Format = DateTimePickerFormat.Short, .TabIndex = 2}
            dtReturn = New DateTimePicker() With {.Format = DateTimePickerFormat.Short, .ShowCheckBox = True, .TabIndex = 3}
            txtStatus = CreateTextBox(4)

            AddRow("Book ID:", txtBookId)
            AddRow("Member ID:", txtMemberId)
            AddRow("Borrow Date:", dtBorrow)
            AddRow("Return Date:", dtReturn)
            AddRow("Status:", txtStatus)
        End Sub

        Private Function CreateTextBox(tabIndex As Integer) As TextBox
            Return New TextBox() With {
                .BorderStyle = BorderStyle.FixedSingle,
                .BackColor = Color.White,
                .ForeColor = ColorTranslator.FromHtml("#333333"),
                .TabIndex = tabIndex
            }
        End Function

        Private Sub AddRow(labelText As String, control As Control)
            Dim row As Integer = panel.RowCount - 1
            panel.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            panel.Controls.Add(New Label() With {
                .Text = labelText,
                .AutoSize = True,
                .Margin = New Padding(0, 8, 8, 8),
                .ForeColor = ColorTranslator.FromHtml("#333333")
            }, 0, row)
            panel.Controls.Add(control, 1, row)
            panel.RowCount += 1
        End Sub

        Private Sub OnSave(sender As Object, e As EventArgs)
            Try
                Select Case entry
                    Case EntryType.Book
                        SaveBook()
                    Case EntryType.Member
                        SaveMember()
                    Case EntryType.Transaction
                        SaveTransaction()
                End Select
                DialogResult = DialogResult.OK
            Catch ex As Exception
                Logger.Error("Save failed", ex)
                MessageBox.Show("Save failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub SaveBook()
            Dim book As New Book() With {
                .Title = txtTitle.Text.Trim(),
                .Author = txtAuthor.Text.Trim(),
                .ISBN = txtISBN.Text.Trim(),
                .Genre = txtGenre.Text.Trim()
            }

            If Not String.IsNullOrWhiteSpace(txtYear.Text) Then
                Dim yearValue As Integer
                If Integer.TryParse(txtYear.Text, yearValue) Then
                    book.PublishYear = yearValue
                Else
                    errorProvider.SetError(txtYear, "Publish year must be a number")
                    Throw New ArgumentException("Publish year must be a number")
                End If
            End If
            book.Available = chkAvailable.Checked

            Dim errors = book.Validate()
            If errors.Count > 0 Then
                ShowValidationErrors(errors)
                Throw New ArgumentException(String.Join("; ", errors))
            End If

            Dim repo As New BookRepository()
            repo.Insert(book)
        End Sub

        Private Sub SaveMember()
            Dim member As New Member() With {
                .FirstName = txtFirstName.Text.Trim(),
                .LastName = txtLastName.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .Phone = txtPhone.Text.Trim(),
                .JoinDate = dtJoinDate.Value.Date
            }

            Dim errors = member.Validate()
            If errors.Count > 0 Then
                ShowValidationErrors(errors)
                Throw New ArgumentException(String.Join("; ", errors))
            End If

            Dim repo As New MemberRepository()
            repo.Insert(member)
        End Sub

        Private Sub SaveTransaction()
            Dim trx As New Models.Transaction() With {
                .Status = txtStatus.Text.Trim(),
                .BorrowDate = dtBorrow.Value.Date
            }

            Dim v As Integer
            If Not Integer.TryParse(txtBookId.Text, v) OrElse v <= 0 Then
                errorProvider.SetError(txtBookId, "Book ID must be a positive integer")
                Throw New ArgumentException("Book ID must be a positive integer")
            End If
            trx.BookID = v

            If Not Integer.TryParse(txtMemberId.Text, v) OrElse v <= 0 Then
                errorProvider.SetError(txtMemberId, "Member ID must be a positive integer")
                Throw New ArgumentException("Member ID must be a positive integer")
            End If
            trx.MemberID = v

            If dtReturn.ShowCheckBox AndAlso dtReturn.Checked Then
                trx.ReturnDate = dtReturn.Value.Date
            End If

            Dim errors = trx.Validate()
            If errors.Count > 0 Then
                ShowValidationErrors(errors)
                Throw New ArgumentException(String.Join("; ", errors))
            End If

            Dim repo As New TransactionRepository()
            repo.Insert(trx)
        End Sub

        Private Sub ShowValidationErrors(errors As List(Of String))
            MessageBox.Show(String.Join(Environment.NewLine, errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
    End Class
End Namespace
