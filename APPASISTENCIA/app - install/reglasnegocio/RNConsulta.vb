Public Class RNConsulta

    Public Function Registrar(ByVal wConsulta As Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iConsulta", cn)
        Dim codigo As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", 0).Direction = ParameterDirection.Output
            .AddWithValue("@fecha_Examen", wConsulta.fecha_Examen)
            .AddWithValue("@fecha_Informe", wConsulta.fecha_Informe)
            .AddWithValue("@hora_Examen", wConsulta.hora_Examen)
            .AddWithValue("@numDoc", wConsulta.numDoc)
            .AddWithValue("@costo", wConsulta.costo)
            .AddWithValue("@acuenta", wConsulta.acuenta)
            .AddWithValue("@saldo", wConsulta.saldo)
            .AddWithValue("@total_Consulta", wConsulta.total_Consulta)
            .AddWithValue("@estado", wConsulta.estado)
            .AddWithValue("@nroTicket", wConsulta.nroTicket)
            .AddWithValue("@tipoPago", wConsulta.TipoPago)
            .AddWithValue("@Cod_Paciente", wConsulta.Cod_Paciente)
            .AddWithValue("@cod_Comprobante", wConsulta.cod_Comprobante)
            .AddWithValue("@cod_Persona", wConsulta.cod_Persona)
            .AddWithValue("@MedicoOrden", wConsulta.MedicoOrdena)
            .AddWithValue("@UsuarioReg", wConsulta.UsuarioReg)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_Consulta").Value)
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

        Return codigo
    End Function

	Public Sub Modificar(Byval wConsulta AS Consulta)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aConsulta", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
			.AddWithValue("@fecha_Examen", wConsulta.fecha_Examen)
			.AddWithValue("@fecha_Informe", wConsulta.fecha_Informe)
			.AddWithValue("@hora_Examen", wConsulta.hora_Examen)
			.AddWithValue("@numDoc", wConsulta.numDoc)
			.AddWithValue("@costo", wConsulta.costo)
			.AddWithValue("@acuenta", wConsulta.acuenta)
			.AddWithValue("@saldo", wConsulta.saldo)
			.AddWithValue("@total_Consulta", wConsulta.total_Consulta)
			.AddWithValue("@estado", wConsulta.estado)
			.AddWithValue("@nroTicket", wConsulta.nroTicket)
            .AddWithValue("@tipoPago", wConsulta.TipoPago)
            .AddWithValue("@Cod_Paciente", wConsulta.Cod_Paciente)
			.AddWithValue("@cod_Comprobante", wConsulta.cod_Comprobante)
            .AddWithValue("@cod_Persona", wConsulta.cod_Persona)
            .AddWithValue("@MedicoOrden", wConsulta.MedicoOrdena)
            .AddWithValue("@UsuarioMod", wConsulta.UsuarioMod)
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

	Public Function Leer(Byval wConsulta AS Consulta) AS Consulta
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lConsulta", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Consulta = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Consulta(wConsulta.cod_Consulta, CDate(dr.Item("fecha_Examen")), CDate(dr.Item("fecha_Informe")), CDate(dr.Item("hora_Examen")), CStr(dr.Item("numDoc")), CDbl(dr.Item("costo")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CDbl(dr.Item("total_Consulta")), CStr(dr.Item("estado")), CStr(dr.Item("nroTicket")), CStr(dr.Item("TipoPago")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_Comprobante")), CInt(dr.Item("cod_Persona")), CStr(dr.Item("MedicoOrden")))
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

    Public Function LeerxDetMat(ByVal wConsulta As Consulta) As Consulta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lConsulta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Consulta = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Consulta(wConsulta.cod_Consulta, CDate(dr.Item("fecha_Examen")), CDate(dr.Item("fecha_Informe")), CDate(dr.Item("hora_Examen")), CStr(dr.Item("numDoc")), CDbl(dr.Item("costo")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CDbl(dr.Item("total_Consulta")), CStr(dr.Item("estado")), CStr(dr.Item("nroTicket")), CStr(dr.Item("TipoPago")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_Comprobante")), CInt(dr.Item("cod_Persona")), CStr(dr.Item("MedicoOrden")), CStr(dr.Item("EstadoMat")))
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

    Public Function LeerxDetMatExtra(ByVal wConsulta As Consulta) As Consulta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lConsulta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Consulta = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Consulta(wConsulta.cod_Consulta, CDate(dr.Item("fecha_Examen")), CDate(dr.Item("fecha_Informe")), CDate(dr.Item("hora_Examen")), CStr(dr.Item("numDoc")), CDbl(dr.Item("costo")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CDbl(dr.Item("total_Consulta")), CStr(dr.Item("estado")), CStr(dr.Item("nroTicket")), CStr(dr.Item("TipoPago")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_Comprobante")), CInt(dr.Item("cod_Persona")), CStr(dr.Item("MedicoOrden")), CStr(dr.Item("EstadoMat")), CStr(dr.Item("estadoMatExtra")))
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

    Public Function ListarxConsultasReservadasxFecha(ByVal xfecha As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("CoReservadasxFecha", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function ListarConsultasxEstado(ByVal xfecha As Date, ByVal xestado As String) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("listarConsultasxEstado", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
                .AddWithValue("@estado", xestado)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarConsultasxCambioExamen(ByVal xfecha As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("listarConsultasxCambioExamen", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarConsultasxEstadoMatRX(ByVal xfecha As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("listarConsultasxEstadoMatRX", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
                '.AddWithValue("@estado", xestado)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function ListarConsultasxEstadoMatTomo(ByVal xfecha As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("listarConsultasxEstadoMatTomo", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
                '.AddWithValue("@estado", xestado)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function ListarConsultasxEstadoMatEnfermera(ByVal xfecha As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("listarConsultasxEstadoMatEnfermera", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", xfecha)
                '.AddWithValue("@estado", xestado)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerTickets(ByVal numero As String) As Consulta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("ver_Tickets", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Consulta = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@numero", numero)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                dato = (New Consulta(CInt(dr.Item("cod_Consulta")), CDate(dr.Item("fecha_Examen")), CDate(dr.Item("fecha_Informe")), CDate(dr.Item("hora_Examen")), CStr(dr.Item("numDoc")), CDbl(dr.Item("costo")), CDbl(dr.Item("acuenta")), CDbl(dr.Item("saldo")), CDbl(dr.Item("total_Consulta")), CStr(dr.Item("estado")), CStr(dr.Item("nroTicket")), CStr(dr.Item("TipoPago")), CInt(dr.Item("Cod_Paciente")), CInt(dr.Item("cod_Comprobante")), CInt(dr.Item("cod_Persona")), CStr(dr.Item("MedicoOrden"))))
            End If
        Catch ex As Exception
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
        Return dato

    End Function

    Public Function MostrarTicket(ByVal cod_consulta As Integer) As Consulta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_RetornarTicket", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Consulta = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_consulta", cod_consulta)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                dato = (New Consulta(CInt(dr.Item("cod_Consulta")), CStr(dr.Item("estado")), CStr(dr.Item("nroTicket"))))
            End If
        Catch ex As Exception
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
        Return dato

    End Function


    Public Sub ModificarEstado(ByVal wConsulta As Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aConsultaEstado", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigo", wConsulta.cod_Consulta)
            .AddWithValue("@estado", wConsulta.Estado)
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


    Public Function ListarxNombre(ByVal nombre As String) As List(Of Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaConsultaxNombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Consulta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Consulta)
            Do While (dr.Read)
                ListP.Add(New Consulta(CInt(dr.Item("cod_consulta")), CDate(dr.Item("FechaExamen")), CDate(dr.Item("horaExamen")), CDate(dr.Item("fecha_Informe")), CStr(dr.Item("estado")), CInt(dr.Item("cod_Paciente")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre")), CStr(dr.Item("dni")), CStr(dr.Item("NroTicket"))))

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
    Public Function ListarxFecha(ByVal fecha As Date) As List(Of Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaConsultaxFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Consulta) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fecha", fecha)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Consulta)
            Do While (dr.Read)
                ListP.Add(New Consulta(CInt(dr.Item("cod_consulta")), CDate(dr.Item("FechaExamen")), CDate(dr.Item("horaExamen")), CDate(dr.Item("Fecha_Informe")), CStr(dr.Item("estado")), CInt(dr.Item("cod_Paciente")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre")), CStr(dr.Item("dni")), CStr(dr.Item("NroTicket"))))

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


    Public Function ListarIngresosxFechas(ByVal xfechaini As Date, ByVal xFechaFin As Date) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("ListarIngresosxFechas", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@FechaIni", xfechaini)
                .AddWithValue("@FechaFin", xFechaFin)

            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function HistorialxPaciente(ByVal nombre As String) As DataSet
        Try

            Dim cn As New SqlConnection(My.Settings.conexion)
            Dim adaptador As New SqlDataAdapter("HistorialConsultasxNombre", cn)


            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@cadena", nombre)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function HistorialxCodPaciente(ByVal codigo As Integer) As DataSet
        Try

            Dim cn As New SqlConnection(My.Settings.conexion)
            Dim adaptador As New SqlDataAdapter("HistorialConsultasxCodigo", cn)


            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@codigo", codigo)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function HistorialxFecha(ByVal fecha As Date) As DataSet
        Try

            Dim cn As New SqlConnection(My.Settings.conexion)
            Dim adaptador As New SqlDataAdapter("HistorialConsultasxFecha", cn)


            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@fecha", fecha)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarPagosxMedico(xFechaIni As Date, FechaFin As Date, codMedico As Integer) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_LiPagoMedicosxPeriodo", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@FechaIni", xFechaIni)
                .AddWithValue("@FechaFin", FechaFin)
                .AddWithValue("@cod_Medico", codMedico)

            End With
            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ListarPagosxCerinxGrupo(ByVal xperiodoid As String, xtipoexam As Integer) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_LiMensualxGrupo", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With adaptador.SelectCommand.Parameters
                .AddWithValue("@periodoid", xperiodoid)
                .AddWithValue("@tipoexam", xtipoexam)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub EstadoConsultaMaterial(ByVal wConsulta As Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aConsultaMaterial", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
            .AddWithValue("@estadoMat", wConsulta.EstadoMat)
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

    Public Sub EstadoConsultaMaterialEnfermera(ByVal wConsulta As Consulta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aConsultaMaterialEnfermera", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Consulta", wConsulta.cod_Consulta)
            .AddWithValue("@estadoMat", wConsulta.EstadoMat)
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