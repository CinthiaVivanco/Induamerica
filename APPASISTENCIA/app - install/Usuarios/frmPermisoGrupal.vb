Public Class frmPermisoGrupal

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Dispose()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeseleccionar.Click
    For Each row As DataGridViewRow In Me.dgvpermiso.Rows
      row.Cells(0).Value = False
    Next
  End Sub

  Private Sub frmPermisoGrupal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btndeseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.cargasistema()
    Me.cargagrupo()
    Me.limpiar()
    cargatabla()
  End Sub
  Private Sub cargapermiso()
    Dim regla As New RNPermiso
    Dim permiso As New Permiso
    Dim rpta As New Permiso
    For Each row As DataGridViewRow In Me.dgvpermiso.Rows
      permiso.CodigoSist = CInt(Me.cbosistema.SelectedValue)
      permiso.NumeroOpc = CInt(row.Cells(1).Value)
      permiso.CodigoGrupoUsu = CInt(Me.cbogrupo.SelectedValue)
      If permiso.CodigoGrupoUsu = 0 Then
        permiso.CodigoGrupoUsu = 1
      End If
      rpta = regla.verificaPermisoGrupal(permiso)
      If rpta IsNot Nothing Then
        If rpta.Acceso = -1 Then
          row.Cells(0).Value = True
        Else
          row.Cells(0).Value = False
        End If
      End If
    Next

  End Sub
  Private Sub cargatabla()
    Dim x As Integer
    x = CInt(Me.cbosistema.SelectedValue)
    Dim obj As New RNOpcion
    Dim la As List(Of Opcion)
    la = obj.Leer(x)
    dgvpermiso.AutoGenerateColumns = False
    dgvpermiso.DataSource = la
    Me.dgvpermiso.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    Me.cargapermiso()
  End Sub
  Private Sub cargasistema()
    Dim obj As New RNSistema
    Dim la As List(Of Sistema)
    la = obj.LeerVigentes
    cbosistema.DisplayMember = "Nombre"
    cbosistema.ValueMember = "Codigo"
    cbosistema.DataSource = la
  End Sub
  Private Sub cargagrupo()
        Dim obj As New RNGRUPO_USUARIO
        Dim la As List(Of GRUPO_USUARIO)
    la = obj.LeerVigentes
    cbogrupo.DisplayMember = "Nombre"
    cbogrupo.ValueMember = "Codigo"
    cbogrupo.DataSource = la
  End Sub

  Private Sub cbosistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosistema.SelectedIndexChanged
    Me.cargatabla()
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.limpiar()
  End Sub
  Private Sub limpiar()
    If Me.cbogrupo.Items.Count > 0 Then
      Me.cbogrupo.SelectedIndex = 0
    End If
    If Me.cbosistema.Items.Count > 0 Then
      Me.cbosistema.SelectedIndex = 0
    End If

  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    For Each row As DataGridViewRow In Me.dgvpermiso.Rows
      row.Cells(0).Value = True
    Next
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.cbogrupo.Items.Count > 0 And Me.cbosistema.Items.Count > 0 Then
      Dim regla As New RNPermiso
      Dim permiso As New Permiso
      Dim rpta As New Permiso
      For Each row As DataGridViewRow In Me.dgvpermiso.Rows
        permiso.CodigoSist = CInt(Me.cbosistema.SelectedValue)
        permiso.NumeroOpc = CInt(row.Cells(1).Value)
        permiso.CodigoGrupoUsu = CInt(Me.cbogrupo.SelectedValue)
        rpta = regla.verificaPermisoGrupal(permiso)
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
          regla.registrarpermisoGrupo(permiso)
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

  Private Sub cbogrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbogrupo.SelectedIndexChanged
    Me.cargatabla()
  End Sub
End Class