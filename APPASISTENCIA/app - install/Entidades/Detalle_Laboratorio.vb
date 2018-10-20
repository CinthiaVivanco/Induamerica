Public Class Detalle_Laboratorio

#Region "Datos"
	Private mcod_Detalle_Lab AS Integer
	Private mcod_Examen_Lab AS Integer
	Private mcantidad AS Integer
	Private mmontoTotal AS Double
    Private mcod_Laboratorio As Integer

    Private moExamenLab As Examen_Lab
#End Region
#Region "Propiedades"
	Public Property cod_Detalle_Lab() AS Integer
		Get
			return Me.mcod_Detalle_Lab
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Detalle_Lab = value
		End Set
	End Property
	Public Property cod_Examen_Lab() AS Integer
		Get
			return Me.mcod_Examen_Lab
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Examen_Lab = value
		End Set
	End Property
	Public Property cantidad() AS Integer
		Get
			return Me.mcantidad
		End Get
		Set(ByVal value As Integer)
			Me.mcantidad = value
		End Set
	End Property
	Public Property montoTotal() AS Double
		Get
			return Me.mmontoTotal
		End Get
		Set(ByVal value As Double)
			Me.mmontoTotal = value
		End Set
	End Property
	Public Property cod_Laboratorio() AS Integer
		Get
			return Me.mcod_Laboratorio
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Laboratorio = value
		End Set
    End Property

    Public Property Examen() As Examen_Lab
        Get
            Return Me.moExamenLab
        End Get
        Set(ByVal value As Examen_Lab)
            Me.moExamenLab = value
        End Set
    End Property

    Public ReadOnly Property nombreExamen_Lab As String
        Get
            Return Examen.nombre
        End Get
    End Property

    Public ReadOnly Property PrecioExamenLab As Double
        Get
            Return Examen.precioPublico
        End Get
    End Property

#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Detalle_Lab As Integer, ByVal wcod_Laboratorio As Integer)
        Me.cod_Detalle_Lab = wcod_Detalle_Lab

        Me.cod_Laboratorio = wcod_Laboratorio
    End Sub
    Public Sub New(ByVal wcod_Detalle_Lab As Integer, ByVal wcod_Examen_Lab As Integer, ByVal wcantidad As Integer, ByVal wmontoTotal As Double, ByVal wcod_Laboratorio As Integer)
        Me.cod_Detalle_Lab = wcod_Detalle_Lab
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.cantidad = wcantidad
        Me.montoTotal = wmontoTotal
        Me.cod_Laboratorio = wcod_Laboratorio
    End Sub
    Public Sub New(ByVal wcod_Detalle_Lab As Integer, ByVal wcod_Examen_Lab As Integer, ByVal wcantidad As Integer, ByVal wmontoTotal As Double, ByVal wcod_Laboratorio As Integer, ByVal wNombreExamen As String, ByVal wprecioExa As Double)
        Me.cod_Detalle_Lab = wcod_Detalle_Lab
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.cantidad = wcantidad
        Me.montoTotal = wmontoTotal
        Me.cod_Laboratorio = wcod_Laboratorio
        Me.Examen = New Examen_Lab(wcod_Examen_Lab, wNombreExamen, wprecioExa)
    End Sub
#End Region

End Class