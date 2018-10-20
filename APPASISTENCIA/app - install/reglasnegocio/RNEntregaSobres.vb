Public Class RNEntregaSobres

    Public Sub GenerarxPeriodo(ByVal wEntregaSobres As EntregaSobres)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iEntregaSobresxPeriodo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wEntregaSobres.periodoid)
            .AddWithValue("@usuarioreg", wEntregaSobres.usuarioreg)
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

    Public Sub Registrar(ByVal wEntregaSobres As EntregaSobres)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iEntregaSobres", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", wEntregaSobres.periodoid)
            .AddWithValue("@cod_medico", wEntregaSobres.cod_medico)
            .AddWithValue("@fechareparto", wEntregaSobres.fechareparto)
            .AddWithValue("@fechadevolucion", wEntregaSobres.fechadevolucion)
            .AddWithValue("@fechaentrega", wEntregaSobres.fechaentrega)
            .AddWithValue("@devolvio", wEntregaSobres.devolvio)
            .AddWithValue("@recogiocerin", wEntregaSobres.recogiocerin)
            .AddWithValue("@fechacerin", wEntregaSobres.fechacerin)
            .AddWithValue("@observacion", wEntregaSobres.observacion)
            .AddWithValue("@usuarioreg", wEntregaSobres.usuarioreg)
            .AddWithValue("@usuariomod", wEntregaSobres.usuariomod)
            .AddWithValue("@fechamod", wEntregaSobres.fechamod)

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

	Public Sub Modificar(Byval wEntregaSobres AS EntregaSobres)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aEntregaSobres", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wEntregaSobres.periodoid)
			.AddWithValue("@cod_medico", wEntregaSobres.cod_medico)
			.AddWithValue("@fechareparto", wEntregaSobres.fechareparto)
			.AddWithValue("@fechadevolucion", wEntregaSobres.fechadevolucion)
			.AddWithValue("@fechaentrega", wEntregaSobres.fechaentrega)
			.AddWithValue("@devolvio", wEntregaSobres.devolvio)
            .AddWithValue("@recogiocerin", wEntregaSobres.recogiocerin)
			.AddWithValue("@fechacerin", wEntregaSobres.fechacerin)
			.AddWithValue("@observacion", wEntregaSobres.observacion)
            .AddWithValue("@usuarioreg", wEntregaSobres.usuarioreg)
            .AddWithValue("@usuariomod", wEntregaSobres.usuariomod)
            .AddWithValue("@fechamod", wEntregaSobres.fechamod)

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
	Public Function Leer(Byval wEntregaSobres AS EntregaSobres) AS EntregaSobres
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lEntregaSobres", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As EntregaSobres = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@periodoid", wEntregaSobres.periodoid)
			.AddWithValue("@cod_medico", wEntregaSobres.cod_medico)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New EntregaSobres(wEntregaSobres.periodoid, wEntregaSobres.cod_medico, CDate(dr.Item("fechareparto")), CDate(dr.Item("fechadevolucion")), CDate(dr.Item("fechaentrega")), CBool(dr.Item("devolvio")), CBool(dr.Item("recogiocerin")), CDate(dr.Item("fechacerin")), CStr(dr.Item("observacion")), CStr(dr.Item("usuarioreg")), CStr(dr.Item("usuariomod")), CDate(dr.Item("fechamod")))

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

    Public Function ListarxPeriodo(ByVal periodoid As String) As List(Of EntregaSobres)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liEntregaSobresxPeriodo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of EntregaSobres) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@periodoid", periodoid)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of EntregaSobres)
            Do While (dr.Read)
                ListP.Add(New EntregaSobres(CStr(dr.Item("periodoid")), CInt(dr.Item("cod_medico")), CDate(dr.Item("fechareparto")), CDate(dr.Item("fechadevolucion")), CDate(dr.Item("fechaentrega")), CBool(dr.Item("devolvio")), CBool(dr.Item("recogiocerin")), CDate(dr.Item("fechacerin")), CStr(dr.Item("observacion")), CStr(dr.Item("usuarioreg")), CStr(dr.Item("usuariomod")), CDate(dr.Item("fechamod")), CStr(dr.Item("APPATERNO")), CStr(dr.Item("apMaterno")), CStr(dr.Item("nombre"))))
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