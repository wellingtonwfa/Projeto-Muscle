Imports System
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim MDIForm As New Form

        FormMDI.Show()
        MDIForm.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()

    End Sub
    Private Sub Salvar()
        Dim conn As New MySqlConnection
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim dr As MySqlDataReader
        Dim SQL As String
        Dim objDados As Object

        conn.ConnectionString = "server=localhost;user id=root;password=root;database=muscle"
        SQL = "insert into tb_Pessoas(NomePessoa,CPF,Data_Nascimento,Sexo,Estado_Civil,Profissao,Logradouro,Cidade,Estado) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','M','SOLTEIRO',NULL,NULL,NULL,NULL)"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DataGridView1.DataSource = myData
                objDados = myData
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            'MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CadastroCliente.Show()
        'BuscaDados()
        BuscaDados2()
    End Sub
    Private Sub BuscaDados2()
        'Dim sql = "SELECT * FROM Produtos WHERE (Codigo = " & Convert.ToInt32(txtCodigo.Text) & ")"
        Dim sql = "SELECT * FROM muscle.tb_Pessoas WHERE CPF = 00259923176"

        Dim dt As DataTable = DAL.AcessoBD.ExecutarComando(sql, CommandType.Text, Nothing, DAL.AcessoBD.TipoDeComando.ExecuteDataTable)

        'txtDescricao.Text = dt.Rows(0).Item("Descricao").ToString()
        TextBox1.Text = dt.Rows(0).Item("NomePessoa").ToString()
        TextBox2.Text = dt.Rows(0).Item("CPF").ToString
        TextBox3.Text = dt.Rows(0).Item("DataInclusao").ToString

    End Sub
    Private Sub BuscaDados()
        Dim conn As New MySqlConnection
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim dr As MySqlDataReader
        Dim SQL As String
        Dim objDados As Object

        'conn.ConnectionString = "server=127.0.0.1;user id=root;password='root';database=muscle"
        conn.ConnectionString = "server=localhost;user id=ConectLocal;password=123456;database=muscle"
        SQL = "SELECT * FROM muscle.tb_Pessoas WHERE CPF = 00259923176"
        'ExecutaDataTable(SQL)

        Try

            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DataGridView1.DataSource = myData
                objDados = myData
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            'MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

        'Try
        '    conn.Open()

        '    Dim str As String

        '    str = "SELECT * FROM muscle.tb_Pessoas WHERE CPF = 00259923176"

        '    Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
        '    dr = cmd.ExecuteReader

        '    While dr.Read()
        '        TextBox1.Text = dr("NomePessoa").ToString
        '        TextBox2.Text = dr("CPF").ToString
        '        TextBox3.Text = dr("DataInclusao").ToString
        '    End While

        '    conn.Close()
        'Catch myerro As Exception
        '    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        'Finally
        '    conn.Dispose()
        'End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssisregisterDataSet.tb_pessoa' table. You can move, or remove it, as needed.
        Me.Tb_pessoaTableAdapter.Fill(Me.AssisregisterDataSet.tb_pessoa)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Imports MySql.Data.MySqlClient

    'Imports System.Data.DataSet



    Public Class ConexaoMySql

        Private mConexao As New MySqlConnection

        Private mComando As New MySqlCommand

        Private mDataAdap As New MySqlDataAdapter

        Private mDataRead As MySqlDataReader



        Private usuarioServidor As String

        Private usuarioBancoDeDados As String

        Private usuarioLogin As String

        Private usuarioSenha As String



        Public Property ServidorUs() As String

            Get

                Return usuarioServidor

            End Get

            Set(ByVal value As String)

                usuarioServidor = value

            End Set

        End Property



        Public Property BancoDeDadosUs() As String

            Get

                Return usuarioBancoDeDados

            End Get

            Set(ByVal value As String)

                usuarioBancoDeDados = value

            End Set

        End Property



        Public Property LoginUs() As String

            Get

                Return usuarioLogin

            End Get

            Set(ByVal value As String)

                usuarioLogin = value

            End Set

        End Property



        Public Property SenhaUs() As String

            Get

                Return usuarioSenha

            End Get

            Set(ByVal value As String)

                usuarioSenha = value

            End Set

        End Property



        Sub New(ByVal servidor As String, ByVal usuario As String, ByVal senha As String, ByVal bancoDeDados As String)

            ServidorUs = servidor

            LoginUs = usuario

            SenhaUs = senha

            BancoDeDadosUs = bancoDeDados

        End Sub



        Public Sub ConectarMySql()

            If Not mConexao.State = ConnectionState.Open Then

                Dim strConexao As String = "Data Source=" + ServidorUs + ";user id=" + LoginUs + ";password=" + SenhaUs + "; database=" + BancoDeDadosUs

                mConexao = New MySqlConnection()

                mConexao.ConnectionString = strConexao

                mConexao.Open()

            End If

        End Sub



        Public Sub DesconectarMySql()

            If mConexao.State = ConnectionState.Open Then

                mConexao.Close()

                mConexao.Dispose()

                mConexao = Nothing

            End If

        End Sub



        Public Function ExecutaDataTable(ByVal sql As String) As DataTable

            Dim mDataTable As New DataTable

            Try

                ConectarMySql()

                mComando.CommandType = CommandType.Text

                mComando.CommandText = sql

                mComando.Connection = mConexao

                mDataAdap.SelectCommand = mComando

                mDataAdap.Fill(mDataTable)

                mDataAdap.Dispose()

                Return mDataTable

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            Return mDataTable

        End Function



        Public Function ExecutaDataRead(ByVal sql As String) As MySqlDataReader

            mDataRead = Nothing

            Try

                ConectarMySql()

                mComando.CommandType = CommandType.Text

                mComando.CommandText = sql

                mComando.Connection = mConexao

                mDataRead = mComando.ExecuteReader()

                mComando.Dispose()

                Return mDataRead

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            Return mDataRead

        End Function



        Public Function ExecutaQuery(ByVal sql As String) As MySqlCommand

            Try

                ConectarMySql()

                mComando.CommandType = CommandType.Text

                mComando.CommandText = sql

                mComando.Connection = mConexao

                Return mComando

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            Return mComando

        End Function

    End Class
End Class
