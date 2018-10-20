Public Class RNPeriodo

	Public Sub Registrar(Byval wPeriodo AS Periodo)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iPeriodo", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wPeriodo.periodoid)
			.AddWithValue("@nombre", wPeriodo.nombre)
            .AddWithValue("@FechaInicial", wPeriodo.FechaInicial)
            .AddWithValue("@FechaQuincena", wPeriodo.FechaQuincena)
            .AddWithValue("@FechaFinal", wPeriodo.FechaFinal)
            .AddWithValue("@diaslab", wPeriodo.DiasLaborables)
            .AddWithValue("@feriados", wPeriodo.DiasFeriados)

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
	Public Sub Modificar(Byval wPeriodo AS Periodo)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aPeriodo", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wPeriodo.periodoid)
			.AddWithValue("@nombre", wPeriodo.nombre)
            .AddWithValue("@FechaInicial", wPeriodo.FechaInicial)
            .AddWithValue("@FechaQuincena", wPeriodo.FechaQuincena)
            .AddWithValue("@FechaFinal", wPeriodo.FechaFinal)
            .AddWithValue("@diaslab", wPeriodo.DiasLaborables)
            .AddWithValue("@feriados", wPeriodo.DiasFeriados)
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
	Public Function Leer(Byval wPeriodo AS Periodo) AS Periodo
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lPeriodo", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Periodo = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wPeriodo.periodoid)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                '                dato = New Periodo(wPeriodo.periodoid, CStr(dr.Item("nombre")), CDate(dr.Item("FechaInicial")), CDate(dr.Item("FechaFinal")), CDate(dr.Item("FechaQuincena")))
                dato = New Periodo(wPeriodo.periodoid, CStr(dr.Item("nombre")), CDate(dr.Item("FechaInicial")), CDate(dr.Item("FechaFinal")), CDate(dr.Item("FechaQuincena")), CInt(dr.Item("diaslab")), CInt(dr.Item("feriados")))

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

    Public Function Listar() As List(Of Periodo)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liPeriodo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Periodo) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Periodo)
            Do While (dr.Read)
                ListP.Add(New Periodo(CStr(dr.Item("periodoid")), CStr(dr.Item("nombre")), CDate(dr.Item("FechaInicial")), CDate(dr.Item("FechaFinal")), CDate(dr.Item("FechaQuincena")), CInt(dr.Item("diaslab")), CInt(dr.Item("feriados"))))

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
    Public Function ListarxNombre(ByVal nombre As String) As List(Of Periodo)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liPeriodo_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Periodo) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Periodo)
            Do While (dr.Read)
                '                ListP.Add(New Periodo(CStr(dr.Item("periodoid")), CStr(dr.Item("nombre")), CDate(dr.Item("FechaInicial")), CDate(dr.Item("FechaFinal")), CDate(dr.Item("FechaQuincena"))))
                ListP.Add(New Periodo(CStr(dr.Item("periodoid")), CStr(dr.Item("nombre")), CDate(dr.Item("FechaInicial")), CDate(dr.Item("FechaFinal")), CDate(dr.Item("FechaQuincena")), CInt(dr.Item("diaslab")), CInt(dr.Item("feriados"))))

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