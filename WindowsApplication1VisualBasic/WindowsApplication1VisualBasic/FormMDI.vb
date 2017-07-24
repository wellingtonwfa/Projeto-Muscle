Public Class FormMDI

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
End Class