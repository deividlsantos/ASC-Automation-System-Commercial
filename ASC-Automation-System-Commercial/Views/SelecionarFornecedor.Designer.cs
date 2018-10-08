namespace ASC_Automation_System_Commercial.Views
{
    partial class SelecionarFornecedor
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
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 12);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(397, 150);
            this.dgvFornecedor.TabIndex = 0;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            this.dgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            // 
            // SelecionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 176);
            this.Controls.Add(this.dgvFornecedor);
            this.Name = "SelecionarFornecedor";
            this.Text = "SelecionarFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFornecedor;
    }
}