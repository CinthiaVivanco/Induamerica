Public Class RNTipoGasto

	Public Sub Registrar(Byval wTipoGasto AS TipoGasto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iTipoGasto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Descripcion", wTipoGasto.Descripcion)
			.AddWithValue("@Estado", wTipoGasto.Estado)
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
	Public Sub Modificar(Byval wTipoGasto AS TipoGasto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aTipoGasto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_TipoGasto", wTipoGasto.cod_TipoGasto)
			.AddWithValue("@Descripcion", wTipoGasto.Descripcion)
			.AddWithValue("@Estado", wTipoGasto.Estado)
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
	Public Function Leer(Byval wTipoGasto AS TipoGasto) AS TipoGasto
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lTipoGasto", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As TipoGasto = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_TipoGasto", wTipoGasto.cod_TipoGasto)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New TipoGasto( wTipoGasto.cod_TipoGasto,CStr( dr.Item("Descripcion") ),CStr( dr.Item("Estado") ) )
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
    Public Function Listar() As List(Of TipoGasto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liTipoGasto", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of TipoGasto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of TipoGasto)
            Do While (dr.Read)
                ListP.Add(New TipoGasto(CInt(dr.Item("cod_TipoGasto")), CStr(dr.Item("Descripcion")), CStr(dr.Item("Estado"))))

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