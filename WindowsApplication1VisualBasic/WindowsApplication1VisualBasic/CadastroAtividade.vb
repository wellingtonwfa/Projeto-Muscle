Public Class CadastroAtividade
    Dim intIdAtividade As Integer

    Private Sub CadastroAtividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarDados()
    End Sub
    Private Sub BuscarDados()

        Dim sql = "SELECT IdAtividade, Nome FROM muscle.tb_atividades"

        Dim dt As DataTable = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataTable)

        grdAtividade.DataSource = dt
    End Sub

    Private Sub ImbExcluir_Click(sender As Object, e As EventArgs) Handles imbExcluir.Click
        Excluir()
    End Sub
    Private Sub Excluir()
        Dim sql As String = ""

        If intIdAtividade = 0 Then
            MessageBox.Show("Selecione uma Atividade na grid!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        sql = "delete from muscle.tb_atividades where IdAtividade = " + CStr(intIdAtividade)

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()
    End Sub

    Private Sub ImbSalvar_Click(sender As Object, e As EventArgs) Handles imbSalvar.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strAtividade As String = ""
        Dim sql As String = ""

        strAtividade = RTrim(Me.txtAtividade.Text)

        If strAtividade = "" Then
            MessageBox.Show("Informe uma Atividade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If intIdAtividade = 0 Then

            For Each dtObjetvo As DataGridViewRow In grdAtividade.Rows
                If dtObjetvo.Cells(1).Value = strAtividade Then
                    MessageBox.Show("Já existe essa Atividade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            sql = "insert tb_atividades(Nome) values('" + strAtividade + "')"
        Else

            sql = "update muscle.tb_atividades set Nome = '" + strAtividade + "' where IdAtividade = " + CStr(intIdAtividade)

        End If

        Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        Limpar()
    End Sub

    Private Sub ImbLimpar_Click(sender As Object, e As EventArgs) Handles imbLimpar.Click
        Limpar()
    End Sub
    Private Sub Limpar()

        Me.txtAtividade.Text = ""
        intIdAtividade = 0
        BuscarDados()

    End Sub

    Private Sub grdAtividade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAtividade.CellContentClick

        intIdAtividade = grdAtividade.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.txtAtividade.Text = grdAtividade.Rows(e.RowIndex).Cells(1).Value.ToString()

    End Sub
End Class