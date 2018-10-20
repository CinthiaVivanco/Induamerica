Public Class RNMaterialExamen

    Public Function Registrar(ByVal wMaterialExamen As MaterialExamen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iMaterialExamen", cn)
        Dim codigo As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_material", 0).Direction = ParameterDirection.Output
            .AddWithValue("@fecha", wMaterialExamen.fecha)
            .AddWithValue("@estado", wMaterialExamen.estado)
            .AddWithValue("@cod_tecnologo", wMaterialExamen.cod_tecnologo)
            .AddWithValue("@cod_Consulta", wMaterialExamen.cod_Consulta)
            .AddWithValue("@tipo", wMaterialExamen.tipo)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_material").Value)
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

	Public Sub Modificar(Byval wMaterialExamen AS MaterialExamen)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aMaterialExamen", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_material", wMaterialExamen.cod_material)
			.AddWithValue("@fecha", wMaterialExamen.fecha)
			.AddWithValue("@estado", wMaterialExamen.estado)
			.AddWithValue("@cod_tecnologo", wMaterialExamen.cod_tecnologo)
			.AddWithValue("@cod_Consulta", wMaterialExamen.cod_Consulta)
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

	Public Function Leer(Byval wMaterialExamen AS MaterialExamen) AS MaterialExamen
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lMaterialExamen", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As MaterialExamen = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_material", wMaterialExamen.cod_material)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New MaterialExamen( wMaterialExamen.cod_material,CDate( dr.Item("fecha") ),CStr( dr.Item("estado") ),CInt( dr.Item("cod_tecnologo") ),CInt( dr.Item("cod_Consulta") ) )
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


    Public Function LeerxConsulta(ByVal wCodConsulta As Integer) As MaterialExamen
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lMaterialExamenxConsulta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As MaterialExamen = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_consulta", wCodConsulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New MaterialExamen(CInt(dr.Item("cod_material")), CDate(dr.Item("fecha")), CStr(dr.Item("estado")), CInt(dr.Item("cod_tecnologo")), CInt(dr.Item("cod_Consulta")))
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

    Public Function LeerxConsultaExtra(ByVal wCodConsulta As Integer) As MaterialExamen
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lMaterialExamenxConsultaExtra", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As MaterialExamen = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_consulta", wCodConsulta)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New MaterialExamen(CInt(dr.Item("cod_material")), CDate(dr.Item("fecha")), CStr(dr.Item("estado")), CInt(dr.Item("cod_tecnologo")), CInt(dr.Item("cod_Consulta")))
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



End Class