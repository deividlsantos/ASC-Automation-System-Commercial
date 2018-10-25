using ASC_Automation_System_Commercial.DAO;
using ASC_Automation_System_Commercial.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASC_Automation_System_Commercial
{
    public partial class CadastrarFuncionarios : Form
    {
        public CadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            habilitar();
            txtFiltro.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO funcionarioBD = new FuncionarioDAO();
                Funcionario funcinarioReg = new Funcionario
                {
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Email = txtEmail.Text,
                    Numero_residencia = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                    Data_admissao = txtDataAdm.Text,
                    Data_demissao = txtDataDem.Text,
                    Id_cargo_fk = Convert.ToInt32(cmbCargo.Text),
                    Salario = Convert.ToDouble(txtSalario.Text),
                    Estado_civil = cmbEstadoCivil.Text,
                    Situacao = cmbSituacao.Text,
                };
                funcionarioBD.CadastrarFuncionarios(funcinarioReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Funcionario cadastrado com sucesso");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO funcionarioBD = new FuncionarioDAO();
                Funcionario funcinarioReg = new Funcionario
                {
                    Id_funcionario = Convert.ToInt32(txtIdFunc.Text),
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Email = txtEmail.Text,
                    Numero_residencia = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                    Data_admissao = txtDataAdm.Text,
                    Data_demissao = txtDataDem.Text,
                    Id_cargo_fk = Convert.ToInt32(cmbCargo.Text),
                    Salario = Convert.ToDouble(txtSalario.Text),
                    Estado_civil = cmbEstadoCivil.Text,
                    Situacao = cmbSituacao.Text,
                };
                funcionarioBD.Alterar(funcinarioReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Funcionario Alterado com sucesso");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO funcionarioBD = new FuncionarioDAO();
                Funcionario funcinarioReg = new Funcionario
                {
                    Id_funcionario = Convert.ToInt32(txtIdFunc.Text),
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Email = txtEmail.Text,
                    Numero_residencia = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                    Data_admissao = txtDataAdm.Text,
                    Data_demissao = txtDataDem.Text,
                    Id_cargo_fk = Convert.ToInt32(cmbCargo.Text),
                    Salario = Convert.ToDouble(txtSalario.Text),
                    Estado_civil = cmbEstadoCivil.Text,
                    Situacao = cmbSituacao.Text,
                };
                funcionarioBD.Excluir(funcinarioReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Funcionario Deletado com sucesso");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoDAO endereco = new EnderecoDAO();
                string pesquisa = "cep";
                dgvListaFunc.DataSource = endereco.getEndereco(pesquisa, txtCep.Text);
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO funcList = new FuncionarioDAO();
                string pesquisa = "Cpf";
                if (txtFiltro.Text == null)
                {
                    MessageBox.Show("Informe o CPF do Funcionario");
                }
                else
                {
                    dgvListaFunc.DataSource = funcList.getFunc(pesquisa, txtFiltro.Text);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void dgvListaFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSearch.Enabled == true)
            {
                DataGridViewRow LinhaSelecionada;
                LinhaSelecionada = dgvListaFunc.CurrentRow;
                txtCep.Text = LinhaSelecionada.Cells[1].Value.ToString();
                txtIdFunc.Text = LinhaSelecionada.Cells[0].Value.ToString();
                txtLogradouro.Text = LinhaSelecionada.Cells[17].Value.ToString();
                txtNumero.Text = LinhaSelecionada.Cells[18].Value.ToString();
                txtBairro.Text = LinhaSelecionada.Cells[19].Value.ToString();
                txtCidade.Text = LinhaSelecionada.Cells[20].Value.ToString();
                cmbEstado.Text = LinhaSelecionada.Cells[21].Value.ToString();
                txtPais.Text = LinhaSelecionada.Cells[22].Value.ToString();
                txtNome.Text = LinhaSelecionada.Cells[3].Value.ToString();
                txtCpf.Text = LinhaSelecionada.Cells[7].Value.ToString();
                txtRg.Text = LinhaSelecionada.Cells[6].Value.ToString();
                txtDataNasc.Text = LinhaSelecionada.Cells[8].Value.ToString();
                cmbSexo.Text = LinhaSelecionada.Cells[13].Value.ToString();
                txtTelefone.Text = LinhaSelecionada.Cells[11].Value.ToString();
                txtCelular.Text = LinhaSelecionada.Cells[12].Value.ToString();
                txtEmail.Text = LinhaSelecionada.Cells[10].Value.ToString();
                txtDataAdm.Text = LinhaSelecionada.Cells[15].Value.ToString();
                txtDataDem.Text = LinhaSelecionada.Cells[16].Value.ToString();
                cmbEstadoCivil.Text = LinhaSelecionada.Cells[9].Value.ToString();
                txtSalario.Text = LinhaSelecionada.Cells[5].Value.ToString();
                cmbSituacao.Text = LinhaSelecionada.Cells[14].Value.ToString();
                cmbCargo.Text = LinhaSelecionada.Cells[2].Value.ToString();
                habilitar();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                txtFiltro.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                DataGridViewRow LinhaSelecionada;
                LinhaSelecionada = dgvListaFunc.CurrentRow;
                txtLogradouro.Text = LinhaSelecionada.Cells[1].Value.ToString();
                txtBairro.Text = LinhaSelecionada.Cells[2].Value.ToString();
                txtCidade.Text = LinhaSelecionada.Cells[3].Value.ToString();
                cmbEstado.Text = LinhaSelecionada.Cells[4].Value.ToString();
                txtNumero.Text = "";
                txtPais.Text = "";
            }
        }

        public void limpar()
        {
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbEstado.Text = "";
            txtPais.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtDataNasc.Text = "";
            cmbSexo.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataAdm.Text = "";
            txtDataDem.Text = "";
            cmbEstadoCivil.Text = "";
            txtSalario.Text = "";
            cmbSituacao.Text = "";
            cmbCargo.Text = "";

        }
        public void desabilitar()
        {
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            txtCep.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtPais.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtDataNasc.Enabled = false;
            cmbSexo.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            btnVerificar.Enabled = false;
            txtDataAdm.Enabled = false;
            txtDataDem.Enabled = false;
            cmbCargo.Enabled = false;
            txtSalario.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbSituacao.Enabled = false;
        }

        public void habilitar()
        {
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            txtCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstado.Enabled = true;
            txtPais.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtDataNasc.Enabled = true;
            cmbSexo.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            btnVerificar.Enabled = true;
            txtDataAdm.Enabled = true;
            txtDataDem.Enabled = true;
            cmbCargo.Enabled = true;
            txtSalario.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbSituacao.Enabled = true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorEmail.SetError(txtEmail, errorMsg);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorEmail.SetError(txtEmail, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Email invalido ex: someone@example.com ";
            return false;
        }
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            if (!IsCpf(txtCpf.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtCpf.Select(0, txtCpf.Text.Length);
            }
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);

        }
    }
   
}
