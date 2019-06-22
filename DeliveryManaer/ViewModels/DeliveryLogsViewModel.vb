Public Class DeliveryLogsViewModel
    Public Sub New()
        Me.Logs = New List(Of DeliveryLogsModel)
        Logs.Add(New DeliveryLogsModel With {.DeliveryNo = "D29384",
                 .CustomerPoNumber = "PO26357627",
                 .Godown = "Godown 1",
                 .Customer = "Indira Gandhi Memorial Hospital",
                 .DeliveredBy = "Ibraim Hussain",
                 .DeliveryDate = Date.Today,
                 .ReceivedBy = "Ahmed Hisaan Saeed",
                 .ReceivedDate = Date.Today,
                 .Comment = "Delivery Completed."})
    End Sub
    Public Property Logs As List(Of DeliveryLogsModel)

    Public Shared Function GetLogs(e As DeliveryLogsViewModel) As List(Of DeliveryLogsModel)
        Return e.Logs
    End Function
End Class
