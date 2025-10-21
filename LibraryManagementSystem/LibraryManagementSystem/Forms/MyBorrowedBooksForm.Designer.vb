<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyBorrowedBooksForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblTotalFines = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSummary
        '
        Me.pnlSummary.BackColor = System.Drawing.Color.White
        Me.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummary.Location = New System.Drawing.Point(16, 16)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(952, 80)
        Me.pnlSummary.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 112)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 48
        Me.dgv.Size = New System.Drawing.Size(952, 380)
        Me.dgv.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(16, 508)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 30)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblTotalFines
        '
        Me.lblTotalFines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFines.AutoSize = True
        Me.lblTotalFines.Location = New System.Drawing.Point(820, 516)
        Me.lblTotalFines.Name = "lblTotalFines"
        Me.lblTotalFines.Size = New System.Drawing.Size(77, 15)
        Me.lblTotalFines.TabIndex = 3
        Me.lblTotalFines.Text = "Total Fines: $0"
        '
        'MyBorrowedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.lblTotalFines)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "MyBorrowedBooksForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Borrowed Books"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSummary As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblTotalFines As System.Windows.Forms.Label
End Class
