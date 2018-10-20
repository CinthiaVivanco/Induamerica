Public Class TipoDocumento

#Region "Datos"
	Private mcod_TipoDoc AS Integer
	Private mDescripcion AS String
	Private mEstado AS String
#End Region
#Region "Propiedades"
	Public Property cod_TipoDoc() AS Integer
		Get
			return Me.mcod_TipoDoc
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoDoc = value
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
    Public Sub New(ByVal wcod_TipoDoc As Integer)
         Me.cod_TipoDoc = wcod_TipoDoc
    End Sub
    Public Sub New(ByVal wcod_TipoDoc As Integer, ByVal wDescripcion As String, ByVal wEstado As String)
        Me.cod_TipoDoc = wcod_TipoDoc
        Me.Descripcion = wDescripcion
        Me.Estado = wEstado
    End Sub
#End Region

End Class