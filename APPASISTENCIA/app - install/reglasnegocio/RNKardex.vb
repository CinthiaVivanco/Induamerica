Public Class RNKardex

	Public Sub Registrar(Byval wKardex AS Kardex)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iKardex", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@tipo", wKardex.tipo)
            .AddWithValue("@cantidad", wKardex.cantidad)
            .AddWithValue("@cantidadTotal", wKardex.cantidadTotal)
            .AddWithValue("@fecha", wKardex.fecha)
			.AddWithValue("@cod_Producto", wKardex.cod_Producto)
            .AddWithValue("@cod_Ambiente", wKardex.cod_Ambiente)
            .AddWithValue("@cod_detalleMaterial", wKardex.cod_detalleMaterial)
            'nuevo
            .AddWithValue("@UsuarioReg", wKardex.UsuarioReg)
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
    Public Sub RegistrarDM(ByVal wKardex As Kardex)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iKardexDM", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@tipo", wKardex.tipo)
            .AddWithValue("@cantidad", wKardex.cantidad)
            .AddWithValue("@cantidadTotal", wKardex.cantidadTotal)

            .AddWithValue("@fecha", wKardex.fecha)
            .AddWithValue("@cod_Producto", wKardex.cod_Producto)
            .AddWithValue("@cod_Ambiente", wKardex.cod_Ambiente)
            .AddWithValue("@cod_detalleMaterial", wKardex.cod_detalleMaterial)
            .AddWithValue("@UsuarioReg", wKardex.UsuarioReg)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
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
    End Sub

    Public Sub ModificarDM(ByVal wKardex As Kardex)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aKardexDM", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@tipo", wKardex.tipo)
            .AddWithValue("@cantidad", wKardex.cantidad)
            .AddWithValue("@cantidadTotal", wKardex.cantidadTotal)

            .AddWithValue("@fecha", wKardex.fecha)
            .AddWithValue("@cod_Producto", wKardex.cod_Producto)
            .AddWithValue("@cod_Ambiente", wKardex.cod_Ambiente)
            .AddWithValue("@cod_detalleMaterial", wKardex.cod_detalleMaterial)
            .AddWithValue("@UsuarioReg", wKardex.UsuarioReg)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
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
    End Sub

	Public Sub Modificar(Byval wKardex AS Kardex)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aKardex", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_kardex", wKardex.cod_kardex)
			.AddWithValue("@tipo", wKardex.tipo)
            .AddWithValue("@cantidad", wKardex.cantidad)
            .AddWithValue("@cantidadTotal", wKardex.cantidadTotal)
			.AddWithValue("@fecha", wKardex.fecha)
			.AddWithValue("@cod_Producto", wKardex.cod_Producto)
            .AddWithValue("@cod_Ambiente", wKardex.cod_Ambiente)

            .AddWithValue("@UsuarioReg", wKardex.UsuarioReg)

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
	Public Function Leer(Byval wKardex AS Kardex) AS Kardex
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lKardex", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Kardex = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_kardex", wKardex.cod_kardex)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Kardex(wKardex.cod_kardex, CStr(dr.Item("tipo")), CInt(dr.Item("cantidad")), CInt(dr.Item("cantidadTotal")), CDate(dr.Item("fecha")), CInt(dr.Item("cod_Producto")), CInt(dr.Item("cod_Ambiente")))
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

    Public Function LeerxDM(ByVal wcodDetMat As Integer) As Kardex
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lKardexxDetMat", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Kardex = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleMaterial", wcodDetMat)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Kardex(CInt(dr.Item("cod_kardex")), CStr(dr.Item("tipo")), CInt(dr.Item("cantidad")), CInt(dr.Item("cantidadTotal")), CDate(dr.Item("fecha")), CInt(dr.Item("cod_Producto")), CInt(dr.Item("cod_Ambiente")))
            End If
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
        Return dato
    End Function

    Public Function LeerStockxAmbiente_Prod(ByVal wKardex As Kardex) As Kardex
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lStockxAmbiente_Prod", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Kardex = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_producto", wKardex.cod_Producto)
            .AddWithValue("@cod_Ambiente", wKardex.cod_Ambiente)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Kardex(0, CInt(dr.Item("cod_producto")), CInt(dr.Item("cod_ambiente")), CInt(dr.Item("StockxAmbiente")))
            End If
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
        Return dato
    End Function

    Public Function ListarAjustesxFecha(ByVal xFecha As Date, ByVal xcod_ambiente As Integer) As DataSet
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim adaptador As New SqlDataAdapter("pr_liAjustesxFecha", cn)
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        With adaptador.SelectCommand.Parameters
            .AddWithValue("@Fecha", xFecha)
            .AddWithValue("@cod_Ambiente", xcod_ambiente)
        End With

        Dim dt As New DataSet
        adaptador.Fill(dt)

        Return dt

    End Function

    Public Function ListarKardexEcoFecha(ByVal xFecha As Date, ByVal xcod_ambiente As Integer) As DataSet
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim adaptador As New SqlDataAdapter("pr_liKardexEcoFecha", cn)
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        With adaptador.SelectCommand.Parameters
            .AddWithValue("@Fecha", xFecha)
            .AddWithValue("@cod_Ambiente", xcod_ambiente)
        End With

        Dim dt As New DataSet
        adaptador.Fill(dt)

        Return dt

    End Function



End Class