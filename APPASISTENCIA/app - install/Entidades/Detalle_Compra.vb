Public Class Detalle_Compra

#Region "Datos"
	Private mcod_detalleCompra AS Integer
	Private mcantidad AS Integer
    Private mprecioUnit As Double
    Private mTotal As Double
    Private mcod_Producto As Integer
    Private mcod_compra As Integer
#End Region
#Region "Propiedades"
    Public Property cod_detalleCompra() As Integer
        Get
            Return Me.mcod_detalleCompra
        End Get
        Set(ByVal value As Integer)
            Me.mcod_detalleCompra = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return Me.mcantidad
        End Get
        Set(ByVal value As Integer)
            Me.mcantidad = value
        End Set
    End Property
    Public Property precioUnit() As Double
        Get
            Return Me.mprecioUnit
        End Get
        Set(ByVal value As Double)
            Me.mprecioUnit = value
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
    Public Property cod_Producto() As Integer
        Get
            Return Me.mcod_Producto
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Producto = value
        End Set
    End Property
    Public Property cod_compra() As Integer
        Get
            Return Me.mcod_compra
        End Get
        Set(ByVal value As Integer)
            Me.mcod_compra = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_detalleCompra As Integer, ByVal wcantidad As Integer, ByVal wprecioUnit As Double, ByVal wTotal As Double, ByVal wcod_Producto As Integer, ByVal wcod_compra As Integer)
        Me.cod_detalleCompra = wcod_detalleCompra
        Me.cantidad = wcantidad
        Me.precioUnit = wprecioUnit
        Me.Total = wTotal
        Me.cod_Producto = wcod_Producto
        Me.cod_compra = wcod_compra
    End Sub
#End Region

End Class