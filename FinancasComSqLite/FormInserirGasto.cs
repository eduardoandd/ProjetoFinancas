


using FinancasComSqLite;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormInserirGasto : Form
    {

        public FormInserirGasto()
        {
            InitializeComponent();
            
            


        }

        #region Métodos responsáveis por exibir o valor total
        protected void AlterarValorTotal()
        {
            lblValorTotal.Visible = true;
            lblValorTotal.Text = $"Valor total: {ndValor.Value + ndValorFrete.Value}";
        }

        private void ndValor_ValueChanged(object sender, EventArgs e)
        {
            AlterarValorTotal();
        }

        private void ndValorFrete_ValueChanged(object sender, EventArgs e)
        {
            AlterarValorTotal();
        }

        private void chkFrete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrete.Checked)
            {
                ndValorFrete.Value = 0;
                ndValorFrete.Visible = true;
            }
            else
            {
                ndValorFrete.Value = 0;
                ndValorFrete.Visible = false;
            }

        }
        #endregion


       
    }
}
