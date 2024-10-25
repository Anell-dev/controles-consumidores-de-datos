Imports DALL

Public Class DataService
    Private dbHelper As New DatabaseHelper()

    Public Function GetAllCustomers() As DataTable
        Dim query As String = "SELECT * FROM customers"
        Return dbHelper.GetData(query)
    End Function
End Class
