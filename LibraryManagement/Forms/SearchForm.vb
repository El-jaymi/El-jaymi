Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.DataAccess
Imports LibraryManagement.Utilities

Namespace LibraryManagement.Forms
    Public Class SearchForm
        Inherits Form

        Private ReadOnly txtKeyword As New TextBox()
        Private ReadOnly btnSearch As New Button()
        Private ReadOnly cboType As New ComboBox()
        Private ReadOnly grid As New DataGridView()

        Private ReadOnly bookRepo As New BookRepository()
        Private ReadOnly memberRepo As New MemberRepository()
        Private ReadOnly transactionRepo As New TransactionRepository()

        Public Sub New()
            Me.Text = "Search"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.MinimumSize = New Size(800, 500)
            Me.BackColor = ColorTranslator.FromHtml("#F5F5F5")
            Me.Font = New Font("Segoe UI", 9.0F)

            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim topPanel As New FlowLayoutPanel() With {
                .Dock = DockStyle.Top,
                .Height = 48,
                .Padding = New Padding(8),
                .FlowDirection = FlowDirection.LeftToRight
            }

            cboType.DropDownStyle = ComboBoxStyle.DropDownList
            cboType.Items.AddRange(New Object() {"Books", "Members", "Transactions"})
            cboType.SelectedIndex = 0
            cboType.Width = 150
            cboType.TabIndex = 0

            txtKeyword.Width = 300
            txtKeyword.BorderStyle = BorderStyle.FixedSingle
            txtKeyword.TabIndex = 1

            btnSearch.Text = "Search"
            btnSearch.BackColor = ColorTranslator.FromHtml("#0078D4")
            btnSearch.ForeColor = Color.White
            btnSearch.FlatStyle = FlatStyle.Flat
            btnSearch.TabIndex = 2
            AddHandler btnSearch.Click, AddressOf OnSearch

            topPanel.Controls.AddRange(New Control() {cboType, txtKeyword, btnSearch})
            Controls.Add(topPanel)

            grid.Dock = DockStyle.Fill
            grid.BackgroundColor = Color.White
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.ReadOnly = True
            Controls.Add(grid)
        End Sub

        Private Sub OnSearch(sender As Object, e As EventArgs)
            Try
                Dim keyword As String = txtKeyword.Text.Trim()
                Dim dt As DataTable
                Select Case cboType.SelectedItem.ToString()
                    Case "Books"
                        dt = If(String.IsNullOrWhiteSpace(keyword), bookRepo.GetAll(), bookRepo.Search(keyword))
                    Case "Members"
                        dt = If(String.IsNullOrWhiteSpace(keyword), memberRepo.GetAll(), memberRepo.Search(keyword))
                    Case Else
                        dt = If(String.IsNullOrWhiteSpace(keyword), transactionRepo.GetAll(), transactionRepo.Search(keyword))
                End Select
                grid.DataSource = dt
            Catch ex As Exception
                Logger.Error("Search failed", ex)
                MessageBox.Show("Search failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
