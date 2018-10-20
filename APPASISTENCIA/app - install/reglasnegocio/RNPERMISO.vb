Public Class RNPERMISO

    Public Sub registrarpermisoGrupo(ByVal permiso As PERMISO)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iPermisoGrupo", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoSist", permiso.CodigoSist)
            .AddWithValue("@numeroOpc", permiso.NumeroOpc)
            .AddWithValue("@codigoGrupoUsu", permiso.CodigoGrupoUsu)
            .AddWithValue("@acceso", permiso.Acceso)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
    End Sub

    Public Sub registrarpermisoindividual(ByVal permiso As PERMISO)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iPermisoIndividual", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoSist", permiso.CodigoSist)
            .AddWithValue("@numeroOpc", permiso.NumeroOpc)
            .AddWithValue("@codigoUsu", permiso.CodigoUsu)
            .AddWithValue("@acceso", permiso.Acceso)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
    End Sub

    Public Function verificaPermisoGrupal(ByVal permiso As PERMISO) As PERMISO
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lPermisoGrupo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim p As Permiso = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoSist", permiso.CodigoSist)
        cmd.Parameters.AddWithValue("@numeroOpc", permiso.NumeroOpc)
        cmd.Parameters.AddWithValue("@codigoGrupoUsu", permiso.CodigoGrupoUsu)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                p = New PERMISO(CInt(dr.Item("numero")), New SISTEMA(CInt(dr.Item("codigosist"))), New OPCION(CInt(dr.Item("numeroOpc"))), New GRUPO_USUARIO(CInt(dr.Item("codigoGrupoUsu"))), CInt(dr.Item("acceso")))
            End If
            cn.Close()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return p
    End Function

    Public Function verificaPermisoIndividual(ByVal permiso As PERMISO) As PERMISO
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lPermisoIndividual", cn)
        Dim dr As SqlDataReader = Nothing
        Dim p As Permiso = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoSist", permiso.CodigoSist)
        cmd.Parameters.AddWithValue("@numeroOpc", permiso.NumeroOpc)
        cmd.Parameters.AddWithValue("@codigoUsu", permiso.CodigoUsu)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                p = New Permiso(CInt(dr.Item("numero")), New Sistema(CInt(dr.Item("codigosist"))), New Opcion(CInt(dr.Item("numeroOpc"))), Nothing, New Usuario(CInt(dr.Item("codigoUsu"))), CInt(dr.Item("acceso")))
            End If
            cn.Close()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return p
    End Function

    Public Sub ModificarPermisoGrupal(ByVal permiso As PERMISO)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_aPermisoGrupo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@numero", permiso.Numero)
            .AddWithValue("@acceso", permiso.Acceso)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
    End Sub

    Public Function existenciapermisoindividual(ByVal permiso As PERMISO) As Integer

        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_CPermisoIndividual", cn)
        Dim dr As SqlDataReader = Nothing
        Dim p As Integer

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoSist", permiso.CodigoSist)
        cmd.Parameters.AddWithValue("@codigoUsu", permiso.CodigoUsu)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                p = CInt(dr.Item("numero"))

            End If
            cn.Close()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return p
    End Function

    Public Function ListarPermisosxPersonal(ByVal permiso As PERMISO) As List(Of PERMISO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liPermisoPersonalAutentificacion", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of PERMISO) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoSist", permiso.CodigoSist)
        cmd.Parameters.AddWithValue("@codigoUsu", permiso.CodigoUsu)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of PERMISO)
            Do While (dr.Read)
                'SELECT p.numero,p.numeroopc,o.nombre,o.vigencia,p.acceso

                ListP.Add(New PERMISO(CInt(dr.Item("numero")), New SISTEMA(permiso.CodigoSist), New OPCION(CInt(dr.Item("numeroOpc"))), Nothing, New USUARIO(permiso.CodigoUsu), CBool(dr.Item("acceso"))))

            Loop
            cn.Close()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return ListP



         

    End Function

End Class