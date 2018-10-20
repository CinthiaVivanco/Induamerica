Public Class Detalle_Egreso

#Region "Datos"
	Private mcod_detalle AS Integer
	Private mdescripcion AS String
    Private mprecio As Double
    Private mcod_Egreso As Integer

    Private mOEgreso As Egreso

#End Region
#Region "Propiedades"
    Public Property cod_detalle() As Integer
        Get
            Return Me.mcod_detalle
        End Get
        Set(ByVal value As Integer)
            Me.mcod_detalle = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return Me.mdescripcion
        End Get
        Set(ByVal value As String)
            Me.mdescripcion = value
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
    Public Property cod_Egreso() As Integer
        Get
            Return Me.mcod_Egreso
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Egreso = value
        End Set
    End Property



    Public Property Egreso() As Egreso
        Get
            Return Me.mOEgreso
        End Get
        Set(ByVal value As Egreso)
            Me.mOEgreso = value
        End Set
    End Property


#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_detalle As Integer)

        Me.cod_detalle = wcod_detalle

    End Sub
    Public Sub New(ByVal wcod_detalle As Integer, ByVal wdescripcion As String, ByVal wprecio As Double, ByVal wcod_Egreso As Integer, ByVal wfecha As Date, ByVal wEstado As String, ByVal wMontoTotal As Double)
        Me.cod_detalle = wcod_detalle
        Me.descripcion = wdescripcion
        Me.precio = wprecio
        Me.cod_Egreso = wcod_Egreso
        Me.Egreso = New Egreso(wcod_Egreso, wfecha, wMontoTotal, wEstado, "")
    End Sub
    Public Sub New(ByVal wcod_detalle As Integer, ByVal wdescripcion As String, ByVal wprecio As Double, ByVal wcod_Egreso As Integer)
        Me.cod_detalle = wcod_detalle
        Me.descripcion = wdescripcion
        Me.precio = wprecio
        Me.cod_Egreso = wcod_Egreso

    End Sub
#End Region

End Class