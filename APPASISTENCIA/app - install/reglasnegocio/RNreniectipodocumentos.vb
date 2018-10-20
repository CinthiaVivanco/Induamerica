Public Class RNreniectipodocumentos

	Public Sub Registrar(Byval wreniectipodocumentos AS reniectipodocumentos)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_ireniectipodocumentos", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@id", wreniectipodocumentos.id)
			.AddWithValue("@nombre", wreniectipodocumentos.nombre)
			.AddWithValue("@atributo", wreniectipodocumentos.atributo)
			.AddWithValue("@activo", wreniectipodocumentos.activo)
			.AddWithValue("@created_at", wreniectipodocumentos.created_at)
			.AddWithValue("@updated_at", wreniectipodocumentos.updated_at)
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
	Public Sub Modificar(Byval wreniectipodocumentos AS reniectipodocumentos)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_areniectipodocumentos", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@id", wreniectipodocumentos.id)
			.AddWithValue("@nombre", wreniectipodocumentos.nombre)
			.AddWithValue("@atributo", wreniectipodocumentos.atributo)
			.AddWithValue("@activo", wreniectipodocumentos.activo)
			.AddWithValue("@created_at", wreniectipodocumentos.created_at)
			.AddWithValue("@updated_at", wreniectipodocumentos.updated_at)
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
    Public Function Listar() As List(Of reniectipodocumentos)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_lireniectipodocumentos", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListT As List(Of reniectipodocumentos) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListT = New List(Of reniectipodocumentos)
            Do While (dr.Read)
                ListT.Add(New reniectipodocumentos(CStr(dr.Item("id")), CStr(dr.Item("nombre")), CStr(dr.Item("atributo")), CBool(dr.Item("activo")), CDate(dr.Item("created_at")), CDate(dr.Item("updated_at"))))
            Loop
        Catch ex As Exception
            If ListT IsNot Nothing Then
                ListT.Clear()
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
        Return ListT
    End Function

	Public Function Leer(Byval wreniectipodocumentos AS reniectipodocumentos) AS reniectipodocumentos
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lreniectipodocumentos", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As reniectipodocumentos = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New reniectipodocumentos(CStr( dr.Item("id") ),CStr( dr.Item("nombre") ),CStr( dr.Item("atributo") ),CBool( dr.Item("activo") ),CDate( dr.Item("created_at") ),CDate( dr.Item("updated_at") ) )
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