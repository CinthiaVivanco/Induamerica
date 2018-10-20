Public Class RNPersona

	Public Sub Registrar(Byval wPersona AS Persona)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iPersona", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wPersona.nombre)
			.AddWithValue("@apPaterno", wPersona.apPaterno)
            .AddWithValue("@dni", wPersona.dni)
            .AddWithValue("@sexo", wPersona.sexo)
            .AddWithValue("@edad", wPersona.edad)
            .AddWithValue("@fechaNac", wPersona.fechaNac)
            .AddWithValue("@direccion", wPersona.direccion)
			.AddWithValue("@telefono", wPersona.telefono)
			.AddWithValue("@mail", wPersona.mail)
			.AddWithValue("@celular", wPersona.celular)
			.AddWithValue("@estado", wPersona.estado)
			.AddWithValue("@cod_Distrito", wPersona.cod_Distrito)
			.AddWithValue("@cod_Provincia", wPersona.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPersona.cod_Departamento)
            .AddWithValue("@apMaterno", wPersona.apMaterno)
        End With

		Try
			cn.Open()
			cmd.ExecuteNonQuery()
		Catch ex AS Exception
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
	Public Sub Modificar(Byval wPersona AS Persona)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aPersona", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Persona", wPersona.cod_Persona)
			.AddWithValue("@nombre", wPersona.nombre)
            .AddWithValue("@apPaterno", wPersona.apPaterno)

            .AddWithValue("@dni", wPersona.dni)
            .AddWithValue("@sexo", wPersona.sexo)
            .AddWithValue("@edad", wPersona.edad)
            .AddWithValue("@fechaNac", wPersona.fechaNac)
			.AddWithValue("@direccion", wPersona.direccion)
			.AddWithValue("@telefono", wPersona.telefono)
			.AddWithValue("@mail", wPersona.mail)
			.AddWithValue("@celular", wPersona.celular)
			.AddWithValue("@estado", wPersona.estado)
			.AddWithValue("@cod_Distrito", wPersona.cod_Distrito)
			.AddWithValue("@cod_Provincia", wPersona.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPersona.cod_Departamento)
            .AddWithValue("@apMaterno", wPersona.apMaterno)


		End With

		Try
			cn.Open()
			cmd.ExecuteNonQuery()
		Catch ex AS Exception
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
    Public Function LeerCerin() As Persona
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_LeerCerin", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Persona = Nothing
        cmd.CommandType = CommandType.StoredProcedure


        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Persona(CInt(dr.Item("cod_persona")), CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), dr.Item("edad"), CStr(dr.Item("fechaNac")), CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")), CStr(dr.Item("apMaterno")))
            End If
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
        Return dato
    End Function

    Public Function Leer(ByVal cod_persona As Integer) As Persona
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_LeerPersona", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Persona = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .AddWithValue("@codPersona", cod_persona)


        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Persona(CInt(dr.Item("cod_persona")), CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), dr.Item("edad"), CStr(dr.Item("fechaNac")), CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")), CStr(dr.Item("apMaterno")))
            End If
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
        Return dato
    End Function


    Public Function LeerTratante(ByVal cod_persona As Integer) As Persona
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_LeerTratante", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Persona = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .AddWithValue("@codPersona", cod_persona)

        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Persona(CInt(dr.Item("cod_persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), CStr(dr.Item("estado")))
            End If
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
        Return dato
    End Function

    Public Function Listar(ByVal wNombre As String) As List(Of Persona)
        Dim la As New List(Of Persona)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liPersona", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Nombre", wNombre)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            While dr.Read
                la.Add(New Persona(CInt(dr.Item("cod_persona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString))
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

    Public Function ListarPersonal(ByVal wNombre As String) As List(Of Persona)
        Dim la As New List(Of Persona)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liPersonal", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Nombre", wNombre)
        Try
            cn.Open()
            dr = cmd.ExecuteReader

            While dr.Read
                la.Add(New Persona(CInt(dr.Item("cod_persona")), dr.Item("nombre").ToString, dr.Item("apPaterno").ToString, dr.Item("apMaterno").ToString))
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

End Class