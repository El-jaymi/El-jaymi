Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.DataAccess
Imports LibraryManagement.Utilities

Namespace LibraryManagement.Forms
    Public Class MainForm
        Inherits Form

        Private ReadOnly menuStrip As New MenuStrip()
        Private ReadOnly toolStrip As New ToolStrip()
        Private ReadOnly statusStrip As New StatusStrip()
        Private ReadOnly statusLabel As New ToolStripStatusLabel()
        Private ReadOnly tabControl As New TabControl()
        Private ReadOnly booksGrid As New DataGridView()
        Private ReadOnly membersGrid As New DataGridView()
        Private ReadOnly transactionsGrid As New DataGridView()

        Private ReadOnly bookRepo As New BookRepository()
        Private ReadOnly memberRepo As New MemberRepository()
        Private ReadOnly transactionRepo As New TransactionRepository()

        Public Sub New()
            Me.Text = "Library Management - Dashboard"
            Me.MinimumSize = New Size(1000, 700)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.BackColor = ColorTranslator.FromHtml("#F5F5F5")
            Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)

            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            ' Menu
            Dim fileMenu As New ToolStripMenuItem("File")
            Dim exportMenu As New ToolStripMenuItem("Export Current Tab to CSV", Nothing, AddressOf OnExportCsv)
            Dim settingsMenu As New ToolStripMenuItem("Settings", Nothing, AddressOf OnOpenSettings)
            Dim exitMenu As New ToolStripMenuItem("Exit", Nothing, AddressOf OnExit)
            fileMenu.DropDownItems.AddRange(New ToolStripItem() {exportMenu, New ToolStripSeparator(), settingsMenu, New ToolStripSeparator(), exitMenu})

            Dim manageMenu As New ToolStripMenuItem("Manage")
            Dim addBookMenu As New ToolStripMenuItem("Add Book", Nothing, AddressOf OnAddBook)
            Dim addMemberMenu As New ToolStripMenuItem("Add Member", Nothing, AddressOf OnAddMember)
            Dim addTransactionMenu As New ToolStripMenuItem("Add Transaction", Nothing, AddressOf OnAddTransaction)
            manageMenu.DropDownItems.AddRange(New ToolStripItem() {addBookMenu, addMemberMenu, addTransactionMenu})

            menuStrip.Items.AddRange(New ToolStripItem() {fileMenu, manageMenu})
            menuStrip.BackColor = Color.White
            menuStrip.RenderMode = ToolStripRenderMode.System
            Controls.Add(menuStrip)

            ' ToolStrip
            Dim refreshButton As New ToolStripButton("Refresh", Nothing, AddressOf OnRefresh) With {.DisplayStyle = ToolStripItemDisplayStyle.Text}
            Dim searchLabel As New ToolStripLabel("Search:")
            Dim searchBox As New ToolStripTextBox() With {.AutoSize = False, .Width = 250}
            AddHandler searchBox.KeyDown, Sub(s, e)
                                              If e.KeyCode = Keys.Enter Then
                                                  OnSearch(searchBox.Text)
                                              End If
                                          End Sub
            toolStrip.Items.AddRange(New ToolStripItem() {refreshButton, New ToolStripSeparator(), searchLabel, searchBox})
            toolStrip.GripStyle = ToolStripGripStyle.Hidden
            toolStrip.BackColor = Color.White
            toolStrip.Dock = DockStyle.Top
            Controls.Add(toolStrip)

            ' StatusStrip
            statusLabel.Text = "Ready"
            statusStrip.Items.Add(statusLabel)
            statusStrip.SizingGrip = False
            statusStrip.BackColor = Color.White
            Controls.Add(statusStrip)

            ' TabControl
            tabControl.Dock = DockStyle.Fill
            tabControl.Alignment = TabAlignment.Top
            tabControl.Appearance = TabAppearance.Normal
            Controls.Add(tabControl)

            ' Tabs and grids
            SetupGrid(booksGrid)
            SetupGrid(membersGrid)
            SetupGrid(transactionsGrid)

            Dim booksPage As New TabPage("Books") With {.BackColor = ColorTranslator.FromHtml("#F5F5F5")}
            booksPage.Controls.Add(booksGrid)
            Dim membersPage As New TabPage("Members") With {.BackColor = ColorTranslator.FromHtml("#F5F5F5")}
            membersPage.Controls.Add(membersGrid)
            Dim transactionsPage As New TabPage("Transactions") With {.BackColor = ColorTranslator.FromHtml("#F5F5F5")}
            transactionsPage.Controls.Add(transactionsGrid)

            tabControl.TabPages.AddRange(New TabPage() {booksPage, membersPage, transactionsPage})

            ' Layout
            menuStrip.Dock = DockStyle.Top
            toolStrip.Dock = DockStyle.Top
            statusStrip.Dock = DockStyle.Bottom

            LoadData()
        End Sub

        Private Sub SetupGrid(grid As DataGridView)
            grid.Dock = DockStyle.Fill
            grid.BackgroundColor = Color.White
            grid.EnableHeadersVisualStyles = False
            grid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0078D4")
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            grid.DefaultCellStyle.BackColor = Color.White
            grid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#333333")
            grid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0F8FF")
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.MultiSelect = False
            grid.ReadOnly = True
            grid.AllowUserToAddRows = False
            grid.AllowUserToDeleteRows = False
        End Sub

        Private Sub LoadData()
            Try
                statusLabel.Text = "Loading..."
                booksGrid.DataSource = bookRepo.GetAll()
                membersGrid.DataSource = memberRepo.GetAll()
                transactionsGrid.DataSource = transactionRepo.GetAll()
                statusLabel.Text = "Loaded"
            Catch ex As Exception
                statusLabel.Text = "Error"
                Logger.Error("Failed to load data", ex)
                MessageBox.Show("Failed to load data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub OnRefresh(sender As Object, e As EventArgs)
            LoadData()
        End Sub

        Private Sub OnSearch(keyword As String)
            Try
                Dim currentTab As TabPage = tabControl.SelectedTab
                If currentTab Is Nothing Then Return

                If currentTab.Text = "Books" Then
                    booksGrid.DataSource = If(String.IsNullOrWhiteSpace(keyword), bookRepo.GetAll(), bookRepo.Search(keyword))
                ElseIf currentTab.Text = "Members" Then
                    membersGrid.DataSource = If(String.IsNullOrWhiteSpace(keyword), memberRepo.GetAll(), memberRepo.Search(keyword))
                Else
                    transactionsGrid.DataSource = If(String.IsNullOrWhiteSpace(keyword), transactionRepo.GetAll(), transactionRepo.Search(keyword))
                End If
                statusLabel.Text = "Search complete"
            Catch ex As Exception
                statusLabel.Text = "Error"
                Logger.Error("Search error", ex)
                MessageBox.Show("Search error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub OnExportCsv(sender As Object, e As EventArgs)
            Try
                Dim sfd As New SaveFileDialog() With {
                    .Filter = "CSV Files (*.csv)|*.csv",
                    .Title = "Export to CSV",
                    .FileName = tabControl.SelectedTab.Text & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"
                }
                If sfd.ShowDialog(Me) = DialogResult.OK Then
                    Dim source As DataTable = TryCast(GetCurrentGrid().DataSource, DataTable)
                    If source Is Nothing Then
                        MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    CsvExporter.ExportDataTable(source, sfd.FileName, True)
                    statusLabel.Text = "Exported " & sfd.FileName
                End If
            Catch ex As Exception
                statusLabel.Text = "Error"
                Logger.Error("Export error", ex)
                MessageBox.Show("Export error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function GetCurrentGrid() As DataGridView
            If tabControl.SelectedTab Is Nothing Then Return booksGrid
            Select Case tabControl.SelectedTab.Text
                Case "Books" : Return booksGrid
                Case "Members" : Return membersGrid
                Case Else : Return transactionsGrid
            End Select
        End Function

        Private Sub OnOpenSettings(sender As Object, e As EventArgs)
            Using frm As New SettingsForm()
                frm.ShowDialog(Me)
            End Using
        End Sub

        Private Sub OnAddBook(sender As Object, e As EventArgs)
            Using frm As New DataEntryForm(DataEntryForm.EntryType.Book)
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadData()
                End If
            End Using
        End Sub

        Private Sub OnAddMember(sender As Object, e As EventArgs)
            Using frm As New DataEntryForm(DataEntryForm.EntryType.Member)
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadData()
                End If
            End Using
        End Sub

        Private Sub OnAddTransaction(sender As Object, e As EventArgs)
            Using frm As New DataEntryForm(DataEntryForm.EntryType.Transaction)
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadData()
                End If
            End Using
        End Sub

        Private Sub OnExit(sender As Object, e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
