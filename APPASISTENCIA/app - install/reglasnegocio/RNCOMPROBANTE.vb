Public Class RNCOMPROBANTE

	Public Sub Registrar(Byval wCOMPROBANTE AS COMPROBANTE)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iCOMPROBANTE", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wCOMPROBANTE.nombre)
			.AddWithValue("@serie", wCOMPROBANTE.serie)
			.AddWithValue("@numero", wCOMPROBANTE.numero)
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
	Public Sub Modificar(Byval wCOMPROBANTE AS COMPROBANTE)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aCOMPROBANTE", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Comprobante", wCOMPROBANTE.cod_Comprobante)
			.AddWithValue("@nombre", wCOMPROBANTE.nombre)
			.AddWithValue("@serie", wCOMPROBANTE.serie)
			.AddWithValue("@numero", wCOMPROBANTE.numero)
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
	Public Function Leer(Byval wCOMPROBANTE AS COMPROBANTE) AS COMPROBANTE
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lCOMPROBANTE", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As COMPROBANTE = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Comprobante", wCOMPROBANTE.cod_Comprobante)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New COMPROBANTE( wCOMPROBANTE.cod_Comprobante,CStr( dr.Item("nombre") ),CStr( dr.Item("serie") ),CStr( dr.Item("numero") ) )
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

    Public Function Listar() As List(Of COMPROBANTE)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarComprobante", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of COMPROBANTE) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of COMPROBANTE)
            Do While (dr.Read)
                ListP.Add(New COMPROBANTE(CStr(dr.Item("cod_Comprobante")), CStr(dr.Item("nombre")), CStr(dr.Item("serie")), CStr(dr.Item("numero"))))

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