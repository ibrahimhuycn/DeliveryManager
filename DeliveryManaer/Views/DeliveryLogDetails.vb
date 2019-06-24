Imports DevExpress.XtraEditors

Public Class DeliveryLogDetailViewEditNew
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ToggleSwitch1_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch1.Toggled
        Dim selector As ToggleSwitch = TryCast(sender, ToggleSwitch)

        If selector.IsOn = True Then
            'raise an event to filter grid view
        Else
            'raise an event to filter the grid view
        End If
    End Sub
End Class