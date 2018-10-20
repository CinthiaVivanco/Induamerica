Public Class RNDetalle_Informe

	Public Sub Registrar(Byval wDetalle_Informe AS Detalle_Informe)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_Informe", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cantidad", wDetalle_Informe.cantidad)
			.AddWithValue("@Monto_Total", wDetalle_Informe.Monto_Total)
			.AddWithValue("@Informe", wDetalle_Informe.Informe)
			.AddWithValue("@estado", wDetalle_Informe.estado)
			.AddWithValue("@cod_Examen", wDetalle_Informe.cod_Examen)
			.AddWithValue("@cod_Informe", wDetalle_Informe.cod_Informe)
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
	Public Sub Modificar(Byval wDetalle_Informe AS Detalle_Informe)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aDetalle_Informe", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_DetalleInforme", wDetalle_Informe.cod_DetalleInforme)
			.AddWithValue("@cantidad", wDetalle_Informe.cantidad)
			.AddWithValue("@Monto_Total", wDetalle_Informe.Monto_Total)
			.AddWithValue("@Informe", wDetalle_Informe.Informe)
			.AddWithValue("@estado", wDetalle_Informe.estado)
			.AddWithValue("@cod_Examen", wDetalle_Informe.cod_Examen)
			.AddWithValue("@cod_Informe", wDetalle_Informe.cod_Informe)
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
	Public Function Leer(Byval wDetalle_Informe AS Detalle_Informe) AS Detalle_Informe
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_Informe", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_Informe = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_DetalleInforme", wDetalle_Informe.cod_DetalleInforme)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Detalle_Informe(wDetalle_Informe.cod_DetalleInforme, CInt(dr.Item("cantidad")), CDbl(dr.Item("Monto_Total")), CStr(dr.Item("Informe")), CStr(dr.Item("estado")), CInt(dr.Item("cod_Examen")), CInt(dr.Item("cod_Informe")))
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

    Public Function LeerDInforme(ByVal wDetalle_Informe As Detalle_Informe) As Detalle_Informe
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDInf", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Detalle_Informe = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleInforme", wDetalle_Informe.cod_DetalleInforme)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Detalle_Informe(wDetalle_Informe.cod_DetalleInforme, CInt(dr.Item("cod_Informe")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), CStr(dr.Item("Informe")), CInt(dr.Item("cod_Medico")), CStr(dr.Item("Informado")))
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


    Public Function ListarxCodInforme(ByVal wDetalle_Consulta As Detalle_Informe) As List(Of Detalle_Informe)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_leerDCxCodInforme", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_Informe) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Informe", wDetalle_Consulta.cod_Informe)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_Informe)
            Do While (dr.Read)
                ListP.Add(New Detalle_Informe(CInt(dr.Item("cod_DetalleInforme")), CInt(dr.Item("cod_Informe")), CInt(dr.Item("cantidad")), CDbl(dr.Item("monto_Total")), CInt(dr.Item("cod_Examen")), CStr(dr.Item("nombreExamen")), CDbl(dr.Item("PrecioExamen"))))

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

    Public Function ListarDetalleInformesPendientes(ByVal cod_centro As Integer, ByVal fechaini As Date, ByVal fechafin As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_ListarDetInformesPend", cn)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            With adaptador.SelectCommand.Parameters
                .AddWithValue("@cod_CentroConvenio", cod_centro)
                .AddWithValue("@FechaIni", fechaini)
                .AddWithValue("@FechaFin", fechafin)

            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarDetalleInformesTerminados(ByVal cod_centro As Integer, ByVal fechaini As Date, ByVal fechafin As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_ListarDetInformesTerm", cn)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            With adaptador.SelectCommand.Parameters
                .AddWithValue("@cod_CentroConvenio", cod_centro)
                .AddWithValue("@FechaIni", fechaini)
                .AddWithValue("@FechaFin", fechafin)

            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function ListarDetalleInformes(ByVal cod_centro As Integer, ByVal fechaini As Date, ByVal fechafin As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_ListarDetInformes", cn)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            With adaptador.SelectCommand.Parameters
                .AddWithValue("@cod_CentroConvenio", cod_centro)
                .AddWithValue("@FechaIni", fechaini)
                .AddWithValue("@FechaFin", fechafin)

            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Sub InformarExamen(ByVal wDetalle_Informe As Detalle_Informe)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aInformeExamenOtros", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleInforme", wDetalle_Informe.cod_DetalleInforme)
            .AddWithValue("@cod_Informe", wDetalle_Informe.cod_Informe)
            .AddWithValue("@informe", wDetalle_Informe.Informe)
            .AddWithValue("@cod_medico", wDetalle_Informe.cod_Medico)
            .AddWithValue("@informado", wDetalle_Informe.informado)
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
    Public Sub CambiarExamen(ByVal cod_DetalleInforme As Integer, ByVal cod_Examen As Integer, ByVal wnewExamen As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_CambiarExamenInforme", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleInforme", cod_DetalleInforme)
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



End Class