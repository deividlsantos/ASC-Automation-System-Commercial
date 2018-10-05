namespace ASC_Automation_System_Commercial
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDependentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btnListFun = new System.Windows.Forms.Button();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtCpfFun = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.produtosToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionarioToolStripMenuItem,
            this.listarFuncionarioToolStripMenuItem,
            this.cadastrarDependentesToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.produtosToolStripMenuItem.Text = "Funcionarios";
            // 
            // cadastrarFuncionarioToolStripMenuItem
            // 
            this.cadastrarFuncionarioToolStripMenuItem.Name = "cadastrarFuncionarioToolStripMenuItem";
            this.cadastrarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastrarFuncionarioToolStripMenuItem.Text = "Cadastrar Funcionario";
            this.cadastrarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionarioToolStripMenuItem_Click);
            // 
            // listarFuncionarioToolStripMenuItem
            // 
            this.listarFuncionarioToolStripMenuItem.Name = "listarFuncionarioToolStripMenuItem";
            this.listarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.listarFuncionarioToolStripMenuItem.Text = "Listar Funcionario";
            this.listarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.listarFuncionarioToolStripMenuItem_Click);
            // 
            // cadastrarDependentesToolStripMenuItem
            // 
            this.cadastrarDependentesToolStripMenuItem.Name = "cadastrarDependentesToolStripMenuItem";
            this.cadastrarDependentesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastrarDependentesToolStripMenuItem.Text = "Cadastrar Dependentes";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.produtosToolStripMenuItem1.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(80, 24);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(13, 91);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(775, 352);
            this.dgvLista.TabIndex = 1;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(12, 59);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(184, 22);
            this.txtCpfCliente.TabIndex = 2;
            this.txtCpfCliente.Visible = false;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(15, 36);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(164, 17);
            this.lblCpfCliente.TabIndex = 3;
            this.lblCpfCliente.Text = "Informe o CPF do Cliente";
            this.lblCpfCliente.Visible = false;
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Location = new System.Drawing.Point(202, 54);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(139, 31);
            this.btnListaClientes.TabIndex = 4;
            this.btnListaClientes.Text = "Listar Clientes";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Visible = false;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnListFun
            // 
            this.btnListFun.Location = new System.Drawing.Point(209, 55);
            this.btnListFun.Name = "btnListFun";
            this.btnListFun.Size = new System.Drawing.Size(153, 31);
            this.btnListFun.TabIndex = 7;
            this.btnListFun.Text = "Listar Funcionario";
            this.btnListFun.UseVisualStyleBackColor = true;
            this.btnListFun.Visible = false;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(15, 36);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(187, 17);
            this.lblFuncionario.TabIndex = 6;
            this.lblFuncionario.Text = "Informe o CPF do Funcinario";
            this.lblFuncionario.Visible = false;
            // 
            // txtCpfFun
            // 
            this.txtCpfFun.Location = new System.Drawing.Point(13, 58);
            this.txtCpfFun.Name = "txtCpfFun";
            this.txtCpfFun.Size = new System.Drawing.Size(190, 22);
            this.txtCpfFun.TabIndex = 5;
            this.txtCpfFun.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.btnListFun);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtCpfFun);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.Button btnListFun;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtCpfFun;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDependentesToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}