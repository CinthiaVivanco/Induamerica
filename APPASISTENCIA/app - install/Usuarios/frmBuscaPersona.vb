Public Class frmBuscaPersona
    Private pro As New Persona
    Public Function Buscar() As Persona
        Me.ShowDialog()
        If pro.Nombre Is Nothing Then
            Return Nothing
        Else
            Return pro
        End If
    End Function
    Private Sub frmBuscaPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Try
            pro = CType(Me.BuscaPersonal1.dgvgrupo.Rows(BuscaPersonal1.dgvgrupo.CurrentRow.Index).DataBoundItem, Persona)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class