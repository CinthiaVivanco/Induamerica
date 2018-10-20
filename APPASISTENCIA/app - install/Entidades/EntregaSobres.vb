Public Class EntregaSobres
    
#Region "Datos"
	Private mperiodoid AS String
	Private mcod_medico AS Integer
	Private mfechareparto AS Date
	Private mfechadevolucion AS Date
	Private mfechaentrega AS Date
	Private mdevolvio AS Boolean
	Private mreogiocerin AS Boolean
	Private mfechacerin AS Date
	Private mobservacion AS String
    Private musuarioreg As String
    Private musuariomod As String
    Private mfechamod As Date

    Private moMedico As Medico

#End Region
#Region "Propiedades"
	Public Property periodoid() AS String
		Get
			return Me.mperiodoid
		End Get
		Set(ByVal value As String)
			Me.mperiodoid = value
		End Set
	End Property
	Public Property cod_medico() AS Integer
		Get
			return Me.mcod_medico
		End Get
		Set(ByVal value As Integer)
			Me.mcod_medico = value
		End Set
	End Property
	Public Property fechareparto() AS Date
		Get
			return Me.mfechareparto
		End Get
		Set(ByVal value As Date)
			Me.mfechareparto = value
		End Set
	End Property
	Public Property fechadevolucion() AS Date
		Get
			return Me.mfechadevolucion
		End Get
		Set(ByVal value As Date)
			Me.mfechadevolucion = value
		End Set
	End Property
	Public Property fechaentrega() AS Date
		Get
			return Me.mfechaentrega
		End Get
		Set(ByVal value As Date)
			Me.mfechaentrega = value
		End Set
	End Property
	Public Property devolvio() AS Boolean
		Get
			return Me.mdevolvio
		End Get
		Set(ByVal value As Boolean)
			Me.mdevolvio = value
		End Set
	End Property
    Public Property recogiocerin() As Boolean
        Get
            Return Me.mreogiocerin
        End Get
        Set(ByVal value As Boolean)
            Me.mreogiocerin = value
        End Set
    End Property
	Public Property fechacerin() AS Date
		Get
			return Me.mfechacerin
		End Get
		Set(ByVal value As Date)
			Me.mfechacerin = value
		End Set
	End Property
	Public Property observacion() AS String
		Get
			return Me.mobservacion
		End Get
		Set(ByVal value As String)
			Me.mobservacion = value
		End Set
	End Property
    Public Property usuarioreg() As String
        Get
            Return Me.musuarioreg
        End Get
        Set(ByVal value As String)
            Me.musuarioreg = value
        End Set
    End Property
    Public Property usuariomod() As String
        Get
            Return Me.musuariomod
        End Get
        Set(ByVal value As String)
            Me.musuariomod = value
        End Set
    End Property
    Public Property fechamod() As Date
        Get
            Return Me.mfechamod
        End Get
        Set(ByVal value As Date)
            Me.mfechamod = value
        End Set
    End Property

    Public Property Medico() As Medico
        Get
            Return Me.moMedico
        End Get
        Set(ByVal value As Medico)
            Me.moMedico = value
        End Set
    End Property
    Public ReadOnly Property NombreMedico As String
        Get
            Return Medico.NombreCompleto
        End Get
    End Property

#End Region
#Region "Constructores"
	Public Sub New()
    End Sub
    Public Sub New(ByVal wperiodoid As String)
        Me.periodoid = wperiodoid

    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wusuarioreg As String)
        Me.periodoid = wperiodoid
        Me.usuarioreg = wusuarioreg
    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wcod_medico As Integer, ByVal wfechareparto As Date, ByVal wfechadevolucion As Date, ByVal wfechaentrega As Date, ByVal wdevolvio As Boolean, ByVal wreogiocerin As Boolean, ByVal wfechacerin As Date, ByVal wobservacion As String, ByVal wusuarioreg As String, ByVal wusuariomod As String, ByVal wfechamod As Date)
        Me.periodoid = wperiodoid
        Me.cod_medico = wcod_medico
        Me.fechareparto = wfechareparto
        Me.fechadevolucion = wfechadevolucion
        Me.fechaentrega = wfechaentrega
        Me.devolvio = wdevolvio
        Me.recogiocerin = wreogiocerin
        Me.fechacerin = wfechacerin
        Me.observacion = wobservacion
        Me.usuarioreg = wusuarioreg
        Me.usuariomod = wusuariomod
        Me.fechamod = wfechamod
    End Sub
    Public Sub New(ByVal wperiodoid As String, ByVal wcod_medico As Integer, ByVal wfechareparto As Date, ByVal wfechadevolucion As Date, ByVal wfechaentrega As Date, ByVal wdevolvio As Boolean, ByVal wreogiocerin As Boolean, ByVal wfechacerin As Date, ByVal wobservacion As String, ByVal wusuarioreg As String, ByVal wusuariomod As String, ByVal wfechamod As Date _
                      , ByVal wpaterno As String, ByVal wmaterno As String, ByVal wnombre As String)
        Me.periodoid = wperiodoid
        Me.cod_medico = wcod_medico
        Me.fechareparto = wfechareparto
        Me.fechadevolucion = wfechadevolucion
        Me.fechaentrega = wfechaentrega
        Me.devolvio = wdevolvio
        Me.recogiocerin = wreogiocerin
        Me.fechacerin = wfechacerin
        Me.observacion = wobservacion
        Me.usuarioreg = wusuarioreg
        Me.usuariomod = wusuariomod
        Me.fechamod = wfechamod

        Medico = New Medico(wcod_medico, wnombre, wpaterno, wmaterno, "", 0, 0)

    End Sub
#End Region

End Class