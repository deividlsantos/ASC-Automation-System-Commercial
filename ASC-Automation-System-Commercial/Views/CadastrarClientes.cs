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
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            habilitar();
            txtFiltro.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteBD = new ClienteDAO();
                Cliente clienteReg = new Cliente
                {
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Numero_casa = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.CadastrarCliente(clienteReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Cliente cadastrado com sucesso");
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
                ClienteDAO clienteBD = new ClienteDAO();
                Cliente clienteReg = new Cliente
                {
                    Id_cliente = Convert.ToInt32(txtIdCliente.Text),
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Numero_casa = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.Alterar(clienteReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Cliente alterado com sucesso");
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
                ClienteDAO clienteBD = new ClienteDAO();
                Cliente clienteReg = new Cliente
                {
                    Id_cliente = Convert.ToInt32(txtIdCliente.Text),
                    Id_endereco_fk = txtCep.Text,
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtDataNasc.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = cmbSexo.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Numero_casa = Convert.ToInt32(txtNumero.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.Excluir(clienteReg);
                limpar();
                desabilitar();
                txtFiltro.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Cliente deletado com sucesso");
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
                dgvListarClientes.DataSource = endereco.getEndereco(pesquisa, txtCep.Text);
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
                ClienteDAO clienteList = new ClienteDAO();
                string pesquisa = "Cpf";
                if (txtFiltro.Text == "")
                {
                    MessageBox.Show("Informe o CPF do Cliente");
                }
                else
                {
                    dgvListarClientes.DataSource = clienteList.getCliente(pesquisa, txtFiltro.Text);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void dgvListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSearch.Enabled == true)
            {
                DataGridViewRow LinhaSelecionada;
                LinhaSelecionada = dgvListarClientes.CurrentRow;
                txtCep.Text = LinhaSelecionada.Cells[1].Value.ToString();
                txtIdCliente.Text = LinhaSelecionada.Cells[0].Value.ToString();
                txtLogradouro.Text = LinhaSelecionada.Cells[10].Value.ToString();
                txtNumero.Text = LinhaSelecionada.Cells[11].Value.ToString();
                txtBairro.Text = LinhaSelecionada.Cells[12].Value.ToString();
                txtCidade.Text = LinhaSelecionada.Cells[13].Value.ToString();
                cmbEstado.Text = LinhaSelecionada.Cells[14].Value.ToString();
                txtPais.Text = LinhaSelecionada.Cells[15].Value.ToString();
                txtNome.Text = LinhaSelecionada.Cells[2].Value.ToString();
                txtCpf.Text = LinhaSelecionada.Cells[4].Value.ToString();
                txtRg.Text = LinhaSelecionada.Cells[3].Value.ToString();
                txtDataNasc.Text = LinhaSelecionada.Cells[5].Value.ToString();
                cmbSexo.Text = LinhaSelecionada.Cells[9].Value.ToString();
                txtTelefone.Text = LinhaSelecionada.Cells[7].Value.ToString();
                txtCelular.Text = LinhaSelecionada.Cells[8].Value.ToString();
                txtEmail.Text = LinhaSelecionada.Cells[6].Value.ToString();
                habilitar();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                txtFiltro.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                DataGridViewRow LinhaSelecionada;
                LinhaSelecionada = dgvListarClientes.CurrentRow;
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
            btnSalvar.Text = "";
            btnLimpar.Text = "";
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
            btnVerificar.Text = "";
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
