Public Class RNDetalle_Egreso

	Public Sub Registrar(Byval wDetalle_Egreso AS Detalle_Egreso)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Egreso", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@descripcion", wDetalle_Egreso.descripcion)
			.AddWithValue("@precio", wDetalle_Egreso.precio)
			.AddWithValue("@cod_Egreso", wDetalle_Egreso.cod_Egreso)
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
	Public Sub Modificar(Byval wDetalle_Egreso AS Detalle_Egreso)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Egreso", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_detalle", wDetalle_Egreso.cod_detalle)
			.AddWithValue("@descripcion", wDetalle_Egreso.descripcion)
			.AddWithValue("@precio", wDetalle_Egreso.precio)
			.AddWithValue("@cod_Egreso", wDetalle_Egreso.cod_Egreso)
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
	Public Function Leer(Byval wDetalle_Egreso AS Detalle_Egreso) AS Detalle_Egreso
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_Egreso", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_Egreso = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_detalle", wDetalle_Egreso.cod_detalle)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Detalle_Egreso(wDetalle_Egreso.cod_detalle, CStr(dr.Item("descripcion")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Egreso")))
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

    Public Function ListarxFecha(ByVal xFecha As Date) As List(Of Detalle_Egreso)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liEgresosxFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Egreso) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Fecha", xFecha)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Egreso)
            Do While (dr.Read)
                ListP.Add(New Detalle_Egreso(CInt(dr.Item("cod_Detalle")), CStr(dr.Item("descripcion")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Egreso")), CDate(dr.Item("Fecha")), CStr(dr.Item("Estado")), CDbl(dr.Item("Total"))))

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

    Public Sub Eliminar(ByVal wDetalleEgreso As Detalle_Egreso)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_eDetalleEgreso", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_detalle", wDetalleEgreso.cod_detalle)
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
End Class