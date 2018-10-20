Public Class RNSESION

	Public Sub Registrar(Byval wSESION AS SESION)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iSESION", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@fechaIni", wSESION.fechaIni)
			.AddWithValue("@fechaFin", wSESION.fechaFin)
			.AddWithValue("@codigoUsu", wSESION.codigoUsu)
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
	Public Sub Modificar(Byval wSESION AS SESION)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aSESION", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoSesion", wSESION.codigoSesion)
			.AddWithValue("@fechaIni", wSESION.fechaIni)
			.AddWithValue("@fechaFin", wSESION.fechaFin)
			.AddWithValue("@codigoUsu", wSESION.codigoUsu)
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
	Public Function Leer(Byval wSESION AS SESION) AS SESION
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lSESION", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As SESION = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoSesion", wSESION.codigoSesion)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New SESION( wSESION.codigoSesion,CDate( dr.Item("fechaIni") ),CDate( dr.Item("fechaFin") ),CInt( dr.Item("codigoUsu") ) )
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