<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
 Partial Class frmBuscaPersona
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BuscaPersonal1 = New Colegio.IUsuario.BuscaPersonal()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(333, 18)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(115, 43)
        Me.btnSeleccionar.TabIndex = 8
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(333, 61)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 43)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BuscaPersonal1
        '
        Me.BuscaPersonal1.Location = New System.Drawing.Point(-5, 2)
        Me.BuscaPersonal1.Name = "BuscaPersonal1"
        Me.BuscaPersonal1.Size = New System.Drawing.Size(332, 238)
        Me.BuscaPersonal1.TabIndex = 9
        '
        'frmBuscaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 235)
        Me.Controls.Add(Me.BuscaPersonal1)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmBuscaPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Personal"
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BuscaPersona1 As BuscaPersona
    Friend WithEvents BuscaPersonal1 As Colegio.IUsuario.BuscaPersonal
End Class
