Public Class Kardex

#Region "Datos"
	Private mcod_kardex AS Integer
	Private mtipo AS String
    Private mcantidad As Integer
    Private mcantidadTotal As Integer

	Private mfecha AS Date
	Private mcod_Producto AS Integer
    Private mcod_Ambiente As Integer

    Private mcod_detalleMaterial As Integer
    Private mUsuarioReg As String

#End Region
#Region "Propiedades"
	Public Property cod_kardex() AS Integer
		Get
			return Me.mcod_kardex
		End Get
		Set(ByVal value As Integer)
			Me.mcod_kardex = value
		End Set
	End Property
	Public Property tipo() AS String
		Get
			return Me.mtipo
		End Get
		Set(ByVal value As String)
			Me.mtipo = value
		End Set
	End Property
	Public Property cantidad() AS Integer
		Get
			return Me.mcantidad
		End Get
		Set(ByVal value As Integer)
			Me.mcantidad = value
		End Set
    End Property
    Public Property cantidadTotal() As Integer
        Get
            Return Me.mcantidadTotal
        End Get
        Set(ByVal value As Integer)
            Me.mcantidadTotal = value
        End Set
    End Property

	Public Property fecha() AS Date
		Get
			return Me.mfecha
		End Get
		Set(ByVal value As Date)
			Me.mfecha = value
		End Set
	End Property
	Public Property cod_Producto() AS Integer
		Get
			return Me.mcod_Producto
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Producto = value
		End Set
	End Property
	Public Property cod_Ambiente() AS Integer
		Get
			return Me.mcod_Ambiente
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Ambiente = value
		End Set
    End Property
    Public Property cod_detalleMaterial() As Integer
        Get
            Return Me.mcod_detalleMaterial
        End Get
        Set(ByVal value As Integer)
            Me.mcod_detalleMaterial = value
        End Set
    End Property
    Public Property UsuarioReg() As String
        Get
            Return Me.mUsuarioReg
        End Get
        Set(ByVal value As String)
            Me.mUsuarioReg = value
        End Set
    End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_kardex As Integer)
        Me.cod_kardex = wcod_kardex
    End Sub
    Public Sub New(ByVal wcod_kardex As Integer, ByVal wtipo As String, ByVal wcantidad As Integer, ByVal wcantidadTotal As Integer, ByVal wfecha As Date, ByVal wcod_Producto As Integer, ByVal wcod_Ambiente As Integer)
        Me.cod_kardex = wcod_kardex
        Me.tipo = wtipo
        Me.cantidad = wcantidad
        Me.cantidadTotal = wcantidadTotal

        Me.fecha = wfecha
        Me.cod_Producto = wcod_Producto
        Me.cod_Ambiente = wcod_Ambiente
    End Sub
    Public Sub New(ByVal wcod_kardex As Integer, ByVal wtipo As String, ByVal wcantidad As Integer, ByVal wcantidadTotal As Integer, ByVal wfecha As Date, ByVal wcod_Producto As Integer, ByVal wcod_Ambiente As Integer, ByVal wcod_detalleMaterial As Integer)
        Me.cod_kardex = wcod_kardex
        Me.tipo = wtipo
        Me.cantidad = wcantidad
        Me.cantidadTotal = wcantidadTotal

        Me.fecha = wfecha
        Me.cod_Producto = wcod_Producto
        Me.cod_Ambiente = wcod_Ambiente
        Me.cod_detalleMaterial = wcod_detalleMaterial
    End Sub

    Public Sub New(ByVal wcod_kardex As Integer, ByVal wtipo As String, ByVal wcantidad As Integer, ByVal wcantidadTotal As Integer, ByVal wfecha As Date, ByVal wcod_Producto As Integer, ByVal wcod_Ambiente As Integer, ByVal wcod_detalleMaterial As Integer, ByVal wUsuarioReg As String)
        Me.cod_kardex = wcod_kardex
        Me.tipo = wtipo
        Me.cantidad = wcantidad
        Me.cantidadTotal = wcantidadTotal

        Me.fecha = wfecha
        Me.cod_Producto = wcod_Producto
        Me.cod_Ambiente = wcod_Ambiente
        Me.cod_detalleMaterial = wcod_detalleMaterial

        Me.UsuarioReg = wUsuarioReg
    End Sub

    Public Sub New(ByVal wcod_kardex As Integer, ByVal wcod_detalleMaterial As Integer, ByVal wcod_Ambiente As Integer)
        Me.cod_kardex = wcod_kardex
        Me.cod_detalleMaterial = wcod_detalleMaterial
        Me.cod_Ambiente = wcod_Ambiente
    End Sub

    Public Sub New(ByVal wcod_kardex As Integer, ByVal wcod_Prod As Integer, ByVal wcod_Ambiente As Integer, ByVal wstock As Integer)
        Me.cod_Producto = wcod_Prod
        Me.cod_Ambiente = wcod_Ambiente
        Me.cantidadTotal = wstock

    End Sub
#End Region

End Class