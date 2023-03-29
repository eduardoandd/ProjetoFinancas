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
        public Produto produto = null;

        public FormRegistroDeGasto()
        {

            InitializeComponent();
            PreencheLabelValorTotal();
            AtualizarComboBoxCategoria();
            txtGasto.Select();

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

        #region Métodos para exibir o valor total
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
        #endregion


        #region Atualizar Combo Box Categoria
        private void AtualizarComboBoxCategoria()
        {
            cbxCategoria.DataSource = Enum.GetNames(typeof(EnumCategoria));
            cbxCategoria.DisplayMember = "";
            //cbxCategoria.DisplayMember = "Categoria";
            cbxCategoria.SelectedIndex = -1;
        }
        #endregion

        
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
            PreencheuTodosOsCampos();
        }

        public void AlterarEstadoDosCampos(bool estado)
        {
            txtDescricao.Enabled = estado;
            cbxCategoria.Enabled = estado;
            dtpDataCompra.Enabled=estado;
            ndValor.Enabled = estado;

        }

        private void FormRegistroDeGasto_Load(object sender, EventArgs e)
        {
            txtGasto.Text = produto.Nome.ToString();
            cbxCategoria.SelectedText = produto.Categoria.ToString();
            dtpDataCompra.Value = produto.DataCompra.Date;
            txtDescricao.Text = produto.Descricao;
            //ndValor.Value = produto.Valor.ToString();
            //ndFrete.Value = (double)produto.Frete;
               
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            
            produto.Nome = txtGasto.Text;
            produto.Categoria = (EnumCategoria)cbxCategoria.SelectedIndex;
            produto.DataCompra = dtpDataCompra.Value.Date;
            produto.Descricao = txtDescricao.Text;
            produto.Valor = (double)ndValor.Value;
            produto.Frete = (double)ndFrete.Value;
          
        }
    }
}
