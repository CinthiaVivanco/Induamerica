Public Class reniectipodocumentos

#Region "Datos"
	Private mid AS String
	Private mnombre AS String
	Private matributo AS String
	Private mactivo AS Boolean
	Private mcreated_at AS Date
	Private mupdated_at AS Date
#End Region
#Region "Propiedades"
	Public Property id() AS String
		Get
			return Me.mid
		End Get
		Set(ByVal value As String)
			Me.mid = value
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
	Public Property atributo() AS String
		Get
			return Me.matributo
		End Get
		Set(ByVal value As String)
			Me.matributo = value
		End Set
	End Property
	Public Property activo() AS Boolean
		Get
			return Me.mactivo
		End Get
		Set(ByVal value As Boolean)
			Me.mactivo = value
		End Set
	End Property
	Public Property created_at() AS Date
		Get
			return Me.mcreated_at
		End Get
		Set(ByVal value As Date)
			Me.mcreated_at = value
		End Set
	End Property
	Public Property updated_at() AS Date
		Get
			return Me.mupdated_at
		End Get
		Set(ByVal value As Date)
			Me.mupdated_at = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wid As String)

        Me.id = wid

    End Sub
	Public Sub New(Byval wid AS String,Byval wnombre AS String,Byval watributo AS String,Byval wactivo AS Boolean,Byval wcreated_at AS Date,Byval wupdated_at AS Date)
		Me.id = wid
		Me.nombre = wnombre
		Me.atributo = watributo
		Me.activo = wactivo
		Me.created_at = wcreated_at
		Me.updated_at = wupdated_at
	End Sub
#End Region

End Class