Public Class Medico
    Inherits Persona
#Region "Datos"
    Private mespecialidad As String
    Private mrm As String
    Private mre As String
    Private mcentro_Trabajo As String
    Private mporcentaje_Examen As Double
    Private mCod_Medico As Integer
    Private mporcentaje_Proc As Double
    Private mporcentaje_Tomo As Double
    Private mTelefReferencia1 As String
    Private mTelefReferencia2 As String

    Private mtrabcerin As Boolean

#End Region
#Region "Propiedades"
    Public Property especialidad() As String
        Get
            Return Me.mespecialidad
        End Get
        Set(ByVal value As String)
            Me.mespecialidad = value
        End Set
    End Property
    Public Property rm() As String
        Get
            Return Me.mrm
        End Get
        Set(ByVal value As String)
            Me.mrm = value
        End Set
    End Property
    Public Property re() As String
        Get
            Return Me.mre
        End Get
        Set(ByVal value As String)
            Me.mre = value
        End Set
    End Property
    Public Property centro_Trabajo() As String
        Get
            Return Me.mcentro_Trabajo
        End Get
        Set(ByVal value As String)
            Me.mcentro_Trabajo = value
        End Set
    End Property
    Public Property porcentaje_Examen() As Double
        Get
            Return Me.mporcentaje_Examen
        End Get
        Set(ByVal value As Double)
            Me.mporcentaje_Examen = value
        End Set
    End Property

    Public Property Porcentaje_Tomo() As Double
        Get
            Return Me.mporcentaje_Tomo
        End Get
        Set(ByVal value As Double)
            Me.mporcentaje_Tomo = value
        End Set
    End Property


    Public Property Cod_Medico() As Integer
        Get
            Return Me.mCod_Medico
        End Get
        Set(ByVal value As Integer)
            Me.mCod_Medico = value
        End Set
    End Property
    Public Property porcentaje_Proc() As Double
        Get
            Return Me.mporcentaje_Proc
        End Get
        Set(ByVal value As Double)
            Me.mporcentaje_Proc = value
        End Set
    End Property
    Public Property TelefReferencia1() As String
        Get
            Return Me.mTelefReferencia1
        End Get
        Set(ByVal value As String)
            Me.mTelefReferencia1 = value
        End Set
    End Property

    Public Property TelefReferencia2() As String
        Get
            Return Me.mTelefReferencia2
        End Get
        Set(ByVal value As String)
            Me.mTelefReferencia2 = value
        End Set
    End Property

    Public Property TrabajaCerin() As Boolean
        Get
            Return Me.mtrabcerin
        End Get
        Set(ByVal value As Boolean)
            Me.mtrabcerin = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal _cod As Integer)
        MyBase.New(_cod)
        Cod_Medico = _cod
    End Sub

    Public Sub New(ByVal wespecialidad As String, ByVal wrm As String, ByVal wre As String, ByVal wcentro_Trabajo As String, ByVal wporcentaje_Examen As Double, ByVal wCod_Medico As Integer, ByVal wporcentaje_Proc As Double, ByVal wTelef1 As String, ByVal wtelef2 As String)

        Me.especialidad = wespecialidad
        Me.rm = wrm
        Me.re = wre
        Me.centro_Trabajo = wcentro_Trabajo
        Me.porcentaje_Examen = wporcentaje_Examen
        Me.Cod_Medico = wCod_Medico
        Me.porcentaje_Proc = wporcentaje_Proc
        Me.TelefReferencia1 = wTelef1
        Me.TelefReferencia2 = wtelef2
    End Sub

    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String, ByVal wporcentajeExam As Double, ByVal wporcentajeProc As Double)

        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.Cod_Medico = wcod_Persona
        Me.porcentaje_Examen = wporcentajeExam
        Me.porcentaje_Proc = wporcentajeProc
    End Sub

    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, _
                  ByVal wapMaterno As String, ByVal wespecialidad As String, ByVal wrm As String, ByVal wre As String, ByVal wcentro_Trabajo As String, ByVal wporcentaje_Examen As Double, ByVal wCod_Medico As Integer, ByVal wporcentaje_Proc As Double, ByVal wTelef1 As String, ByVal wtelef2 As String, ByVal wtrabcerin As Boolean, ByVal wporc_tomo As Double)

        MyBase.New(wcod_Persona, wtipodoc, wnombre, wapPaterno, wdni, wsexo, wedad, wfechaNac, wdireccion, wtelefono, wmail, wcelular, westado, wcod_Distrito, wcod_Provincia, wcod_Departamento, wapMaterno)
        Me.Cod_Medico = wcod_Persona
        Me.especialidad = wespecialidad
        Me.rm = wrm
        Me.re = wre
        Me.centro_Trabajo = wcentro_Trabajo
        Me.porcentaje_Examen = wporcentaje_Examen
        Me.Cod_Medico = wCod_Medico
        Me.porcentaje_Proc = wporcentaje_Proc
        Me.TelefReferencia1 = wTelef1
        Me.TelefReferencia2 = wtelef2
        Me.TrabajaCerin = wtrabcerin

        Me.Porcentaje_Tomo = wporc_tomo
    End Sub

#End Region

End Class