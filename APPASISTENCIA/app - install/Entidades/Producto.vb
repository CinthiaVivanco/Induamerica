Public Class Producto

#Region "Datos"
	Private mcod_Producto AS Integer
	Private mnombre AS String
    Private mprecio As Double
    Private mestado As String
    Private mstockMinimo As Integer
    Private mstock As Integer
    Private mventa As Integer

    Private mcod_Unidad As Integer
    Private mcod_UnidadPres As Integer
    Private mcontenido As Integer
    Private mcod_categoria As Integer

    Private mOCategoria As CategoriaProducto
    Private mOUnidadMedida As UnidadMedida
    Private mOUnidadMedidaPres As UnidadMedida

#End Region


#Region "Propiedades"
    Public Property cod_Producto() As Integer
        Get
            Return Me.mcod_Producto
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Producto = value
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
    Public Property precio() As Double
        Get
            Return Me.mprecio
        End Get
        Set(ByVal value As Double)
            Me.mprecio = value
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
    Public Property stock() As Integer
        Get
            Return Me.mstock
        End Get
        Set(ByVal value As Integer)
            Me.mstock = value
        End Set
    End Property
    Public Property venta() As Integer
        Get
            Return Me.mventa
        End Get
        Set(ByVal value As Integer)
            Me.mventa = value
        End Set
    End Property
    Public Property stockMinimo() As Integer
        Get
            Return Me.mstockMinimo
        End Get
        Set(ByVal value As Integer)
            Me.mstockMinimo = value
        End Set
    End Property
    Public Property cod_Unidad() As Integer
        Get
            Return Me.mcod_Unidad
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Unidad = value
        End Set
    End Property
    Public Property cod_UnidadPres() As Integer
        Get
            Return Me.mcod_UnidadPres
        End Get
        Set(ByVal value As Integer)
            Me.mcod_UnidadPres = value
        End Set
    End Property
    Public Property contenido() As Integer
        Get
            Return Me.mcontenido
        End Get
        Set(ByVal value As Integer)
            Me.mcontenido = value
        End Set
    End Property
    Public Property cod_categoria() As Integer
        Get
            Return Me.mcod_categoria
        End Get
        Set(ByVal value As Integer)
            Me.mcod_categoria = value
        End Set
    End Property

    Public Property CategoriaProducto() As CategoriaProducto
        Get
            Return Me.mOCategoria
        End Get
        Set(ByVal value As CategoriaProducto)
            Me.mOCategoria = value
        End Set
    End Property


    Public ReadOnly Property NombreCategoria As String
        Get
            Return mOCategoria.nombre
        End Get
    End Property

    Public Property UnidadMedida As UnidadMedida
        Get
            Return Me.mOUnidadMedida
        End Get
        Set(ByVal value As UnidadMedida)
            Me.mOUnidadMedida = value
        End Set
    End Property

    Public ReadOnly Property NombreUnidad As String
        Get
            Return mOUnidadMedida.nombre
        End Get
    End Property
    Public Property UnidadMedidaPres As UnidadMedida
        Get
            Return Me.mOUnidadMedidaPres
        End Get
        Set(ByVal value As UnidadMedida)
            Me.mOUnidadMedidaPres = value
        End Set
    End Property

    Public ReadOnly Property NombreUnidadPres As String
        Get
            Return mOUnidadMedidaPres.nombre()
        End Get
    End Property

#End Region

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_Producto As Integer)


        Me.cod_Producto = wcod_Producto

    End Sub
    Public Sub New(ByVal wcod_Producto As Integer, ByVal wnombre As String)

        Me.cod_Producto = wcod_Producto
        Me.nombre = wnombre

    End Sub

    Public Sub New(ByVal wcod_Producto As Integer, ByVal wnombre As String, ByVal wprecio As Double, ByVal westado As String, ByVal wstock As Integer, ByVal wstockMinimo As Integer, ByVal wcod_Unidad As Integer, ByVal wcod_UnidadPres As Integer, ByVal wcontenido As Integer, ByVal wcod_categoria As Integer)
        Me.cod_Producto = wcod_Producto
        Me.nombre = wnombre
        Me.precio = wprecio
        Me.estado = westado
        Me.stock = wstock
        Me.stockMinimo = wstockMinimo
        Me.cod_Unidad = wcod_Unidad
        Me.cod_UnidadPres = wcod_UnidadPres
        Me.contenido = wcontenido
        Me.cod_categoria = wcod_categoria
    End Sub
    Public Sub New(ByVal wcod_Producto As Integer, ByVal wnombre As String, ByVal wprecio As Double, ByVal westado As String, ByVal wstock As Integer, ByVal wstockMinimo As Integer, ByVal wcod_Unidad As Integer, ByVal wcod_UnidadPres As Integer, ByVal wcontenido As Integer, ByVal wcod_categoria As Integer, ByVal wventa As Integer)
        Me.cod_Producto = wcod_Producto
        Me.nombre = wnombre
        Me.precio = wprecio
        Me.estado = westado
        Me.stock = wstock
        Me.stockMinimo = wstockMinimo
        Me.cod_Unidad = wcod_Unidad
        Me.cod_UnidadPres = wcod_UnidadPres
        Me.contenido = wcontenido
        Me.cod_categoria = wcod_categoria
        Me.venta = wventa
    End Sub
    Public Sub New(ByVal wcod_Producto As Integer, ByVal wnombre As String, ByVal wprecio As Double, ByVal westado As String, ByVal wstock As Integer, ByVal wstockMinimo As Integer, ByVal wcod_Unidad As Integer, ByVal wnombreUnidad As String, ByVal wcod_UnidadPres As Integer, ByVal wnombreUnidadPres As String, ByVal wcontenido As Integer, ByVal wcod_categoria As Integer, ByVal wnombreCategoria As String)
        Me.cod_Producto = wcod_Producto
        Me.nombre = wnombre
        Me.precio = wprecio
        Me.estado = westado
        Me.stock = wstock
        Me.stockMinimo = wstockMinimo

        Me.contenido = wcontenido
        Me.cod_Unidad = wcod_Unidad
        Me.cod_UnidadPres = wcod_UnidadPres
        Me.cod_categoria = wcod_categoria

        CategoriaProducto = New CategoriaProducto(wcod_categoria, wnombreCategoria, "")
        UnidadMedida = New UnidadMedida(wcod_Unidad, wnombreUnidad, "")
        UnidadMedidaPres = New UnidadMedida(wcod_UnidadPres, wnombreUnidadPres, "")


    End Sub
#End Region

End Class