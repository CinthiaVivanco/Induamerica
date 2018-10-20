Public Class Persona

#Region "Datos"
	Private mcod_Persona AS Integer
	Private mnombre AS String
	Private mapPaterno AS String
    Private mdni As String
    Private medad As String
    Private mfechaNac As Date
	Private mdireccion AS String
	Private mtelefono AS String
	Private mmail AS String
	Private mcelular AS String
	Private mestado AS String
	Private mcod_Distrito AS String
	Private mcod_Provincia AS String
	Private mcod_Departamento AS String
	Private mapMaterno AS String
    Private msexo As Boolean
    Private mtipodoc As String

#End Region

#Region "Propiedades"
    Private _wcod_Persona As Integer
    Private _wnombre As String
    Private _wapPaterno As String
    Private _wapMaterno As String

    'Protected Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String)
    '    ' TODO: Complete member initialization 
    '    _wcod_Persona = wcod_Persona
    '    _wnombre = wnombre
    '    _wapPaterno = wapPaterno
    '    _wapMaterno = wapMaterno
    'End Sub

    Public Property cod_Persona() As Integer
        Get
            Return Me.mcod_Persona
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Persona = value
        End Set
    End Property
	Public Property nombre() AS String
		Get
			return Me.mnombre
		End Get
		Set(ByVal value As String)
			Me.mnombre = value
		End Set
	End Property
	Public Property apPaterno() AS String
		Get
			return Me.mapPaterno
		End Get
		Set(ByVal value As String)
			Me.mapPaterno = value
		End Set
    End Property
    Public Property TipoDoc() As String
        Get
            Return Me.mtipodoc
        End Get
        Set(ByVal value As String)
            Me.mtipodoc = value
        End Set
    End Property

	Public Property dni() AS String
		Get
			return Me.mdni
		End Get
		Set(ByVal value As String)
			Me.mdni = value
		End Set
	End Property
    Public Property edad() As String
        Get
            Return Me.medad
        End Get
        Set(ByVal value As String)
            Me.medad = value
        End Set
    End Property
    Public Property fechaNac() As Date
        Get
            Return Me.mfechaNac
        End Get
        Set(ByVal value As Date)
            Me.mfechaNac = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return Me.mdireccion
        End Get
        Set(ByVal value As String)
            Me.mdireccion = value
        End Set
    End Property
	Public Property telefono() AS String
		Get
			return Me.mtelefono
		End Get
		Set(ByVal value As String)
			Me.mtelefono = value
		End Set
	End Property
	Public Property mail() AS String
		Get
			return Me.mmail
		End Get
		Set(ByVal value As String)
			Me.mmail = value
		End Set
	End Property
	Public Property celular() AS String
		Get
			return Me.mcelular
		End Get
		Set(ByVal value As String)
			Me.mcelular = value
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
	Public Property cod_Distrito() AS String
		Get
			return Me.mcod_Distrito
		End Get
		Set(ByVal value As String)
			Me.mcod_Distrito = value
		End Set
	End Property
	Public Property cod_Provincia() AS String
		Get
			return Me.mcod_Provincia
		End Get
		Set(ByVal value As String)
			Me.mcod_Provincia = value
		End Set
	End Property
	Public Property cod_Departamento() AS String
		Get
			return Me.mcod_Departamento
		End Get
		Set(ByVal value As String)
			Me.mcod_Departamento = value
		End Set
	End Property
	Public Property apMaterno() AS String
		Get
			return Me.mapMaterno
		End Get
		Set(ByVal value As String)
			Me.mapMaterno = value
		End Set
	End Property
	Public Property sexo() AS Boolean
		Get
			return Me.msexo
		End Get
		Set(ByVal value As Boolean)
			Me.msexo = value
		End Set
    End Property


    Public ReadOnly Property NombreCompleto
        Get
            Return apPaterno & " " & apMaterno & " " & nombre
        End Get
    End Property

#End Region

#Region "Constructores"
	Public Sub New()
    End Sub

    Public Sub New(ByVal wCodigo As Integer)
        Me.mcod_Persona = wCodigo
    End Sub

    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, ByVal wapMaterno As String)
        Me.cod_Persona = wcod_Persona
        Me.nombre = wnombre
        Me.apPaterno = wapPaterno
        Me.dni = wdni
        Me.TipoDoc = wtipodoc
        Me.sexo = wsexo
        Me.edad = wedad
        Me.fechaNac = wfechaNac
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.mail = wmail
        Me.celular = wcelular
        Me.estado = westado
        Me.cod_Distrito = wcod_Distrito
        Me.cod_Provincia = wcod_Provincia
        Me.cod_Departamento = wcod_Departamento
        Me.apMaterno = wapMaterno
    End Sub

    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String)

        Me.cod_Persona = wcod_Persona
        Me.nombre = wnombre
        Me.apPaterno = wapPaterno
        Me.apMaterno = wapMaterno
        Me.dni = wdni

    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String)

        Me.cod_Persona = wcod_Persona
        Me.nombre = wnombre
        Me.apPaterno = wapPaterno
        Me.apMaterno = wapMaterno


    End Sub


    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String, ByVal westado As String)

        Me.cod_Persona = wcod_Persona
        Me.nombre = wnombre
        Me.apPaterno = wapPaterno
        Me.apMaterno = wapMaterno
        Me.dni = wdni
        Me.estado = westado

    End Sub
#End Region

End Class