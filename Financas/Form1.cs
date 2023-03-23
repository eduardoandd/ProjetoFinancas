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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            PreencheLabelValorTotal();
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
    }
}
