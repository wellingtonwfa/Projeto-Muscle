Public Class CadastroAtividade
    Dim intIdAtividade As Integer

    Private Sub CadastroAtividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarDados()
    End Sub
    Private Sub BuscarDados()

        Dim sql = "SELECT IdAtividade, Nome FROM muscle.tb_atividades"

        Dim dt As Object = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

        'grdAtividade.DataSource = dt
        Try
            Me.grdAtividade.DataSource = Nothing
            Dim intCount As Integer = 1
            For i As Integer = dt.Tables(0).Rows.Count - 1 To 0 Step -1
                Me.grdAtividade.Rows.Add(dt.Tables(0).Rows(i)("IdAtividade"), intCount, dt.Tables(0).Rows(i)("Nome"))

                intCount = intCount + 1
                'With grdAtividade.Rows 'with significa com e substitui variavel a frente dele
                '    .Add(dt.Tables(0).Rows(i)("IdAtividade"), i, dt.Tables(0).Rows(i)("Nome"))
                '    '.Add(i)
                '    '.Add(dt.Tables(0).Rows(i)("Nome"))
                '    'numero refere-se as posições dos campos
                'End With
            Next

            With grdAtividade
                With .Columns
                    .Item(1).Width = 50 : .Item(1).Visible = True
                    .Item(2).Width = 500 : .Item(2).Visible = True
                End With
            End With

            'Me.grdAtividade.Columns(2).DefaultCellStyle.Format = "330"
            'Me.grdAtividade.Columns(3).HeaderCell. = "530"

            'With Me.grdAtividade
            '    .Width = 230
            'End With

        Catch ex As Exception

        End Try

        'For Each dados As Object In dt.TableName
        '    Me.grdAtividade.Rows.Add(dados.Item("IdAtividade"), dados.Item("Nome"))
        '    'Me.grdAtividade.Rows.Add(dados.Item("IdAtividade").ToString(), dados.Rows(0).Item("Nome").ToString())
        'Next

        'dt.Rows(0).Item("NomePessoa").ToString()


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
                If dtObjetvo.Cells(2).Value = strAtividade Then
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