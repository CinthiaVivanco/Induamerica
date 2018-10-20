Public Class BuscaPersonal
    Public Event DobleClicGrid()
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Sub btnbusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusca.Click
        Dim obj As New RNPersona
        Dim la As List(Of Persona)
        la = obj.ListarPersonal(txtnombre.Text.Trim)
        dgvgrupo.AutoGenerateColumns = False
        dgvgrupo.DataSource = la
    End Sub

    Private Sub BuscaPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombre.Text = ""
        txtnombre.Focus()

    End Sub

    Private Sub dgvgrupo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvgrupo.DoubleClick
        RaiseEvent DobleClicGrid()
    End Sub

    Private Sub txtnombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Enter
        Me.ParentForm.AcceptButton = btnbusca
    End Sub
End Class
