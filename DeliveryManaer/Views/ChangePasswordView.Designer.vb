<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordView
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(98, 40)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(218, 22)
        Me.TextEdit2.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(98, 96)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(218, 22)
        Me.TextEdit1.TabIndex = 2
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(98, 68)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(218, 22)
        Me.TextEdit3.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 15)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Old Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 15)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "New Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 15)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "New Password"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(241, 124)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Save"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Username"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(98, 12)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(218, 22)
        Me.TextEdit4.TabIndex = 8
        '
        'ChangePasswordView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 158)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangePasswordView"
        Me.Text = "Change Password"
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
End Class
