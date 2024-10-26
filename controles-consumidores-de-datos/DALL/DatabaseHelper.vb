Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Private connectionString As String = "Server=localhost;Database=customerdb;User ID=root;Password=;"

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


    Public Function ExecuteQuery(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            For Each param As KeyValuePair(Of String, Object) In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next
            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

End Class


