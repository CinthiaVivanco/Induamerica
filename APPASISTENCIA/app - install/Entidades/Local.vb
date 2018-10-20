Public Class Local

#Region "Datos"
	Private mcod_local AS Integer
	Private mnombre AS String
	Private mdireccion AS String
	Private mtipo AS String
	Private mestado AS String
	Private mcod_Empresa AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_local() AS Integer
		Get
			return Me.mcod_local
		End Get
		Set(ByVal value As Integer)
			Me.mcod_local = value
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
	Public Property direccion() AS String
		Get
			return Me.mdireccion
		End Get
		Set(ByVal value As String)
			Me.mdireccion = value
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
	Public Property estado() AS String
		Get
			return Me.mestado
		End Get
		Set(ByVal value As String)
			Me.mestado = value
		End Set
	End Property
	Public Property cod_Empresa() AS Integer
		Get
			return Me.mcod_Empresa
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Empresa = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_local As Integer)

        Me.cod_local = wcod_local


    End Sub

    Public Sub New(ByVal wcod_local As Integer, ByVal wnombre As String)

        Me.cod_local = wcod_local
        Me.nombre = wnombre

    End Sub
    Public Sub New(ByVal wcod_local As Integer, ByVal wnombre As String, ByVal wdireccion As String, ByVal wtipo As String, ByVal westado As String, ByVal wcod_Empresa As Integer)
        Me.cod_local = wcod_local
        Me.nombre = wnombre
        Me.direccion = wdireccion
        Me.tipo = wtipo
        Me.estado = westado
        Me.cod_Empresa = wcod_Empresa
    End Sub
#End Region

End Class