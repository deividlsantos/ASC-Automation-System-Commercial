using ASC_Automation_System_Commercial.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASC_Automation_System_Commercial.Views
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        String pesquisa;

        private void habilitarrdb()
        {
            rdbCnpf.Enabled = true;
            rdbSocial.Enabled = true;
            rdbFantasia.Enabled = true;
            rdbTodos.Enabled = true;
        }

        private void desabilitarrdb()
        {
            rdbCnpf.Enabled = false;
            rdbSocial.Enabled = false;
            rdbFantasia.Enabled = false;
            rdbTodos.Enabled = false;
        }

        private void desabilitarbtns()
        {
            btnCadastrar.Enabled = false;
            btnSelecionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void limparcampos()
        {
            txtid_Fornecedor.Text = "";
            txtCep.Text = "";
            txtSocial.Text = "";
            txtFantasia.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtNumero.Text = "";
            txtPais.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }

        private void habilitarcampos()
        {
            txtid_Fornecedor.Enabled = true;
            txtCep.Enabled = true;
            txtSocial.Enabled = true;
            txtFantasia.Enabled = true;
            txtCnpj.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtNumero.Enabled = true;
            txtPais.Enabled = true;
        }

        private void desabilitarcampos()
        {
            txtid_Fornecedor.Enabled = false;
            txtCep.Enabled = false;
            txtSocial.Enabled = false;
            txtFantasia.Enabled = false;
            txtCnpj.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtNumero.Enabled = false;
            txtPais.Enabled = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rdbCnpf.Checked == false && rdbSocial.Checked == false && rdbFantasia.Checked == false && rdbTodos.Checked == false)
            {
                MessageBox.Show("Selecione alguma opção para realizar a busca!");
            }

            if (rdbCnpf.Checked == true)
            {

                if (txtCnpj.Text == "")
                {
                    MessageBox.Show("O campo Cnpj esta vazio!");
                }
                else
                {
                    FornecedorDAO cnpjBD = new FornecedorDAO();
                    dgvFornecedor.DataSource = cnpjBD.cnpj(Convert.ToInt32(txtCnpj.Text));
                }
            }

            if (rdbSocial.Checked == true)
            {
                if (txtSocial.Text == "")
                {
                    MessageBox.Show("O campo Razão Social esta vazio!");
                }
                else
                {
                    FornecedorDAO socialBD = new FornecedorDAO();
                    pesquisa = "razao_social";
                    dgvFornecedor.DataSource = socialBD.social(pesquisa, txtSocial.Text);
                }
            }

            if (rdbFantasia.Checked == true)
            {
                if (txtFantasia.Text == "")
                {
                    MessageBox.Show("O campo Nome Fantasia esta vazio!");
                }
                else
                {
                    FornecedorDAO fantasiaBD = new FornecedorDAO();
                    pesquisa = "nome_fantasia";
                    dgvFornecedor.DataSource = fantasiaBD.fantasia(pesquisa, txtFantasia.Text);
                }
            }

            if (rdbTodos.Checked == true)
            {
                FornecedorDAO todosBD = new FornecedorDAO();
                dgvFornecedor.DataSource = todosBD.getFornecedor();
            }

            desabilitarbtns();
            btnSelecionar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text == "" || txtSocial.Text == "" || txtFantasia.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    FornecedorDAO fornecedorBD = new FornecedorDAO();
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(txtCep.Text, int.Parse(txtCnpj.Text), txtSocial.Text, txtFantasia.Text, int.Parse(txtTelefone.Text), int.Parse(txtCelular.Text), txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.CadastrarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Cadastrado");
                    limparcampos();
                    dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
                }
                catch (Exception)
                {
                   MessageBox.Show("Todos os campos devem estar preenchidos corretamente!!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text == "" || txtSocial.Text == "" || txtFantasia.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    FornecedorDAO fornecedorBD = new FornecedorDAO();
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(int.Parse(txtid_Fornecedor.Text), txtCep.Text, int.Parse(txtCnpj.Text), txtSocial.Text, txtFantasia.Text, int.Parse(txtTelefone.Text), int.Parse(txtCelular.Text), txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.AlterarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Alterado");
                    dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
                }
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text == "" || txtSocial.Text == "" || txtFantasia.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    FornecedorDAO fornecedorBD = new FornecedorDAO();
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(int.Parse(txtid_Fornecedor.Text), txtCep.Text, int.Parse(txtCnpj.Text), txtSocial.Text, txtFantasia.Text, int.Parse(txtTelefone.Text), int.Parse(txtCelular.Text), txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.DeletarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Deletado");
                    dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
                    limparcampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
                }
            }
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvFornecedor.CurrentRow;
            txtid_Fornecedor.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtCep.Text = LinhaSelecionada.Cells[1].Value.ToString();
            txtSocial.Text = LinhaSelecionada.Cells[2].Value.ToString();
            txtFantasia.Text = LinhaSelecionada.Cells[3].Value.ToString();
            txtCnpj.Text = LinhaSelecionada.Cells[4].Value.ToString();
            txtTelefone.Text = LinhaSelecionada.Cells[5].Value.ToString();
            txtCelular.Text = LinhaSelecionada.Cells[6].Value.ToString();
            txtEmail.Text = LinhaSelecionada.Cells[7].Value.ToString();
            txtNumero.Text = LinhaSelecionada.Cells[8].Value.ToString();
            txtPais.Text = LinhaSelecionada.Cells[9].Value.ToString();
            txtLogradouro.Text = LinhaSelecionada.Cells[10].Value.ToString();
            txtBairro.Text = LinhaSelecionada.Cells[11].Value.ToString();
            txtCidade.Text = LinhaSelecionada.Cells[12].Value.ToString();
            txtEstado.Text = LinhaSelecionada.Cells[13].Value.ToString();
            habilitarcampos();
            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoDAO endereco = new EnderecoDAO();
                string pesquisa = "cep";
                dgvEndereco.DataSource = endereco.getEndereco(pesquisa, txtCep.Text);
                dgvEndereco.Visible = true;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvEndereco.CurrentRow;
            txtLogradouro.Text = LinhaSelecionada.Cells[1].Value.ToString();
            txtBairro.Text = LinhaSelecionada.Cells[2].Value.ToString();
            txtCidade.Text = LinhaSelecionada.Cells[3].Value.ToString();
            txtEstado.Text = LinhaSelecionada.Cells[4].Value.ToString();
            dgvEndereco.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            habilitarrdb();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            limparcampos();
            desabilitarcampos();
        }

        private void rdbCnpf_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtCnpj.Enabled = true;
            txtCnpj.Focus();
        }

        private void rdbSocial_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtSocial.Enabled = true;
            txtSocial.Focus();
        }

        private void rdbFantasia_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtFantasia.Enabled = true;
            txtFantasia.Focus();
        }

        private void btnNFornecedor_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            desabilitarbtns();
            desabilitarrdb();
            btnCadastrar.Enabled = true;
            btnEndereco.Enabled = true;
            limparcampos();
            dgvFornecedor.DataSource = "";
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
        }
    }
}
