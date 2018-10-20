Imports System.Data.SqlClient

Public Class RNPlan_Atencion

    Public Sub Registrar(ByVal wPlan_Atencion As Plan_Atencion)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iPlan_Atencion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@descripcion", wPlan_Atencion.descripcion)
            .AddWithValue("@descuento", wPlan_Atencion.descuento)
            .AddWithValue("@precio", wPlan_Atencion.descuento)
            .AddWithValue("@estado", wPlan_Atencion.estado)
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
    Public Sub Modificar(ByVal wPlan_Atencion As Plan_Atencion)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_aPlan_Atencion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_PlanAtencion", wPlan_Atencion.cod_PlanAtencion)
            .AddWithValue("@descripcion", wPlan_Atencion.descripcion)
            .AddWithValue("@descuento", wPlan_Atencion.descuento)
            .AddWithValue("@precio", wPlan_Atencion.Precio)

            .AddWithValue("@estado", wPlan_Atencion.estado)
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
    Public Function Leer(ByVal wPlan_Atencion As Plan_Atencion) As Plan_Atencion
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lPlan_Atencion", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Plan_Atencion = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_PlanAtencion", wPlan_Atencion.cod_PlanAtencion)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Plan_Atencion(wPlan_Atencion.cod_PlanAtencion, CStr(dr.Item("descripcion")), CDec(dr.Item("descuento")), CDec(dr.Item("precio")), CStr(dr.Item("estado")))
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


    Public Function ListarNombre(ByVal nombre As String) As List(Of Plan_Atencion)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPlanes_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Plan_Atencion) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@descripcion", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Plan_Atencion)
            Do While (dr.Read)
                ListP.Add(New Plan_Atencion(CStr(dr.Item("cod_PlanAtencion")), CStr(dr.Item("descripcion")), dr.Item("descuento"), CStr(dr.Item("estado"))))
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
    Public Function Listar() As List(Of Plan_Atencion)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarPlanes", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Plan_Atencion) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Plan_Atencion)
            Do While (dr.Read)
                ListP.Add(New Plan_Atencion(CStr(dr.Item("cod_PlanAtencion")), CStr(dr.Item("descripcion")), dr.Item("descuento"), dr.Item("precio"), CStr(dr.Item("estado"))))
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