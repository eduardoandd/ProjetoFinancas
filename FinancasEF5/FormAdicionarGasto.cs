using FinancasEF5.Data;
using FinancasEF5.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancasEF5
{
    public partial class FormAdicionarGasto : Form
    {
        public FormAdicionarGasto()
        {
            
            InitializeComponent();
           

        }

        private void FormAdicionarGasto_Load(object sender, EventArgs e)
        {
            
            using (var db = new GastoContexto())
            {
                AtualizarCbxCategoria(db);
               
            }
        }

        #region Método para atualizar Combo Box
        private void AtualizarCbxCategoria(GastoContexto db)
        {
           
            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.SelectedIndex = -1;
            cbxCategoria.ValueMember = "IdCategoria";
        }

        #endregion

        #region Métodos para exibir valor total
        private void cbxFrete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdFrete.Checked) 
            {
                //ndFrete.Value = 0;
                ndFrete.Visible = true;
            }
            else
            {
                ndFrete.Value = 0;
                ndFrete.Visible = false;    
            }
        }

        private void ExibirValorTotal()
        {
            if(ndValor.Value > 0 || ndFrete.Value > 0) 
            {
                lbValorTotal.Visible = true;
                lbValorTotal.Text = (ndValor.Value + ndFrete.Value).ToString();
            }
        }

        private void ndValor_ValueChanged(object sender, EventArgs e)
        {
            ExibirValorTotal();
        }

        private void ndFrete_ValueChanged(object sender, EventArgs e)
        {
            ExibirValorTotal();
        }

        #endregion

        #region Métodos para inserir e alterar categorias
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(var form = new FormCategoria())
            {
                form.Text = "Adição de categoria..";
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using(var db = new GastoContexto())
                    {
                        Categoria categoria = new Categoria();
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Add(categoria);
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);
                        MessageBox.Show("Categoria inserida.");

                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new FormCategoria())
            {
                form.Text = "Alterar categoria...";
                form.txtNome.Text = cbxCategoria.Text;
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new GastoContexto())
                    {
                        Categoria categoria = (cbxCategoria.SelectedItem as Categoria);
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Modified;
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);
                        cbxCategoria.SelectedItem = categoria;
                        MessageBox.Show("Categoria alterada.");
                    }
                }
            }
        }
        #endregion

        #region Excluir Categoria
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            if (SimpleMessage.Confirm("Deseja realmente excluir a categoria selecionada", "Exclusão categoria")) ;
            {
                using(var db = new GastoContexto())
                {
                    Categoria categoria = cbxCategoria.SelectedItem as Categoria;
                    int qtdGasto = db.Gastos.Where(x => x.IdCategoria == categoria.IdCategoria).Count();

                    if(qtdGasto == 0)
                    {
                        db.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);
                        SimpleMessage.Inform("Categoria excluida com sucesso.", "Informação");
                    }
                    else
                    {
                        SimpleMessage.Error("Não é possivel excluir uma categoria com produtos.", "Erro");
                    }


                }
            }
        }
        #endregion
    }
}
