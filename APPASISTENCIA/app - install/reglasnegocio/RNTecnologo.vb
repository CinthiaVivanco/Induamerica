Public Class RNTecnologo

	Public Sub Registrar(Byval wTecnologo AS Tecnologo)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iTecnologo", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@dni", wTecnologo.dni)
			.AddWithValue("@nombre", wTecnologo.nombre)
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
	Public Sub Modificar(Byval wTecnologo AS Tecnologo)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aTecnologo", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_tecnologo", wTecnologo.cod_tecnologo)
			.AddWithValue("@dni", wTecnologo.dni)
			.AddWithValue("@nombre", wTecnologo.nombre)
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
	Public Function Leer(Byval wTecnologo AS Tecnologo) AS Tecnologo
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lTecnologo", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Tecnologo = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_tecnologo", wTecnologo.cod_tecnologo)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Tecnologo( wTecnologo.cod_tecnologo,CStr( dr.Item("dni") ),CStr( dr.Item("nombre") ) )
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


    Public Function Listar() As List(Of Tecnologo)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liTecnologo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Tecnologo) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Tecnologo)
            Do While (dr.Read)
                ListP.Add(New Tecnologo(CInt(dr.Item("cod_tecnologo")), CStr(dr.Item("dni")), CStr(dr.Item("nombre"))))
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