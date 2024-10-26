<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtFields = New TextBox()
        cbFields = New ComboBox()
        lbFields = New ListBox()
        datagw = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        txtDetails = New TextBox()
        txtName = New TextBox()
        CType(datagw, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFields
        ' 
        txtFields.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        txtFields.ForeColor = SystemColors.Window
        txtFields.Location = New Point(26, 31)
        txtFields.Name = "txtFields"
        txtFields.Size = New Size(160, 23)
        txtFields.TabIndex = 0
        ' 
        ' cbFields
        ' 
        cbFields.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        cbFields.ForeColor = SystemColors.Window
        cbFields.FormattingEnabled = True
        cbFields.Location = New Point(26, 77)
        cbFields.Name = "cbFields"
        cbFields.Size = New Size(160, 23)
        cbFields.TabIndex = 1
        ' 
        ' lbFields
        ' 
        lbFields.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        lbFields.ForeColor = SystemColors.Window
        lbFields.FormattingEnabled = True
        lbFields.ItemHeight = 15
        lbFields.Location = New Point(26, 131)
        lbFields.Name = "lbFields"
        lbFields.Size = New Size(236, 154)
        lbFields.TabIndex = 2
        ' 
        ' datagw
        ' 
        datagw.BackgroundColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        datagw.GridColor = SystemColors.Window
        datagw.Location = New Point(305, 31)
        datagw.Name = "datagw"
        datagw.Size = New Size(607, 212)
        datagw.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(320, 299)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Insertar"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = SystemColors.ControlLightLight
        btnUpdate.Location = New Point(414, 299)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Actualizar"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.ControlLight
        btnDelete.Location = New Point(512, 299)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' txtDetails
        ' 
        txtDetails.Location = New Point(657, 300)
        txtDetails.Name = "txtDetails"
        txtDetails.Size = New Size(145, 23)
        txtDetails.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(657, 262)
        txtName.Name = "txtName"
        txtName.Size = New Size(145, 23)
        txtName.TabIndex = 8
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(40))
        ClientSize = New Size(951, 359)
        Controls.Add(txtName)
        Controls.Add(txtDetails)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(datagw)
        Controls.Add(lbFields)
        Controls.Add(cbFields)
        Controls.Add(txtFields)
        Name = "Principal"
        Text = "Enlaces"
        CType(datagw, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFields As TextBox
    Friend WithEvents cbFields As ComboBox
    Friend WithEvents lbFields As ListBox
    Friend WithEvents datagw As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtName As TextBox

End Class
