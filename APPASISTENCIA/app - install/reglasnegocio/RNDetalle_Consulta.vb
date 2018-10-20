Public Class RNDetalle_Consulta

	Public Sub Registrar(Byval wDetalle_Consulta AS Detalle_Consulta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Consulta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)
			.AddWithValue("@cantidad", wDetalle_Consulta.cantidad)
			.AddWithValue("@monto_Total", wDetalle_Consulta.monto_Total)
			.AddWithValue("@cod_Examen", wDetalle_Consulta.cod_Examen)
            .AddWithValue("@cod_PlanAtencion", wDetalle_Consulta.cod_PlanAtencion)
            '.AddWithValue("@informe", wDetalle_Consulta.informe)
            .AddWithValue("@cod_CentroConvenio", wDetalle_Consulta.codCentroConvenio)
            .AddWithValue("@procRealizado", wDetalle_Consulta.ProcRealizado)

            .AddWithValue("@estado", wDetalle_Consulta.Estado)

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
	Public Sub Modificar(Byval wDetalle_Consulta AS Detalle_Consulta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Consulta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Detalle_Consulta", wDetalle_Consulta.cod_Detalle_Consulta)
			.AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)
			.AddWithValue("@cantidad", wDetalle_Consulta.cantidad)
			.AddWithValue("@monto_Total", wDetalle_Consulta.monto_Total)
			.AddWithValue("@cod_Examen", wDetalle_Consulta.cod_Examen)
            .AddWithValue("@cod_PlanAtencion", wDetalle_Consulta.cod_PlanAtencion)
            '.AddWithValue("@informe", wDetalle_Consulta.informe)
            '.AddWithValue("@informe", "")
            .AddWithValue("@cod_CentroConvenio", wDetalle_Consulta.codCentroConvenio)
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

    Public Sub InformarExamen(ByVal wDetalle_Consulta As Detalle_Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aInformeExamen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Detalle_Consulta", wDetalle_Consulta.cod_Detalle_Consulta)
            .AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)
            .AddWithValue("@informe", wDetalle_Consulta.informe)
            .AddWithValue("@cod_medico", wDetalle_Consulta.cod_Medico)
            .AddWithValue("@informado", wDetalle_Consulta.informado)

        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
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


    Public Function ListarxCodConsulta(ByVal wDetalle_Consulta As Detalle_Consulta) As List(Of Detalle_Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDCxCodConsulta", cn)
         Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Consulta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Consulta)
            Do While (dr.Read)
                ListP.Add(New Detalle_Consulta(CInt(dr.Item("cod_Detalle_Consulta")), CInt(dr.Item("cod_Consulta")), CInt(dr.Item("cantidad")), CDbl(dr.Item("monto_Total")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), CDbl(dr.Item("PrecioExamen")), CInt(dr.Item("cod_PlanAtencion")), CStr(dr.Item("nombrePlan")), CInt(dr.Item("COD_CENTROCONVENIO"))))

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

    Public Function LeerDC_Examen(ByVal wDetalle_Consulta As Detalle_Consulta) As Detalle_Consulta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leeDC", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Detalle_Consulta = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Detalle_Consulta", wDetalle_Consulta.cod_Detalle_Consulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Detalle_Consulta(wDetalle_Consulta.cod_Detalle_Consulta, CInt(dr.Item("cod_Consulta")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), CStr(dr.Item("informe")), CInt(dr.Item("cod_medico")), CStr(dr.Item("informado")))
            End If
        Catch ex As Exception
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

    Public Function ListarDetalleExamenxTicket(ByVal numtk As String) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_DetalleTicket", cn)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            With adaptador.SelectCommand.Parameters
                .AddWithValue("@numero", numtk)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub CambiarExamen(ByVal cod_Detalle_Consulta As Integer, ByVal cod_Examen As Integer, ByVal wnewExamen As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_CambiarExamen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Detalle_Consulta", cod_Detalle_Consulta)
            .AddWithValue("@cod_Examen", cod_Examen)
            .AddWithValue("@newcod_Examen", wnewExamen)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
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

    Public Function ListarxExamenInventarioRX(ByVal wDetalle_Consulta As Detalle_Consulta) As List(Of Detalle_Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDCxCodConsultaxRX", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Consulta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Consulta)
            Do While (dr.Read)
                ListP.Add(New Detalle_Consulta(CInt(dr.Item("cod_Detalle_Consulta")), CInt(dr.Item("cod_Consulta")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), ""))
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
    Public Function ListarxExamenInventarioTem(ByVal wDetalle_Consulta As Detalle_Consulta) As List(Of Detalle_Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDCxCodConsultaxTEM", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Consulta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Consulta", wDetalle_Consulta.cod_Consulta)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Consulta)
            Do While (dr.Read)
                ListP.Add(New Detalle_Consulta(CInt(dr.Item("cod_Detalle_Consulta")), CInt(dr.Item("cod_Consulta")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), ""))

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


    Public Sub CambiarPrecioExamen(ByVal cod_Detalle_Consulta As Integer, ByVal cod_Examen As Integer, ByVal wprecio As Double)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_CambiarPrecioExamen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", cod_Detalle_Consulta)
            .AddWithValue("@cod_Examen", cod_Examen)
            .AddWithValue("@precio", wprecio)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
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


End Class