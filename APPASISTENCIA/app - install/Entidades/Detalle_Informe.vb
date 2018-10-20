Public Class Detalle_Informe

#Region "Datos"
	Private mcod_DetalleInforme AS Integer
	Private mcantidad AS Integer
    Private mMonto_Total As Double
    Private mInforme As String
    Private mestado As String
    Private mcod_Examen As Integer
    Private mcod_Informe As Integer

    Private moExamen As Examen

    Private mcodMedico As String
    Private mInformado As String


#End Region
#Region "Propiedades"
    Public Property cod_DetalleInforme() As Integer
        Get
            Return Me.mcod_DetalleInforme
        End Get
        Set(ByVal value As Integer)
            Me.mcod_DetalleInforme = value
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
    Public Property cod_Medico() As Integer
        Get
            Return Me.mcodMedico
        End Get
        Set(ByVal value As Integer)
            Me.mcodMedico = value
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
    Public Property Monto_Total() As Double
        Get
            Return Me.mMonto_Total
        End Get
        Set(ByVal value As Double)
            Me.mMonto_Total = value
        End Set
    End Property
    Public Property Informe() As String
        Get
            Return Me.mInforme
        End Get
        Set(ByVal value As String)
            Me.mInforme = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return Me.mestado
        End Get
        Set(ByVal value As String)
            Me.mestado = value
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
    Public Property cod_Informe() As Integer
        Get
            Return Me.mcod_Informe
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Informe = value
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
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer)
        Me.cod_DetalleInforme = wcod_DetalleInforme
    End Sub
    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcodInforme As Integer)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cod_Informe = wcodInforme
    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcantidad As Integer, ByVal wMonto_Total As Double, ByVal wInforme As String, ByVal westado As String, ByVal wcod_Examen As Integer, ByVal wcod_Informe As Integer)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cantidad = wcantidad
        Me.Monto_Total = wMonto_Total
        Me.Informe = wInforme
        Me.estado = westado
        Me.cod_Examen = wcod_Examen
        Me.cod_Informe = wcod_Informe
    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcodInforme As Integer, ByVal wcantidad As Integer, ByVal wMonto_Total As Double, ByVal wcod_Examen As Integer, ByVal wnombreExamen As String, ByVal wprecioExamen As Double)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cod_Informe = wcodInforme
        Me.cantidad = wcantidad
        Me.Monto_Total = wMonto_Total
        Me.cod_Examen = wcod_Examen
        Me.Examen = New Examen(wcod_Examen, wnombreExamen, wprecioExamen)

    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcodInforme As Integer, ByVal wcod_Examen As Integer, ByVal wnombreExamen As String, ByVal wInforme As String)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cod_Informe = wcodInforme
        Me.cod_Examen = wcod_Examen
        Me.Examen = New Examen(wcod_Examen, wnombreExamen)
        Me.Informe = wInforme
    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcodInforme As Integer, ByVal wcod_Examen As Integer, ByVal wnombreExamen As String, ByVal wInforme As String, ByVal wcodMedico As Integer, ByVal winformado As String)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cod_Informe = wcodInforme
        Me.cod_Examen = wcod_Examen
        Me.Examen = New Examen(wcod_Examen, wnombreExamen)
        Me.Informe = wInforme
        Me.informado = winformado
        Me.cod_Medico = wcodMedico

    End Sub

    Public Sub New(ByVal wcod_DetalleInforme As Integer, ByVal wcodInforme As Integer, ByVal winforme As String, ByVal wcodMedico As Integer, ByVal winformado As String)
        Me.cod_DetalleInforme = wcod_DetalleInforme
        Me.cod_Informe = wcodInforme
        Me.Informe = winforme
        Me.informado = winformado
        Me.cod_Medico = wcodMedico
    End Sub

    
#End Region

End Class