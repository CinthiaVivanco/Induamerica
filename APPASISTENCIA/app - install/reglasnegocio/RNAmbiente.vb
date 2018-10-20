Public Class RNAmbiente

	Public Sub Registrar(Byval wAmbiente AS Ambiente)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iAmbiente", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wAmbiente.nombre)
			.AddWithValue("@tipo", wAmbiente.tipo)
			.AddWithValue("@cod_local", wAmbiente.cod_local)
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
	Public Sub Modificar(Byval wAmbiente AS Ambiente)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aAmbiente", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Ambiente", wAmbiente.cod_Ambiente)
			.AddWithValue("@nombre", wAmbiente.nombre)
			.AddWithValue("@tipo", wAmbiente.tipo)
			.AddWithValue("@cod_local", wAmbiente.cod_local)
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
	Public Function Leer(Byval wAmbiente AS Ambiente) AS Ambiente
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lAmbiente", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Ambiente = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Ambiente", wAmbiente.cod_Ambiente)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Ambiente( wAmbiente.cod_Ambiente,CStr( dr.Item("nombre") ),CStr( dr.Item("tipo") ),CInt( dr.Item("cod_local") ) )
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

    Public Function Listar() As List(Of Ambiente)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liAmbiente", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Ambiente) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Ambiente)
            Do While (dr.Read)
                ListP.Add(New Ambiente(CInt(dr.Item("cod_Ambiente")), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CInt(dr.Item("cod_local"))))
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

    Public Function ListarConsultorios() As List(Of Ambiente)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liAmbConsultorio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Ambiente) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Ambiente)
            Do While (dr.Read)
                ListP.Add(New Ambiente(CInt(dr.Item("cod_Ambiente")), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CInt(dr.Item("cod_local"))))
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