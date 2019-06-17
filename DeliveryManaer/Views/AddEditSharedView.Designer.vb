<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditSharedView
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
        Me.SimpleButtonSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlItemsDisplay = New DevExpress.XtraGrid.GridControl()
        Me.GridViewItemsDisplay = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControlItemsDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewItemsDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButtonSave
        '
        Me.SimpleButtonSave.Location = New System.Drawing.Point(14, 12)
        Me.SimpleButtonSave.Name = "SimpleButtonSave"
        Me.SimpleButtonSave.Size = New System.Drawing.Size(87, 27)
        Me.SimpleButtonSave.TabIndex = 1
        Me.SimpleButtonSave.Text = "&Save"
        '
        'GridControlItemsDisplay
        '
        Me.GridControlItemsDisplay.Location = New System.Drawing.Point(0, 47)
        Me.GridControlItemsDisplay.MainView = Me.GridViewItemsDisplay
        Me.GridControlItemsDisplay.Name = "GridControlItemsDisplay"
        Me.GridControlItemsDisplay.Size = New System.Drawing.Size(755, 263)
        Me.GridControlItemsDisplay.TabIndex = 2
        Me.GridControlItemsDisplay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewItemsDisplay})
        '
        'GridViewItemsDisplay
        '
        Me.GridViewItemsDisplay.DetailHeight = 404
        Me.GridViewItemsDisplay.GridControl = Me.GridControlItemsDisplay
        Me.GridViewItemsDisplay.Name = "GridViewItemsDisplay"
        '
        'AddEditSharedView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 309)
        Me.Controls.Add(Me.GridControlItemsDisplay)
        Me.Controls.Add(Me.SimpleButtonSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddEditSharedView"
        Me.Text = "AddEditShared"
        CType(Me.GridControlItemsDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewItemsDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButtonSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControlItemsDisplay As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewItemsDisplay As DevExpress.XtraGrid.Views.Grid.GridView
End Class
