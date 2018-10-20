Public Class CLIENTE
    Inherits Persona
#Region "Datos"
	Private mRuc AS String
	Private mCod_Cliente AS Integer
#End Region
#Region "Propiedades"
	Public Property Ruc() AS String
		Get
			return Me.mRuc
		End Get
		Set(ByVal value As String)
			Me.mRuc = value
		End Set
	End Property
	Public Property Cod_Cliente() AS Integer
		Get
			return Me.mCod_Cliente
		End Get
		Set(ByVal value As Integer)
			Me.mCod_Cliente = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal _cod As Integer)
        MyBase.New(_cod)
        Cod_Cliente = _cod
    End Sub
    Public Sub New(ByVal wRuc As String, ByVal wCod_Cliente As Integer)
        Me.Ruc = wRuc
        Me.Cod_Cliente = wCod_Cliente
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.Cod_Cliente = wcod_Persona
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, _
                   ByVal wapMaterno As String, ByVal wruc As String, ByVal wcod_Cliente As Integer)

        MyBase.New(wcod_Persona, wtipodoc, wnombre, wapPaterno, wdni, wsexo, wedad, wfechaNac, wdireccion, wtelefono, wmail, wcelular, westado, wcod_Distrito, wcod_Provincia, wcod_Departamento, wapMaterno)
        Me.Ruc = wruc
        Me.Cod_Cliente = wcod_Cliente
    End Sub
#End Region

End Class