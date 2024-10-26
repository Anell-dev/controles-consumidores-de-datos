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
        btnInsertar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
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
        datagw.Size = New Size(404, 212)
        datagw.TabIndex = 3
        ' 
        ' btnInsertar
        ' 
        btnInsertar.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnInsertar.FlatStyle = FlatStyle.Flat
        btnInsertar.ForeColor = SystemColors.ControlLightLight
        btnInsertar.Location = New Point(320, 299)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(75, 23)
        btnInsertar.TabIndex = 4
        btnInsertar.Text = "Insertar"
        btnInsertar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.ForeColor = SystemColors.ControlLightLight
        btnActualizar.Location = New Point(414, 299)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 5
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(43), CByte(45), CByte(61))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.ForeColor = SystemColors.ControlLight
        btnEliminar.Location = New Point(512, 299)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 6
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(40))
        ClientSize = New Size(734, 359)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnInsertar)
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
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button

End Class
