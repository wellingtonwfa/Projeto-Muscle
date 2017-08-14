Public Class CadastroObjetivo
    Dim intIdObjetivo As Integer

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strObjetivo As String = ""
        Dim sql As String = ""
        Dim strAcao As String = ""

        strObjetivo = RTrim(Me.TextBox1.Text)

        If strObjetivo = "" Then
            MessageBox.Show("Informe um Objetivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Try
            If intIdObjetivo = 0 Then

                For Each dtObjetvo As DataGridViewRow In grdObjetivo.Rows
                    If dtObjetvo.Cells(1).Value = strObjetivo Then
                        MessageBox.Show("Já existe esse Objetivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next

                sql = "insert tb_objetivos(NomeObjetivo) values('" + strObjetivo + "')"
                strAcao = "criada"
            Else

                sql = "update muscle.tb_objetivos set NomeObjetivo = '" + strObjetivo + "' where idObjetivo = " + CStr(intIdObjetivo)
                strAcao = "alterada"
            End If

            Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)
            
            MessageBox.Show("Objetivo " & strAcao & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Limpar()
    End Sub
    Private Sub CadastroObjetivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()
        Dim intCount2 As Integer = 1

        Try
            Dim sql = "SELECT idObjetivo, NomeObjetivo FROM muscle.tb_objetivos"

            Dim dt As Object = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

            For intCount As Integer = dt.Tables(0).Rows.Count - 1 To 0 Step -1
                Me.grdObjetivo.Rows.Add(dt.Tables(0).Rows(intCount)("idObjetivo"), intCount2, dt.Tables(0).Rows(intCount)("NomeObjetivo"))
                intCount2 = intCount2 + 1
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub grdObjetivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdObjetivo.CellContentClick

        intIdObjetivo = grdObjetivo.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.TextBox1.Text = grdObjetivo.Rows(e.RowIndex).Cells(2).Value.ToString()

    End Sub
    Private Sub Limpar()
        intIdObjetivo = 0
        Me.TextBox1.Text = ""
        Me.grdObjetivo.Rows.Clear()
        BuscaDados()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Limpar()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Excluir()
    End Sub
    Private Sub Excluir()
        Dim sql As String = ""

        If intIdObjetivo = 0 Then
            MessageBox.Show("Selecione um objetivo na grid!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            sql = "delete from muscle.tb_objetivos where idObjetivo = " + CStr(intIdObjetivo)

            Dim dt As DataSet = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataSet)

            MessageBox.Show("Objetivo excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir dados! " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Limpar()
    End Sub
End Class