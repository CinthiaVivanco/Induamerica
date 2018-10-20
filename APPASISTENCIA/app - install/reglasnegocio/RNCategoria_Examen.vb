Imports System.Data.SqlClient
Public Class RNCategoria_Examen

    Public Sub Registrar(ByVal wCategoria_Examen As Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_iCategoria_Examen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@nombre", wCategoria_Examen.nombre)
            .AddWithValue("@precio", wCategoria_Examen.precio)
            .AddWithValue("@estado", wCategoria_Examen.estado)
            .AddWithValue("@cod_CentroConvenio", wCategoria_Examen.cod_Centro)
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
    Public Sub Modificar(ByVal wCategoria_Examen As Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_aCategoria_Examen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Categoria", wCategoria_Examen.cod_Categoria)
            .AddWithValue("@nombre", wCategoria_Examen.nombre)
            .AddWithValue("@precio", wCategoria_Examen.precio)
            .AddWithValue("@estado", wCategoria_Examen.estado)
            .AddWithValue("@cod_CentroConvenio", wCategoria_Examen.cod_Centro)
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
    Public Function Leer(ByVal wCategoria_Examen As Categoria_Examen) As Categoria_Examen
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lCategoria_Examen", cn)
        Dim dr As SQLDataReader = Nothing
        Dim dato As Categoria_Examen = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Categoria", wCategoria_Examen.cod_Categoria)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dato = New Categoria_Examen(wCategoria_Examen.cod_Categoria, CStr(dr.Item("nombre")), CDec(dr.Item("precio")), CStr((dr.Item("estado"))), dr.Item("cod_CentroConvenio"))
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
    Public Function Listar() As List(Of Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarCategorias", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Categoria_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Categoria_Examen)
            Do While (dr.Read)
                ListP.Add(New Categoria_Examen(dr.Item("cod_Categoria"), CStr(dr.Item("nombre")), CDec(dr.Item("precio")), CStr((dr.Item("estado"))), dr.Item("@cod_CentroConvenio")))
                
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
    Public Function ListarNombre(ByVal nombre As String) As List(Of Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCategorias_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Categoria_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombre", nombre)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Categoria_Examen)
            Do While (dr.Read)
                ListP.Add(New Categoria_Examen(dr.Item("cod_Categoria"), CStr(dr.Item("nombre")), CDec(dr.Item("precio")), CStr((dr.Item("estado"))), dr.Item("cod_CentroConvenio")))
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
    Public Function ListarCentro(ByVal centro As Integer) As List(Of Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCategorias_Centro", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Categoria_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_Centro", centro)

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Categoria_Examen)
            Do While (dr.Read)
                ListP.Add(New Categoria_Examen(dr.Item("cod_Categoria"), CStr(dr.Item("nombre")), CDec(dr.Item("precio")), CStr((dr.Item("estado"))), dr.Item("cod_CentroConvenio")))
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

    Public Function ListarCentroCerin() As List(Of Categoria_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarCategorias_Cerin", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Categoria_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Categoria_Examen)
            Do While (dr.Read)
                ListP.Add(New Categoria_Examen(dr.Item("cod_Categoria"), CStr(dr.Item("nombre")), CDec(dr.Item("precio")), CStr((dr.Item("estado"))), dr.Item("cod_CentroConvenio")))
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