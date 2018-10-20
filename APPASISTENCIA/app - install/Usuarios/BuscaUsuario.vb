Public Class buscaUsuario
    Public Event DobleClicGrid()

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub buscaUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombre.Text = ""
        txtnombre.Focus()
        Me.dgvusuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnbusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusca.Click
        Dim obj As New RNUsuario
        Dim la As List(Of Usuario)
        la = obj.Listar(txtnombre.Text.Trim)
        dgvusuario.AutoGenerateColumns = False
        dgvusuario.DataSource = la
    End Sub

    Private Sub dgvgrupo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvusuario.DoubleClick
        RaiseEvent DobleClicGrid()
    End Sub

    Private Sub txtnombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Enter
        Me.ParentForm.AcceptButton = btnbusca
    End Sub

   
End Class
