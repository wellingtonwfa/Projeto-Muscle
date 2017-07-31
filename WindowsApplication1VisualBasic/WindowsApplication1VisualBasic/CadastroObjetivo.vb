Public Class CadastroObjetivo

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim strObjetivo As String = ""

        strObjetivo = Me.TextBox1.Text
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
End Class