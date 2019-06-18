Partial Public Class DeliveryManagerView
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DeliveryManaer.DeliveryManagerSplashView), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryManagerView))
        Me.ribbonControlGodown = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonDeliveryLog = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemNewDeliveryRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDeliveryStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuDeliveryStatus = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItemDeliveryCompleted = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDeliveryPending = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDeliveryPartial = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemGodown = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuGodown = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItemGodown1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemGodown2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.Customer = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItemIGMH = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemTTH = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemLogout = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPageMain = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroupDeliveries = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroupFilters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroupUserAdministration = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.ribbonControlGodown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuDeliveryStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuGodown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager
        '
        SplashScreenManager.ClosingDelay = 500
        '
        'ribbonControlGodown
        '
        Me.ribbonControlGodown.ApplicationButtonImageOptions.SvgImage = CType(resources.GetObject("ribbonControlGodown.ApplicationButtonImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.ribbonControlGodown.ApplicationButtonImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.ribbonControlGodown.ExpandCollapseItem.Id = 0
        Me.ribbonControlGodown.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControlGodown.ExpandCollapseItem, Me.ribbonControlGodown.SearchEditItem, Me.BarButtonDeliveryLog, Me.BarButtonItemNewDeliveryRequest, Me.BarButtonItemDeliveryStatus, Me.BarButtonItemGodown, Me.BarButtonItemDeliveryCompleted, Me.BarButtonItemDeliveryPending, Me.BarButtonItemDeliveryPartial, Me.BarButtonItemGodown1, Me.BarButtonItemGodown2, Me.BarButtonItemCustomer, Me.BarButtonItemIGMH, Me.BarButtonItemTTH, Me.BarButtonItemLogout, Me.BarButtonItemChangePassword})
        Me.ribbonControlGodown.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControlGodown.MaxItemId = 1
        Me.ribbonControlGodown.Name = "ribbonControlGodown"
        Me.ribbonControlGodown.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPageMain})
        Me.ribbonControlGodown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.ribbonControlGodown.Size = New System.Drawing.Size(1087, 151)
        '
        'BarButtonDeliveryLog
        '
        Me.BarButtonDeliveryLog.Caption = "Delivery Log"
        Me.BarButtonDeliveryLog.Id = 1
        Me.BarButtonDeliveryLog.ImageOptions.Image = CType(resources.GetObject("BarButtonDeliveryLog.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonDeliveryLog.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonDeliveryLog.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonDeliveryLog.Name = "BarButtonDeliveryLog"
        Me.BarButtonDeliveryLog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemNewDeliveryRequest
        '
        Me.BarButtonItemNewDeliveryRequest.Caption = "New Delivery Request"
        Me.BarButtonItemNewDeliveryRequest.Id = 2
        Me.BarButtonItemNewDeliveryRequest.ImageOptions.Image = CType(resources.GetObject("BarButtonItemNewDeliveryRequest.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemNewDeliveryRequest.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemNewDeliveryRequest.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemNewDeliveryRequest.Name = "BarButtonItemNewDeliveryRequest"
        Me.BarButtonItemNewDeliveryRequest.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemDeliveryStatus
        '
        Me.BarButtonItemDeliveryStatus.ActAsDropDown = True
        Me.BarButtonItemDeliveryStatus.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItemDeliveryStatus.Caption = "Delivery Status"
        Me.BarButtonItemDeliveryStatus.DropDownControl = Me.PopupMenuDeliveryStatus
        Me.BarButtonItemDeliveryStatus.Id = 3
        Me.BarButtonItemDeliveryStatus.ImageOptions.Image = CType(resources.GetObject("BarButtonItemDeliveryStatus.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemDeliveryStatus.Name = "BarButtonItemDeliveryStatus"
        Me.BarButtonItemDeliveryStatus.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'PopupMenuDeliveryStatus
        '
        Me.PopupMenuDeliveryStatus.ItemLinks.Add(Me.BarButtonItemDeliveryCompleted)
        Me.PopupMenuDeliveryStatus.ItemLinks.Add(Me.BarButtonItemDeliveryPending)
        Me.PopupMenuDeliveryStatus.ItemLinks.Add(Me.BarButtonItemDeliveryPartial)
        Me.PopupMenuDeliveryStatus.Name = "PopupMenuDeliveryStatus"
        Me.PopupMenuDeliveryStatus.Ribbon = Me.ribbonControlGodown
        '
        'BarButtonItemDeliveryCompleted
        '
        Me.BarButtonItemDeliveryCompleted.Caption = "Completed"
        Me.BarButtonItemDeliveryCompleted.Id = 1
        Me.BarButtonItemDeliveryCompleted.Name = "BarButtonItemDeliveryCompleted"
        '
        'BarButtonItemDeliveryPending
        '
        Me.BarButtonItemDeliveryPending.Caption = "Pending"
        Me.BarButtonItemDeliveryPending.Id = 2
        Me.BarButtonItemDeliveryPending.Name = "BarButtonItemDeliveryPending"
        '
        'BarButtonItemDeliveryPartial
        '
        Me.BarButtonItemDeliveryPartial.Caption = "Partial"
        Me.BarButtonItemDeliveryPartial.Id = 3
        Me.BarButtonItemDeliveryPartial.Name = "BarButtonItemDeliveryPartial"
        '
        'BarButtonItemGodown
        '
        Me.BarButtonItemGodown.ActAsDropDown = True
        Me.BarButtonItemGodown.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItemGodown.Caption = "Godown"
        Me.BarButtonItemGodown.DropDownControl = Me.PopupMenuGodown
        Me.BarButtonItemGodown.Id = 4
        Me.BarButtonItemGodown.ImageOptions.Image = CType(resources.GetObject("BarButtonItemGodown.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemGodown.Name = "BarButtonItemGodown"
        Me.BarButtonItemGodown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'PopupMenuGodown
        '
        Me.PopupMenuGodown.ItemLinks.Add(Me.BarButtonItemGodown1)
        Me.PopupMenuGodown.ItemLinks.Add(Me.BarButtonItemGodown2)
        Me.PopupMenuGodown.Name = "PopupMenuGodown"
        Me.PopupMenuGodown.Ribbon = Me.ribbonControlGodown
        '
        'BarButtonItemGodown1
        '
        Me.BarButtonItemGodown1.Caption = "Godown 1"
        Me.BarButtonItemGodown1.Id = 4
        Me.BarButtonItemGodown1.Name = "BarButtonItemGodown1"
        '
        'BarButtonItemGodown2
        '
        Me.BarButtonItemGodown2.Caption = "Godown 2"
        Me.BarButtonItemGodown2.Id = 5
        Me.BarButtonItemGodown2.Name = "BarButtonItemGodown2"
        '
        'BarButtonItemCustomer
        '
        Me.BarButtonItemCustomer.ActAsDropDown = True
        Me.BarButtonItemCustomer.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItemCustomer.Caption = "Customer"
        Me.BarButtonItemCustomer.DropDownControl = Me.Customer
        Me.BarButtonItemCustomer.Id = 6
        Me.BarButtonItemCustomer.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItemCustomer.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItemCustomer.Name = "BarButtonItemCustomer"
        Me.BarButtonItemCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'Customer
        '
        Me.Customer.ItemLinks.Add(Me.BarButtonItemIGMH)
        Me.Customer.ItemLinks.Add(Me.BarButtonItemTTH)
        Me.Customer.Name = "Customer"
        Me.Customer.Ribbon = Me.ribbonControlGodown
        '
        'BarButtonItemIGMH
        '
        Me.BarButtonItemIGMH.Caption = "IGMH"
        Me.BarButtonItemIGMH.Id = 7
        Me.BarButtonItemIGMH.Name = "BarButtonItemIGMH"
        '
        'BarButtonItemTTH
        '
        Me.BarButtonItemTTH.Caption = "TTH"
        Me.BarButtonItemTTH.Id = 8
        Me.BarButtonItemTTH.Name = "BarButtonItemTTH"
        '
        'BarButtonItemLogout
        '
        Me.BarButtonItemLogout.Caption = "Logout"
        Me.BarButtonItemLogout.Id = 9
        Me.BarButtonItemLogout.ImageOptions.Image = CType(resources.GetObject("BarButtonItemLogout.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemLogout.Name = "BarButtonItemLogout"
        Me.BarButtonItemLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemChangePassword
        '
        Me.BarButtonItemChangePassword.Caption = "Change Password"
        Me.BarButtonItemChangePassword.Id = 10
        Me.BarButtonItemChangePassword.ImageOptions.Image = CType(resources.GetObject("BarButtonItemChangePassword.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemChangePassword.Name = "BarButtonItemChangePassword"
        Me.BarButtonItemChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonPageMain
        '
        Me.ribbonPageMain.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroupDeliveries, Me.RibbonPageGroupFilters, Me.RibbonPageGroupUserAdministration})
        Me.ribbonPageMain.Name = "ribbonPageMain"
        Me.ribbonPageMain.Text = "Main"
        '
        'ribbonPageGroupDeliveries
        '
        Me.ribbonPageGroupDeliveries.ItemLinks.Add(Me.BarButtonDeliveryLog)
        Me.ribbonPageGroupDeliveries.ItemLinks.Add(Me.BarButtonItemNewDeliveryRequest)
        Me.ribbonPageGroupDeliveries.Name = "ribbonPageGroupDeliveries"
        Me.ribbonPageGroupDeliveries.Text = "Deliveries"
        '
        'RibbonPageGroupFilters
        '
        Me.RibbonPageGroupFilters.ItemLinks.Add(Me.BarButtonItemDeliveryStatus)
        Me.RibbonPageGroupFilters.ItemLinks.Add(Me.BarButtonItemGodown)
        Me.RibbonPageGroupFilters.ItemLinks.Add(Me.BarButtonItemCustomer)
        Me.RibbonPageGroupFilters.Name = "RibbonPageGroupFilters"
        Me.RibbonPageGroupFilters.Text = "Filters"
        '
        'RibbonPageGroupUserAdministration
        '
        Me.RibbonPageGroupUserAdministration.ItemLinks.Add(Me.BarButtonItemChangePassword)
        Me.RibbonPageGroupUserAdministration.ItemLinks.Add(Me.BarButtonItemLogout)
        Me.RibbonPageGroupUserAdministration.Name = "RibbonPageGroupUserAdministration"
        Me.RibbonPageGroupUserAdministration.Text = "User Administration"
        '
        'DeliveryManagerView
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 502)
        Me.Controls.Add(Me.ribbonControlGodown)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "DeliveryManagerView"
        Me.Ribbon = Me.ribbonControlGodown
        Me.Text = "Delivery Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControlGodown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuDeliveryStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuGodown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControlGodown As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPageMain As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroupDeliveries As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonDeliveryLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemNewDeliveryRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDeliveryStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuDeliveryStatus As DevExpress.XtraBars.PopupMenu
    Friend WithEvents RibbonPageGroupFilters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemGodown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuGodown As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItemDeliveryCompleted As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDeliveryPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDeliveryPartial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemGodown1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemGodown2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuCustomer As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Customer As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItemIGMH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemTTH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemLogout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroupUserAdministration As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
