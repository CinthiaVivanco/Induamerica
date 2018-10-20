Public Class Distrito

#Region "Datos"
	Private mcod_Distrito AS String
	Private mnombre_Dist AS String
	Private mcod_Provincia AS String
	Private mcod_Departamento AS String
#End Region
#Region "Propiedades"
	Public Property cod_Distrito() AS String
		Get
			return Me.mcod_Distrito
		End Get
		Set(ByVal value As String)
			Me.mcod_Distrito = value
		End Set
	End Property
	Public Property nombre_Dist() AS String
		Get
			return Me.mnombre_Dist
		End Get
		Set(ByVal value As String)
			Me.mnombre_Dist = value
		End Set
	End Property
	Public Property cod_Provincia() AS String
		Get
			return Me.mcod_Provincia
		End Get
		Set(ByVal value As String)
			Me.mcod_Provincia = value
		End Set
	End Property
	Public Property cod_Departamento() AS String
		Get
			return Me.mcod_Departamento
		End Get
		Set(ByVal value As String)
			Me.mcod_Departamento = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcod_Distrito AS String,Byval wnombre_Dist AS String,Byval wcod_Provincia AS String,Byval wcod_Departamento AS String)
		Me.cod_Distrito = wcod_Distrito
		Me.nombre_Dist = wnombre_Dist
		Me.cod_Provincia = wcod_Provincia
		Me.cod_Departamento = wcod_Departamento
	End Sub
#End Region

End Class