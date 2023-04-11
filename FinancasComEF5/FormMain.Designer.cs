namespace FinancasComEF5
{
    partial class FormMain
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
            this.grdGasto = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGasto
            // 
            this.grdGasto.AllowUserToDeleteRows = false;
            this.grdGasto.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGasto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmCategoria,
            this.clmDataCompra,
            this.clmDescricao,
            this.clmValorCompra,
            this.clmTemFrete,
            this.clmValorFrete,
            this.clmValorFinal});
            this.grdGasto.Location = new System.Drawing.Point(44, 57);
            this.grdGasto.Name = "grdGasto";
            this.grdGasto.RowHeadersVisible = false;
            this.grdGasto.RowTemplate.Height = 25;
            this.grdGasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGasto.Size = new System.Drawing.Size(642, 323);
            this.grdGasto.TabIndex = 0;
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "IdGasto";
            this.clmCodigo.Frozen = true;
            this.clmCodigo.HeaderText = "Cod";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCodigo.Width = 40;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.Width = 120;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Categoria";
            this.clmCategoria.HeaderText = "Categoria";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.Width = 60;
            // 
            // clmDataCompra
            // 
            this.clmDataCompra.DataPropertyName = "DataCompra";
            this.clmDataCompra.HeaderText = "Data";
            this.clmDataCompra.Name = "clmDataCompra";
            this.clmDataCompra.Width = 70;
            // 
            // clmDescricao
            // 
            this.clmDescricao.DataPropertyName = "Descricao";
            this.clmDescricao.HeaderText = "Descrição";
            this.clmDescricao.Name = "clmDescricao";
            this.clmDescricao.Width = 120;
            // 
            // clmValorCompra
            // 
            this.clmValorCompra.DataPropertyName = "ValorCompra";
            this.clmValorCompra.HeaderText = "Valor";
            this.clmValorCompra.Name = "clmValorCompra";
            this.clmValorCompra.Width = 50;
            // 
            // clmTemFrete
            // 
            this.clmTemFrete.DataPropertyName = "TemFrete";
            this.clmTemFrete.HeaderText = "Frete";
            this.clmTemFrete.Name = "clmTemFrete";
            this.clmTemFrete.Width = 30;
            // 
            // clmValorFrete
            // 
            this.clmValorFrete.DataPropertyName = "ValorFrete";
            this.clmValorFrete.HeaderText = "Valor do Frete";
            this.clmValorFrete.Name = "clmValorFrete";
            this.clmValorFrete.Width = 50;
            // 
            // clmValorFinal
            // 
            this.clmValorFinal.DataPropertyName = "ValorFinal";
            this.clmValorFinal.HeaderText = "Valor Final";
            this.clmValorFinal.Name = "clmValorFinal";
            this.clmValorFinal.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo gasto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Location = new System.Drawing.Point(257, 395);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(128, 23);
            this.btnNovaCategoria.TabIndex = 3;
            this.btnNovaCategoria.Text = "Nova Categoria";
            this.btnNovaCategoria.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdGasto);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.grdGasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGasto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTemFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorFinal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNovaCategoria;
    }
}