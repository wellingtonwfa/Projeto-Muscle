<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroRefeicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroRefeicao))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.imbLimpar = New System.Windows.Forms.ToolStripButton()
        Me.imbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.imbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.txtRefeicao = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.grdRefeicao = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTipoRefeicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdRefeicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imbLimpar, Me.imbSalvar, Me.imbExcluir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(391, 39)
        Me.ToolStrip1.TabIndex = 6
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
        'txtRefeicao
        '
        Me.txtRefeicao.Location = New System.Drawing.Point(51, 69)
        Me.txtRefeicao.Name = "txtRefeicao"
        Me.txtRefeicao.Size = New System.Drawing.Size(319, 20)
        Me.txtRefeicao.TabIndex = 9
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(9, 72)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 13)
        Me.lblNome.TabIndex = 8
        Me.lblNome.Text = "Nome:"
        '
        'grdRefeicao
        '
        Me.grdRefeicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRefeicao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoRefeicao, Me.Ordem, Me.Nome})
        Me.grdRefeicao.Location = New System.Drawing.Point(6, 19)
        Me.grdRefeicao.Name = "grdRefeicao"
        Me.grdRefeicao.Size = New System.Drawing.Size(352, 135)
        Me.grdRefeicao.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdRefeicao)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 168)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Objetivos"
        '
        'IdTipoRefeicao
        '
        Me.IdTipoRefeicao.HeaderText = "IdTipoRefeicao"
        Me.IdTipoRefeicao.Name = "IdTipoRefeicao"
        Me.IdTipoRefeicao.Visible = False
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
        'CadastroRefeicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRefeicao)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CadastroRefeicao"
        Me.Text = "Cadastro de Refeições"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdRefeicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents imbLimpar As ToolStripButton
    Friend WithEvents imbSalvar As ToolStripButton
    Friend WithEvents imbExcluir As ToolStripButton
    Friend WithEvents txtRefeicao As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents grdRefeicao As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTipoRefeicao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ordem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
