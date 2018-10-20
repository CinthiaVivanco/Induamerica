Public Class frmAsignaGrupoaUsuario
  Private a As Usuario = Nothing
  Private Sub btnbuscapersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscapersona.Click
    Dim frmbuscar As New frmBuscarUsuario
    Dim obj As RNUsuario = Nothing
    a = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing
    If a IsNot Nothing Then
      Me.txtusuario.Text = a.Nombre
      Me.cargatabla()
    End If

  End Sub
  Private Sub cargagrupo()
        Dim obj As New RNGRUPO_USUARIO
        Dim la As List(Of GRUPO_USUARIO)
    la = obj.LeerVigentes
    cbogrupo.DisplayMember = "Nombre"
    cbogrupo.ValueMember = "Codigo"
    cbogrupo.DataSource = la
  End Sub

  Private Sub frmAsignaGrupoaUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cargagrupo()
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btneliminar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.limpiar()
  End Sub
  Private Sub limpiar()
    Me.txtusuario.Text = ""
    Me.cbogrupo.SelectedIndex = 0
    Me.dvggrupo.DataSource = Nothing
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Dispose()
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.txtusuario.Text.Length > 0 Then
      If Me.btnregistrar.Text = "&Agregar" Then
        Try
          Dim regla As New RNUsuario
                    regla.registrar2(New USUARIO(a.Codigo), New GRUPO_USUARIO(CInt(Me.cbogrupo.SelectedValue)))
          Me.cargatabla()
          'Me.limpiar()
        Catch ex As Exception
        End Try
      End If
    Else
      MessageBox.Show("Buscar Usuario", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cargatabla()
        Dim obj As New RNGRUPO_USUARIO
        Dim la As List(Of GRUPO_USUARIO)
    la = obj.VerGrupodeUsuario(New Usuario(Me.a.Codigo))
    dvggrupo.AutoGenerateColumns = False
    dvggrupo.DataSource = la
    Me.dvggrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

  End Sub


  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Me.dvggrupo.Rows.Count > 0 Then
            Dim l As New GRUPO_USUARIO
      Dim x As New RNUsuario
            l = CType(Me.dvggrupo.Rows(dvggrupo.CurrentRow.Index).DataBoundItem, GRUPO_USUARIO)
            x.Eliminar(New USUARIO(a.Codigo), New GRUPO_USUARIO(l.Codigo))

      Me.cargatabla()
    End If
  End Sub
End Class