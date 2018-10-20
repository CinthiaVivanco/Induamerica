Public Class Departamento

#Region "Datos"
	Private mcod_Departamento AS String
	Private mnombre_Dep AS String
#End Region
#Region "Propiedades"
	Public Property cod_Departamento() AS String
		Get
			return Me.mcod_Departamento
		End Get
		Set(ByVal value As String)
			Me.mcod_Departamento = value
		End Set
	End Property
	Public Property nombre_Dep() AS String
		Get
			return Me.mnombre_Dep
		End Get
		Set(ByVal value As String)
			Me.mnombre_Dep = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcod_Departamento AS String,Byval wnombre_Dep AS String)
		Me.cod_Departamento = wcod_Departamento
		Me.nombre_Dep = wnombre_Dep
	End Sub
#End Region

End Class