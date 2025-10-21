<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(255, 254, 242)
        Me.pnlLeft.Controls.Add(Me.btnLogout)
        Me.pnlLeft.Controls.Add(Me.btnSettings)
        Me.pnlLeft.Controls.Add(Me.btnReports)
        Me.pnlLeft.Controls.Add(Me.btnTransactions)
        Me.pnlLeft.Controls.Add(Me.btnStudents)
        Me.pnlLeft.Controls.Add(Me.btnBooks)
        Me.pnlLeft.Controls.Add(Me.btnReturn)
        Me.pnlLeft.Controls.Add(Me.btnIssue)
        Me.pnlLeft.Controls.Add(Me.btnHome)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(280, 681)
        Me.pnlLeft.TabIndex = 0
        '
        'Buttons
        '
        Me.btnHome.Location = New System.Drawing.Point(16, 24)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(248, 36)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Dashboard Home"
        Me.btnHome.UseVisualStyleBackColor = True

        Me.btnIssue.Location = New System.Drawing.Point(16, 72)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(248, 36)
        Me.btnIssue.TabIndex = 1
        Me.btnIssue.Text = "Issue Book"
        Me.btnIssue.UseVisualStyleBackColor = True

        Me.btnReturn.Location = New System.Drawing.Point(16, 120)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(248, 36)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True

        Me.btnBooks.Location = New System.Drawing.Point(16, 168)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(248, 36)
        Me.btnBooks.TabIndex = 3
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.UseVisualStyleBackColor = True

        Me.btnStudents.Location = New System.Drawing.Point(16, 216)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(248, 36)
        Me.btnStudents.TabIndex = 4
        Me.btnStudents.Text = "Manage Students"
        Me.btnStudents.UseVisualStyleBackColor = True

        Me.btnTransactions.Location = New System.Drawing.Point(16, 264)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(248, 36)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "View Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = True

        Me.btnReports.Location = New System.Drawing.Point(16, 312)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(248, 36)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Generate Reports"
        Me.btnReports.UseVisualStyleBackColor = True

        Me.btnSettings.Location = New System.Drawing.Point(16, 360)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(248, 36)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "System Settings"
        Me.btnSettings.UseVisualStyleBackColor = True

        Me.btnLogout.Location = New System.Drawing.Point(16, 408)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(248, 36)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(280, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(984, 64)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblTitle.Location = New System.Drawing.Point(16, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(197, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Librarian Portal"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(280, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(984, 617)
        Me.pnlMain.TabIndex = 2
        '
        'LibrarianDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "LibrarianDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Librarian Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnTransactions As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
End Class
