namespace ASC_Automation_System_Commercial.Views
{
    partial class Produto
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcProduto = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnQuantidade = new System.Windows.Forms.Button();
            this.btnNProduto = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProduto.Location = new System.Drawing.Point(235, 21);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(432, 150);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor:";
            // 
            // txtcProduto
            // 
            this.txtcProduto.Enabled = false;
            this.txtcProduto.Location = new System.Drawing.Point(112, 21);
            this.txtcProduto.MaxLength = 100000;
            this.txtcProduto.Name = "txtcProduto";
            this.txtcProduto.Size = new System.Drawing.Size(100, 20);
            this.txtcProduto.TabIndex = 3;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(112, 61);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fabricante(Marca):";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(112, 131);
            this.txtFabricante.MaxLength = 60;
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipo.Enabled = false;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "POWER BANK",
            "MONITOR",
            "MOUSE",
            "NOTEBOOK",
            "SMART PHONE",
            "SMART TV",
            "ROTEADOR",
            "TABLET",
            "TECLADO",
            "NOBREAK"});
            this.cboTipo.Location = new System.Drawing.Point(91, 172);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 4;
            this.cboTipo.Text = "Selecione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(112, 225);
            this.txtModelo.MaxLength = 60;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço R$:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(112, 290);
            this.txtPreco.MaxLength = 8;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(112, 325);
            this.txtQuantidade.MaxLength = 5;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Text = "0";
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.Enabled = false;
            this.btnFornecedor.Location = new System.Drawing.Point(114, 87);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(100, 38);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.Text = "Selecionar Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnQuantidade
            // 
            this.btnQuantidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantidade.Enabled = false;
            this.btnQuantidade.Location = new System.Drawing.Point(112, 360);
            this.btnQuantidade.Name = "btnQuantidade";
            this.btnQuantidade.Size = new System.Drawing.Size(100, 38);
            this.btnQuantidade.TabIndex = 8;
            this.btnQuantidade.Text = "Adicionar/Alterar Quantidade";
            this.btnQuantidade.UseVisualStyleBackColor = true;
            this.btnQuantidade.Click += new System.EventHandler(this.btnQuantidade_Click);
            // 
            // btnNProduto
            // 
            this.btnNProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNProduto.Location = new System.Drawing.Point(12, 438);
            this.btnNProduto.Name = "btnNProduto";
            this.btnNProduto.Size = new System.Drawing.Size(100, 38);
            this.btnNProduto.TabIndex = 1;
            this.btnNProduto.Text = "Cadastrar Novo Produto";
            this.btnNProduto.UseVisualStyleBackColor = true;
            this.btnNProduto.Click += new System.EventHandler(this.btnNProduto_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(114, 438);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 38);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.Location = new System.Drawing.Point(220, 438);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 38);
            this.btnSelecionar.TabIndex = 11;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(326, 438);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 38);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(432, 438);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 38);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(538, 438);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Enabled = false;
            this.txtCor.Location = new System.Drawing.Point(112, 258);
            this.txtCor.MaxLength = 20;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 6;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 513);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNProduto);
            this.Controls.Add(this.btnQuantidade);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtcProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduto);
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnNProduto;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCor;
        public System.Windows.Forms.TextBox txtFornecedor;
        public System.Windows.Forms.Button btnQuantidade;
        public System.Windows.Forms.Button btnCadastrar;
    }
}