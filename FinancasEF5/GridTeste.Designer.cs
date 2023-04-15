namespace FinancasEF5
{
    partial class GridTeste
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
            this.grdTeste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTeste
            // 
            this.grdTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeste.Location = new System.Drawing.Point(59, 79);
            this.grdTeste.Name = "grdTeste";
            this.grdTeste.RowTemplate.Height = 25;
            this.grdTeste.Size = new System.Drawing.Size(621, 284);
            this.grdTeste.TabIndex = 0;
            // 
            // GridTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdTeste);
            this.Name = "GridTeste";
            this.Text = "GridTeste";
            ((System.ComponentModel.ISupportInitialize)(this.grdTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grdTeste;
    }
}