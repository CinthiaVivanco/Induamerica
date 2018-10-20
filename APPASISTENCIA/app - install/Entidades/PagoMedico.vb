Public Class PagoMedico

#Region "Datos"
	Private mcod_PagoMedico AS Integer
	Private mperiodoid AS String
	Private mCod_Medico AS Integer
	Private mDcto AS Double
    Private mTotal As Double
    Private mTipo As String
#End Region
#Region "Propiedades"
	Public Property cod_PagoMedico() AS Integer
		Get
			return Me.mcod_PagoMedico
		End Get
		Set(ByVal value As Integer)
			Me.mcod_PagoMedico = value
		End Set
	End Property
	Public Property periodoid() AS String
		Get
			return Me.mperiodoid
		End Get
		Set(ByVal value As String)
			Me.mperiodoid = value
		End Set
	End Property
	Public Property Cod_Medico() AS Integer
		Get
			return Me.mCod_Medico
		End Get
		Set(ByVal value As Integer)
			Me.mCod_Medico = value
		End Set
	End Property
	Public Property Dcto() AS Double
		Get
			return Me.mDcto
		End Get
		Set(ByVal value As Double)
			Me.mDcto = value
		End Set
	End Property
	Public Property Total() AS Double
		Get
			return Me.mTotal
		End Get
		Set(ByVal value As Double)
			Me.mTotal = value
		End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Me.mTipo
        End Get
        Set(ByVal value As String)
            Me.mTipo = value
        End Set
    End Property

#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_PagoMedico As Integer)
         Me.cod_PagoMedico = wcod_PagoMedico

    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wCod_Medico As Integer, wtipo As String)

        Me.periodoid = wperiodoid
        Me.Cod_Medico = wCod_Medico
        Me.Tipo = wtipo
    End Sub
	Public Sub New(Byval wcod_PagoMedico AS Integer,Byval wperiodoid AS String,Byval wCod_Medico AS Integer,Byval wDcto AS Double,Byval wTotal AS Double)
		Me.cod_PagoMedico = wcod_PagoMedico
		Me.periodoid = wperiodoid
		Me.Cod_Medico = wCod_Medico
		Me.Dcto = wDcto
		Me.Total = wTotal
    End Sub

    Public Sub New(ByVal wcod_PagoMedico As Integer, ByVal wperiodoid As String, ByVal wCod_Medico As Integer, ByVal wDcto As Double, ByVal wTotal As Double, wtipo As String)
        Me.cod_PagoMedico = wcod_PagoMedico
        Me.periodoid = wperiodoid
        Me.Cod_Medico = wCod_Medico
        Me.Dcto = wDcto
        Me.Total = wTotal
        Me.Tipo = wtipo
    End Sub

#End Region

End Class