namespace ASC_Automation_System_Commercial
{
    partial class ProcurarEndereco
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
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(32, 40);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(166, 22);
            this.txtCep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe seu cep";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(11, 78);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.RowTemplate.Height = 24;
            this.dgvEndereco.Size = new System.Drawing.Size(777, 360);
            this.dgvEndereco.TabIndex = 2;
            this.dgvEndereco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEndereco_CellClick);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(204, 39);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(95, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Visible = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(204, 39);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(95, 23);
            this.btnLocalizar.TabIndex = 4;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Visible = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // ProcurarEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCep);
            this.Name = "ProcurarEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereco";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEndereco;
        public System.Windows.Forms.Button btnLocalizar;
        public System.Windows.Forms.Button btnVerificar;
    }
}