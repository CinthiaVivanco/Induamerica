Public Class Plan_Atencion

#Region "Datos"
	Private mcod_PlanAtencion AS Integer
	Private mdescripcion AS String
    Private mdescuento As Double
    Private mPrecio As Double
    Private mestado As String

#End Region

#Region "Propiedades"


    Public Property cod_PlanAtencion() As Integer
        Get
            Return Me.mcod_PlanAtencion
        End Get
        Set(ByVal value As Integer)
            Me.mcod_PlanAtencion = value
        End Set
    End Property
	Public Property descripcion() AS String
		Get
			return Me.mdescripcion
		End Get
		Set(ByVal value As String)
			Me.mdescripcion = value
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
    Public Property Precio() As Double
        Get
            Return Me.mPrecio
        End Get
        Set(ByVal value As Double)
            Me.mPrecio = value
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
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub

    Public Sub New(ByVal wcod_PlanAtencion As Integer)
        Me.cod_PlanAtencion = wcod_PlanAtencion

    End Sub
    Public Sub New(ByVal wcod_PlanAtencion As Integer, ByVal wprecio As Double)
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.Precio = wprecio
    End Sub
    Public Sub New(ByVal wcod_PlanAtencion As Integer, ByVal wnombre As String)
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.descripcion = wnombre
        'Me.Precio = wprecio
    End Sub
    Public Sub New(ByVal wcod_PlanAtencion As Integer, ByVal wdescripcion As String, ByVal wdescuento As Double, ByVal westado As String)
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.descripcion = wdescripcion
        Me.descuento = wdescuento
        Me.estado = westado
    End Sub
    Public Sub New(ByVal wcod_PlanAtencion As Integer, ByVal wdescripcion As String, ByVal wdescuento As Double, ByVal wprecio As Double, ByVal westado As String)
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.descripcion = wdescripcion
        Me.descuento = wdescuento
        Me.Precio = wprecio
        Me.estado = westado
    End Sub

#End Region

End Class