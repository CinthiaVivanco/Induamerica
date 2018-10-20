Public Class Menu

    Public Sub ActivarMenues()

        Dim vLocMnuOpciones As ToolStripMenuItem
        Try
            For Each vLocMnuOpciones In Me.MenuStrip1.Items

                If vLocMnuOpciones.DropDownItems.Count > 0 Then
                    RecorrerMenus(vLocMnuOpciones.DropDownItems)
                End If

            Next
            'vGlovalor = vGlovalor.TrimEnd(";")
            'MsgBox(vGlovalor)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RecorrerMenus(ByVal vLocOneItem As ToolStripItemCollection)
        Dim vLocElItem As ToolStripMenuItem
        Dim P As PERMISO = Nothing

        Try
            For Each vLocOtroItem As ToolStripItem In vLocOneItem
                If TypeOf vLocOtroItem Is ToolStripMenuItem Then

                    If vLocOtroItem.IsOnDropDown Then
                        vLocElItem = vLocOtroItem
                        If IsNumeric(vLocOtroItem.Tag) Then

                            For Each P In LPermisos
                                If CInt(vLocOtroItem.Tag) = P.NumeroOpc And P.Acceso Then
                                    vLocOtroItem.Enabled = True
                                    Exit For
                                Else
                                    vLocOtroItem.Enabled = False
                                End If
                            Next


                        End If

                        If vLocElItem.DropDownItems.Count > 0 Then
                            RecorrerMenus(vLocElItem.DropDownItems)
                        End If


                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub RegistrarGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarGrupoToolStripMenuItem.Click
        Dim grupo As New frmGrupoUsuario
        grupo.Show()
    End Sub

    Private Sub RegistrarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
        Dim usuario As New frmUsuario
        usuario.Show()
    End Sub

    Private Sub RegistrarSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarSistemaToolStripMenuItem.Click
        Dim sistema As New frmSistema
        sistema.Show()
    End Sub

    Private Sub RegistrarOpcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarOpcionToolStripMenuItem.Click
        Dim opcion As New frmOpcion
        opcion.Show()
    End Sub

    Private Sub PermisosGrupalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosGrupalesToolStripMenuItem.Click
        Dim permiso As New frmPermisoGrupal
        permiso.Show()
    End Sub

    Private Sub PermisosIndividualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosIndividualesToolStripMenuItem.Click
        Dim permiso As New frmPermisoIndividuales
        permiso.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AsignarGrupoAUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarGrupoAUsuarioToolStripMenuItem.Click
        Dim asignar As New frmAsignaGrupoaUsuario
        asignar.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActivarMenues()
    End Sub
End Class