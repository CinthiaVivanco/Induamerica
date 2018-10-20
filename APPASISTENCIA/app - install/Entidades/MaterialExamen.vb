Public Class MaterialExamen

#Region "Datos"
	Private mcod_material AS Integer
	Private mfecha AS Date
    Private mestado As String
    Private mtipo As String

	Private mcod_tecnologo AS Integer
	Private mcod_Consulta AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_material() AS Integer
		Get
			return Me.mcod_material
		End Get
		Set(ByVal value As Integer)
			Me.mcod_material = value
		End Set
	End Property
	Public Property fecha() AS Date
		Get
			return Me.mfecha
		End Get
		Set(ByVal value As Date)
			Me.mfecha = value
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
    Public Property Tipo() As String
        Get
            Return Me.mtipo
        End Get
        Set(ByVal value As String)
            Me.mtipo = value
        End Set
    End Property
	Public Property cod_tecnologo() AS Integer
		Get
			return Me.mcod_tecnologo
		End Get
		Set(ByVal value As Integer)
			Me.mcod_tecnologo = value
		End Set
	End Property
	Public Property cod_Consulta() AS Integer
		Get
			return Me.mcod_Consulta
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Consulta = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_material As Integer)
        Me.cod_material = wcod_material

    End Sub
    Public Sub New(ByVal wcod_material As Integer, ByVal wfecha As Date, ByVal westado As String, ByVal wcod_tecnologo As Integer, ByVal wcod_Consulta As Integer)
        Me.cod_material = wcod_material
        Me.fecha = wfecha
        Me.estado = westado
        Me.cod_tecnologo = wcod_tecnologo
        Me.cod_Consulta = wcod_Consulta
    End Sub
    Public Sub New(ByVal wcod_material As Integer, ByVal wfecha As Date, ByVal westado As String, ByVal wcod_tecnologo As Integer, ByVal wcod_Consulta As Integer, ByVal wtipo As String)
        Me.cod_material = wcod_material
        Me.fecha = wfecha
        Me.estado = westado
        Me.Tipo = wtipo
        Me.cod_tecnologo = wcod_tecnologo
        Me.cod_Consulta = wcod_Consulta
    End Sub
#End Region

End Class