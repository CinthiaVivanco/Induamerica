<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
 Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.dvgusuario = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidopaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidomaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiene = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbogrupo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.frmvigencia = New System.Windows.Forms.GroupBox()
        Me.rbtnovigente = New System.Windows.Forms.RadioButton()
        Me.rbtvigente = New System.Windows.Forms.RadioButton()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscapersona = New System.Windows.Forms.Button()
        Me.txtpersona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxHuella = New System.Windows.Forms.GroupBox()
        Me.CHKDNI = New System.Windows.Forms.CheckBox()
        Me.CHKHUELLA = New System.Windows.Forms.CheckBox()
        Me.UltraLabel14 = New System.Windows.Forms.TextBox()
        Me.btnHuellaRefresh = New System.Windows.Forms.Button()
        Me.picHuella = New System.Windows.Forms.PictureBox()
        Me.rbtZkFinger10 = New System.Windows.Forms.RadioButton()
        Me.rbtZkFinger9 = New System.Windows.Forms.RadioButton()
        Me.lblTieneHuella = New System.Windows.Forms.Label()
        Me.ZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txttrabajador = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dvgusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.frmvigencia.SuspendLayout()
        Me.GroupBoxHuella.SuspendLayout()
        CType(Me.picHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgusuario
        '
        Me.dvgusuario.AllowUserToAddRows = False
        Me.dvgusuario.AllowUserToDeleteRows = False
        Me.dvgusuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dvgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgusuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellidopaterno, Me.apellidomaterno, Me.nombres, Me.telefono, Me.tiene})
        Me.dvgusuario.Location = New System.Drawing.Point(6, 19)
        Me.dvgusuario.Name = "dvgusuario"
        Me.dvgusuario.ReadOnly = True
        Me.dvgusuario.Size = New System.Drawing.Size(565, 475)
        Me.dvgusuario.TabIndex = 0
        '
        'dni
        '
        Me.dni.HeaderText = "Dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.Width = 80
        '
        'apellidopaterno
        '
        Me.apellidopaterno.HeaderText = "Apellido Paterno"
        Me.apellidopaterno.Name = "apellidopaterno"
        Me.apellidopaterno.ReadOnly = True
        Me.apellidopaterno.Width = 95
        '
        'apellidomaterno
        '
        Me.apellidomaterno.HeaderText = "Apellido Materno"
        Me.apellidomaterno.Name = "apellidomaterno"
        Me.apellidomaterno.ReadOnly = True
        Me.apellidomaterno.Width = 95
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 95
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 90
        '
        'tiene
        '
        Me.tiene.HeaderText = "Tiene Huella"
        Me.tiene.Name = "tiene"
        Me.tiene.ReadOnly = True
        Me.tiene.Width = 70
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(204, 547)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(115, 43)
        Me.btnseleccionar.TabIndex = 6
        Me.btnseleccionar.Text = "&Seleccionar"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dvgusuario)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 500)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Trabajadores"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(920, 172)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(99, 43)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(920, 116)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(99, 43)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "C&ancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrar.Location = New System.Drawing.Point(920, 60)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(99, 43)
        Me.btnregistrar.TabIndex = 2
        Me.btnregistrar.Text = "&Registrar"
        Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(920, 3)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(99, 45)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        Me.btnnuevo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbogrupo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboTipo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.frmvigencia)
        Me.GroupBox2.Controls.Add(Me.txtContraseña)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnbuscapersona)
        Me.GroupBox2.Controls.Add(Me.txtpersona)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(595, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 246)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trabajador"
        Me.GroupBox2.Visible = False
        '
        'cbogrupo
        '
        Me.cbogrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.Location = New System.Drawing.Point(63, 29)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(237, 21)
        Me.cbogrupo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Grupo"
        '
        'cboTipo
        '
        Me.cboTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(82, 161)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(220, 21)
        Me.cboTipo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo"
        '
        'frmvigencia
        '
        Me.frmvigencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmvigencia.Controls.Add(Me.rbtnovigente)
        Me.frmvigencia.Controls.Add(Me.rbtvigente)
        Me.frmvigencia.Location = New System.Drawing.Point(16, 195)
        Me.frmvigencia.Name = "frmvigencia"
        Me.frmvigencia.Size = New System.Drawing.Size(286, 37)
        Me.frmvigencia.TabIndex = 10
        Me.frmvigencia.TabStop = False
        Me.frmvigencia.Text = "Vigencia"
        '
        'rbtnovigente
        '
        Me.rbtnovigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.rbtvigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtvigente.AutoSize = True
        Me.rbtvigente.Location = New System.Drawing.Point(25, 14)
        Me.rbtvigente.Name = "rbtvigente"
        Me.rbtvigente.Size = New System.Drawing.Size(61, 17)
        Me.rbtvigente.TabIndex = 0
        Me.rbtvigente.TabStop = True
        Me.rbtvigente.Text = "Vigente"
        Me.rbtvigente.UseVisualStyleBackColor = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContraseña.Location = New System.Drawing.Point(80, 127)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(220, 20)
        Me.txtContraseña.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña"
        '
        'btnbuscapersona
        '
        Me.btnbuscapersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscapersona.Image = Global.Colegio.IUsuario.My.Resources.Resources._18
        Me.btnbuscapersona.Location = New System.Drawing.Point(278, 63)
        Me.btnbuscapersona.Name = "btnbuscapersona"
        Me.btnbuscapersona.Size = New System.Drawing.Size(24, 20)
        Me.btnbuscapersona.TabIndex = 2
        Me.btnbuscapersona.UseVisualStyleBackColor = True
        '
        'txtpersona
        '
        Me.txtpersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpersona.Location = New System.Drawing.Point(62, 63)
        Me.txtpersona.Name = "txtpersona"
        Me.txtpersona.ReadOnly = True
        Me.txtpersona.Size = New System.Drawing.Size(220, 20)
        Me.txtpersona.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Persona"
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(62, 93)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(240, 20)
        Me.txtnombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombrepersona"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Persona"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombretipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombrevigencia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vigencia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBoxHuella
        '
        Me.GroupBoxHuella.Controls.Add(Me.CHKDNI)
        Me.GroupBoxHuella.Controls.Add(Me.CHKHUELLA)
        Me.GroupBoxHuella.Controls.Add(Me.UltraLabel14)
        Me.GroupBoxHuella.Controls.Add(Me.btnHuellaRefresh)
        Me.GroupBoxHuella.Controls.Add(Me.picHuella)
        Me.GroupBoxHuella.Location = New System.Drawing.Point(615, 285)
        Me.GroupBoxHuella.Name = "GroupBoxHuella"
        Me.GroupBoxHuella.Size = New System.Drawing.Size(283, 258)
        Me.GroupBoxHuella.TabIndex = 7
        Me.GroupBoxHuella.TabStop = False
        Me.GroupBoxHuella.Text = "Huella"
        '
        'CHKDNI
        '
        Me.CHKDNI.AutoSize = True
        Me.CHKDNI.Location = New System.Drawing.Point(171, 23)
        Me.CHKDNI.Name = "CHKDNI"
        Me.CHKDNI.Size = New System.Drawing.Size(81, 17)
        Me.CHKDNI.TabIndex = 31
        Me.CHKDNI.Text = "Marcar DNI"
        Me.CHKDNI.UseVisualStyleBackColor = True
        Me.CHKDNI.Visible = False
        '
        'CHKHUELLA
        '
        Me.CHKHUELLA.AutoSize = True
        Me.CHKHUELLA.Location = New System.Drawing.Point(33, 23)
        Me.CHKHUELLA.Name = "CHKHUELLA"
        Me.CHKHUELLA.Size = New System.Drawing.Size(92, 17)
        Me.CHKHUELLA.TabIndex = 30
        Me.CHKHUELLA.Text = "Marcar Huella"
        Me.CHKHUELLA.UseVisualStyleBackColor = True
        Me.CHKHUELLA.Visible = False
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Location = New System.Drawing.Point(16, 192)
        Me.UltraLabel14.Multiline = True
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.ReadOnly = True
        Me.UltraLabel14.Size = New System.Drawing.Size(255, 55)
        Me.UltraLabel14.TabIndex = 29
        '
        'btnHuellaRefresh
        '
        Me.btnHuellaRefresh.Image = CType(resources.GetObject("btnHuellaRefresh.Image"), System.Drawing.Image)
        Me.btnHuellaRefresh.Location = New System.Drawing.Point(208, 53)
        Me.btnHuellaRefresh.Name = "btnHuellaRefresh"
        Me.btnHuellaRefresh.Size = New System.Drawing.Size(29, 29)
        Me.btnHuellaRefresh.TabIndex = 27
        Me.btnHuellaRefresh.UseVisualStyleBackColor = True
        Me.btnHuellaRefresh.Visible = False
        '
        'picHuella
        '
        Me.picHuella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHuella.Location = New System.Drawing.Point(82, 46)
        Me.picHuella.Name = "picHuella"
        Me.picHuella.Size = New System.Drawing.Size(123, 133)
        Me.picHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHuella.TabIndex = 25
        Me.picHuella.TabStop = False
        '
        'rbtZkFinger10
        '
        Me.rbtZkFinger10.AutoSize = True
        Me.rbtZkFinger10.Location = New System.Drawing.Point(918, 308)
        Me.rbtZkFinger10.Name = "rbtZkFinger10"
        Me.rbtZkFinger10.Size = New System.Drawing.Size(92, 17)
        Me.rbtZkFinger10.TabIndex = 33
        Me.rbtZkFinger10.Text = "ZKFinger 10.0"
        Me.rbtZkFinger10.UseVisualStyleBackColor = True
        Me.rbtZkFinger10.Visible = False
        '
        'rbtZkFinger9
        '
        Me.rbtZkFinger9.AutoSize = True
        Me.rbtZkFinger9.Checked = True
        Me.rbtZkFinger9.Location = New System.Drawing.Point(918, 277)
        Me.rbtZkFinger9.Name = "rbtZkFinger9"
        Me.rbtZkFinger9.Size = New System.Drawing.Size(86, 17)
        Me.rbtZkFinger9.TabIndex = 32
        Me.rbtZkFinger9.TabStop = True
        Me.rbtZkFinger9.Text = "ZKFinger 9.0"
        Me.rbtZkFinger9.UseVisualStyleBackColor = True
        Me.rbtZkFinger9.Visible = False
        '
        'lblTieneHuella
        '
        Me.lblTieneHuella.AutoSize = True
        Me.lblTieneHuella.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieneHuella.ForeColor = System.Drawing.Color.Navy
        Me.lblTieneHuella.Location = New System.Drawing.Point(688, 267)
        Me.lblTieneHuella.Name = "lblTieneHuella"
        Me.lblTieneHuella.Size = New System.Drawing.Size(0, 17)
        Me.lblTieneHuella.TabIndex = 35
        Me.lblTieneHuella.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ZKFPEngX1
        '
        Me.ZKFPEngX1.Enabled = True
        Me.ZKFPEngX1.Location = New System.Drawing.Point(936, 373)
        Me.ZKFPEngX1.Name = "ZKFPEngX1"
        Me.ZKFPEngX1.OcxState = CType(resources.GetObject("ZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.ZKFPEngX1.TabIndex = 36
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtnombres)
        Me.GroupBox3.Controls.Add(Me.txtmaterno)
        Me.GroupBox3.Controls.Add(Me.txtpaterno)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtdni)
        Me.GroupBox3.Location = New System.Drawing.Point(589, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(324, 246)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trabajador"
        '
        'txtnombres
        '
        Me.txtnombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombres.Enabled = False
        Me.txtnombres.Location = New System.Drawing.Point(111, 205)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(183, 20)
        Me.txtnombres.TabIndex = 9
        Me.txtnombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmaterno
        '
        Me.txtmaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmaterno.Enabled = False
        Me.txtmaterno.Location = New System.Drawing.Point(110, 153)
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(183, 20)
        Me.txtmaterno.TabIndex = 8
        Me.txtmaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpaterno
        '
        Me.txtpaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpaterno.Enabled = False
        Me.txtpaterno.Location = New System.Drawing.Point(111, 99)
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(183, 20)
        Me.txtpaterno.TabIndex = 7
        Me.txtpaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ap Paterno"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Nombres"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ap Materno"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Dni"
        '
        'txtdni
        '
        Me.txtdni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(111, 50)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(183, 20)
        Me.txtdni.TabIndex = 5
        Me.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttrabajador
        '
        Me.txttrabajador.Location = New System.Drawing.Point(164, 13)
        Me.txttrabajador.Name = "txttrabajador"
        Me.txttrabajador.Size = New System.Drawing.Size(305, 20)
        Me.txttrabajador.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Trabajador"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 602)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttrabajador)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ZKFPEngX1)
        Me.Controls.Add(Me.lblTieneHuella)
        Me.Controls.Add(Me.rbtZkFinger10)
        Me.Controls.Add(Me.rbtZkFinger9)
        Me.Controls.Add(Me.GroupBoxHuella)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        CType(Me.dvgusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmvigencia.ResumeLayout(False)
        Me.frmvigencia.PerformLayout()
        Me.GroupBoxHuella.ResumeLayout(False)
        Me.GroupBoxHuella.PerformLayout()
        CType(Me.picHuella, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents dvgusuario As System.Windows.Forms.DataGridView
  Friend WithEvents btnseleccionar As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnregistrar As System.Windows.Forms.Button
  Friend WithEvents btnnuevo As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents frmvigencia As System.Windows.Forms.GroupBox
  Friend WithEvents rbtnovigente As System.Windows.Forms.RadioButton
  Friend WithEvents rbtvigente As System.Windows.Forms.RadioButton
  Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnbuscapersona As System.Windows.Forms.Button
  Friend WithEvents txtpersona As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxHuella As System.Windows.Forms.GroupBox
    Friend WithEvents UltraLabel14 As System.Windows.Forms.TextBox
    Friend WithEvents btnHuellaRefresh As System.Windows.Forms.Button
    Friend WithEvents picHuella As System.Windows.Forms.PictureBox
    Private WithEvents rbtZkFinger10 As System.Windows.Forms.RadioButton
    Private WithEvents rbtZkFinger9 As System.Windows.Forms.RadioButton
    Friend WithEvents CHKDNI As System.Windows.Forms.CheckBox
    Friend WithEvents CHKHUELLA As System.Windows.Forms.CheckBox
    Friend WithEvents lblTieneHuella As System.Windows.Forms.Label
    Friend WithEvents ZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtpaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents txttrabajador As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidopaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidomaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiene As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
