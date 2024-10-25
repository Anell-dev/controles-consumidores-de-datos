Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Private connectionString As String = "Server=localhost;Database=customerdb;User ID=root;Password=admin;"

    Public Function GetData(query As String) As DataTable
        Dim dataTable As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            connection.Open()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using
        Return dataTable
    End Function
End Class
