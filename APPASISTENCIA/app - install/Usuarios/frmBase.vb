Public Class frmBase

    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssPeriodo.Text = (Year(Now) & Format(Month(Now), "00")).ToString

        If Not (mOUsuario Is Nothing) Then
            tssUsuario.Text = mOUsuario.Nombre
        Else
            tssUsuario.Text = ""
        End If

    End Sub

End Class