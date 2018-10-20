Public Class TipoGasto

#Region "Datos"
	Private mcod_TipoGasto AS Integer
	Private mDescripcion AS String
	Private mEstado AS String
#End Region
#Region "Propiedades"
	Public Property cod_TipoGasto() AS Integer
		Get
			return Me.mcod_TipoGasto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoGasto = value
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
	Public Property Estado() AS String
		Get
			return Me.mEstado
		End Get
		Set(ByVal value As String)
			Me.mEstado = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub

    Public Sub New(ByVal wcod_TipoGasto As Integer)
         Me.cod_TipoGasto = wcod_TipoGasto
    End Sub

    Public Sub New(ByVal wcod_TipoGasto As Integer, ByVal wDescripcion As String, ByVal wEstado As String)
        Me.cod_TipoGasto = wcod_TipoGasto
        Me.Descripcion = wDescripcion
        Me.Estado = wEstado
    End Sub
#End Region

End Class