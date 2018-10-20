Public Class Periodo

#Region "Datos"
	Private mperiodoid AS String
	Private mnombre AS String
	Private mFechaInicial AS Date
    Private mFechaFinal As Date
    Private mFechaQuincena As Date
    Private mDiasLaborables As Integer
    Private mDiasFeriados As Integer



#End Region
#Region "Propiedades"


    Public Property periodoid() As String
        Get
            Return Me.mperiodoid
        End Get
        Set(ByVal value As String)
            Me.mperiodoid = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return Me.mnombre
        End Get
        Set(ByVal value As String)
            Me.mnombre = value
        End Set
    End Property
    Public Property FechaInicial() As Date
        Get
            Return Me.mFechaInicial
        End Get
        Set(ByVal value As Date)
            Me.mFechaInicial = value
        End Set
    End Property
    Public Property FechaFinal() As Date
        Get
            Return Me.mFechaFinal
        End Get
        Set(ByVal value As Date)
            Me.mFechaFinal = value
        End Set
    End Property
    Public Property FechaQuincena() As Date
        Get
            Return Me.mFechaQuincena
        End Get
        Set(ByVal value As Date)
            Me.mFechaQuincena = value
        End Set
    End Property

    Public Property DiasLaborables() As Integer
        Get
            Return Me.mDiasLaborables
        End Get
        Set(ByVal value As Integer)
            Me.mDiasLaborables = value
        End Set
    End Property

    Public Property DiasFeriados() As Integer
        Get
            Return Me.mDiasFeriados
        End Get
        Set(ByVal value As Integer)
            Me.mDiasFeriados = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wperiodoid As String)

        Me.periodoid = wperiodoid
    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wnombre As String, ByVal wFechaInicial As Date, ByVal wFechaFinal As Date, ByVal wfechaquincena As Date)
        Me.periodoid = wperiodoid
        Me.nombre = wnombre
        Me.FechaInicial = wFechaInicial
        Me.FechaFinal = wFechaFinal
        Me.FechaQuincena = wfechaquincena

    End Sub

    Public Sub New(ByVal wperiodoid As String, ByVal wnombre As String, ByVal wFechaInicial As Date, ByVal wFechaFinal As Date, ByVal wfechaquincena As Date, ByVal wdiaslab As Integer, ByVal wdiasferiados As Integer)
        Me.periodoid = wperiodoid
        Me.nombre = wnombre
        Me.FechaInicial = wFechaInicial
        Me.FechaFinal = wFechaFinal
        Me.FechaQuincena = wfechaquincena
        Me.DiasLaborables = wdiaslab
        Me.mDiasFeriados = wdiasferiados
    End Sub

#End Region

End Class