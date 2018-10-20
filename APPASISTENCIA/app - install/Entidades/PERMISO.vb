Public Class PERMISO

#Region "Datos"
    Protected mNumero As Integer
    Private mCodigoSist As New SISTEMA
    Private mNumeroOpc As New OPCION
    Private mCodigoGrupoUsu As New GRUPO_USUARIO
    Private mCodigoUsu As New USUARIO
    Private mAcceso As Boolean

#End Region

#Region "Propiedades"
    Public Property Numero() As Integer
        Get
            Return mNumero
        End Get
        Set(ByVal value As Integer)
            mNumero = value
        End Set
    End Property
    Public Property CodigoSist() As Integer
        Get
            Return mCodigoSist.Codigo
        End Get
        Set(ByVal value As Integer)
            mCodigoSist.Codigo = value
        End Set
    End Property
    Public Property NumeroOpc() As Integer
        Get
            Return mNumeroOpc.Numero
        End Get
        Set(ByVal value As Integer)
            mNumeroOpc.Numero = value
        End Set
    End Property
    Public Property CodigoGrupoUsu() As Integer
        Get
            Return mCodigoGrupoUsu.Codigo
        End Get
        Set(ByVal value As Integer)
            mCodigoGrupoUsu.Codigo = value
        End Set
    End Property
    Public Property CodigoUsu() As Integer
        Get
            Return mCodigoUsu.Codigo
        End Get
        Set(ByVal value As Integer)
            mCodigoUsu.Codigo = value
        End Set
    End Property
    Public Property Acceso() As Boolean
        Get
            Return mAcceso
        End Get
        Set(ByVal value As Boolean)
            mAcceso = value
        End Set
    End Property

#End Region
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wNumero As Integer, ByVal wCodigoSist As SISTEMA, ByVal wNumeroOpc As OPCION, ByVal wCodigoGrupoUsu As GRUPO_USUARIO, ByVal wCodigoUsu As USUARIO, ByVal wAcceso As Boolean)
        mNumero = wNumero
        mCodigoSist = wCodigoSist
        mNumeroOpc = wNumeroOpc
        mCodigoGrupoUsu = wCodigoGrupoUsu
        mCodigoUsu = wCodigoUsu
        mAcceso = wAcceso
    End Sub

    Public Sub New(ByVal wNumero As Integer, ByVal wCodigoSist As SISTEMA, ByVal wNumeroOpc As OPCION, ByVal wCodigoGrupoUsu As GRUPO_USUARIO, ByVal wAcceso As Boolean)
        mNumero = wNumero
        mCodigoSist = wCodigoSist
        mNumeroOpc = wNumeroOpc
        mCodigoGrupoUsu = wCodigoGrupoUsu
        mAcceso = wAcceso
    End Sub

    Public Sub New(ByVal wCodigoSist As SISTEMA, ByVal wCodigoUsu As USUARIO)
        mCodigoSist = wCodigoSist
        mCodigoUsu = wCodigoUsu
    End Sub



#End Region

End Class