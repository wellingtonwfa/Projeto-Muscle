Public Class SAN

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim NewMDIFilho As New CadastroCliente()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
        'My.Forms.CadastroCliente.Show()
        'CadastroCliente.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim NewMDIFilho As New CadastroObjetivo()
        NewMDIFilho.MdiParent = Me
        NewMDIFilho.Show()
    End Sub
End Class