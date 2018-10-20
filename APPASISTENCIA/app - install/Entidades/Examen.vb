Public Class Examen
#Region "Datos"
    Private mcod_Examen As Integer
    Private mnombre As String
    Private mtipo As String
    Private mprecio As Double
    Private mcod_Categoria As Integer
    Private mestado As String
    Private mcod_TipoExamen As Integer
    Private mcod_CentroConvenio As Integer
    Private mFormato As Formato
    Private mprecioConv As Double
    Private mprecioreporte As Double

    Private mElegir As Boolean

#End Region
#Region "Propiedades"



    Public Property cod_Examen() As Integer
        Get
            Return Me.mcod_Examen
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Examen = value
        End Set
    End Property
	Public Property nombre() AS String
		Get
			return Me.mnombre
		End Get
		Set(ByVal value As String)
			Me.mnombre = value
		End Set
	End Property
	Public Property tipo() AS String
		Get
			return Me.mtipo
		End Get
		Set(ByVal value As String)
			Me.mtipo = value
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
    Public Property precioUnit_Ex() As Double
        Get
            Return Me.mprecio
        End Get
        Set(ByVal value As Double)
            Me.mprecio = value
        End Set
    End Property
	Public Property cod_Categoria() AS Integer
		Get
			return Me.mcod_Categoria
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Categoria = value
		End Set
	End Property
	Public Property estado() AS String
		Get
			return Me.mestado
		End Get
		Set(ByVal value As String)
			Me.mestado = value
		End Set
	End Property
	Public Property cod_TipoExamen() AS Integer
		Get
			return Me.mcod_TipoExamen
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoExamen = value
		End Set
	End Property
	Public Property cod_CentroConvenio() AS Integer
		Get
			return Me.mcod_CentroConvenio
		End Get
		Set(ByVal value As Integer)
			Me.mcod_CentroConvenio = value
		End Set
    End Property

    Public Property Formato() As Formato
        Get
            Return Me.mFormato
        End Get
        Set(ByVal value As Formato)
            Me.mFormato = value
        End Set
    End Property
    Public Property precioConv() As Double
        Get
            Return Me.mprecioConv
        End Get
        Set(ByVal value As Double)
            Me.mprecioConv = value
        End Set
    End Property

    Public Property Elegir As Boolean
        Get
            Return Me.mElegir
        End Get
        Set(ByVal value As Boolean)
            Me.mElegir = value
        End Set
    End Property

    Public Property precioreporte() As Double
        Get
            Return Me.mprecioreporte
        End Get
        Set(ByVal value As Double)
            Me.mprecioreporte = value
        End Set
    End Property

#End Region 
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_Examen As Integer)
        Me.cod_Examen = wcod_Examen
    End Sub
    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String)
        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
    End Sub
    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String, wprecio As Double)
        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
        Me.precio = wprecio
    End Sub
    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String, ByVal wprecio As Double, ByVal wprecioreporte As Double)
        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
        Me.precio = wprecio
        Me.precioreporte = wprecioreporte
    End Sub

    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String, ByVal wtipo As String, ByVal wprecio As Double, ByVal wcod_Categoria As Integer, ByVal westado As String, ByVal wcod_TipoExamen As Integer, ByVal wcod_CentroConvenio As Integer, ByVal wcod_formato As Integer, ByVal wprecioConv As Double)
        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
        Me.tipo = wtipo
        Me.precio = wprecio
        Me.cod_Categoria = wcod_Categoria
        Me.estado = westado
        Me.cod_TipoExamen = wcod_TipoExamen
        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.Formato = New Formato(wcod_formato)

        Me.precioConv = wprecioConv

        Me.Elegir = False
    End Sub

    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String, ByVal wtipo As String, ByVal wprecio As Double, ByVal wcod_Categoria As Integer, ByVal westado As String, ByVal wcod_TipoExamen As Integer, ByVal wcod_CentroConvenio As Integer, ByVal wprecioConv As Double _
                    , ByVal wcod_Formato As Integer, ByVal wContenido As String)
        Me.Formato = New Formato(wcod_Formato, wContenido)

        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
        Me.tipo = wtipo
        Me.precio = wprecio
        Me.cod_Categoria = wcod_Categoria
        Me.estado = westado
        Me.cod_TipoExamen = wcod_TipoExamen
        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.precioConv = wprecioConv
        Me.Elegir = False
    End Sub
    Public Sub New(ByVal wcod_Examen As Integer, ByVal wnombre As String, ByVal wtipo As String, ByVal wprecio As Double, ByVal wcod_Categoria As Integer, ByVal westado As String, ByVal wcod_TipoExamen As Integer, ByVal wcod_CentroConvenio As Integer, ByVal wprecioConv As Double _
                  , ByVal wprecioUnit_ex As Double, ByVal wcod_Formato As Integer, ByVal wContenido As String)
        Me.Formato = New Formato(wcod_Formato, wContenido)

        Me.cod_Examen = wcod_Examen
        Me.nombre = wnombre
        Me.tipo = wtipo
        Me.precio = wprecio
        Me.cod_Categoria = wcod_Categoria
        Me.estado = westado
        Me.cod_TipoExamen = wcod_TipoExamen
        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.precioConv = wprecioConv
        Me.precioUnit_Ex = wprecioUnit_ex
        Me.Elegir = False
    End Sub
#End Region

End Class