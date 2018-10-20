Public Class Falta

#Region "Datos"
	Private mcod_Falta AS Integer
	Private mcodigoPersonal AS Integer
	Private mdia AS Date
#End Region
#Region "Propiedades"
	Public Property cod_Falta() AS Integer
		Get
			return Me.mcod_Falta
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Falta = value
		End Set
	End Property
	Public Property codigoPersonal() AS Integer
		Get
			return Me.mcodigoPersonal
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoPersonal = value
		End Set
	End Property
	Public Property dia() AS Date
		Get
			return Me.mdia
		End Get
		Set(ByVal value As Date)
			Me.mdia = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Falta As Integer)

        Me.cod_Falta = wcod_Falta

    End Sub
	Public Sub New(Byval wcod_Falta AS Integer,Byval wcodigoPersonal AS Integer,Byval wdia AS Date)
		Me.cod_Falta = wcod_Falta
		Me.codigoPersonal = wcodigoPersonal
		Me.dia = wdia
	End Sub
#End Region

End Class