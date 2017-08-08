<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroAtividade
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroAtividade))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.imbLimpar = New System.Windows.Forms.ToolStripButton()
        Me.imbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.imbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdAtividade = New System.Windows.Forms.DataGridView()
        Me.txtAtividade = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imbLimpar, Me.imbSalvar, Me.imbExcluir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(391, 39)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'imbLimpar
        '
        Me.imbLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.imbLimpar.Image = CType(resources.GetObject("imbLimpar.Image"), System.Drawing.Image)
        Me.imbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imbLimpar.Name = "imbLimpar"
        Me.imbLimpar.Size = New System.Drawing.Size(36, 36)
        Me.imbLimpar.Text = "Limpar"
        '
        'imbSalvar
        '
        Me.imbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.imbSalvar.Image = CType(resources.GetObject("imbSalvar.Image"), System.Drawing.Image)
        Me.imbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imbSalvar.Name = "imbSalvar"
        Me.imbSalvar.Size = New System.Drawing.Size(36, 36)
        Me.imbSalvar.Text = "Salvar"
        '
        'imbExcluir
        '
        Me.imbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.imbExcluir.Image = CType(resources.GetObject("imbExcluir.Image"), System.Drawing.Image)
        Me.imbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imbExcluir.Name = "imbExcluir"
        Me.imbExcluir.Size = New System.Drawing.Size(36, 36)
        Me.imbExcluir.Text = "Excluir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdAtividade)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 168)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Objetivos"
        '
        'grdAtividade
        '
        Me.grdAtividade.AllowUserToAddRows = False
        Me.grdAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAtividade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Ordem, Me.Nome})
        Me.grdAtividade.Location = New System.Drawing.Point(6, 19)
        Me.grdAtividade.Name = "grdAtividade"
        Me.grdAtividade.Size = New System.Drawing.Size(352, 135)
        Me.grdAtividade.TabIndex = 0
        '
        'txtAtividade
        '
        Me.txtAtividade.Location = New System.Drawing.Point(51, 69)
        Me.txtAtividade.Name = "txtAtividade"
        Me.txtAtividade.Size = New System.Drawing.Size(319, 20)
        Me.txtAtividade.TabIndex = 7
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(9, 72)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 13)
        Me.lblNome.TabIndex = 6
        Me.lblNome.Text = "Nome:"
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Ordem
        '
        Me.Ordem.HeaderText = "Ordem"
        Me.Ordem.Name = "Ordem"
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'CadastroAtividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAtividade)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CadastroAtividade"
        Me.Text = "Cadastro de Atividades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents imbLimpar As ToolStripButton
    Friend WithEvents imbSalvar As ToolStripButton
    Friend WithEvents imbExcluir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdAtividade As DataGridView
    Friend WithEvents txtAtividade As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ordem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
