Public Class turno

#Region "Datos"
	Private mCod_turno AS Integer
	Private mAbrev AS String
	Private mNombre AS String
	Private mHoraIni AS Date
	Private mHoraFin AS Date
#End Region
#Region "Propiedades"
	Public Property Cod_turno() AS Integer
		Get
			return Me.mCod_turno
		End Get
		Set(ByVal value As Integer)
			Me.mCod_turno = value
		End Set
	End Property
	Public Property Abrev() AS String
		Get
			return Me.mAbrev
		End Get
		Set(ByVal value As String)
			Me.mAbrev = value
		End Set
	End Property
	Public Property Nombre() AS String
		Get
			return Me.mNombre
		End Get
		Set(ByVal value As String)
			Me.mNombre = value
		End Set
	End Property
	Public Property HoraIni() AS Date
		Get
			return Me.mHoraIni
		End Get
		Set(ByVal value As Date)
			Me.mHoraIni = value
		End Set
	End Property
	Public Property HoraFin() AS Date
		Get
			return Me.mHoraFin
		End Get
		Set(ByVal value As Date)
			Me.mHoraFin = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wCod_turno AS Integer,Byval wAbrev AS String,Byval wNombre AS String,Byval wHoraIni AS Date,Byval wHoraFin AS Date)
		Me.Cod_turno = wCod_turno
		Me.Abrev = wAbrev
		Me.Nombre = wNombre
		Me.HoraIni = wHoraIni
		Me.HoraFin = wHoraFin
    End Sub
    Public Sub New(ByVal wCod_turno As Integer, ByVal wNombre As String)
        Me.Cod_turno = wCod_turno

        Me.Nombre = wNombre

    End Sub

#End Region

End Class