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

        String pesquisa;

        private void habilitarrdb()
        {
            rdbCodigo.Enabled = true;
            rdbMarca.Enabled = true;
            rdbTipo.Enabled = true;
            rdbModelo.Enabled = true;
            rdbTodos.Enabled = true;
        }

        private void desabilitarrdb()
        {
            rdbCodigo.Enabled = false;
            rdbMarca.Enabled = false;
            rdbTipo.Enabled = false;
            rdbModelo.Enabled = false;
            rdbTodos.Enabled = false;
        }

        private void habilitarcampos()
        {
            btnFornecedor.Enabled = true;
            txtFabricante.Enabled = true;
            cboTipo.Enabled = true;
            txtModelo.Enabled = true;
            txtCor.Enabled = true;
            txtPreco.Enabled = true;
            txtQuantidade.Enabled = true;
        }

        private void desabilitarcampos()
        {
            txtcProduto.Enabled = false;
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
            btnCadastrar.Enabled = false;
            btnSelecionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void limparcampos()
        {
            txtcProduto.Text = "";
            txtFornecedor.Text = "";
            txtFabricante.Text = "";
            cboTipo.Text = "Selecione";
            txtModelo.Text = "";
            txtCor.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnNProduto_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            desabilitarbtns();
            desabilitarrdb();
            btnFornecedor.Enabled = true;
            btnCadastrar.Enabled = true;
            limparcampos();
            dgvProduto.DataSource = "";
            txtQuantidade.Text = "0";
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            habilitarrdb();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            limparcampos();
            desabilitarcampos();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtcProduto.Enabled = true;
            txtcProduto.Focus();
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtFabricante.Enabled = true;
            txtFabricante.Focus();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            cboTipo.Enabled = true;
            cboTipo.Focus();
        }

        private void rdbModelo_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
            txtModelo.Enabled = true;
            txtModelo.Focus();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            limparcampos();
            desabilitarcampos();
            desabilitarbtns();
            btnSelecionar.Enabled = true;
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
                    txtQuantidade.Text = "0";
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos corretamente!!");
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false && rdbMarca.Checked == false && rdbTipo.Checked == false && rdbModelo.Checked == false && rdbTodos.Checked == false)
            {
                MessageBox.Show("Selecione alguma opção para realizar a busca!");
            }

            if (rdbCodigo.Checked == true) {

                if (txtcProduto.Text == "")
                {
                    MessageBox.Show("O campo codigo esta vazio!");
                }
                else
                {
                    ProdutoDAO codigoBD = new ProdutoDAO();
                    dgvProduto.DataSource = codigoBD.sCodigo(Convert.ToInt32(txtcProduto.Text));
                }
            }

            if (rdbMarca.Checked == true)
            {
                if (txtFabricante.Text == "")
                {
                    MessageBox.Show("O campo marca esta vazio!");
                }
                else
                {
                    ProdutoDAO fabricanteBD = new ProdutoDAO();
                    pesquisa = "fabricante";
                    dgvProduto.DataSource = fabricanteBD.sFabricante(pesquisa, txtFabricante.Text);
                }
            }

            if (rdbTipo.Checked == true)
            {
                if (cboTipo.Text == "")
                {
                    MessageBox.Show("Não foi selecionado o tipo de produto para a busca!");
                }
                else
                {
                    ProdutoDAO tipoBD = new ProdutoDAO();
                    dgvProduto.DataSource = tipoBD.sTipo(cboTipo.Text);
                }
            }

            if (rdbModelo.Checked == true)
            {
                if (txtModelo.Text == "")
                {
                    MessageBox.Show("O campo modelo esta vazio!");
                }
                else
                {
                    ProdutoDAO modeloBD = new ProdutoDAO();
                    pesquisa = "modelo";
                    dgvProduto.DataSource = modeloBD.sModelo(pesquisa, txtModelo.Text);
                }
            }

            if (rdbTodos.Checked == true)
            {
                ProdutoDAO todosBD = new ProdutoDAO();
                dgvProduto.DataSource = todosBD.getProduto();
            }

            desabilitarbtns();
            btnSelecionar.Enabled = true;
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
                    btnSelecionar.Enabled = true;
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
            FornecedorDAO fornecedorBD = new FornecedorDAO();
            dgvFornecedor.DataSource = fornecedorBD.getFornecedor();
            dgvFornecedor.Visible = true;
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

                btnAlterar.Enabled = true;
                btnDeletar.Enabled = true;
                txtQuantidade.Enabled = false;
                //txtcProduto.Enabled = false;
                habilitarcampos();
            
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvFornecedor.CurrentRow;
            txtFornecedor.Text = LinhaSelecionada.Cells[0].Value.ToString();
            dgvFornecedor.Visible = false;
        }
    }
}