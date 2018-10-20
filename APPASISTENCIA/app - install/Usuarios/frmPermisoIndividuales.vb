Public Class frmPermisoIndividuales
  Private a As Persona = Nothing
  Private Usuario As Integer = 0


  Private Sub frmPermisoIndividuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btndeseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.cargasistema()
    'Me.cargatabla()
  End Sub
  Private Sub cargasistema()
    Dim obj As New RNSistema
    Dim la As List(Of Sistema)
    la = obj.LeerVigentes
    cbosistema.DisplayMember = "Nombre"
    cbosistema.ValueMember = "Codigo"
    cbosistema.DataSource = la
  End Sub

  Private Sub cargatabla()
    Dim x As Integer
    Dim obj As New RNOpcion
    Dim la As List(Of Opcion)
    x = CInt(Me.cbosistema.SelectedValue)
    la = obj.Leer(x)
    dgvpermiso.AutoGenerateColumns = False
    dgvpermiso.DataSource = la
    Me.dgvpermiso.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    If Me.txtpersona.Text.Length > 0 Then
      Me.cargapermiso()
    End If
  End Sub
  Private Sub cargapermiso()
    Dim regla As New RNPermiso
    Dim permiso As New Permiso
    Dim rpta As New Permiso
    Dim existencia As Integer
    permiso.CodigoSist = CInt(Me.cbosistema.SelectedValue)
    permiso.CodigoUsu = CInt(Me.cbousuario.SelectedValue)

    existencia = regla.existenciapermisoindividual(permiso)

    If existencia <> 0 Then
      For Each row As DataGridViewRow In Me.dgvpermiso.Rows
        permiso.CodigoSist = CInt(Me.cbosistema.SelectedValue)
        permiso.NumeroOpc = CInt(row.Cells(1).Value)
        permiso.CodigoUsu = CInt(Me.cbousuario.SelectedValue)

        If permiso.CodigoGrupoUsu = 0 Then
          permiso.CodigoGrupoUsu = 1
        End If
        rpta = regla.verificaPermisoIndividual(permiso)
        If rpta IsNot Nothing Then
          If rpta.Acceso = -1 Then
            row.Cells(0).Value = True
          Else
            row.Cells(0).Value = False
          End If
        End If
      Next
    End If
  End Sub



  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.limpiar()

  End Sub
  Private Sub limpiar()
    Me.cbosistema.SelectedIndex = 0
    Me.txtpersona.Text = ""
    Me.Usuario = 0
    Me.cbousuario.DataSource = Nothing
    Me.dgvpermiso.DataSource = Nothing
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    'MessageBox.Show(Me.cbousuario.SelectedValue)
    Dispose()
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    For Each row As DataGridViewRow In Me.dgvpermiso.Rows
      row.Cells(0).Value = True
    Next
  End Sub

  Private Sub btndeseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeseleccionar.Click
    For Each row As DataGridViewRow In Me.dgvpermiso.Rows
      row.Cells(0).Value = False
    Next
  End Sub

  Private Sub btnbuscapersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscapersona.Click
    Me.cbousuario.DataSource = Nothing
    Dim frmbuscar As New frmBuscaPersona
    Dim obj As RNPersona = Nothing
    a = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing
    If a IsNot Nothing Then
            Me.txtpersona.Text = a.NombreCompleto
    End If
    Me.cargausuario()
  End Sub
  Private Sub cargausuario()
    Dim obj As New RNUsuario
    Dim la As List(Of Usuario)
    If a IsNot Nothing Then
            la = obj.PersonaUsuario(a.cod_Persona)
      cbousuario.DisplayMember = "Nombre"
      cbousuario.ValueMember = "Codigo"
      cbousuario.DataSource = la
    End If
  End Sub

  Private Sub cbousuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbousuario.SelectedIndexChanged
    Me.cargatabla()
    Me.Usuario = CInt(Me.cbousuario.SelectedValue)
  End Sub

  Private Sub cbosistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosistema.SelectedIndexChanged
    If Me.Usuario > 0 Then
      Me.cargatabla()
    End If
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.txtpersona.Text.Length > 0 And Me.cbousuario.Items.Count > 0 And Me.cbosistema.Items.Count > 0 Then
      Dim regla As New RNPermiso
      Dim permiso As New Permiso
      Dim rpta As New Permiso
      For Each row As DataGridViewRow In Me.dgvpermiso.Rows
        permiso.CodigoSist = CInt(Me.cbosistema.SelectedValue)
        permiso.NumeroOpc = CInt(row.Cells(1).Value)
        permiso.CodigoUsu = CInt(Me.cbousuario.SelectedValue)
        rpta = regla.verificaPermisoIndividual(permiso)
        If rpta IsNot Nothing Then
          If CBool(row.Cells(0).Value) = True Then
            rpta.Acceso = 1
          Else
            rpta.Acceso = 0
          End If
        Else
          If CBool(row.Cells(0).Value) = True Then
            permiso.Acceso = 1
          Else
            permiso.Acceso = 0
          End If
        End If

        If rpta Is Nothing Then
                    regla.registrarpermisoindividual(permiso)
        Else
                    regla.ModificarPermisoGrupal(rpta)
        End If

      Next
      Me.cargatabla()
      Me.limpiar()
      MessageBox.Show("Permisos Gestionados Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("Error al Gestionar Permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
End Class
