Public Class Paciente
    Inherits Persona
#Region "Datos"
    Private mCod_Paciente As Integer
#End Region
#Region "Propiedades"
	
	Public Property Cod_Paciente() AS Integer
		Get
			return Me.mCod_Paciente
		End Get
		Set(ByVal value As Integer)
			Me.mCod_Paciente = value
		End Set
	End Property
#End Region

#Region "Constructores"
	Public Sub New()
    End Sub
    
    Public Sub New(ByVal wCod_Paciente As Integer)
        MyBase.New(wCod_Paciente)
        Me.Cod_Paciente = wCod_Paciente

    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.Cod_Paciente = wcod_Persona
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String, ByVal wedad As String)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.edad = wedad
        Me.Cod_Paciente = wcod_Persona
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, ByVal wapMaterno As String)
        MyBase.New(wcod_Persona, wtipodoc, wnombre, wapPaterno, wdni, wsexo, wedad, wfechaNac, wdireccion, wtelefono, wmail, wcelular, westado, wcod_Distrito, wcod_Provincia, wcod_Departamento, wapMaterno)
        Me.Cod_Paciente = wcod_Persona
    End Sub
#End Region
End Class