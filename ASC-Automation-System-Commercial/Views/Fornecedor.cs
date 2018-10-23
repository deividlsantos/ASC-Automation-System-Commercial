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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorBD = new FornecedorDAO();
            dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
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
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(txtCep.Text, txtCnpj.Text, txtSocial.Text, txtFantasia.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.CadastrarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Cadastrado");
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
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(int.Parse(txtid_Fornecedor.Text), txtCep.Text, txtCnpj.Text, txtSocial.Text, txtFantasia.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.AlterarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Alterado");
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
                    MODEL.Fornecedor fornecedorReg = new MODEL.Fornecedor(int.Parse(txtid_Fornecedor.Text), txtCep.Text, txtCnpj.Text, txtSocial.Text, txtFantasia.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, int.Parse(txtNumero.Text), txtPais.Text);

                    fornecedorBD.DeletarFornecedor(fornecedorReg);
                    MessageBox.Show("Fornecedor Deletado");

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
        }
    }
}
