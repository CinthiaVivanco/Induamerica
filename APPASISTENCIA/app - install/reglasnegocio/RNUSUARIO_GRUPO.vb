Public Class RNUSUARIO_GRUPO

	Public Sub Registrar(Byval wUSUARIO_GRUPO AS USUARIO_GRUPO)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iUSUARIO_GRUPO", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoUsu", wUSUARIO_GRUPO.codigoUsu)
			.AddWithValue("@codigoGrupoUsu", wUSUARIO_GRUPO.codigoGrupoUsu)
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
	Public Sub Modificar(Byval wUSUARIO_GRUPO AS USUARIO_GRUPO)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aUSUARIO_GRUPO", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoUsu", wUSUARIO_GRUPO.codigoUsu)
			.AddWithValue("@codigoGrupoUsu", wUSUARIO_GRUPO.codigoGrupoUsu)
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
	Public Function Leer(Byval wUSUARIO_GRUPO AS USUARIO_GRUPO) AS USUARIO_GRUPO
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lUSUARIO_GRUPO", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As USUARIO_GRUPO = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoUsu", wUSUARIO_GRUPO.codigoUsu)
			.AddWithValue("@codigoGrupoUsu", wUSUARIO_GRUPO.codigoGrupoUsu)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New USUARIO_GRUPO( wUSUARIO_GRUPO.codigoUsu, wUSUARIO_GRUPO.codigoGrupoUsu )
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