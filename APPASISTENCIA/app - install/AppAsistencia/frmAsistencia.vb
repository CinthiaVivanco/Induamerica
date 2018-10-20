Imports System.IO

Public Class frmAsistencia
    Dim rutaFoto As String = "\\SYSCERIN\AppAsistencia\"
    Dim dt As DataTable
    Dim row As DataRow
    Private FechaHoy As Date
    Private codigo As String
    Private HoraLlegada As Date = Nothing
    Private segundos As Integer
    Private U As TRABAJADOR
    Private lD As List(Of turno)
    Private seleccion As Integer = 0
#Region "Lector de Huella"
    Private FMatchType As Integer
    Private fpcHandle As Integer
    Private FAutoIdentify As Boolean

    Private Accion As String
    ''VARIABLES
    Dim sTemp As String
    Dim fingerid As Integer
    Dim FRegTemplate As Object
    Dim fi As Long

    Private Sub Iniciar_Sensor()
        Try
            If (ZKFPEngX1.InitEngine() = 0) Then
                FMatchType = 2
                UltraLabel14.Text = "Sensor conectado"
                If (rbtZkFinger9.Checked) Then
                    ZKFPEngX1.FPEngineVersion = "9"
                Else
                    ZKFPEngX1.FPEngineVersion = "10"
                End If
                'DEVUELVE EL IDENTIFICADOR DE LA HUELLLA
                fpcHandle = ZKFPEngX1.CreateFPCacheDB
                ZKFPEngX1.EnrollCount = 3
                UltraLabel14.Text = "Sensor conectado"

            Else
                UltraLabel14.Text = "Error al conectar sensor"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub Iniciar_Identificacion()
        Try
            FAutoIdentify = True
            ZKFPEngX1.SetAutoIdentifyPara(FAutoIdentify, fpcHandle, 8)
            FMatchType = 2
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub ShowHintInfo(ByVal s As String)
        If (s <> "") Then
            memoHint.AppendText(s + Environment.NewLine)
        End If

    End Sub
    Private Sub ShowHintImage(ByVal iType As Integer)

        If (iType = 0) Then
            imgNO.Visible = False
            imgOK.Visible = False

        ElseIf (iType = 1) Then

            imgNO.Visible = False
            imgOK.Visible = True

        ElseIf (iType = 2) Then

            imgNO.Visible = True
            imgOK.Visible = False
        End If
    End Sub
    Private Sub ZKFPEngX1_OnImageReceived(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent) Handles ZKFPEngX1.OnImageReceived
        Dim g As Graphics = picHuella.CreateGraphics()
        Dim bmp As New Bitmap(picHuella.Width, picHuella.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc().ToInt32()
        ZKFPEngX1.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        picHuella.Image = bmp
    End Sub
    Private Sub ZKFPEngX1_OnFeatureInfo(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEvent) Handles ZKFPEngX1.OnFeatureInfo

        Try
            Dim strTemp As String = "Fingerprint quality - Calidad"
            If (e.aQuality <> 0) Then
                strTemp = strTemp + " not good"
            Else
                strTemp = strTemp + " good"
            End If

            If (ZKFPEngX1.EnrollIndex <> 1) Then
                If (ZKFPEngX1.IsRegister) Then
                    If (ZKFPEngX1.EnrollIndex - 1 > 0) Then
                        strTemp = strTemp + " Register status: still press finger " + Convert.ToString(ZKFPEngX1.EnrollIndex - 1) + " times!"
                    End If
                End If
            End If

            ShowHintInfo(strTemp)
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub ZKFPEngX1_OnCapture(ByVal sender As Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent) Handles ZKFPEngX1.OnCapture
        LblNombre.Text = ""
        LblDni.Text = ""
        Dim ID, i As Integer
        Dim Score As New Integer()
        Dim ProcessNum As New Integer()

        ShowHintInfo("Acquired fingerprint template:")

        ''INICIA EL PROCESO DE IDENTIFICAICON AUTOMATICA
        If FMatchType = 2 Then
            If Not FAutoIdentify Then

            Else
                ID = 0
                Score = 0

                Dim _ObjectArray As Array = CType(e.aTemplate, Array)
                Dim _ObjectCount As Integer = _ObjectArray.GetLength(0)
                For i = 0 To 2 - 1
                    If i = 0 Then
                        ID = Convert.ToInt32(_ObjectArray.GetValue(i))
                    Else
                        Score = Convert.ToInt32(_ObjectArray.GetValue(i))
                    End If
                Next

                If ID = -1 Then
                    UltraLabel14.Text = "Huella no Identificada!"
                    Limpiar()

                    ShowHintInfo("Huella no Identificada!")
                    ShowHintImage(2)
                Else
                    UltraLabel14.Text = "Huella identificada con exito! " '' & Chr(13) & "ID: " & ID.ToString
                    Call ValidarDatos(ID)
                End If
            End If
        End If
    End Sub

    Private Function imgOK() As Object
        Throw New NotImplementedException
    End Function

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

    Private Sub Limpiar()
        LblNombre.Text = ""
        LblDni.Text = ""
        codigo = ""

        'lbl_fecha.Text = ""
        picFoto.Image = Nothing
        picHuella.Image = Nothing
        'cboturno.SelectedIndex = 0
        segundos = 0
        'BtnRegistrar.Visible = False
        Timer1.Stop()
    End Sub

  

    Private Sub frmAsistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CargarFechaActual()

        Timer1.Start()

        Limpiar()

        ' If codigo.Length > 0 Then

        Call Iniciar_Sensor()
        Call CargaPersonalHuella()
        Call Iniciar_Identificacion()
        'End If

    End Sub

    Private Sub cargarTurno()
        Dim obj As New RNturno


        lD = obj.ListarxUsuario(U.Codigo)

        If lD.Count > 0 Then

            Me.cboturno.DisplayMember = "nombre"
            Me.cboturno.ValueMember = "cod_turno"

            If lD.Count = 1 Then
                lD.Insert(0, New turno(0, "Seleccione"))
                Me.cboturno.DataSource = lD
                cboturno.Enabled = False
                cboturno.SelectedIndex = 1
                seleccion = 0
            Else
                lD.Insert(0, New turno(0, "Seleccione"))
                Me.cboturno.DataSource = lD
                cboturno.Enabled = True


                cboturno.SelectedIndex = seleccion

            End If
        End If

    End Sub
    Private Sub CargarFechaActual()

        Dim obj As New RNAsistencia

        Dim dt As DataTable
        Dim row As DataRow

        dt = obj.FechaActual
        If dt.Rows.Count > 0 Then
            row = dt.Rows(0)
            lbl_fecha.Text = CDate(row("fecha").ToString).ToShortDateString
            FechaHoy = row("fecha").ToString
        Else
            FechaHoy = Nothing
        End If


    End Sub

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
            La = Nothing
        End Try
    End Sub

    Private Sub ValidarDatos(ByVal Id_Personal As Integer)
        Me.LblMensaje.Text = ""
        Dim obj As New RNUSUARIO

        Dim msg As String = ""
        Dim NroDocumento As String = ""
        Dim Dedito As String = ""
        Dim Estado As String = ""
        Dim Foto As String = ""

        

        If Id_Personal = 0 Then
            NroDocumento = RTrim(LTrim(Me.TxtNroDocuemento.Text))

            If Len(NroDocumento) = 8 Then

                U = obj.LeerxNroDoc(NroDocumento)

                If U IsNot Nothing Then


                    If U.MAR_DNI = 0 Then
                        MsgBox("Ud. no puede marcar con DNI", 64, "Mensaje del Sistema")
                        Exit Sub
                        Return
                    End If
                End If



            End If
        Else

        
            dt = obj.LeerxNroDocxID(Id_Personal)

            row = dt.Rows(0)
            If dt.Rows.Count > 0 Then
                NroDocumento = row("DNI").ToString
                Dedito = row("Template").ToString

                If Dedito = "" Then
                    LblMensaje.Text = "No tiene Huella Digital Asignada, Contacte con el Area de Sistemas"
                    Return
                End If
            End If

            If row("MAR_HUELLA") = 1 Then
                MsgBox("Ud. no puede marcar con HUELLA", 64, "Mensaje del Sistema")
                Exit Sub
                Return
            End If

        End If


        If Len(NroDocumento) = 8 Then

            U = obj.LeerxNroDoc(NroDocumento)



            If U IsNot Nothing Then
                LblNombre.Text = U.nombres
                LblDni.Text = "N° D.N.I : " & NroDocumento

                'Foto = rutaFoto & NroDocumento + ".jpg"

                'If File.Exists(Foto) Then
                '    picFoto.Image = Image.FromFile(Foto)
                'Else
                '    picFoto.ImageLocation = AppDomain.CurrentDomain.BaseDirectory & "img\NODISPONIBLE.jpg"
                'End If

                MarcarAsistencia(NroDocumento)

                Timer1.Start()
                Timer2.Start()

            Else
                Limpiar()
            End If



        End If


    End Sub

    Private Sub MarcarAsistencia(ByVal NroDocumento As String)
        Dim obj As RNAsistencia = New RNAsistencia

        'cargarTurno()

        'If cboturno.SelectedIndex = 0 Then
        '    MessageBox.Show("Seleccione el Turno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        Dim ds As DataSet = obj.Validar(U.dni)
        'Dim ds As DataSet = obj.Validar("rebb")
        Dim aviso As String = ""
        Dim idasistencia As String = ""
        Dim atributomodificar As String = ""
        Dim errorsw As Integer = 0
        Dim tipo As String = ""

        ' aviso = ds.Tables(0).Columns(0).ToString

        aviso = ds.Tables(0).Rows(0).Item(0)
        errorsw = ds.Tables(0).Rows(0).Item(1)
        idasistencia = ds.Tables(0).Rows(0).Item(2)
        atributomodificar = ds.Tables(0).Rows(0).Item(3)

        tipo = Microsoft.VisualBasic.Left(aviso, 1)

        Try
            If errorsw = 0 Then
                If MessageBox.Show("Esta seguro de registrar su " & aviso, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    obj.Registrar(New Asistencia(idasistencia, atributomodificar))
                    'MessageBox.Show("Asistencia Registrada exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LblMensaje.Text = "Asistencia Registrada Correctamente."
                    Me.txtobs.Text = ""

                    ' Me.Close()
                Else
                    Limpiar()
                End If
            Else
                ' MessageBox.Show("Ya registro su Asistencia el dia de Hoy", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Me.Close()

                lblError.Visible = True
                lblError.Text = "Este Personal ya registró su Asistencia !!!"
                lblError.ForeColor = Color.Red
            End If

        Catch ex As Exception
            'Este Personal ya registro su Asistencia !!!
            lblError.Visible = True
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            obj = Nothing
        End Try

    End Sub

    Private Sub TxtNroDocuemento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroDocuemento.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Try
            If AscW(e.KeyChar) = Keys.Enter Then
                Call CargaPersonalHuella()

                Call ValidarDatos(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub TxtNroDocuemento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroDocuemento.TextChanged
        Try
            If Len(Me.TxtNroDocuemento.Text.Trim) > 0 Then
                TxtNroDocuemento.BackColor = Color.PowderBlue
            Else
                TxtNroDocuemento.BackColor = SystemColors.Window
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        segundos += 1

        If segundos = 2 Then
            LblMensaje.Text = ""
            lblError.Text = ""
            lblError.Visible = False
            Timer2.Stop()
            Limpiar()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Static C As Integer

        C = C + 1 'Inicializando
        If C = 1 Then
            LblMensaje.ForeColor = Color.Red
        ElseIf C = 2 Then
            LblMensaje.ForeColor = Color.Blue
        ElseIf C = 3 Then
            LblMensaje.ForeColor = Color.Yellow
        Else : C = 4
            C = 0

        End If
    End Sub

    Private Sub cboturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboturno.SelectedIndexChanged
        If cboturno.SelectedIndex > 0 Then
            seleccion = cboturno.SelectedIndex
        End If
    End Sub
End Class
