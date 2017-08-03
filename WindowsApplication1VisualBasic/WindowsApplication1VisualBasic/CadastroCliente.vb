Public Class CadastroCliente

    Private Sub CadastroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()

    End Sub
    Private Sub imbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()
        Me.txtNomeCliente.Text = ""
        Me.txtCPF.Text = ""
        Me.txtDataNasc.Text = ""
        Me.rdbMasculino.Checked = False
        Me.rdbFeminino.Checked = False
        Me.cboEstadoCivil.SelectedIndex = -1
        Me.txtProfissao.Text = ""
        Me.txt1Celular.Text = ""
        Me.txt2Celular.Text = ""
        Me.txtEmail.Text = ""
        Me.txtCEP.Text = ""
        Me.txtRua.Text = ""
        Me.txtComplemento.Text = ""
        Me.txtCidade.Text = ""
        Me.txtEstado.Text = ""
    End Sub

    Private Sub imbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()

    End Sub

    Private Sub imbPesquisar_Click(sender As Object, e As EventArgs) Handles imbPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub Pesquisar()

    End Sub
End Class