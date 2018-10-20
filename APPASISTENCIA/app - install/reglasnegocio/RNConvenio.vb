Public Class RNConvenio

	Public Sub Registrar(Byval wConvenio AS Convenio)
		Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iConvenio", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Examen", wConvenio.cod_Examen)
			.AddWithValue("@precio", wConvenio.precio)
			.AddWithValue("@FechaInicio", wConvenio.FechaInicio)
			.AddWithValue("@FechaFin", wConvenio.FechaFin)
			.AddWithValue("@estado", wConvenio.estado)
			.AddWithValue("@cod_TipoExamen", wConvenio.cod_TipoExamen)
            .AddWithValue("@cod_CentroConvenio", wConvenio.cod_CentroConvenio)
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
	Public Sub Modificar(Byval wConvenio AS Convenio)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aConvenio", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Convenio", wConvenio.cod_Convenio)
			.AddWithValue("@cod_Examen", wConvenio.cod_Examen)
			.AddWithValue("@precio", wConvenio.precio)
			.AddWithValue("@FechaInicio", wConvenio.FechaInicio)
			.AddWithValue("@FechaFin", wConvenio.FechaFin)
			.AddWithValue("@estado", wConvenio.estado)
            .AddWithValue("@cod_TipoExamen", wConvenio.cod_TipoExamen)
            .AddWithValue("@cod_CentroConvenio", wConvenio.cod_CentroConvenio)
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
	Public Function Leer(Byval wConvenio AS Convenio) AS Convenio
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lConvenio", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Convenio = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Convenio", wConvenio.cod_Convenio)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Convenio(wConvenio.cod_Convenio, CInt(dr.Item("cod_Examen")), dr.Item("precio"), CDate(dr.Item("FechaInicio")), CDate(dr.Item("FechaFin")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")))
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

    Public Function LeerConvenioExamen(ByVal wcodExamen As Integer, ByVal wcodCentro As Integer) As Convenio
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lExamenConvenio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Convenio = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Examen", wcodExamen)
            .AddWithValue("@cod_CentroConvenio", wcodCentro)

        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Convenio(CInt(dr.Item("cod_Convenio")), CInt(dr.Item("cod_Examen")), dr.Item("precio"), CDate(dr.Item("FechaInicio")), CDate(dr.Item("FechaFin")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")))
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
End Class