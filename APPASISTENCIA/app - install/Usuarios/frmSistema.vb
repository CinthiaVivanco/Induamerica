Public Class frmSistema
  Private cod As Integer

  Private Sub limpiar()
    Me.txtnombre.Text = ""
    Me.txtdescripcion.Text = ""
    Me.rbtvigente.Checked = True
  End Sub

  Private Sub Sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    cargatabla()
  End Sub
  Public Sub cargatabla()
    Dim obj As New RNSistema
    Dim la As List(Of Sistema)
    la = obj.Leer
    Me.dvgsistema.AutoGenerateColumns = False
    Me.dvgsistema.DataSource = la
    Me.dvgsistema.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Me.txtnombre.Focus()
    Me.btnregistrar.Text = "&Modificar"
        Dim obj As RNGRUPO_USUARIO = Nothing
    Dim L As Sistema = Nothing
    Dim count As Integer
    count = Me.dvgsistema.Rows.Count

    If count > 0 Then
            obj = New RNGRUPO_USUARIO
      L = CType(Me.dvgsistema.Rows(dvgsistema.CurrentRow.Index).DataBoundItem, Sistema)
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
        MessageBox.Show("No se pudo encontrar el Sistema Seleccionado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    End If

  End Sub


  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.txtnombre.Focus()
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Dispose()
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.txtnombre.Text.Length > 0 And Me.txtdescripcion.Text.Length > 0 Then

      Dim x As Boolean
      If Me.rbtvigente.Checked Then
        x = True
      Else
        x = False
      End If
      If Me.btnregistrar.Text = "&Registrar" Then
        Dim regla As New RNSistema
        regla.registrar(New Sistema(Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text.ToUpper, x))
        Me.cargatabla()
        Me.limpiar()
        MessageBox.Show("Sistema Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        Dim regla As New RNSistema
        regla.Modificar(New Sistema(cod, Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, x))
        Me.cargatabla()
        Me.limpiar()
        Me.btnregistrar.Text = "&Registrar"
        MessageBox.Show("Sistema  Modificado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    Else
      MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.limpiar()
    End If
    Me.txtnombre.Focus()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub
End Class
