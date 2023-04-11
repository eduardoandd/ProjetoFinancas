namespace FinancasComEF5
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
            this.chkdFrete = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.ndFrete = new System.Windows.Forms.NumericUpDown();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkNovaCategoria = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // chkdFrete
            // 
            this.chkdFrete.AutoSize = true;
            this.chkdFrete.Location = new System.Drawing.Point(120, 254);
            this.chkdFrete.Name = "chkdFrete";
            this.chkdFrete.Size = new System.Drawing.Size(52, 19);
            this.chkdFrete.TabIndex = 1;
            this.chkdFrete.Text = "Frete";
            this.chkdFrete.UseVisualStyleBackColor = true;
            this.chkdFrete.CheckedChanged += new System.EventHandler(this.chkdFrete_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(244, 54);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(382, 54);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(104, 23);
            this.dtpData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(34, 117);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(499, 117);
            this.txtDescricao.TabIndex = 9;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(34, 57);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(32, 23);
            this.txtCod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cod.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor:";
            // 
            // ndValor
            // 
            this.ndValor.Location = new System.Drawing.Point(34, 273);
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(61, 23);
            this.ndValor.TabIndex = 14;
            this.ndValor.ValueChanged += new System.EventHandler(this.ndValor_ValueChanged);
            // 
            // ndFrete
            // 
            this.ndFrete.Location = new System.Drawing.Point(120, 273);
            this.ndFrete.Name = "ndFrete";
            this.ndFrete.Size = new System.Drawing.Size(61, 23);
            this.ndFrete.TabIndex = 15;
            this.ndFrete.Visible = false;
            this.ndFrete.ValueChanged += new System.EventHandler(this.ndFrete_ValueChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(253, 263);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(112, 30);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor total:";
            this.lblValorTotal.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(442, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkNovaCategoria
            // 
            this.linkNovaCategoria.AutoSize = true;
            this.linkNovaCategoria.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkNovaCategoria.Location = new System.Drawing.Point(244, 80);
            this.linkNovaCategoria.Name = "linkNovaCategoria";
            this.linkNovaCategoria.Size = new System.Drawing.Size(65, 12);
            this.linkNovaCategoria.TabIndex = 18;
            this.linkNovaCategoria.TabStop = true;
            this.linkNovaCategoria.Text = "Nova categoria";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(308, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 12);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ou altere";
            // 
            // FormInserirGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 371);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkNovaCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.ndFrete);
            this.Controls.Add(this.ndValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.chkdFrete);
            this.Name = "FormInserirGasto";
            this.Text = "FormInserirGasto";
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.NumericUpDown ndValor;
        public System.Windows.Forms.NumericUpDown ndFrete;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.CheckBox chkdFrete;
        public System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.LinkLabel linkNovaCategoria;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox txtCod;
    }
}