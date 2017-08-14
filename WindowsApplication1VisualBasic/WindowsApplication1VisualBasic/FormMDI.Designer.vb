<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaDeAlimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeRefeiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeObjetivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeAtividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.NomeCliente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvaliaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.AvaliaçãoToolStripMenuItem, Me.DietaToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabelaDeAlimentoToolStripMenuItem, Me.TipoDeRefeiçãoToolStripMenuItem, Me.CadastroDeObjetivosToolStripMenuItem, Me.CadastroDeAtividadesToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 20)
        Me.ToolStripMenuItem2.Text = "Manutenção"
        '
        'TabelaDeAlimentoToolStripMenuItem
        '
        Me.TabelaDeAlimentoToolStripMenuItem.Name = "TabelaDeAlimentoToolStripMenuItem"
        Me.TabelaDeAlimentoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TabelaDeAlimentoToolStripMenuItem.Text = "Tabela de Alimentos"
        '
        'TipoDeRefeiçãoToolStripMenuItem
        '
        Me.TipoDeRefeiçãoToolStripMenuItem.Name = "TipoDeRefeiçãoToolStripMenuItem"
        Me.TipoDeRefeiçãoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TipoDeRefeiçãoToolStripMenuItem.Text = "Tipo de Refeição"
        '
        'CadastroDeObjetivosToolStripMenuItem
        '
        Me.CadastroDeObjetivosToolStripMenuItem.Name = "CadastroDeObjetivosToolStripMenuItem"
        Me.CadastroDeObjetivosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CadastroDeObjetivosToolStripMenuItem.Text = "Cadastro de Objetivos"
        '
        'CadastroDeAtividadesToolStripMenuItem
        '
        Me.CadastroDeAtividadesToolStripMenuItem.Name = "CadastroDeAtividadesToolStripMenuItem"
        Me.CadastroDeAtividadesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CadastroDeAtividadesToolStripMenuItem.Text = "Cadastro de Atividades"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(38, 20)
        Me.ToolStripMenuItem3.Text = "Sair"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeCliente})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(963, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NomeCliente
        '
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.Size = New System.Drawing.Size(77, 17)
        Me.NomeCliente.Text = "NomeCliente"
        Me.NomeCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'AvaliaçãoToolStripMenuItem
        '
        Me.AvaliaçãoToolStripMenuItem.Name = "AvaliaçãoToolStripMenuItem"
        Me.AvaliaçãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AvaliaçãoToolStripMenuItem.Text = "Avaliação"
        '
        'DietaToolStripMenuItem
        '
        Me.DietaToolStripMenuItem.Name = "DietaToolStripMenuItem"
        Me.DietaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DietaToolStripMenuItem.Text = "Dieta"
        '
        'SAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.IsMdiContainer = True
        Me.Name = "SAN"
        Me.Text = "SAN - Sistema de Acompanhamento Nutricional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NomeCliente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabelaDeAlimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeRefeiçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeObjetivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeAtividadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvaliaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DietaToolStripMenuItem As ToolStripMenuItem
End Class
