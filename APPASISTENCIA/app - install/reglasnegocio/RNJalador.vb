Public Class RNJalador


    Public Sub Registrar(ByVal wjalador As Jalador)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iContacto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters

            .AddWithValue("@nombre", wjalador.nombre)
            .AddWithValue("@apPaterno", wjalador.apPaterno)
            .AddWithValue("@dni", wjalador.dni)
            .AddWithValue("@sexo", wjalador.sexo)
            .AddWithValue("@edad", wjalador.edad)
            .AddWithValue("@fechaNac", wjalador.fechaNac)
            .AddWithValue("@direccion", wjalador.direccion)
            .AddWithValue("@telefono", wjalador.telefono)
            .AddWithValue("@mail", wjalador.mail)
            .AddWithValue("@celular", wjalador.celular)
            .AddWithValue("@estado", wjalador.estado)
            .AddWithValue("@cod_Distrito", wjalador.cod_Distrito)
            .AddWithValue("@cod_Provincia", wjalador.cod_Provincia)
            .AddWithValue("@cod_Departamento", wjalador.cod_Departamento)
            .AddWithValue("@apMaterno", wjalador.apMaterno)
            .AddWithValue("@comision", wjalador.comision)
            .AddWithValue("@tipodoc", wjalador.TipoDoc)

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
	Public Sub Modificar(Byval wJalador AS Jalador)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aJalador", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            '.AddWithValue("@comision", wJalador.comision)
            .AddWithValue("@Cod_Jalador", wJalador.Cod_Jalador)

            .AddWithValue("@nombre", wJalador.nombre)
            .AddWithValue("@apPaterno", wJalador.apPaterno)
            .AddWithValue("@dni", wJalador.dni)
            .AddWithValue("@sexo", wJalador.sexo)
            .AddWithValue("@edad", wJalador.edad)
            .AddWithValue("@fechaNac", wJalador.fechaNac)
            .AddWithValue("@direccion", wJalador.direccion)
            .AddWithValue("@telefono", wJalador.telefono)
            .AddWithValue("@mail", wJalador.mail)
            .AddWithValue("@celular", wJalador.celular)
            .AddWithValue("@estado", wJalador.estado)
            .AddWithValue("@cod_Distrito", wJalador.cod_Distrito)
            .AddWithValue("@cod_Provincia", wJalador.cod_Provincia)
            .AddWithValue("@cod_Departamento", wJalador.cod_Departamento)
            .AddWithValue("@apMaterno", wJalador.apMaterno)
            .AddWithValue("@comision", wJalador.comision)
            .AddWithValue("@tipodoc", wJalador.TipoDoc)

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
	Public Function Leer(Byval wJalador AS Jalador) AS Jalador
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lJalador", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Jalador = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Jalador", wJalador.Cod_Jalador)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then

                dato = New Jalador(wJalador.cod_Persona, CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), CStr(dr.Item("edad")), CDate(dr.Item("fechaNac")),
                                 CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")),
                                CStr(dr.Item("apMaterno")), dr.Item("comision"), dr.Item("cod_Jalador"))
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of Jalador)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarJalador_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Jalador) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Jalador)
            Do While (dr.Read)
                ListP.Add(New Jalador(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("comision")))

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
    Public Function ListarxDni(ByVal dni As String) As List(Of Jalador)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarJalador_Dni", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Jalador) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Jalador)
            Do While (dr.Read)
                ListP.Add(New Jalador(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("comision")))

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
    Public Function Listar() As List(Of Jalador)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarJalador", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Jalador) = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Jalador)
            Do While (dr.Read)
                ListP.Add(New Jalador(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno"))))

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