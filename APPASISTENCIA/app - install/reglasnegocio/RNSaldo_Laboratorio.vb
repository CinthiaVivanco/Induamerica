Public Class RNSaldo_Laboratorio

    Public Sub Registrar(ByVal wSaldo_Laboratorio As Saldo_Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iSaldo_Laboratorio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@fecha", wSaldo_Laboratorio.fecha)
            .AddWithValue("@saldo", wSaldo_Laboratorio.saldo)
            .AddWithValue("@cod_Laboratorio", wSaldo_Laboratorio.cod_Laboratorio)
            .AddWithValue("@tipopago", wSaldo_Laboratorio.TipoPago)
            .AddWithValue("@cod_Comprobante", wSaldo_Laboratorio.cod_Comprobante)
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
    Public Sub Modificar(ByVal wSaldo_Laboratorio As Saldo_Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aSaldo_Laboratorio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@fecha", wSaldo_Laboratorio.fecha)
            .AddWithValue("@saldo", wSaldo_Laboratorio.saldo)
            .AddWithValue("@tipopag", wSaldo_Laboratorio.TipoPago)
            .AddWithValue("@cod_Laboratorio", wSaldo_Laboratorio.cod_Laboratorio)
            .AddWithValue("@cod_Comprobante", wSaldo_Laboratorio.cod_Comprobante)

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
    Public Function Leer(ByVal wSaldo_Laboratorio As Saldo_Laboratorio) As Saldo_Laboratorio
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lSaldo_Laboratorio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Saldo_Laboratorio = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Saldo", wSaldo_Laboratorio.cod_Saldo)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Saldo_Laboratorio(wSaldo_Laboratorio.cod_Saldo, CDate(dr.Item("fecha")), CDbl(dr.Item("saldo")), CStr(dr.Item("tipopago")), CInt(dr.Item("cod_Laboratorio")), CInt(dr.Item("cod_Comprobante")))
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

    Public Function ListarxLaboratorio(ByVal wCod_Laboratorio As Integer) As List(Of Saldo_Laboratorio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_liSaldo_Laboratorio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Saldo_Laboratorio) = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Laboratorio", wCod_Laboratorio)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Saldo_Laboratorio)
            Do While (dr.Read)
                ListP.Add(New Saldo_Laboratorio(CInt(dr.Item("cod_Saldo")), CDate(dr.Item("fecha")), CDbl(dr.Item("saldo")), CStr(dr.Item("tipopago")), CInt(dr.Item("cod_Laboratorio")), CInt(dr.Item("cod_Comprobante"))))

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