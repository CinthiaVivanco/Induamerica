Public Class RNAFP

	Public Sub Registrar(Byval wAFP AS AFP)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iAFP", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codAfp", wAFP.codAfp)
			.AddWithValue("@nombre", wAFP.nombre)
			.AddWithValue("@fondo", wAFP.fondo)
			.AddWithValue("@seguro", wAFP.seguro)
			.AddWithValue("@comisionflujo", wAFP.comisionflujo)
			.AddWithValue("@comisionsaldo", wAFP.comisionsaldo)
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
	Public Sub Modificar(Byval wAFP AS AFP)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aAFP", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codAfp", wAFP.codAfp)
			.AddWithValue("@nombre", wAFP.nombre)
			.AddWithValue("@fondo", wAFP.fondo)
			.AddWithValue("@seguro", wAFP.seguro)
			.AddWithValue("@comisionflujo", wAFP.comisionflujo)
			.AddWithValue("@comisionsaldo", wAFP.comisionsaldo)
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
	Public Function Leer(Byval wAFP AS AFP) AS AFP
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lAFP", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As AFP = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .AddWithValue("@codAfp", wAFP.codAfp)
        End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New AFP(CStr(dr.Item("codAfp")), CStr(dr.Item("nombre")), CDbl(dr.Item("fondo")), CDbl(dr.Item("seguro")), CDbl(dr.Item("comisionflujo")), CDbl(dr.Item("comisionsaldo")))
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

    Public Function Listar() As List(Of AFP)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liafp", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of AFP) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of AFP)
            Do While (dr.Read)
                ListP.Add(New AFP(CStr(dr.Item("codAfp")), CStr(dr.Item("nombre")), CDbl(dr.Item("fondo")), CDbl(dr.Item("seguro")), CDbl(dr.Item("comisionflujo")), CDbl(dr.Item("comisionsaldo"))))
                          
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