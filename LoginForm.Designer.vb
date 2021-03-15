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
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.OpenRegisterFormLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(244, 52)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(361, 38)
        Me.UsernameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(244, 224)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(147, 54)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log-in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'OpenRegisterFormLinkLabel
        '
        Me.OpenRegisterFormLinkLabel.AutoSize = True
        Me.OpenRegisterFormLinkLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenRegisterFormLinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.OpenRegisterFormLinkLabel.Location = New System.Drawing.Point(86, 311)
        Me.OpenRegisterFormLinkLabel.Name = "OpenRegisterFormLinkLabel"
        Me.OpenRegisterFormLinkLabel.Size = New System.Drawing.Size(514, 32)
        Me.OpenRegisterFormLinkLabel.TabIndex = 3
        Me.OpenRegisterFormLinkLabel.TabStop = True
        Me.OpenRegisterFormLinkLabel.Text = "Don't have an account yet? Create an account "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(244, 123)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(361, 38)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(441, 167)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(164, 29)
        Me.ShowPasswordCheckBox.TabIndex = 6
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(454, 224)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(151, 54)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(720, 370)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.OpenRegisterFormLinkLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET SQL Server | Login Form by Simeon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents OpenRegisterFormLinkLabel As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents CancelButton As Button
End Class
