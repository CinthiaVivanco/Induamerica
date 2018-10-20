Imports System.Data.OleDb

Public Class RNUSUARIO

    Public Function Identificar(ByVal wUsuario As USUARIO) As USUARIO
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_IdentificarUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        Dim o As USUARIO = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Usuario", wUsuario.Nombre)
        cmd.Parameters.AddWithValue("@Contrasenia", wUsuario.Contrasenia)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                o = New USUARIO(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), _
                                New Persona(dr.GetInt32(dr.GetOrdinal("cod_persona")), _
                                dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("apPaterno")), _
                                dr.GetString(dr.GetOrdinal("apMaterno"))), "", "", _
                                CChar(dr.Item("Tipo")), True)
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

        Return o
    End Function

    Public Sub CambiarClave(ByVal Obj As USUARIO, ByVal wclaveNueva As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aUsuarioClave", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Codigo", Obj.Codigo)
            '.AddWithValue("@Nombre", Obj.Nombre)
            .AddWithValue("@ContraseniaNueva", wclaveNueva)
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

    Public Sub registrar(ByVal usuario As USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iUsuario", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoPersona", usuario.Persona.cod_Persona)
            .AddWithValue("@nombreUsuario", usuario.Nombre)
            .AddWithValue("@contrasenia", usuario.Contrasenia)
            .AddWithValue("@tipo", usuario.Tipo)
            .AddWithValue("@vigencia", usuario.Vigencia)

            .AddWithValue("@Template", usuario.Template)
            .AddWithValue("@Template10", usuario.Template10)
            .AddWithValue("@FOTO", usuario.HUELLA_FOTO)
            .AddWithValue("@MAR_DNI", usuario.MAR_DNI)
            .AddWithValue("@MAR_HUELLA", usuario.MAR_HUELLA)
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

    Public Function verifica(ByVal dni As String) As TRABAJADOR
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lUsuariot", cn)
        Dim dr As SqlDataReader = Nothing
        Dim p As TRABAJADOR = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                p = New TRABAJADOR(CInt(dr.Item("dni")))
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
    Public Function Leer(ByVal wpro As String) As List(Of TRABAJADOR)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liUsuariot", cn)
        Dim dr As SqlDataReader = Nothing
        Dim la As New List(Of TRABAJADOR)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombreUsuario", wpro)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read

                la.Add(New TRABAJADOR(dr.Item("dni").ToString, dr.Item("apellidopaterno").ToString, dr.Item("apellidomaterno").ToString, dr.Item("nombres").ToString, dr.Item("telefono").ToString, dr.Item("tiene").ToString, CStr(dr.Item("template")), CStr(dr.Item("template10")), CType(IIf(IsDBNull(dr.Item("huella_foto")) = True, Nothing, dr.Item("huella_foto")), Byte()), CBool(dr.Item("mar_huella")), CBool(dr.Item("mar_dni"))))

                'la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), _
                '                   New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString), _
                '                  dr.Item("nombreUsuario").ToString, "", CChar(dr.Item("tipo")), CBool(dr.Item("vigencia"))))

                'la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), _
                '                   New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString), _
                '                  dr.Item("nombreUsuario").ToString, "", CChar(dr.Item("tipo")), CBool(dr.Item("vigencia")), _
                '                  CStr(dr.Item("Template")), CStr(dr.Item("Template10")), CType(IIf(IsDBNull(dr.Item("HUELLA_FOTO")) = True, Nothing, dr.Item("HUELLA_FOTO")), Byte()), CBool(dr.Item("MAR_HUELLA")), CBool(dr.Item("MAR_DNI"))))

            End While
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
        Return la

    End Function
    Public Function filtrodb(ByVal wpro As String) As List(Of TRABAJADOR)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liUsuariofiltro", cn)
        Dim dr As SqlDataReader = Nothing
        Dim la As New List(Of TRABAJADOR)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombreUsuario", wpro)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read

                la.Add(New TRABAJADOR(dr.Item("dni").ToString, dr.Item("apellidopaterno").ToString, dr.Item("apellidomaterno").ToString, dr.Item("nombres").ToString, dr.Item("telefono").ToString, dr.Item("tiene").ToString, CStr(dr.Item("template")), CStr(dr.Item("template10")), CType(IIf(IsDBNull(dr.Item("huella_foto")) = True, Nothing, dr.Item("huella_foto")), Byte()), CBool(dr.Item("mar_huella")), CBool(dr.Item("mar_dni"))))

                'la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), _
                '                   New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString), _
                '                  dr.Item("nombreUsuario").ToString, "", CChar(dr.Item("tipo")), CBool(dr.Item("vigencia"))))

                'la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), _
                '                   New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString), _
                '                  dr.Item("nombreUsuario").ToString, "", CChar(dr.Item("tipo")), CBool(dr.Item("vigencia")), _
                '                  CStr(dr.Item("Template")), CStr(dr.Item("Template10")), CType(IIf(IsDBNull(dr.Item("HUELLA_FOTO")) = True, Nothing, dr.Item("HUELLA_FOTO")), Byte()), CBool(dr.Item("MAR_HUELLA")), CBool(dr.Item("MAR_DNI"))))

            End While
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
        Return la

    End Function
    Function Filtro(ByVal busqueda As String) As DataTable

        Dim cn As New SqlConnection(My.Settings.conexion)
        cn.Open()
        Dim dt As New DataTable
        Dim dr As SqlDataReader = Nothing
        Dim da As New SqlDataAdapter("SELECT dni,apellidopaterno,apellidomaterno,nombres,telefono,tiene FROM trabajadores WHERE apellidopaterno LIKE '%" & busqueda & "%'", cn)
        da.Fill(dt)
        cn.Close()

        Return dt
    End Function

    Public Sub Modificar(ByVal usuario As TRABAJADOR)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aUsuariot", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@dni", usuario.dni)
            .AddWithValue("@tiene", usuario.tiene)
            .AddWithValue("@Template", usuario.Template)
            .AddWithValue("@Template10", usuario.Template10)
            .AddWithValue("@FOTO", usuario.HUELLA_FOTO)
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
    Public Sub registrar2(ByVal usuario As USUARIO, ByVal grupo As GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iUsuario_Grupo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoUsu", usuario.Codigo)
            .AddWithValue("@codigoGrupoUsu", grupo.Codigo)
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
    Public Sub Eliminar(ByVal usuario As USUARIO, ByVal grupo As GRUPO_USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_eUsuario_Grupo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoUsu", usuario.Codigo)
            .AddWithValue("@codigoGrupoUsu", grupo.Codigo)
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
    Public Function PersonaUsuario(ByVal wpro As Integer) As List(Of USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liPersonaUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        Dim la As New List(Of USUARIO)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoPersona", wpro)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), dr.Item("nombreUsuario").ToString))

            End While
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
        Return la

    End Function
    Public Function Listar(ByVal wNombre As String) As List(Of USUARIO)
        Dim la As New List(Of USUARIO)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liUsuarios", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Nombre", wNombre)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            While dr.Read
                la.Add(New USUARIO(CInt(dr.Item("codigoUsu")), New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString), dr.Item("nombreUsuario").ToString, "", "L"c, False))
            End While

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

        Return la
    End Function

    Public Function Listar_personal_huella() As List(Of TRABAJADOR)
        Dim la As New List(Of TRABAJADOR)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_consultar_personal_huella", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader

            While dr.Read
                la.Add(New TRABAJADOR(CInt(dr.Item("dni")), dr.Item("Template").ToString, dr.Item("Template10").ToString))
            End While

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

        Return la
    End Function
    Public Function LeerxNroDoc(ByVal wpro As String) As TRABAJADOR
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_LeerxNroDoc", cn)
        Dim dr As SqlDataReader = Nothing
        Dim o As TRABAJADOR = Nothing


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", wpro)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                o = New TRABAJADOR(dr.Item("id").ToString, CInt(dr.Item("dni")), dr.Item("apellidopaterno").ToString, dr.Item("apellidomaterno").ToString, dr.Item("nombres").ToString, _
                                  CStr(dr.Item("Template")), CStr(dr.Item("Template10")), CType(IIf(IsDBNull(dr.Item("huella_foto")) = True, Nothing, dr.Item("huella_foto")), Byte()), CBool(dr.Item("MAR_DNI")), CBool(dr.Item("MAR_HUELLA")))
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

        Return o

    End Function
    Public Function LeerxNroDocxID(ByVal wcod As Integer) As DataTable
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_LeerDnixId", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@id", wcod)
            End With
            Dim dt As New DataTable
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function



End Class