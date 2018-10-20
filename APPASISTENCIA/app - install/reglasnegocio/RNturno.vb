Public Class RNturno

	Public Sub Registrar(Byval wturno AS turno)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iturno", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Abrev", wturno.Abrev)
			.AddWithValue("@Nombre", wturno.Nombre)
			.AddWithValue("@HoraIni", wturno.HoraIni)
			.AddWithValue("@HoraFin", wturno.HoraFin)
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
	Public Sub Modificar(Byval wturno AS turno)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aturno", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@Cod_turno", wturno.Cod_turno)
			.AddWithValue("@Abrev", wturno.Abrev)
			.AddWithValue("@Nombre", wturno.Nombre)
			.AddWithValue("@HoraIni", wturno.HoraIni)
			.AddWithValue("@HoraFin", wturno.HoraFin)
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
	Public Function Leer(Byval wturno AS turno) AS turno
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lturno", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As turno = Nothing
		cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@Cod_turno", wturno.Cod_turno)
        End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New turno(CInt( dr.Item("Cod_turno") ),CStr( dr.Item("Abrev") ),CStr( dr.Item("Nombre") ),CDate( dr.Item("HoraIni") ),CDate( dr.Item("HoraFin") ) )
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

    Public Function Listar() As List(Of turno)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liturno", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of turno) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of turno)
            Do While (dr.Read)
                ListP.Add(New turno(CInt(dr.Item("Cod_turno")), CStr(dr.Item("Abrev")), CStr(dr.Item("Nombre")), CDate(dr.Item("HoraIni")), CDate(dr.Item("HoraFin"))))
                
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

    Public Function ListarxUsuario(ByVal xcod_Usuario As Integer) As List(Of turno)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liturnoxUsuario", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of turno) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@CodigoUsu", xcod_Usuario)
        End With
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of turno)
            Do While (dr.Read)
                ListP.Add(New turno(CInt(dr.Item("Cod_turno")), CStr(dr.Item("Abrev")), CStr(dr.Item("Nombre")), CDate(dr.Item("HoraIni")), CDate(dr.Item("HoraFin"))))

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