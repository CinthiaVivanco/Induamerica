Public Class RNProducto

	Public Sub Registrar(Byval wProducto AS Producto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iProducto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wProducto.nombre)
			.AddWithValue("@precio", wProducto.precio)
			.AddWithValue("@estado", wProducto.estado)
			.AddWithValue("@stock", wProducto.stock)
            .AddWithValue("@stockMinimo", wProducto.stockMinimo)
            .AddWithValue("@cod_Unidad", wProducto.cod_Unidad)
			.AddWithValue("@cod_UnidadPres", wProducto.cod_UnidadPres)
			.AddWithValue("@contenido", wProducto.contenido)
            .AddWithValue("@cod_categoria", wProducto.cod_categoria)
            .AddWithValue("@venta", wProducto.venta)

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
	Public Sub Modificar(Byval wProducto AS Producto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aProducto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Producto", wProducto.cod_Producto)
			.AddWithValue("@nombre", wProducto.nombre)
			.AddWithValue("@precio", wProducto.precio)
			.AddWithValue("@estado", wProducto.estado)
            '  .AddWithValue("@stock", wProducto.stock)
            .AddWithValue("@stockMinimo", wProducto.stockMinimo)
            .AddWithValue("@cod_Unidad", wProducto.cod_Unidad)
			.AddWithValue("@cod_UnidadPres", wProducto.cod_UnidadPres)
			.AddWithValue("@contenido", wProducto.contenido)
            .AddWithValue("@cod_categoria", wProducto.cod_categoria)
            .AddWithValue("@venta", wProducto.venta)

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
	Public Function Leer(Byval wProducto AS Producto) AS Producto
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lProducto", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Producto = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Producto", wProducto.cod_Producto)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Producto(wProducto.cod_Producto, CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CInt(dr.Item("cod_UnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria")), CInt(dr.Item("venta")))
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

    Public Function Listar() As List(Of Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProductos", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Producto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Producto)
            Do While (dr.Read)
                ListP.Add(New Producto(CInt(dr.Item("cod_Producto")), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CStr(dr.Item("nombreUnidad")), CInt(dr.Item("cod_UnidadPres")), CStr(dr.Item("nombreUnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria")), CStr(dr.Item("NombreCategoria"))))

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

    Public Function ListarxCategoriaVentas(ByVal codigocat As Integer) As List(Of Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProductosVentas", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Producto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_categoria", codigocat)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Producto)
            Do While (dr.Read)
                ListP.Add(New Producto(CInt(dr.Item("cod_Producto")), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CStr(dr.Item("nombreUnidad")), CInt(dr.Item("cod_UnidadPres")), CStr(dr.Item("nombreUnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria")), CStr(dr.Item("NombreCategoria"))))

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

    Public Function ListarxCategoria(ByVal codigocat As Integer) As List(Of Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProductosxCategoria", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Producto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_categoria", codigocat)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Producto)
            Do While (dr.Read)
                ListP.Add(New Producto(CInt(dr.Item("cod_Producto")), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CInt(dr.Item("cod_UnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria")), CInt(dr.Item("venta"))))

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

    Public Function ListarPlacas(ByVal xcod_ambiente As Integer) As List(Of Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProductosPlacas", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Producto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_ambiente", xcod_ambiente)
        End With



        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Producto)
            Do While (dr.Read)
                ListP.Add(New Producto(CInt(dr.Item("cod_Producto")), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CInt(dr.Item("cod_UnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria"))))

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

    Public Function ListarxAmbiente(ByVal xcod_ambiente As Integer) As List(Of Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liProductosxAmbiente", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Producto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_ambiente", xcod_ambiente)
        End With



        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Producto)
            Do While (dr.Read)
                ListP.Add(New Producto(CInt(dr.Item("cod_Producto")), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CStr(dr.Item("estado")), CInt(dr.Item("stock")), CInt(dr.Item("stockMinimo")), CInt(dr.Item("cod_Unidad")), CInt(dr.Item("cod_UnidadPres")), CInt(dr.Item("contenido")), CInt(dr.Item("cod_categoria"))))

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