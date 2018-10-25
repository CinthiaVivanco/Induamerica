<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistencia
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistencia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.memoHint = New System.Windows.Forms.TextBox()
        Me.GroupBoxHuella = New System.Windows.Forms.GroupBox()
        Me.UltraLabel14 = New System.Windows.Forms.TextBox()
        Me.btnHuellaRefresh = New System.Windows.Forms.Button()
        Me.picHuella = New System.Windows.Forms.PictureBox()
        Me.rbtZkFinger10 = New System.Windows.Forms.RadioButton()
        Me.rbtZkFinger9 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNroDocuemento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.cboturno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.imgNO = New System.Windows.Forms.PictureBox()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.PH_Clock1 = New AppAsistencia.PH_Clock()
        Me.GroupBoxHuella.SuspendLayout()
        CType(Me.picHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fecha.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_fecha.Location = New System.Drawing.Point(12, 53)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(445, 32)
        Me.lbl_fecha.TabIndex = 53
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 41)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "CONTROL DE ASISTENCIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'memoHint
        '
        Me.memoHint.Location = New System.Drawing.Point(804, 395)
        Me.memoHint.Multiline = True
        Me.memoHint.Name = "memoHint"
        Me.memoHint.Size = New System.Drawing.Size(36, 17)
        Me.memoHint.TabIndex = 60
        Me.memoHint.Visible = False
        '
        'GroupBoxHuella
        '
        Me.GroupBoxHuella.Controls.Add(Me.UltraLabel14)
        Me.GroupBoxHuella.Controls.Add(Me.btnHuellaRefresh)
        Me.GroupBoxHuella.Controls.Add(Me.picHuella)
        Me.GroupBoxHuella.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxHuella.Location = New System.Drawing.Point(800, 9)
        Me.GroupBoxHuella.Name = "GroupBoxHuella"
        Me.GroupBoxHuella.Size = New System.Drawing.Size(205, 248)
        Me.GroupBoxHuella.TabIndex = 59
        Me.GroupBoxHuella.TabStop = False
        Me.GroupBoxHuella.Text = "HUELLA"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Enabled = False
        Me.UltraLabel14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.UltraLabel14.Location = New System.Drawing.Point(17, 196)
        Me.UltraLabel14.Multiline = True
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.ReadOnly = True
        Me.UltraLabel14.Size = New System.Drawing.Size(154, 37)
        Me.UltraLabel14.TabIndex = 29
        '
        'btnHuellaRefresh
        '
        Me.btnHuellaRefresh.Image = CType(resources.GetObject("btnHuellaRefresh.Image"), System.Drawing.Image)
        Me.btnHuellaRefresh.Location = New System.Drawing.Point(177, 19)
        Me.btnHuellaRefresh.Name = "btnHuellaRefresh"
        Me.btnHuellaRefresh.Size = New System.Drawing.Size(29, 29)
        Me.btnHuellaRefresh.TabIndex = 27
        Me.btnHuellaRefresh.UseVisualStyleBackColor = True
        Me.btnHuellaRefresh.Visible = False
        '
        'picHuella
        '
        Me.picHuella.Location = New System.Drawing.Point(17, 19)
        Me.picHuella.Name = "picHuella"
        Me.picHuella.Size = New System.Drawing.Size(154, 171)
        Me.picHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHuella.TabIndex = 25
        Me.picHuella.TabStop = False
        '
        'rbtZkFinger10
        '
        Me.rbtZkFinger10.AutoSize = True
        Me.rbtZkFinger10.Location = New System.Drawing.Point(914, 441)
        Me.rbtZkFinger10.Name = "rbtZkFinger10"
        Me.rbtZkFinger10.Size = New System.Drawing.Size(92, 17)
        Me.rbtZkFinger10.TabIndex = 58
        Me.rbtZkFinger10.Text = "ZKFinger 10.0"
        Me.rbtZkFinger10.UseVisualStyleBackColor = True
        Me.rbtZkFinger10.Visible = False
        '
        'rbtZkFinger9
        '
        Me.rbtZkFinger9.AutoSize = True
        Me.rbtZkFinger9.Checked = True
        Me.rbtZkFinger9.Location = New System.Drawing.Point(913, 418)
        Me.rbtZkFinger9.Name = "rbtZkFinger9"
        Me.rbtZkFinger9.Size = New System.Drawing.Size(86, 17)
        Me.rbtZkFinger9.TabIndex = 57
        Me.rbtZkFinger9.TabStop = True
        Me.rbtZkFinger9.Text = "ZKFinger 9.0"
        Me.rbtZkFinger9.UseVisualStyleBackColor = True
        Me.rbtZkFinger9.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LblNombre)
        Me.GroupBox1.Controls.Add(Me.LblDni)
        Me.GroupBox1.Controls.Add(Me.TxtNroDocuemento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(466, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 517)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvlistado)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 320)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista Personal"
        '
        'dgvlistado
        '
        Me.dgvlistado.AllowUserToAddRows = False
        Me.dgvlistado.AllowUserToDeleteRows = False
        Me.dgvlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvlistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlistado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlistado.Location = New System.Drawing.Point(3, 16)
        Me.dgvlistado.Name = "dgvlistado"
        Me.dgvlistado.ReadOnly = True
        Me.dgvlistado.Size = New System.Drawing.Size(313, 301)
        Me.dgvlistado.TabIndex = 0
        '
        'LblDni
        '
        Me.LblDni.BackColor = System.Drawing.Color.White
        Me.LblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDni.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblDni.Location = New System.Drawing.Point(9, 110)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(317, 28)
        Me.LblDni.TabIndex = 51
        Me.LblDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNombre
        '
        Me.LblNombre.BackColor = System.Drawing.Color.White
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblNombre.Location = New System.Drawing.Point(9, 137)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(317, 28)
        Me.LblNombre.TabIndex = 50
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNroDocuemento
        '
        Me.TxtNroDocuemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroDocuemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtNroDocuemento.Location = New System.Drawing.Point(9, 44)
        Me.TxtNroDocuemento.MaxLength = 8
        Me.TxtNroDocuemento.Name = "TxtNroDocuemento"
        Me.TxtNroDocuemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNroDocuemento.Size = New System.Drawing.Size(317, 31)
        Me.TxtNroDocuemento.TabIndex = 36
        Me.TxtNroDocuemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(45, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Ingrese aqui su Nro Documento:"
        '
        'picFoto
        '
        Me.picFoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picFoto.Location = New System.Drawing.Point(817, 263)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(154, 126)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(9, 165)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(317, 30)
        Me.lblError.TabIndex = 67
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboturno
        '
        Me.cboturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboturno.FormattingEnabled = True
        Me.cboturno.Location = New System.Drawing.Point(12, 25)
        Me.cboturno.Name = "cboturno"
        Me.cboturno.Size = New System.Drawing.Size(92, 21)
        Me.cboturno.TabIndex = 69
        Me.cboturno.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "TURNO"
        Me.Label2.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(13, 546)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(444, 23)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Hora Marcada"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'ZKFPEngX1
        '
        Me.ZKFPEngX1.Enabled = True
        Me.ZKFPEngX1.Location = New System.Drawing.Point(488, 559)
        Me.ZKFPEngX1.Name = "ZKFPEngX1"
        Me.ZKFPEngX1.OcxState = CType(resources.GetObject("ZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.ZKFPEngX1.TabIndex = 71
        '
        'imgNO
        '
        Me.imgNO.Location = New System.Drawing.Point(842, 418)
        Me.imgNO.Name = "imgNO"
        Me.imgNO.Size = New System.Drawing.Size(48, 44)
        Me.imgNO.TabIndex = 72
        Me.imgNO.TabStop = False
        Me.imgNO.Visible = False
        '
        'LblMensaje
        '
        Me.LblMensaje.BackColor = System.Drawing.Color.White
        Me.LblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblMensaje.Location = New System.Drawing.Point(9, 83)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(317, 27)
        Me.LblMensaje.TabIndex = 66
        Me.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PH_Clock1
        '
        Me.PH_Clock1.AutoSize = True
        Me.PH_Clock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PH_Clock1.Location = New System.Drawing.Point(12, 81)
        Me.PH_Clock1.Name = "PH_Clock1"
        Me.PH_Clock1.Size = New System.Drawing.Size(445, 445)
        Me.PH_Clock1.TabIndex = 0
        '
        'frmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 606)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.imgNO)
        Me.Controls.Add(Me.ZKFPEngX1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboturno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.memoHint)
        Me.Controls.Add(Me.GroupBoxHuella)
        Me.Controls.Add(Me.rbtZkFinger10)
        Me.Controls.Add(Me.rbtZkFinger9)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PH_Clock1)
        Me.Name = "frmAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Asistencia Diaria - Huella Digital"
        Me.GroupBoxHuella.ResumeLayout(False)
        Me.GroupBoxHuella.PerformLayout()
        CType(Me.picHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PH_Clock1 As AppAsistencia.PH_Clock
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents memoHint As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxHuella As System.Windows.Forms.GroupBox
    Friend WithEvents UltraLabel14 As System.Windows.Forms.TextBox
    Friend WithEvents btnHuellaRefresh As System.Windows.Forms.Button
    Friend WithEvents picHuella As System.Windows.Forms.PictureBox
    Private WithEvents rbtZkFinger10 As System.Windows.Forms.RadioButton
    Private WithEvents rbtZkFinger9 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents TxtNroDocuemento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents cboturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Private WithEvents imgNO As System.Windows.Forms.PictureBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvlistado As System.Windows.Forms.DataGridView

End Class
