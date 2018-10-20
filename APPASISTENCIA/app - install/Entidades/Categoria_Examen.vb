Public Class Categoria_Examen

#Region "Datos"
	Private mcod_Categoria AS Integer
	Private mnombre AS String
    Private mprecio As Double
    Private mestado As String
    Private mcod_Centro As Integer
#End Region
#Region "Propiedades"
    Private _codCateg As Integer


    Public Property cod_Categoria() As Integer
        Get
            Return Me.mcod_Categoria
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Categoria = value
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
    Public Property precio() As Double
        Get
            Return Me.mprecio
        End Get
        Set(ByVal value As Double)
            Me.mprecio = value
        End Set
    End Property

    Public Property cod_Centro() As Integer
        Get
            Return Me.mcod_Centro
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Centro = value
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
    Public Sub New(ByVal wcod_Categoria As Integer)
        Me.cod_Categoria = wcod_Categoria
    End Sub

    Public Sub New(ByVal wcod_Categoria As Integer, ByVal wnombre As String, ByVal wprecio As Double, ByVal westado As String, ByVal wcod_Centro As Integer)
        Me.cod_Categoria = wcod_Categoria
        Me.nombre = wnombre
        Me.precio = wprecio
        Me.estado = westado
        Me.mcod_Centro = wcod_Centro


    End Sub
#End Region

End Class