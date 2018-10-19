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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        public void habilitarcampos()
        {
            btnFornecedor.Enabled = true;
            txtFabricante.Enabled = true;
            cboTipo.Enabled = true;
            txtModelo.Enabled = true;
            txtCor.Enabled = true;
            txtPreco.Enabled = true;
        }

        private void desabilitarcampos()
        {
            btnFornecedor.Enabled = false;
            txtFabricante.Enabled = false;
            cboTipo.Enabled = false;
            txtModelo.Enabled = false;
            txtCor.Enabled = false;
            txtPreco.Enabled = false;
            txtQuantidade.Enabled = false;
        }

        private void desabilitarbtns()
        {
            btnFornecedor.Enabled = false;
            btnQuantidade.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void limparcampos()
        {
            txtcProduto.Text = "";
            txtFornecedor.Text = "";
            txtFabricante.Text = "";
            cboTipo.Text = "";
            txtModelo.Text = "";
            txtCor.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnNProduto_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            desabilitarbtns();
            btnFornecedor.Enabled = true;
            btnCadastrar.Enabled = true;
            txtQuantidade.Enabled = false;
            btnQuantidade.Enabled = true;
            dgvProduto.DataSource = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == "" || txtFabricante.Text == "" || cboTipo.Text == "" || txtModelo.Text == "" || txtCor.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    ProdutoDAO produtoBD = new ProdutoDAO();
                    MODEL.Produto produtoReg = new MODEL.Produto(int.Parse(txtFornecedor.Text), txtFabricante.Text, cboTipo.Text, txtModelo.Text, txtCor.Text, Double.Parse(txtPreco.Text), int.Parse(txtQuantidade.Text));

                    produtoBD.CadastrarProduto(produtoReg);
                    MessageBox.Show("Produto Cadastrado");
                    limparcampos();
                    dgvProduto.DataSource = produtoBD.getProduto();
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!!");
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoBD = new ProdutoDAO();
            dgvProduto.DataSource = produtoBD.getProduto();
            desabilitarcampos();
            desabilitarbtns();
            btnAlterar.Enabled = false;
            limparcampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == "" || txtFabricante.Text == "" || cboTipo.Text == "" || txtModelo.Text == "" || txtCor.Text == "" || txtPreco.Text == "" || txtQuantidade.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    ProdutoDAO produtoBD = new ProdutoDAO();
                    MODEL.Produto produtoReg = new MODEL.Produto(int.Parse(txtcProduto.Text), int.Parse(txtFornecedor.Text), txtFabricante.Text, cboTipo.Text, txtModelo.Text, txtCor.Text, Double.Parse(txtPreco.Text), int.Parse(txtQuantidade.Text));

                    produtoBD.AlterarProduto(produtoReg);
                    desabilitarcampos();
                    desabilitarbtns();
                    btnAlterar.Enabled = false;
                    MessageBox.Show("Produto Alterado");
                    limparcampos();
                    dgvProduto.DataSource = produtoBD.getProduto();
                }
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == "" || txtFabricante.Text == "" || cboTipo.Text == "" || txtModelo.Text == "" || txtCor.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
            }
            else
            {
                try
                {
                    ProdutoDAO produtoBD = new ProdutoDAO();
                    MODEL.Produto produtoReg = new MODEL.Produto(int.Parse(txtcProduto.Text), int.Parse(txtFornecedor.Text), txtFabricante.Text, cboTipo.Text, txtModelo.Text, txtCor.Text, Double.Parse(txtPreco.Text), int.Parse(txtQuantidade.Text));

                    produtoBD.DeletarProduto(produtoReg);
                    desabilitarcampos();
                    desabilitarbtns();
                    btnAlterar.Enabled = false;
                    MessageBox.Show("Produto Deletado");
                    limparcampos();
                    dgvProduto.DataSource = produtoBD.getProduto();
                }
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor abre = new SelecionarFornecedor();
            FornecedorDAO fornecedorBD = new FornecedorDAO();
            abre.dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
            abre.Show();
            this.Close();
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {
            desabilitarcampos();
            btnFornecedor.Enabled = false;
            txtQuantidade.Enabled = true;
            btnQuantidade.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvProduto.CurrentRow;
            txtcProduto.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtFornecedor.Text = LinhaSelecionada.Cells[1].Value.ToString();
            txtFabricante.Text = LinhaSelecionada.Cells[2].Value.ToString();
            cboTipo.Text = LinhaSelecionada.Cells[3].Value.ToString();
            txtModelo.Text = LinhaSelecionada.Cells[4].Value.ToString();
            txtCor.Text = LinhaSelecionada.Cells[5].Value.ToString();
            txtPreco.Text = LinhaSelecionada.Cells[6].Value.ToString();
            txtQuantidade.Text = LinhaSelecionada.Cells[7].Value.ToString();

            btnQuantidade.Enabled = true;
            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
            txtQuantidade.Enabled = false;
            habilitarcampos();
        }

       
    }
}
