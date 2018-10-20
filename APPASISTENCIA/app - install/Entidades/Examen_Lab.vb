Public Class Examen_Lab

#Region "Datos"
	Private mcod_Examen_Lab AS Integer
	Private mnombre AS String
    Private mprecioPublico As Double
    Private mprecioCerin As Double
	Private mestado AS String
	Private mcod_CentroConvenio AS Integer
	Private mcod_TipoExamen AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_Examen_Lab() AS Integer
		Get
			return Me.mcod_Examen_Lab
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Examen_Lab = value
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
    Public Property precioPublico() As Double
        Get
            Return Me.mprecioPublico
        End Get
        Set(ByVal value As Double)
            Me.mprecioPublico = value
        End Set
    End Property
    Public Property precioCerin() As Double
        Get
            Return Me.mprecioCerin
        End Get
        Set(ByVal value As Double)
            Me.mprecioCerin = value
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
	Public Property cod_CentroConvenio() AS Integer
		Get
			return Me.mcod_CentroConvenio
		End Get
		Set(ByVal value As Integer)
			Me.mcod_CentroConvenio = value
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
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_Examen_Lab As Integer)
        Me.cod_Examen_Lab = wcod_Examen_Lab
    End Sub
    Public Sub New(ByVal wcod_Examen_Lab As Integer, ByVal wnombre As String)
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.nombre = wnombre
    End Sub
    Public Sub New(ByVal wcod_Examen_Lab As Integer, ByVal wnombre As String, ByVal wprecioPublico As Double)
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.nombre = wnombre
        Me.precioPublico = wprecioPublico
    End Sub
    Public Sub New(ByVal wcod_Examen_Lab As Integer, ByVal wnombre As String, ByVal wprecioPublico As Double, ByVal wprecioCerin As Double)
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.nombre = wnombre
        Me.precioPublico = wprecioPublico
        Me.precioCerin = wprecioCerin
    End Sub

    Public Sub New(ByVal wcod_Examen_Lab As Integer, ByVal wnombre As String, ByVal wprecioPublico As Double, ByVal wprecioCerin As Double, ByVal westado As String, ByVal wcod_CentroConvenio As Integer, ByVal wcod_TipoExamen As Integer)
        Me.cod_Examen_Lab = wcod_Examen_Lab
        Me.nombre = wnombre
        Me.precioPublico = wprecioPublico
        Me.precioCerin = wprecioCerin
        Me.estado = westado
        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.cod_TipoExamen = wcod_TipoExamen
    End Sub
#End Region

End Class