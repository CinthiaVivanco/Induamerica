Public Class RNInforme

    Public Function Registrar(ByVal wInforme As Informe)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iInforme", cn)
        Dim codigo As Integer

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Cod_Informe", 0).Direction = ParameterDirection.Output
            .AddWithValue("@FechaExamen", wInforme.FechaExamen)
            .AddWithValue("@FechaToma", wInforme.FechaToma)
            .AddWithValue("@Total", wInforme.Total)
            .AddWithValue("@estado", wInforme.estado)
            .AddWithValue("@convenio", wInforme.convenio)
            .AddWithValue("@estado_Pago", wInforme.estado_Pago)
            .AddWithValue("@Cod_Paciente", wInforme.Cod_Paciente)
            .AddWithValue("@cod_Persona", wInforme.cod_Persona)
            .AddWithValue("@autogenerado", wInforme.autogenerado)
            .AddWithValue("@cod_CentroConvenio", wInforme.cod_CentroConvenio)
            .AddWithValue("@MedicoOrden", wInforme.MedicoOrdena)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@Cod_Informe").Value)
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
	Public Sub Modificar(Byval wInforme AS Informe)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aInforme", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Informe", wInforme.cod_Informe)
			.AddWithValue("@FechaExamen", wInforme.FechaExamen)
			.AddWithValue("@FechaToma", wInforme.FechaToma)
			.AddWithValue("@Total", wInforme.Total)
			.AddWithValue("@estado", wInforme.estado)
			.AddWithValue("@convenio", wInforme.convenio)
			.AddWithValue("@estado_Pago", wInforme.estado_Pago)
			.AddWithValue("@Cod_Paciente", wInforme.Cod_Paciente)
			.AddWithValue("@cod_Persona", wInforme.cod_Persona)
			.AddWithValue("@autogenerado", wInforme.autogenerado)
            .AddWithValue("@cod_CentroConvenio", wInforme.cod_CentroConvenio)
            .AddWithValue("@MedicoOrden", wInforme.MedicoOrdena)
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
	Public Function Leer(Byval wInforme AS Informe) AS Informe
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lInforme", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Informe = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Informe", wInforme.cod_Informe)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Informe(wInforme.cod_Informe, CDate(dr.Item("FechaExamen")), CDate(dr.Item("FechaToma")), CDbl(dr.Item("Total")), CStr(dr.Item("estado")), CStr(dr.Item("convenio")), CStr(dr.Item("estado_Pago")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_Persona")), CStr(dr.Item("autogenerado")), CInt(dr.Item("cod_CentroConvenio")), CStr(dr.Item("MedicoOrden")))
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of Informe)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaInformesxNombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Informe) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Informe)
            Do While (dr.Read)
                ListP.Add(New Informe(CInt(dr.Item("cod_Informe")), CDate(dr.Item("FechaExamen")), CStr(dr.Item("estado")), CInt(dr.Item("Cod_Paciente")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), CInt(dr.Item("cod_CentroConvenio")), CStr(dr.Item("Centro"))))


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

    Public Function ListarxFecha(ByVal nombre As Date) As List(Of Informe)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaInformesxFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Informe) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fecha", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Informe)
            Do While (dr.Read)
                ListP.Add(New Informe(CInt(dr.Item("cod_Informe")), CDate(dr.Item("FechaExamen")), CStr(dr.Item("estado")), CInt(dr.Item("Cod_Paciente")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), CInt(dr.Item("cod_CentroConvenio")), CStr(dr.Item("Centro"))))


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