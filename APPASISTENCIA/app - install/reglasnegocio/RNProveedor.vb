Public Class RNProveedor

	Public Sub Registrar(Byval wProveedor AS Proveedor)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iProveedor", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@ruc", wProveedor.ruc)
			.AddWithValue("@razonsocial", wProveedor.razonsocial)
			.AddWithValue("@nombreComercial", wProveedor.nombreComercial)
			.AddWithValue("@tipoContribuyente", wProveedor.tipoContribuyente)
			.AddWithValue("@Telefono", wProveedor.Telefono)
			.AddWithValue("@direccion", wProveedor.direccion)
			.AddWithValue("@estado", wProveedor.estado)
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
	Public Sub Modificar(Byval wProveedor AS Proveedor)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aProveedor", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Proveedor", wProveedor.cod_Proveedor)
			.AddWithValue("@ruc", wProveedor.ruc)
			.AddWithValue("@razonsocial", wProveedor.razonsocial)
			.AddWithValue("@nombreComercial", wProveedor.nombreComercial)
			.AddWithValue("@tipoContribuyente", wProveedor.tipoContribuyente)
			.AddWithValue("@Telefono", wProveedor.Telefono)
			.AddWithValue("@direccion", wProveedor.direccion)
			.AddWithValue("@estado", wProveedor.estado)
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
	Public Function Leer(Byval wProveedor AS Proveedor) AS Proveedor
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lProveedor", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Proveedor = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Proveedor", wProveedor.cod_Proveedor)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Proveedor( wProveedor.cod_Proveedor,CStr( dr.Item("ruc") ),CStr( dr.Item("razonsocial") ),CStr( dr.Item("nombreComercial") ),CStr( dr.Item("tipoContribuyente") ),CStr( dr.Item("Telefono") ),CStr( dr.Item("direccion") ),CStr( dr.Item("estado") ) )
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

    Public Function Listar() As List(Of Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProveedor", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Proveedor) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Proveedor)
            Do While (dr.Read)
                ListP.Add(New Proveedor(CInt(dr.Item("cod_Proveedor")), CStr(dr.Item("ruc")), CStr(dr.Item("razonsocial")), CStr(dr.Item("nombreComercial")), CStr(dr.Item("tipoContribuyente")), CStr(dr.Item("Telefono")), CStr(dr.Item("direccion")), CStr(dr.Item("estado"))))
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