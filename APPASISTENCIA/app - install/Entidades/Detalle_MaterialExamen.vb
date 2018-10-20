Public Class Detalle_MaterialExamen

#Region "Datos"
	Private mcod_DetalleMaterial AS Integer
	Private mcod_material AS Integer
	Private mcod_Producto AS Integer
    Private mcantidad As Double
    Private mmalas As Double
#End Region
#Region "Propiedades"
	Public Property cod_DetalleMaterial() AS Integer
		Get
			return Me.mcod_DetalleMaterial
		End Get
		Set(ByVal value As Integer)
			Me.mcod_DetalleMaterial = value
		End Set
	End Property
	Public Property cod_material() AS Integer
		Get
			return Me.mcod_material
		End Get
		Set(ByVal value As Integer)
			Me.mcod_material = value
		End Set
	End Property
	Public Property cod_Producto() AS Integer
		Get
			return Me.mcod_Producto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Producto = value
		End Set
	End Property
    Public Property cantidad() As Double
        Get
            Return Me.mcantidad
        End Get
        Set(ByVal value As Double)
            Me.mcantidad = value
        End Set
    End Property
    Public Property malas() As Double
        Get
            Return Me.mmalas
        End Get
        Set(ByVal value As Double)
            Me.mmalas = value
        End Set
    End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_DetalleMaterial As Integer, ByVal wcod_material As Integer, ByVal wcod_Producto As Integer, ByVal wcantidad As Double, ByVal wmalas As Double)
        Me.cod_DetalleMaterial = wcod_DetalleMaterial
        Me.cod_material = wcod_material
        Me.cod_Producto = wcod_Producto
        Me.cantidad = wcantidad
        Me.malas = wmalas
    End Sub
#End Region

End Class