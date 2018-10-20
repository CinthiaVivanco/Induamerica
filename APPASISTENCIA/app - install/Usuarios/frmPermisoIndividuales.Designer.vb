<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisoIndividuales
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
    Me.btnbuscapersona = New System.Windows.Forms.Button
    Me.txtpersona = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.dgvpermiso = New System.Windows.Forms.DataGridView
    Me.cdPermiso = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnregistrar = New System.Windows.Forms.Button
    Me.btnnuevo = New System.Windows.Forms.Button
    Me.btnseleccionar = New System.Windows.Forms.Button
    Me.btndeseleccionar = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbousuario = New System.Windows.Forms.ComboBox
    CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cbosistema
    '
    Me.cbosistema.FormattingEnabled = True
    Me.cbosistema.Location = New System.Drawing.Point(265, 34)
    Me.cbosistema.Name = "cbosistema"
    Me.cbosistema.Size = New System.Drawing.Size(155, 21)
    Me.cbosistema.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(218, 42)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(44, 13)
    Me.Label3.TabIndex = 29
    Me.Label3.Text = "Sistema"
    '
    'btnbuscapersona
    '
    Me.btnbuscapersona.Image = Global.Colegio.IUsuario.My.Resources.Resources._18
    Me.btnbuscapersona.Location = New System.Drawing.Point(396, 8)
    Me.btnbuscapersona.Name = "btnbuscapersona"
    Me.btnbuscapersona.Size = New System.Drawing.Size(24, 20)
    Me.btnbuscapersona.TabIndex = 0
    Me.btnbuscapersona.UseVisualStyleBackColor = True
    '
    'txtpersona
    '
    Me.txtpersona.Location = New System.Drawing.Point(57, 9)
    Me.txtpersona.Name = "txtpersona"
    Me.txtpersona.ReadOnly = True
    Me.txtpersona.Size = New System.Drawing.Size(341, 20)
    Me.txtpersona.TabIndex = 35
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 34
    Me.Label2.Text = "Persona"
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
    Me.dgvpermiso.Location = New System.Drawing.Point(15, 73)
    Me.dgvpermiso.Name = "dgvpermiso"
    Me.dgvpermiso.Size = New System.Drawing.Size(405, 416)
    Me.dgvpermiso.TabIndex = 37
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
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(427, 110)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnregistrar
    '
    Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnregistrar.Location = New System.Drawing.Point(427, 61)
    Me.btnregistrar.Name = "btnregistrar"
    Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
    Me.btnregistrar.TabIndex = 4
    Me.btnregistrar.Text = "&Registrar"
    Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnregistrar.UseVisualStyleBackColor = True
    '
    'btnnuevo
    '
    Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnnuevo.Location = New System.Drawing.Point(428, 10)
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
    Me.btnnuevo.TabIndex = 3
    Me.btnnuevo.Text = "&Nuevo"
    Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnnuevo.UseVisualStyleBackColor = True
    '
    'btnseleccionar
    '
    Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnseleccionar.Location = New System.Drawing.Point(36, 495)
    Me.btnseleccionar.Name = "btnseleccionar"
    Me.btnseleccionar.Size = New System.Drawing.Size(156, 43)
    Me.btnseleccionar.TabIndex = 6
    Me.btnseleccionar.Text = "&Seleccionar Todo"
    Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnseleccionar.UseVisualStyleBackColor = True
    '
    'btndeseleccionar
    '
    Me.btndeseleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btndeseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btndeseleccionar.Location = New System.Drawing.Point(208, 495)
    Me.btndeseleccionar.Name = "btndeseleccionar"
    Me.btndeseleccionar.Size = New System.Drawing.Size(156, 43)
    Me.btndeseleccionar.TabIndex = 7
    Me.btndeseleccionar.Text = "&Deseleccionar Todo"
    Me.btndeseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btndeseleccionar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 42)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 43
    Me.Label1.Text = "Usuario"
    '
    'cbousuario
    '
    Me.cbousuario.FormattingEnabled = True
    Me.cbousuario.Location = New System.Drawing.Point(57, 34)
    Me.cbousuario.Name = "cbousuario"
    Me.cbousuario.Size = New System.Drawing.Size(155, 21)
    Me.cbousuario.TabIndex = 1
    '
    'frmPermisoIndividuales
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(549, 542)
    Me.Controls.Add(Me.cbousuario)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnseleccionar)
    Me.Controls.Add(Me.btndeseleccionar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnregistrar)
    Me.Controls.Add(Me.btnnuevo)
    Me.Controls.Add(Me.dgvpermiso)
    Me.Controls.Add(Me.btnbuscapersona)
    Me.Controls.Add(Me.txtpersona)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cbosistema)
    Me.Controls.Add(Me.Label3)
    Me.Name = "frmPermisoIndividuales"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "PermisoIndividuales"
    CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbosistema As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnbuscapersona As System.Windows.Forms.Button
  Friend WithEvents txtpersona As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgvpermiso As System.Windows.Forms.DataGridView
  Friend WithEvents cdPermiso As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnregistrar As System.Windows.Forms.Button
  Friend WithEvents btnnuevo As System.Windows.Forms.Button
  Friend WithEvents btnseleccionar As System.Windows.Forms.Button
  Friend WithEvents btndeseleccionar As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbousuario As System.Windows.Forms.ComboBox
End Class
