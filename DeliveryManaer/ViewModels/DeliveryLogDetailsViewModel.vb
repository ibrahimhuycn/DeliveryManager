Public Class DeliveryLogDetailsViewModel
    Inherits DeliveryLogsModel

    'PENDING: Add properties specific to this class...

    Public Sub New(e As DeliveryLogDetailsViewModel)

    End Sub


    'THE FOLLOWING TWO PROPERTIES COULD BE DECLARED IN MODELS
    'AND THEN DECLARED IN THIS CLASS AS A LIST.
    Public Property AttachmentsList As List(Of String)
    Public Property EventsTrace As List(Of String)
End Class
