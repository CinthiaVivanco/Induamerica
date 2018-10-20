Imports System.Data.SqlClient

Public Class RNCentro_Convenio

    Public Sub Registrar(ByVal wCentro_Convenio As Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iCentro_Convenio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@tipo", wCentro_Convenio.tipo)
            .AddWithValue("@razonSocial", wCentro_Convenio.razonSocial)
            .AddWithValue("@ruc", wCentro_Convenio.ruc)
            .AddWithValue("@telefono", wCentro_Convenio.telefono)
            .AddWithValue("@celular", wCentro_Convenio.celular)
            .AddWithValue("@direccion", wCentro_Convenio.direccion)
            .AddWithValue("@cod_Distrito", wCentro_Convenio.cod_Distrito)
            .AddWithValue("@cod_Provincia", wCentro_Convenio.cod_Provincia)
            .AddWithValue("@cod_Departamento", wCentro_Convenio.cod_Departamento)
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
    Public Sub Modificar(ByVal wCentro_Convenio As Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aCentro_Convenio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_CentroConvenio", wCentro_Convenio.cod_CentroConvenio)
            .AddWithValue("@tipo", wCentro_Convenio.tipo)
            .AddWithValue("@razonSocial", wCentro_Convenio.razonSocial)
            .AddWithValue("@ruc", wCentro_Convenio.ruc)
            .AddWithValue("@telefono", wCentro_Convenio.telefono)
            .AddWithValue("@celular", wCentro_Convenio.celular)
            .AddWithValue("@direccion", wCentro_Convenio.direccion)
            .AddWithValue("@cod_Distrito", wCentro_Convenio.cod_Distrito)
            .AddWithValue("@cod_Provincia", wCentro_Convenio.cod_Provincia)
            .AddWithValue("@cod_Departamento", wCentro_Convenio.cod_Departamento)
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
    Public Function Leer(ByVal wCentro_Convenio As Centro_Convenio) As Centro_Convenio
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lCentro_Convenio", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Centro_Convenio = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_CentroConvenio", wCentro_Convenio.cod_CentroConvenio)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Centro_Convenio(wCentro_Convenio.cod_CentroConvenio, CStr(dr.Item("tipo")), CStr(dr.Item("razonSocial")), CStr(dr.Item("ruc")), CStr(dr.Item("telefono")), CStr(dr.Item("celular")), CStr(dr.Item("direccion")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")))
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

    Public Function Listar() As List(Of Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarCentros", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Centro_Convenio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Centro_Convenio)
            Do While (dr.Read)
                ListP.Add(New Centro_Convenio(CStr(dr.Item("cod_CentroConvenio")), CStr(dr.Item("tipo")), CStr(dr.Item("razonSocial")), CStr(dr.Item("ruc")), CStr(dr.Item("telefono")),
                                              CStr(dr.Item("celular")), CStr(dr.Item("direccion")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento"))))

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
    Public Function ListarC(ByVal tipo As String) As List(Of Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarCentrosConvenios", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Centro_Convenio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@tipo", tipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Centro_Convenio)
            Do While (dr.Read)
                ListP.Add(New Centro_Convenio(CStr(dr.Item("cod_CentroConvenio")), CStr(dr.Item("tipo")), CStr(dr.Item("razonSocial")), CStr(dr.Item("ruc")), CStr(dr.Item("telefono")),
                                              CStr(dr.Item("celular")), CStr(dr.Item("direccion")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento"))))

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
    
    Public Function ListarNombreCentro(ByVal nombre As String, ByVal tipo As String) As List(Of Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCentros_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Centro_Convenio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@rsocial", nombre)
        cmd.Parameters.AddWithValue("@tipo", tipo)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Centro_Convenio)
            Do While (dr.Read)
                ListP.Add(New Centro_Convenio(CStr(dr.Item("cod_CentroConvenio")), CStr(dr.Item("tipo")), dr.Item("razonSocial"), CStr(dr.Item("ruc")), CStr(dr.Item("telefono")), CStr(dr.Item("celular")),
                                              CStr(dr.Item("direccion")), dr.Item("cod_Distrito"), dr.Item("cod_Provincia"), dr.Item("cod_Departamento")))
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
    Public Function ListarCerin() As List(Of Centro_Convenio)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCentrosCerin", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Centro_Convenio) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Centro_Convenio)
            Do While (dr.Read)
                ListP.Add(New Centro_Convenio(CStr(dr.Item("cod_CentroConvenio")), CStr(dr.Item("tipo")), dr.Item("razonSocial"), CStr(dr.Item("ruc")), CStr(dr.Item("telefono")), CStr(dr.Item("celular")),
                                              CStr(dr.Item("direccion")), dr.Item("cod_Distrito"), dr.Item("cod_Provincia"), dr.Item("cod_Departamento")))
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