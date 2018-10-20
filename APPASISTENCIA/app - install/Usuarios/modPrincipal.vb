Module modPrincipal
    Public mOUsuario As USUARIO
    Public mSistema As Integer = 4
    Public LPermisos As List(Of PERMISO) = Nothing

    Public Sub main()
        Dim f As New frmIdentificar

        Application.EnableVisualStyles()
        f.ShowDialog()

        'If f.DialogResult = DialogResult.OK Then
        If mOUsuario IsNot Nothing Then

            'Application.Run(fPer)
            '  If mOInstitucion IsNot Nothing Then
            Application.Run(New Menu)
            'End If
        End If
        ' End If
    End Sub

End Module
