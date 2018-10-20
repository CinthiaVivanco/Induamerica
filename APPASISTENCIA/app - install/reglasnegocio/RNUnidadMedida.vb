Public Class RNUnidadMedida

	Public Sub Registrar(Byval wUnidadMedida AS UnidadMedida)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iUnidadMedida", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wUnidadMedida.nombre)
			.AddWithValue("@estado", wUnidadMedida.estado)
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
	Public Sub Modificar(Byval wUnidadMedida AS UnidadMedida)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aUnidadMedida", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Unidad", wUnidadMedida.cod_Unidad)
			.AddWithValue("@nombre", wUnidadMedida.nombre)
			.AddWithValue("@estado", wUnidadMedida.estado)
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
	Public Function Leer(Byval wUnidadMedida AS UnidadMedida) AS UnidadMedida
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lUnidadMedida", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As UnidadMedida = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Unidad", wUnidadMedida.cod_Unidad)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New UnidadMedida( wUnidadMedida.cod_Unidad,CStr( dr.Item("nombre") ),CStr( dr.Item("estado") ) )
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


    Public Function Listar() As List(Of UnidadMedida)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liUnidadMedida", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of UnidadMedida) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of UnidadMedida)
            Do While (dr.Read)
                ListP.Add(New UnidadMedida(CInt(dr.Item("cod_Unidad")), CStr(dr.Item("nombre")), CStr(dr.Item("estado"))))
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