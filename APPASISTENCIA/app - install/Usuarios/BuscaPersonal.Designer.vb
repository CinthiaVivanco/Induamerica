<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaPersonal
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvgrupo = New System.Windows.Forms.DataGridView()
        Me.btnbusca = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvgrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvgrupo
        '
        Me.dgvgrupo.AllowUserToAddRows = False
        Me.dgvgrupo.AllowUserToDeleteRows = False
        Me.dgvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPersona})
        Me.dgvgrupo.Location = New System.Drawing.Point(13, 40)
        Me.dgvgrupo.Name = "dgvgrupo"
        Me.dgvgrupo.ReadOnly = True
        Me.dgvgrupo.Size = New System.Drawing.Size(307, 187)
        Me.dgvgrupo.TabIndex = 7
        '
        'btnbusca
        '
        Me.btnbusca.Location = New System.Drawing.Point(245, 11)
        Me.btnbusca.Name = "btnbusca"
        Me.btnbusca.Size = New System.Drawing.Size(75, 23)
        Me.btnbusca.TabIndex = 6
        Me.btnbusca.Text = "Buscar"
        Me.btnbusca.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(53, 13)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(186, 20)
        Me.txtnombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'cdPersona
        '
        Me.cdPersona.DataPropertyName = "NombreCompleto"
        Me.cdPersona.HeaderText = "Personal"
        Me.cdPersona.Name = "cdPersona"
        Me.cdPersona.ReadOnly = True
        Me.cdPersona.Width = 263
        '
        'BuscaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvgrupo)
        Me.Controls.Add(Me.btnbusca)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscaPersonal"
        Me.Size = New System.Drawing.Size(332, 238)
        CType(Me.dgvgrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvgrupo As System.Windows.Forms.DataGridView
    Friend WithEvents btnbusca As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
