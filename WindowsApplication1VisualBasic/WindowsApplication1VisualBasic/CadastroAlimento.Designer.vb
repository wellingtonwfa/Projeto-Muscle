<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroAlimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroAlimento))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.imbLimpar = New System.Windows.Forms.ToolStripButton()
        Me.imbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.imbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblCarboidrato = New System.Windows.Forms.Label()
        Me.txtQtdeCarboidr = New System.Windows.Forms.TextBox()
        Me.txtQtdeProteina = New System.Windows.Forms.TextBox()
        Me.lblProteina = New System.Windows.Forms.Label()
        Me.txtQtdeLipideos = New System.Windows.Forms.TextBox()
        Me.lblLipideos = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.lblGramaCarb = New System.Windows.Forms.Label()
        Me.lblGramaProt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPesquisar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grdAlimento = New System.Windows.Forms.DataGridView()
        Me.txtNomeAlimentoPesq = New System.Windows.Forms.TextBox()
        Me.lblNomeAlimentoPesq = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdAlimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imbLimpar, Me.imbSalvar, Me.imbExcluir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(543, 39)
        Me.ToolStrip1.TabIndex = 7
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
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(51, 69)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(299, 20)
        Me.txtAlimento.TabIndex = 11
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(9, 72)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 13)
        Me.lblNome.TabIndex = 10
        Me.lblNome.Text = "Nome:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(354, 72)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(65, 13)
        Me.lblCategoria.TabIndex = 12
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblCarboidrato
        '
        Me.lblCarboidrato.AutoSize = True
        Me.lblCarboidrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarboidrato.Location = New System.Drawing.Point(9, 109)
        Me.lblCarboidrato.Name = "lblCarboidrato"
        Me.lblCarboidrato.Size = New System.Drawing.Size(76, 13)
        Me.lblCarboidrato.TabIndex = 13
        Me.lblCarboidrato.Text = "Carboidrato:"
        '
        'txtQtdeCarboidr
        '
        Me.txtQtdeCarboidr.Location = New System.Drawing.Point(83, 106)
        Me.txtQtdeCarboidr.Name = "txtQtdeCarboidr"
        Me.txtQtdeCarboidr.Size = New System.Drawing.Size(34, 20)
        Me.txtQtdeCarboidr.TabIndex = 14
        '
        'txtQtdeProteina
        '
        Me.txtQtdeProteina.Location = New System.Drawing.Point(198, 106)
        Me.txtQtdeProteina.Name = "txtQtdeProteina"
        Me.txtQtdeProteina.Size = New System.Drawing.Size(33, 20)
        Me.txtQtdeProteina.TabIndex = 16
        '
        'lblProteina
        '
        Me.lblProteina.AutoSize = True
        Me.lblProteina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteina.Location = New System.Drawing.Point(140, 109)
        Me.lblProteina.Name = "lblProteina"
        Me.lblProteina.Size = New System.Drawing.Size(60, 13)
        Me.lblProteina.TabIndex = 15
        Me.lblProteina.Text = "Proteína:"
        '
        'txtQtdeLipideos
        '
        Me.txtQtdeLipideos.Location = New System.Drawing.Point(317, 106)
        Me.txtQtdeLipideos.Name = "txtQtdeLipideos"
        Me.txtQtdeLipideos.Size = New System.Drawing.Size(33, 20)
        Me.txtQtdeLipideos.TabIndex = 18
        '
        'lblLipideos
        '
        Me.lblLipideos.AutoSize = True
        Me.lblLipideos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLipideos.Location = New System.Drawing.Point(260, 109)
        Me.lblLipideos.Name = "lblLipideos"
        Me.lblLipideos.Size = New System.Drawing.Size(60, 13)
        Me.lblLipideos.TabIndex = 17
        Me.lblLipideos.Text = "Lípideos:"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(416, 68)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 19
        '
        'lblGramaCarb
        '
        Me.lblGramaCarb.AutoSize = True
        Me.lblGramaCarb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGramaCarb.Location = New System.Drawing.Point(117, 110)
        Me.lblGramaCarb.Name = "lblGramaCarb"
        Me.lblGramaCarb.Size = New System.Drawing.Size(18, 13)
        Me.lblGramaCarb.TabIndex = 20
        Me.lblGramaCarb.Text = "gr"
        '
        'lblGramaProt
        '
        Me.lblGramaProt.AutoSize = True
        Me.lblGramaProt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGramaProt.Location = New System.Drawing.Point(231, 109)
        Me.lblGramaProt.Name = "lblGramaProt"
        Me.lblGramaProt.Size = New System.Drawing.Size(18, 13)
        Me.lblGramaProt.TabIndex = 21
        Me.lblGramaProt.Text = "gr"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPesquisar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.grdAlimento)
        Me.GroupBox1.Controls.Add(Me.txtNomeAlimentoPesq)
        Me.GroupBox1.Controls.Add(Me.lblNomeAlimentoPesq)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 217)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'lblPesquisar
        '
        Me.lblPesquisar.AutoSize = True
        Me.lblPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisar.Location = New System.Drawing.Point(396, 33)
        Me.lblPesquisar.Name = "lblPesquisar"
        Me.lblPesquisar.Size = New System.Drawing.Size(62, 13)
        Me.lblPesquisar.TabIndex = 16
        Me.lblPesquisar.Text = "Pesquisar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grdAlimento
        '
        Me.grdAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAlimento.Location = New System.Drawing.Point(10, 76)
        Me.grdAlimento.Name = "grdAlimento"
        Me.grdAlimento.Size = New System.Drawing.Size(491, 135)
        Me.grdAlimento.TabIndex = 14
        '
        'txtNomeAlimentoPesq
        '
        Me.txtNomeAlimentoPesq.Location = New System.Drawing.Point(10, 30)
        Me.txtNomeAlimentoPesq.Name = "txtNomeAlimentoPesq"
        Me.txtNomeAlimentoPesq.Size = New System.Drawing.Size(299, 20)
        Me.txtNomeAlimentoPesq.TabIndex = 13
        '
        'lblNomeAlimentoPesq
        '
        Me.lblNomeAlimentoPesq.AutoSize = True
        Me.lblNomeAlimentoPesq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeAlimentoPesq.Location = New System.Drawing.Point(7, 14)
        Me.lblNomeAlimentoPesq.Name = "lblNomeAlimentoPesq"
        Me.lblNomeAlimentoPesq.Size = New System.Drawing.Size(91, 13)
        Me.lblNomeAlimentoPesq.TabIndex = 12
        Me.lblNomeAlimentoPesq.Text = "Nome Alimento"
        '
        'CadastroAlimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGramaProt)
        Me.Controls.Add(Me.lblGramaCarb)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtQtdeLipideos)
        Me.Controls.Add(Me.lblLipideos)
        Me.Controls.Add(Me.txtQtdeProteina)
        Me.Controls.Add(Me.lblProteina)
        Me.Controls.Add(Me.txtQtdeCarboidr)
        Me.Controls.Add(Me.lblCarboidrato)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CadastroAlimento"
        Me.Text = "Cadastro de Alimentos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdAlimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents imbLimpar As ToolStripButton
    Friend WithEvents imbSalvar As ToolStripButton
    Friend WithEvents imbExcluir As ToolStripButton
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblCarboidrato As Label
    Friend WithEvents txtQtdeCarboidr As TextBox
    Friend WithEvents txtQtdeProteina As TextBox
    Friend WithEvents lblProteina As Label
    Friend WithEvents txtQtdeLipideos As TextBox
    Friend WithEvents lblLipideos As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents lblGramaCarb As Label
    Friend WithEvents lblGramaProt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNomeAlimentoPesq As TextBox
    Friend WithEvents lblNomeAlimentoPesq As Label
    Friend WithEvents grdAlimento As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lblPesquisar As Label
End Class
