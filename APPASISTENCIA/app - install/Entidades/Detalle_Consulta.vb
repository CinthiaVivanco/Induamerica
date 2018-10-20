Public Class Detalle_Consulta

#Region "Datos"
	Private mcod_Detalle_Consulta AS Integer
	Private mcod_Consulta AS Integer
	Private mcantidad AS Integer
    Private mmonto_Total As Double
    Private mcod_Examen As Integer
    Private mcod_PlanAtencion As Integer
    Private minforme As String
    Private mEstado As String
    Private mcodMedico As Integer
    Private mInformado As String
    Private mcodCentroConvenio As Integer
    Private mprocRealizado As String


    Private moExamen As Examen
    Private moPlanAtencion As Plan_Atencion
    

#End Region

#Region "Propiedades"
    Public Property cod_Detalle_Consulta() As Integer
        Get
            Return Me.mcod_Detalle_Consulta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Detalle_Consulta = value
        End Set
    End Property
    Public Property cod_Consulta() As Integer
        Get
            Return Me.mcod_Consulta
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Consulta = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return Me.mcantidad
        End Get
        Set(ByVal value As Integer)
            Me.mcantidad = value
        End Set
    End Property
    Public Property monto_Total() As Double
        Get
            Return Me.mmonto_Total
        End Get
        Set(ByVal value As Double)
            Me.mmonto_Total = value
        End Set
    End Property
    Public Property cod_Examen() As Integer
        Get
            Return Me.mcod_Examen
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Examen = value
        End Set
    End Property
    Public Property cod_PlanAtencion() As Integer
        Get
            Return Me.mcod_PlanAtencion
        End Get
        Set(ByVal value As Integer)
            Me.mcod_PlanAtencion = value
        End Set
    End Property

    Public Property codCentroConvenio() As Integer
        Get
            Return Me.mcodCentroConvenio
        End Get
        Set(ByVal value As Integer)
            Me.mcodCentroConvenio = value
        End Set
    End Property


    Public Property informe() As String
        Get
            Return Me.minforme
        End Get
        Set(ByVal value As String)
            Me.minforme = value
        End Set
    End Property
    Public Property informado() As String
        Get
            Return Me.mInformado
        End Get
        Set(ByVal value As String)
            Me.mInformado = value
        End Set
    End Property
    Public Property ProcRealizado() As String
        Get
            Return Me.mprocRealizado
        End Get
        Set(ByVal value As String)
            Me.mprocRealizado = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return Me.mEstado
        End Get
        Set(ByVal value As String)
            Me.mEstado = value
        End Set
    End Property

    Public Property Examen() As Examen
        Get
            Return Me.moExamen
        End Get
        Set(ByVal value As Examen)
            Me.moExamen = value
        End Set
    End Property
    Public ReadOnly Property NombreExamen As String
        Get
            Return Examen.nombre.Trim
        End Get
    End Property
    Public ReadOnly Property PrecioExamen As Double
        Get
            Return Examen.precio
        End Get
    End Property
    Public Property cod_Medico() As Integer
        Get
            Return Me.mcodMedico
        End Get
        Set(ByVal value As Integer)
            Me.mcodMedico = value
        End Set
    End Property
    Public Property PlanAtencion() As Plan_Atencion
        Get
            Return Me.moPlanAtencion
        End Get
        Set(ByVal value As Plan_Atencion)
            Me.moPlanAtencion = value
        End Set
    End Property
   
    Public ReadOnly Property NombrePlanAtencion As String
        Get
            Return PlanAtencion.descripcion

        End Get
    End Property

#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta

    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcantidad As Integer, ByVal wmonto_Total As Double, ByVal wcod_Examen As Integer, ByVal wProcRealizado As String, ByVal wcod_PlanAtencion As Integer, ByVal wcodCentroConvenio As Integer, ByVal westado As String)
        '0, CodVenta, cantidad, MontoTotal, CodExamen, ProcRealizado, codPlan, codCentroConvenio, "P"
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.cantidad = wcantidad
        Me.monto_Total = wmonto_Total
        Me.cod_Examen = wcod_Examen
        Me.ProcRealizado = wProcRealizado
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.codCentroConvenio = wcodCentroConvenio
        Me.Estado = westado
    End Sub

    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcantidad As Integer, ByVal wmonto_Total As Double, ByVal wcod_Examen As Integer, ByVal wcod_PlanAtencion As Integer, ByVal wcodCentroConvenio As Integer, ByVal westado As String)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.cantidad = wcantidad
        Me.monto_Total = wmonto_Total
        Me.cod_Examen = wcod_Examen
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.Estado = westado
        Me.codCentroConvenio = wcodCentroConvenio

    End Sub


    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcantidad As Integer, ByVal wmonto_Total As Double, ByVal wcod_Examen As Integer, ByVal wNombreExamen As String, ByVal wprecioExa As Double, ByVal wcod_PlanAtencion As Integer, ByVal wNombrePlan As String, ByVal wcodCentroConvenio As Integer)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.cantidad = wcantidad
        Me.monto_Total = wmonto_Total
        Me.Examen = New Examen(wcod_Examen, wNombreExamen, wprecioExa)
        Me.PlanAtencion = New Plan_Atencion(wcod_PlanAtencion, wNombrePlan)

        Me.cod_Examen = wcod_Examen
        Me.cod_PlanAtencion = wcod_PlanAtencion
        Me.codCentroConvenio = wcodCentroConvenio
        Me.codCentroConvenio = wcodCentroConvenio

    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal winforme As String)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.informe = winforme

    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal winforme As String, ByVal wcodMedico As Integer, ByVal winformado As String) ', ByVal wcodCentroConvenio As Integer)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.informe = winforme
        Me.informado = winformado
        Me.cod_Medico = wcodMedico
        
    End Sub
    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcod_Examen As Integer, ByVal wNombreExamen As String, ByVal winforme As String)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.Examen = New Examen(wcod_Examen, wNombreExamen)
        Me.PlanAtencion = New Plan_Atencion(0, "")

        Me.cod_Examen = wcod_Examen
        Me.informe = winforme
    End Sub

    Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcod_Examen As Integer, ByVal wNombreExamen As String, ByVal winforme As String, ByVal wcodMedico As Integer, ByVal winformado As String) ', ByVal wcodCentroConvenio As Integer)
        Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
        Me.cod_Consulta = wcod_Consulta
        Me.Examen = New Examen(wcod_Examen, wNombreExamen)
        Me.cod_Examen = wcod_Examen
        Me.informe = winforme
        Me.informado = winformado
        Me.cod_Medico = wcodMedico

    End Sub
    'Public Sub New(ByVal wcod_Detalle_Consulta As Integer, ByVal wcod_Consulta As Integer, ByVal wcod_Examen As Integer, ByVal wNombreExamen As String, ByVal winforme As String, ByVal wcodMedico As Integer, ByVal winformado As String)
    '    Me.cod_Detalle_Consulta = wcod_Detalle_Consulta
    '    Me.cod_Consulta = wcod_Consulta
    '    Me.Examen = New Examen(wcod_Examen, wNombreExamen)
    '    Me.cod_Examen = wcod_Examen
    '    Me.informe = winforme
    '    Me.informado = winformado
    '    Me.cod_Medico = wcodMedico
    'End Sub

#End Region

End Class