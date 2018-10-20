Public Class RNAsistencia

	Public Sub Registrar(Byval wAsistencia AS Asistencia)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iAsistencia", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
            .AddWithValue("@idasistenca", wAsistencia.Usuario)
            .AddWithValue("@variableenviar", wAsistencia.tipo)
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

    
    Public Function Validar(ByVal wdni As String) As DataSet
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("ValidarAsistencia", cn)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            With adaptador.SelectCommand.Parameters
                .AddWithValue("@dni", wdni)
            End With

            Dim dt As New DataSet
            adaptador.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function


	Public Function Leer(Byval wAsistencia AS Asistencia) AS Asistencia
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lAsistencia", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Asistencia = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New Asistencia(CInt( dr.Item("Cod_asistencia") ),CInt( dr.Item("Cod_turno") ),CStr( dr.Item("Usuario") ),CStr( dr.Item("tipo") ),CDate( dr.Item("Hora") ),CDate( dr.Item("HoraServidor") ),CStr( dr.Item("observacion") ) )
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

    Public Function FechaActual() As DataTable
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_lPAfechaEstHActual", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim dt As New DataTable
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarPersonalHuella() As DataTable
        Try
            Dim cn As New SqlConnection(My.Settings.conexion)

            Dim adaptador As New SqlDataAdapter("pr_consultar_personal_huella", cn)

            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim dt As New DataTable
            adaptador.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class