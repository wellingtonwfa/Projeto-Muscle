Public Class CadastroObjetivo

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Salvar()
    End Sub
    Private Sub Salvar()
        Dim strObjetivo As String = ""

        strObjetivo = RTrim(Me.TextBox1.Text)

        For Each dtObjetvo As DataGridViewRow In grdObjetivo.Rows
            If dtObjetvo.Cells(0).Value = strObjetivo Then
                MessageBox.Show("Já existe esse Objetivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next

        Dim sql = "insert tb_objetivos(NomeObjetivo) values('" + strObjetivo + "')"

        Dim dt As Boolean = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteReader)

        BuscaDados()
    End Sub
    Private Sub CadastroObjetivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuscaDados()
    End Sub
    Private Sub BuscaDados()

        Dim sql = "SELECT NomeObjetivo FROM muscle.tb_objetivos"

        Dim dt As DataTable = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataTable)

        grdObjetivo.DataSource = dt
    End Sub

    Private Sub grdObjetivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdObjetivo.CellContentClick
        SelecionaObjetivo()
    End Sub
    Private Sub SelecionaObjetivo()

        'TextBox1.Text = grdObjetivo.Rows(0).Cells(0).Value.ToString
        TextBox1.Text = grdObjetivo.SelectedRows(0).Cells(0).Value.ToString()
    End Sub
End Class