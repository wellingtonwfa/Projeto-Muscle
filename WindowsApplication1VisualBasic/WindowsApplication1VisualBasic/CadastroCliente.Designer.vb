<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastroCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.imbLimpar = New System.Windows.Forms.ToolStripButton()
        Me.imbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.imbPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grbContato = New System.Windows.Forms.GroupBox()
        Me.txt2Celular = New System.Windows.Forms.TextBox()
        Me.lbl2Celular = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txt1Celular = New System.Windows.Forms.TextBox()
        Me.lbl1Celuar = New System.Windows.Forms.Label()
        Me.txtProfissao = New System.Windows.Forms.TextBox()
        Me.lblProfissao = New System.Windows.Forms.Label()
        Me.rdbFeminino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.txtDataNasc = New System.Windows.Forms.TextBox()
        Me.lblDataNasc = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbContato.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imbLimpar, Me.imbSalvar, Me.imbPesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(477, 39)
        Me.ToolStrip1.TabIndex = 8
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
        Me.imbSalvar.AccessibleDescription = "Salvar"
        Me.imbSalvar.AccessibleName = "Salvar"
        Me.imbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.imbSalvar.Image = CType(resources.GetObject("imbSalvar.Image"), System.Drawing.Image)
        Me.imbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imbSalvar.Name = "imbSalvar"
        Me.imbSalvar.Size = New System.Drawing.Size(36, 36)
        Me.imbSalvar.Text = "Salvar"
        '
        'imbPesquisar
        '
        Me.imbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.imbPesquisar.Image = CType(resources.GetObject("imbPesquisar.Image"), System.Drawing.Image)
        Me.imbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imbPesquisar.Name = "imbPesquisar"
        Me.imbPesquisar.Size = New System.Drawing.Size(36, 36)
        Me.imbPesquisar.Text = "Pesquisar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.grbContato)
        Me.Panel1.Controls.Add(Me.txtProfissao)
        Me.Panel1.Controls.Add(Me.lblProfissao)
        Me.Panel1.Controls.Add(Me.rdbFeminino)
        Me.Panel1.Controls.Add(Me.rdbMasculino)
        Me.Panel1.Controls.Add(Me.lblSexo)
        Me.Panel1.Controls.Add(Me.cboEstadoCivil)
        Me.Panel1.Controls.Add(Me.lblEstadoCivil)
        Me.Panel1.Controls.Add(Me.txtDataNasc)
        Me.Panel1.Controls.Add(Me.lblDataNasc)
        Me.Panel1.Controls.Add(Me.txtCPF)
        Me.Panel1.Controls.Add(Me.lblCPF)
        Me.Panel1.Controls.Add(Me.txtNomeCliente)
        Me.Panel1.Controls.Add(Me.lblNomeCliente)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 441)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.lblComplemento)
        Me.GroupBox1.Controls.Add(Me.txtRua)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCEP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 113)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endereços"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(370, 80)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(37, 21)
        Me.txtEstado.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Estado"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(172, 80)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(192, 21)
        Me.txtCidade.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Cidade"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(7, 80)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(159, 21)
        Me.txtComplemento.TabIndex = 23
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(5, 64)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(82, 13)
        Me.lblComplemento.TabIndex = 22
        Me.lblComplemento.Text = "Complemento"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(94, 36)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(319, 21)
        Me.txtRua.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Rua"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(6, 36)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(81, 21)
        Me.txtCEP.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "CEP"
        '
        'grbContato
        '
        Me.grbContato.Controls.Add(Me.txt2Celular)
        Me.grbContato.Controls.Add(Me.lbl2Celular)
        Me.grbContato.Controls.Add(Me.txtEmail)
        Me.grbContato.Controls.Add(Me.lblEmail)
        Me.grbContato.Controls.Add(Me.txt1Celular)
        Me.grbContato.Controls.Add(Me.lbl1Celuar)
        Me.grbContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbContato.Location = New System.Drawing.Point(7, 147)
        Me.grbContato.Name = "grbContato"
        Me.grbContato.Size = New System.Drawing.Size(419, 113)
        Me.grbContato.TabIndex = 27
        Me.grbContato.TabStop = False
        Me.grbContato.Text = "Contatos"
        '
        'txt2Celular
        '
        Me.txt2Celular.Location = New System.Drawing.Point(7, 80)
        Me.txt2Celular.Name = "txt2Celular"
        Me.txt2Celular.Size = New System.Drawing.Size(121, 21)
        Me.txt2Celular.TabIndex = 23
        '
        'lbl2Celular
        '
        Me.lbl2Celular.AutoSize = True
        Me.lbl2Celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Celular.Location = New System.Drawing.Point(5, 64)
        Me.lbl2Celular.Name = "lbl2Celular"
        Me.lbl2Celular.Size = New System.Drawing.Size(62, 13)
        Me.lbl2Celular.TabIndex = 22
        Me.lbl2Celular.Text = "2º Celular"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 36)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 21)
        Me.txtEmail.TabIndex = 21
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(131, 20)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "Email"
        '
        'txt1Celular
        '
        Me.txt1Celular.Location = New System.Drawing.Point(6, 36)
        Me.txt1Celular.Name = "txt1Celular"
        Me.txt1Celular.Size = New System.Drawing.Size(121, 21)
        Me.txt1Celular.TabIndex = 19
        '
        'lbl1Celuar
        '
        Me.lbl1Celuar.AutoSize = True
        Me.lbl1Celuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Celuar.Location = New System.Drawing.Point(4, 20)
        Me.lbl1Celuar.Name = "lbl1Celuar"
        Me.lbl1Celuar.Size = New System.Drawing.Size(62, 13)
        Me.lbl1Celuar.TabIndex = 18
        Me.lbl1Celuar.Text = "1º Celular"
        '
        'txtProfissao
        '
        Me.txtProfissao.Location = New System.Drawing.Point(7, 112)
        Me.txtProfissao.Name = "txtProfissao"
        Me.txtProfissao.Size = New System.Drawing.Size(419, 20)
        Me.txtProfissao.TabIndex = 26
        '
        'lblProfissao
        '
        Me.lblProfissao.AutoSize = True
        Me.lblProfissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfissao.Location = New System.Drawing.Point(5, 96)
        Me.lblProfissao.Name = "lblProfissao"
        Me.lblProfissao.Size = New System.Drawing.Size(59, 13)
        Me.lblProfissao.TabIndex = 25
        Me.lblProfissao.Text = "Profissão"
        '
        'rdbFeminino
        '
        Me.rdbFeminino.AutoSize = True
        Me.rdbFeminino.Location = New System.Drawing.Point(225, 68)
        Me.rdbFeminino.Name = "rdbFeminino"
        Me.rdbFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rdbFeminino.TabIndex = 24
        Me.rdbFeminino.TabStop = True
        Me.rdbFeminino.Text = "Feminino"
        Me.rdbFeminino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(153, 68)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 23
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(151, 52)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(35, 13)
        Me.lblSexo.TabIndex = 22
        Me.lblSexo.Text = "Sexo"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(306, 68)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoCivil.TabIndex = 21
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(303, 52)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(74, 13)
        Me.lblEstadoCivil.TabIndex = 20
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Location = New System.Drawing.Point(6, 68)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(121, 20)
        Me.txtDataNasc.TabIndex = 17
        '
        'lblDataNasc
        '
        Me.lblDataNasc.AutoSize = True
        Me.lblDataNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataNasc.Location = New System.Drawing.Point(4, 52)
        Me.lblDataNasc.Name = "lblDataNasc"
        Me.lblDataNasc.Size = New System.Drawing.Size(122, 13)
        Me.lblDataNasc.TabIndex = 16
        Me.lblDataNasc.Text = "Data de Nascimento"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(288, 24)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(140, 20)
        Me.txtCPF.TabIndex = 15
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(287, 8)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 14
        Me.lblCPF.Text = "CPF"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(6, 24)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(276, 20)
        Me.txtNomeCliente.TabIndex = 13
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.AutoSize = True
        Me.lblNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeCliente.Location = New System.Drawing.Point(3, 8)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblNomeCliente.TabIndex = 12
        Me.lblNomeCliente.Text = "Nome"
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CadastroCliente"
        Me.Text = "Cadastro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbContato.ResumeLayout(False)
        Me.grbContato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents imbLimpar As ToolStripButton
    Friend WithEvents imbPesquisar As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDataNasc As TextBox
    Friend WithEvents lblDataNasc As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents txtProfissao As TextBox
    Friend WithEvents lblProfissao As Label
    Friend WithEvents rdbFeminino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents lblSexo As Label
    Friend WithEvents imbSalvar As ToolStripButton
    Friend WithEvents grbContato As GroupBox
    Friend WithEvents txt2Celular As TextBox
    Friend WithEvents lbl2Celular As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txt1Celular As TextBox
    Friend WithEvents lbl1Celuar As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label3 As Label
End Class
