Public Class RNSaldo_Consulta

	Public Sub Registrar(Byval wSaldo_Consulta AS Saldo_Consulta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iSaldo_Consulta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@fecha", wSaldo_Consulta.fecha)
            .AddWithValue("@saldo", wSaldo_Consulta.saldo)
            .AddWithValue("@tipopago", wSaldo_Consulta.TipoPago)
            .AddWithValue("@cod_Comprobante", wSaldo_Consulta.cod_Comprobante)
            .AddWithValue("@cod_Consulta", wSaldo_Consulta.cod_Consulta)
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
	Public Sub Modificar(Byval wSaldo_Consulta AS Saldo_Consulta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aSaldo_Consulta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@cod_Saldo", wSaldo_Consulta.cod_Saldo)
            .AddWithValue("@fecha", wSaldo_Consulta.fecha)
            .AddWithValue("@saldo", wSaldo_Consulta.saldo)
            .AddWithValue("@cod_Consulta", wSaldo_Consulta.cod_Consulta)
            .AddWithValue("@TipoPago", wSaldo_Consulta.TipoPago)
            .AddWithValue("@cod_Comprobante", wSaldo_Consulta.cod_Comprobante)
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
	Public Function Leer(Byval wSaldo_Consulta AS Saldo_Consulta) AS Saldo_Consulta
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lSaldo_Consulta", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Saldo_Consulta = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Saldo", wSaldo_Consulta.cod_Saldo)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Saldo_Consulta(wSaldo_Consulta.cod_Saldo, CDate(dr.Item("fecha")), CDbl(dr.Item("saldo")), CInt(dr.Item("cod_Consulta")), CStr(dr.Item("tipopago")), CInt(dr.Item("cod_Comprobante")))
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

    Public Function ListarxConsulta(ByVal wCod_Consulta As Integer) As List(Of Saldo_Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liSaldo_Consulta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Saldo_Consulta) = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_consulta", wCod_Consulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Saldo_Consulta)
            Do While (dr.Read)
                ListP.Add(New Saldo_Consulta(CInt(dr.Item("cod_Saldo")), CDate(dr.Item("fecha")), CDbl(dr.Item("saldo")), CInt(dr.Item("cod_Consulta")), CStr(dr.Item("tipopago")), CInt(dr.Item("cod_Comprobante"))))
 
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