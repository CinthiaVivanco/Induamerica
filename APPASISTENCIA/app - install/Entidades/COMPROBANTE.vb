Public Class COMPROBANTE

#Region "Datos"
	Private mcod_Comprobante AS Integer
	Private mnombre AS String
	Private mserie AS String
	Private mnumero AS String
#End Region
#Region "Propiedades"
	Public Property cod_Comprobante() AS Integer
		Get
			return Me.mcod_Comprobante
		End Get
		Set(ByVal value As Integer)
			Me.mcod_Comprobante = value
		End Set
	End Property
	Public Property nombre() AS String
		Get
			return Me.mnombre
		End Get
		Set(ByVal value As String)
			Me.mnombre = value
		End Set
	End Property
	Public Property serie() AS String
		Get
			return Me.mserie
		End Get
		Set(ByVal value As String)
			Me.mserie = value
		End Set
	End Property
	Public Property numero() AS String
		Get
			return Me.mnumero
		End Get
		Set(ByVal value As String)
			Me.mnumero = value
		End Set
    End Property
    Public ReadOnly Property NumSerie() As String
        Get
            Return Me.serie.Trim + "-" + Me.numero.Trim
        End Get

    End Property


#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
    Public Sub New(ByVal wcod_Comprobante As Integer, ByVal wnumero As String)
        Me.cod_Comprobante = wcod_Comprobante
        Me.numero = wnumero
    End Sub
    Public Sub New(ByVal wcod_Comprobante As Integer, ByVal wnombre As String, ByVal wserie As String, ByVal wnumero As String)
        Me.cod_Comprobante = wcod_Comprobante
        Me.nombre = wnombre
        Me.serie = wserie
        Me.numero = wnumero
    End Sub
#End Region

End Class