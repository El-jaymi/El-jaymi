<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnBorrowed = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.lblStatusConn = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.status.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(255, 254, 242)
        Me.pnlLeft.Controls.Add(Me.btnLogout)
        Me.pnlLeft.Controls.Add(Me.btnHelp)
        Me.pnlLeft.Controls.Add(Me.btnNotifications)
        Me.pnlLeft.Controls.Add(Me.btnProfile)
        Me.pnlLeft.Controls.Add(Me.btnHistory)
        Me.pnlLeft.Controls.Add(Me.btnBorrowed)
        Me.pnlLeft.Controls.Add(Me.btnBrowse)
        Me.pnlLeft.Controls.Add(Me.btnHome)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(250, 681)
        Me.pnlLeft.TabIndex = 0
        '
        'Buttons
        '
        Me.btnHome.Location = New System.Drawing.Point(16, 24)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(218, 36)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        Me.btnBrowse.Location = New System.Drawing.Point(16, 72)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(218, 36)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Books"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        Me.btnBorrowed.Location = New System.Drawing.Point(16, 120)
        Me.btnBorrowed.Name = "btnBorrowed"
        Me.btnBorrowed.Size = New System.Drawing.Size(218, 36)
        Me.btnBorrowed.TabIndex = 2
        Me.btnBorrowed.Text = "My Borrowed Books"
        Me.btnBorrowed.UseVisualStyleBackColor = True
        '
        Me.btnHistory.Location = New System.Drawing.Point(16, 168)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(218, 36)
        Me.btnHistory.TabIndex = 3
        Me.btnHistory.Text = "Borrowing History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        Me.btnProfile.Location = New System.Drawing.Point(16, 216)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(218, 36)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.Text = "My Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        Me.btnNotifications.Location = New System.Drawing.Point(16, 264)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(218, 36)
        Me.btnNotifications.TabIndex = 5
        Me.btnNotifications.Text = "Notifications"
        Me.btnNotifications.UseVisualStyleBackColor = True
        '
        Me.btnHelp.Location = New System.Drawing.Point(16, 312)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(218, 36)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        Me.btnLogout.Location = New System.Drawing.Point(16, 360)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(218, 36)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.lblDateTime)
        Me.pnlTop.Controls.Add(Me.lblWelcome)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(250, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1014, 64)
        Me.pnlTop.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblWelcome.Location = New System.Drawing.Point(16, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(150, 25)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, User!"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44)
        Me.lblDateTime.Location = New System.Drawing.Point(800, 22)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(180, 19)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Tuesday, 21 Oct 2025 12:00"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(250, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1014, 595)
        Me.pnlMain.TabIndex = 2
        '
        'status
        '
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusConn})
        Me.status.Location = New System.Drawing.Point(250, 659)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(1014, 22)
        Me.status.TabIndex = 3
        Me.status.Text = "StatusStrip1"
        '
        'lblStatusConn
        '
        Me.lblStatusConn.Name = "lblStatusConn"
        Me.lblStatusConn.Size = New System.Drawing.Size(116, 17)
        Me.lblStatusConn.Text = "Connected to server"
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.status)
        Me.Name = "StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnNotifications As System.Windows.Forms.Button
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnBorrowed As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents status As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusConn As System.Windows.Forms.ToolStripStatusLabel
End Class
