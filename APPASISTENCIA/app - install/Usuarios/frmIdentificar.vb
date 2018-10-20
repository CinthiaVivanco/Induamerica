Public Class frmIdentificar


    Private Const MAXINTENTOS As Byte = 3
    Private Intentos As Integer = 0

     
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        mOUsuario = Nothing
        Me.Close()
    End Sub

    Public Sub ListarPermisosPersonal()
        Dim objRN As New RNPERMISO

        LPermisos = objRN.ListarPermisosxPersonal(New PERMISO(New SISTEMA(mSistema), New USUARIO(mOUsuario.Codigo)))

    End Sub

    Private Sub btnIdentificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentificar.Click
        Dim rnU As New RNUSUARIO
        Dim o As USUARIO
        Dim msje As String

        Intentos += 1
        o = rnU.Identificar(New USUARIO(txtUsuario.Text, txtContrasena.Text))
        rnU = Nothing

        If o IsNot Nothing Then

            mOUsuario = o
            mOUsuario.Nombre = txtUsuario.Text


            ListarPermisosPersonal()
            Me.Close()
        Else
            msje = "El nombre de usuario o contraseña son incorrectas. Sólo le quedan " & (MAXINTENTOS - Intentos).ToString & " intentos"
            MessageBox.Show(msje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)



        End If

        If Intentos = 3 Then
            Me.Close()
        Else
            Me.txtContrasena.Text = ""
            Me.txtContrasena.Focus()
        End If

    End Sub
End Class