<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisoGrupal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.cbosistema = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbogrupo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btndeseleccionar = New System.Windows.Forms.Button
        Me.btnregistrar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.dgvpermiso = New System.Windows.Forms.DataGridView
        Me.cdPermiso = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnseleccionar = New System.Windows.Forms.Button
        CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbosistema
        '
        Me.cbosistema.FormattingEnabled = True
        Me.cbosistema.Location = New System.Drawing.Point(53, 12)
        Me.cbosistema.Name = "cbosistema"
        Me.cbosistema.Size = New System.Drawing.Size(164, 21)
        Me.cbosistema.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Sistema"
        '
        'cbogrupo
        '
        Me.cbogrupo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.Location = New System.Drawing.Point(259, 12)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(164, 21)
        Me.cbogrupo.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Grupo"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(429, 112)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
        Me.btnCerrar.TabIndex = 32
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btndeseleccionar
        '
        Me.btndeseleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btndeseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeseleccionar.Location = New System.Drawing.Point(247, 479)
        Me.btndeseleccionar.Name = "btndeseleccionar"
        Me.btndeseleccionar.Size = New System.Drawing.Size(156, 43)
        Me.btndeseleccionar.TabIndex = 31
        Me.btndeseleccionar.Text = "&Deseleccionar Todo"
        Me.btndeseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeseleccionar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrar.Location = New System.Drawing.Point(429, 63)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
        Me.btnregistrar.TabIndex = 30
        Me.btnregistrar.Text = "&Registrar"
        Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(430, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
        Me.btnnuevo.TabIndex = 29
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'dgvpermiso
        '
        Me.dgvpermiso.AllowUserToAddRows = False
        Me.dgvpermiso.AllowUserToDeleteRows = False
        Me.dgvpermiso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpermiso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPermiso, Me.cdNumero, Me.cdNombre, Me.cdVigencia})
        Me.dgvpermiso.Location = New System.Drawing.Point(12, 41)
        Me.dgvpermiso.Name = "dgvpermiso"
        Me.dgvpermiso.Size = New System.Drawing.Size(411, 432)
        Me.dgvpermiso.TabIndex = 33
        '
        'cdPermiso
        '
        Me.cdPermiso.HeaderText = "Permiso"
        Me.cdPermiso.Name = "cdPermiso"
        Me.cdPermiso.Width = 50
        '
        'cdNumero
        '
        Me.cdNumero.DataPropertyName = "Numero"
        Me.cdNumero.HeaderText = "Numero"
        Me.cdNumero.Name = "cdNumero"
        Me.cdNumero.ReadOnly = True
        Me.cdNumero.Width = 50
        '
        'cdNombre
        '
        Me.cdNombre.DataPropertyName = "Nombre"
        Me.cdNombre.HeaderText = "Nombre"
        Me.cdNombre.Name = "cdNombre"
        Me.cdNombre.ReadOnly = True
        Me.cdNombre.Width = 150
        '
        'cdVigencia
        '
        Me.cdVigencia.DataPropertyName = "nombrevigencia"
        Me.cdVigencia.HeaderText = "Vigencia"
        Me.cdVigencia.Name = "cdVigencia"
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(32, 479)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(156, 43)
        Me.btnseleccionar.TabIndex = 34
        Me.btnseleccionar.Text = "&Seleccionar Todo"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'frmPermisoGrupal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 534)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.dgvpermiso)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btndeseleccionar)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.cbogrupo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbosistema)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmPermisoGrupal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PermisoGrupal"
        CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbosistema As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btndeseleccionar As System.Windows.Forms.Button
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents dgvpermiso As System.Windows.Forms.DataGridView
    Friend WithEvents cdPermiso As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
End Class
