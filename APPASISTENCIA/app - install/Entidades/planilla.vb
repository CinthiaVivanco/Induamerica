Public Class planilla

#Region "Datos"
	Private mperiodoid AS String
	Private mcodigoPersonal AS Integer
	Private mplanilla AS String
    Private mjornada As String
    Private mbasico As Double
    Private masigfam As Double
    Private mcostoxdia As Double

    Private msbruto As Double
    Private mdias As Double
    Private mfaltas As Double
    Private mferiados As Double
    Private mrentaquinta As Double
    Private mcodafp As String
    Private mafpfondo As Double
    Private mafpseguro As Double
    Private mafpcomision As Double
    Private messalud As Double
    Private mbono As Double
    Private madelanto As Double
    Private mdcto As Double
    Private mneto As Double
    Private mestado As String

    Private moPersonal As PERSONAL

#End Region
#Region "Propiedades"
    Public Property periodoid() As String
        Get
            Return Me.mperiodoid
        End Get
        Set(ByVal value As String)
            Me.mperiodoid = value
        End Set
    End Property
    Public Property codigoPersonal() As Integer
        Get
            Return Me.mcodigoPersonal
        End Get
        Set(ByVal value As Integer)
            Me.mcodigoPersonal = value
        End Set
    End Property
    Public Property planilla() As String
        Get
            Return Me.mplanilla
        End Get
        Set(ByVal value As String)
            Me.mplanilla = value
        End Set
    End Property
    Public Property jornada() As String
        Get
            Return Me.mjornada
        End Get
        Set(ByVal value As String)
            Me.mjornada = value
        End Set
    End Property
    Public Property basico() As Double
        Get
            Return Me.mbasico
        End Get
        Set(ByVal value As Double)
            Me.mbasico = value
        End Set
    End Property
    Public Property asigfam() As Double
        Get
            Return Me.masigfam
        End Get
        Set(ByVal value As Double)
            Me.masigfam = value
        End Set
    End Property
    Public Property costoxdia() As Double
        Get
            Return Me.mcostoxdia
        End Get
        Set(ByVal value As Double)
            Me.mcostoxdia = value
        End Set
    End Property
    Public Property sbruto() As Double
        Get
            Return Me.msbruto
        End Get
        Set(ByVal value As Double)
            Me.msbruto = value
        End Set
    End Property
    Public Property dias() As Double
        Get
            Return Me.mdias
        End Get
        Set(ByVal value As Double)
            Me.mdias = value
        End Set
    End Property
    Public Property faltas() As Double
        Get
            Return Me.mfaltas
        End Get
        Set(ByVal value As Double)
            Me.mfaltas = value
        End Set
    End Property
    Public Property feriados() As Double
        Get
            Return Me.mferiados
        End Get
        Set(ByVal value As Double)
            Me.mferiados = value
        End Set
    End Property
    Public Property rentaquinta() As Double
        Get
            Return Me.mrentaquinta
        End Get
        Set(ByVal value As Double)
            Me.mrentaquinta = value
        End Set
    End Property
    Public Property codafp() As String
        Get
            Return Me.mcodafp
        End Get
        Set(ByVal value As String)
            Me.mcodafp = value
        End Set
    End Property
    Public Property afpfondo() As Double
        Get
            Return Me.mafpfondo
        End Get
        Set(ByVal value As Double)
            Me.mafpfondo = value
        End Set
    End Property
    Public Property afpseguro() As Double
        Get
            Return Me.mafpseguro
        End Get
        Set(ByVal value As Double)
            Me.mafpseguro = value
        End Set
    End Property
    Public Property afpcomision() As Double
        Get
            Return Me.mafpcomision
        End Get
        Set(ByVal value As Double)
            Me.mafpcomision = value
        End Set
    End Property
    Public Property essalud() As Double
        Get
            Return Me.messalud
        End Get
        Set(ByVal value As Double)
            Me.messalud = value
        End Set
    End Property
    Public Property bono() As Double
        Get
            Return Me.mbono
        End Get
        Set(ByVal value As Double)
            Me.mbono = value
        End Set
    End Property
    Public Property adelanto() As Double
        Get
            Return Me.madelanto
        End Get
        Set(ByVal value As Double)
            Me.madelanto = value
        End Set
    End Property
    Public Property dcto() As Double
        Get
            Return Me.mdcto
        End Get
        Set(ByVal value As Double)
            Me.mdcto = value
        End Set
    End Property
    Public Property neto() As Double
        Get
            Return Me.mneto
        End Get
        Set(ByVal value As Double)
            Me.mneto = value
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

    Public ReadOnly Property NJornada
        Get
            If jornada = "C" Then
                Return "Completa"
            ElseIf jornada = "P" Then
                Return "Parcial"
            End If
        End Get
    End Property

    Public ReadOnly Property TotalAFP
        Get
            Return afpfondo + afpcomision + afpseguro
        End Get
    End Property


    Public Property Personal() As PERSONAL
        Get
            Return Me.moPersonal
        End Get
        Set(ByVal value As PERSONAL)
            Me.moPersonal = value
        End Set
    End Property
    Public ReadOnly Property NombrePersonal As String
        Get
            Return Personal.NombreCompleto
        End Get
    End Property

#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
    Public Sub New(ByVal wperiodoid As String)
        Me.periodoid = wperiodoid
    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wcodigoPersonal As Integer)

        Me.periodoid = wperiodoid
        Me.codigoPersonal = wcodigoPersonal

    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wcodigoPersonal As Integer, ByVal wsbruto As Double, ByVal wdias As Double, ByVal wfaltas As Double, ByVal wferiados As Double, ByVal wrentaquinta As Double, ByVal wcodafp As String, ByVal wbono As Double, ByVal wadelanto As Double, ByVal wdcto As Double, ByVal wneto As Double, ByVal westado As String)
        Me.periodoid = wperiodoid
        Me.codigoPersonal = wcodigoPersonal
        Me.sbruto = wsbruto
        Me.dias = wdias
        Me.feriados = wferiados
        Me.rentaquinta = wrentaquinta
        Me.bono = wbono
        Me.adelanto = wadelanto
        Me.dcto = wdcto
        Me.neto = wneto
        Me.codafp = wcodafp
        Me.estado = westado
    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wcodigoPersonal As Integer, ByVal wplanilla As String, ByVal wjornada As String, ByVal wbasico As Double, ByVal wasigfam As Double, ByVal wcostoxdia As Double, ByVal wsbruto As Double, ByVal wdias As Double, ByVal wfaltas As Double, ByVal wferiados As Double, ByVal wrentaquinta As Double, ByVal wcodafp As String, ByVal wafpfondo As Double, ByVal wafpseguro As Double, ByVal wafpcomision As Double, ByVal wessalud As Double, ByVal wbono As Double, ByVal wadelanto As Double, ByVal wdcto As Double, ByVal wneto As Double, ByVal westado As String)
        Me.periodoid = wperiodoid
        Me.codigoPersonal = wcodigoPersonal
        Me.planilla = wplanilla
        Me.jornada = wjornada
        Me.basico = wbasico
        Me.asigfam = wasigfam
        Me.costoxdia = wcostoxdia
        Me.sbruto = wsbruto
        Me.dias = wdias
        Me.faltas = wfaltas
        Me.feriados = wferiados
        Me.rentaquinta = wrentaquinta
        Me.codafp = wcodafp
        Me.afpfondo = wafpfondo
        Me.afpseguro = wafpseguro
        Me.afpcomision = wafpcomision
        Me.essalud = wessalud
        Me.bono = wbono
        Me.adelanto = wadelanto
        Me.dcto = wdcto
        Me.neto = wneto
        Me.estado = westado
    End Sub

    Public Sub New(ByVal wperiodoid As String, ByVal wcodigoPersonal As Integer, ByVal wplanilla As String, ByVal wjornada As String, ByVal wbasico As Double, ByVal wasigfam As Double, ByVal wcostoxdia As Double, ByVal wsbruto As Double, ByVal wdias As Double, ByVal wfaltas As Double, ByVal wferiados As Double, ByVal wrentaquinta As Double, ByVal wcodafp As String, ByVal wafpfondo As Double, ByVal wafpseguro As Double, ByVal wafpcomision As Double, ByVal wessalud As Double, ByVal wbono As Double, ByVal wadelanto As Double, ByVal wdcto As Double, ByVal wneto As Double, ByVal westado As String _
                   , ByVal wpaterno As String, ByVal wmaterno As String, ByVal wnombre As String)
        Me.periodoid = wperiodoid
        Me.codigoPersonal = wcodigoPersonal
        Me.planilla = wplanilla
        Me.jornada = wjornada
        Me.basico = wbasico
        Me.asigfam = wasigfam
        Me.costoxdia = wcostoxdia
        Me.sbruto = wsbruto
        Me.dias = wdias
        Me.faltas = wfaltas
        Me.feriados = wferiados
        Me.rentaquinta = wrentaquinta
        Me.codafp = wcodafp
        Me.afpfondo = wafpfondo
        Me.afpseguro = wafpseguro
        Me.afpcomision = wafpcomision
        Me.essalud = wessalud
        Me.bono = wbono
        Me.adelanto = wadelanto
        Me.dcto = wdcto
        Me.neto = wneto
        Me.estado = westado

        Personal = New PERSONAL(wcodigoPersonal, wnombre, wpaterno, wmaterno, "", "")

    End Sub
#End Region

End Class