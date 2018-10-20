Public Class SubTipoGasto

#Region "Datos"
	Private mcod_Subtipo AS Integer
	Private mDescripcion AS String
	Private mestado AS String
	Private mcod_TipoGasto AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_Subtipo() AS Integer
		Get
			return Me.mcod_Subtipo
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Subtipo = value
		End Set
	End Property
	Public Property Descripcion() AS String
		Get
			return Me.mDescripcion
		End Get
		Set(ByVal value As String)
			Me.mDescripcion = value
		End Set
	End Property
	Public Property estado() AS String
		Get
			return Me.mestado
		End Get
		Set(ByVal value As String)
			Me.mestado = value
		End Set
	End Property
	Public Property cod_TipoGasto() AS Integer
		Get
			return Me.mcod_TipoGasto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoGasto = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Subtipo As Integer)
        Me.cod_Subtipo = wcod_Subtipo
    End Sub
	Public Sub New(Byval wcod_Subtipo AS Integer,Byval wDescripcion AS String,Byval westado AS String,Byval wcod_TipoGasto AS Integer)
		Me.cod_Subtipo = wcod_Subtipo
		Me.Descripcion = wDescripcion
		Me.estado = westado
		Me.cod_TipoGasto = wcod_TipoGasto
	End Sub
#End Region

End Class