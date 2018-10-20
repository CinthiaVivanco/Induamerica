<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits Colegio.IUsuario.frmBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarGrupoAUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarOpcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosGrupalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosIndividualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.PermisosToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarGrupoToolStripMenuItem, Me.RegistrarUsuarioToolStripMenuItem, Me.AsignarGrupoAUsuarioToolStripMenuItem, Me.RegistrarSistemaToolStripMenuItem, Me.RegistrarOpcionToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "&Registrar"
        '
        'RegistrarGrupoToolStripMenuItem
        '
        Me.RegistrarGrupoToolStripMenuItem.Name = "RegistrarGrupoToolStripMenuItem"
        Me.RegistrarGrupoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RegistrarGrupoToolStripMenuItem.Tag = "1"
        Me.RegistrarGrupoToolStripMenuItem.Text = "Registrar &Grupo"
        '
        'RegistrarUsuarioToolStripMenuItem
        '
        Me.RegistrarUsuarioToolStripMenuItem.Name = "RegistrarUsuarioToolStripMenuItem"
        Me.RegistrarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RegistrarUsuarioToolStripMenuItem.Tag = "2"
        Me.RegistrarUsuarioToolStripMenuItem.Text = "Registrar Huella Trabajadaor"
        '
        'AsignarGrupoAUsuarioToolStripMenuItem
        '
        Me.AsignarGrupoAUsuarioToolStripMenuItem.Name = "AsignarGrupoAUsuarioToolStripMenuItem"
        Me.AsignarGrupoAUsuarioToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AsignarGrupoAUsuarioToolStripMenuItem.Tag = "3"
        Me.AsignarGrupoAUsuarioToolStripMenuItem.Text = "Asignar Grupo a Usuario"
        '
        'RegistrarSistemaToolStripMenuItem
        '
        Me.RegistrarSistemaToolStripMenuItem.Name = "RegistrarSistemaToolStripMenuItem"
        Me.RegistrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RegistrarSistemaToolStripMenuItem.Tag = "4"
        Me.RegistrarSistemaToolStripMenuItem.Text = "Registrar &Sistema"
        '
        'RegistrarOpcionToolStripMenuItem
        '
        Me.RegistrarOpcionToolStripMenuItem.Name = "RegistrarOpcionToolStripMenuItem"
        Me.RegistrarOpcionToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RegistrarOpcionToolStripMenuItem.Tag = "5"
        Me.RegistrarOpcionToolStripMenuItem.Text = "Registrar &Opcion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosGrupalesToolStripMenuItem, Me.PermisosIndividualesToolStripMenuItem})
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PermisosToolStripMenuItem.Text = "&Permisos"
        '
        'PermisosGrupalesToolStripMenuItem
        '
        Me.PermisosGrupalesToolStripMenuItem.Name = "PermisosGrupalesToolStripMenuItem"
        Me.PermisosGrupalesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PermisosGrupalesToolStripMenuItem.Tag = "6"
        Me.PermisosGrupalesToolStripMenuItem.Text = "Permisos Grupales"
        '
        'PermisosIndividualesToolStripMenuItem
        '
        Me.PermisosIndividualesToolStripMenuItem.Name = "PermisosIndividualesToolStripMenuItem"
        Me.PermisosIndividualesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PermisosIndividualesToolStripMenuItem.Tag = "7"
        Me.PermisosIndividualesToolStripMenuItem.Text = "Permisos Individuales"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Colegio.IUsuario.My.Resources.Resources.MenuAcceso
        Me.ClientSize = New System.Drawing.Size(774, 466)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Sistema de Control de Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarOpcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosGrupalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosIndividualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarGrupoAUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
