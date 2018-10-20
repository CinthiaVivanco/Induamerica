Public Class AFP

#Region "Datos"
	Private mcodAfp AS String
	Private mnombre AS String
    Private mfondo As Double
    Private mseguro As Double
    Private mcomisionflujo As Double
    Private mcomisionsaldo As Double
#End Region
#Region "Propiedades"
    Public Property codAfp() As String
        Get
            Return Me.mcodAfp
        End Get
        Set(ByVal value As String)
            Me.mcodAfp = value
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
    Public Property fondo() As Double
        Get
            Return Me.mfondo
        End Get
        Set(ByVal value As Double)
            Me.mfondo = value
        End Set
    End Property
    Public Property seguro() As Double
        Get
            Return Me.mseguro
        End Get
        Set(ByVal value As Double)
            Me.mseguro = value
        End Set
    End Property
    Public Property comisionflujo() As Double
        Get
            Return Me.mcomisionflujo
        End Get
        Set(ByVal value As Double)
            Me.mcomisionflujo = value
        End Set
    End Property
    Public Property comisionsaldo() As Double
        Get
            Return Me.mcomisionsaldo
        End Get
        Set(ByVal value As Double)
            Me.mcomisionsaldo = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcodAfp As String)

        Me.codAfp = wcodAfp
    End Sub
    Public Sub New(ByVal wcodAfp As String, ByVal wnombre As String, ByVal wfondo As Double, ByVal wseguro As Double, ByVal wcomisionflujo As Double, ByVal wcomisionsaldo As Double)
        Me.codAfp = wcodAfp
        Me.nombre = wnombre
        Me.fondo = wfondo
        Me.seguro = wseguro
        Me.comisionflujo = wcomisionflujo
        Me.comisionsaldo = wcomisionsaldo
    End Sub
#End Region

End Class