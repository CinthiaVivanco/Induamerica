Public Class Centro_Convenio

#Region "Datos"
	Private mcod_CentroConvenio AS Integer
	Private mtipo AS String
	Private mrazonSocial AS String
	Private mruc AS String
	Private mtelefono AS String
	Private mcelular AS String
	Private mdireccion AS String
	Private mcod_Distrito AS String
	Private mcod_Provincia AS String
	Private mcod_Departamento AS String
#End Region
#Region "Propiedades"
    Private _codCentro As Integer


    Public Property cod_CentroConvenio() As Integer
        Get
            Return Me.mcod_CentroConvenio
        End Get
        Set(ByVal value As Integer)
            Me.mcod_CentroConvenio = value
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
	Public Property razonSocial() AS String
		Get
			return Me.mrazonSocial
		End Get
		Set(ByVal value As String)
			Me.mrazonSocial = value
		End Set
	End Property
	Public Property ruc() AS String
		Get
			return Me.mruc
		End Get
		Set(ByVal value As String)
			Me.mruc = value
		End Set
	End Property
	Public Property telefono() AS String
		Get
			return Me.mtelefono
		End Get
		Set(ByVal value As String)
			Me.mtelefono = value
		End Set
	End Property
	Public Property celular() AS String
		Get
			return Me.mcelular
		End Get
		Set(ByVal value As String)
			Me.mcelular = value
		End Set
	End Property
	Public Property direccion() AS String
		Get
			return Me.mdireccion
		End Get
		Set(ByVal value As String)
			Me.mdireccion = value
		End Set
	End Property
	Public Property cod_Distrito() AS String
		Get
			return Me.mcod_Distrito
		End Get
		Set(ByVal value As String)
			Me.mcod_Distrito = value
		End Set
	End Property
	Public Property cod_Provincia() AS String
		Get
			return Me.mcod_Provincia
		End Get
		Set(ByVal value As String)
			Me.mcod_Provincia = value
		End Set
	End Property
	Public Property cod_Departamento() AS String
		Get
			return Me.mcod_Departamento
		End Get
		Set(ByVal value As String)
			Me.mcod_Departamento = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_CentroConvenio As Integer)
        Me.cod_CentroConvenio = wcod_CentroConvenio

    End Sub
    Public Sub New(ByVal wcod_CentroConvenio As Integer, ByVal wrazonSocial As String)

        Me.cod_CentroConvenio = wcod_CentroConvenio
        Me.razonSocial = wrazonSocial
    End Sub

	Public Sub New(Byval wcod_CentroConvenio AS Integer,Byval wtipo AS String,Byval wrazonSocial AS String,Byval wruc AS String,Byval wtelefono AS String,Byval wcelular AS String,Byval wdireccion AS String,Byval wcod_Distrito AS String,Byval wcod_Provincia AS String,Byval wcod_Departamento AS String)
		Me.cod_CentroConvenio = wcod_CentroConvenio
		Me.tipo = wtipo
		Me.razonSocial = wrazonSocial
		Me.ruc = wruc
		Me.telefono = wtelefono
		Me.celular = wcelular
		Me.direccion = wdireccion
		Me.cod_Distrito = wcod_Distrito
		Me.cod_Provincia = wcod_Provincia
		Me.cod_Departamento = wcod_Departamento
	End Sub
#End Region

End Class