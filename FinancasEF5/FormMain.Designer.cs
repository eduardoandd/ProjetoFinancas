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
            this.components = new System.ComponentModel.Container();
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
            this.lbValorTotalCategoria = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
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
            this.grdGasto.Location = new System.Drawing.Point(22, 54);
            this.grdGasto.Name = "grdGasto";
            this.grdGasto.ReadOnly = true;
            this.grdGasto.RowHeadersWidth = 51;
            this.grdGasto.RowTemplate.Height = 25;
            this.grdGasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGasto.Size = new System.Drawing.Size(1093, 356);
            this.grdGasto.TabIndex = 3;
            this.grdGasto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGasto_CellContentClick);
            this.grdGasto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGasto_CellDoubleClick);
            // 
            // clmIdGasto
            // 
            this.clmIdGasto.DataPropertyName = "IdGasto";
            this.clmIdGasto.HeaderText = "ID";
            this.clmIdGasto.MinimumWidth = 6;
            this.clmIdGasto.Name = "clmIdGasto";
            this.clmIdGasto.ReadOnly = true;
            this.clmIdGasto.Width = 45;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.MinimumWidth = 6;
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 66;
            // 
            // clmDataCompra
            // 
            this.clmDataCompra.DataPropertyName = "DataCompra";
            this.clmDataCompra.HeaderText = "Data da compra";
            this.clmDataCompra.MinimumWidth = 6;
            this.clmDataCompra.Name = "clmDataCompra";
            this.clmDataCompra.ReadOnly = true;
            this.clmDataCompra.Width = 109;
            // 
            // clmDescricao
            // 
            this.clmDescricao.DataPropertyName = "Descricao";
            this.clmDescricao.HeaderText = "Descrição";
            this.clmDescricao.MinimumWidth = 6;
            this.clmDescricao.Name = "clmDescricao";
            this.clmDescricao.ReadOnly = true;
            this.clmDescricao.Width = 86;
            // 
            // clmValorCompra
            // 
            this.clmValorCompra.DataPropertyName = "ValorCompra";
            this.clmValorCompra.HeaderText = "Valor";
            this.clmValorCompra.MinimumWidth = 6;
            this.clmValorCompra.Name = "clmValorCompra";
            this.clmValorCompra.ReadOnly = true;
            this.clmValorCompra.Width = 60;
            // 
            // clmValorFrete
            // 
            this.clmValorFrete.DataPropertyName = "ValorFrete";
            this.clmValorFrete.HeaderText = "Valor do Frete";
            this.clmValorFrete.MinimumWidth = 6;
            this.clmValorFrete.Name = "clmValorFrete";
            this.clmValorFrete.ReadOnly = true;
            this.clmValorFrete.Width = 101;
            // 
            // clmTemFrete
            // 
            this.clmTemFrete.DataPropertyName = "TemFrete";
            this.clmTemFrete.HeaderText = "Frete";
            this.clmTemFrete.MinimumWidth = 6;
            this.clmTemFrete.Name = "clmTemFrete";
            this.clmTemFrete.ReadOnly = true;
            this.clmTemFrete.Width = 43;
            // 
            // clmValorFinal
            // 
            this.clmValorFinal.DataPropertyName = "ValorFinal";
            this.clmValorFinal.HeaderText = "Valor final";
            this.clmValorFinal.MinimumWidth = 6;
            this.clmValorFinal.Name = "clmValorFinal";
            this.clmValorFinal.ReadOnly = true;
            this.clmValorFinal.Width = 80;
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
            // lbValorTotalCategoria
            // 
            this.lbValorTotalCategoria.AutoSize = true;
            this.lbValorTotalCategoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValorTotalCategoria.Location = new System.Drawing.Point(790, 21);
            this.lbValorTotalCategoria.Name = "lbValorTotalCategoria";
            this.lbValorTotalCategoria.Size = new System.Drawing.Size(103, 25);
            this.lbValorTotalCategoria.TabIndex = 7;
            this.lbValorTotalCategoria.Text = "Valor total:";
            this.lbValorTotalCategoria.Visible = false;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(FinancasEF5.Models.Categoria);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1292, 462);
            this.Controls.Add(this.lbValorTotalCategoria);
            this.Controls.Add(this.btnExcluirGasto);
            this.Controls.Add(this.btnAlterarGasto);
            this.Controls.Add(this.btnAdicionarGasto);
            this.Controls.Add(this.grdGasto);
            this.Controls.Add(this.cbxCategoria);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView grdGasto;
        private System.Windows.Forms.Button btnAdicionarGasto;
        private System.Windows.Forms.Button btnAlterarGasto;
        private System.Windows.Forms.Button btnExcluirGasto;
        private System.Windows.Forms.Label lbValorTotalCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFrete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTemFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFinal;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}
