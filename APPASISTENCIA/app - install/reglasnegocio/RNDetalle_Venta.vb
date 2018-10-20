Public Class RNDetalle_Venta

	Public Sub Registrar(Byval wDetalle_Venta AS Detalle_Venta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Venta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@cod_Venta", wDetalle_Venta.cod_Venta)
            .AddWithValue("@cod_Producto", wDetalle_Venta.cod_Producto)
            .AddWithValue("@cantidad", wDetalle_Venta.cantidad)
            .AddWithValue("@preciounit", wDetalle_Venta.preciounit)
            .AddWithValue("@total", wDetalle_Venta.total)
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
	Public Sub Modificar(Byval wDetalle_Venta AS Detalle_Venta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Venta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@cod_Detalle_Venta", wDetalle_Venta.cod_Detalle_Venta)
            .AddWithValue("@cod_Venta", wDetalle_Venta.cod_Venta)
            .AddWithValue("@cod_Producto", wDetalle_Venta.cod_Producto)
            .AddWithValue("@cantidad", wDetalle_Venta.cantidad)
            .AddWithValue("@preciounit", wDetalle_Venta.preciounit)
            .AddWithValue("@total", wDetalle_Venta.total)
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
	Public Function Leer(Byval wDetalle_Venta AS Detalle_Venta) AS Detalle_Venta
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_Venta", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_Venta = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Detalle_Venta", wDetalle_Venta.cod_Detalle_Venta)
			.AddWithValue("@cod_Venta", wDetalle_Venta.cod_Venta)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Detalle_Venta(wDetalle_Venta.cod_Detalle_Venta, wDetalle_Venta.cod_Venta, CInt(dr.Item("cod_Producto")), CInt(dr.Item("cantidad")), CDbl(dr.Item("preciounit")), CDbl(dr.Item("total")))

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

    Public Function ListarxCodConVenta(ByVal wVenta As Venta) As List(Of Detalle_Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDVxCodVenta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Venta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_venta", wVenta.cod_Venta)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Venta)
            Do While (dr.Read)
                ListP.Add(New Detalle_Venta(CInt(dr.Item("cod_Detalle_Venta")), CInt(dr.Item("cod_Venta")), CInt(dr.Item("cod_Producto")), CInt(dr.Item("cantidad")), CDbl(dr.Item("preciounit")), CDbl(dr.Item("total")), CStr(dr.Item("nombreProducto"))))

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