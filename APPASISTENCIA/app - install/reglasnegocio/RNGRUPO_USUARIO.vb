Public Class RNGRUPO_USUARIO
    Public Sub registrar(ByVal grupo As GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iGrupoUsuario", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@nombre", grupo.Nombre)
            .AddWithValue("@descripcion", grupo.Descripcion)
            .AddWithValue("@vigencia", grupo.Vigencia)
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
    Public Function Leer() As List(Of GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liGruposUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Dim ListL As List(Of GRUPO_USUARIO) = Nothing

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListL = New List(Of GRUPO_USUARIO)
            Do While (dr.Read)
                ListL.Add(New GRUPO_USUARIO(CInt(dr.Item("codigoGrupoUsu")), dr.Item("nombre").ToString, (dr.Item("descripcion").ToString), CBool(dr.Item("vigencia"))))
            Loop
        Catch ex As Exception
            If ListL IsNot Nothing Then
                ListL.Clear()
            End If
            ' I = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            dr.Dispose()
            dr = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try

        Return ListL


    End Function
    Public Function LeerVigentes() As List(Of GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liGruposVigentesUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Dim ListL As List(Of GRUPO_USUARIO) = Nothing

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListL = New List(Of GRUPO_USUARIO)
            Do While (dr.Read)
                ListL.Add(New GRUPO_USUARIO(CInt(dr.Item("codigoGrupoUsu")), dr.Item("nombre").ToString, dr.Item("descripcion").ToString, CBool(dr.Item("vigencia"))))
            Loop
        Catch ex As Exception
            If ListL IsNot Nothing Then
                ListL.Clear()
            End If
            ' I = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            dr.Dispose()
            dr = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try

        Return ListL


    End Function
    Public Sub Modificar(ByVal sistema As GRUPO_USUARIO)

        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aGrupoUsuario", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoGrupoUsu", sistema.Codigo)
            .AddWithValue("@nombre", sistema.Nombre)
            .AddWithValue("@descripcion", sistema.Descripcion)
            .AddWithValue("@vigencia", sistema.Vigencia)
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
    Public Function VerGrupodeUsuario(ByVal usuario As USUARIO) As List(Of GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liGrupoUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoUsu", usuario.Codigo)
        Dim ListL As List(Of GRUPO_USUARIO) = Nothing

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListL = New List(Of GRUPO_USUARIO)
            Do While (dr.Read)
                ListL.Add(New GRUPO_USUARIO(CInt(dr.Item("codigoGrupoUsu")), dr.Item("nombre").ToString, "", CBool(dr.Item("vigencia"))))
            Loop
        Catch ex As Exception
            If ListL IsNot Nothing Then
                ListL.Clear()
            End If
            ' I = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            dr.Dispose()
            dr = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try

        Return ListL

    End Function
End Class