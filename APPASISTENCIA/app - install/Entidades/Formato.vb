Public Class Formato

#Region "Datos"
	Private mcod_Formato AS Integer
	Private mcontenido AS String
#End Region
#Region "Propiedades"
   

    Public Property cod_Formato() As Integer
        Get
            Return Me.mcod_Formato
        End Get
        Set(ByVal value As Integer)
            Me.mcod_Formato = value
        End Set
    End Property
	Public Property contenido() AS String
		Get
			return Me.mcontenido
		End Get
		Set(ByVal value As String)
			Me.mcontenido = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
    End Sub

    Public Sub New(ByVal wCodigo As Integer)
        Me.cod_Formato = wCodigo

    End Sub
    Public Sub New(ByVal wcod_Formato As Integer, ByVal wcontenido As String)
        Me.cod_Formato = wcod_Formato
        Me.contenido = wcontenido
    End Sub
#End Region

End Class