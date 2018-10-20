Public Class OPCION

#Region "Datos"

    Protected mNumero As Integer
    Private mOSistema As SISTEMA
    Private mNombre As String
    Private mDescripcion As String
    Private mVigencia As Integer
#End Region

#Region "Propiedades"
    Public Property Numero() As Integer
        Get
            Return mNumero
        End Get
        Set(ByVal value As Integer)
            mNumero = value
        End Set
    End Property

    Public Property Sistema() As SISTEMA
        Get
            Return mOSistema
        End Get
        Set(ByVal value As SISTEMA)
            mOSistema = value
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

    Public Property Vigencia() As Integer
        Get
            Return mVigencia
        End Get
        Set(ByVal value As Integer)
            mVigencia = value
        End Set
    End Property


    Public ReadOnly Property nombrevigencia() As String
        Get
            If mVigencia = 0 Then
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

    Public Sub New(ByVal wNumero As Integer, ByVal wSistema As SISTEMA, ByVal wNombre As String, ByVal wDescripcion As String, ByVal wVigencia As Integer)
        Me.mNumero = wNumero
        Me.mOSistema = wSistema
        Me.mNombre = wNombre
        Me.mDescripcion = wDescripcion
        Me.mVigencia = wVigencia
    End Sub
    Public Sub New(ByVal wNumero As Integer, ByVal wNombre As String, ByVal wDescripcion As String, ByVal wVigencia As Integer)
        Me.mNumero = wNumero
        Me.mNombre = wNombre
        Me.mDescripcion = wDescripcion
        Me.mVigencia = wVigencia
    End Sub

    Public Sub New(ByVal wNumero As Integer)
        Me.mNumero = wNumero
    End Sub
#End Region


End Class