Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BLL

Public Class Principal
    Private dataService As New DataService()

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    ' Mostrar detalles en TextBox al seleccionar un elemento en ComboBox
    Private Sub cbFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFields.SelectedIndexChanged
        Dim selectedRow As DataRowView = DirectCast(cbFields.SelectedItem, DataRowView)
        txtFields.Text = selectedRow("CustomerDetails").ToString()
    End Sub

    ' Mostrar detalles en TextBox al seleccionar un elemento en ListBox
    Private Sub lbFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFields.SelectedIndexChanged
        Dim selectedRow As DataRowView = DirectCast(lbFields.SelectedItem, DataRowView)
        txtFields.Text = selectedRow("CustomerDetails").ToString()
    End Sub

    ' Mostrar detalles en TextBox al seleccionar una fila en DataGridView
    Private Sub datagw_SelectionChanged(sender As Object, e As EventArgs) Handles datagw.SelectionChanged
        If datagw.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataRowView = DirectCast(datagw.CurrentRow.DataBoundItem, DataRowView)
            txtFields.Text = selectedRow("CustomerDetails").ToString()
        End If
    End Sub

    ' Botón Agregar Cliente
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim success As Boolean = dataService.AddCustomer(txtName.Text, txtDetails.Text)
        If success Then
            MessageBox.Show("Cliente agregado correctamente.")
            LoadCustomers() ' Recargar la lista después de agregar
        Else
            MessageBox.Show("Error al agregar el cliente.")
        End If
    End Sub

    ' Botón Actualizar Cliente
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedCustomerId As Integer = Convert.ToInt32(cbFields.SelectedValue)
        Dim success As Boolean = dataService.UpdateCustomer(selectedCustomerId, txtName.Text, txtDetails.Text)
        If success Then
            MessageBox.Show("Cliente actualizado correctamente.")
            LoadCustomers()
        Else
            MessageBox.Show("Error al actualizar el cliente.")
        End If
    End Sub

    ' Botón Eliminar Cliente
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedCustomerId As Integer = Convert.ToInt32(cbFields.SelectedValue)
        Dim success As Boolean = dataService.DeleteCustomer(selectedCustomerId)
        If success Then
            MessageBox.Show("Cliente eliminado correctamente.")
            LoadCustomers()
        Else
            MessageBox.Show("Error al eliminar el cliente.")
        End If
    End Sub

    ' Método para recargar la lista de clientes
    Private Sub LoadCustomers()
        Dim data As DataTable = dataService.GetAllCustomers()
        cbFields.DataSource = data
        cbFields.DisplayMember = "CustomerName"
        cbFields.ValueMember = "CustomerID"
        lbFields.DataSource = data
        lbFields.DisplayMember = "CustomerName"
        lbFields.ValueMember = "CustomerID"
        datagw.DataSource = data
    End Sub

End Class
