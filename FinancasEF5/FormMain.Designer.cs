namespace FinancasEF5
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.grdGasto = new System.Windows.Forms.DataGridView();
            this.clmIdGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemFrete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarGasto = new System.Windows.Forms.Button();
            this.btnAlterarGasto = new System.Windows.Forms.Button();
            this.btnExcluirGasto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(12, 25);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoria.TabIndex = 1;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            this.cbxCategoria.Click += new System.EventHandler(this.cbxCategoria_Click);
            // 
            // grdGasto
            // 
            this.grdGasto.AllowUserToAddRows = false;
            this.grdGasto.AllowUserToDeleteRows = false;
            this.grdGasto.AllowUserToOrderColumns = true;
            this.grdGasto.AllowUserToResizeColumns = false;
            this.grdGasto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grdGasto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGasto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdGasto,
            this.clmNome,
            this.clmDataCompra,
            this.clmDescricao,
            this.clmValorCompra,
            this.clmValorFrete,
            this.clmTemFrete,
            this.clmValorFinal});
            this.grdGasto.Location = new System.Drawing.Point(12, 66);
            this.grdGasto.Name = "grdGasto";
            this.grdGasto.ReadOnly = true;
            this.grdGasto.RowTemplate.Height = 25;
            this.grdGasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGasto.Size = new System.Drawing.Size(863, 343);
            this.grdGasto.TabIndex = 3;
            this.grdGasto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGasto_CellDoubleClick);
            // 
            // clmIdGasto
            // 
            this.clmIdGasto.DataPropertyName = "IdGasto";
            this.clmIdGasto.HeaderText = "ID";
            this.clmIdGasto.Name = "clmIdGasto";
            this.clmIdGasto.ReadOnly = true;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            // 
            // clmDataCompra
            // 
            this.clmDataCompra.DataPropertyName = "DataCompra";
            this.clmDataCompra.HeaderText = "Data da compra";
            this.clmDataCompra.Name = "clmDataCompra";
            this.clmDataCompra.ReadOnly = true;
            // 
            // clmDescricao
            // 
            this.clmDescricao.DataPropertyName = "Descricao";
            this.clmDescricao.HeaderText = "Descrição";
            this.clmDescricao.Name = "clmDescricao";
            this.clmDescricao.ReadOnly = true;
            // 
            // clmValorCompra
            // 
            this.clmValorCompra.DataPropertyName = "ValorCompra";
            this.clmValorCompra.HeaderText = "Valor";
            this.clmValorCompra.Name = "clmValorCompra";
            this.clmValorCompra.ReadOnly = true;
            // 
            // clmValorFrete
            // 
            this.clmValorFrete.DataPropertyName = "ValorFrete";
            this.clmValorFrete.HeaderText = "Valor do Frete";
            this.clmValorFrete.Name = "clmValorFrete";
            this.clmValorFrete.ReadOnly = true;
            // 
            // clmTemFrete
            // 
            this.clmTemFrete.DataPropertyName = "TemFrete";
            this.clmTemFrete.HeaderText = "Frete";
            this.clmTemFrete.Name = "clmTemFrete";
            this.clmTemFrete.ReadOnly = true;
            // 
            // clmValorFinal
            // 
            this.clmValorFinal.DataPropertyName = "ValorFinal";
            this.clmValorFinal.HeaderText = "Valor final";
            this.clmValorFinal.Name = "clmValorFinal";
            this.clmValorFinal.ReadOnly = true;
            // 
            // btnAdicionarGasto
            // 
            this.btnAdicionarGasto.Location = new System.Drawing.Point(160, 25);
            this.btnAdicionarGasto.Name = "btnAdicionarGasto";
            this.btnAdicionarGasto.Size = new System.Drawing.Size(194, 23);
            this.btnAdicionarGasto.TabIndex = 4;
            this.btnAdicionarGasto.Text = "Adicionar Gasto";
            this.btnAdicionarGasto.UseVisualStyleBackColor = true;
            this.btnAdicionarGasto.Click += new System.EventHandler(this.btnAdicionarGasto_Click);
            // 
            // btnAlterarGasto
            // 
            this.btnAlterarGasto.Location = new System.Drawing.Point(365, 25);
            this.btnAlterarGasto.Name = "btnAlterarGasto";
            this.btnAlterarGasto.Size = new System.Drawing.Size(194, 23);
            this.btnAlterarGasto.TabIndex = 5;
            this.btnAlterarGasto.Text = "Alterar gasto";
            this.btnAlterarGasto.UseVisualStyleBackColor = true;
            this.btnAlterarGasto.Click += new System.EventHandler(this.btnAlterarGasto_Click);
            // 
            // btnExcluirGasto
            // 
            this.btnExcluirGasto.Location = new System.Drawing.Point(575, 24);
            this.btnExcluirGasto.Name = "btnExcluirGasto";
            this.btnExcluirGasto.Size = new System.Drawing.Size(194, 23);
            this.btnExcluirGasto.TabIndex = 6;
            this.btnExcluirGasto.Text = "Excluir gasto";
            this.btnExcluirGasto.UseVisualStyleBackColor = true;
            this.btnExcluirGasto.Click += new System.EventHandler(this.btnExcluirGasto_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 435);
            this.Controls.Add(this.btnExcluirGasto);
            this.Controls.Add(this.btnAlterarGasto);
            this.Controls.Add(this.btnAdicionarGasto);
            this.Controls.Add(this.grdGasto);
            this.Controls.Add(this.cbxCategoria);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView grdGasto;
        private System.Windows.Forms.Button btnAdicionarGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFrete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTemFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFinal;
        private System.Windows.Forms.Button btnAlterarGasto;
        private System.Windows.Forms.Button btnExcluirGasto;
    }
}
