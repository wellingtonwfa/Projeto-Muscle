Public Class CadastroAtividade
    Dim intIdAtividade As Integer

    Private Sub CadastroAtividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BuscarDados()

    End Sub

    Private Sub ImbExcluir_Click(sender As Object, e As EventArgs) Handles imbExcluir.Click
        Excluir()
    End Sub
    Private Sub Excluir()

    End Sub

    Private Sub ImbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()

    End Sub

    Private Sub ImbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()

        Me.txtAtividade.Text = ""
    End Sub
End Class