Public Class Proveedor

#Region "Datos"
	Private mcod_Proveedor AS Integer
	Private mruc AS String
	Private mrazonsocial AS String
	Private mnombreComercial AS String
	Private mtipoContribuyente AS String
	Private mTelefono AS String
	Private mdireccion AS String
	Private mestado AS String
#End Region
#Region "Propiedades"
	Public Property cod_Proveedor() AS Integer
		Get
			return Me.mcod_Proveedor
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Proveedor = value
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
	Public Property razonsocial() AS String
		Get
			return Me.mrazonsocial
		End Get
		Set(ByVal value As String)
			Me.mrazonsocial = value
		End Set
	End Property
	Public Property nombreComercial() AS String
		Get
			return Me.mnombreComercial
		End Get
		Set(ByVal value As String)
			Me.mnombreComercial = value
		End Set
	End Property
	Public Property tipoContribuyente() AS String
		Get
			return Me.mtipoContribuyente
		End Get
		Set(ByVal value As String)
			Me.mtipoContribuyente = value
		End Set
	End Property
	Public Property Telefono() AS String
		Get
			return Me.mTelefono
		End Get
		Set(ByVal value As String)
			Me.mTelefono = value
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
	Public Property estado() AS String
		Get
			return Me.mestado
		End Get
		Set(ByVal value As String)
			Me.mestado = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Proveedor As Integer)

        Me.cod_Proveedor = wcod_Proveedor

    End Sub
    Public Sub New(ByVal wcod_Proveedor As Integer, ByVal wruc As String, ByVal wrazonsocial As String)

        Me.cod_Proveedor = wcod_Proveedor
        Me.ruc = wruc
        Me.razonsocial = wrazonsocial

    End Sub
	Public Sub New(Byval wcod_Proveedor AS Integer,Byval wruc AS String,Byval wrazonsocial AS String,Byval wnombreComercial AS String,Byval wtipoContribuyente AS String,Byval wTelefono AS String,Byval wdireccion AS String,Byval westado AS String)
		Me.cod_Proveedor = wcod_Proveedor
		Me.ruc = wruc
		Me.razonsocial = wrazonsocial
		Me.nombreComercial = wnombreComercial
		Me.tipoContribuyente = wtipoContribuyente
		Me.Telefono = wTelefono
		Me.direccion = wdireccion
		Me.estado = westado
	End Sub
#End Region

End Class