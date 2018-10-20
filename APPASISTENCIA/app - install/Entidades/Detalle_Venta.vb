Public Class Detalle_Venta

#Region "Datos"
	Private mcod_Detalle_Venta AS Integer
	Private mcod_Venta AS Integer
	Private mcod_Producto AS Integer
	Private mcantidad AS Integer
    Private mpreciounit As Double
    Private mtotal As Double

    Private moProducto As Producto

#End Region
#Region "Propiedades"
    Public Property cod_Detalle_Venta() As Integer
        Get
            Return Me.mcod_Detalle_Venta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Detalle_Venta = value
        End Set
    End Property
    Public Property cod_Venta() As Integer
        Get
            Return Me.mcod_Venta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Venta = value
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
    Public Property cantidad() As Integer
        Get
            Return Me.mcantidad
        End Get
        Set(ByVal value As Integer)
            Me.mcantidad = value
        End Set
    End Property
    Public Property preciounit() As Double
        Get
            Return Me.mpreciounit
        End Get
        Set(ByVal value As Double)
            Me.mpreciounit = value
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

    Public Property Producto() As Producto
        Get
            Return Me.moProducto
        End Get
        Set(ByVal value As Producto)
            Me.moProducto = value
        End Set
    End Property

    Public ReadOnly Property NombreProducto
        Get
            Return Producto.nombre
        End Get
    End Property

#End Region
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_Detalle_Venta As Integer)
        Me.cod_Detalle_Venta = wcod_Detalle_Venta
    End Sub

    Public Sub New(ByVal wcod_Detalle_Venta As Integer, ByVal wcod_Venta As Integer, ByVal wcod_Producto As Integer, ByVal wcantidad As Integer, ByVal wpreciounit As Double, ByVal wtotal As Double)
        Me.cod_Detalle_Venta = wcod_Detalle_Venta
        Me.cod_Venta = wcod_Venta
        Me.cod_Producto = wcod_Producto
        Me.cantidad = wcantidad
        Me.preciounit = wpreciounit
        Me.total = wtotal
    End Sub
    Public Sub New(ByVal wcod_Detalle_Venta As Integer, ByVal wcod_Venta As Integer, ByVal wcod_Producto As Integer, ByVal wcantidad As Integer, ByVal wpreciounit As Double, ByVal wtotal As Double, ByVal wnombreProducto As String)
        Me.cod_Detalle_Venta = wcod_Detalle_Venta
        Me.cod_Venta = wcod_Venta
        Me.cod_Producto = wcod_Producto
        Me.cantidad = wcantidad
        Me.preciounit = wpreciounit
        Me.total = wtotal

        Me.Producto = New Producto(wcod_Producto, wnombreProducto)

    End Sub
#End Region

End Class