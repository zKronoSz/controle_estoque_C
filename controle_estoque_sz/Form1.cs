using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace controle_estoque_sz
{

    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Controle_estoque"].ConnectionString;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {

            // fazendo a conexao do banco // para jogar no data grid 
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    //vai dar uma olhada lá no banco, ver oque caralhos tem lá
                    string query = "SELECT Codigo, Descricao, Quantidade, Valor FROM Produtos";

                    //metodo para execultar a consulta 
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conexao);
                    DataTable dataTable = new DataTable();

                    //preenche o dataTable
                    dataAdapter.Fill(dataTable);

                    //preenche o dataGrid com os dados do dataTable
                    dataGridView1.DataSource = dataTable;

                    //limpar selecao inicial
                    dataGridView1.ClearSelection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("deu certo não, tome no C#, Erro ao carregar dados:" + ex.Message);
                }
                finally
                {

                    //so pra garatir que ela vai fechar 
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
        }//dataGrid tudo ok, eu acho !!!
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Grafico formGrafico = new Grafico();
            formGrafico.ShowDialog(); //chamar o form do grafico
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                MessageBox.Show("Informe primeiro o Código que deseja excluir","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);   
                return;
            }

            int codigo;

            if(!int.TryParse(txt_codigo.Text, out codigo))
            {

                MessageBox.Show("Código inválido. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string query = "DELETE FROM Produtos WHERE Codigo = @Codigo";

                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);


                    //mesma coisa do outro
                    int coisaQueMudo = comando.ExecuteNonQuery();
                    CarregarDados();
                    //mander o texto limpo depois de add
                    txt_codigo.Text = "";
                    txt_quantidade.Text = "";
                    txt_descricao.Text = "";
                    txt_valor.Text = "";


                }
            }

       }
        
        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // mudar o nome dessa porra aqui dps
        }

        private void mENuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_descricao_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // eu fiz um metodo chamado "carregar" para ficar mais organizado 
            //obs: se o metodo do "carregar" estiver sendo executado aqui o botao exibir se torna inutio 
            CarregarDados();
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void lbl_codigo_grupo_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //sim codico kkkkkk, é porque ja tinha muito txt...codigo, eu comecei a confundir ai botei codico kkkk
            if (string.IsNullOrWhiteSpace(txt_codico_grupo.Text))
            {
                MessageBox.Show("Digite um Código valido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigo;
            // para ele pegar os dois parâmetros 
            // o tryParse e so pra validar os tipos 
            if (!int.TryParse(txt_codico_grupo.Text, out codigo))
            {
                MessageBox.Show("Código inválido. Digite apenas números.");
                return;
            }

            try
            {
                // conecta a o banco minino
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT Descricao, Quantidade, Valor FROM Produtos WHERE Codigo = @Codigo";
                    ///////////////////////////////

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Codigo", codigo);

                        using (MySqlDataReader carreReader = comando.ExecuteReader())
                        {
                            if (carreReader.Read())
                            {
                                // Preenche os campos com os dados encontrados
                                txt_descricaoGrande.Text = carreReader["Descricao"].ToString();
                                txt_quantidade_grupo.Text = carreReader["Quantidade"].ToString();
                                txt_valor_grupo.Text = carreReader["Valor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum item encontrado com o Código fornecido", "ERRO");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO ao buscar o item: {ex.Message}", "ERRO");
            }

        }

        private void txt_codico_grupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_valor_grupo_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_grupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_valor_grupo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_novo_Click(object sender, EventArgs e)
        {

            //add // so pra ver se esta limpo 
            if (string.IsNullOrWhiteSpace(txt_codigo.Text) ||
                string.IsNullOrWhiteSpace(txt_descricao.Text) ||
                string.IsNullOrWhiteSpace(txt_quantidade.Text) ||
                string.IsNullOrWhiteSpace(txt_valor.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                return;
            }

            string query = "INSERT INTO Produtos (Codigo, Descricao, Quantidade, Valor) VALUES (@Codigo, @Descricao, @Quantidade, @Valor)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", txt_codigo.Text);
                    cmd.Parameters.AddWithValue("@Descricao", txt_descricao.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", txt_quantidade.Text);
                    cmd.Parameters.AddWithValue("@Valor", txt_valor.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com sucesso!");

                    //LimparCampos();
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
                }
                //mander o texto limpo depois de add
                txt_codigo.Text = "";
                txt_quantidade.Text = "";
                txt_descricao.Text = "";
                txt_valor.Text = "";


            }
        }//final do using, logo depois o try

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descricaoGrande_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_codico_grupo.Text) ||
                string.IsNullOrWhiteSpace(txt_descricaoGrande.Text) ||
                string.IsNullOrWhiteSpace(txt_quantidade_grupo.Text) ||
                string.IsNullOrWhiteSpace(txt_valor_grupo.Text))
            {
                MessageBox.Show("Os campos estão vazios, seu corno!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Declaração de variáveis para conversão
            int codico;
            int quantidade;
            decimal valor;

            // Validação e conversão de valores
            if (!int.TryParse(txt_codico_grupo.Text, out codico))
            {
                MessageBox.Show("Código inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txt_quantidade_grupo.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txt_valor_grupo.Text, out valor))
            {
                MessageBox.Show("Valor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    // Comando SQL para atualizar o registro
                    string query = "UPDATE Produtos SET Descricao = @Descricao, Quantidade = @Quantidade, Valor = @Valor WHERE Codigo = @Codigo";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        
                        comando.Parameters.AddWithValue("@Codigo", codico); 
                        comando.Parameters.AddWithValue("@Descricao", txt_descricaoGrande.Text);
                        comando.Parameters.AddWithValue("@Quantidade", quantidade);
                        comando.Parameters.AddWithValue("@Valor", valor); 

                        // Executando o comando SQL
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            CarregarDados();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi alterado. Verifique o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_codico_grupo.Text = "";
            txt_quantidade_grupo.Text = "";
            txt_descricaoGrande.Text = "";
            txt_valor_grupo.Text = "";
        }
    }
}


//obs:
/*
 *no bagulho de limpar da pra fazer um metodo , se voce tiver coragem faça se não tome no cu .ASS:Eu do passado
 */