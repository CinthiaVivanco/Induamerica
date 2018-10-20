Imports System.Data.SqlClient

Public Class RNDistrito

    Public Sub Registrar(ByVal wDistrito As Distrito)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iDistrito", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Distrito", wDistrito.cod_Distrito)
            .AddWithValue("@nombre_Dist", wDistrito.nombre_Dist)
            .AddWithValue("@cod_Provincia", wDistrito.cod_Provincia)
            .AddWithValue("@cod_Departamento", wDistrito.cod_Departamento)
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
    Public Sub Modificar(ByVal wDistrito As Distrito)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aDistrito", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Distrito", wDistrito.cod_Distrito)
            .AddWithValue("@nombre_Dist", wDistrito.nombre_Dist)
            .AddWithValue("@cod_Provincia", wDistrito.cod_Provincia)
            .AddWithValue("@cod_Departamento", wDistrito.cod_Departamento)
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
    Public Function Leer(ByVal wDistrito As Distrito) As Distrito
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lDistrito", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Distrito = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Distrito", wDistrito.cod_Distrito)
            .AddWithValue("@cod_Provincia", wDistrito.cod_Provincia)
            .AddWithValue("@cod_Departamento", wDistrito.cod_Departamento)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Distrito(wDistrito.cod_Distrito, CStr(dr.Item("nombre_Dist")), wDistrito.cod_Provincia, wDistrito.cod_Departamento)
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

    Public Function Listar(ByVal Codigo_Dep As String, ByVal codigo_Prov As String) As List(Of Distrito)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_ListarDistritos", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListT As List(Of DISTRITO) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Departamento", Codigo_Dep)
        cmd.Parameters.AddWithValue("@cod_Provincia", codigo_Prov)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListT = New List(Of DISTRITO)
            Do While (dr.Read)
                ListT.Add(New Distrito(dr.Item("cod_Distrito").ToString, dr.Item("nombre_Dist").ToString, dr.Item("cod_Provincia").ToString, dr.Item("cod_Departamento").ToString))
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