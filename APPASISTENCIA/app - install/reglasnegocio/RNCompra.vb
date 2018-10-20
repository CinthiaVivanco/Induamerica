Public Class RNCompra
     
    Public Function Registrar(ByVal wCompra As Compra)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iCompra", cn)
        Dim codigo As Integer = 0

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
             .AddWithValue("@cod_compra", 0).Direction = ParameterDirection.Output
            .AddWithValue("@fecha", wCompra.fecha)
            .AddWithValue("@nrodocumento", wCompra.nrodocumento)
            .AddWithValue("@moneda", wCompra.moneda)
            .AddWithValue("@montototal", wCompra.montototal)
            .AddWithValue("@cod_Proveedor", wCompra.cod_Proveedor)
            .AddWithValue("@estado", wCompra.estado)
            .AddWithValue("@tc", wCompra.TC)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_compra").Value)
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
	Public Sub Modificar(Byval wCompra AS Compra)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aCompra", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_compra", wCompra.cod_compra)
			.AddWithValue("@fecha", wCompra.fecha)
			.AddWithValue("@nrodocumento", wCompra.nrodocumento)
			.AddWithValue("@moneda", wCompra.moneda)
			.AddWithValue("@montototal", wCompra.montototal)
            .AddWithValue("@cod_Proveedor", wCompra.cod_Proveedor)
            .AddWithValue("@estado", wCompra.estado)
            .AddWithValue("@tc", wCompra.TC)
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
	Public Function Leer(Byval wCompra AS Compra) AS Compra
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lCompra", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Compra = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_compra", wCompra.cod_compra)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Compra(wCompra.cod_compra, CDate(dr.Item("fecha")), CStr(dr.Item("nrodocumento")), CStr(dr.Item("moneda")), CDbl(dr.Item("montototal")), CDbl(dr.Item("tc")), CInt(dr.Item("cod_Proveedor")), CStr(dr.Item("estado")))
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