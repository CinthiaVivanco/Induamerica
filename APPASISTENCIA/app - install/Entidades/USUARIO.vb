Public Class USUARIO



#Region "Datos"
    Protected mCodigo As Integer
    Private mOPersona As Persona
    Private mNombre As String
    Private mContrasenia As String
    Private mTipo As Char
    Private mVigencia As Boolean

    Private mTemplate As String
    Private mTemplate10 As String
    Private mHUELLA_FOTO As Byte()
    Private mMAR_HUELLA As Boolean
    Private mMAR_DNI As Boolean

    Private mGrupo As GRUPO_USUARIO

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
    Public Property Persona() As Persona
        Get
            Return mOPersona
        End Get
        Set(ByVal value As Persona)
            mOPersona = value

        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value

        End Set
    End Property
    Public Property Contrasenia() As String
        Get
            Return mContrasenia
        End Get
        Set(ByVal value As String)
            mContrasenia = value
        End Set
    End Property
    Public Property Tipo() As Char
        Get
            Return mTipo
        End Get
        Set(ByVal value As Char)
            mTipo = value
        End Set
    End Property
    Public Property Vigencia() As Boolean
        Get
            Return mVigencia
        End Get
        Set(ByVal value As Boolean)
            mVigencia = value
        End Set
    End Property
    Public ReadOnly Property nombrecompleto() As String
        Get
            If mVigencia = False Then
                Return mNombre & " - " & " - No vigente"
            Else
                Return mNombre & " - " & " - Vigente"

            End If
        End Get
    End Property
    Public ReadOnly Property nombrevigencia() As String
        Get
            If mVigencia = False Then
                Return "No vigente"
            Else
                Return "Vigente"

            End If
        End Get
    End Property
    Public ReadOnly Property nombretipo() As String
        Get
            If mTipo = "A" Then
                Return "Administrador"
            Else
                Return "Limitado"
            End If
        End Get
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

    Public ReadOnly Property nombrepersona() As String
        Get
            Return mOPersona.NombreCompleto
        End Get
    End Property
#End Region

#Region "Contructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcodigo As Integer, ByVal wPersona As Persona, ByVal wnombre As String, ByVal wcontrasenia As String, ByVal wtipo As String, ByVal wvigencia As Boolean, ByVal wTemplate As String, ByVal wTemplate10 As String, ByVal wHUELLA_FOTO As Byte(), ByVal wMAR_HUELLA As Boolean, ByVal wMAR_DNI As Boolean)
        Me.Codigo = wcodigo
        Me.mOPersona = wPersona
        Me.Nombre = wnombre
        Me.Contrasenia = wcontrasenia
        Me.Tipo = wtipo
        Me.Vigencia = wvigencia
        Me.Template = wTemplate
        Me.Template10 = wTemplate10
        Me.HUELLA_FOTO = wHUELLA_FOTO
        Me.MAR_HUELLA = wMAR_HUELLA
        Me.MAR_DNI = wMAR_DNI
    End Sub
    Public Sub New(ByVal wcodigo As Integer, ByVal wTemplate As String, ByVal wTemplate10 As String)
        Me.Codigo = wcodigo
        Me.Template = wTemplate
        Me.Template10 = wTemplate10
    End Sub
    Public Sub New(ByVal wCodigo As Integer, ByVal wPersona As Persona, ByVal wNombre As String, ByVal wContrasenia As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
        Me.mCodigo = wCodigo
        Me.mOPersona = wPersona
        Me.mNombre = wNombre
        Me.mContrasenia = wContrasenia
        Me.mTipo = wTipo
        Me.mVigencia = wVigenca
    End Sub
    Public Sub New(ByVal wCodigo As Integer, ByVal wPersona As Persona, ByVal wNombre As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
        Me.mCodigo = wCodigo
        Me.mOPersona = wPersona
        Me.mNombre = wNombre
        Me.mTipo = wTipo
        Me.mVigencia = wVigenca
    End Sub
    Public Sub New(ByVal wPersona As Persona, ByVal wNombre As String, ByVal wContrasenia As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
        Me.mOPersona = wPersona
        Me.mNombre = wNombre
        Me.mContrasenia = wContrasenia
        Me.mTipo = wTipo
        Me.mVigencia = wVigenca
    End Sub
    Public Sub New(ByVal wPersona As Persona, ByVal wCodigo As Integer)
        Me.mCodigo = wCodigo
        Me.mOPersona = wPersona
    End Sub
    Public Sub New(ByVal wCodigo As Integer)
        Me.mCodigo = wCodigo
    End Sub
    Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String)
        Me.mCodigo = wCodigo
        Me.mNombre = wNombre
    End Sub
    Public Sub New(ByVal wNombre As String, ByVal wContrasenia As String)
        Me.Nombre = wNombre
        Me.Contrasenia = wContrasenia
    End Sub
#End Region

End Class