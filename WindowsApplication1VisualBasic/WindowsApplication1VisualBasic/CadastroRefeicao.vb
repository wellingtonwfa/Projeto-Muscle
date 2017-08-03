Public Class CadastroRefeicao
    Dim intIdRefeicao As Integer

    Private Sub CadastroRefeicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()

        'Dim sql = "SELECT IdTipoRefeicao,1 as ordem, NomeRefeicao FROM muscle.tb_tiporefeicao"
        Dim sql = "SELECT IdTipoRefeicao,@contador := @contador + 1 AS linha, NomeRefeicao FROM (SELECT @contador := 0) AS nada, muscle.tb_tiporefeicao"

        Dim dt As DataTable = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataTable)

        Me.grdRefeicao.DataSource = dt

    End Sub

    Private Sub imbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strRefeicao As String = ""
        Dim sql As String = ""

        strRefeicao = RTrim(Me.txtRefeicao.Text)

        If strRefeicao = "" Then
            MessageBox.Show("Informe o nome da Refeição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If intIdRefeicao = 0 Then

            For Each dtObjetvo As DataGridViewRow In grdRefeicao.Rows
                If dtObjetvo.Cells(1).Value = strRefeicao Then
                    MessageBox.Show("Esse Refeição já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            sql = "insert tb_tiporefeicao(NomeRefeicao) values('" + strRefeicao + "')"
        Else

            sql = "update muscle.tb_tiporefeicao set NomeRefeicao = '" + strRefeicao + "' where IdTipoRefeicao = " + CStr(intIdRefeicao)

        End If

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()


    End Sub

    Private Sub imbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()

        intIdRefeicao = 0
        Me.txtRefeicao.Text = ""
        BuscaDados()

    End Sub

    Private Sub imbExcluir_Click(sender As Object, e As EventArgs) Handles imbExcluir.Click
        Excluir()
    End Sub
    Private Sub Excluir()
        Dim sql As String = ""

        If intIdRefeicao = 0 Then
            MessageBox.Show("Selecione um Alimento na grid!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        sql = "delete from muscle.tb_tiporefeicao where IdTipoRefeicao = " + CStr(intIdRefeicao)

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()


    End Sub

    Private Sub grdRefeicao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRefeicao.CellContentClick

        intIdRefeicao = grdRefeicao.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.txtRefeicao.Text = grdRefeicao.Rows(e.RowIndex).Cells(1).Value.ToString()

    End Sub
End Class