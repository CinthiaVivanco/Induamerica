<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignaGrupoaUsuario
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
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.dvggrupo = New System.Windows.Forms.DataGridView
    Me.cbogrupo = New System.Windows.Forms.ComboBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.btnbuscapersona = New System.Windows.Forms.Button
    Me.txtusuario = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btneliminar = New System.Windows.Forms.Button
    Me.btnregistrar = New System.Windows.Forms.Button
    Me.btnnuevo = New System.Windows.Forms.Button
    Me.cdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GroupBox2.SuspendLayout()
    CType(Me.dvggrupo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.dvggrupo)
    Me.GroupBox2.Controls.Add(Me.cbogrupo)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.btnbuscapersona)
    Me.GroupBox2.Controls.Add(Me.txtusuario)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(297, 258)
    Me.GroupBox2.TabIndex = 6
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Usuario"
    '
    'dvggrupo
    '
    Me.dvggrupo.AllowUserToAddRows = False
    Me.dvggrupo.AllowUserToDeleteRows = False
    Me.dvggrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dvggrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dvggrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdGrupo, Me.cdVigencia})
    Me.dvggrupo.Location = New System.Drawing.Point(11, 88)
    Me.dvggrupo.Name = "dvggrupo"
    Me.dvggrupo.ReadOnly = True
    Me.dvggrupo.Size = New System.Drawing.Size(280, 150)
    Me.dvggrupo.TabIndex = 33
    '
    'cbogrupo
    '
    Me.cbogrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbogrupo.FormattingEnabled = True
    Me.cbogrupo.Location = New System.Drawing.Point(55, 52)
    Me.cbogrupo.Name = "cbogrupo"
    Me.cbogrupo.Size = New System.Drawing.Size(235, 21)
    Me.cbogrupo.TabIndex = 32
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(7, 60)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(36, 13)
    Me.Label5.TabIndex = 31
    Me.Label5.Text = "Grupo"
    '
    'btnbuscapersona
    '
    Me.btnbuscapersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnbuscapersona.Image = Global.Colegio.IUsuario.My.Resources.Resources._18
    Me.btnbuscapersona.Location = New System.Drawing.Point(267, 25)
    Me.btnbuscapersona.Name = "btnbuscapersona"
    Me.btnbuscapersona.Size = New System.Drawing.Size(24, 20)
    Me.btnbuscapersona.TabIndex = 2
    Me.btnbuscapersona.UseVisualStyleBackColor = True
    '
    'txtusuario
    '
    Me.txtusuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtusuario.Location = New System.Drawing.Point(55, 25)
    Me.txtusuario.Name = "txtusuario"
    Me.txtusuario.ReadOnly = True
    Me.txtusuario.Size = New System.Drawing.Size(216, 20)
    Me.txtusuario.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 32)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(43, 13)
    Me.Label2.TabIndex = 25
    Me.Label2.Text = "Usuario"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(315, 161)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
    Me.btnCerrar.TabIndex = 15
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btneliminar
    '
    Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btneliminar.Location = New System.Drawing.Point(315, 112)
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(115, 43)
    Me.btneliminar.TabIndex = 14
    Me.btneliminar.Text = "&Eliminar"
    Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btneliminar.UseVisualStyleBackColor = True
    '
    'btnregistrar
    '
    Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnregistrar.Location = New System.Drawing.Point(315, 63)
    Me.btnregistrar.Name = "btnregistrar"
    Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
    Me.btnregistrar.TabIndex = 13
    Me.btnregistrar.Text = "&Agregar"
    Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnregistrar.UseVisualStyleBackColor = True
    '
    'btnnuevo
    '
    Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnnuevo.Location = New System.Drawing.Point(315, 12)
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
    Me.btnnuevo.TabIndex = 12
    Me.btnnuevo.Text = "&Nuevo"
    Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnnuevo.UseVisualStyleBackColor = True
    '
    'cdGrupo
    '
    Me.cdGrupo.DataPropertyName = "Nombre"
    Me.cdGrupo.HeaderText = "Grupo"
    Me.cdGrupo.Name = "cdGrupo"
    Me.cdGrupo.ReadOnly = True
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "nombrevigencia"
    Me.cdVigencia.HeaderText = "Vigencia"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    '
    'frmAsignaGrupoaUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(433, 285)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btneliminar)
    Me.Controls.Add(Me.btnregistrar)
    Me.Controls.Add(Me.btnnuevo)
    Me.Controls.Add(Me.GroupBox2)
    Me.Name = "frmAsignaGrupoaUsuario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmAsignaGrupoaUsuario"
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.dvggrupo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents btnbuscapersona As System.Windows.Forms.Button
  Friend WithEvents txtusuario As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btneliminar As System.Windows.Forms.Button
  Friend WithEvents btnregistrar As System.Windows.Forms.Button
  Friend WithEvents btnnuevo As System.Windows.Forms.Button
  Friend WithEvents dvggrupo As System.Windows.Forms.DataGridView
  Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
