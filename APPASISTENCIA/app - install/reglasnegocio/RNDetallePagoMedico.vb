Public Class RNDetallePagoMedico

	Public Sub Registrar(Byval wDetallePagoMedico AS DetallePagoMedico)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetallePagoMedico", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Fecha", wDetallePagoMedico.Fecha)
			.AddWithValue("@PrecioOrig", wDetallePagoMedico.PrecioOrig)
			.AddWithValue("@PorcOrig", wDetallePagoMedico.PorcOrig)
			.AddWithValue("@PrecioMod", wDetallePagoMedico.PrecioMod)
			.AddWithValue("@PorcMod", wDetallePagoMedico.PorcMod)
			.AddWithValue("@cod_Examen", wDetallePagoMedico.cod_Examen)
			.AddWithValue("@Cod_Paciente", wDetallePagoMedico.Cod_Paciente)
			.AddWithValue("@cod_PagoMedico", wDetallePagoMedico.cod_PagoMedico)
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
	Public Sub Modificar(Byval wDetallePagoMedico AS DetallePagoMedico)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetallePagoMedico", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_DetallePago", wDetallePagoMedico.cod_DetallePago)
			.AddWithValue("@Fecha", wDetallePagoMedico.Fecha)
			.AddWithValue("@PrecioOrig", wDetallePagoMedico.PrecioOrig)
			.AddWithValue("@PorcOrig", wDetallePagoMedico.PorcOrig)
			.AddWithValue("@PrecioMod", wDetallePagoMedico.PrecioMod)
			.AddWithValue("@PorcMod", wDetallePagoMedico.PorcMod)
			.AddWithValue("@cod_Examen", wDetallePagoMedico.cod_Examen)
			.AddWithValue("@Cod_Paciente", wDetallePagoMedico.Cod_Paciente)
			.AddWithValue("@cod_PagoMedico", wDetallePagoMedico.cod_PagoMedico)
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
	Public Function Leer(Byval wDetallePagoMedico AS DetallePagoMedico) AS DetallePagoMedico
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetallePagoMedico", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As DetallePagoMedico = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_DetallePago", wDetallePagoMedico.cod_DetallePago)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New DetallePagoMedico( wDetallePagoMedico.cod_DetallePago,CDate( dr.Item("Fecha") ),CDbl( dr.Item("PrecioOrig") ),CDbl( dr.Item("PorcOrig") ),CDbl( dr.Item("PrecioMod") ),CDbl( dr.Item("PorcMod") ),CInt( dr.Item("cod_Examen") ),CInt( dr.Item("Cod_Paciente") ),CInt( dr.Item("cod_PagoMedico") ) )
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


    Public Function Listar(ByVal cod_PagoMedico As Integer) As List(Of DetallePagoMedico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liDetallePagoMedico", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of DetallePagoMedico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Cod_PagoMedico", cod_PagoMedico)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of DetallePagoMedico)
            Do While (dr.Read)
                ListP.Add(New DetallePagoMedico(CInt(dr.Item("cod_DetallePago")), CDate(dr.Item("Fecha")), CDbl(dr.Item("PrecioOrig")), CDbl(dr.Item("PorcOrig")), CDbl(dr.Item("PrecioMod")), CDbl(dr.Item("PorcMod")), CInt(dr.Item("cod_Examen")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_PagoMedico")), CStr(dr.Item("nombreExamen")), CStr(dr.Item("APPATERNO")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre"))))

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