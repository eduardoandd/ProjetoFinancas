namespace Financas
{
    partial class FormGrdFinancas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdFinancas = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFinancas
            // 
            this.grdFinancas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.grdFinancas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFinancas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFinancas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFinancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFinancas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmExcluir,
            this.clmNome,
            this.clmCategoria,
            this.clmDataCompra,
            this.clmDescricao,
            this.clmValor,
            this.clmFrete,
            this.clmValorTotal});
            this.grdFinancas.Location = new System.Drawing.Point(12, 44);
            this.grdFinancas.MultiSelect = false;
            this.grdFinancas.Name = "grdFinancas";
            this.grdFinancas.RowTemplate.Height = 25;
            this.grdFinancas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinancas.Size = new System.Drawing.Size(846, 359);
            this.grdFinancas.TabIndex = 0;
            this.grdFinancas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdFinancas_CellFormatting);
            this.grdFinancas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdFinancas_MouseDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "ProdutoId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            // 
            // clmExcluir
            // 
            this.clmExcluir.HeaderText = "Excluir";
            this.clmExcluir.Name = "clmExcluir";
            this.clmExcluir.Text = "Excluir";
            this.clmExcluir.Width = 80;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Categoria";
            this.clmCategoria.HeaderText = "Categoria";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmDataCompra
            // 
            this.clmDataCompra.DataPropertyName = "DataCompra";
            this.clmDataCompra.HeaderText = "Data";
            this.clmDataCompra.Name = "clmDataCompra";
            // 
            // clmDescricao
            // 
            this.clmDescricao.DataPropertyName = "Descricao";
            this.clmDescricao.HeaderText = "Descrição";
            this.clmDescricao.Name = "clmDescricao";
            // 
            // clmValor
            // 
            this.clmValor.DataPropertyName = "Valor";
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            // 
            // clmFrete
            // 
            this.clmFrete.DataPropertyName = "ValorFrete";
            this.clmFrete.HeaderText = "Frete";
            this.clmFrete.Name = "clmFrete";
            // 
            // clmValorTotal
            // 
            this.clmValorTotal.DataPropertyName = "ValorTotal";
            this.clmValorTotal.HeaderText = "Valor Total";
            this.clmValorTotal.Name = "clmValorTotal";
            // 
            // FormGrdFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.grdFinancas);
            this.Name = "FormGrdFinancas";
            this.Text = "FormGrdFinancas";
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFinancas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewButtonColumn clmExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorTotal;
    }
}