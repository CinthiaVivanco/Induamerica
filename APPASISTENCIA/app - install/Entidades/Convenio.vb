Public Class Convenio

#Region "Datos"
	Private mcod_Convenio AS Integer
	Private mcod_Examen AS Integer
    Private mprecio As Double
	Private mFechaInicio AS Date
	Private mFechaFin AS Date
	Private mestado AS String
    Private mcod_TipoExamen As Integer
    Private mcod_CentroConvenio As Integer

#End Region
#Region "Propiedades"
	Public Property cod_Convenio() AS Integer
		Get
			return Me.mcod_Convenio
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Convenio = value
		End Set
	End Property
	Public Property cod_Examen() AS Integer
		Get
			return Me.mcod_Examen
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Examen = value
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
	Public Property FechaInicio() AS Date
		Get
			return Me.mFechaInicio
		End Get
		Set(ByVal value As Date)
			Me.mFechaInicio = value
		End Set
	End Property
	Public Property FechaFin() AS Date
		Get
			return Me.mFechaFin
		End Get
		Set(ByVal value As Date)
			Me.mFechaFin = value
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
    Public Property cod_CentroConvenio() As Integer
        Get
            Return Me.mcod_CentroConvenio
        End Get
        Set(ByVal value As Integer)
            Me.mcod_CentroConvenio = value
        End Set
    End Property

#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Convenio As Integer)
        Me.cod_Convenio = wcod_Convenio

    End Sub
    Public Sub New(ByVal wcod_Convenio As Integer, ByVal wprecio As Double)
        Me.cod_Convenio = wcod_Convenio
        Me.precio = wprecio
    End Sub
    Public Sub New(ByVal wcod_Convenio As Integer, ByVal wcod_Examen As Integer, ByVal wprecio As Double, ByVal wFechaInicio As Date, ByVal wFechaFin As Date, ByVal westado As String, ByVal wcod_TipoExamen As Integer, ByVal wcod_CentroConvenio As Integer)
        Me.cod_Convenio = wcod_Convenio
        Me.cod_Examen = wcod_Examen
        Me.precio = wprecio
        Me.FechaInicio = wFechaInicio
        Me.FechaFin = wFechaFin
        Me.estado = westado
        Me.cod_TipoExamen = wcod_TipoExamen
        Me.cod_CentroConvenio = wcod_CentroConvenio
    End Sub
#End Region

End Class