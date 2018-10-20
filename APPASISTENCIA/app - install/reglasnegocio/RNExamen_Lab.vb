Public Class RNExamen_Lab

	Public Sub Registrar(Byval wExamen_Lab AS Examen_Lab)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iExamen_Lab", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wExamen_Lab.nombre)
			.AddWithValue("@precioPublico", wExamen_Lab.precioPublico)
			.AddWithValue("@precioCerin", wExamen_Lab.precioCerin)
			.AddWithValue("@estado", wExamen_Lab.estado)
			.AddWithValue("@cod_CentroConvenio", wExamen_Lab.cod_CentroConvenio)
			.AddWithValue("@cod_TipoExamen", wExamen_Lab.cod_TipoExamen)
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
	Public Sub Modificar(Byval wExamen_Lab AS Examen_Lab)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aExamen_Lab", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Examen_Lab", wExamen_Lab.cod_Examen_Lab)
			.AddWithValue("@nombre", wExamen_Lab.nombre)
			.AddWithValue("@precioPublico", wExamen_Lab.precioPublico)
			.AddWithValue("@precioCerin", wExamen_Lab.precioCerin)
			.AddWithValue("@estado", wExamen_Lab.estado)
			.AddWithValue("@cod_CentroConvenio", wExamen_Lab.cod_CentroConvenio)
			.AddWithValue("@cod_TipoExamen", wExamen_Lab.cod_TipoExamen)
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
    Public Function Leer(ByVal wExamen_Lab As Examen_Lab) As Examen_Lab
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lExamen_Lab", cn)
        Dim dr As SQLDataReader = Nothing
        Dim dato As Examen_Lab = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Examen_Lab", wExamen_Lab.cod_Examen_Lab)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Examen_Lab(wExamen_Lab.cod_Examen_Lab, dr.Item("nombre"), dr.Item("precioPublico"), CDbl(dr.Item("precioCerin")), CStr(dr.Item("estado")), CInt(dr.Item("cod_CentroConvenio")), CInt(dr.Item("cod_TipoExamen")))
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

    Public Function ListarNombreExamen(ByVal nombre As String)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamenLab_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen_Lab) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombre", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen_Lab)
            Do While (dr.Read)
                ListP.Add(New Examen_Lab(dr.Item("cod_Examen_Lab"), CStr(dr.Item("nombre")), dr.Item("precioPublico"), dr.Item("precioCerin"), CStr(dr.Item("estado")), CInt(dr.Item("cod_CentroConvenio")), CInt(dr.Item("cod_TipoExamen"))))
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
    Public Function ListarTipoExamen(ByVal nombre As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamenLab_TipoExam", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen_Lab) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_TipoExam", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen_Lab)
            Do While (dr.Read)
                ListP.Add(New Examen_Lab(dr.Item("cod_Examen_Lab"), CStr(dr.Item("nombre")), dr.Item("precioPublico"), dr.Item("precioCerin"), CStr(dr.Item("estado")), CInt(dr.Item("cod_CentroConvenio")), CInt(dr.Item("cod_TipoExamen"))))
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
    Public Function ListarExamenLab(ByVal cod As Integer, ByVal codTipo As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_Laboratorio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen_Lab) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Centro", cod)
        cmd.Parameters.AddWithValue("@cod_Tipo", codTipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen_Lab)
            Do While (dr.Read)
                ListP.Add(New Examen_Lab(dr.Item("cod_Examen_Lab"), CStr(dr.Item("nombre")), dr.Item("precioPublico"), dr.Item("precioCerin"), CStr(dr.Item("estado")), CInt(dr.Item("cod_CentroConvenio")), CInt(dr.Item("cod_TipoExamen"))))
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