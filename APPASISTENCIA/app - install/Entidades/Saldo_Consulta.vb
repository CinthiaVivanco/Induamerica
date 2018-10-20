Public Class Saldo_Consulta

#Region "Datos"
	Private mcod_Saldo AS Integer
	Private mfecha AS Date
    Private msaldo As Double
    Private mcod_Consulta As Integer
    Private mtipoPago As String
    Private mcod_Comprobante As Integer

#End Region

#Region "Propiedades"
    Public Property cod_Saldo() As Integer
        Get
            Return Me.mcod_Saldo
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Saldo = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return Me.mfecha
        End Get
        Set(ByVal value As Date)
            Me.mfecha = value
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
    Public Property cod_Consulta() As Integer
        Get
            Return Me.mcod_Consulta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Consulta = value
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
    Public Property cod_Comprobante() As Integer
        Get
            Return Me.mcod_Comprobante
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Comprobante = value
        End Set
    End Property


#End Region
#Region "Constructores"
	Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_Saldo As Integer)
        Me.cod_Saldo = wcod_Saldo
    End Sub

    Public Sub New(ByVal wcod_Saldo As Integer, ByVal wfecha As Date, ByVal wsaldo As Double, ByVal wcod_Consulta As Integer, ByVal wtipopago As String, ByVal wcodComprobante As Integer)
        Me.cod_Saldo = wcod_Saldo
        Me.fecha = wfecha
        Me.saldo = wsaldo
        Me.cod_Consulta = wcod_Consulta
        Me.TipoPago = wtipopago
        Me.cod_Comprobante = wcodComprobante
    End Sub

#End Region

End Class