Public Class SAN

    Private Sub CadastroDeObjetivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeObjetivosToolStripMenuItem.Click
        Dim NewMDIFilho As New CadastroObjetivo()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        'sair
    End Sub

    Private Sub TabelaDeAlimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelaDeAlimentoToolStripMenuItem.Click
        Dim NewMDIFilho As New CadastroAlimento()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
    End Sub

    Private Sub TipoDeRefeiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeRefeiçãoToolStripMenuItem.Click
        Dim NewMDIFilho As New CadastroRefeicao()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
    End Sub

    Private Sub CadastroDeAtividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAtividadesToolStripMenuItem.Click
        Dim NewMDIFilho As New CadastroAtividade()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Dim NewMDIFilho As New CadastroCliente()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
        'My.Forms.CadastroCliente.Show()
        'CadastroCliente.Show()
    End Sub
End Class