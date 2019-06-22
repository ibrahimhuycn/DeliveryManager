
Public Class CustomerViewModel
    Public Sub New()
        Me.CustomerList = New List(Of CustomerModel)
        CustomerList.Add(New CustomerModel With {.Id = "C000001", .CustomerName = "Test Hospital Name"})
    End Sub
    Public Property CustomerList As List(Of CustomerModel)
    Public Shared Function GetCustomerList(customerViewModel As CustomerViewModel) As List(Of CustomerModel)
        Return customerViewModel.CustomerList
    End Function
End Class
