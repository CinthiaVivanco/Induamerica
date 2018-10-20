Public Class frmBuscarUsuario
    Private pro As New Usuario
    Public Function Buscar() As Usuario
        Me.ShowDialog()
        If pro.Nombre Is Nothing Then
            Return Nothing
        Else
            Return pro
        End If
    End Function
    Private Sub frmBuscarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    End Sub

    Private Sub BuscaUsuario1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Try
            pro = CType(BuscaUsuario1.dgvusuario.Rows(BuscaUsuario1.dgvusuario.CurrentRow.Index).DataBoundItem, Usuario)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class