Imports System.Data.SqlClient

Public Class RNDepartamento

    Public Sub Registrar(ByVal wDepartamento As Departamento)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iDepartamento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Departamento", wDepartamento.cod_Departamento)
            .AddWithValue("@nombre_Dep", wDepartamento.nombre_Dep)
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
    Public Sub Modificar(ByVal wDepartamento As Departamento)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aDepartamento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Departamento", wDepartamento.cod_Departamento)
            .AddWithValue("@nombre_Dep", wDepartamento.nombre_Dep)
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
    Public Function Leer(ByVal wDepartamento As Departamento) As Departamento
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lDepartamento", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Departamento = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Departamento", wDepartamento.cod_Departamento)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Departamento(wDepartamento.cod_Departamento, CStr(dr.Item("nombre_Dep")))
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

    Public Function Listar() As List(Of Departamento)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarDepartamentos", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListT As List(Of Departamento) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListT = New List(Of Departamento)
            Do While (dr.Read)
                ListT.Add(New Departamento(dr.Item("cod_Departamento").ToString, dr.Item("nombre_Dep").ToString))
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