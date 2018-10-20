Public Class RNSISTEMA


    Public Sub registrar(ByVal sistema As SISTEMA)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iSistema", cn)

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@nombre", sistema.Nombre)
            .AddWithValue("@descripcion", sistema.Descripcion)
            .AddWithValue("@vigencia", sistema.Vigencia)
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
    Public Function Leer() As List(Of SISTEMA)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_liSistemas", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Dim ListL As List(Of Sistema) = Nothing

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListL = New List(Of Sistema)
            Do While (dr.Read)
                ListL.Add(New Sistema(CInt(dr.Item("codigoSist")), dr.Item("nombre").ToString, dr.Item("descripcion").ToString, CBool(dr.Item("vigencia"))))

            Loop
        Catch ex As Exception
            If ListL IsNot Nothing Then
                ListL.Clear()
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

        Return ListL


    End Function
    Public Function LeerVigentes() As List(Of SISTEMA)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_liSistemasVigentes", cn)
        Dim dr As SqlDataReader = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Dim ListL As List(Of Sistema) = Nothing

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListL = New List(Of Sistema)
            Do While (dr.Read)
                ListL.Add(New Sistema(CInt(dr.Item("codigoSist")), dr.Item("nombre").ToString, dr.Item("descripcion").ToString, CBool(dr.Item("vigencia"))))
            Loop
        Catch ex As Exception
            If ListL IsNot Nothing Then
                ListL.Clear()
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

        Return ListL


    End Function
    Public Sub Modificar(ByVal sistema As SISTEMA)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_aSistema ", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigoSist", sistema.Codigo)
            .AddWithValue("@nombre", sistema.Nombre)
            .AddWithValue("@descripcion", sistema.Descripcion)
            .AddWithValue("@vigencia", sistema.Vigencia)
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