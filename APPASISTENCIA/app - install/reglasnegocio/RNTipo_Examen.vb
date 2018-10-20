Imports System.Data.SqlClient

Public Class RNTipo_Examen

    Public Function Listar() As List(Of Tipo_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarTipoExamen", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Tipo_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Tipo_Examen)
            Do While (dr.Read)
                ListP.Add(New Tipo_Examen(CStr(dr.Item("cod_TipoExamen")), CStr(dr.Item("nombre"))))

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

    Public Function ListarxCentro(ByVal codcentro As Integer) As List(Of Tipo_Examen)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_ListarTipoExamen_Cli", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Tipo_Examen) = Nothing

        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@codigo", codcentro)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Tipo_Examen)
            Do While (dr.Read)
                ListP.Add(New Tipo_Examen(CStr(dr.Item("cod_TipoExamen")), CStr(dr.Item("nombre"))))

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