Public Class Jalador
    Inherits Persona
#Region "Datos"
    Private mcomision As Double
	Private mCod_Jalador AS Integer
#End Region
#Region "Propiedades"


    Public Property comision() As Double
        Get
            Return Me.mcomision
        End Get
        Set(ByVal value As Double)
            Me.mcomision = value
        End Set
    End Property
    Public Property Cod_Jalador() As Integer
        Get
            Return Me.mCod_Jalador
        End Get
        Set(ByVal value As Integer)
            Me.mCod_Jalador = value
        End Set
    End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal _cod As Integer)
        MyBase.New(_cod)
        Cod_Jalador = _cod
    End Sub
    Public Sub New(ByVal wcomision As Double, ByVal wCod_Jalador As Integer)
        Me.comision = wcomision
        Me.Cod_Jalador = wCod_Jalador
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String, ByVal wcomision As Double)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.Cod_Jalador = wcod_Persona
        Me.comision = wcomision
    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, "")
        Me.Cod_Jalador = wcod_Persona

    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, _
                   ByVal wapMaterno As String, ByVal wcomision As Double, ByVal wcod_Jalador As Integer)

        MyBase.New(wcod_Persona, wtipodoc, wnombre, wapPaterno, wdni, wsexo, wedad, wfechaNac, wdireccion, wtelefono, wmail, wcelular, westado, wcod_Distrito, wcod_Provincia, wcod_Departamento, wapMaterno)
        Me.comision = wcomision
        Me.Cod_Jalador = wcod_Jalador
    End Sub
#End Region

End Class