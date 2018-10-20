Public Class Venta
    Inherits Persona
#Region "Datos"
	Private mcod_Venta AS Integer
	Private mfecha AS Date
    Private mtipopago As String
    Private msubtotal As Double
    Private migv As Double
    Private mdescuento As Double
    Private mtotal As Double
    Private macuenta As Double
    Private msaldo As Double
    Private mNroDoc As String
    Private mestado As String
    Private mcod_Cliente As Integer
    Private mcod_Comprobante As Integer
    Private musuario As String
#End Region

#Region "Propiedades"
    Public Property cod_Venta() As Integer
        Get
            Return Me.mcod_Venta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Venta = value
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
    Public Property tipopago() As String
        Get
            Return Me.mtipopago
        End Get
        Set(ByVal value As String)
            Me.mtipopago = value
        End Set
    End Property
    Public Property subtotal() As Double
        Get
            Return Me.msubtotal
        End Get
        Set(ByVal value As Double)
            Me.msubtotal = value
        End Set
    End Property
    Public Property igv() As Double
        Get
            Return Me.migv
        End Get
        Set(ByVal value As Double)
            Me.migv = value
        End Set
    End Property
    Public Property descuento() As Double
        Get
            Return Me.mdescuento
        End Get
        Set(ByVal value As Double)
            Me.mdescuento = value
        End Set
    End Property
    Public Property total() As Double
        Get
            Return Me.mtotal
        End Get
        Set(ByVal value As Double)
            Me.mtotal = value
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
    Public Property NroDoc() As String
        Get
            Return Me.mNroDoc
        End Get
        Set(ByVal value As String)
            Me.mNroDoc = value
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
    Public Property cod_Cliente() As Integer
        Get
            Return Me.mcod_Cliente
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Cliente = value
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
    Public Property Usuario() As String
        Get
            Return Me.musuario
        End Get
        Set(ByVal value As String)
            Me.musuario = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Venta As Integer)

        Me.cod_Venta = wcod_Venta

    End Sub

    Public Sub New(ByVal wcod_Venta As Integer, ByVal wfecha As Date, ByVal wtipopago As String, ByVal wsubtotal As Double, ByVal wigv As Double, ByVal wdescuento As Double, ByVal wtotal As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wNroDoc As String, ByVal westado As String, ByVal wcod_Cliente As Integer, ByVal wcod_Comprobante As Integer, ByVal wusuario As String)
        Me.cod_Venta = wcod_Venta
        Me.fecha = wfecha
        Me.tipopago = wtipopago
        Me.subtotal = wsubtotal
        Me.igv = wigv
        Me.descuento = wdescuento
        Me.total = wtotal
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.NroDoc = wNroDoc
        Me.estado = westado
        Me.cod_Cliente = wcod_Cliente
        Me.cod_Comprobante = wcod_Comprobante
        Me.Usuario = wusuario
    End Sub

    Public Sub New(ByVal wcod_Venta As Integer, ByVal wfecha As Date, ByVal wtipopago As String, ByVal wsubtotal As Double, ByVal wigv As Double, ByVal wdescuento As Double, ByVal wtotal As Double, ByVal wacuenta As Double, ByVal wsaldo As Double, ByVal wNroDoc As String, ByVal westado As String, ByVal wcod_Cliente As Integer, ByVal wcod_Comprobante As Integer, ByVal wusuario As String _
                   , ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String)

        MyBase.New(wcod_Cliente, wnombre, wapPaterno, wapMaterno, "")

        Me.cod_Venta = wcod_Venta
        Me.fecha = wfecha
        Me.tipopago = wtipopago
        Me.subtotal = wsubtotal
        Me.igv = wigv
        Me.descuento = wdescuento
        Me.total = wtotal
        Me.acuenta = wacuenta
        Me.saldo = wsaldo
        Me.NroDoc = wNroDoc
        Me.estado = westado
        Me.cod_Cliente = wcod_Cliente
        Me.cod_Comprobante = wcod_Comprobante
        Me.Usuario = wusuario
    End Sub


#End Region

End Class