Public Class PERSONAL
    Inherits Persona
#Region "Datos"
	Private mcodigoPersonal AS Integer
	Private mCARGO AS String
	Private mjornada AS String
	Private mPlanilla AS String
	Private mRuc AS String
    Private mBruto As Double
    Private mAsigFam As Double
    Private mComision As Double
    Private mAFP As String
    Private mTipoComisionAFP As String
    Private mFechaIngreso As Date
    Private mFechaSalida As Date
    Private mEstado As String
#End Region
#Region "Propiedades"
    Public Property codigoPersonal() As Integer
        Get
            Return Me.mcodigoPersonal
        End Get
        Set(ByVal value As Integer)
            Me.mcodigoPersonal = value
        End Set
    End Property
    Public Property CARGO() As String
        Get
            Return Me.mCARGO
        End Get
        Set(ByVal value As String)
            Me.mCARGO = value
        End Set
    End Property
    Public Property jornada() As String
        Get
            Return Me.mjornada
        End Get
        Set(ByVal value As String)
            Me.mjornada = value
        End Set
    End Property
    Public Property Planilla() As String
        Get
            Return Me.mPlanilla
        End Get
        Set(ByVal value As String)
            Me.mPlanilla = value
        End Set
    End Property
    Public Property Ruc() As String
        Get
            Return Me.mRuc
        End Get
        Set(ByVal value As String)
            Me.mRuc = value
        End Set
    End Property
    Public Property Bruto() As Double
        Get
            Return Me.mBruto
        End Get
        Set(ByVal value As Double)
            Me.mBruto = value
        End Set
    End Property
    Public Property AsigFam() As Double
        Get
            Return Me.mAsigFam
        End Get
        Set(ByVal value As Double)
            Me.mAsigFam = value
        End Set
    End Property
    Public Property Comision() As Double
        Get
            Return Me.mComision
        End Get
        Set(ByVal value As Double)
            Me.mComision = value
        End Set
    End Property
    Public Property AFP() As String
        Get
            Return Me.mAFP
        End Get
        Set(ByVal value As String)
            Me.mAFP = value
        End Set
    End Property
    Public Property TipoComisionAFP() As String
        Get
            Return Me.mTipoComisionAFP
        End Get
        Set(ByVal value As String)
            Me.mTipoComisionAFP = value
        End Set
    End Property
    Public Property FechaIngreso() As Date
        Get
            Return Me.mFechaIngreso
        End Get
        Set(ByVal value As Date)
            Me.mFechaIngreso = value
        End Set
    End Property
    Public Property FechaSalida() As Date
        Get
            Return Me.mFechaSalida
        End Get
        Set(ByVal value As Date)
            Me.mFechaSalida = value
        End Set
    End Property
    Public Property EstadoPersonal() As String
        Get
            Return Me.mEstado
        End Get
        Set(ByVal value As String)
            Me.mEstado = value
        End Set
    End Property


#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal _cod As Integer)
        MyBase.New(_cod)
        codigoPersonal = _cod
    End Sub

    Public Sub New(ByVal wcodigoPersonal As Integer, ByVal wCARGO As String, ByVal wjornada As String, ByVal wPlanilla As String, ByVal wRuc As String, ByVal wBruto As Double, ByVal wAsigFam As Double, ByVal wComision As Double, ByVal wAFP As String, ByVal wTipoComisionAFP As String, ByVal wFechaIngreso As Date, ByVal wFechaSalida As Date, ByVal wEstado As String)
        Me.codigoPersonal = wcodigoPersonal
        Me.CARGO = wCARGO
        Me.jornada = wjornada
        Me.Planilla = wPlanilla
        Me.Ruc = wRuc
        Me.Bruto = wBruto
        Me.AsigFam = wAsigFam
        Me.Comision = wComision
        Me.AFP = wAFP
        Me.TipoComisionAFP = wTipoComisionAFP
        Me.FechaIngreso = wFechaIngreso
        Me.FechaSalida = wFechaSalida
        Me.EstadoPersonal = wEstado
    End Sub

    Public Sub New(ByVal wcod_Persona As Integer, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wapMaterno As String, ByVal wdni As String, ByVal wcargo As String)


        MyBase.New(wcod_Persona, wnombre, wapPaterno, wapMaterno, wdni)
        Me.codigoPersonal = wcod_Persona
        Me.CARGO = wcargo

    End Sub
    Public Sub New(ByVal wcod_Persona As Integer, ByVal wtipodoc As String, ByVal wnombre As String, ByVal wapPaterno As String, ByVal wdni As String, ByVal wsexo As Boolean, ByVal wedad As String, ByVal wfechaNac As Date, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wmail As String, ByVal wcelular As String, ByVal westado As String, ByVal wcod_Distrito As String, ByVal wcod_Provincia As String, ByVal wcod_Departamento As String, _
                  ByVal wapMaterno As String, ByVal wcodigoPersonal As Integer, ByVal wCARGO As String, ByVal wjornada As String, ByVal wPlanilla As String, ByVal wRuc As String, ByVal wBruto As Double, ByVal wAsigFam As Double, ByVal wComision As Double, ByVal wAFP As String, ByVal wTipoComisionAFP As String, ByVal wFechaIngreso As Date, ByVal wFechaSalida As Date, ByVal wEstadoPersonal As String)

        MyBase.New(wcod_Persona, wtipodoc, wnombre, wapPaterno, wdni, wsexo, wedad, wfechaNac, wdireccion, wtelefono, wmail, wcelular, westado, wcod_Distrito, wcod_Provincia, wcod_Departamento, wapMaterno)
        Me.codigoPersonal = wcod_Persona
        Me.CARGO = wCARGO
        Me.jornada = wjornada
        Me.Planilla = wPlanilla
        Me.Ruc = wRuc
        Me.Bruto = wBruto
        Me.AsigFam = wAsigFam
        Me.Comision = wComision
        Me.AFP = wAFP
        Me.TipoComisionAFP = wTipoComisionAFP
        Me.FechaIngreso = wFechaIngreso
        Me.FechaSalida = wFechaSalida
        Me.EstadoPersonal = wEstadoPersonal
    End Sub
#End Region

End Class