Public Class Ambiente

#Region "Datos"
	Private mcod_Ambiente AS Integer
	Private mnombre AS String
	Private mtipo AS String
	Private mcod_local AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_Ambiente() AS Integer
		Get
			return Me.mcod_Ambiente
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Ambiente = value
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
	Public Property tipo() AS String
		Get
			return Me.mtipo
		End Get
		Set(ByVal value As String)
			Me.mtipo = value
		End Set
	End Property
	Public Property cod_local() AS Integer
		Get
			return Me.mcod_local
		End Get
		Set(ByVal value As Integer)
			Me.mcod_local = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_Ambiente As Integer)

        Me.cod_Ambiente = wcod_Ambiente

    End Sub
    Public Sub New(ByVal wcod_Ambiente As Integer, ByVal wnombre As String)

        Me.cod_Ambiente = wcod_Ambiente
        Me.nombre = wnombre

    End Sub
    Public Sub New(ByVal wcod_Ambiente As Integer, ByVal wnombre As String, ByVal wtipo As String, ByVal wcod_local As Integer)
        Me.cod_Ambiente = wcod_Ambiente
        Me.nombre = wnombre
        Me.tipo = wtipo
        Me.cod_local = wcod_local
    End Sub
#End Region

End Class