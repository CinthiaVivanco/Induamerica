Public Class RNPaciente

    Public Function Registrar(ByVal wPaciente As Paciente) As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iPaciente", cn)
        Dim codigo As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Cod_Paciente", 0).Direction = ParameterDirection.Output
            .AddWithValue("@nombre", wPaciente.nombre)
            .AddWithValue("@apPaterno", wPaciente.apPaterno)
            .AddWithValue("@dni", wPaciente.dni)
            .AddWithValue("@sexo", wPaciente.sexo)
            .AddWithValue("@edad", wPaciente.edad)
            .AddWithValue("@fechaNac", wPaciente.fechaNac)
            .AddWithValue("@direccion", wPaciente.direccion)
            .AddWithValue("@telefono", wPaciente.telefono)
            .AddWithValue("@mail", wPaciente.mail)
            .AddWithValue("@celular", wPaciente.celular)
            .AddWithValue("@estado", wPaciente.estado)
            .AddWithValue("@cod_Distrito", wPaciente.cod_Distrito)
            .AddWithValue("@cod_Provincia", wPaciente.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPaciente.cod_Departamento)
            .AddWithValue("@apMaterno", wPaciente.apMaterno)
            .AddWithValue("@tipodoc", wPaciente.TipoDoc)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@Cod_Paciente").Value)
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

        Return codigo
    End Function
	Public Sub Modificar(Byval wPaciente AS Paciente)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aPaciente", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@cod_Paciente", wPaciente.cod_Persona)
            .AddWithValue("@nombre", wPaciente.nombre)
            .AddWithValue("@apPaterno", wPaciente.apPaterno)
            .AddWithValue("@dni", wPaciente.dni)
            .AddWithValue("@sexo", wPaciente.sexo)
            .AddWithValue("@edad", wPaciente.edad)
            .AddWithValue("@fechaNac", wPaciente.fechaNac)
            .AddWithValue("@direccion", wPaciente.direccion)
            .AddWithValue("@telefono", wPaciente.telefono)
            .AddWithValue("@mail", wPaciente.mail)
            .AddWithValue("@celular", wPaciente.celular)
            .AddWithValue("@estado", wPaciente.estado)
            .AddWithValue("@cod_Distrito", wPaciente.cod_Distrito)
            .AddWithValue("@cod_Provincia", wPaciente.cod_Provincia)
            .AddWithValue("@cod_Departamento", wPaciente.cod_Departamento)
            .AddWithValue("@apMaterno", wPaciente.apMaterno)
            .AddWithValue("@tipodoc", wPaciente.TipoDoc)

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
	Public Function Leer(Byval wPaciente AS Paciente) AS Paciente
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lPaciente", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Paciente = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Cod_Paciente", wPaciente.Cod_Paciente)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Paciente(wPaciente.Cod_Paciente, CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), CStr(dr.Item("edad")), CDate(dr.Item("fechaNac")),
                                 CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")), CStr(dr.Item("apMaterno")))
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of Paciente)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPaciente_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Paciente) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Paciente)
            Do While (dr.Read)
                ListP.Add(New Paciente(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni"))))

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
    Public Function ListarxDni(ByVal dni As String) As List(Of Paciente)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPaciente_Dni", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Paciente) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Paciente)
            Do While (dr.Read)
                ListP.Add(New Paciente(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni"))))

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
