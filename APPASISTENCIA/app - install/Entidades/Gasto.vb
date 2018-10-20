Public Class Gasto

 

#Region "Datos"
	Private mcod_gasto AS Integer
	Private mFechaEmision AS Date
	Private mRuc AS String
	Private mRazonSocial AS String
	Private mNroDocumento AS String
	Private mNroCuenta AS String
    Private mMonto As Double
    Private mIgv As Double
    Private mRetencion As Double
    Private mTotalPagado As Double

	Private mDescripcion AS String
	Private mcod_TipoGasto AS Integer
	Private mcod_TipoDoc AS Integer
#End Region
#Region "Propiedades"
	Public Property cod_gasto() AS Integer
		Get
			return Me.mcod_gasto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_gasto = value
		End Set
	End Property
	Public Property FechaEmision() AS Date
		Get
			return Me.mFechaEmision
		End Get
		Set(ByVal value As Date)
			Me.mFechaEmision = value
		End Set
	End Property
	Public Property Ruc() AS String
		Get
			return Me.mRuc
		End Get
		Set(ByVal value As String)
			Me.mRuc = value
		End Set
	End Property
	Public Property RazonSocial() AS String
		Get
			return Me.mRazonSocial
		End Get
		Set(ByVal value As String)
			Me.mRazonSocial = value
		End Set
	End Property
	Public Property NroDocumento() AS String
		Get
			return Me.mNroDocumento
		End Get
		Set(ByVal value As String)
			Me.mNroDocumento = value
		End Set
	End Property
	Public Property NroCuenta() AS String
		Get
			return Me.mNroCuenta
		End Get
		Set(ByVal value As String)
			Me.mNroCuenta = value
		End Set
	End Property
    Public Property Monto() As Double
        Get
            Return Me.mMonto
        End Get
        Set(ByVal value As Double)
            Me.mMonto = value
        End Set
    End Property

    Public Property TotalPagado() As Double
        Get
            Return Me.mTotalPagado
        End Get
        Set(ByVal value As Double)
            Me.mTotalPagado = value
        End Set
    End Property

    Public Property Igv() As Double
        Get
            Return Me.mIgv
        End Get
        Set(ByVal value As Double)
            Me.mIgv = value
        End Set
    End Property
    Public Property Retencion() As Double
        Get
            Return Me.mRetencion
        End Get
        Set(ByVal value As Double)
            Me.mRetencion = value
        End Set
    End Property
	Public Property Descripcion() AS String
		Get
			return Me.mDescripcion
		End Get
		Set(ByVal value As String)
			Me.mDescripcion = value
		End Set
	End Property
	Public Property cod_TipoGasto() AS Integer
		Get
			return Me.mcod_TipoGasto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoGasto = value
		End Set
	End Property
	Public Property cod_TipoDoc() AS Integer
		Get
			return Me.mcod_TipoDoc
		End Get
		Set(ByVal value As Integer)
			Me.mcod_TipoDoc = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_gasto As Integer)

        Me.cod_gasto = wcod_gasto
    End Sub

    Public Sub New(ByVal wcod_gasto As Integer, ByVal Descripcion As String, ByVal wNroDocumento As String, ByVal wMonto As Double)
        Me.cod_gasto = wcod_gasto
        Me.Descripcion = Descripcion
        Me.NroDocumento = wNroDocumento
        Me.TotalPagado = wMonto
    End Sub

    Public Sub New(ByVal wcod_gasto As Integer, ByVal wFechaEmision As Date, ByVal wRuc As String, ByVal wRazonSocial As String, ByVal wNroDocumento As String, ByVal wNroCuenta As String, ByVal wMonto As Double, ByVal wIgv As Double, ByVal wRetencion As Double, ByVal wTotalPagado As Double, ByVal wDescripcion As String, ByVal wcod_TipoGasto As Integer, ByVal wcod_TipoDoc As Integer)
        Me.cod_gasto = wcod_gasto
        Me.FechaEmision = wFechaEmision
        Me.Ruc = wRuc
        Me.RazonSocial = wRazonSocial
        Me.NroDocumento = wNroDocumento
        Me.NroCuenta = wNroCuenta
        Me.Monto = wMonto
        Me.TotalPagado = wTotalPagado
        Me.Igv = wIgv
        Me.Retencion = wRetencion
        Me.Descripcion = wDescripcion
        Me.cod_TipoGasto = wcod_TipoGasto
        Me.cod_TipoDoc = wcod_TipoDoc
    End Sub

#End Region

End Class