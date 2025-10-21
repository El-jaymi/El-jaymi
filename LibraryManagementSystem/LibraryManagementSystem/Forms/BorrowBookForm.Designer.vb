<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlBook = New System.Windows.Forms.Panel()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.chkAccept = New System.Windows.Forms.CheckBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(74, 124, 60)
        Me.lblHeader.Location = New System.Drawing.Point(24, 20)
        Me.lblHeader.Text = "Borrow Book Confirmation"
        '
        Me.pnlBook.BackColor = System.Drawing.Color.White
        Me.pnlBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBook.Location = New System.Drawing.Point(24, 64)
        Me.pnlBook.Size = New System.Drawing.Size(540, 120)
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.White
        Me.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStudent.Location = New System.Drawing.Point(24, 196)
        Me.pnlStudent.Size = New System.Drawing.Size(540, 120)
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.White
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Location = New System.Drawing.Point(24, 328)
        Me.pnlDetails.Size = New System.Drawing.Size(540, 100)
        '
        Me.chkAccept.AutoSize = True
        Me.chkAccept.Location = New System.Drawing.Point(24, 440)
        Me.chkAccept.Text = "I Accept the terms"
        '
        Me.btnConfirm.Location = New System.Drawing.Point(24, 472)
        Me.btnConfirm.Size = New System.Drawing.Size(260, 36)
        Me.btnConfirm.Text = "Confirm Borrow"
        '
        Me.btnCancel.Location = New System.Drawing.Point(304, 472)
        Me.btnCancel.Size = New System.Drawing.Size(260, 36)
        Me.btnCancel.Text = "Cancel"
        '
        Me.progress.Location = New System.Drawing.Point(24, 520)
        Me.progress.Size = New System.Drawing.Size(540, 8)
        Me.progress.Visible = False
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 248, 231)
        Me.ClientSize = New System.Drawing.Size(600, 540)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.chkAccept)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.pnlBook)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "BorrowBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Borrow Book"
    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlBook As System.Windows.Forms.Panel
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents chkAccept As System.Windows.Forms.CheckBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents progress As System.Windows.Forms.ProgressBar
End Class
