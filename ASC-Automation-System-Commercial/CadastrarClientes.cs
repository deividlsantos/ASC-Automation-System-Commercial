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

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {

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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            habilitar();
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
                MessageBox.Show("Cliente cadastrado com sucesso");
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
                ProcurarEndereco abre = new ProcurarEndereco();
                abre.dgvEndereco.DataSource = endereco.getEndereco(pesquisa, txtCep.Text);
                abre.ShowDialog();
                this.Close();
            }
            catch(Exception c)
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
                if(txtFiltro.Text == "")
                {
                    MessageBox.Show("Informe o CPF do Cliente");
                }
                else { 
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
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvListarClientes.CurrentRow;
            /*"SELECT id_cliente, id_endereco_fk, nome, rg, cpf, data_nascimento, email, telefone, celular, sexo" 
                + ", logradouro, numero_casa, bairro, cidade, estado, pais FROM cliente inner join " 
                + "endereco on cliente.id_endereco_fk = endereco.Cep where " + pesquisa + " like '%" + Cpf + "%'";*/
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
                MessageBox.Show("Cliente alterado com sucesso");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
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
                MessageBox.Show("Cliente deletado com sucesso");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
