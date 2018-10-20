Public Class DetallePagoMedico

#Region "Datos"
	Private mcod_DetallePago AS Integer
	Private mFecha AS Date
	Private mPrecioOrig AS Double
	Private mPorcOrig AS Double
	Private mPrecioMod AS Double
	Private mPorcMod AS Double
	Private mcod_Examen AS Integer
	Private mCod_Paciente AS Integer
    Private mcod_PagoMedico As Integer


    Private moPaciente As Paciente
    Private moExamen As Examen

#End Region
#Region "Propiedades"
	Public Property cod_DetallePago() AS Integer
		Get
			return Me.mcod_DetallePago
		End Get
		Set(ByVal value As Integer)
			Me.mcod_DetallePago = value
		End Set
	End Property
	Public Property Fecha() AS Date
		Get
			return Me.mFecha
		End Get
		Set(ByVal value As Date)
			Me.mFecha = value
		End Set
	End Property
	Public Property PrecioOrig() AS Double
		Get
			return Me.mPrecioOrig
		End Get
		Set(ByVal value As Double)
			Me.mPrecioOrig = value
		End Set
	End Property
	Public Property PorcOrig() AS Double
		Get
			return Me.mPorcOrig
		End Get
		Set(ByVal value As Double)
			Me.mPorcOrig = value
		End Set
	End Property
	Public Property PrecioMod() AS Double
		Get
			return Me.mPrecioMod
		End Get
		Set(ByVal value As Double)
			Me.mPrecioMod = value
		End Set
	End Property
	Public Property PorcMod() AS Double
		Get
			return Me.mPorcMod
		End Get
		Set(ByVal value As Double)
			Me.mPorcMod = value
		End Set
	End Property
	Public Property cod_Examen() AS Integer
		Get
			return Me.mcod_Examen
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Examen = value
		End Set
	End Property
	Public Property Cod_Paciente() AS Integer
		Get
			return Me.mCod_Paciente
		End Get
		Set(ByVal value As Integer)
			Me.mCod_Paciente = value
		End Set
	End Property
	Public Property cod_PagoMedico() AS Integer
		Get
			return Me.mcod_PagoMedico
		End Get
		Set(ByVal value As Integer)
			Me.mcod_PagoMedico = value
		End Set
    End Property

    Public Property Examen() As Examen
        Get
            Return Me.moExamen
        End Get
        Set(ByVal value As Examen)
            Me.moExamen = value
        End Set
    End Property
    Public ReadOnly Property NombreExamen As String
        Get
            Return Examen.nombre.Trim
        End Get
    End Property
    Public Property Paciente() As Paciente
        Get
            Return Me.moPaciente
        End Get
        Set(ByVal value As Paciente)
            Me.moPaciente = value
        End Set
    End Property
    Public ReadOnly Property NombrePaciente As String
        Get
            Return Paciente.NombreCompleto
        End Get
    End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcod_DetallePago AS Integer,Byval wFecha AS Date,Byval wPrecioOrig AS Double,Byval wPorcOrig AS Double,Byval wPrecioMod AS Double,Byval wPorcMod AS Double,Byval wcod_Examen AS Integer,Byval wCod_Paciente AS Integer,Byval wcod_PagoMedico AS Integer)
		Me.cod_DetallePago = wcod_DetallePago
		Me.Fecha = wFecha
		Me.PrecioOrig = wPrecioOrig
		Me.PorcOrig = wPorcOrig
		Me.PrecioMod = wPrecioMod
		Me.PorcMod = wPorcMod
		Me.cod_Examen = wcod_Examen
		Me.Cod_Paciente = wCod_Paciente
		Me.cod_PagoMedico = wcod_PagoMedico
    End Sub

    Public Sub New(ByVal wcod_DetallePago As Integer, ByVal wFecha As Date, ByVal wPrecioOrig As Double, ByVal wPorcOrig As Double, ByVal wPrecioMod As Double, ByVal wPorcMod As Double, ByVal wcod_Examen As Integer, ByVal wCod_Paciente As Integer, ByVal wcod_PagoMedico As Integer, _
                   wNombreExamen As String, wpaterno As String, wmaterno As String, wnombre As String)
        Me.cod_DetallePago = wcod_DetallePago
        Me.Fecha = wFecha
        Me.PrecioOrig = wPrecioOrig
        Me.PorcOrig = wPorcOrig
        Me.PrecioMod = wPrecioMod
        Me.PorcMod = wPorcMod
        Me.cod_Examen = wcod_Examen
        Me.Cod_Paciente = wCod_Paciente
        Me.cod_PagoMedico = wcod_PagoMedico
        Me.Examen = New Examen(wcod_Examen, wNombreExamen)
        Paciente = New Paciente(wCod_Paciente, wnombre, wpaterno, wmaterno, "")

    End Sub

#End Region

End Class