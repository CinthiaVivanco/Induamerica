Public Class SISTEMA

#Region "Datos"
    Protected mCodigo As Integer
    Private mNombre As String
    Private mDescripcion As String
    Private mVigencia As Boolean
#End Region

#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal value As String)
            mDescripcion = value
        End Set
    End Property

    Public Property Vigencia() As Boolean
        Get
            Return mVigencia
        End Get
        Set(ByVal value As Boolean)
            mVigencia = value
        End Set
    End Property

    Public ReadOnly Property nombrecompleto() As String
        Get
            If mVigencia = False Then
                Return mNombre & " - " & " - No vigente"
            Else
                Return mNombre & " - " & " - Vigente"

            End If
        End Get
    End Property

    Public ReadOnly Property nombrevigencia() As String
        Get
            If mVigencia = False Then
                Return "No vigente"
            Else
                Return "Vigente"

            End If
        End Get
    End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wDescripcion As String, ByVal wVigencia As Boolean)
        Me.mCodigo = wCodigo
        Me.mNombre = wNombre
        Me.mDescripcion = wDescripcion
        Me.mVigencia = wVigencia
    End Sub

    Public Sub New(ByVal wNombre As String, ByVal wDescripcion As String, ByVal wVigencia As Boolean)
        Me.mNombre = wNombre
        Me.mDescripcion = wDescripcion
        Me.mVigencia = wVigencia
    End Sub

    Public Sub New(ByVal wDescripcion As String, ByVal wVigencia As Boolean)
        Me.mDescripcion = wDescripcion
        Me.mVigencia = wVigencia
    End Sub

    Public Sub New(ByVal wCodigo As Integer)
        Me.mCodigo = wCodigo
    End Sub

#End Region



End Class