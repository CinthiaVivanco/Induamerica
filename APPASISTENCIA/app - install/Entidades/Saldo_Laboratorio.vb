Public Class Saldo_Laboratorio

#Region "Datos"
    Private mcod_Saldo As Integer
    Private mfecha As Date
    Private msaldo As Double
    Private mcod_Laboratorio As Integer
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

    Public Property TipoPago() As String
        Get
            Return Me.mTipoPago
        End Get
        Set(ByVal value As String)
            Me.mTipoPago = value
        End Set
    End Property
    Public Property cod_Laboratorio() As Integer
        Get
            Return Me.mcod_Laboratorio
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Laboratorio = value
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

    Public Sub New(ByVal wcod_Saldo As Integer, ByVal wfecha As Date, ByVal wsaldo As Double, ByVal wtipopago As String, ByVal wcod_Laboratorio As Integer, ByVal wcodComprobante As Integer)
        Me.cod_Saldo = wcod_Saldo
        Me.fecha = wfecha
        Me.saldo = wsaldo
        Me.cod_Laboratorio = wcod_Laboratorio
        Me.TipoPago = wtipopago
        Me.cod_Comprobante = wcodComprobante
    End Sub
#End Region

End Class