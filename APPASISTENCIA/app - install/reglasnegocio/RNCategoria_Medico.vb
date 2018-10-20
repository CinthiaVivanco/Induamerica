Public Class RNCategoria_Medico

	Public Sub Registrar(Byval wCategoria_Medico AS Categoria_Medico)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iCategoria_Medico", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_categoria", wCategoria_Medico.cod_categoria)
			.AddWithValue("@cod_medico", wCategoria_Medico.cod_medico)
			.AddWithValue("@cod_centroconvenio", wCategoria_Medico.cod_centroconvenio)
			.AddWithValue("@precio", wCategoria_Medico.precio)
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
	Public Sub Modificar(Byval wCategoria_Medico AS Categoria_Medico)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aCategoria_Medico", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_categoria", wCategoria_Medico.cod_categoria)
			.AddWithValue("@cod_medico", wCategoria_Medico.cod_medico)
			.AddWithValue("@cod_centroconvenio", wCategoria_Medico.cod_centroconvenio)
			.AddWithValue("@precio", wCategoria_Medico.precio)
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

    Public Function ListarxMedico(ByVal wCategoria_Medico As Categoria_Medico) As List(Of Categoria_Medico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liCategoriaMedico", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Categoria_Medico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_medico", wCategoria_Medico.cod_medico)
            .AddWithValue("@cod_centroconvenio", wCategoria_Medico.cod_centroconvenio)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Categoria_Medico)
            Do While (dr.Read)


                ListP.Add(New Categoria_Medico(CInt(dr.Item("cod_categoria")), CInt(dr.Item("cod_medico")), CInt(dr.Item("cod_centroconvenio")), CDbl(dr.Item("precio")), CStr(dr.Item("NombreCategoria"))))

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


	Public Function Leer(Byval wCategoria_Medico AS Categoria_Medico) AS Categoria_Medico
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lCategoria_Medico", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Categoria_Medico = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Categoria_Medico(CInt(dr.Item("cod_categoria")), CInt(dr.Item("cod_medico")), CInt(dr.Item("cod_centroconvenio")), CDbl(dr.Item("precio")))
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