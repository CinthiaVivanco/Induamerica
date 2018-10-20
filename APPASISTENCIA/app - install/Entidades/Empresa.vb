Public Class Empresa

#Region "Datos"
	Private mcod_Empresa AS Integer
	Private mrazonsocial AS String
	Private mruc AS String
	Private mdireccion AS String
	Private mnombrecomercial AS String
	Private mreplegal AS String
	Private mdnireplegal AS String
#End Region
#Region "Propiedades"
	Public Property cod_Empresa() AS Integer
		Get
			return Me.mcod_Empresa
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Empresa = value
		End Set
	End Property
	Public Property razonsocial() AS String
		Get
			return Me.mrazonsocial
		End Get
		Set(ByVal value As String)
			Me.mrazonsocial = value
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
	Public Property direccion() AS String
		Get
			return Me.mdireccion
		End Get
		Set(ByVal value As String)
			Me.mdireccion = value
		End Set
	End Property
	Public Property nombrecomercial() AS String
		Get
			return Me.mnombrecomercial
		End Get
		Set(ByVal value As String)
			Me.mnombrecomercial = value
		End Set
	End Property
	Public Property replegal() AS String
		Get
			return Me.mreplegal
		End Get
		Set(ByVal value As String)
			Me.mreplegal = value
		End Set
	End Property
	Public Property dnireplegal() AS String
		Get
			return Me.mdnireplegal
		End Get
		Set(ByVal value As String)
			Me.mdnireplegal = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_Empresa As Integer)

        Me.cod_Empresa = wcod_Empresa

    End Sub

    Public Sub New(ByVal wcod_Empresa As Integer, ByVal wrazonsocial As String, ByVal wruc As String, ByVal wdireccion As String, ByVal wnombrecomercial As String, ByVal wreplegal As String, ByVal wdnireplegal As String)
        Me.cod_Empresa = wcod_Empresa
        Me.razonsocial = wrazonsocial
        Me.ruc = wruc
        Me.direccion = wdireccion
        Me.nombrecomercial = wnombrecomercial
        Me.replegal = wreplegal
        Me.dnireplegal = wdnireplegal
    End Sub
#End Region

End Class