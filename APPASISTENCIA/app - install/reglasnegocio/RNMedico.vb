Public Class RNMedico

    Public Sub Registrar(ByVal wMedico As Medico)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_iMedico", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@nombre", wMedico.nombre)
            .AddWithValue("@apPaterno", wMedico.apPaterno)
            .AddWithValue("@dni", wMedico.dni)
            .AddWithValue("@sexo", wMedico.sexo)
            .AddWithValue("@edad", wMedico.edad)

            .AddWithValue("@fechaNac", wMedico.fechaNac)
            .AddWithValue("@direccion", wMedico.direccion)
            .AddWithValue("@telefono", wMedico.telefono)
            .AddWithValue("@mail", wMedico.mail)
            .AddWithValue("@celular", wMedico.celular)
            .AddWithValue("@estado", wMedico.estado)
            .AddWithValue("@cod_Distrito", wMedico.cod_Distrito)
            .AddWithValue("@cod_Provincia", wMedico.cod_Provincia)
            .AddWithValue("@cod_Departamento", wMedico.cod_Departamento)
            .AddWithValue("@apMaterno", wMedico.apMaterno)

            .AddWithValue("@especialidad", wMedico.especialidad)
            .AddWithValue("@rm", wMedico.rm)
            .AddWithValue("@re", wMedico.re)
            .AddWithValue("@centro_Trabajo", wMedico.centro_Trabajo)
            .AddWithValue("@porcentaje_Examen", wMedico.porcentaje_Examen)
            .AddWithValue("@porcentaje_Proc", wMedico.porcentaje_Proc)

            .AddWithValue("@telef_referencia1", wMedico.TelefReferencia1)
            .AddWithValue("@telef_referencia2", wMedico.TelefReferencia2)
            .AddWithValue("@trabajacerin ", wMedico.TrabajaCerin)
            .AddWithValue("@porcentaje_Tomo ", wMedico.Porcentaje_Tomo)

            .AddWithValue("@tipodoc", wMedico.TipoDoc)

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
    Public Sub Modificar(ByVal wMedico As Medico)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_aMedico", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Medico", wMedico.Cod_Medico)
            .AddWithValue("@nombre", wMedico.nombre)
            .AddWithValue("@apPaterno", wMedico.apPaterno)
            .AddWithValue("@dni", wMedico.dni)
            .AddWithValue("@sexo", wMedico.sexo)
            .AddWithValue("@edad", wMedico.edad)

            'asi tienes q ponerle para q acepte nulos

            .AddWithValue("@fechaNac", wMedico.fechaNac)
            .AddWithValue("@direccion", wMedico.direccion)
            .AddWithValue("@telefono", wMedico.telefono)
            .AddWithValue("@mail", wMedico.mail)
            .AddWithValue("@celular", wMedico.celular)
            .AddWithValue("@estado", wMedico.estado)
            .AddWithValue("@cod_Distrito", wMedico.cod_Distrito)
            .AddWithValue("@cod_Provincia", wMedico.cod_Provincia)
            .AddWithValue("@cod_Departamento", wMedico.cod_Departamento)
            .AddWithValue("@apMaterno", wMedico.apMaterno)

            .AddWithValue("@especialidad", wMedico.especialidad)
            .AddWithValue("@rm", wMedico.rm)
            .AddWithValue("@re", wMedico.re)
            .AddWithValue("@centro_Trabajo", wMedico.centro_Trabajo)
            .AddWithValue("@porcentaje_Examen", wMedico.porcentaje_Examen)
            .AddWithValue("@porcentaje_Proc", wMedico.porcentaje_Proc)
            .AddWithValue("@telef_referencia1", wMedico.TelefReferencia1)
            .AddWithValue("@telef_referencia2", wMedico.TelefReferencia2)
            .AddWithValue("@trabajacerin ", wMedico.TrabajaCerin)
            .AddWithValue("@porcentaje_Tomo ", wMedico.Porcentaje_Tomo)

            .AddWithValue("@tipodoc", wMedico.TipoDoc)
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
    Public Function Leer(ByVal wMedico As Medico) As Medico
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("pr_lMedico", cn)
        Dim dr As SqlDataReader = Nothing
        Dim dato As Medico = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@cod_Medico", wMedico.Cod_Medico)
        End With

        Try
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read = True Then

                dato = New Medico(wMedico.cod_Persona, CStr(dr.Item("tipodoc")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("dni")), CBool(dr.Item("sexo")), CStr(dr.Item("edad")), CDate(dr.Item("fechaNac")),
                                 CStr(dr.Item("direccion")), CStr(dr.Item("telefono")), CStr(dr.Item("mail")), CStr(dr.Item("celular")), CStr(dr.Item("estado")), CStr(dr.Item("cod_Distrito")), CStr(dr.Item("cod_Provincia")), CStr(dr.Item("cod_Departamento")),
                                 CStr(dr.Item("apMaterno")), CStr(dr.Item("especialidad")), CStr(dr.Item("rm")), CStr(dr.Item("re")), CStr(dr.Item("centro_Trabajo")), CDbl(dr.Item("porcentaje_Examen")), dr.Item("Cod_Medico"), CStr(dr.Item("porcentaje_Proc")), CStr(dr.Item("Telef_Referencia1")), CStr(dr.Item("Telef_Referencia2")), CBool(dr.Item("trabajacerin")), CDbl(dr.Item("porcentaje_Tomo")))
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

    Public Function ListarxNombre(ByVal nombre As String) As List(Of Medico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarMedico_Nombre", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Medico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cadena", nombre)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Medico)
            Do While (dr.Read)
                ListP.Add(New Medico(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("porcentaje_Examen"), dr.Item("porcentaje_Proc")))
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

    Public Function ListarxDni(ByVal dni As String) As List(Of Medico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_listarMedico_Dni", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Medico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni", dni)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Medico)
            Do While (dr.Read)
                ListP.Add(New Medico(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("porcentaje_Examen"), dr.Item("porcentaje_Proc")))


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

    Public Function ListarxPeriodo(ByVal periodo As String) As List(Of Medico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_LiMedicosxPeriodo", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Medico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@periodoid", periodo)


        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Medico)
            Do While (dr.Read)
                ListP.Add(New Medico(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), dr.Item("porcentaje_Examen"), dr.Item("porcentaje_Proc")))


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

    Public Function ListaTrabCerin() As List(Of Medico)
        Dim cn As New SqlConnection(My.Settings.conexion)

        Dim cmd As New SqlCommand("pr_LiMedicosTrabCerin", cn)
        Dim dr As SqlDataReader = Nothing
        Dim ListP As List(Of Medico) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListP = New List(Of Medico)
            Do While (dr.Read)
                ListP.Add(New Medico(CInt(dr.Item("cod_Persona")), CStr(dr.Item("nombre")), CStr(dr.Item("apPaterno")), CStr(dr.Item("apMaterno")), CStr(dr.Item("dni")), 0, 0))
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