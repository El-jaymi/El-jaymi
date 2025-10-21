<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnWishlist = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Controls.Add(Me.btnWishlist)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.picCover)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlLeft.Size = New System.Drawing.Size(300, 600)
        Me.pnlLeft.TabIndex = 0
        '
        'picCover
        '
        Me.picCover.BackColor = System.Drawing.Color.FromArgb(193, 213, 164)
        Me.picCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.picCover.Location = New System.Drawing.Point(16, 16)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(268, 360)
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCover.TabIndex = 0
        Me.picCover.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(92, 184, 92)
        Me.lblStatus.Location = New System.Drawing.Point(16, 392)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(79, 20)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Available"
        '
        'btnWishlist
        '
        Me.btnWishlist.Location = New System.Drawing.Point(16, 430)
        Me.btnWishlist.Name = "btnWishlist"
        Me.btnWishlist.Size = New System.Drawing.Size(268, 30)
        Me.btnWishlist.TabIndex = 2
        Me.btnWishlist.Text = "Add to Wishlist"
        Me.btnWishlist.UseVisualStyleBackColor = True
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.pnlRight.Controls.Add(Me.btnClose)
        Me.pnlRight.Controls.Add(Me.btnReserve)
        Me.pnlRight.Controls.Add(Me.btnBorrow)
        Me.pnlRight.Controls.Add(Me.txtDetails)
        Me.pnlRight.Controls.Add(Me.lblAuthor)
        Me.pnlRight.Controls.Add(Me.lblTitle)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(300, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlRight.Size = New System.Drawing.Size(500, 600)
        Me.pnlRight.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Book Title Here"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblAuthor.Location = New System.Drawing.Point(22, 60)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(122, 21)
        Me.lblAuthor.TabIndex = 1
        Me.lblAuthor.Text = "by Author Name"
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(24, 96)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(452, 400)
        Me.txtDetails.TabIndex = 2
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(24, 512)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(140, 30)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "Borrow This Book"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.Location = New System.Drawing.Point(180, 512)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(140, 30)
        Me.btnReserve.TabIndex = 4
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(336, 512)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BookDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BookDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Book Details"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents picCover As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnWishlist As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnReserve As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
