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
        CType(datagw, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFields
        ' 
        txtFields.Location = New Point(64, 113)
        txtFields.Name = "txtFields"
        txtFields.Size = New Size(160, 23)
        txtFields.TabIndex = 0
        ' 
        ' cbFields
        ' 
        cbFields.FormattingEnabled = True
        cbFields.Location = New Point(64, 170)
        cbFields.Name = "cbFields"
        cbFields.Size = New Size(160, 23)
        cbFields.TabIndex = 1
        ' 
        ' lbFields
        ' 
        lbFields.FormattingEnabled = True
        lbFields.ItemHeight = 15
        lbFields.Location = New Point(309, 332)
        lbFields.Name = "lbFields"
        lbFields.Size = New Size(447, 94)
        lbFields.TabIndex = 2
        ' 
        ' datagw
        ' 
        datagw.Location = New Point(309, 22)
        datagw.Name = "datagw"
        datagw.Size = New Size(461, 285)
        datagw.TabIndex = 3
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

End Class
