Public Class Egreso

#Region "Datos"
	Private mcod_Egreso AS Integer
	Private mFecha AS Date
    Private mTotal As Double
    Private mEstado As String
    Private mperiodoid As String

    
#End Region
#Region "Propiedades"
    Public Property cod_Egreso() As Integer
        Get
            Return Me.mcod_Egreso
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Egreso = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return Me.mFecha
        End Get
        Set(ByVal value As Date)
            Me.mFecha = value
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
    Public Property periodoid() As String
        Get
            Return Me.mperiodoid
        End Get
        Set(ByVal value As String)
            Me.mperiodoid = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return Me.mEstado
        End Get
        Set(ByVal value As String)
            Me.mEstado = value
        End Set
    End Property



#End Region
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_Egreso As Integer)
         Me.cod_Egreso = wcod_Egreso

    End Sub

    Public Sub New(ByVal wcod_Egreso As Integer, ByVal wFecha As Date, ByVal wTotal As Double, ByVal westado As String, ByVal wperiodoid As String)
        Me.cod_Egreso = wcod_Egreso
        Me.Fecha = wFecha
        Me.Total = wTotal
        Me.Estado = westado
        Me.periodoid = wperiodoid
    End Sub

   

#End Region

End Class