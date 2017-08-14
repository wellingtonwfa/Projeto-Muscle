Public Class CadastroRefeicao
    Dim intIdRefeicao As Integer

    Private Sub CadastroRefeicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()
        Dim intCount2 As Integer = 1

        Try
            Dim sql = "SELECT IdTipoRefeicao, NomeRefeicao FROM muscle.tb_tiporefeicao"

            Dim dt As Object = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

            For intCount As Integer = dt.Tables(0).Rows.Count - 1 To 0 Step -1
                Me.grdRefeicao.Rows.Add(dt.Tables(0).Rows(intCount)("IdTipoRefeicao"), intCount2, dt.Tables(0).Rows(intCount)("NomeRefeicao"))
                intCount2 = intCount2 + 1
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub imbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strRefeicao As String = ""
        Dim sql As String = ""
        Dim strAcao As String = ""

        strRefeicao = RTrim(Me.txtRefeicao.Text)

        If strRefeicao = "" Then
            MessageBox.Show("Informe o nome da Refeição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Try
            If intIdRefeicao = 0 Then

                For Each dtObjetvo As DataGridViewRow In grdRefeicao.Rows
                    If dtObjetvo.Cells(1).Value = strRefeicao Then
                        MessageBox.Show("Essa Refeição já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next

                sql = "insert tb_tiporefeicao(NomeRefeicao) values('" + strRefeicao + "')"
                strAcao = "criada"
            Else

                sql = "update muscle.tb_tiporefeicao set NomeRefeicao = '" + strRefeicao + "' where IdTipoRefeicao = " + CStr(intIdRefeicao)
                strAcao = "alterada"
            End If

            Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

            MessageBox.Show("Refeição " & strAcao & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Limpar()

    End Sub

    Private Sub imbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()

        intIdRefeicao = 0
        Me.txtRefeicao.Text = ""
        Me.grdRefeicao.Rows.Clear()
        BuscaDados()

    End Sub

    Private Sub imbExcluir_Click(sender As Object, e As EventArgs) Handles imbExcluir.Click
        Excluir()
    End Sub
    Private Sub Excluir()
        Dim sql As String = ""

        If intIdRefeicao = 0 Then
            MessageBox.Show("Selecione uma Refeição na grid!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            sql = "delete from muscle.tb_tiporefeicao where IdTipoRefeicao = " + CStr(intIdRefeicao)

            Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)
            
            MessageBox.Show("Refeição excluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Limpar()


    End Sub

    Private Sub grdRefeicao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRefeicao.CellContentClick

        intIdRefeicao = grdRefeicao.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.txtRefeicao.Text = grdRefeicao.Rows(e.RowIndex).Cells(2).Value.ToString()

    End Sub
End Class