Public Class RNOPCION

    Public Sub registrar(ByVal opci As OPCION)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iOpcion", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@numeroOpc", opci.Numero)
            .AddWithValue("@sistema", opci.Sistema.Codigo)
            .AddWithValue("@nombre", opci.Nombre)
            .AddWithValue("@descripcion", opci.Descripcion)
            .AddWithValue("@vigencia", opci.Vigencia)
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

    Public Function Leer(ByVal wpro As Integer) As List(Of OPCION)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_liOpcion", cn)
        Dim dr As SqlDataReader = Nothing
        Dim la As New List(Of Opcion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoSist", wpro)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                la.Add(New Opcion(CInt(dr.Item("numeroOpc")), dr.Item("nombre").ToString, dr.Item("descripcion").ToString, CInt(dr.Item("vigencia"))))
            End While
            cn.Close()
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
        Return la

    End Function

    Public Sub Modificar(ByVal opci As OPCION, ByVal numero As Integer)


        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_aOpcion ", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@numero", numero)
            .AddWithValue("@numeroOpc", opci.Numero)
            .AddWithValue("@codigoSist", opci.Sistema.Codigo)
            .AddWithValue("@nombre", opci.Nombre)
            .AddWithValue("@descripcion", opci.Descripcion)
            .AddWithValue("@vigencia", opci.Vigencia)
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