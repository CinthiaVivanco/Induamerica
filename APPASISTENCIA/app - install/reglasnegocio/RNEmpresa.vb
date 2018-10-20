Public Class RNEmpresa

	Public Sub Registrar(Byval wEmpresa AS Empresa)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iEmpresa", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@razonsocial", wEmpresa.razonsocial)
			.AddWithValue("@ruc", wEmpresa.ruc)
			.AddWithValue("@direccion", wEmpresa.direccion)
			.AddWithValue("@nombrecomercial", wEmpresa.nombrecomercial)
			.AddWithValue("@replegal", wEmpresa.replegal)
			.AddWithValue("@dnireplegal", wEmpresa.dnireplegal)
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
	Public Sub Modificar(Byval wEmpresa AS Empresa)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aEmpresa", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Empresa", wEmpresa.cod_Empresa)
			.AddWithValue("@razonsocial", wEmpresa.razonsocial)
			.AddWithValue("@ruc", wEmpresa.ruc)
			.AddWithValue("@direccion", wEmpresa.direccion)
			.AddWithValue("@nombrecomercial", wEmpresa.nombrecomercial)
			.AddWithValue("@replegal", wEmpresa.replegal)
			.AddWithValue("@dnireplegal", wEmpresa.dnireplegal)
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
	Public Function Leer(Byval wEmpresa AS Empresa) AS Empresa
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lEmpresa", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Empresa = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Empresa", wEmpresa.cod_Empresa)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Empresa( wEmpresa.cod_Empresa,CStr( dr.Item("razonsocial") ),CStr( dr.Item("ruc") ),CStr( dr.Item("direccion") ),CStr( dr.Item("nombrecomercial") ),CStr( dr.Item("replegal") ),CStr( dr.Item("dnireplegal") ) )
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