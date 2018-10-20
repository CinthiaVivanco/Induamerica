Public Class Informe

#Region "Datos"
	Private mcod_Informe AS Integer
	Private mFechaExamen AS Date
	Private mFechaToma AS Date
    Private mTotal As Double
    Private mestado As String
    Private mconvenio As String
    Private mestado_Pago As String
    Private mCod_Paciente As Integer
    Private mcod_Persona As Integer
    Private mautogenerado As String
    Private mcod_CentroConvenio As Integer

    Private mMedicoOrdena As String

    Private moPaciente As Paciente
    Private moCentroConvenio As Centro_Convenio

#End Region
#Region "Propiedades"
    Public Property cod_Informe() As Integer
        Get
            Return Me.mcod_Informe
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Informe = value
        End Set
    End Property
    Public Property FechaExamen() As Date
        Get
            Return Me.mFechaExamen
        End Get
        Set(ByVal value As Date)
            Me.mFechaExamen = value
        End Set
    End Property
    Public Property FechaToma() As Date
        Get
            Return Me.mFechaToma
        End Get
        Set(ByVal value As Date)
            Me.mFechaToma = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return Me.mTotal
        End Get
        Set(ByVal value As Double)
            Me.mTotal = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return Me.mestado
        End Get
        Set(ByVal value As String)
            Me.mestado = value
        End Set
    End Property
    Public Property convenio() As String
        Get
            Return Me.mconvenio
        End Get
        Set(ByVal value As String)
            Me.mconvenio = value
        End Set
    End Property
    Public Property estado_Pago() As String
        Get
            Return Me.mestado_Pago
        End Get
        Set(ByVal value As String)
            Me.mestado_Pago = value
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
    Public Property cod_Persona() As Integer
        Get
            Return Me.mcod_Persona
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Persona = value
        End Set
    End Property
    Public Property autogenerado() As String
        Get
            Return Me.mautogenerado
        End Get
        Set(ByVal value As String)
            Me.mautogenerado = value
        End Set
    End Property
    Public Property cod_CentroConvenio() As Integer
        Get
            Return Me.mcod_CentroConvenio
        End Get
        Set(ByVal value As Integer)
            Me.mcod_CentroConvenio = value
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

    Public ReadOnly Property DniPaciente As String
        Get
            Return Paciente.dni
        End Get
    End Property

    Public Property centroconvenio() As Centro_Convenio
        Get
            Return Me.moCentroConvenio
        End Get
        Set(ByVal value As Centro_Convenio)
            Me.moCentroConvenio = value
        End Set
    End Property

    Public ReadOnly Property NombreCentro As String
        Get
            Return centroconvenio.razonSocial.Trim
        End Get
    End Property

#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Informe As Integer)
        Me.cod_Informe = wcod_Informe
    End Sub

    Public Sub New(ByVal wcod_Informe As Integer, ByVal wFechaExamen As Date, ByVal wFechaToma As Date, ByVal wTotal As Double, ByVal westado As String, ByVal wconvenio As String, ByVal westado_Pago As String, ByVal wCod_Paciente As Integer, ByVal wcod_Persona As Integer, ByVal wautogenerado As String, ByVal wcod_CentroConvenio As Integer, ByVal wmedicoOrden As String)
        Me.cod_Informe = wcod_Informe
        Me.FechaExamen = wFechaExamen
        Me.FechaToma = wFechaToma
        Me.Total = wTotal
        Me.estado = westado
        Me.convenio = wconvenio
        Me.estado_Pago = westado_Pago
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_Persona = wcod_Persona
        Me.autogenerado = wautogenerado
        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.MedicoOrdena = wmedicoOrden
    End Sub

    Public Sub New(ByVal wcod_Informe As Integer, ByVal wFechaExamen As Date, ByVal westado As String, ByVal wCod_Paciente As Integer, _
                     ByVal wpaterno As String, ByVal wmaterno As String, ByVal wnombre As String, ByVal wdni As String, _
                     ByVal wcod_CentroConvenio As Integer, ByVal wcentro As String)

        Paciente = New Paciente(wCod_Paciente, wnombre, wpaterno, wmaterno, wdni)
        centroconvenio = New Centro_Convenio(wcod_CentroConvenio, wcentro)
        Me.cod_Informe = wcod_Informe
        Me.FechaExamen = wFechaExamen
        Me.estado = westado
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_CentroConvenio = wcod_CentroConvenio

    End Sub

#End Region

End Class