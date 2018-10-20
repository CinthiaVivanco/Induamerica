Public Class RNLaboratorio

    Public Function Registrar(ByVal wLaboratorio As Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iLaboratorio", cn)
        Dim codigo As Integer = 0

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Laboratorio", 0).Direction = ParameterDirection.Output

            .AddWithValue("@Cod_Paciente", wLaboratorio.Cod_Paciente)
            .AddWithValue("@fechaRegisstro", wLaboratorio.fechaRegistro)
            .AddWithValue("@fechaExamen", wLaboratorio.fechaExamen)
            .AddWithValue("@fechaInforme", wLaboratorio.fechaInforme)
            .AddWithValue("@costo", wLaboratorio.costo)
            .AddWithValue("@acuenta", wLaboratorio.acuenta)
            .AddWithValue("@saldo", wLaboratorio.saldo)
            .AddWithValue("@total", wLaboratorio.total)
            .AddWithValue("@tipoPago", wLaboratorio.tipoPago)
            .AddWithValue("@estado", wLaboratorio.estado)
            .AddWithValue("@cod_Comprobante", wLaboratorio.cod_Comprobante)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()

            codigo = CInt(cmd.Parameters.Item("@cod_Laboratorio").Value)


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
	Public Sub Modificar(Byval wLaboratorio AS Laboratorio)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aLaboratorio", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Laboratorio", wLaboratorio.cod_Laboratorio)
			.AddWithValue("@Cod_Paciente", wLaboratorio.Cod_Paciente)
            .AddWithValue("@fechaRegisstro", wLaboratorio.fechaRegistro)
			.AddWithValue("@fechaExamen", wLaboratorio.fechaExamen)
			.AddWithValue("@fechaInforme", wLaboratorio.fechaInforme)
			.AddWithValue("@costo", wLaboratorio.costo)
			.AddWithValue("@acuenta", wLaboratorio.acuenta)
			.AddWithValue("@saldo", wLaboratorio.saldo)
			.AddWithValue("@total", wLaboratorio.total)
			.AddWithValue("@tipoPago", wLaboratorio.tipoPago)
			.AddWithValue("@estado", wLaboratorio.estado)
			.AddWithValue("@cod_Comprobante", wLaboratorio.cod_Comprobante)
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
	Public Function Leer(Byval wLaboratorio AS Laboratorio) AS Laboratorio
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lLaboratorio", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Laboratorio = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Laboratorio", wLaboratorio.cod_Laboratorio)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Laboratorio( wLaboratorio.cod_Laboratorio,CInt( dr.Item("Cod_Paciente") ),CDate( dr.Item("fechaRegisstro") ),CDate( dr.Item("fechaExamen") ),CDate( dr.Item("fechaInforme") ),CDbl( dr.Item("costo") ),CDbl( dr.Item("acuenta") ),CDbl( dr.Item("saldo") ),CDbl( dr.Item("total") ),CStr( dr.Item("tipoPago") ),CStr( dr.Item("estado") ),CInt( dr.Item("cod_Comprobante") ) )
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaLaboratorioxNombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Laboratorio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Laboratorio)
            Do While (dr.Read)
                ListP.Add(New Laboratorio(CInt(dr.Item("cod_Laboratorio")), CDate(dr.Item("fechaRegisstro")), CDate(dr.Item("fechaExamen")), CDate(dr.Item("fechaInforme")), CStr(dr.Item("estado")), CInt(dr.Item("Cod_Paciente")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre")), CStr(dr.Item("dni"))))

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
    Public Function ListarxFecha(ByVal fecha As Date) As List(Of Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("ListaLaboratorioxFecha", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Laboratorio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fecha", fecha)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Laboratorio)
            Do While (dr.Read)
                ListP.Add(New Laboratorio(CInt(dr.Item("cod_Laboratorio")), CDate(dr.Item("fechaRegisstro")), CDate(dr.Item("fechaExamen")), CDate(dr.Item("fechaInforme")), CStr(dr.Item("estado")), CInt(dr.Item("Cod_Paciente")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre")), CStr(dr.Item("dni"))))

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