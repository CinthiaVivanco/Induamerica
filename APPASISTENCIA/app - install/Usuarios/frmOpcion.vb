Public Class frmOpcion
  Private cod As Integer
  Private Sub Opcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnsistema.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    cargasistema()
    Me.cargatabla()
  End Sub

  Private Sub cargatabla()
    Dim x As Integer
    Dim obj As New RNOpcion
    Dim la As List(Of Opcion)

    x = CInt(Me.cbosistema.SelectedValue)
    la = obj.Leer(x)
    dgvopciones.AutoGenerateColumns = False
    dgvopciones.DataSource = la
    Me.dgvopciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub
  Private Sub cargasistema()
    Dim obj As New RNSistema
    Dim la As List(Of Sistema)
    la = obj.LeerVigentes
    cbosistema.DisplayMember = "Nombre"
    cbosistema.ValueMember = "Codigo"
    cbosistema.DataSource = la
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    'MessageBox.Show(cbosistema.SelectedValue.ToString)
    Me.txtNumero.Focus()
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub limpiar()
    If cbosistema.Items.Count > 0 Then
      Me.cbosistema.SelectedIndex = 0
    End If
    Me.txtnombre.Text = ""
    Me.txtdescripcion.Text = ""
    Me.rbtvigente.Checked = True
    Me.txtNumero.Text = ""
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Dispose()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    If Me.cbosistema.Items.Count > 0 And Me.txtNumero.Text.Length > 0 And Me.txtnombre.Text.Length > 0 And Me.txtdescripcion.Text.Length > 0 Then
      Dim x As Integer
      If Me.rbtvigente.Checked Then
        x = 1
      Else
        x = 0
      End If
      If Me.btnregistrar.Text = "&Registrar" Then
        Try
          Dim regla As New RNOpcion
          regla.registrar(New Opcion(CInt(Me.txtNumero.Text), New Sistema(CInt(Me.cbosistema.SelectedValue)), Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, x))
          MessageBox.Show("Opcion del Sistema Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          MessageBox.Show("Error en el Registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          Me.cargatabla()
          Me.limpiar()
        End Try
      Else
        Try
          Dim regla As New RNOpcion
          regla.Modificar(New Opcion(cod, New Sistema(CInt(Me.cbosistema.SelectedIndex.ToString) + 1), Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, x), CInt(Me.txtNumero.Text))
          Me.btnregistrar.Text = "&Registrar"
          MessageBox.Show("Opcion del Sistema Modificada Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          MessageBox.Show("Error en la Modificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          Me.cargatabla()
          Me.limpiar()
        End Try
      End If
    Else
      MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.limpiar()

    End If
    Me.cargatabla()
    Me.txtNumero.Focus()
  End Sub

  Private Sub cbosistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosistema.SelectedIndexChanged
    Me.cargatabla()
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Me.txtNumero.Focus()
    Me.btnregistrar.Text = "&Modificar"
    Dim obj As RNOpcion = Nothing
    Dim L As Opcion = Nothing
    Dim count As Integer
    count = Me.dgvopciones.Rows.Count

    If count > 0 Then
      obj = New RNOpcion
      L = CType(Me.dgvopciones.Rows(dgvopciones.CurrentRow.Index).DataBoundItem, Opcion)
      'cod = Me.cbosistema.SelectedValue.ToString
      cod = L.Numero
      If L IsNot Nothing Then
        Me.txtNumero.Text = L.Numero.ToString
        Me.txtnombre.Text = L.Nombre
        Me.txtdescripcion.Text = L.Descripcion
        If L.Vigencia = 0 Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar la Opcion solicitada", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    End If

  End Sub

  Private Sub btnsistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsistema.Click
    Dim sist As New frmSistema
    sist.Show()
  End Sub

  Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub


  Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

  End Sub
End Class