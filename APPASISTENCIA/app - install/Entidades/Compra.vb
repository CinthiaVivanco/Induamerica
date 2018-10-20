Public Class Compra

#Region "Datos"
	Private mcod_compra AS Integer
	Private mfecha AS Date
	Private mnrodocumento AS String
	Private mmoneda AS String
    Private mmontototal As Double
    Private mcod_Proveedor As Integer
    Private mTC As Double
    Private mestado As String


#End Region
#Region "Propiedades"
	Public Property cod_compra() AS Integer
		Get
			return Me.mcod_compra
		End Get
		Set(ByVal value As Integer)
			Me.mcod_compra = value
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
	Public Property nrodocumento() AS String
		Get
			return Me.mnrodocumento
		End Get
		Set(ByVal value As String)
			Me.mnrodocumento = value
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
 
	Public Property moneda() AS String
		Get
			return Me.mmoneda
		End Get
		Set(ByVal value As String)
			Me.mmoneda = value
		End Set
	End Property
    Public Property montototal() As Double
        Get
            Return Me.mmontototal
        End Get
        Set(ByVal value As Double)
            Me.mmontototal = value
        End Set
    End Property
    Public Property TC() As Double
        Get
            Return Me.mTC
        End Get
        Set(ByVal value As Double)
            Me.mTC = value
        End Set
    End Property

    Public Property cod_Proveedor() As Integer
        Get
            Return Me.mcod_Proveedor
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Proveedor = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wcod_compra As Integer)

        Me.cod_compra = wcod_compra

    End Sub
    Public Sub New(ByVal wcod_compra As Integer, ByVal wfecha As Date, ByVal wnrodocumento As String, ByVal wmoneda As String, ByVal wmontototal As Double, ByVal wtc As Double, ByVal wcod_Proveedor As Integer, ByVal westado As String)
        Me.cod_compra = wcod_compra
        Me.fecha = wfecha
        Me.nrodocumento = wnrodocumento
        Me.moneda = wmoneda
        Me.montototal = wmontototal
        Me.TC = wtc
        Me.estado = westado
        Me.cod_Proveedor = wcod_Proveedor


    End Sub

#End Region

End Class