Public Class Laboratorio
    Inherits Persona
#Region "Datos"
	Private mcod_Laboratorio AS Integer
	Private mCod_Paciente AS Integer
    Private mfechaRegistro As Date
	Private mfechaExamen AS Date
	Private mfechaInforme AS Date
	Private mcosto AS Double
	Private macuenta AS Double
	Private msaldo AS Double
	Private mtotal AS Double
	Private mtipoPago AS String
	Private mestado AS String
    Private mcod_Comprobante As Integer

    Private moPaciente As Paciente
#End Region
#Region "Propiedades"
	Public Property cod_Laboratorio() AS Integer
		Get
			return Me.mcod_Laboratorio
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Laboratorio = value
		End Set
	End Property
	Public Property Cod_Paciente() AS Integer
		Get
			return Me.mCod_Paciente
		End Get
		Set(ByVal value As Integer)
			Me.mCod_Paciente = value
		End Set
	End Property
    Public Property fechaRegistro() As Date
        Get
            Return Me.mfechaRegistro
        End Get
        Set(ByVal value As Date)
            Me.mfechaRegistro = value
        End Set
    End Property
	Public Property fechaExamen() AS Date
		Get
			return Me.mfechaExamen
		End Get
		Set(ByVal value As Date)
			Me.mfechaExamen = value
		End Set
	End Property
	Public Property fechaInforme() AS Date
		Get
			return Me.mfechaInforme
		End Get
		Set(ByVal value As Date)
			Me.mfechaInforme = value
		End Set
	End Property
	Public Property costo() AS Double
		Get
			return Me.mcosto
		End Get
		Set(ByVal value As Double)
			Me.mcosto = value
		End Set
	End Property
	Public Property acuenta() AS Double
		Get
			return Me.macuenta
		End Get
		Set(ByVal value As Double)
			Me.macuenta = value
		End Set
	End Property
	Public Property saldo() AS Double
		Get
			return Me.msaldo
		End Get
		Set(ByVal value As Double)
			Me.msaldo = value
		End Set
	End Property
	Public Property total() AS Double
		Get
			return Me.mtotal
		End Get
		Set(ByVal value As Double)
			Me.mtotal = value
		End Set
	End Property
	Public Property tipoPago() AS String
		Get
			return Me.mtipoPago
		End Get
		Set(ByVal value As String)
			Me.mtipoPago = value
		End Set
	End Property
	Public Property estado() AS String
		Get
			return Me.mestado
		End Get
		Set(ByVal value As String)
			Me.mestado = value
		End Set
	End Property
	Public Property cod_Comprobante() AS Integer
		Get
			return Me.mcod_Comprobante
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Comprobante = value
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
    'Public Property numDoc() As String
    '    Get
    '        Return Me.mnumDoc
    '    End Get
    '    Set(ByVal value As String)
    '        Me.mnumDoc = value
    '    End Set
    'End Property

#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_Laboratorio As Integer)
        Me.cod_Laboratorio = wcod_Laboratorio
    End Sub
    Public Sub New(ByVal wcod_Laboratorio As Integer, ByVal wCod_Paciente As Integer, ByVal wfechaRegistro As Date, ByVal wfechaExamen As Date, ByVal wfechaInforme As Date, ByVal wcosto As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wtotal As Double, ByVal wtipoPago As String, ByVal westado As String, ByVal wcod_Comprobante As Integer)
        Me.cod_Laboratorio = wcod_Laboratorio
        Me.Cod_Paciente = wCod_Paciente
        Me.fechaRegistro = wfechaRegistro
        Me.fechaExamen = wfechaExamen
        Me.fechaInforme = wfechaInforme
        Me.costo = wcosto
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.total = wtotal
        Me.tipoPago = wtipoPago
        Me.estado = westado
        Me.cod_Comprobante = wcod_Comprobante
    End Sub
 
    Public Sub New(ByVal wcod_Laboratorio As Integer, ByVal wfechaRegistro As Date, ByVal wfechaExamen As Date, ByVal wfechaInforme As Date, ByVal westado As String, ByVal wCod_Paciente As Integer, _
                   ByVal wpaterno As String, ByVal wmaterno As String, ByVal wnombre As String, ByVal wdni As String)
        ' MyBase.New(wCod_Paciente, wnombre, wpaterno, wmaterno, wdni)

        Paciente = New Paciente(wCod_Paciente, wnombre, wpaterno, wmaterno, wdni)
        Me.cod_Laboratorio = wcod_Laboratorio
        Me.fechaRegistro = wfechaRegistro
        Me.fechaExamen = wfechaExamen
        Me.fechaInforme = wfechaInforme
        Me.estado = westado
        Me.Cod_Paciente = wCod_Paciente

    End Sub
#End Region

End Class