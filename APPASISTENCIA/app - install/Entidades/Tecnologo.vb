Public Class Tecnologo

#Region "Datos"
	Private mcod_tecnologo AS Integer
	Private mdni AS String
	Private mnombre AS String
#End Region
#Region "Propiedades"
	Public Property cod_tecnologo() AS Integer
		Get
			return Me.mcod_tecnologo
		End Get
		Set(ByVal value As Integer)
			Me.mcod_tecnologo = value
		End Set
	End Property
	Public Property dni() AS String
		Get
			return Me.mdni
		End Get
		Set(ByVal value As String)
			Me.mdni = value
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
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub

    Public Sub New(ByVal wcod_tecnologo As Integer)

        Me.cod_tecnologo = wcod_tecnologo

    End Sub

    Public Sub New(ByVal wcod_tecnologo As Integer, ByVal wnombre As String)

        Me.cod_tecnologo = wcod_tecnologo
        Me.nombre = wnombre

    End Sub
    Public Sub New(ByVal wcod_tecnologo As Integer, ByVal wdni As String, ByVal wnombre As String)
        Me.cod_tecnologo = wcod_tecnologo
        Me.dni = wdni
        Me.nombre = wnombre
    End Sub
#End Region

End Class