<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingHistoryForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnThisMonth = New System.Windows.Forms.Button()
        Me.btnThreeMonths = New System.Windows.Forms.Button()
        Me.btnThisYear = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilters.Location = New System.Drawing.Point(16, 16)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(952, 88)
        Me.pnlFilters.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 120)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(952, 360)
        Me.dgv.TabIndex = 1
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.White
        Me.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStats.Location = New System.Drawing.Point(16, 492)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(740, 53)
        Me.pnlStats.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(772, 496)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(90, 30)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(878, 496)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 30)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'BorrowingHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlFilters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "BorrowingHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Borrowing History"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFilters As System.Windows.Forms.Panel
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThisMonth As System.Windows.Forms.Button
    Friend WithEvents btnThreeMonths As System.Windows.Forms.Button
    Friend WithEvents btnThisYear As System.Windows.Forms.Button
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
