namespace ASC_Automation_System_Commercial
{
    partial class CadastrarFuncionarios
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
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
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
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaFunc = new System.Windows.Forms.DataGridView();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDataAdm = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDataDem = new System.Windows.Forms.MaskedTextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(436, 593);
            this.txtFiltro.Mask = "000.000.000-00";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(468, 22);
            this.txtFiltro.TabIndex = 89;
            this.txtFiltro.ValidatingType = typeof(System.DateTime);
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(157, 94);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(107, 22);
            this.txtCep.TabIndex = 49;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.verificar;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.Enabled = false;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(270, 87);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(52, 37);
            this.btnVerificar.TabIndex = 88;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(801, 212);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(124, 22);
            this.txtPais.TabIndex = 60;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(797, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 20);
            this.label18.TabIndex = 87;
            this.label18.Text = "Pais";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(910, 595);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 22);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(153, 593);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(253, 20);
            this.label16.TabIndex = 85;
            this.label16.Text = "Informe o Cpf do Funcionario";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(345, 94);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(133, 22);
            this.txtIdFunc.TabIndex = 84;
            this.txtIdFunc.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(341, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 83;
            this.label17.Text = "Id Funcionario";
            this.label17.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(554, 398);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 22);
            this.txtEmail.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(558, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 82;
            this.label15.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(558, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 20);
            this.label14.TabIndex = 81;
            this.label14.Text = "Data de Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Enabled = false;
            this.txtDataNasc.Location = new System.Drawing.Point(562, 341);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(176, 22);
            this.txtDataNasc.TabIndex = 66;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(372, 398);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 22);
            this.txtCelular.TabIndex = 70;
            this.txtCelular.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(368, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 80;
            this.label13.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(157, 398);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(162, 22);
            this.txtTelefone.TabIndex = 69;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 79;
            this.label12.Text = "Telefone Fixo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Enabled = false;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(792, 341);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 24);
            this.cmbSexo.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(788, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 77;
            this.label10.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(372, 341);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(162, 22);
            this.txtRg.TabIndex = 64;
            this.txtRg.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 76;
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
            this.cmbEstado.Location = new System.Drawing.Point(655, 210);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(710, 153);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(133, 22);
            this.txtNumero.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Numero";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(420, 212);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(216, 22);
            this.txtCidade.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(157, 212);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(247, 22);
            this.txtBairro.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(157, 153);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(540, 22);
            this.txtLogradouro.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Cep";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(157, 341);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(162, 22);
            this.txtCpf.TabIndex = 63;
            this.txtCpf.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(157, 288);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(415, 22);
            this.txtNome.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(36, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 37);
            this.btnExcluir.TabIndex = 58;
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
            this.btnLimpar.Location = new System.Drawing.Point(36, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(52, 37);
            this.btnLimpar.TabIndex = 56;
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
            this.btnAlterar.Location = new System.Drawing.Point(36, 173);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(52, 37);
            this.btnAlterar.TabIndex = 54;
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
            this.btnSalvar.Location = new System.Drawing.Point(36, 116);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 42);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.BackgroundImage = global::ASC_Automation_System_Commercial.Properties.Resources.novoCliente1;
            this.btnNovoFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoFunc.FlatAppearance.BorderSize = 0;
            this.btnNovoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFunc.Location = new System.Drawing.Point(36, 68);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(52, 42);
            this.btnNovoFunc.TabIndex = 51;
            this.btnNovoFunc.UseVisualStyleBackColor = true;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnNovoFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 44);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cadastro Funcionario";
            // 
            // dgvListaFunc
            // 
            this.dgvListaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFunc.Location = new System.Drawing.Point(157, 623);
            this.dgvListaFunc.Name = "dgvListaFunc";
            this.dgvListaFunc.RowTemplate.Height = 24;
            this.dgvListaFunc.Size = new System.Drawing.Size(789, 220);
            this.dgvListaFunc.TabIndex = 90;
            this.dgvListaFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFunc_CellClick);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Enabled = false;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCargo.Location = new System.Drawing.Point(157, 464);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(256, 24);
            this.cmbCargo.TabIndex = 91;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(153, 441);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 92;
            this.label19.Text = "Cargo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(608, 260);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 20);
            this.label20.TabIndex = 94;
            this.label20.Text = "Estado Civil";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Enabled = false;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viuvo"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(613, 286);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(256, 24);
            this.cmbEstadoCivil.TabIndex = 93;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(441, 441);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 20);
            this.label21.TabIndex = 96;
            this.label21.Text = "Data de Admissao";
            // 
            // txtDataAdm
            // 
            this.txtDataAdm.Enabled = false;
            this.txtDataAdm.Location = new System.Drawing.Point(445, 466);
            this.txtDataAdm.Mask = "00/00/0000";
            this.txtDataAdm.Name = "txtDataAdm";
            this.txtDataAdm.Size = new System.Drawing.Size(176, 22);
            this.txtDataAdm.TabIndex = 95;
            this.txtDataAdm.ValidatingType = typeof(System.DateTime);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(651, 441);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(165, 20);
            this.label22.TabIndex = 98;
            this.label22.Text = "Data de Demissao";
            // 
            // txtDataDem
            // 
            this.txtDataDem.Enabled = false;
            this.txtDataDem.Location = new System.Drawing.Point(655, 466);
            this.txtDataDem.Mask = "00/00/0000";
            this.txtDataDem.Name = "txtDataDem";
            this.txtDataDem.Size = new System.Drawing.Size(176, 22);
            this.txtDataDem.TabIndex = 97;
            this.txtDataDem.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.Enabled = false;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Afastado"});
            this.cmbSituacao.Location = new System.Drawing.Point(157, 538);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 24);
            this.cmbSituacao.TabIndex = 99;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(153, 512);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 20);
            this.label23.TabIndex = 100;
            this.label23.Text = "Situacao";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(358, 512);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 20);
            this.label24.TabIndex = 102;
            this.label24.Text = "Salario";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(324, 542);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 20);
            this.label25.TabIndex = 103;
            this.label25.Text = "R$";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(362, 540);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(124, 22);
            this.txtSalario.TabIndex = 101;
            // 
            // CadastrarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 864);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtDataDem);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDataAdm);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.dgvListaFunc);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtIdFunc);
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
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovoFunc);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFuncionarios";
            this.Text = "Cadastrar Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox txtFiltro;
        public System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnVerificar;
        public System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIdFunc;
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
        public System.Windows.Forms.MaskedTextBox txtCpf;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaFunc;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.MaskedTextBox txtDataAdm;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.MaskedTextBox txtDataDem;
        public System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox txtSalario;
    }
}