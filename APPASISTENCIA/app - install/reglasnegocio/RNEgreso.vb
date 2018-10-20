Public Class RNEgreso

    Public Function Registrar(ByVal wEgreso As Egreso)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iEgreso", cn)
        Dim codigo As Integer = 0


        cmd.CommandType = CommandType.StoredProcedure
        
        With cmd.Parameters
            .AddWithValue("@cod_Egreso", 0).Direction = ParameterDirection.Output
            .AddWithValue("@Fecha", wEgreso.Fecha)
            .AddWithValue("@Total", wEgreso.Total)
            .AddWithValue("@Estado", wEgreso.Estado)
            .AddWithValue("@periodoid", wEgreso.periodoid)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_Egreso").Value)
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
	Public Sub Modificar(Byval wEgreso AS Egreso)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aEgreso", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Egreso", wEgreso.cod_Egreso)
			.AddWithValue("@Fecha", wEgreso.Fecha)
            .AddWithValue("@Total", wEgreso.Total)
            .AddWithValue("@Estado", wEgreso.Estado)
            .AddWithValue("@periodoid", wEgreso.periodoid)
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
	Public Function Leer(Byval wEgreso AS Egreso) AS Egreso
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lEgreso", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Egreso = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Egreso", wEgreso.cod_Egreso)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Egreso(wEgreso.cod_Egreso, CDate(dr.Item("Fecha")), CDbl(dr.Item("Total")), CStr(dr.Item("estado")), CStr(dr.Item("periodoid")))
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