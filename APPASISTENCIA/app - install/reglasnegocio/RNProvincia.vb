Imports System.Data.SqlClient

Public Class RNProvincia

    Public Sub Registrar(ByVal wProvincia As Provincia)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iProvincia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Provincia", wProvincia.cod_Provincia)
            .AddWithValue("@nombre_Prov", wProvincia.nombre_Prov)
            .AddWithValue("@cod_Departamento", wProvincia.cod_Departamento)
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
    Public Sub Modificar(ByVal wProvincia As Provincia)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aProvincia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Provincia", wProvincia.cod_Provincia)
            .AddWithValue("@nombre_Prov", wProvincia.nombre_Prov)
            .AddWithValue("@cod_Departamento", wProvincia.cod_Departamento)
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
    Public Function Leer(ByVal wProvincia As Provincia) As Provincia
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lProvincia", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Provincia = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Provincia", wProvincia.cod_Provincia)
            .AddWithValue("@cod_Departamento", wProvincia.cod_Departamento)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Provincia(wProvincia.cod_Provincia, CStr(dr.Item("nombre_Prov")), wProvincia.cod_Departamento)
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

    Public Function Listar(ByVal Codigo_Dep As String) As List(Of Provincia)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_ListarProvincias", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListT As List(Of PROVINCIA) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Departamento", Codigo_Dep)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListT = New List(Of PROVINCIA)
            Do While (dr.Read)
                ListT.Add(New Provincia(dr.Item("cod_Provincia").ToString, dr.Item("nombre_Prov").ToString, dr.Item("cod_Departamento").ToString))
            Loop
        Catch ex As Exception
            If ListT IsNot Nothing Then
                ListT.Clear()
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
        Return ListT
    End Function

End Class