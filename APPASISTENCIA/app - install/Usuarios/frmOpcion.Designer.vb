<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbosistema = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.frmvigencia = New System.Windows.Forms.GroupBox
        Me.rbtnovigente = New System.Windows.Forms.RadioButton
        Me.rbtvigente = New System.Windows.Forms.RadioButton
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvopciones = New System.Windows.Forms.DataGridView
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnregistrar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btnseleccionar = New System.Windows.Forms.Button
        Me.btnsistema = New System.Windows.Forms.Button
        Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.frmvigencia.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvopciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbosistema)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.frmvigencia)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opcion"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(69, 52)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Numero"
        '
        'cbosistema
        '
        Me.cbosistema.FormattingEnabled = True
        Me.cbosistema.Location = New System.Drawing.Point(69, 23)
        Me.cbosistema.Name = "cbosistema"
        Me.cbosistema.Size = New System.Drawing.Size(181, 21)
        Me.cbosistema.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sistema"
        '
        'frmvigencia
        '
        Me.frmvigencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmvigencia.Controls.Add(Me.rbtnovigente)
        Me.frmvigencia.Controls.Add(Me.rbtvigente)
        Me.frmvigencia.Location = New System.Drawing.Point(19, 195)
        Me.frmvigencia.Name = "frmvigencia"
        Me.frmvigencia.Size = New System.Drawing.Size(236, 37)
        Me.frmvigencia.TabIndex = 4
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
        Me.txtdescripcion.Location = New System.Drawing.Point(19, 131)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(236, 58)
        Me.txtdescripcion.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Location = New System.Drawing.Point(69, 79)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(186, 20)
        Me.txtnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvopciones)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 246)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Opciones"
        '
        'dgvopciones
        '
        Me.dgvopciones.AllowUserToAddRows = False
        Me.dgvopciones.AllowUserToDeleteRows = False
        Me.dgvopciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvopciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvopciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdNombre, Me.cdVigencia})
        Me.dgvopciones.Location = New System.Drawing.Point(6, 19)
        Me.dgvopciones.Name = "dgvopciones"
        Me.dgvopciones.ReadOnly = True
        Me.dgvopciones.Size = New System.Drawing.Size(336, 221)
        Me.dgvopciones.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(649, 161)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(649, 112)
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
        Me.btnregistrar.Location = New System.Drawing.Point(649, 63)
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
        Me.btnnuevo.Location = New System.Drawing.Point(649, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(47, 264)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(115, 43)
        Me.btnseleccionar.TabIndex = 6
        Me.btnseleccionar.Text = "&Seleccionar"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'btnsistema
        '
        Me.btnsistema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsistema.Location = New System.Drawing.Point(186, 264)
        Me.btnsistema.Name = "btnsistema"
        Me.btnsistema.Size = New System.Drawing.Size(115, 43)
        Me.btnsistema.TabIndex = 7
        Me.btnsistema.Text = "S&istemas"
        Me.btnsistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsistema.UseVisualStyleBackColor = True
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
        Me.cdNombre.Width = 140
        '
        'cdVigencia
        '
        Me.cdVigencia.DataPropertyName = "nombrevigencia"
        Me.cdVigencia.HeaderText = "Vigencia"
        Me.cdVigencia.Name = "cdVigencia"
        Me.cdVigencia.ReadOnly = True
        '
        'frmOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 319)
        Me.Controls.Add(Me.btnsistema)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOpcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opcion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.frmvigencia.ResumeLayout(False)
        Me.frmvigencia.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvopciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosistema As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents frmvigencia As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnovigente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtvigente As System.Windows.Forms.RadioButton
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvopciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents btnsistema As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
