<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AuthenticationView
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SimpleButtonLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEditUsername = New DevExpress.XtraEditors.TextEdit()
        Me.TextEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControlWelcomeText = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEditRememberUser = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.TextEditUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditRememberUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButtonLogin
        '
        Me.SimpleButtonLogin.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButtonLogin.Appearance.Options.UseFont = True
        Me.SimpleButtonLogin.Location = New System.Drawing.Point(154, 99)
        Me.SimpleButtonLogin.Name = "SimpleButtonLogin"
        Me.SimpleButtonLogin.Size = New System.Drawing.Size(87, 27)
        Me.SimpleButtonLogin.TabIndex = 0
        Me.SimpleButtonLogin.Text = "&Login"
        '
        'TextEditUsername
        '
        Me.TextEditUsername.Location = New System.Drawing.Point(12, 35)
        Me.TextEditUsername.Name = "TextEditUsername"
        Me.TextEditUsername.Properties.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditUsername.Properties.Appearance.Options.UseFont = True
        Me.TextEditUsername.Properties.NullText = "Username"
        Me.TextEditUsername.Size = New System.Drawing.Size(229, 22)
        Me.TextEditUsername.TabIndex = 1
        '
        'TextEditPassword
        '
        Me.TextEditPassword.Location = New System.Drawing.Point(12, 65)
        Me.TextEditPassword.Name = "TextEditPassword"
        Me.TextEditPassword.Properties.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditPassword.Properties.Appearance.Options.UseFont = True
        Me.TextEditPassword.Properties.NullText = "Password"
        Me.TextEditPassword.Properties.UseSystemPasswordChar = True
        Me.TextEditPassword.Size = New System.Drawing.Size(229, 22)
        Me.TextEditPassword.TabIndex = 2
        '
        'LabelControlWelcomeText
        '
        Me.LabelControlWelcomeText.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlWelcomeText.Appearance.Options.UseFont = True
        Me.LabelControlWelcomeText.Location = New System.Drawing.Point(80, 8)
        Me.LabelControlWelcomeText.Name = "LabelControlWelcomeText"
        Me.LabelControlWelcomeText.Size = New System.Drawing.Size(77, 21)
        Me.LabelControlWelcomeText.TabIndex = 4
        Me.LabelControlWelcomeText.Text = "WELCOME"
        '
        'CheckEditRememberUser
        '
        Me.CheckEditRememberUser.Location = New System.Drawing.Point(12, 103)
        Me.CheckEditRememberUser.Name = "CheckEditRememberUser"
        Me.CheckEditRememberUser.Properties.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditRememberUser.Properties.Appearance.Options.UseFont = True
        Me.CheckEditRememberUser.Properties.Caption = "Remember me"
        Me.CheckEditRememberUser.Size = New System.Drawing.Size(129, 19)
        Me.CheckEditRememberUser.TabIndex = 5
        '
        'AuthenticationView
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 135)
        Me.Controls.Add(Me.CheckEditRememberUser)
        Me.Controls.Add(Me.LabelControlWelcomeText)
        Me.Controls.Add(Me.TextEditPassword)
        Me.Controls.Add(Me.TextEditUsername)
        Me.Controls.Add(Me.SimpleButtonLogin)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AuthenticationView"
        Me.Text = "Authentication"
        CType(Me.TextEditUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditRememberUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButtonLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEditUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControlWelcomeText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEditRememberUser As DevExpress.XtraEditors.CheckEdit
End Class
