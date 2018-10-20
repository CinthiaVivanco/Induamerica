Public Class RNExamen

	Public Sub Registrar(Byval wExamen AS Examen)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iExamen", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@nombre", wExamen.nombre)
			.AddWithValue("@tipo", wExamen.tipo)
			.AddWithValue("@precio", wExamen.precio)
			.AddWithValue("@cod_Categoria", wExamen.cod_Categoria)
			.AddWithValue("@estado", wExamen.estado)
			.AddWithValue("@cod_TipoExamen", wExamen.cod_TipoExamen)
			.AddWithValue("@cod_CentroConvenio", wExamen.cod_CentroConvenio)
            .AddWithValue("@precioConv", wExamen.precioConv)
            .AddWithValue("@cod_formato", wExamen.Formato.cod_Formato)
            .AddWithValue("@contenido", IIf(wExamen.Formato.contenido Is Nothing, "", wExamen.Formato.contenido))
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
	Public Sub Modificar(Byval wExamen AS Examen)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aExamen", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Examen", wExamen.cod_Examen)
			.AddWithValue("@nombre", wExamen.nombre)
			.AddWithValue("@tipo", wExamen.tipo)
			.AddWithValue("@precio", wExamen.precio)
			.AddWithValue("@cod_Categoria", wExamen.cod_Categoria)
			.AddWithValue("@estado", wExamen.estado)
			.AddWithValue("@cod_TipoExamen", wExamen.cod_TipoExamen)
            .AddWithValue("@cod_CentroConvenio", wExamen.cod_CentroConvenio)
            .AddWithValue("@precioConv", wExamen.precioConv)
            .AddWithValue("@cod_formato", wExamen.Formato.cod_Formato)
            .AddWithValue("@contenido", wExamen.Formato.contenido)
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

    Public Sub ModificarPrecioReporte(ByVal wExamen As Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aExamenPrecioReporte", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Examen", wExamen.cod_Examen)
            .AddWithValue("@precioreporte", wExamen.precioreporte)
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

	Public Function Leer(Byval wExamen AS Examen) AS Examen
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lExamen", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As Examen = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@cod_Examen", wExamen.cod_Examen)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then

                dato = New Examen(wExamen.cod_Examen, CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato"), dr.Item("contenido"))
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

    Public Function ListarE(ByVal cod As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Centro", cod)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato")))
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

    Public Function ListarExInformes(ByVal cod As Integer, ByVal tipo As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_Informe", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_CentroConvenio", cod)
        cmd.Parameters.AddWithValue("@cod_tipo", tipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato")))
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

    Public Function ListarNombreExamen(ByVal nombre As String)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombre", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato")))
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

        Dim cmd As New SqlCommand("pr_listarExamen_TipoExam", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_TipoExam", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CInt(dr.Item("cod_formato")), CDbl(dr.Item("precioConv"))))
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


    Public Function ListarTipoExamenReporte(ByVal nombre As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_TipoExam", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_TipoExam", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CDbl(dr.Item("precio")), CDbl(dr.Item("precioreporte"))))
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

    Public Function ListarExamenCentro(ByVal cod As Integer, ByVal codTipo As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_CentroConvenio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Centro", cod)
        cmd.Parameters.AddWithValue("@cod_Tipo", codTipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato"), Nothing))
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

    Public Function ListarExamenCentroConvenio(ByVal cod As Integer, ByVal codTipo As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_Convenios", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Centro", cod)
        cmd.Parameters.AddWithValue("@cod_Tipo", codTipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato"), Nothing))
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
    Public Function ListarExamenCerin(ByVal codTipo As Integer)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarExamen_Cerin", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_Tipo", codTipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Examen)
            Do While (dr.Read)
                ListP.Add(New Examen(dr.Item("cod_Examen"), CStr(dr.Item("nombre")), CStr(dr.Item("tipo")), CDbl(dr.Item("precio")), CInt(dr.Item("cod_Categoria")), CStr(dr.Item("estado")), CInt(dr.Item("cod_TipoExamen")), CInt(dr.Item("cod_CentroConvenio")), CDbl(dr.Item("precioConv")), dr.Item("cod_formato"), False))
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