Public Class RNPagoMedico

    Public Sub Registrar(ByVal wPagoMedico As PagoMedico, wfechaIni As Date, wFechaFin As Date)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iPagoMedico", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wPagoMedico.periodoid)
            .AddWithValue("@Cod_Medico", wPagoMedico.Cod_Medico)
            .AddWithValue("@tipo", wPagoMedico.Tipo)
            .AddWithValue("@FechaIni", wfechaIni)
            .AddWithValue("@FechaFin", wFechaFin)
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


	Public Sub Modificar(Byval wPagoMedico AS PagoMedico)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aPagoMedico", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_PagoMedico", wPagoMedico.cod_PagoMedico)
			.AddWithValue("@periodoid", wPagoMedico.periodoid)
			.AddWithValue("@Cod_Medico", wPagoMedico.Cod_Medico)
			.AddWithValue("@Dcto", wPagoMedico.Dcto)
			.AddWithValue("@Total", wPagoMedico.Total)
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
	Public Function Leer(Byval wPagoMedico AS PagoMedico) AS PagoMedico
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lPagoMedico", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As PagoMedico = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_PagoMedico", wPagoMedico.cod_PagoMedico)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New PagoMedico( wPagoMedico.cod_PagoMedico,CStr( dr.Item("periodoid") ),CInt( dr.Item("Cod_Medico") ),CDbl( dr.Item("Dcto") ),CDbl( dr.Item("Total") ) )
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

    Public Function LeerxPeriodo(ByVal wPagoMedico As PagoMedico) As PagoMedico
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lPagoMedicoxPeriodo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As PagoMedico = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wPagoMedico.periodoid)
            .AddWithValue("@Cod_Medico", wPagoMedico.Cod_Medico)
            .AddWithValue("@tipo", wPagoMedico.Tipo)

        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New PagoMedico(CInt(dr.Item("cod_PagoMedico")), CStr(dr.Item("periodoid")), CInt(dr.Item("Cod_Medico")), CDbl(dr.Item("Dcto")), CDbl(dr.Item("Total")), CStr(dr.Item("tipo")))
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