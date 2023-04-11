namespace FinancasEF5
{
    partial class FormAdicionarGasto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.chkdFrete = new System.Windows.Forms.CheckBox();
            this.ndFrete = new System.Windows.Forms.NumericUpDown();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(392, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(473, 301);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(12, 35);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(194, 23);
            this.txtGasto.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(237, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Categoria";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbValorTotal.Location = new System.Drawing.Point(233, 262);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(146, 37);
            this.lbValorTotal.TabIndex = 32;
            this.lbValorTotal.Text = "Valor total:";
            this.lbValorTotal.Visible = false;
            // 
            // chkdFrete
            // 
            this.chkdFrete.AutoSize = true;
            this.chkdFrete.Location = new System.Drawing.Point(122, 254);
            this.chkdFrete.Name = "chkdFrete";
            this.chkdFrete.Size = new System.Drawing.Size(52, 19);
            this.chkdFrete.TabIndex = 28;
            this.chkdFrete.Text = "Frete";
            this.chkdFrete.UseVisualStyleBackColor = true;
            this.chkdFrete.CheckedChanged += new System.EventHandler(this.cbxFrete_CheckedChanged);
            // 
            // ndFrete
            // 
            this.ndFrete.DecimalPlaces = 2;
            this.ndFrete.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.ndFrete.Location = new System.Drawing.Point(122, 276);
            this.ndFrete.Name = "ndFrete";
            this.ndFrete.Size = new System.Drawing.Size(84, 23);
            this.ndFrete.TabIndex = 29;
            this.ndFrete.Visible = false;
            this.ndFrete.ValueChanged += new System.EventHandler(this.ndFrete_ValueChanged);
            // 
            // ndValor
            // 
            this.ndValor.DecimalPlaces = 2;
            this.ndValor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.ndValor.Location = new System.Drawing.Point(12, 276);
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(84, 23);
            this.ndValor.TabIndex = 27;
            this.ndValor.ValueChanged += new System.EventHandler(this.ndValor_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Valor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 117);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(536, 115);
            this.txtDescricao.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descrição";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(238, 61);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inserir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(237, 35);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(142, 23);
            this.cbxCategoria.Sorted = true;
            this.cbxCategoria.TabIndex = 22;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(455, 35);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(93, 23);
            this.dtpDataCompra.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gasto";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Location = new System.Drawing.Point(295, 61);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 13);
            this.linkLabel2.TabIndex = 37;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "alterar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "ou";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "categoria";
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Location = new System.Drawing.Point(385, 35);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(56, 23);
            this.btnExcluirCategoria.TabIndex = 40;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // FormAdicionarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 370);
            this.Controls.Add(this.btnExcluirCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.chkdFrete);
            this.Controls.Add(this.ndFrete);
            this.Controls.Add(this.ndValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAdicionarGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdicionarGasto";
            this.Load += new System.EventHandler(this.FormAdicionarGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbValorTotal;
        public System.Windows.Forms.CheckBox chkdFrete;
        public System.Windows.Forms.NumericUpDown ndFrete;
        public System.Windows.Forms.NumericUpDown ndValor;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExcluirCategoria;
    }
}