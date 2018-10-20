Public Class TRABAJADOR
#Region "Datos"
    Protected mCodigo As Integer
    Private mdni As String
    Private mapellidopaterno As String
    Private mapellidomaterno As String
    Private mnombres As String
    Private mtelefono As String
    Private mtiene As String

    Private mTemplate As String
    Private mTemplate10 As String
    Private mHUELLA_FOTO As Byte()
    Private mMAR_HUELLA As Boolean
    Private mMAR_DNI As Boolean

#End Region

#Region "Propiedades"

    Public Property Codigo() As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property


    Public Property dni() As String
        Get
            Return mdni
        End Get
        Set(ByVal value As String)
            mdni = value

        End Set
    End Property

    Public Property apellidopaterno() As String
        Get
            Return mapellidopaterno
        End Get
        Set(ByVal value As String)
            mapellidopaterno = value
        End Set
    End Property
    Public Property apellidomaterno() As String
        Get
            Return mapellidomaterno
        End Get
        Set(ByVal value As String)
            mapellidomaterno = value
        End Set
    End Property
    Public Property nombres() As String
        Get
            Return mnombres
        End Get
        Set(ByVal value As String)
            mnombres = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return mtelefono
        End Get
        Set(ByVal value As String)
            mtelefono = value
        End Set
    End Property

    Public Property tiene() As String
        Get
            Return mtiene
        End Get
        Set(ByVal value As String)
            mtiene = value
        End Set
    End Property


    Public Property Template() As String
        Get
            Return Me.mTemplate
        End Get
        Set(ByVal value As String)
            Me.mTemplate = value
        End Set
    End Property
    Public Property Template10() As String
        Get
            Return Me.mTemplate10
        End Get
        Set(ByVal value As String)
            Me.mTemplate10 = value
        End Set
    End Property
    Public Property HUELLA_FOTO() As Byte()
        Get
            Return Me.mHUELLA_FOTO
        End Get
        Set(ByVal value As Byte())
            Me.mHUELLA_FOTO = value
        End Set
    End Property
    Public Property MAR_HUELLA() As Boolean
        Get
            Return Me.mMAR_HUELLA
        End Get
        Set(ByVal value As Boolean)
            Me.mMAR_HUELLA = value
        End Set
    End Property
    Public Property MAR_DNI() As Boolean
        Get
            Return Me.mMAR_DNI
        End Get
        Set(ByVal value As Boolean)
            Me.mMAR_DNI = value
        End Set
    End Property


#End Region

#Region "Contructores"
    Public Sub New()
    End Sub
    Public Sub New(wdni As String, wapellidopaterno As String, wapellidomaterno As String, wnombres As String, wtelefono As String, ByVal wtiene As Char)

        Me.dni = wdni
        Me.apellidopaterno = wapellidopaterno
        Me.apellidomaterno = wapellidomaterno

        Me.nombres = wnombres
        Me.telefono = wtelefono
        Me.tiene = wtiene

    End Sub
    Public Sub New(ByVal wdni As Integer, ByVal wTemplate As String, ByVal wTemplate10 As String)
        Me.dni = wdni
        Me.Template = wTemplate
        Me.Template10 = wTemplate10

    End Sub
    Public Sub New(ByVal wdni As Integer, ByVal wtiene As String, ByVal wTemplate As String, ByVal wTemplate10 As String)
        Me.dni = wdni
        Me.tiene = wtiene
        Me.Template = wTemplate
        Me.Template10 = wTemplate10

    End Sub
    Public Sub New(ByVal wdni As Integer, ByVal wtiene As String, ByVal wTemplate As String, ByVal wTemplate10 As String, ByVal wHUELLA_FOTO As Byte())
        Me.dni = wdni
        Me.tiene = wtiene
        Me.Template = wTemplate
        Me.Template10 = wTemplate10
        Me.HUELLA_FOTO = wHUELLA_FOTO
    End Sub

    Public Sub New(wdni As String, wapellidopaterno As String, wapellidomaterno As String, wnombres As String, wtelefono As String, ByVal wtiene As String, ByVal wTemplate As String, ByVal wTemplate10 As String, ByVal wHUELLA_FOTO As Byte(), ByVal wMAR_HUELLA As Boolean, ByVal wMAR_DNI As Boolean)
        Me.dni = wdni
        Me.apellidopaterno = wapellidopaterno
        Me.apellidomaterno = wapellidomaterno
        Me.nombres = wnombres
        Me.telefono = wtelefono
        Me.tiene = wtiene

        Me.Template = wTemplate
        Me.Template10 = wTemplate10
        Me.HUELLA_FOTO = wHUELLA_FOTO
        Me.MAR_HUELLA = wMAR_HUELLA
        Me.MAR_DNI = wMAR_DNI
    End Sub


    Public Sub New(wid As String, ByVal wdni As Integer, wapellidopaterno As String, wapellidomaterno As String, wnombres As String, ByVal wTemplate As String, ByVal wTemplate10 As String, ByVal whuella_foto As Byte(), ByVal wMAR_DNI As Boolean, ByVal wMAR_HUELLA As Boolean)
        Me.dni = wid
        Me.dni = wdni
        Me.apellidopaterno = wapellidopaterno
        Me.apellidomaterno = wapellidomaterno
        Me.nombres = wnombres

        Me.Template = wTemplate
        Me.Template10 = wTemplate10
        Me.HUELLA_FOTO = whuella_foto
        Me.MAR_HUELLA = wMAR_HUELLA
        Me.MAR_DNI = wMAR_DNI
    End Sub



    Public Sub New(ByVal wdni As Integer)
        Me.dni = wdni
    End Sub
#End Region

End Class
