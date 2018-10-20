Public Class RNDetalle_Laboratorio

	Public Sub Registrar(Byval wDetalle_Laboratorio AS Detalle_Laboratorio)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Laboratorio", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Examen_Lab", wDetalle_Laboratorio.cod_Examen_Lab)
			.AddWithValue("@cantidad", wDetalle_Laboratorio.cantidad)
			.AddWithValue("@montoTotal", wDetalle_Laboratorio.montoTotal)
			.AddWithValue("@cod_Laboratorio", wDetalle_Laboratorio.cod_Laboratorio)
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
	Public Sub Modificar(Byval wDetalle_Laboratorio AS Detalle_Laboratorio)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Laboratorio", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Detalle_Lab", wDetalle_Laboratorio.cod_Detalle_Lab)
			.AddWithValue("@cod_Examen_Lab", wDetalle_Laboratorio.cod_Examen_Lab)
			.AddWithValue("@cantidad", wDetalle_Laboratorio.cantidad)
			.AddWithValue("@montoTotal", wDetalle_Laboratorio.montoTotal)
			.AddWithValue("@cod_Laboratorio", wDetalle_Laboratorio.cod_Laboratorio)
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
	Public Function Leer(Byval wDetalle_Laboratorio AS Detalle_Laboratorio) AS Detalle_Laboratorio
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_Laboratorio", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_Laboratorio = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Detalle_Lab", wDetalle_Laboratorio.cod_Detalle_Lab)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Detalle_Laboratorio( wDetalle_Laboratorio.cod_Detalle_Lab,CInt( dr.Item("cod_Examen_Lab") ),CInt( dr.Item("cantidad") ),CDbl( dr.Item("montoTotal") ),CInt( dr.Item("cod_Laboratorio") ) )
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

    Public Function ListarxCodLaboratorio(ByVal wDetalle_Laboratorio As Detalle_Laboratorio) As List(Of Detalle_Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDCxCodLaboratorio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Laboratorio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Laboratorio", wDetalle_Laboratorio.cod_Laboratorio)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Laboratorio)
            Do While (dr.Read)
                ListP.Add(New Detalle_Laboratorio(CInt(dr.Item("cod_Detalle_Lab")), CInt(dr.Item("cod_Examen_Lab")), CInt(dr.Item("cantidad")), CDbl(dr.Item("montoTotal")), CInt(dr.Item("cod_Laboratorio")), CStr(dr.Item("nombreExamen")), CDbl(dr.Item("PrecioExamen"))))
        
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