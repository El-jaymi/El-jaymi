<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.chkRememberMe = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lnkSignUp = New System.Windows.Forms.LinkLabel()
        Me.lnkForgot = New System.Windows.Forms.LinkLabel()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbLibrarian = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 120)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblTitle.Location = New System.Drawing.Point(160, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(393, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Library Management System"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.FromArgb(193, 213, 164)
        Me.picLogo.Location = New System.Drawing.Point(24, 20)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(120, 80)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUsername.Location = New System.Drawing.Point(320, 200)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(350, 27)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(320, 260)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(350, 27)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44)
        Me.lblUsername.Location = New System.Drawing.Point(320, 175)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(170, 20)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username or Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44)
        Me.lblPassword.Location = New System.Drawing.Point(320, 235)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 20)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(320, 293)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 19)
        Me.chkShowPassword.TabIndex = 2
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'chkRememberMe
        '
        Me.chkRememberMe.AutoSize = True
        Me.chkRememberMe.Location = New System.Drawing.Point(468, 293)
        Me.chkRememberMe.Name = "chkRememberMe"
        Me.chkRememberMe.Size = New System.Drawing.Size(102, 19)
        Me.chkRememberMe.TabIndex = 3
        Me.chkRememberMe.Text = "Remember Me"
        Me.chkRememberMe.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(320, 360)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 40)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lnkSignUp
        '
        Me.lnkSignUp.AutoSize = True
        Me.lnkSignUp.Location = New System.Drawing.Point(320, 410)
        Me.lnkSignUp.Name = "lnkSignUp"
        Me.lnkSignUp.Size = New System.Drawing.Size(54, 15)
        Me.lnkSignUp.TabIndex = 5
        Me.lnkSignUp.TabStop = True
        Me.lnkSignUp.Text = "Sign Up"
        '
        'lnkForgot
        '
        Me.lnkForgot.AutoSize = True
        Me.lnkForgot.Location = New System.Drawing.Point(606, 410)
        Me.lnkForgot.Name = "lnkForgot"
        Me.lnkForgot.Size = New System.Drawing.Size(96, 15)
        Me.lnkForgot.TabIndex = 6
        Me.lnkForgot.TabStop = True
        Me.lnkForgot.Text = "Forgot Password?"
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Checked = True
        Me.rbStudent.Location = New System.Drawing.Point(320, 328)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(66, 19)
        Me.rbStudent.TabIndex = 7
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "Student"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rbLibrarian
        '
        Me.rbLibrarian.AutoSize = True
        Me.rbLibrarian.Location = New System.Drawing.Point(400, 328)
        Me.rbLibrarian.Name = "rbLibrarian"
        Me.rbLibrarian.Size = New System.Drawing.Size(73, 19)
        Me.rbLibrarian.TabIndex = 8
        Me.rbLibrarian.Text = "Librarian"
        Me.rbLibrarian.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(217, 83, 79)
        Me.lblStatus.Location = New System.Drawing.Point(320, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(149, 15)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Invalid credentials."
        Me.lblStatus.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rbLibrarian)
        Me.Controls.Add(Me.rbStudent)
        Me.Controls.Add(Me.lnkForgot)
        Me.Controls.Add(Me.lnkSignUp)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chkRememberMe)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Library Management System"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkRememberMe As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lnkSignUp As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkForgot As System.Windows.Forms.LinkLabel
    Friend WithEvents rbStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rbLibrarian As System.Windows.Forms.RadioButton
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
