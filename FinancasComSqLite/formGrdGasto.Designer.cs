namespace FinancasComSqLite
{
    partial class formGrdGasto
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
            this.grdFinancas = new System.Windows.Forms.DataGridView();
            this.clmGastoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemFrete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmValorDoFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFinancas
            // 
            this.grdFinancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFinancas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmGastoId,
            this.clmNome,
            this.clmDescricao,
            this.clmCategoria,
            this.clmDataCompra,
            this.clmValoGasto,
            this.clmTemFrete,
            this.clmValorDoFrete,
            this.clmValorTotal});
            this.grdFinancas.Location = new System.Drawing.Point(72, 42);
            this.grdFinancas.Name = "grdFinancas";
            this.grdFinancas.RowTemplate.Height = 25;
            this.grdFinancas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinancas.Size = new System.Drawing.Size(644, 279);
            this.grdFinancas.TabIndex = 0;
            this.grdFinancas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdFinancas_MouseDoubleClick);
            // 
            // clmGastoId
            // 
            this.clmGastoId.DataPropertyName = "IdGasto";
            this.clmGastoId.Frozen = true;
            this.clmGastoId.HeaderText = "ID";
            this.clmGastoId.Name = "clmGastoId";
            this.clmGastoId.Width = 28;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.Width = 120;
            // 
            // clmDescricao
            // 
            this.clmDescricao.DataPropertyName = "Descricao";
            this.clmDescricao.HeaderText = "Descrição";
            this.clmDescricao.Name = "clmDescricao";
            this.clmDescricao.Width = 120;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Categoria";
            this.clmCategoria.HeaderText = "Categoria";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.Width = 70;
            // 
            // clmDataCompra
            // 
            this.clmDataCompra.DataPropertyName = "DataCompra";
            this.clmDataCompra.HeaderText = "Data";
            this.clmDataCompra.Name = "clmDataCompra";
            this.clmDataCompra.Width = 70;
            // 
            // clmValoGasto
            // 
            this.clmValoGasto.DataPropertyName = "ValorCompra";
            this.clmValoGasto.HeaderText = "Valor";
            this.clmValoGasto.Name = "clmValoGasto";
            this.clmValoGasto.Width = 50;
            // 
            // clmTemFrete
            // 
            this.clmTemFrete.DataPropertyName = "TemFrete";
            this.clmTemFrete.HeaderText = "Frete";
            this.clmTemFrete.Name = "clmTemFrete";
            this.clmTemFrete.Width = 40;
            // 
            // clmValorDoFrete
            // 
            this.clmValorDoFrete.DataPropertyName = "ValorFrete";
            this.clmValorDoFrete.HeaderText = "Valor do Frete";
            this.clmValorDoFrete.Name = "clmValorDoFrete";
            this.clmValorDoFrete.Width = 50;
            // 
            // clmValorTotal
            // 
            this.clmValorTotal.DataPropertyName = "ValorFinal";
            this.clmValorTotal.HeaderText = "Valor total";
            this.clmValorTotal.Name = "clmValorTotal";
            this.clmValorTotal.Width = 50;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(641, 356);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(550, 356);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // formGrdGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.grdFinancas);
            this.Name = "formGrdGasto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formGrdGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFinancas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGastoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValoGasto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTemFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorDoFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorTotal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}
