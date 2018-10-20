Public Class RNplanilla

    Public Sub Registrar(ByVal wplanilla As planilla, ByVal wfechaIni As Date, ByVal wFechaFin As Date)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iplanilla", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wplanilla.periodoid)
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

	Public Sub Modificar(Byval wplanilla AS planilla)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aplanilla", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wplanilla.periodoid)
			.AddWithValue("@codigoPersonal", wplanilla.codigoPersonal)
            .AddWithValue("@sbruto", wplanilla.sbruto)
			.AddWithValue("@dias", wplanilla.dias)
            .AddWithValue("@feriados", wplanilla.feriados)
			.AddWithValue("@rentaquinta", wplanilla.rentaquinta)
			.AddWithValue("@codafp", wplanilla.codafp)
            .AddWithValue("@bono", wplanilla.bono)
			.AddWithValue("@adelanto", wplanilla.adelanto)
			.AddWithValue("@dcto", wplanilla.dcto)
			.AddWithValue("@neto", wplanilla.neto)
			.AddWithValue("@estado", wplanilla.estado)
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
	Public Function Leer(Byval wplanilla AS planilla) AS planilla
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lplanilla", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As planilla = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New planilla(CStr(dr.Item("periodoid")), CInt(dr.Item("codigoPersonal")), CStr(dr.Item("planilla")), CStr(dr.Item("jornada")), CDbl(dr.Item("basico")), CDbl(dr.Item("asigfam")), CDbl(dr.Item("costoxdia")), CDbl(dr.Item("sbruto")), CDbl(dr.Item("dias")), CDbl(dr.Item("faltas")), CDbl(dr.Item("feriados")), CDbl(dr.Item("rentaquinta")), CStr(dr.Item("codafp")), CDbl(dr.Item("afpfondo")), CDbl(dr.Item("afpseguro")), CDbl(dr.Item("afpcomision")), CDbl(dr.Item("essalud")), CDbl(dr.Item("bono")), CDbl(dr.Item("adelanto")), CDbl(dr.Item("dcto")), CDbl(dr.Item("neto")), CStr(dr.Item("estado")))
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

    Public Function LeerxPersonal(ByVal wplanilla As planilla) As planilla
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lplanillaxPersonal", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As planilla = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wplanilla.periodoid)
            .AddWithValue("@codigoPersonal", wplanilla.codigoPersonal)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New planilla(CStr(dr.Item("periodoid")), CInt(dr.Item("codigoPersonal")), CStr(dr.Item("planilla")), CStr(dr.Item("jornada")), CDbl(dr.Item("basico")), CDbl(dr.Item("asigfam")), CDbl(dr.Item("costoxdia")), CDbl(dr.Item("sbruto")), CDbl(dr.Item("dias")), CDbl(dr.Item("faltas")), CDbl(dr.Item("feriados")), CDbl(dr.Item("rentaquinta")), CStr(dr.Item("codafp")), CDbl(dr.Item("afpfondo")), CDbl(dr.Item("afpseguro")), CDbl(dr.Item("afpcomision")), CDbl(dr.Item("essalud")), CDbl(dr.Item("bono")), CDbl(dr.Item("adelanto")), CDbl(dr.Item("dcto")), CDbl(dr.Item("neto")), CStr(dr.Item("estado")))
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

    Public Function ListarxPeriodo(ByVal periodoid As String) As List(Of planilla)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liPlanillaxPeriodo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of planilla) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", periodoid)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of planilla)
            Do While (dr.Read)
                ListP.Add(New planilla(CStr(dr.Item("periodoid")), CInt(dr.Item("codigoPersonal")), CStr(dr.Item("planilla")), CStr(dr.Item("jornada")), CDbl(dr.Item("basico")), CDbl(dr.Item("asigfam")), CDbl(dr.Item("costoxdia")), CDbl(dr.Item("sbruto")), CDbl(dr.Item("dias")), CDbl(dr.Item("faltas")), CDbl(dr.Item("feriados")), CDbl(dr.Item("rentaquinta")), CStr(dr.Item("codafp")), CDbl(dr.Item("afpfondo")), CDbl(dr.Item("afpseguro")), CDbl(dr.Item("afpcomision")), CDbl(dr.Item("essalud")), CDbl(dr.Item("bono")), CDbl(dr.Item("adelanto")), CDbl(dr.Item("dcto")), CDbl(dr.Item("neto")), CStr(dr.Item("estado")), CStr(dr.Item("APPATERNO")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre"))))

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