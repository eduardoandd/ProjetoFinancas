using FinancasComEF5.Data;
using FinancasComEF5.Models;
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

namespace FinancasComEF5
{
    public partial class FormInserirGasto : Form
    {
        public FormInserirGasto()
        {
            InitializeComponent();
            
        }

        public void AtualizarCbxCategoria(GastoContexto db)
        {
            

            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
        }



        #region Métodos para exibir o valor total
        private void AlterarValorTotal()
        {
            lblValorTotal.Visible = true;
            lblValorTotal.Text = $"Valor total: {ndValor.Value + ndFrete.Value}";
        }

        private void ndValor_ValueChanged(object sender, EventArgs e)
        {
            AlterarValorTotal();
        }

        private void ndFrete_ValueChanged(object sender, EventArgs e)
        {
            AlterarValorTotal();
        }

        private void chkdFrete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdFrete.Checked)
            {
                ndFrete.Value = 0;
                ndFrete.Visible = true;
            }
            else
            {
                ndFrete.Value = 0;
                ndFrete.Visible = false;
            }
        }


        #endregion

    }
}
