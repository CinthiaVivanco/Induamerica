<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscaUsuario
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
        Me.dgvusuario = New System.Windows.Forms.DataGridView
        Me.btnbusca = New System.Windows.Forms.Button
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvusuario
        '
        Me.dgvusuario.AllowUserToAddRows = False
        Me.dgvusuario.AllowUserToDeleteRows = False
        Me.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdUsuario, Me.cdPersona})
        Me.dgvusuario.Location = New System.Drawing.Point(7, 32)
        Me.dgvusuario.Name = "dgvusuario"
        Me.dgvusuario.ReadOnly = True
        Me.dgvusuario.Size = New System.Drawing.Size(416, 187)
        Me.dgvusuario.TabIndex = 11
        '
        'btnbusca
        '
        Me.btnbusca.Location = New System.Drawing.Point(348, 3)
        Me.btnbusca.Name = "btnbusca"
        Me.btnbusca.Size = New System.Drawing.Size(75, 23)
        Me.btnbusca.TabIndex = 10
        Me.btnbusca.Text = "Buscar"
        Me.btnbusca.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(57, 5)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(285, 20)
        Me.txtnombre.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre:"
        '
        'cdUsuario
        '
        Me.cdUsuario.DataPropertyName = "Nombre"
        Me.cdUsuario.HeaderText = "Usuario"
        Me.cdUsuario.Name = "cdUsuario"
        Me.cdUsuario.ReadOnly = True
        Me.cdUsuario.Width = 120
        '
        'cdPersona
        '
        Me.cdPersona.DataPropertyName = "nombrepersona"
        Me.cdPersona.HeaderText = "Persona"
        Me.cdPersona.Name = "cdPersona"
        Me.cdPersona.ReadOnly = True
        Me.cdPersona.Width = 250
        '
        'buscaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvusuario)
        Me.Controls.Add(Me.btnbusca)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "buscaUsuario"
        Me.Size = New System.Drawing.Size(429, 226)
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvusuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnbusca As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
