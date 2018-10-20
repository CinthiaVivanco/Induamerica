Public Class Tipo_Examen

#Region "Datos"
	Private mcod_TipoExamen AS Integer
	Private mnombre AS String
#End Region

#Region "Propiedades"
    Public Property cod_TipoExamen() As Integer
        Get
            Return Me.mcod_TipoExamen
        End Get
        Set(ByVal value As Integer)
            Me.mcod_TipoExamen = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return Me.mnombre
        End Get
        Set(ByVal value As String)
            Me.mnombre = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_TipoExamen As Integer, ByVal wnombre As String)
        Me.cod_TipoExamen = wcod_TipoExamen
        Me.nombre = wnombre
    End Sub
#End Region

End Class