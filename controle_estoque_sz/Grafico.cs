using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace controle_estoque_sz
{
    public partial class Grafico : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Controle_estoque"].ConnectionString;
        public Grafico()
        {
            InitializeComponent();
            //chamar o metodo 
            carregarGrafico();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void carregarGrafico()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = "SELECT Descricao, Quantidade, Valor FROM Produtos";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    using (MySqlDataReader carregarReader = comando.ExecuteReader())
                    {
                        // Limpa as áreas e séries do gráfico antes de adicionar novos dados
                        chart1.Series.Clear();
                        chart1.ChartAreas.Clear();

                        // Configura a área do gráfico
                        ChartArea chartArea = new ChartArea("MainArea");
                        chartArea.BackColor = Color.FromArgb(240, 240, 240); // Fundo cinza claro
                        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray; // Linhas de grade
                        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray; // Linhas de grade
                        chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Fonte do eixo X
                        chartArea.AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Fonte do eixo Y
                        chartArea.AxisX.Interval = 1; // Intervalo dos valores do eixo X
                        chartArea.AxisY.LabelStyle.Format = "0"; // Mostra apenas números inteiros no eixo Y
                        chartArea.AxisX.Title = "Produtos";
                        chartArea.AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                        chartArea.AxisY.Title = "Quantidade / Preço";
                        chartArea.AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                        chart1.ChartAreas.Add(chartArea);

                        // Série para Quantidade
                        Series serieQuantidade = new Series("Quantidade");
                        serieQuantidade.ChartType = SeriesChartType.Column; // Coluna para mostrar a quantidade
                        serieQuantidade.Color = Color.FromArgb(70, 130, 180); // Azul
                        serieQuantidade.BorderWidth = 2;
                        serieQuantidade.IsValueShownAsLabel = true;
                        serieQuantidade.Font = new Font("Arial", 10, FontStyle.Bold);
                        serieQuantidade.LabelForeColor = Color.Black;
                        serieQuantidade.CustomProperties = "DrawingStyle=Cylinder"; // Efeito 3D nas colunas

                        chart1.Series.Add(serieQuantidade);

                        // Série para Preço (Agora é uma coluna também)
                        Series seriePreco = new Series("Preço");
                        seriePreco.ChartType = SeriesChartType.Column; // Coluna para mostrar o preço
                        seriePreco.Color = Color.FromArgb(220, 20, 60); // Vermelho
                        seriePreco.BorderWidth = 2;
                        seriePreco.IsValueShownAsLabel = true;
                        seriePreco.Font = new Font("Arial", 10, FontStyle.Bold);
                        seriePreco.LabelForeColor = Color.Black;

                        chart1.Series.Add(seriePreco);

                        // Preenchendo os dados
                        while (carregarReader.Read())
                        {
                            string descricao = carregarReader["Descricao"].ToString();
                            int quantidade = Convert.ToInt32(carregarReader["Quantidade"]);
                            decimal valor = Convert.ToDecimal(carregarReader["Valor"]);

                            // Adiciona dados às séries
                            serieQuantidade.Points.AddXY(descricao, quantidade);
                            seriePreco.Points.AddXY(descricao, valor);
                        }

                        // Adiciona título ao gráfico
                        chart1.Titles.Clear();
                        chart1.Titles.Add(new Title("Controle de Estoque - Quantidade e Preço")
                        {
                            Font = new Font("Arial", 16, FontStyle.Bold),
                            ForeColor = Color.FromArgb(25, 25, 112), // Azul escuro
                            Alignment = ContentAlignment.TopCenter
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o gráfico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
