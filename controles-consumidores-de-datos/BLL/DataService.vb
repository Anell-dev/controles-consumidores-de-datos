Imports DALL

Public Class DataService
    Private dbHelper As New DatabaseHelper()

    'Metodos'
    Public Function GetAllCustomers() As DataTable
        Dim query As String = "SELECT * FROM customers"
        Return dbHelper.GetData(query)
    End Function


    Public Function AddCustomer(customerName As String, customerDetails As String) As Boolean
        Dim query As String = "INSERT INTO customers (CustomerName, CustomerDetails) VALUES (@CustomerName, @CustomerDetails)"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@CustomerName", customerName},
        {"@CustomerDetails", customerDetails}
    }
        Return dbHelper.ExecuteQuery(query, parameters)
    End Function


    Public Function UpdateCustomer(customerId As Integer, customerName As String, customerDetails As String) As Boolean
        Dim query As String = "UPDATE customers SET CustomerName = @CustomerName, CustomerDetails = @CustomerDetails WHERE CustomerID = @CustomerID"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@CustomerName", customerName},
        {"@CustomerDetails", customerDetails},
        {"@CustomerID", customerId}
    }
        Return dbHelper.ExecuteQuery(query, parameters)
    End Function



    Public Function DeleteCustomer(customerId As Integer) As Boolean
        Dim query As String = "DELETE FROM customers WHERE CustomerID = @CustomerID"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@CustomerID", customerId}
    }
        Return dbHelper.ExecuteQuery(query, parameters)
    End Function
End Class
