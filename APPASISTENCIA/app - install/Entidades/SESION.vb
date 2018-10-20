Public Class SESION

#Region "Datos"
	Private mcodigoSesion AS Integer
	Private mfechaIni AS Date
	Private mfechaFin AS Date
	Private mcodigoUsu AS Integer
#End Region
#Region "Propiedades"
	Public Property codigoSesion() AS Integer
		Get
			return Me.mcodigoSesion
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoSesion = value
		End Set
	End Property
	Public Property fechaIni() AS Date
		Get
			return Me.mfechaIni
		End Get
		Set(ByVal value As Date)
			Me.mfechaIni = value
		End Set
	End Property
	Public Property fechaFin() AS Date
		Get
			return Me.mfechaFin
		End Get
		Set(ByVal value As Date)
			Me.mfechaFin = value
		End Set
	End Property
	Public Property codigoUsu() AS Integer
		Get
			return Me.mcodigoUsu
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoUsu = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcodigoSesion AS Integer,Byval wfechaIni AS Date,Byval wfechaFin AS Date,Byval wcodigoUsu AS Integer)
		Me.codigoSesion = wcodigoSesion
		Me.fechaIni = wfechaIni
		Me.fechaFin = wfechaFin
		Me.codigoUsu = wcodigoUsu
	End Sub
#End Region

End Class