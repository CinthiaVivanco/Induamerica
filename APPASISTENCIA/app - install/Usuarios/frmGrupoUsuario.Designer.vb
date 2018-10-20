<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoUsuario
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
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnregistrar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dvggrupo = New System.Windows.Forms.DataGridView
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnseleccionar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.frmvigencia = New System.Windows.Forms.GroupBox
        Me.rbtnovigente = New System.Windows.Forms.RadioButton
        Me.rbtvigente = New System.Windows.Forms.RadioButton
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvggrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.frmvigencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(602, 117)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(115, 43)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "C&ancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrar.Location = New System.Drawing.Point(602, 68)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
        Me.btnregistrar.TabIndex = 2
        Me.btnregistrar.Text = "&Registrar"
        Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(602, 17)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dvggrupo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 246)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Grupos"
        '
        'dvggrupo
        '
        Me.dvggrupo.AllowUserToAddRows = False
        Me.dvggrupo.AllowUserToDeleteRows = False
        Me.dvggrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvggrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvggrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cdVigencia})
        Me.dvggrupo.Location = New System.Drawing.Point(6, 19)
        Me.dvggrupo.Name = "dvggrupo"
        Me.dvggrupo.ReadOnly = True
        Me.dvggrupo.Size = New System.Drawing.Size(288, 221)
        Me.dvggrupo.TabIndex = 0
        '
        'cdNombre
        '
        Me.cdNombre.DataPropertyName = "Nombre"
        Me.cdNombre.HeaderText = "Nombre"
        Me.cdNombre.Name = "cdNombre"
        Me.cdNombre.ReadOnly = True
        '
        'cdVigencia
        '
        Me.cdVigencia.DataPropertyName = "nombrevigencia"
        Me.cdVigencia.HeaderText = "Vigencia"
        Me.cdVigencia.Name = "cdVigencia"
        Me.cdVigencia.ReadOnly = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(90, 264)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(115, 43)
        Me.btnseleccionar.TabIndex = 6
        Me.btnseleccionar.Text = "&Seleccionar"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.frmvigencia)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 246)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos"
        '
        'frmvigencia
        '
        Me.frmvigencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmvigencia.Controls.Add(Me.rbtnovigente)
        Me.frmvigencia.Controls.Add(Me.rbtvigente)
        Me.frmvigencia.Location = New System.Drawing.Point(16, 188)
        Me.frmvigencia.Name = "frmvigencia"
        Me.frmvigencia.Size = New System.Drawing.Size(231, 37)
        Me.frmvigencia.TabIndex = 28
        Me.frmvigencia.TabStop = False
        Me.frmvigencia.Text = "Vigencia"
        '
        'rbtnovigente
        '
        Me.rbtnovigente.AutoSize = True
        Me.rbtnovigente.Location = New System.Drawing.Point(135, 14)
        Me.rbtnovigente.Name = "rbtnovigente"
        Me.rbtnovigente.Size = New System.Drawing.Size(78, 17)
        Me.rbtnovigente.TabIndex = 1
        Me.rbtnovigente.TabStop = True
        Me.rbtnovigente.Text = "No Vigente"
        Me.rbtnovigente.UseVisualStyleBackColor = True
        '
        'rbtvigente
        '
        Me.rbtvigente.AutoSize = True
        Me.rbtvigente.Location = New System.Drawing.Point(25, 14)
        Me.rbtvigente.Name = "rbtvigente"
        Me.rbtvigente.Size = New System.Drawing.Size(61, 17)
        Me.rbtvigente.TabIndex = 0
        Me.rbtvigente.TabStop = True
        Me.rbtvigente.Text = "Vigente"
        Me.rbtvigente.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.Location = New System.Drawing.Point(16, 97)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(234, 65)
        Me.txtdescripcion.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Location = New System.Drawing.Point(66, 30)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(181, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(602, 166)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 319)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Name = "frmGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dvggrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmvigencia.ResumeLayout(False)
        Me.frmvigencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents frmvigencia As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnovigente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtvigente As System.Windows.Forms.RadioButton
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents dvggrupo As System.Windows.Forms.DataGridView
    Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
