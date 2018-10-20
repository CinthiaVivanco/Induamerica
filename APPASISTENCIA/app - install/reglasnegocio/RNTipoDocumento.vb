Public Class RNTipoDocumento

	Public Sub Registrar(Byval wTipoDocumento AS TipoDocumento)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iTipoDocumento", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Descripcion", wTipoDocumento.Descripcion)
			.AddWithValue("@Estado", wTipoDocumento.Estado)
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
	Public Sub Modificar(Byval wTipoDocumento AS TipoDocumento)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aTipoDocumento", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_TipoDoc", wTipoDocumento.cod_TipoDoc)
			.AddWithValue("@Descripcion", wTipoDocumento.Descripcion)
			.AddWithValue("@Estado", wTipoDocumento.Estado)
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
	Public Function Leer(Byval wTipoDocumento AS TipoDocumento) AS TipoDocumento
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lTipoDocumento", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As TipoDocumento = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_TipoDoc", wTipoDocumento.cod_TipoDoc)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New TipoDocumento( wTipoDocumento.cod_TipoDoc,CStr( dr.Item("Descripcion") ),CStr( dr.Item("Estado") ) )
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


    Public Function Listar() As List(Of TipoDocumento)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liTipoDocumento", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of TipoDocumento) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of TipoDocumento)
            Do While (dr.Read)
                ListP.Add(New TipoDocumento(CInt(dr.Item("cod_TipoDoc")), CStr(dr.Item("Descripcion")), CStr(dr.Item("Estado"))))

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