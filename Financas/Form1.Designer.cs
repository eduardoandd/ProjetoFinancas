namespace Financas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.ndFrete = new System.Windows.Forms.NumericUpDown();
            this.cbxFrete = new System.Windows.Forms.CheckBox();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(465, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(22, 26);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(246, 23);
            this.txtGasto.TabIndex = 0;
            this.txtGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(465, 26);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(93, 23);
            this.dtpDataCompra.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(281, 26);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(142, 23);
            this.cbxCategoria.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(281, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inserir nova categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(22, 108);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(536, 115);
            this.txtDescricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor";
            // 
            // ndValor
            // 
            this.ndValor.DecimalPlaces = 2;
            this.ndValor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.ndValor.Location = new System.Drawing.Point(22, 267);
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(84, 23);
            this.ndValor.TabIndex = 5;
            this.ndValor.ValueChanged += new System.EventHandler(this.ndValor_ValueChanged);
            // 
            // ndFrete
            // 
            this.ndFrete.DecimalPlaces = 2;
            this.ndFrete.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.ndFrete.Location = new System.Drawing.Point(148, 265);
            this.ndFrete.Name = "ndFrete";
            this.ndFrete.Size = new System.Drawing.Size(84, 23);
            this.ndFrete.TabIndex = 7;
            this.ndFrete.Visible = false;
            this.ndFrete.ValueChanged += new System.EventHandler(this.ndFrete_ValueChanged);
            // 
            // cbxFrete
            // 
            this.cbxFrete.AutoSize = true;
            this.cbxFrete.Location = new System.Drawing.Point(132, 245);
            this.cbxFrete.Name = "cbxFrete";
            this.cbxFrete.Size = new System.Drawing.Size(52, 19);
            this.cbxFrete.TabIndex = 6;
            this.cbxFrete.Text = "Frete";
            this.cbxFrete.UseVisualStyleBackColor = true;
            this.cbxFrete.CheckedChanged += new System.EventHandler(this.cbxFrete_CheckedChanged);
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbValorTotal.Location = new System.Drawing.Point(297, 267);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(146, 37);
            this.lbValorTotal.TabIndex = 15;
            this.lbValorTotal.Text = "Valor total:";
            this.lbValorTotal.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(281, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.cbxFrete);
            this.Controls.Add(this.ndFrete);
            this.Controls.Add(this.ndValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar gasto..";
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndFrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ndValor;
        private System.Windows.Forms.NumericUpDown ndFrete;
        private System.Windows.Forms.CheckBox cbxFrete;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.Label label6;
    }
}
