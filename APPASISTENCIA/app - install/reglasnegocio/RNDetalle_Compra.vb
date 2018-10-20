Public Class RNDetalle_Compra

	Public Sub Registrar(Byval wDetalle_Compra AS Detalle_Compra)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Compra", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cantidad", wDetalle_Compra.cantidad)
			.AddWithValue("@precioUnit", wDetalle_Compra.precioUnit)
			.AddWithValue("@Total", wDetalle_Compra.Total)
			.AddWithValue("@cod_Producto", wDetalle_Compra.cod_Producto)
			.AddWithValue("@cod_compra", wDetalle_Compra.cod_compra)
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
	Public Sub Modificar(Byval wDetalle_Compra AS Detalle_Compra)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Compra", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_detalleCompra", wDetalle_Compra.cod_detalleCompra)
			.AddWithValue("@cantidad", wDetalle_Compra.cantidad)
			.AddWithValue("@precioUnit", wDetalle_Compra.precioUnit)
			.AddWithValue("@Total", wDetalle_Compra.Total)
			.AddWithValue("@cod_Producto", wDetalle_Compra.cod_Producto)
			.AddWithValue("@cod_compra", wDetalle_Compra.cod_compra)
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
	Public Function Leer(Byval wDetalle_Compra AS Detalle_Compra) AS Detalle_Compra
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_Compra", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_Compra = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_detalleCompra", wDetalle_Compra.cod_detalleCompra)
			.AddWithValue("@cod_compra", wDetalle_Compra.cod_compra)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Detalle_Compra(wDetalle_Compra.cod_detalleCompra, CInt(dr.Item("cantidad")), CDbl(dr.Item("precioUnit")), CDbl(dr.Item("Total")), CInt(dr.Item("cod_Producto")), wDetalle_Compra.cod_compra)
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

End Class