Public Class RNGasto
     
	Public Sub Registrar(Byval wGasto AS Gasto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iGasto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@FechaEmision", wGasto.FechaEmision)
			.AddWithValue("@Ruc", wGasto.Ruc)
			.AddWithValue("@RazonSocial", wGasto.RazonSocial)
			.AddWithValue("@NroDocumento", wGasto.NroDocumento)
			.AddWithValue("@NroCuenta", wGasto.NroCuenta)
			.AddWithValue("@Monto", wGasto.Monto)
            .AddWithValue("@Igv", wGasto.Igv)
            .AddWithValue("@Retencion", wGasto.Retencion)
            .AddWithValue("@TotalPagado", wGasto.TotalPagado)

			.AddWithValue("@Descripcion", wGasto.Descripcion)
			.AddWithValue("@cod_TipoGasto", wGasto.cod_TipoGasto)
			.AddWithValue("@cod_TipoDoc", wGasto.cod_TipoDoc)
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
    Public Sub Modificar(ByVal wGasto As Gasto)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aGasto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_gasto", wGasto.cod_gasto)
            .AddWithValue("@FechaEmision", wGasto.FechaEmision)
            .AddWithValue("@Ruc", wGasto.Ruc)
            .AddWithValue("@RazonSocial", wGasto.RazonSocial)
            .AddWithValue("@NroDocumento", wGasto.NroDocumento)
            .AddWithValue("@NroCuenta", wGasto.NroCuenta)
            .AddWithValue("@Monto", wGasto.Monto)
            .AddWithValue("@Igv", wGasto.Igv)
            .AddWithValue("@Retencion", wGasto.Retencion)
            .AddWithValue("@TotalPagado", wGasto.TotalPagado)

            .AddWithValue("@Descripcion", wGasto.Descripcion)
            .AddWithValue("@cod_TipoGasto", wGasto.cod_TipoGasto)
            .AddWithValue("@cod_TipoDoc", wGasto.cod_TipoDoc)
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


    Public Sub Eliminar(ByVal wGasto As Gasto)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_eGasto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_gasto", wGasto.cod_gasto)
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

	Public Function Leer(Byval wGasto AS Gasto) AS Gasto
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lGasto", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Gasto = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_gasto", wGasto.cod_gasto)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Gasto(wGasto.cod_gasto, CDate(dr.Item("FechaEmision")), CStr(dr.Item("Ruc")), CStr(dr.Item("RazonSocial")), CStr(dr.Item("NroDocumento")), CStr(dr.Item("NroCuenta")), CDbl(dr.Item("Monto")), CDbl(dr.Item("Igv")), CDbl(dr.Item("Retencion")), CDbl(dr.Item("TotalPagado")), CStr(dr.Item("Descripcion")), CInt(dr.Item("cod_TipoGasto")), CInt(dr.Item("cod_TipoDoc")))
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
    Public Function ListarxFecha(ByVal xFecha As Date) As List(Of Gasto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liGastoxFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Gasto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@FechaEmision", xFecha)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Gasto)
            Do While (dr.Read)


                ListP.Add(New Gasto(CInt(dr.Item("cod_gasto")), CStr(dr.Item("Descripcion")), CStr(dr.Item("NroDocumento")), CDbl(dr.Item("TotalPagado"))))

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
    Public Function ListarxRangoFecha(ByVal xFecha1 As Date, ByVal xFecha2 As Date) As List(Of Gasto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liGastoxRangoFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Gasto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Fechaini", xFecha1)
        cmd.Parameters.AddWithValue("@Fechafin", xFecha2)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Gasto)
            Do While (dr.Read)


                ListP.Add(New Gasto(CInt(dr.Item("cod_gasto")), CStr(dr.Item("Descripcion")), CStr(dr.Item("NroDocumento")), CDbl(dr.Item("TotalPagado"))))

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