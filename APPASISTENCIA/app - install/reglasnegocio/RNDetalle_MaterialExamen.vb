Public Class RNDetalle_MaterialExamen

	Public Sub Registrar(Byval wDetalle_MaterialExamen AS Detalle_MaterialExamen)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iDetalle_MaterialExamen", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_material", wDetalle_MaterialExamen.cod_material)
			.AddWithValue("@cod_Producto", wDetalle_MaterialExamen.cod_Producto)
			.AddWithValue("@cantidad", wDetalle_MaterialExamen.cantidad)
			.AddWithValue("@malas", wDetalle_MaterialExamen.malas)
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

    Public Function RegistrarK(ByVal wDetalle_MaterialExamen As Detalle_MaterialExamen) As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iDetalle_MaterialExamenK", cn)
        Dim codigo As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleMaterial", 0).Direction = ParameterDirection.Output

            .AddWithValue("@cod_material", wDetalle_MaterialExamen.cod_material)
            .AddWithValue("@cod_Producto", wDetalle_MaterialExamen.cod_Producto)
            .AddWithValue("@cantidad", wDetalle_MaterialExamen.cantidad)
            .AddWithValue("@malas", wDetalle_MaterialExamen.malas)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            codigo = CInt(cmd.Parameters.Item("@cod_DetalleMaterial").Value)
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

   

    Public Sub Modificar(ByVal wDetalle_MaterialExamen As Detalle_MaterialExamen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aDetalle_MaterialExamen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_DetalleMaterial", wDetalle_MaterialExamen.cod_DetalleMaterial)
            .AddWithValue("@cod_material", wDetalle_MaterialExamen.cod_material)
            .AddWithValue("@cod_Producto", wDetalle_MaterialExamen.cod_Producto)
            .AddWithValue("@cantidad", wDetalle_MaterialExamen.cantidad)
            .AddWithValue("@malas", wDetalle_MaterialExamen.malas)
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
	Public Function Leer(Byval wDetalle_MaterialExamen AS Detalle_MaterialExamen) AS Detalle_MaterialExamen
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lDetalle_MaterialExamen", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Detalle_MaterialExamen = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_DetalleMaterial", wDetalle_MaterialExamen.cod_DetalleMaterial)
			.AddWithValue("@cod_material", wDetalle_MaterialExamen.cod_material)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
                dato = New Detalle_MaterialExamen(wDetalle_MaterialExamen.cod_DetalleMaterial, wDetalle_MaterialExamen.cod_material, CInt(dr.Item("cod_Producto")), CDbl(dr.Item("cantidad")), CDbl(dr.Item("malas")))
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


    Public Function ListarxConsultaPlacas(ByVal xCodigoMaterial As Integer, ByVal wcod_Ambiente As Integer) As List(Of Detalle_MaterialExamen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liDetalleMatxConsulta", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_MaterialExamen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Material", xCodigoMaterial)
            .AddWithValue("@cod_Ambiente", wcod_Ambiente)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_MaterialExamen)
            Do While (dr.Read)
                ListP.Add(New Detalle_MaterialExamen(CInt(dr.Item("cod_DetalleMaterial")), xCodigoMaterial, CInt(dr.Item("cod_Producto")), CDbl(dr.Item("cantidad")), CDbl(dr.Item("malas"))))

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

    Public Function ListarxConsultaOtros(ByVal xCodigoMaterial As Integer) As List(Of Detalle_MaterialExamen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_liDetalleMatxConsultaOtros", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Detalle_MaterialExamen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Material", xCodigoMaterial)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Detalle_MaterialExamen)
            Do While (dr.Read)
                ListP.Add(New Detalle_MaterialExamen(CInt(dr.Item("cod_DetalleMaterial")), xCodigoMaterial, CInt(dr.Item("cod_Producto")), CDbl(dr.Item("cantidad")), CDbl(dr.Item("malas"))))

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