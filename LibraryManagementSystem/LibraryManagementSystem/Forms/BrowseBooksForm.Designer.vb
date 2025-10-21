<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseBooksForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.txtISBN)
        Me.pnlSearch.Controls.Add(Me.txtAuthor)
        Me.pnlSearch.Controls.Add(Me.cboCategory)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(984, 80)
        Me.pnlSearch.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(16, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search title, author, ISBN"
        Me.txtSearch.Size = New System.Drawing.Size(250, 23)
        Me.txtSearch.TabIndex = 0
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"All", "Fiction", "Non-Fiction", "Science", "History", "Biography"})
        Me.cboCategory.Location = New System.Drawing.Point(280, 28)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(150, 23)
        Me.cboCategory.TabIndex = 1
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(444, 28)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.PlaceholderText = "Author"
        Me.txtAuthor.Size = New System.Drawing.Size(150, 23)
        Me.txtAuthor.TabIndex = 2
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(606, 28)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PlaceholderText = "ISBN"
        Me.txtISBN.Size = New System.Drawing.Size(120, 23)
        Me.txtISBN.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(740, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 27)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(846, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 27)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.BackgroundColor = System.Drawing.Color.White
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResults.Location = New System.Drawing.Point(0, 80)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowTemplate.Height = 60
        Me.dgvResults.Size = New System.Drawing.Size(984, 481)
        Me.dgvResults.TabIndex = 1
        '
        'BrowseBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.pnlSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "BrowseBooksForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Browse Books"
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
End Class
