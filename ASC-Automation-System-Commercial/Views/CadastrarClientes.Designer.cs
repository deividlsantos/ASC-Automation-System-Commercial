namespace ASC_Automation_System_Commercial
{
    partial class CadastrarClientes
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.dgvListarClientes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(116, 76);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(81, 20);
            this.txtCep.TabIndex = 46;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.verificar;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.Enabled = false;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(200, 70);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(39, 30);
            this.btnVerificar.TabIndex = 84;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(598, 171);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(94, 20);
            this.txtPais.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(596, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 17);
            this.label18.TabIndex = 83;
            this.label18.Text = "Pais";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(256, 76);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(101, 20);
            this.txtIdCliente.TabIndex = 82;
            this.txtIdCliente.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(254, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 81;
            this.label17.Text = "Id Cliente";
            this.label17.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(419, 327);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 20);
            this.txtEmail.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(416, 304);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(416, 256);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 17);
            this.label14.TabIndex = 79;
            this.label14.Text = "Data de Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Enabled = false;
            this.txtDataNasc.Location = new System.Drawing.Point(419, 276);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(133, 20);
            this.txtDataNasc.TabIndex = 64;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(277, 323);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(122, 20);
            this.txtCelular.TabIndex = 68;
            this.txtCelular.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 304);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 78;
            this.label13.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(116, 323);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(122, 20);
            this.txtTelefone.TabIndex = 67;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 304);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Telefone Fixo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Enabled = false;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(592, 276);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(92, 21);
            this.cmbSexo.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(589, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(277, 276);
            this.txtRg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(122, 20);
            this.txtRg.TabIndex = 62;
            this.txtRg.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "CPF";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmbEstado.Location = new System.Drawing.Point(489, 170);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(92, 21);
            this.cmbEstado.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(530, 124);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(101, 20);
            this.txtNumero.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Numero";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(313, 171);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(163, 20);
            this.txtCidade.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(116, 171);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 20);
            this.txtBairro.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(116, 124);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(406, 20);
            this.txtLogradouro.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cep";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(116, 233);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(600, 20);
            this.txtNome.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(25, 217);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(39, 30);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(25, 175);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(39, 30);
            this.btnLimpar.TabIndex = 54;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.atualizar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(25, 140);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(39, 30);
            this.btnAlterar.TabIndex = 52;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.save;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(25, 93);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(39, 34);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.novoCliente1;
            this.btnNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Location = new System.Drawing.Point(25, 54);
            this.btnNovoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(39, 34);
            this.btnNovoCliente.TabIndex = 49;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cadastro Cliente";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(300, 379);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltro.Mask = "000.000.000-00";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(384, 20);
            this.txtFiltro.TabIndex = 88;
            this.txtFiltro.ValidatingType = typeof(System.DateTime);
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarClientes.Location = new System.Drawing.Point(116, 404);
            this.dgvListarClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.RowTemplate.Height = 24;
            this.dgvListarClientes.Size = new System.Drawing.Size(598, 206);
            this.dgvListarClientes.TabIndex = 87;
            this.dgvListarClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarClientes_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(687, 381);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 18);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(119, 379);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 17);
            this.label16.TabIndex = 85;
            this.label16.Text = "Informe o Cpf do Cliente";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(115, 276);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(123, 20);
            this.txtCpf.TabIndex = 89;
            // 
            // CadastrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 609);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvListarClientes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CadastrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorEmail;
        public System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvListarClientes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnVerificar;
        public System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox txtDataNasc;
        public System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
    }
}