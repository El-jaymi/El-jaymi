Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Utilities

Namespace LibraryManagement.Forms
    Public Class SettingsForm
        Inherits Form

        Private ReadOnly panel As New TableLayoutPanel()
        Private ReadOnly txtHost As New TextBox()
        Private ReadOnly txtPort As New TextBox()
        Private ReadOnly txtUser As New TextBox()
        Private ReadOnly txtPassword As New TextBox()
        Private ReadOnly txtDbName As New TextBox()
        Private ReadOnly btnSave As New Button()

        Public Sub New()
            Me.Text = "Settings"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.MinimumSize = New Size(500, 350)
            Me.BackColor = ColorTranslator.FromHtml("#F5F5F5")
            Me.Font = New Font("Segoe UI", 9.0F)
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            panel.ColumnCount = 2
            panel.RowCount = 1
            panel.Dock = DockStyle.Fill
            panel.Padding = New Padding(16)
            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70))
            Controls.Add(panel)

            AddRow("Host:", txtHost)
            AddRow("Port:", txtPort)
            AddRow("User:", txtUser)
            AddRow("Password:", txtPassword)
            AddRow("Database:", txtDbName)

            btnSave.Text = "Save"
            btnSave.BackColor = ColorTranslator.FromHtml("#107C10")
            btnSave.ForeColor = Color.White
            btnSave.FlatStyle = FlatStyle.Flat
            AddHandler btnSave.Click, AddressOf OnSave

            Dim buttonPanel As New FlowLayoutPanel() With {.Dock = DockStyle.Bottom, .FlowDirection = FlowDirection.RightToLeft, .Padding = New Padding(16), .Height = 60}
            buttonPanel.Controls.Add(btnSave)
            Controls.Add(buttonPanel)

            LoadCurrentSettings()
        End Sub

        Private Sub AddRow(labelText As String, control As Control)
            Dim row As Integer = panel.RowCount - 1
            panel.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            panel.Controls.Add(New Label() With {.Text = labelText, .AutoSize = True, .Margin = New Padding(0, 8, 8, 8), .ForeColor = ColorTranslator.FromHtml("#333333")}, 0, row)
            panel.Controls.Add(control, 1, row)
            panel.RowCount += 1
        End Sub

        Private Sub LoadCurrentSettings()
            txtHost.Text = System.Configuration.ConfigurationManager.AppSettings("DbHost")
            txtPort.Text = System.Configuration.ConfigurationManager.AppSettings("DbPort")
            txtUser.Text = System.Configuration.ConfigurationManager.AppSettings("DbUser")
            txtPassword.Text = System.Configuration.ConfigurationManager.AppSettings("DbPassword")
            txtDbName.Text = System.Configuration.ConfigurationManager.AppSettings("DbName")
        End Sub

        Private Sub OnSave(sender As Object, e As EventArgs)
            Try
                ConfigManager.UpdateAppSetting("DbHost", txtHost.Text.Trim())
                ConfigManager.UpdateAppSetting("DbPort", txtPort.Text.Trim())
                ConfigManager.UpdateAppSetting("DbUser", txtUser.Text.Trim())
                ConfigManager.UpdateAppSetting("DbPassword", txtPassword.Text.Trim())
                ConfigManager.UpdateAppSetting("DbName", txtDbName.Text.Trim())
                MessageBox.Show("Settings saved. Restart application to apply.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            Catch ex As Exception
                Logger.Error("Failed to save settings", ex)
                MessageBox.Show("Failed to save settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
