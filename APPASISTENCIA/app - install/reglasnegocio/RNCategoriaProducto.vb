Public Class RNCategoriaProducto

	Public Sub Registrar(Byval wCategoriaProducto AS CategoriaProducto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iCategoriaProducto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wCategoriaProducto.nombre)
			.AddWithValue("@estado", wCategoriaProducto.estado)
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
	Public Sub Modificar(Byval wCategoriaProducto AS CategoriaProducto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aCategoriaProducto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_categoria", wCategoriaProducto.cod_categoria)
			.AddWithValue("@nombre", wCategoriaProducto.nombre)
			.AddWithValue("@estado", wCategoriaProducto.estado)
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
	Public Function Leer(Byval wCategoriaProducto AS CategoriaProducto) AS CategoriaProducto
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lCategoriaProducto", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As CategoriaProducto = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_categoria", wCategoriaProducto.cod_categoria)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New CategoriaProducto( wCategoriaProducto.cod_categoria,CStr( dr.Item("nombre") ),CStr( dr.Item("estado") ) )
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

    Public Function Listar() As List(Of CategoriaProducto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liCategoriaProducto", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of CategoriaProducto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
       
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of CategoriaProducto)
            Do While (dr.Read)


                ListP.Add(New CategoriaProducto(CInt(dr.Item("cod_categoria")), CStr(dr.Item("nombre")), CStr(dr.Item("estado"))))


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

    Public Function ListarActivos() As List(Of CategoriaProducto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liCategoriaProductoAct", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of CategoriaProducto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of CategoriaProducto)
            Do While (dr.Read)


                ListP.Add(New CategoriaProducto(CInt(dr.Item("cod_categoria")), CStr(dr.Item("nombre")), CStr(dr.Item("estado"))))


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

    Public Function ListarSinPlacas() As List(Of CategoriaProducto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liCategoriaProductoSinPlacas", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of CategoriaProducto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of CategoriaProducto)
            Do While (dr.Read)


                ListP.Add(New CategoriaProducto(CInt(dr.Item("cod_categoria")), CStr(dr.Item("nombre")), CStr(dr.Item("estado"))))


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