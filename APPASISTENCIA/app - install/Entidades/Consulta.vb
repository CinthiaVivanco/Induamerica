Public Class Consulta
    Inherits Persona
#Region "Datos"
	Private mcod_Consulta AS Integer
	Private mfecha_Examen AS Date
	Private mfecha_Informe AS Date
	Private mhora_Examen AS Date
	Private mnumDoc AS String
    Private mcosto As Double
    Private macuenta As Double
    Private msaldo As Double
    Private mtotal_Consulta As Double
    Private mestado As String
    Private mnroTicket As String
    Private mTipoPago As String
    Private mMedicoOrdena As String

    Private mCod_Paciente As Integer
    Private mcod_Comprobante As Integer
    Private mcod_Persona As Integer

    Private mUsuarioReg As String
    Private mUsuarioMod As String
    Private mFechaUserReg As Date
    Private mFechaUserMod As Date

    Private moPaciente As Paciente
    Private mestadoMat As String
    Private mestadoMatExtra As String

    Private mTIPODOCFE As String
    Private mNRODOCFE As String
    Private mRAZONSOCIALFE As String
    Private mSUBTOTAL As Double
    Private mIGV As Double
    Private mESTADOFE As String
#End Region

#Region "Propiedades"
    Private _p1 As Integer
    Private _p2 As Date
    Private _p3 As Date
    Private _p4 As Date
    Private _p5 As String
    Private _p6 As String
    Private _p7 As String
    Private _p8 As String
    Private _p9 As String
    Private _xestado As String
    Private _p11 As String
    Private _tipoPago As String
    Private _codPac As Integer
    Private _p14 As Object
    Private _codTratante As Integer
    Private _p16 As String
    Private _p17 As String
    Private _p18 As Object
    Private _p19 As Object
    Private _p20 As Object
    Private _p21 As Object
    Private _p22 As String
    Private _p23 As String
    Private _p24 As Double
    Private _p25 As Double

    Public Property cod_Consulta() As Integer
        Get
            Return Me.mcod_Consulta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Consulta = value
        End Set
    End Property
    Public Property fecha_Examen() As Date
        Get
            Return Me.mfecha_Examen
        End Get
        Set(ByVal value As Date)
            Me.mfecha_Examen = value
        End Set
    End Property
    Public Property fecha_Informe() As Date
        Get
            Return Me.mfecha_Informe
        End Get
        Set(ByVal value As Date)
            Me.mfecha_Informe = value
        End Set
    End Property
    Public Property hora_Examen() As Date
        Get
            Return Me.mhora_Examen
        End Get
        Set(ByVal value As Date)
            Me.mhora_Examen = value
        End Set
    End Property
    Public Property numDoc() As String
        Get
            Return Me.mnumDoc
        End Get
        Set(ByVal value As String)
            Me.mnumDoc = value
        End Set
    End Property
    Public Property costo() As Double
        Get
            Return Me.mcosto
        End Get
        Set(ByVal value As Double)
            Me.mcosto = value
        End Set
    End Property
    Public Property acuenta() As Double
        Get
            Return Me.macuenta
        End Get
        Set(ByVal value As Double)
            Me.macuenta = value
        End Set
    End Property
    Public Property saldo() As Double
        Get
            Return Me.msaldo
        End Get
        Set(ByVal value As Double)
            Me.msaldo = value
        End Set
    End Property
    Public Property total_Consulta() As Double
        Get
            Return Me.mtotal_Consulta
        End Get
        Set(ByVal value As Double)
            Me.mtotal_Consulta = value
        End Set
    End Property

    Public Property MedicoOrdena As String
        Get
            Return Me.mMedicoOrdena
        End Get
        Set(ByVal value As String)
            Me.mMedicoOrdena = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return Me.mestado
        End Get
        Set(ByVal value As String)
            Me.mestado = value
        End Set
    End Property
    Public Property nroTicket() As String
        Get
            Return Me.mnroTicket
        End Get
        Set(ByVal value As String)
            Me.mnroTicket = value
        End Set
    End Property
    Public Property TipoPago() As String
        Get
            Return Me.mTipoPago
        End Get
        Set(ByVal value As String)
            Me.mTipoPago = value
        End Set
    End Property
    Public Property UsuarioReg() As String
        Get
            Return Me.mUsuarioReg
        End Get
        Set(ByVal value As String)
            Me.mUsuarioReg = value
        End Set
    End Property
    Public Property UsuarioMod() As String
        Get
            Return Me.mUsuarioMod
        End Get
        Set(ByVal value As String)
            Me.mUsuarioMod = value
        End Set
    End Property


    Public Property FechaUserReg() As Date
        Get
            Return Me.mFechaUserReg
        End Get
        Set(ByVal value As Date)
            Me.mFechaUserReg = value
        End Set
    End Property
    Public Property FechaUsermod() As Date
        Get
            Return Me.mFechaUserMod
        End Get
        Set(ByVal value As Date)
            Me.mFechaUserMod = value
        End Set
    End Property
    Public Property Cod_Paciente() As Integer
        Get
            Return Me.mCod_Paciente
        End Get
        Set(ByVal value As Integer)
            Me.mCod_Paciente = value
        End Set
    End Property
    Public Property cod_Comprobante() As Integer
        Get
            Return Me.mcod_Comprobante
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Comprobante = value
        End Set
    End Property
    Public Property cod_Persona() As Integer
        Get
            Return Me.mcod_Persona
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Persona = value
        End Set
    End Property


    Public Property Paciente() As Paciente
        Get
            Return Me.moPaciente
        End Get
        Set(ByVal value As Paciente)
            Me.moPaciente = value
        End Set
    End Property
    Public ReadOnly Property NombrePaciente As String
        Get
            Return Paciente.NombreCompleto
        End Get
    End Property

    Public ReadOnly Property DNIPaciente As String
        Get
            Return Paciente.dni
        End Get
    End Property


    Public Property EstadoMat() As String
        Get
            Return Me.mestadoMat
        End Get
        Set(ByVal value As String)
            Me.mestadoMat = value
        End Set
    End Property
    Public Property EstadoMatExtra() As String
        Get
            Return Me.mestadoMatExtra
        End Get
        Set(ByVal value As String)
            Me.mestadoMatExtra = value
        End Set
    End Property

    Public Property TIPODOCFE() As String
        Get
            Return Me.mTIPODOCFE
        End Get
        Set(ByVal value As String)
            Me.mTIPODOCFE = value
        End Set
    End Property
    Public Property NRODOCFE() As String
        Get
            Return Me.mNRODOCFE
        End Get
        Set(ByVal value As String)
            Me.mNRODOCFE = value
        End Set
    End Property
    Public Property RAZONSOCIALFE() As String
        Get
            Return Me.mRAZONSOCIALFE
        End Get
        Set(ByVal value As String)
            Me.mRAZONSOCIALFE = value
        End Set
    End Property
    Public Property SUBTOTAL() As Double
        Get
            Return Me.mSUBTOTAL
        End Get
        Set(ByVal value As Double)
            Me.mSUBTOTAL = value
        End Set
    End Property
    Public Property IGV() As Double
        Get
            Return Me.mIGV
        End Get
        Set(ByVal value As Double)
            Me.mIGV = value
        End Set
    End Property
    Public Property ESTADOFE() As String
        Get
            Return Me.mESTADOFE
        End Get
        Set(ByVal value As String)
            Me.mESTADOFE = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer)
        Me.cod_Consulta = wcod_Consulta
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal westado As String)
        Me.cod_Consulta = wcod_Consulta
        Me.estado = westado
    End Sub

    Public Sub New(ByVal wcod_Consulta As Integer, ByVal westado As String, ByVal wnroTk As String)
        Me.cod_Consulta = wcod_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTk
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal westado As String, ByVal westadoMat As String, ByVal wnroTk As String)
        Me.cod_Consulta = wcod_Consulta
        Me.Estado = westado
        Me.EstadoMat = westadoMat
        Me.nroTicket = wnroTk
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal wfecha_Informe As Date, ByVal whora_Examen As Date, ByVal wnumDoc As String, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal_Consulta As Double, ByVal westado As String, ByVal wnroTicket As String, ByVal wTipoPago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Comprobante As Integer, ByVal wcod_Persona As Integer, ByVal wMedicoOrden As String)
        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.fecha_Informe = wfecha_Informe
        Me.hora_Examen = whora_Examen
        Me.numDoc = wnumDoc
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total_Consulta = wtotal_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTicket
        Me.TipoPago = wTipoPago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Comprobante = wcod_Comprobante
        Me.cod_Persona = wcod_Persona
        Me.MedicoOrdena = wMedicoOrden

    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal wfecha_Informe As Date, ByVal whora_Examen As Date, ByVal wnumDoc As String, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal_Consulta As Double, ByVal westado As String, ByVal wnroTicket As String, ByVal wTipoPago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Comprobante As Integer, ByVal wcod_Persona As Integer, ByVal wMedicoOrden As String, ByVal westadoMat As String)
        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.fecha_Informe = wfecha_Informe
        Me.hora_Examen = whora_Examen
        Me.numDoc = wnumDoc
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total_Consulta = wtotal_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTicket
        Me.TipoPago = wTipoPago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Comprobante = wcod_Comprobante
        Me.cod_Persona = wcod_Persona
        Me.MedicoOrdena = wMedicoOrden
        Me.EstadoMat = westadoMat
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal wfecha_Informe As Date, ByVal whora_Examen As Date, ByVal wnumDoc As String, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal_Consulta As Double, ByVal westado As String, ByVal wnroTicket As String, ByVal wTipoPago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Comprobante As Integer, ByVal wcod_Persona As Integer, ByVal wMedicoOrden As String, ByVal westadoMat As String, ByVal westadoMatextra As String)
        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.fecha_Informe = wfecha_Informe
        Me.hora_Examen = whora_Examen
        Me.numDoc = wnumDoc
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total_Consulta = wtotal_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTicket
        Me.TipoPago = wTipoPago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Comprobante = wcod_Comprobante
        Me.cod_Persona = wcod_Persona
        Me.MedicoOrdena = wMedicoOrden
        Me.EstadoMat = westadoMat
        Me.EstadoMatExtra = westadoMatextra
    End Sub
    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal wfecha_Informe As Date, ByVal whora_Examen As Date, ByVal wnumDoc As String, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal_Consulta As Double, ByVal westado As String, ByVal wnroTicket As String, ByVal wTipoPago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Comprobante As Integer, ByVal wcod_Persona As Integer, ByVal wMedicoOrden As String, ByVal wUsuarioReg As String, ByVal wFechaUserReg As Date, ByVal wUsuarioMod As String, ByVal wFechaUserMod As Date)
        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.fecha_Informe = wfecha_Informe
        Me.hora_Examen = whora_Examen
        Me.numDoc = wnumDoc
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total_Consulta = wtotal_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTicket
        Me.TipoPago = wTipoPago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Comprobante = wcod_Comprobante
        Me.cod_Persona = wcod_Persona
        Me.MedicoOrdena = wMedicoOrden

        Me.UsuarioReg = wUsuarioReg
        Me.FechaUserReg = wFechaUserReg

        Me.UsuarioMod = wUsuarioMod
        Me.FechaUsermod = wFechaUserMod

    End Sub

    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal wfecha_Informe As Date, ByVal whora_Examen As Date, ByVal wnumDoc As String, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal_Consulta As Double, ByVal westado As String, ByVal wnroTicket As String, ByVal wTipoPago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Comprobante As Integer, ByVal wcod_Persona As Integer, ByVal wMedicoOrden As String, ByVal wUsuarioReg As String, ByVal wFechaUserReg As Date, ByVal wUsuarioMod As String, ByVal wFechaUserMod As Date, ByVal wTIPODOCFE As String, ByVal wNRODOCFE As String, ByVal wRAZONSOCIALFE As String, ByVal wSUBTOTAL As Double, ByVal wIGV As Double, ByVal wESTADOFE As String)

        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.fecha_Informe = wfecha_Informe
        Me.hora_Examen = whora_Examen
        Me.numDoc = wnumDoc
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total_Consulta = wtotal_Consulta
        Me.Estado = westado
        Me.nroTicket = wnroTicket
        Me.TipoPago = wTipoPago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Comprobante = wcod_Comprobante
        Me.cod_Persona = wcod_Persona
        Me.MedicoOrdena = wMedicoOrden

        Me.UsuarioReg = wUsuarioReg
        Me.FechaUserReg = wFechaUserReg

        Me.UsuarioMod = wUsuarioMod
        Me.FechaUsermod = wFechaUserMod

        '''''FACTURACION
        Me.TIPODOCFE = wTIPODOCFE
        Me.NRODOCFE = wNRODOCFE
        Me.RAZONSOCIALFE = wRAZONSOCIALFE
        Me.SUBTOTAL = wSUBTOTAL
        Me.IGV = wIGV
        Me.ESTADOFE = wESTADOFE
        '''''FACTURACION

    End Sub


    Public Sub New(ByVal wcod_Consulta As Integer, ByVal wfecha_Examen As Date, ByVal whora_Examen As Date, ByVal wfechaInforme As Date, ByVal westado As String, ByVal wCod_Paciente As Integer, _
                   ByVal wpaterno As String, ByVal wmaterno As String, ByVal wnombre As String, ByVal wdni As String, ByVal wnroTicket As String)
        ' MyBase.New(wCod_Paciente, wnombre, wpaterno, wmaterno, wdni)

        Paciente = New Paciente(wCod_Paciente, wnombre, wpaterno, wmaterno, wdni)
        Me.cod_Consulta = wcod_Consulta
        Me.fecha_Examen = wfecha_Examen
        Me.hora_Examen = whora_Examen
        Me.Estado = westado
        Me.Cod_Paciente = wCod_Paciente
        Me.nroTicket = wnroTicket
        Me.fecha_Informe = wfechaInforme

    End Sub



#End Region

End Class