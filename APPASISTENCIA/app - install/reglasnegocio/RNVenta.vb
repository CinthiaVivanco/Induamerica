Public Class RNVenta

    Public Function Registrar(ByVal wVenta As Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iVenta", cn)
        Dim codigo As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Venta", 0).Direction = ParameterDirection.Output
            .AddWithValue("@fecha", wVenta.fecha)
            .AddWithValue("@tipopago", wVenta.tipopago)
            .AddWithValue("@subtotal", wVenta.subtotal)
            .AddWithValue("@igv", wVenta.igv)
            .AddWithValue("@descuento", wVenta.descuento)
            .AddWithValue("@total", wVenta.total)
            .AddWithValue("@acuenta", wVenta.acuenta)
            .AddWithValue("@saldo", wVenta.saldo)
            .AddWithValue("@NroDoc", wVenta.NroDoc)
            .AddWithValue("@estado", wVenta.estado)
            .AddWithValue("@cod_Cliente", wVenta.cod_Cliente)
            .AddWithValue("@cod_Comprobante", wVenta.cod_Comprobante)
            .AddWithValue("@usuario", wVenta.Usuario)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_Venta").Value)
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
	Public Sub Modificar(Byval wVenta AS Venta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aVenta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Venta", wVenta.cod_Venta)
            .AddWithValue("@fecha", wVenta.fecha)
            .AddWithValue("@tipopago", wVenta.tipopago)
            .AddWithValue("@subtotal", wVenta.subtotal)
            .AddWithValue("@igv", wVenta.igv)
            .AddWithValue("@descuento", wVenta.descuento)
            .AddWithValue("@total", wVenta.total)
            .AddWithValue("@acuenta", wVenta.acuenta)
            .AddWithValue("@saldo", wVenta.saldo)
            .AddWithValue("@NroDoc", wVenta.NroDoc)
            .AddWithValue("@estado", wVenta.estado)
            .AddWithValue("@cod_Cliente", wVenta.cod_Cliente)
            .AddWithValue("@cod_Comprobante", wVenta.cod_Comprobante)
            .AddWithValue("@usuario", wVenta.Usuario)
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
	Public Function Leer(Byval wVenta AS Venta) AS Venta
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lVenta", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Venta = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Venta", wVenta.cod_Venta)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Venta(wVenta.cod_Venta, CDate(dr.Item("fecha")), CStr(dr.Item("tipopago")), CDbl(dr.Item("subtotal")), CDbl(dr.Item("igv")), CDbl(dr.Item("descuento")), CDbl(dr.Item("total")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CStr(dr.Item("NroDoc")), CStr(dr.Item("estado")), CInt(dr.Item("cod_Cliente")), CInt(dr.Item("cod_Comprobante")), CStr(dr.Item("usuario")))
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

    Public Function ListarVentaFecha(ByVal fecha As Date) As List(Of Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_ListarVenta_Fecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Venta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fecha", fecha)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Venta)
            Do While (dr.Read)
                ListP.Add(New Venta(CInt(dr.Item("cod_Venta")), CDate(dr.Item("fecha")), CStr(dr.Item("tipopago")), CDbl(dr.Item("subtotal")), CDbl(dr.Item("igv")), CDbl(dr.Item("descuento")), CDbl(dr.Item("total")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CStr(dr.Item("NroDoc")), CStr(dr.Item("estado")), CInt(dr.Item("cod_Cliente")), CInt(dr.Item("cod_Comprobante")), CStr(dr.Item("usuario")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno"))))
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