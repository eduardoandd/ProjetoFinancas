using FinancasEF5.Data;
using FinancasEF5.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancasEF5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using (var db = new GastoContexto())
            {
                AtualizarCbxCategoria(db);
                AtualizarProdutos(db);
                ModificarCelulaGrid();
            }
        }


        private void ExibirValorTotalDaCategoria()
        {
            lbValorTotalCategoria.Visible = true;
            decimal soma = 0;
            for (int i = 0; i < grdGasto.Rows.Count; i++)
            {
                soma += Convert.ToDecimal(grdGasto.Rows[i].Cells[7].Value);
            }
            lbValorTotalCategoria.Text = $"O valor total é: {soma.ToString()}";

        }



        #region Métodos auxiliares do grid
        private void grdGasto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterarGasto_Click(sender, e);
        }


        private void ModificarCelulaGrid()
        {
            grdGasto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grdGasto.AutoResizeColumns();
            grdGasto.AllowUserToResizeColumns = true;
            grdGasto.AllowUserToOrderColumns = true;

            grdGasto.Columns["clmValorFrete"].Width = 50;
        }
        #endregion

        #region CRUD gasto.
        private void btnAdicionarGasto_Click(object sender, EventArgs e)
        {
            using (var form = new FormAdicionarGasto())
            {
                form.Text = "Adição de gasto...";
                //form.cbxCategoria.SelectedIndex = cbxCategoria.SelectedIndex;
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new GastoContexto())
                    {
                        Gasto gasto = new Gasto();
                        gasto.Nome = form.txtGasto.Text;
                        gasto.IdCategoria = (form.cbxCategoria.SelectedItem as Categoria).IdCategoria;
                        gasto.DataCompra = form.dtpDataCompra.Value;
                        gasto.Descricao = form.txtDescricao.Text;
                        gasto.ValorCompra = Convert.ToDouble(form.ndValor.Value);
                        gasto.ValorFrete = Convert.ToDouble(form.ndFrete.Value);
                        gasto.TemFrete = form.chkdFrete.Checked;
                        gasto.ValorFinal = Convert.ToDouble(form.lbValorTotal.Text);
                        db.Gastos.Add(gasto);
                        db.SaveChanges();
                        AtualizarProdutos(db);
                        MessageBox.Show("Gasto adicionado com sucesso");
                        
                    }
                }

            }
        }
        private void btnAlterarGasto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (grdGasto.SelectedRows.Count > 0)
            {
                linhaSelecionada = grdGasto.SelectedRows[0];
                Gasto gasto = linhaSelecionada.DataBoundItem as Gasto;
                using (var form = new FormAdicionarGasto())
                {

                    form.Text = "Alteração de produto...";
                    form.txtGasto.Text = gasto.Nome;
                    form.cbxCategoria.SelectedIndex = form.cbxCategoria.FindString(gasto.Categoria.Nome);
                    form.dtpDataCompra.Value = gasto.DataCompra;
                    form.txtDescricao.Text = gasto.Descricao;
                    form.ndValor.Value = Convert.ToDecimal(gasto.ValorCompra);
                    form.chkdFrete.Checked = Convert.ToBoolean(gasto.TemFrete);
                    form.ndFrete.Value = Convert.ToDecimal(gasto.ValorFrete);
                    form.lbValorTotal.Text = gasto.ValorFinal.ToString();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new GastoContexto())
                        {
                            gasto.Nome = form.txtGasto.Text;
                            gasto.Categoria.IdCategoria = (form.cbxCategoria.SelectedItem as Categoria).IdCategoria;
                            gasto.DataCompra = form.dtpDataCompra.Value;
                            gasto.Descricao = form.txtDescricao.Text;
                            gasto.ValorCompra = Convert.ToDouble(form.ndValor.Value);
                            gasto.TemFrete = Convert.ToBoolean(form.chkdFrete.Checked);
                            gasto.ValorFrete = Convert.ToDouble(form.ndFrete.Value);
                            gasto.ValorFinal = Convert.ToDouble(form.lbValorTotal.Text);
                            db.Gastos.Attach(gasto);
                            db.Entry(gasto).State = EntityState.Modified;
                            db.SaveChanges();
                            AtualizarProdutos(db);
                            MessageBox.Show("Produto alterado com sucesso");

                        }
                    }
                }
            }
        }

        private void btnExcluirGasto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (grdGasto.SelectedRows.Count > 0)
            {
                linhaSelecionada = grdGasto.SelectedRows[0];
                Gasto gasto = linhaSelecionada.DataBoundItem as Gasto;
                if (SimpleMessage.Confirm("Deseja realmente excluir o produto selecionada?", "Exclusão de produto"))
                {
                    using (var db = new GastoContexto())
                    {
                        db.Gastos.Attach(gasto);
                        db.Entry(gasto).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarProdutos(db);
                        SimpleMessage.Inform("Produto excluido com sucesso.");
                    }
                }
            }
        }


        #endregion

        #region Método atualizar Grid e ComboBox
        private void AtualizarProdutos(GastoContexto db)
        {
            
            if (cbxCategoria.SelectedIndex == -1)
            {
                this.Cursor = Cursors.WaitCursor;
                //int idCategoria = (cbxCategoria.SelectedItem as Categoria).IdCategoria;
                grdGasto.DataSource = db.Gastos.
                //Where(x => x.IdCategoria == idCategoria).
                Include(x => x.Categoria).ToList();
                grdGasto.Columns.Remove(grdGasto.Columns["IdCategoria"]);
                grdGasto.Columns.Remove(grdGasto.Columns["Categoria"]);

                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                int idCategoria = (cbxCategoria.SelectedItem as Categoria).IdCategoria;
                grdGasto.DataSource = db.Gastos.
                Where(x => x.IdCategoria == idCategoria).
                Include(x => x.Categoria).ToList();
                grdGasto.Columns.Remove(grdGasto.Columns["IdCategoria"]);
                grdGasto.Columns.Remove(grdGasto.Columns["Categoria"]);

                this.Cursor = Cursors.Default;
            }

            ExibirValorTotalDaCategoria();
            //AtualizarCbxCategoria(db);
         }

        private void AtualizarCbxCategoria(GastoContexto db)
        {
            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.SelectedIndex = -1;
            cbxCategoria.ValueMember = "IdCategoria";
        }

        private void cbxCategoria_Click(object sender, EventArgs e)
        {
            using (var db = new GastoContexto())
            {
                AtualizarCbxCategoria(db);
                //AtualizarProdutos(db);
            }
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new GastoContexto())
            {
                //AtualizarCbxCategoria(db);
                AtualizarProdutos(db);
                //ExibirValorTotalDaCategoria();
            }
        }
        #endregion

        private void grdGasto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
