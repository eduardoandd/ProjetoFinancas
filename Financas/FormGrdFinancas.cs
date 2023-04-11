using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    

    public partial class FormGrdFinancas : Form
    {

        public Produto gastoSelecionado = null;
        public FormGrdFinancas()
        {
            InitializeComponent();
            //Para deixar a celula [1] da grid a esquerda
            grdFinancas.Columns[1].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            grdFinancas.DataSource = Produto.ListaProdutos;
            (grdFinancas.Columns["clmCategoria"] as DataGridViewComboBoxColumn).DataSource = Enum.GetValues(typeof(EnumCategoria));

        }


        #region Método para deixar valores menores que 0 vermelho(coluna frete)
        private void grdFinancas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if( e != null)
            {
                if (grdFinancas.Columns[e.ColumnIndex].HeaderText == "Frete")
                {
                    if(e.Value != null)
                    {
                        double valor = Convert.ToDouble(e.Value);
                        e.Value = valor.ToString("F2");
                        e.FormattingApplied = true;

                        if(valor <= 0)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Green;
                        }

                    }
                }
            }
        }
        #endregion


        #region Método para exibir os valores da linha do grid no formulário de registro
        private void grdFinancas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if(grdFinancas.SelectedRows.Count > 0)
            {
                linhaSelecionada = grdFinancas.SelectedRows[0];
                gastoSelecionado = linhaSelecionada.DataBoundItem as Produto;

            }

            if(gastoSelecionado != null)
            {
                FormRegistroDeGasto formRegistro = new FormRegistroDeGasto();
                formRegistro.produto = gastoSelecionado;
                if(formRegistro.ShowDialog() == DialogResult.OK)
                {
                    grdFinancas.InvalidateRow(linhaSelecionada.Index);
                    MessageBox.Show("Produto alterado com sucesso.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alteração cancelada", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                gastoSelecionado = null;
                formRegistro.Dispose();

            }
        }
        #endregion

        private void FormGrdFinancas_Load(object sender, EventArgs e)
        {

        }
    }
}
