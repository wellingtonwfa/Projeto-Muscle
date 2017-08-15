Public Class CadastroAlimento
    Dim intIdAlimento As Integer

    Private Sub CadastroAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()
        Dim intCount2 As Integer = 1

        Try
            Dim sql = "SELECT IdAlimento, NomeAlimento FROM muscle.tb_alimentos"

            Dim dt As Object = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

            For intCount As Integer = dt.Tables(0).Rows.Count - 1 To 0 Step -1
                Me.grdAlimento.Rows.Add(dt.Tables(0).Rows(intCount)("IdAlimento"), intCount2, dt.Tables(0).Rows(intCount)("NomeAlimento"))
                intCount2 = intCount2 + 1
            Next

            'grdAlimento.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub ImbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()

        intIdAlimento = 0
        Me.txtAlimento.Text = ""
        Me.txtNomeAlimentoPesq.Text = ""
        Me.txtQtdeCarboidr.Text = Nothing
        Me.txtQtdeLipideos.Text = Nothing
        Me.txtQtdeProteina.Text = Nothing
        BuscaDados()

    End Sub

    Private Sub ImbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strAlimento As String = ""
        Dim sql As String = ""

        strAlimento = RTrim(Me.txtAlimento.Text)

        If strAlimento = "" Then
            MessageBox.Show("Informe o nome do Alimento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If intIdAlimento = 0 Then

            For Each dtObjetvo As DataGridViewRow In grdAlimento.Rows
                If dtObjetvo.Cells(1).Value = strAlimento Then
                    MessageBox.Show("Esse Alimento já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            sql = "insert tb_alimentos(NomeAlimento) values('" + strAlimento + "')"
        Else

            sql = "update muscle.tb_alimentos set NomeAlimento = '" + strAlimento + "' where IdAlimento = " + CStr(intIdAlimento)

        End If

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()

    End Sub

    Private Sub ImbExcluir_Click(sender As Object, e As EventArgs) Handles imbExcluir.Click
        Excluir()
    End Sub
    Private Sub Excluir()
        Dim sql As String = ""

        If intIdAlimento = 0 Then
            MessageBox.Show("Selecione um Alimento na grid!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        sql = "delete from muscle.tb_alimentos where IdAlimento = " + CStr(intIdAlimento)

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()

    End Sub

    Private Sub grdAlimento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAlimento.CellContentClick

        intIdAlimento = grdAlimento.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.txtAlimento.Text = grdAlimento.Rows(e.RowIndex).Cells(1).Value.ToString()

    End Sub
End Class