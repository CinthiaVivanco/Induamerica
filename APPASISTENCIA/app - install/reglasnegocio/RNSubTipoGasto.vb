Public Class RNSubTipoGasto

	Public Sub Registrar(Byval wSubTipoGasto AS SubTipoGasto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iSubTipoGasto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Descripcion", wSubTipoGasto.Descripcion)
			.AddWithValue("@estado", wSubTipoGasto.estado)
			.AddWithValue("@cod_TipoGasto", wSubTipoGasto.cod_TipoGasto)
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
	Public Sub Modificar(Byval wSubTipoGasto AS SubTipoGasto)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aSubTipoGasto", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Subtipo", wSubTipoGasto.cod_Subtipo)
			.AddWithValue("@Descripcion", wSubTipoGasto.Descripcion)
			.AddWithValue("@estado", wSubTipoGasto.estado)
			.AddWithValue("@cod_TipoGasto", wSubTipoGasto.cod_TipoGasto)
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
	Public Function Leer(Byval wSubTipoGasto AS SubTipoGasto) AS SubTipoGasto
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lSubTipoGasto", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As SubTipoGasto = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Subtipo", wSubTipoGasto.cod_Subtipo)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New SubTipoGasto( wSubTipoGasto.cod_Subtipo,CStr( dr.Item("Descripcion") ),CStr( dr.Item("estado") ),CInt( dr.Item("cod_TipoGasto") ) )
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
    Public Function ListarxTipo(ByVal wcod As Integer) As List(Of SubTipoGasto)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liSubTipoGasto", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of SubTipoGasto) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_TipoGasto", wcod)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of SubTipoGasto)
            Do While (dr.Read)
                ListP.Add(New SubTipoGasto(CInt(dr.Item("cod_subTipo")), CStr(dr.Item("Descripcion")), CStr(dr.Item("Estado")), wcod))

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