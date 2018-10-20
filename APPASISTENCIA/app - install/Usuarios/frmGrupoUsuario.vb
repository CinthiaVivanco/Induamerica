Public Class frmGrupoUsuario
  Private cod As Integer
  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.txtnombre.Text.Length > 0 And Me.txtdescripcion.Text.Length > 0 Then

      Dim x As Boolean
      If Me.rbtvigente.Checked Then
        x = True
      Else
        x = False
      End If
      If Me.btnregistrar.Text = "&Registrar" Then
                Dim regla As New RNGRUPO_USUARIO
                regla.registrar(New GRUPO_USUARIO(Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text.ToUpper, x))
        Me.cargatabla()
        Me.limpiar()
        MessageBox.Show("Grupo Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
                Dim regla As New RNGRUPO_USUARIO
                regla.Modificar(New GRUPO_USUARIO(cod, Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, x))
        Me.cargatabla()
        Me.limpiar()
        Me.btnregistrar.Text = "&Registrar"
        MessageBox.Show("Grupo Modificado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    Else
      MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.limpiar()

    End If
    Me.txtnombre.Focus()
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.limpiar()
    Me.txtnombre.Focus()
    Me.btnregistrar.Text = "&Registrar"
  End Sub
  Private Sub limpiar()
    Me.txtnombre.Text = ""
    Me.txtdescripcion.Text = ""
    Me.rbtvigente.Checked = True
  End Sub

  Private Sub Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    cargatabla()
    Me.limpiar()
  End Sub
  Public Sub cargatabla()
        Dim obj As New RNGRUPO_USUARIO
        Dim la As List(Of GRUPO_USUARIO)
    la = obj.Leer
    Me.dvggrupo.AutoGenerateColumns = False
    Me.dvggrupo.DataSource = la
    Me.dvggrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Me.txtnombre.Focus()
    Me.btnregistrar.Text = "&Modificar"
        Dim obj As RNGRUPO_USUARIO = Nothing
        Dim L As GRUPO_USUARIO = Nothing
    Dim count As Integer
    count = Me.dvggrupo.Rows.Count

    If count > 0 Then
            obj = New RNGRUPO_USUARIO
            L = CType(Me.dvggrupo.Rows(dvggrupo.CurrentRow.Index).DataBoundItem, GRUPO_USUARIO)
      cod = L.Codigo

      If L IsNot Nothing Then
        Me.txtnombre.Text = L.Nombre
        Me.txtdescripcion.Text = L.Descripcion
        If L.Vigencia = False Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar el Grupo Solicitado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    End If


  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub
End Class