Public Class DeliveryLogDetailsViewModel
    Inherits DeliveryLogsModel
    Public Sub New()
    End Sub

    Public Property AttachmentsList As List(Of String)
    Public Property EventsTrace As List(Of String)
End Class
