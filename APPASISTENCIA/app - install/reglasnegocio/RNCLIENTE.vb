Public Class RNCLIENTE

	Public Sub Registrar(Byval wCLIENTE AS CLIENTE)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iCLIENTE", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@nombre", wCLIENTE.nombre)
            .AddWithValue("@apPaterno", wCLIENTE.apPaterno)
            .AddWithValue("@dni", wCLIENTE.dni)
            .AddWithValue("@sexo", wCLIENTE.sexo)
            .AddWithValue("@edad", wCLIENTE.edad)
            .AddWithValue("@fechaNac", wCLIENTE.fechaNac)
            .AddWithValue("@direccion", wCLIENTE.direccion)
            .AddWithValue("@telefono", wCLIENTE.telefono)
            .AddWithValue("@mail", wCLIENTE.mail)
            .AddWithValue("@celular", wCLIENTE.celular)
            .AddWithValue("@estado", wCLIENTE.estado)
            .AddWithValue("@cod_Distrito", wCLIENTE.cod_Distrito)
            .AddWithValue("@cod_Provincia", wCLIENTE.cod_Provincia)
            .AddWithValue("@cod_Departamento", wCLIENTE.cod_Departamento)
            .AddWithValue("@apMaterno", wCLIENTE.apMaterno)

            .AddWithValue("@Ruc", wCLIENTE.Ruc)
            .AddWithValue("@tipodoc", wCLIENTE.TipoDoc)

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
	Public Sub Modificar(Byval wCLIENTE AS CLIENTE)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aCLIENTE", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@Cod_Cliente", wCLIENTE.Cod_Cliente)

            .AddWithValue("@nombre", wCLIENTE.nombre)
            .AddWithValue("@apPaterno", wCLIENTE.apPaterno)
            .AddWithValue("@dni", wCLIENTE.dni)
            .AddWithValue("@sexo", wCLIENTE.sexo)
            .AddWithValue("@edad", wCLIENTE.edad)
            .AddWithValue("@fechaNac", wCLIENTE.fechaNac)
            .AddWithValue("@direccion", wCLIENTE.direccion)
            .AddWithValue("@telefono", wCLIENTE.telefono)
            .AddWithValue("@mail", wCLIENTE.mail)
            .AddWithValue("@celular", wCLIENTE.celular)
            .AddWithValue("@estado", wCLIENTE.estado)
            .AddWithValue("@cod_Distrito", wCLIENTE.cod_Distrito)
            .AddWithValue("@cod_Provincia", wCLIENTE.cod_Provincia)
            .AddWithValue("@cod_Departamento", wCLIENTE.cod_Departamento)
            .AddWithValue("@apMaterno", wCLIENTE.apMaterno)

            .AddWithValue("@ruc", wCLIENTE.Ruc)
            .AddWithValue("@tipodoc", wCLIENTE.TipoDoc)

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
	Public Function Leer(Byval wCLIENTE AS CLIENTE) AS CLIENTE
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lCLIENTE", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As CLIENTE = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Cod_Cliente", wCLIENTE.Cod_Cliente)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New CLIENTE(wCLIENTE.cod_Persona, CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), CStr(dr.Item("edad")), CDate(dr.Item("fechaNac")),
                                             CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")),
                                            CStr(dr.Item("apMaterno")), CStr(dr.Item("ruc")), dr.Item("cod_Cliente"))
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of CLIENTE)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCliente_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of CLIENTE) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of CLIENTE)
            Do While (dr.Read)
                ListP.Add(New CLIENTE(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni"))))

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
    Public Function ListarxDni(ByVal dni As String) As List(Of CLIENTE)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCliente_Dni", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of CLIENTE) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of CLIENTE)
            Do While (dr.Read)
                ListP.Add(New CLIENTE(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni"))))

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