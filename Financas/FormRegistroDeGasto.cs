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
    public partial class FormRegistroDeGasto : Form
    {
        public FormRegistroDeGasto()
        {

            InitializeComponent();
            PreencheLabelValorTotal();
            AtualizarComboBoxCategoria();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxFrete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFrete.Checked)
            {
                ndFrete.Visible = true;
            }
            else
            {
                ndFrete.Visible = false;
            }
        }


        private void PreencheLabelValorTotal()
        {
            if (ndValor.Value > 1 || ndFrete.Value > 1)
            {
                lbValorTotal.Visible = true;
                lbValorTotal.Text = $"Valor Total: {ndValor.Value + ndFrete.Value}";
            }
        }

        private void ndFrete_ValueChanged(object sender, EventArgs e)
        {
            PreencheLabelValorTotal();
        }

        private void ndValor_ValueChanged(object sender, EventArgs e)
        {
            PreencheLabelValorTotal();
            
        }

        private void AtualizarComboBoxCategoria()
        {
            cbxCategoria.DataSource = Enum.GetNames(typeof(EnumCategoria));
            cbxCategoria.DisplayMember = "";
            //cbxCategoria.DisplayMember = "Categoria";
            cbxCategoria.SelectedIndex = -1;
        }

        private bool PreencheuTodosOsCampos()
        {
            if (string.IsNullOrWhiteSpace(txtGasto.Text)) return false;
            if (cbxCategoria.SelectedIndex < 0) return false;
            if (dtpDataCompra.Value.Date > DateTime.Now.Date) return false;
            if (string.IsNullOrWhiteSpace(txtDescricao.Text)) return false;
            if (ndValor.Value <= 0) return false;

            return true;
        }

        public void PreencherProdutoComCampos(Produto produto)
        {
            produto.Nome = txtGasto.Text;
            produto.Categoria = (EnumCategoria)(cbxCategoria.SelectedValue = produto.Categoria);
            produto.DataCompra = dtpDataCompra.Value;
            produto.Descricao = txtDescricao.Text;
            produto.Valor = Convert.ToDouble(ndValor.Value);
            produto.ValorTotal = (double)(ndValor.Value + ndFrete.Value);
            PreencheuTodosOsCampos()

        }
    }
}
