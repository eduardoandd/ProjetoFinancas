using Financas;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancasComSqLite
{
    public partial class formGrdGasto : Form
    {
        string caminhoBD = Path.Combine(Application.LocalUserAppDataPath, "data.db");


        public formGrdGasto()
        {
            InitializeComponent();

            CriarBancoDeDados(caminhoBD);
           // PopularBancoDeDados(caminhoBD);
            List<Gasto> gastos = LerBancoDeDados(caminhoBD);
            grdFinancas.DataSource = gastos;
        }

        private void grdFinancas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            FormInserirGasto formInserirGasto = new FormInserirGasto();
            formInserirGasto.ShowDialog();

            //DataGridViewRow linhaSelecionada = null;
            //if(grdFinancas.SelectedRows.Count > 0)
            //{
            //    linhaSelecionada = grdFinancas.SelectedRows[0];
            //    gastoSelecionado=linhaSelecionada.DataBoundItem as Gasto;
            //}
        }


        protected void CriarBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("CREATE TABLE IF NOT EXISTS GASTOS (");
                sb.Append("ID_GASTO INTEGER PRIMARY KEY,");
                sb.Append("NOME VARCHAR(100) NOT NULL,");
                sb.Append("CATEGORIA VARCHAR(50) NOT NULL,");
                sb.Append("DATA_COMPRA DATE,");
                sb.Append("DESCRICAO VARCHAR(200),");
                sb.Append("VALOR_COMPRA DECIMAL(18,2),");
                sb.Append("TEM_FRETE BOOLEAN,");
                sb.Append("VALOR_FRETE DECIMAL(18,2),");
                sb.Append("VALOR_FINAL DECIMAL(18,2));");


                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();
            }
        }

        private void PopularBancoDeDados(string caminho)
        {
            Random gerador = new Random();

            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO GASTOS VALUES(NULL,");
                sb.Append("@NOME, @CATEGORIA, @DATA_COMPRA,@DESCRICAO," +
                    "@VALOR_COMPRA,@TEM_FRETE,@VALOR_FRETE,@VALOR_FINAL);");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                int insertCount = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sql.Parameters.Clear();
                    sql.Parameters.AddWithValue("@NOME", $"Produto {i}");
                    sql.Parameters.AddWithValue("@CATEGORIA", $"Categoria{gerador.NextDouble() * 2}");
                    sql.Parameters.AddWithValue("@DATA_COMPRA", DateTime.Today.AddDays(
                        -gerador.Next(18 * 265, 75 * 365)));
                    sql.Parameters.AddWithValue("@DESCRICAO", $"Descrição {i}");
                    sql.Parameters.AddWithValue("@VALOR_COMPRA", gerador.NextDouble() * 10);
                    sql.Parameters.AddWithValue("@TEM_FRETE", 1);
                    sql.Parameters.AddWithValue("@VALOR_FRETE", gerador.NextDouble() * 1);
                    sql.Parameters.AddWithValue("@VALOR_FINAL", gerador.NextDouble() * 11);
                    insertCount += sql.ExecuteNonQuery();

                }
                MessageBox.Show($"Foram inserido {insertCount} clientes no banco de dados.");

            }
        }

        private List<Gasto> LerBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM GASTOS ORDER BY ID_GASTO");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                SqliteDataReader leitor = sql.ExecuteReader();
                List<Gasto> gastos = new List<Gasto>();
                while (leitor.Read())
                {
                    Gasto gasto = new Gasto
                    {
                        IdGasto = Convert.ToInt32(leitor["ID_GASTO"]),
                        Nome = leitor["NOME"].ToString(),
                        Categoria = leitor["CATEGORIA"].ToString(),
                        DataCompra = Convert.ToDateTime(leitor["DATA_COMPRA"]),
                        Descricao = leitor["DESCRICAO"].ToString(),
                        ValorCompra = Convert.ToDouble(leitor["VALOR_COMPRA"]),
                        TemFrete = Convert.ToBoolean(leitor["TEM_FRETE"]),
                        ValorFrete = Convert.ToDouble(leitor["VALOR_FRETE"]),
                        ValorFinal = Convert.ToDouble(leitor["VALOR_FINAL"])
                    };
                    gastos.Add(gasto);

                }
                return gastos;
            }
        }

       

        private void AtualizarBancoDeDados(string caminho, int idCliente)
        {
            using(SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE GASTOS SET ");
                sb.Append("NOME = @NOME, DESCRICAO=@DESCRICAO ");
                sb.Append("WHERE ID_GASTO = @ID_GASTO");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@NOME", $"PRODUTO {idCliente} MODIFICADO");
                sql.Parameters.AddWithValue("@DESCRICAO", $"DESCRICAO MODIFICADA");
                sql.Parameters.AddWithValue("@ID_GASTO", idCliente);
                if(sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"Cliente {idCliente} atualizado com sucesso");
                }

            }
        }

        private void ExcluirBancoDeDados(string caminho, int idCliente)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE FROM  GASTOS WHERE ID_GASTO = @ID_GASTO ");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@ID_GASTO", idCliente);
                if (sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"Cliente {idCliente} EXCLUIDO com sucesso");
                }

            }
        }

        private void formGrdGasto_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdFinancas.SelectedCells[0].Value);
            AtualizarBancoDeDados(caminhoBD, idCliente);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdFinancas.SelectedCells[0].Value);
            ExcluirBancoDeDados(caminhoBD, idCliente);
        }

      
    }
}
