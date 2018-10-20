Public Class Provincia

#Region "Datos"
	Private mcod_Provincia AS String
	Private mnombre_Prov AS String
	Private mcod_Departamento AS String
#End Region
#Region "Propiedades"
	Public Property cod_Provincia() AS String
		Get
			return Me.mcod_Provincia
		End Get
		Set(ByVal value As String)
			Me.mcod_Provincia = value
		End Set
	End Property
	Public Property nombre_Prov() AS String
		Get
			return Me.mnombre_Prov
		End Get
		Set(ByVal value As String)
			Me.mnombre_Prov = value
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
	Public Sub New(Byval wcod_Provincia AS String,Byval wnombre_Prov AS String,Byval wcod_Departamento AS String)
		Me.cod_Provincia = wcod_Provincia
		Me.nombre_Prov = wnombre_Prov
		Me.cod_Departamento = wcod_Departamento
	End Sub
#End Region

End Class