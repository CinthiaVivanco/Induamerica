Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class frmUsuario
    Private a As Persona = Nothing
    Private cod As Integer
    Private grupo As Integer




#Region "HuellaDigital"
    Private FMatchType As Integer
    Private fpcHandle As Integer
    Private FAutoIdentify As Boolean
    Private codigo As String
    Private Accion As String
    Private NewHuella As String
    ''VARIABLES
    Dim sTemp As String
    Dim fingerid As Integer
    Dim FRegTemplate As Object
    Dim fi As Long

    Private Sub Iniciar_Sensor()
        Try
            If (ZKFPEngX1.InitEngine() = 0) Then

                FMatchType = 2
                UltraLabel14.Text = "Sensor connectado"
                If (rbtZkFinger9.Checked) Then
                    ZKFPEngX1.FPEngineVersion = "9"
                Else
                    ZKFPEngX1.FPEngineVersion = "10"
                End If
                'DEVUELVE EL IDENTIFICADOR DE LA HUELLLA
                fpcHandle = ZKFPEngX1.CreateFPCacheDB
                'EDSensorNum.Text = Convert.ToString(ZKFPEngX1.SensorCount)
                'EDSensorIndex.Text = Convert.ToString(ZKFPEngX1.SensorIndex)
                'EDSensorSN.Text = ZKFPEngX1.SensorSN
                ZKFPEngX1.EnrollCount = 3
                UltraLabel14.Text = "Sensor conectado"

            Else
                UltraLabel14.Text = "Error al conectar sensor"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub Iniciar_Registro()
        ZKFPEngX1.CancelEnroll()
        ZKFPEngX1.EnrollCount = 3
        ZKFPEngX1.BeginEnroll()
        UltraLabel14.Text = "Comenzar Registro de Huella"
    End Sub
    Private Sub ZKFPEngX1_OnImageReceived(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent) Handles ZKFPEngX1.OnImageReceived
        'ShowHintImage(0)
        Dim g As Graphics = picHuella.CreateGraphics()
        Dim bmp As New Bitmap(picHuella.Width, picHuella.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc().ToInt32()
        ZKFPEngX1.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        picHuella.Image = bmp
    End Sub

    Private Sub ZKFPEngX1_OnEnroll(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent) Handles ZKFPEngX1.OnEnroll

        Try
            btnHuellaRefresh.Visible = False
            Dim Result As Integer = 0

            If (e.actionResult) Then

                'ShowHintInfo("Huella detectada con exito！")

                Dim ID As Integer
                Dim Score As New Integer()
                Dim ProcessNum As New Integer()

                ID = 0
                Score = 0
                ID = ZKFPEngX1.IdentificationFromStrInFPCacheDB(fpcHandle, ZKFPEngX1.GetTemplateAsString, Score, ProcessNum)

                If ID = -1 Then
                    'ShowHintImage(1)
                    'If MsgBox("Desea Registrar en la Base de Datos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Registro de Huella Dactilar exitosa！") = MsgBoxResult.Yes Then
                    '    'Result = Guardar(TxtNombre.Text.Trim, TxtDni.Text.Trim, ZKFPEngX1.GetTemplateAsStringEx("9") , ZKFPEngX1.GetTemplateAsStringEx("10"))
                    'End If
                    MsgBox("Huella detectada con exito", 64, "Mensaje del Sistema")
                    'PictureBox2.Image = Nothing
                    btnHuellaRefresh.Visible = True
                    NewHuella = "SI"
                Else
                    'ShowHintImage(2)
                    'If Me.Accion = "I" Then
                    MsgBox("Huella ya fue registrada", 48, "Mensaje del Sistema")
                    'End If

                    Call Iniciar_Registro()
                    'PictureBox2.Image = Nothing
                    'Button1.Visible = True
                End If
            Else

                If MessageBox.Show("Ha ocurrido un error en el proceso de registro de la Huella Digital." & vbCrLf & "¿Desea reinicar el Proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call Iniciar_Registro()
                    'ShowHintInfo("Comenzar Registro")
                Else
                    Call Iniciar_Registro()
                    'ShowHintInfo("Comenzar Registro")
                End If
                UltraLabel14.Text = "La detección de Huella a fallado, Comenzar Registro"
                Call Iniciar_Registro()
                Me.picHuella.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub ZKFPEngX1_OnFeatureInfo(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEvent) Handles ZKFPEngX1.OnFeatureInfo

        Dim strTemp As String = "Calidad de Huella:"
        If (e.aQuality <> 0) Then
            strTemp = strTemp + " no es buena"
        Else
            strTemp = strTemp + " buena"
        End If

        If (ZKFPEngX1.EnrollIndex <> 1) Then
            If (ZKFPEngX1.IsRegister) Then
                If (ZKFPEngX1.EnrollIndex - 1 > 0) Then
                    strTemp = strTemp + " Estado: Aun pulse su dedito " + Convert.ToString(ZKFPEngX1.EnrollIndex - 1) + " (veces)!"
                End If
            End If
        End If

        UltraLabel14.Text = strTemp
        'ShowHintInfo(strTemp)
    End Sub



    Private Function ConvertirAByte(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)

        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function
    Private Function ConvertirAImage(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing

        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

#End Region

    Private Sub CargaPersonalHuella()
        Dim obj As New RNUSUARIO
        Dim la As List(Of TRABAJADOR)
        Try


            la = obj.Listar_personal_huella

            Dim i%
            Dim v_decode As Object
            Dim v_decode10 As Object

            If la.Count > 0 Then

                For Each H In la
                    v_decode = ZKFPEngX1.DecodeTemplate1(H.Template)
                    v_decode10 = ZKFPEngX1.DecodeTemplate1(H.Template10)

                    ZKFPEngX1.AddRegTemplateToFPCacheDBEx(fpcHandle, H.dni, v_decode, v_decode10)

                Next

            End If


        Catch ex As Exception
            MsgBox("Sensor NO Detectado ", 48, Me.Text)
        Finally
            obj = Nothing
            la = Nothing
        End Try
    End Sub

    Private Sub btnHuellaRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuellaRefresh.Click
        Call Iniciar_Registro()
        picHuella.Image = Nothing
        btnHuellaRefresh.Visible = False
    End Sub
    Private Sub frmUsuario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            ZKFPEngX1.FreeFPCacheDB(fpcHandle)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.rbtvigente.Checked = True
        Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
        Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")


        'Me.cargagrupo()
        'Me.cbotipollenar()
        cargatabla()

        Iniciar_Sensor()
        Call CargaPersonalHuella()
        limpiar()
        Iniciar_Registro()

    End Sub
    Private Sub cbotipollenar()
        Me.cboTipo.Items.Add("LIMITADO")
        Me.cboTipo.Items.Add("ADMINISTRADOR")
        Me.cboTipo.SelectedIndex = 0
    End Sub
    Private Sub limpiar()
        'Me.cargagrupo()
        Me.txtdni.Text = ""
        Me.txtpaterno.Text = ""
        Me.txtmaterno.Text = ""
        Me.txtnombres.Text = ""
        Me.txtContraseña.Text = ""
        'Me.txtpersona.Text = ""
        'Me.rbtvigente.Checked = True
        'If Me.cbogrupo.Items.Count > 0 Then
        'Me.cbogrupo.SelectedIndex = 0
        'End If
        'Me.cboTipo.SelectedIndex = 0
        'Me.cbogrupo.Enabled = True

        NewHuella = "NO"
        picHuella.Image = Nothing
        Me.btnHuellaRefresh.Visible = False
        lblTieneHuella.Text = ""


    End Sub
    Private Sub cargagrupo()
        Dim obj As New RNGRUPO_USUARIO
        Dim la As List(Of GRUPO_USUARIO)
        la = obj.LeerVigentes
        cbogrupo.DisplayMember = "Nombre"
        cbogrupo.ValueMember = "Codigo"
        cbogrupo.DataSource = la
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.limpiar()
        Me.btnregistrar.Text = "&Registrar"

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.limpiar()
        Me.btnregistrar.Text = "&Registrar"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnbuscapersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscapersona.Click
        Dim frmbuscar As New frmBuscaPersona
        Dim obj As RNPersona = Nothing
        a = frmbuscar.Buscar
        frmbuscar.Dispose()
        frmbuscar = Nothing
        If a IsNot Nothing Then
            Me.txtpersona.Text = a.NombreCompleto
        End If

    End Sub

    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click

        Dim TEMPLATE, TEMPLATE10 As String
        Dim foto As Byte() = Nothing
        Dim tiene As String
        Dim xMarHuella As Boolean
        Dim xMarxDni As Boolean

        'If a IsNot Nothing Then
        Dim regla As New RNUSUARIO
        If Me.txtdni.Text.Length > 0 Then

            If picHuella.Image Is Nothing And NewHuella = "NO" Then
                MessageBox.Show("Registre su Huella", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Dim x As Boolean
            'Dim t As Char
            'If Me.rbtvigente.Checked Then
            '    x = True
            'Else
            '    x = False
            'End If
            'If Me.cboTipo.SelectedIndex = 0 Then
            '    t = "L"c
            'Else
            '    t = "A"c
            'End If

            If picHuella.Image Is Nothing Then
                TEMPLATE = ""
                TEMPLATE10 = ""
                'tiene = "NO"
            ElseIf NewHuella = "NO" And picHuella.Image Is Nothing Then
                TEMPLATE = ""
                TEMPLATE10 = ""
                tiene = ""
            ElseIf NewHuella = "SI" Or picHuella.Image IsNot Nothing Then
                tiene = "SI"
                TEMPLATE = ZKFPEngX1.GetTemplateAsStringEx("9")
                TEMPLATE10 = ZKFPEngX1.GetTemplateAsStringEx("10")
                foto = ConvertirAByte(picHuella.Image)
            End If

            If CHKHUELLA.Checked Then
                xMarHuella = 1
            Else
                xMarHuella = 0
            End If

            If CHKDNI.Checked Then
                xMarxDni = 1
            Else
                xMarxDni = 0
            End If



            If Me.btnregistrar.Text = "&Registrar" Then
                If Me.cbogrupo.Items.Count > 0 Then
                    Try
                        Dim rpta As TRABAJADOR = Nothing
                        rpta = regla.verifica(Me.txtnombre.Text)
                        If rpta Is Nothing Then
                            'regla.registrar(New USUARIO(0, New Persona(a.cod_Persona), Me.txtnombre.Text.ToUpper, Me.txtContraseña.Text, t, x, TEMPLATE, TEMPLATE10, foto, xMarHuella, xMarxDni))
                            'rpta = regla.verifica(Me.txtnombre.Text)
                            ' regla.registrar2(rpta, New GRUPO_USUARIO(CInt(Me.cbogrupo.SelectedValue)))
                            MessageBox.Show("Usuario Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else
                            MessageBox.Show("Usuario Existente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error en el Registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        Me.cargatabla()
                        Me.limpiar()
                    End Try
                Else
                    MessageBox.Show("Grupos no Vigentes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Try
                    regla.Modificar(New TRABAJADOR(txtdni.Text, tiene, TEMPLATE, TEMPLATE10, foto))
                    Me.btnregistrar.Text = "&Registrar"
                    MessageBox.Show("Grupo Modificado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tiene = "SI"

                Catch ex As Exception
                    MessageBox.Show("Error en la Modificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    Me.cargatabla()
                    Me.limpiar()
                End Try

            End If

            Iniciar_Sensor()
            limpiar()
            Iniciar_Registro()
        Else
            MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.limpiar()

        End If
        'Else
        '    MessageBox.Show("Persona no encontrada", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.limpiar()
        'End If
        Me.txtnombre.Focus()
    End Sub

    Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
        Dim i%
        Dim v_decode As Object
        Dim v_decode10 As Object

        Me.txtdni.Focus()
        Me.cbogrupo.DataSource = Nothing
        Me.cbogrupo.Enabled = False
        'Me.grupo = Me.cbogrupo.SelectedIndex
        Me.btnregistrar.Text = "&Modificar"
        Dim obj As RNUSUARIO = Nothing
        Dim L As TRABAJADOR = Nothing
        Dim count As Integer
        count = Me.dvgusuario.Rows.Count
        If count > 0 Then

            L = CType(Me.dvgusuario.Rows(dvgusuario.CurrentRow.Index).DataBoundItem, TRABAJADOR)
            cod = L.dni
            a = Nothing
            'a = L.Persona

            If L IsNot Nothing Then
                'Me.txtpersona.Text = L.nombrepersona
                Me.txtdni.Text = L.dni
                Me.txtpaterno.Text = L.apellidopaterno.ToUpper
                Me.txtmaterno.Text = L.apellidomaterno.ToUpper
                Me.txtnombres.Text = L.nombres.ToUpper
                Me.txtContraseña.Text = ""
                'If L.Tipo = "L" Then
                '    Me.cboTipo.SelectedIndex = 0
                'Else
                '    Me.cboTipo.SelectedIndex = 1
                'End If

                'If L.Vigencia = False Then
                '    Me.rbtnovigente.Checked = True
                'Else
                '    Me.rbtvigente.Checked = True
                'End If

                CHKDNI.Checked = L.MAR_DNI
                CHKHUELLA.Checked = L.MAR_HUELLA

                If L.Template.ToString.Length > 0 Then
                    v_decode = ZKFPEngX1.DecodeTemplate1(L.Template.ToString)
                    v_decode10 = ZKFPEngX1.DecodeTemplate1(L.Template10.ToString)
                    ZKFPEngX1.AddRegTemplateToFPCacheDBEx(fpcHandle, L.dni, v_decode, v_decode10)
                    ' picHuella.Image = ZKFPEngX1.
                    picHuella.Image = ConvertirAImage(L.HUELLA_FOTO)
                    lblTieneHuella.Text = "Personal con Huella registrada!"
                    L.tiene = "SI"
                    Accion = "A"    'Actualizar
                Else
                    lblTieneHuella.Text = "¡Personal sin Huella!"
                    'lblTieneHuella.Text = ""
                    L.tiene = "NO"
                    Accion = "I"    'Insertar
                End If
                btnHuellaRefresh.Visible = True

                NewHuella = "NO"
                L.tiene = "NO"


            Else
                MessageBox.Show("No se pudo encontrar el Sistema Seleccionado", "Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If

    End Sub

    Private Sub txttrabajador_TextChanged(sender As Object, e As EventArgs) Handles txttrabajador.TextChanged

        Dim obj As New RNUSUARIO
        Dim la As List(Of TRABAJADOR)
        la = obj.filtrodb(txttrabajador.Text)
        dvgusuario.AutoGenerateColumns = False
        dvgusuario.DataSource = la



        With dvgusuario
            .Columns("dni").DataPropertyName = "dni"
            .Columns("apellidopaterno").DataPropertyName = "apellidopaterno"
            .Columns("apellidomaterno").DataPropertyName = "apellidomaterno"
            .Columns("nombres").DataPropertyName = "nombres"
            .Columns("telefono").DataPropertyName = "telefono"
            .Columns("tiene").DataPropertyName = "tiene"
        End With

        'If obj.Filtro(txttrabajador.Text).Rows.Count > 0 Then
        '    dvgusuario.DataSource = obj.Filtro(txttrabajador.Text)

        '    With dvgusuario
        '        .Columns("dni").DataPropertyName = "dni"
        '        .Columns("apellidopaterno").DataPropertyName = "apellidopaterno"
        '        .Columns("apellidomaterno").DataPropertyName = "apellidomaterno"
        '        .Columns("nombres").DataPropertyName = "nombres"
        '        .Columns("telefono").DataPropertyName = "telefono"
        '        .Columns("tiene").DataPropertyName = "tiene"
        '    End With

        'End If
    End Sub
    Private Sub cargatabla()
        Dim obj As New RNUSUARIO
        Dim L As TRABAJADOR
        Dim la As List(Of TRABAJADOR)
        la = obj.Leer(Me.txtnombres.Text)
        dvgusuario.AutoGenerateColumns = False
        dvgusuario.DataSource = la

        With dvgusuario
            .Columns("dni").DataPropertyName = "dni"
            .Columns("apellidopaterno").DataPropertyName = "apellidopaterno"
            .Columns("apellidomaterno").DataPropertyName = "apellidomaterno"
            .Columns("nombres").DataPropertyName = "nombres"
            .Columns("telefono").DataPropertyName = "telefono"
            .Columns("tiene").DataPropertyName = "tiene"
        End With
        Me.dvgusuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class