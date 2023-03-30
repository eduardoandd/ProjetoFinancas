namespace Financas
{
    partial class FormInserirGasto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGastoId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ndValorFrete = new System.Windows.Forms.NumericUpDown();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.chkFrete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndValorFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(231, 44);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(371, 44);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(107, 23);
            this.dtpDataCompra.TabIndex = 5;
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(28, 116);
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(494, 135);
            this.txtDescrição.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // txtGastoId
            // 
            this.txtGastoId.Location = new System.Drawing.Point(28, 44);
            this.txtGastoId.Name = "txtGastoId";
            this.txtGastoId.Size = new System.Drawing.Size(30, 23);
            this.txtGastoId.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cod.";
            // 
            // ndValor
            // 
            this.ndValor.Location = new System.Drawing.Point(28, 283);
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(81, 23);
            this.ndValor.TabIndex = 10;
            this.ndValor.ValueChanged += new System.EventHandler(this.ndValor_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor:";
            // 
            // ndValorFrete
            // 
            this.ndValorFrete.Location = new System.Drawing.Point(137, 283);
            this.ndValorFrete.Name = "ndValorFrete";
            this.ndValorFrete.Size = new System.Drawing.Size(81, 23);
            this.ndValorFrete.TabIndex = 12;
            this.ndValorFrete.Visible = false;
            this.ndValorFrete.ValueChanged += new System.EventHandler(this.ndValorFrete_ValueChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(270, 283);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(103, 25);
            this.lblValorTotal.TabIndex = 14;
            this.lblValorTotal.Text = "Valor total:";
            this.lblValorTotal.Visible = false;
            // 
            // chkFrete
            // 
            this.chkFrete.AutoSize = true;
            this.chkFrete.Location = new System.Drawing.Point(137, 261);
            this.chkFrete.Name = "chkFrete";
            this.chkFrete.Size = new System.Drawing.Size(52, 19);
            this.chkFrete.TabIndex = 15;
            this.chkFrete.Text = "Frete";
            this.chkFrete.UseVisualStyleBackColor = true;
            this.chkFrete.CheckedChanged += new System.EventHandler(this.chkFrete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormInserirGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkFrete);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.ndValorFrete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ndValor);
            this.Controls.Add(this.txtGastoId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormInserirGasto";
            this.Text = "FormInserirGasto";
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndValorFrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGastoId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ndValorFrete;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.CheckBox chkFrete;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown ndValor;
    }
}