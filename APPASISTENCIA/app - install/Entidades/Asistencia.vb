Public Class Asistencia

#Region "Datos"
	Private mCod_asistencia AS Integer
	Private mCod_turno AS Integer
	Private mUsuario AS String
	Private mtipo AS String
	Private mHora AS Date
	Private mHoraServidor AS Date
    Private mobservacion As String
    Private mestadoaviso As String

#End Region
#Region "Propiedades"
    Public Property EstadoAviso() As String
        Get
            Return Me.mestadoaviso
        End Get
        Set(ByVal value As String)
            Me.mestadoaviso = value
        End Set
    End Property

    Public Property Cod_asistencia() As Integer
        Get
            Return Me.mCod_asistencia
        End Get
        Set(ByVal value As Integer)
            Me.mCod_asistencia = value
        End Set
    End Property



    Public Property Cod_turno() As Integer
        Get
            Return Me.mCod_turno
        End Get
        Set(ByVal value As Integer)
            Me.mCod_turno = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return Me.mUsuario
        End Get
        Set(ByVal value As String)
            Me.mUsuario = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return Me.mtipo
        End Get
        Set(ByVal value As String)
            Me.mtipo = value
        End Set
    End Property
    Public Property Hora() As Date
        Get
            Return Me.mHora
        End Get
        Set(ByVal value As Date)
            Me.mHora = value
        End Set
    End Property
    Public Property HoraServidor() As Date
        Get
            Return Me.mHoraServidor
        End Get
        Set(ByVal value As Date)
            Me.mHoraServidor = value
        End Set
    End Property
    Public Property observacion() As String
        Get
            Return Me.mobservacion
        End Get
        Set(ByVal value As String)
            Me.mobservacion = value
        End Set
    End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wCod_asistencia As Integer)

        Me.Cod_asistencia = wCod_asistencia

    End Sub

    Public Sub New(ByVal wUsuario As String, ByVal wtipo As String, ByVal mobservacion As String, ByVal mestadoaviso As String)
        Me.Usuario = wUsuario
        Me.tipo = wtipo
        Me.observacion = mobservacion
        Me.EstadoAviso = mestadoaviso

    End Sub

    Public Sub New(ByVal wUsuario As String, ByVal wtipo As String, ByVal wHora As Date, ByVal wobservacion As String, ByVal wCod_turno As Integer)
        Me.Usuario = wUsuario
        Me.tipo = wtipo
        Me.Hora = wHora
        Me.Cod_turno = wCod_turno
        Me.observacion = wobservacion
    End Sub
	Public Sub New(Byval wCod_asistencia AS Integer,Byval wCod_turno AS Integer,Byval wUsuario AS String,Byval wtipo AS String,Byval wHora AS Date,Byval wHoraServidor AS Date,Byval wobservacion AS String)
		Me.Cod_asistencia = wCod_asistencia
		Me.Cod_turno = wCod_turno
		Me.Usuario = wUsuario
		Me.tipo = wtipo
		Me.Hora = wHora
		Me.HoraServidor = wHoraServidor
		Me.observacion = wobservacion
    End Sub

#End Region

End Class