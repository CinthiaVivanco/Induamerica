Public Class USUARIO_GRUPO

#Region "Datos"
	Private mcodigoUsu AS Integer
	Private mcodigoGrupoUsu AS Integer
#End Region
#Region "Propiedades"
	Public Property codigoUsu() AS Integer
		Get
			return Me.mcodigoUsu
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoUsu = value
		End Set
	End Property
	Public Property codigoGrupoUsu() AS Integer
		Get
			return Me.mcodigoGrupoUsu
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoGrupoUsu = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcodigoUsu AS Integer,Byval wcodigoGrupoUsu AS Integer)
		Me.codigoUsu = wcodigoUsu
		Me.codigoGrupoUsu = wcodigoGrupoUsu
	End Sub
#End Region

End Class