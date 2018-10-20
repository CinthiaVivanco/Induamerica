Public Class Categoria_Medico

#Region "Datos"
	Private mcod_categoria AS Integer
	Private mcod_medico AS Integer
	Private mcod_centroconvenio AS Integer
    Private mprecio As Double
    Private mnombreCategoria As String

#End Region

#Region "Propiedades"
    Public Property cod_categoria() As Integer
        Get
            Return Me.mcod_categoria
        End Get
        Set(ByVal value As Integer)
            Me.mcod_categoria = value
        End Set
    End Property
    Public Property cod_medico() As Integer
        Get
            Return Me.mcod_medico
        End Get
        Set(ByVal value As Integer)
            Me.mcod_medico = value
        End Set
    End Property
    Public Property cod_centroconvenio() As Integer
        Get
            Return Me.mcod_centroconvenio
        End Get
        Set(ByVal value As Integer)
            Me.mcod_centroconvenio = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return Me.mprecio
        End Get
        Set(ByVal value As Double)
            Me.mprecio = value
        End Set
    End Property


    Public Property NombreCategoria() As String

        Get
            Return Me.mnombreCategoria
        End Get
        Set(ByVal value As String)
            Me.mnombreCategoria = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wcod_medico As Integer, ByVal wcod_centroconvenio As Integer)

        Me.cod_medico = wcod_medico
        Me.cod_centroconvenio = wcod_centroconvenio

    End Sub
    Public Sub New(ByVal wcod_categoria As Integer, ByVal wcod_medico As Integer, ByVal wcod_centroconvenio As Integer, ByVal wprecio As Double)
        Me.cod_categoria = wcod_categoria
        Me.cod_medico = wcod_medico
        Me.cod_centroconvenio = wcod_centroconvenio
        Me.precio = wprecio
    End Sub
    Public Sub New(ByVal wcod_categoria As Integer, ByVal wcod_medico As Integer, ByVal wcod_centroconvenio As Integer, ByVal wprecio As Double, ByVal wNombreCategoria As String)
        Me.cod_categoria = wcod_categoria
        Me.cod_medico = wcod_medico
        Me.cod_centroconvenio = wcod_centroconvenio
        Me.precio = wprecio
        Me.NombreCategoria = wNombreCategoria
    End Sub

#End Region

End Class