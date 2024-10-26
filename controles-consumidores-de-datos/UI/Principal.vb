Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BLL

Public Class Principal
    Private dataService As New DataService()

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim data As DataTable = dataService.GetAllCustomers()





























        ' Enlace Simple (TextBox, ComboBox, ListBox)
        cbFields.DataSource = data
        cbFields.DisplayMember = "CustomerName"
        cbFields.ValueMember = "CustomerID"

        lbFields.DataSource = data
        lbFields.DisplayMember = "CustomerName"
        lbFields.ValueMember = "CustomerID"


        datagw.DataSource = data
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


End Class
