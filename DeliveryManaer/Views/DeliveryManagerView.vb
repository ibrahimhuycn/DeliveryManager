Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins


Partial Public Class DeliveryManagerView
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
        SkinManager.EnableMdiFormSkins()
    End Sub

    Private Sub BarButtonDeliveryLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDeliveryLog.ItemClick
        Dim DeliveryLog As New DeliveryLogsViews With {.MdiParent = Me}
        DeliveryLog.Show()
    End Sub

    Private Sub BarButtonItemNewDeliveryRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNewDeliveryRequest.ItemClick
        Dim DeliveryRequest As New DeliveryLogDetailViewEditNew With {.MdiParent = Me}
        'Todo: Configure this to load as new if entering a new request. / else load a record on double clicking a delivery log item
        DeliveryRequest.Show()

    End Sub

    Private Sub BarButtonItemDeliveryStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDeliveryStatus.ItemClick

    End Sub

    Private Sub BarButtonItemGodown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemGodown.ItemClick

    End Sub

    Private Sub BarButtonItemCustomer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemCustomer.ItemClick
        Dim Customer As New AddEditSharedView With {.MdiParent = Me}
        Customer.GridControlItemsDisplay.DataSource = CustomerViewModel.GetCustomerList(New CustomerViewModel)
        Customer.Show()
    End Sub

    Private Sub BarButtonItemChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemChangePassword.ItemClick
        Dim ChangePassword As New ChangePasswordView With {.MdiParent = Me}
        ChangePassword.Show()
    End Sub

    Private Sub BarButtonItemLogout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLogout.ItemClick
        'Close all opened forms in Main Form except login form if open
        'Dasable all controls on Main form
        'open login form

        Dim Login As New AuthenticationView With {.MdiParent = Me}
        Login.Show()
    End Sub


End Class
