Public Class RNPERSONAL

	Public Sub Registrar(Byval wPERSONAL AS PERSONAL)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iPERSONAL", cn)
		cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@nombre", wPERSONAL.nombre)
            .AddWithValue("@apPaterno", wPERSONAL.apPaterno)
            .AddWithValue("@dni", wPERSONAL.dni)
            .AddWithValue("@sexo", wPERSONAL.sexo)
            .AddWithValue("@edad", wPERSONAL.edad)

            .AddWithValue("@fechaNac", wPERSONAL.fechaNac)
            .AddWithValue("@direccion", wPERSONAL.direccion)
            .AddWithValue("@telefono", wPERSONAL.telefono)
            .AddWithValue("@mail", wPERSONAL.mail)
            .AddWithValue("@celular", wPERSONAL.celular)
            .AddWithValue("@estado", wPERSONAL.Estado)
            .AddWithValue("@cod_Distrito", wPERSONAL.cod_Distrito)
            .AddWithValue("@cod_Provincia", wPERSONAL.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPERSONAL.cod_Departamento)
            .AddWithValue("@apMaterno", wPERSONAL.apMaterno)

            .AddWithValue("@CARGO", wPERSONAL.CARGO)
            .AddWithValue("@jornada", wPERSONAL.jornada)
            .AddWithValue("@Planilla", wPERSONAL.Planilla)
            .AddWithValue("@Ruc", wPERSONAL.Ruc)
            .AddWithValue("@Bruto", wPERSONAL.Bruto)
            .AddWithValue("@AsigFam", wPERSONAL.AsigFam)
            .AddWithValue("@Comision", wPERSONAL.Comision)
            .AddWithValue("@AFP", wPERSONAL.AFP)
            .AddWithValue("@TipoComisionAFP", wPERSONAL.TipoComisionAFP)
            .AddWithValue("@FechaIngreso", wPERSONAL.FechaIngreso)
            .AddWithValue("@FechaSalida", wPERSONAL.FechaSalida)
            .AddWithValue("@EstadoPersonal", wPERSONAL.EstadoPersonal)
            .AddWithValue("@tipodoc", wPERSONAL.TipoDoc)


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
	Public Sub Modificar(Byval wPERSONAL AS PERSONAL)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aPERSONAL", cn)
		cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoPersonal", wPERSONAL.codigoPersonal)
            .AddWithValue("@nombre", wPERSONAL.nombre)
            .AddWithValue("@apPaterno", wPERSONAL.apPaterno)
            .AddWithValue("@dni", wPERSONAL.dni)
            .AddWithValue("@sexo", wPERSONAL.sexo)
            .AddWithValue("@edad", wPERSONAL.edad)
            .AddWithValue("@fechaNac", wPERSONAL.fechaNac)
            .AddWithValue("@direccion", wPERSONAL.direccion)
            .AddWithValue("@telefono", wPERSONAL.telefono)
            .AddWithValue("@mail", wPERSONAL.mail)
            .AddWithValue("@celular", wPERSONAL.celular)
            .AddWithValue("@estado", wPERSONAL.estado)
            .AddWithValue("@cod_Distrito", wPERSONAL.cod_Distrito)
            .AddWithValue("@cod_Provincia", wPERSONAL.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPERSONAL.cod_Departamento)
            .AddWithValue("@apMaterno", wPERSONAL.apMaterno)

            .AddWithValue("@CARGO", wPERSONAL.CARGO)
            .AddWithValue("@jornada", wPERSONAL.jornada)
            .AddWithValue("@Planilla", wPERSONAL.Planilla)
            .AddWithValue("@Ruc", wPERSONAL.Ruc)
            .AddWithValue("@Bruto", wPERSONAL.Bruto)
            .AddWithValue("@AsigFam", wPERSONAL.AsigFam)
            .AddWithValue("@Comision", wPERSONAL.Comision)
            .AddWithValue("@AFP", wPERSONAL.AFP)
            .AddWithValue("@TipoComisionAFP", wPERSONAL.TipoComisionAFP)
            .AddWithValue("@FechaIngreso", wPERSONAL.FechaIngreso)
            .AddWithValue("@FechaSalida", wPERSONAL.FechaSalida)
            .AddWithValue("@EstadoPersonal", wPERSONAL.EstadoPersonal)

            .AddWithValue("@tipodoc", wPERSONAL.TipoDoc)

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

	Public Function Leer(Byval wPERSONAL AS PERSONAL) AS PERSONAL
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lPERSONAL", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As PERSONAL = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoPersonal", wPERSONAL.codigoPersonal)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New PERSONAL(wPERSONAL.cod_Persona, CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), CStr(dr.Item("edad")), CDate(dr.Item("fechaNac")),
                                CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")),
                                CStr(dr.Item("apMaterno")), wPERSONAL.codigoPersonal, CStr(dr.Item("CARGO")), CStr(dr.Item("jornada")), CStr(dr.Item("Planilla")), CStr(dr.Item("Ruc")), CDbl(dr.Item("Bruto")), CDbl(dr.Item("AsigFam")), CDbl(dr.Item("Comision")), CStr(dr.Item("AFP")), CStr(dr.Item("TipoComisionAFP")), CDate(dr.Item("FechaIngreso")), CDate(dr.Item("FechaSalida")), CStr(dr.Item("EstadoPersonal")))


			End If
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
		Return dato
	End Function

    Public Function ListarxNombre(ByVal nombre As String) As List(Of PERSONAL)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPersonal_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of PERSONAL) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of PERSONAL)
            Do While (dr.Read)
                ListP.Add(New PERSONAL(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("cargo")))
            Loop
        Catch ex As Exception
            If ListP IsNot Nothing Then
                ListP.Clear()
            End If
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
        Return ListP
    End Function

    Public Function ListarxDni(ByVal dni As String) As List(Of PERSONAL)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPersonal_Dni", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of PERSONAL) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of PERSONAL)
            Do While (dr.Read)
                ListP.Add(New PERSONAL(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("cargo")))


            Loop
        Catch ex As Exception
            If ListP IsNot Nothing Then
                ListP.Clear()
            End If
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
        Return ListP
    End Function

    Public Function ListarActivos() As List(Of PERSONAL)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPersonal_Activos", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of PERSONAL) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of PERSONAL)
            Do While (dr.Read)
                ListP.Add(New PERSONAL(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("cargo")))
            Loop
        Catch ex As Exception
            If ListP IsNot Nothing Then
                ListP.Clear()
            End If
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
        Return ListP
    End Function

End Class