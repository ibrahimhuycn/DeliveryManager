<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryLogsViews
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControlDeliveryLogs = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDeliveryLogs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCustomerPoNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnGodown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDeliveredBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReceivedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReceivedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.GridControlDeliveryLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDeliveryLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlDeliveryLogs
        '
        Me.GridControlDeliveryLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlDeliveryLogs.Location = New System.Drawing.Point(0, 0)
        Me.GridControlDeliveryLogs.MainView = Me.GridViewDeliveryLogs
        Me.GridControlDeliveryLogs.Name = "GridControlDeliveryLogs"
        Me.GridControlDeliveryLogs.Size = New System.Drawing.Size(1010, 469)
        Me.GridControlDeliveryLogs.TabIndex = 0
        Me.GridControlDeliveryLogs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDeliveryLogs})
        '
        'GridViewDeliveryLogs
        '
        Me.GridViewDeliveryLogs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNo, Me.GridColumnCustomer, Me.GridColumnCustomerPoNumber, Me.GridColumnGodown, Me.GridColumnDeliveredBy, Me.GridColumnDeliveryDate, Me.GridColumnReceivedBy, Me.GridColumnReceivedDate, Me.GridColumnComment})
        Me.GridViewDeliveryLogs.GridControl = Me.GridControlDeliveryLogs
        Me.GridViewDeliveryLogs.Name = "GridViewDeliveryLogs"
        '
        'GridColumnNo
        '
        Me.GridColumnNo.Caption = "Delivery Number"
        Me.GridColumnNo.FieldName = "DeliveryNo"
        Me.GridColumnNo.Name = "GridColumnNo"
        Me.GridColumnNo.Visible = True
        Me.GridColumnNo.VisibleIndex = 0
        '
        'GridColumnCustomer
        '
        Me.GridColumnCustomer.Caption = "Customer"
        Me.GridColumnCustomer.FieldName = "Customer"
        Me.GridColumnCustomer.Name = "GridColumnCustomer"
        Me.GridColumnCustomer.Visible = True
        Me.GridColumnCustomer.VisibleIndex = 1
        '
        'GridColumnCustomerPoNumber
        '
        Me.GridColumnCustomerPoNumber.Caption = "Cust. PO Number"
        Me.GridColumnCustomerPoNumber.FieldName = "CustomerPoNumber"
        Me.GridColumnCustomerPoNumber.Name = "GridColumnCustomerPoNumber"
        Me.GridColumnCustomerPoNumber.Visible = True
        Me.GridColumnCustomerPoNumber.VisibleIndex = 2
        '
        'GridColumnGodown
        '
        Me.GridColumnGodown.Caption = "Godown"
        Me.GridColumnGodown.FieldName = "Godown"
        Me.GridColumnGodown.Name = "GridColumnGodown"
        Me.GridColumnGodown.Visible = True
        Me.GridColumnGodown.VisibleIndex = 3
        '
        'GridColumnDeliveredBy
        '
        Me.GridColumnDeliveredBy.Caption = "Delivered By"
        Me.GridColumnDeliveredBy.FieldName = "DeliveredBy"
        Me.GridColumnDeliveredBy.Name = "GridColumnDeliveredBy"
        Me.GridColumnDeliveredBy.Visible = True
        Me.GridColumnDeliveredBy.VisibleIndex = 4
        '
        'GridColumnDeliveryDate
        '
        Me.GridColumnDeliveryDate.Caption = "Delivery Date"
        Me.GridColumnDeliveryDate.FieldName = "DeliveryDate"
        Me.GridColumnDeliveryDate.Name = "GridColumnDeliveryDate"
        Me.GridColumnDeliveryDate.Visible = True
        Me.GridColumnDeliveryDate.VisibleIndex = 5
        '
        'GridColumnReceivedBy
        '
        Me.GridColumnReceivedBy.Caption = "Received By"
        Me.GridColumnReceivedBy.FieldName = "ReceivedBy"
        Me.GridColumnReceivedBy.Name = "GridColumnReceivedBy"
        Me.GridColumnReceivedBy.Visible = True
        Me.GridColumnReceivedBy.VisibleIndex = 6
        '
        'GridColumnReceivedDate
        '
        Me.GridColumnReceivedDate.Caption = "Received Date"
        Me.GridColumnReceivedDate.FieldName = "ReceivedDate"
        Me.GridColumnReceivedDate.Name = "GridColumnReceivedDate"
        Me.GridColumnReceivedDate.Visible = True
        Me.GridColumnReceivedDate.VisibleIndex = 7
        '
        'GridColumnComment
        '
        Me.GridColumnComment.Caption = "Comment"
        Me.GridColumnComment.FieldName = "Comment"
        Me.GridColumnComment.Name = "GridColumnComment"
        Me.GridColumnComment.Visible = True
        Me.GridColumnComment.VisibleIndex = 8
        '
        'DeliveryLogsViews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 469)
        Me.Controls.Add(Me.GridControlDeliveryLogs)
        Me.Name = "DeliveryLogsViews"
        Me.Text = "Delivery Logs"
        CType(Me.GridControlDeliveryLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDeliveryLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControlDeliveryLogs As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDeliveryLogs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCustomerPoNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnGodown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDeliveredBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReceivedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReceivedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
