Public Class RNLocal

	Public Sub Registrar(Byval wLocal AS Local)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iLocal", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wLocal.nombre)
			.AddWithValue("@direccion", wLocal.direccion)
			.AddWithValue("@tipo", wLocal.tipo)
			.AddWithValue("@estado", wLocal.estado)
			.AddWithValue("@cod_Empresa", wLocal.cod_Empresa)
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
	Public Sub Modificar(Byval wLocal AS Local)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aLocal", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_local", wLocal.cod_local)
			.AddWithValue("@nombre", wLocal.nombre)
			.AddWithValue("@direccion", wLocal.direccion)
			.AddWithValue("@tipo", wLocal.tipo)
			.AddWithValue("@estado", wLocal.estado)
			.AddWithValue("@cod_Empresa", wLocal.cod_Empresa)
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
	Public Function Leer(Byval wLocal AS Local) AS Local
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lLocal", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Local = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_local", wLocal.cod_local)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Local( wLocal.cod_local,CStr( dr.Item("nombre") ),CStr( dr.Item("direccion") ),CStr( dr.Item("tipo") ),CStr( dr.Item("estado") ),CInt( dr.Item("cod_Empresa") ) )
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