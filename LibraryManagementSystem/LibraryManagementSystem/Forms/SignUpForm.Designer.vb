<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlPersonal = New System.Windows.Forms.Panel()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.pnlAcademic = New System.Windows.Forms.Panel()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.pnlSecurity = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblRequirements = New System.Windows.Forms.Label()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.chkTerms = New System.Windows.Forms.CheckBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lnkBack = New System.Windows.Forms.LinkLabel()
        Me.pnlPhoto = New System.Windows.Forms.Panel()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.pnlPersonal.SuspendLayout()
        Me.pnlAcademic.SuspendLayout()
        Me.pnlSecurity.SuspendLayout()
        Me.pnlPhoto.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblHeader.Location = New System.Drawing.Point(24, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(309, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Create Student Account"
        '
        'pnlPersonal
        '
        Me.pnlPersonal.BackColor = System.Drawing.Color.White
        Me.pnlPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPersonal.Controls.Add(Me.lblPhone)
        Me.pnlPersonal.Controls.Add(Me.lblEmail)
        Me.pnlPersonal.Controls.Add(Me.lblReg)
        Me.pnlPersonal.Controls.Add(Me.lblLastName)
        Me.pnlPersonal.Controls.Add(Me.lblFirstName)
        Me.pnlPersonal.Controls.Add(Me.txtPhone)
        Me.pnlPersonal.Controls.Add(Me.txtEmail)
        Me.pnlPersonal.Controls.Add(Me.txtReg)
        Me.pnlPersonal.Controls.Add(Me.txtLastName)
        Me.pnlPersonal.Controls.Add(Me.txtFirstName)
        Me.pnlPersonal.Location = New System.Drawing.Point(24, 70)
        Me.pnlPersonal.Name = "pnlPersonal"
        Me.pnlPersonal.Size = New System.Drawing.Size(600, 200)
        Me.pnlPersonal.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(24, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(250, 23)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(320, 48)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(250, 23)
        Me.txtLastName.TabIndex = 1
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(24, 104)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(250, 23)
        Me.txtReg.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(320, 104)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 23)
        Me.txtEmail.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(24, 160)
        Me.txtPhone.Mask = "+0 (000) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 23)
        Me.txtPhone.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(24, 28)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(67, 15)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(320, 28)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(66, 15)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(24, 84)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(125, 15)
        Me.lblReg.TabIndex = 7
        Me.lblReg.Text = "Registration Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(320, 84)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(24, 140)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(43, 15)
        Me.lblPhone.TabIndex = 9
        Me.lblPhone.Text = "Phone"
        '
        'pnlAcademic
        '
        Me.pnlAcademic.BackColor = System.Drawing.Color.White
        Me.pnlAcademic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAcademic.Controls.Add(Me.lblYear)
        Me.pnlAcademic.Controls.Add(Me.lblDept)
        Me.pnlAcademic.Controls.Add(Me.cboYear)
        Me.pnlAcademic.Controls.Add(Me.cboDepartment)
        Me.pnlAcademic.Location = New System.Drawing.Point(24, 286)
        Me.pnlAcademic.Name = "pnlAcademic"
        Me.pnlAcademic.Size = New System.Drawing.Size(600, 120)
        Me.pnlAcademic.TabIndex = 2
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"CS", "Engineering", "Medicine", "Business", "Arts", "Science"})
        Me.cboDepartment.Location = New System.Drawing.Point(24, 48)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(250, 23)
        Me.cboDepartment.TabIndex = 0
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "Masters", "PhD"})
        Me.cboYear.Location = New System.Drawing.Point(320, 48)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(250, 23)
        Me.cboYear.TabIndex = 1
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(24, 28)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(71, 15)
        Me.lblDept.TabIndex = 2
        Me.lblDept.Text = "Department"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(320, 28)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(76, 15)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year of Study"
        '
        'pnlSecurity
        '
        Me.pnlSecurity.BackColor = System.Drawing.Color.White
        Me.pnlSecurity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSecurity.Controls.Add(Me.lblRequirements)
        Me.pnlSecurity.Controls.Add(Me.lblConfirm)
        Me.pnlSecurity.Controls.Add(Me.lblPassword)
        Me.pnlSecurity.Controls.Add(Me.txtConfirm)
        Me.pnlSecurity.Controls.Add(Me.txtPassword)
        Me.pnlSecurity.Location = New System.Drawing.Point(24, 420)
        Me.pnlSecurity.Name = "pnlSecurity"
        Me.pnlSecurity.Size = New System.Drawing.Size(600, 160)
        Me.pnlSecurity.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(24, 48)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 23)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(320, 48)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(250, 23)
        Me.txtConfirm.TabIndex = 1
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(24, 28)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 15)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(320, 28)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(109, 15)
        Me.lblConfirm.TabIndex = 3
        Me.lblConfirm.Text = "Confirm Password"
        '
        'lblRequirements
        '
        Me.lblRequirements.AutoSize = True
        Me.lblRequirements.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44)
        Me.lblRequirements.Location = New System.Drawing.Point(24, 88)
        Me.lblRequirements.Name = "lblRequirements"
        Me.lblRequirements.Size = New System.Drawing.Size(313, 15)
        Me.lblRequirements.TabIndex = 4
        Me.lblRequirements.Text = "Min 8 chars, include 1 uppercase and 1 number."
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(24, 662)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(600, 10)
        Me.progress.TabIndex = 4
        Me.progress.Visible = False
        '
        'chkTerms
        '
        Me.chkTerms.AutoSize = True
        Me.chkTerms.Location = New System.Drawing.Point(24, 594)
        Me.chkTerms.Name = "chkTerms"
        Me.chkTerms.Size = New System.Drawing.Size(277, 19)
        Me.chkTerms.TabIndex = 5
        Me.chkTerms.Text = "I agree to the library terms and conditions."
        Me.chkTerms.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreate.Location = New System.Drawing.Point(24, 620)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(600, 36)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Account"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lnkBack
        '
        Me.lnkBack.AutoSize = True
        Me.lnkBack.Location = New System.Drawing.Point(24, 684)
        Me.lnkBack.Name = "lnkBack"
        Me.lnkBack.Size = New System.Drawing.Size(85, 15)
        Me.lnkBack.TabIndex = 7
        Me.lnkBack.TabStop = True
        Me.lnkBack.Text = "Back to Login"
        '
        'pnlPhoto
        '
        Me.pnlPhoto.BackColor = System.Drawing.Color.White
        Me.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPhoto.Controls.Add(Me.btnUpload)
        Me.pnlPhoto.Controls.Add(Me.picPhoto)
        Me.pnlPhoto.Location = New System.Drawing.Point(648, 70)
        Me.pnlPhoto.Name = "pnlPhoto"
        Me.pnlPhoto.Size = New System.Drawing.Size(280, 260)
        Me.pnlPhoto.TabIndex = 8
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.Color.FromArgb(193, 213, 164)
        Me.picPhoto.Location = New System.Drawing.Point(24, 24)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(232, 176)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.TabIndex = 0
        Me.picPhoto.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(24, 210)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(232, 30)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Photo"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(960, 720)
        Me.Controls.Add(Me.pnlPhoto)
        Me.Controls.Add(Me.lnkBack)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.chkTerms)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.pnlSecurity)
        Me.Controls.Add(Me.pnlAcademic)
        Me.Controls.Add(Me.pnlPersonal)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Student Account"
        Me.pnlPersonal.ResumeLayout(False)
        Me.pnlPersonal.PerformLayout()
        Me.pnlAcademic.ResumeLayout(False)
        Me.pnlAcademic.PerformLayout()
        Me.pnlSecurity.ResumeLayout(False)
        Me.pnlSecurity.PerformLayout()
        Me.pnlPhoto.ResumeLayout(False)
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlPersonal As System.Windows.Forms.Panel
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents pnlAcademic As System.Windows.Forms.Panel
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents pnlSecurity As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblRequirements As System.Windows.Forms.Label
    Friend WithEvents progress As System.Windows.Forms.ProgressBar
    Friend WithEvents chkTerms As System.Windows.Forms.CheckBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lnkBack As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlPhoto As System.Windows.Forms.Panel
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
End Class
