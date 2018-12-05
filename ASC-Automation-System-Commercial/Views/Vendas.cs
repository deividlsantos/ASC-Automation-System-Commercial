using ASC_Automation_System_Commercial.DAO;
using MySql.Data.MySqlClient;
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
    public partial class Vendas : Form
    {
        String Con;

        public Vendas()
        {
            InitializeComponent();

            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        String pesquisa;

        private void limpar()
        {
            rdbCodigo.Checked = false;
            rdbMarca.Checked = false;
            rdbTipo.Checked = false;
            rdbModelo.Checked = false;
            rdbTodos.Checked = false;
            txtProduto.Text = "";
            txtProduto.Enabled = false;
            dgvProduto.DataSource = "";
            dgvProduto.Enabled = false;
            txtcProduto.Text = "";
            txtFabricante.Text = "";
            txtTipo.Text = "";
            txtModelo.Text = "";
            txtCor.Text = "";
            txtPreco.Text = "0";
            tQuantidade.Text = "0";
            tQuantidade.Enabled = false;
            btnAdicionar.Enabled = false;
            txtValorProduto.Text = "0";
            txtFuncionario.Text = "";
            txtid_Funcionario.Text = "";
            txtNomeCliente.Text = "";
            txtIdCli.Text = "";
            dgvVenda.DataSource = "";
            dgvVenda.Enabled = false;
            btnItem.Enabled = false;
            btnFinalizar.Enabled = false;
            txtValorTotal.Text = "";
        }

        private void btnPesqProd_Click(object sender, EventArgs e)
        {

            if (rdbCodigo.Checked == false && rdbMarca.Checked == false && rdbTipo.Checked == false && rdbModelo.Checked == false && rdbTodos.Checked == false)
            {
                MessageBox.Show("Selecione alguma opção para realizar a busca!");
            }

            if (rdbCodigo.Checked == true)
            {
                if (txtProduto.Text == "")
                {
                    MessageBox.Show("O campo busca esta vazio!");
                }
                else
                {
                    ProdutoDAO codigoBD = new ProdutoDAO();
                    dgvProduto.DataSource = codigoBD.sCodigo(Convert.ToInt32(txtProduto.Text));
                }
            }

            if (rdbMarca.Checked == true)
            {
                if (txtProduto.Text == "")
                {
                    MessageBox.Show("O campo busca esta vazio!");
                }
                else
                {
                    ProdutoDAO fabricanteBD = new ProdutoDAO();
                    pesquisa = "fabricante";
                    dgvProduto.DataSource = fabricanteBD.sFabricante(pesquisa, txtProduto.Text);
                }
            }

            if (rdbTipo.Checked == true)
            {
                if (cboTipo.Text == "Selecione")
                {
                    MessageBox.Show("Selecione um tipo de produto para busca!");
                }
                else
                {
                    ProdutoDAO tipoBD = new ProdutoDAO();
                    dgvProduto.DataSource = tipoBD.sTipo(cboTipo.Text);
                }
            }

            if (rdbModelo.Checked == true)
            {
                if (txtProduto.Text == "")
                {
                    MessageBox.Show("O campo busca esta vazio!");
                }
                else
                {
                    ProdutoDAO modeloBD = new ProdutoDAO();
                    pesquisa = "modelo";
                    dgvProduto.DataSource = modeloBD.sModelo(pesquisa, txtProduto.Text);
                }
            }

            if (rdbTodos.Checked == true)
            {
                ProdutoDAO todosBD = new ProdutoDAO();
                dgvProduto.DataSource = todosBD.getProduto();
            }

            dgvProduto.Enabled = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (txtcFuncionario.Text == "")
            {
                MessageBox.Show("Informe o ID funcionario!");
            }
            else
            {
                dgvFuncionario.Visible = true;
                FuncionarioDAO codigoBD = new FuncionarioDAO();
                dgvFuncionario.DataSource = codigoBD.sCodigo(Convert.ToInt32(txtcFuncionario.Text));
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvFuncionario.CurrentRow;
            txtid_Funcionario.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtFuncionario.Text = LinhaSelecionada.Cells[2].Value.ToString();
            txtcFuncionario.Text = "";
            dgvFuncionario.DataSource = "";
            dgvFuncionario.Visible = false;
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteList = new ClienteDAO();
                string pesquisa = "Cpf";
                if (txtCpfCliente.Text == "")
                {
                    MessageBox.Show("Informe o CPF do Cliente");
                }
                else
                {

                    dgvCliente.DataSource = clienteList.getCliente(pesquisa, txtCpfCliente.Text);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvCliente.CurrentRow;
            txtIdCli.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtNomeCliente.Text = LinhaSelecionada.Cells[2].Value.ToString();
            dgvCliente.DataSource = "";
            txtCpfCliente.Text = "";
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tQuantidade.Text = "0";
            txtValorProduto.Text = "0";
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvProduto.CurrentRow;
            txtcProduto.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtFabricante.Text = LinhaSelecionada.Cells[2].Value.ToString();
            txtTipo.Text = LinhaSelecionada.Cells[3].Value.ToString();
            txtModelo.Text = LinhaSelecionada.Cells[4].Value.ToString();
            txtCor.Text = LinhaSelecionada.Cells[5].Value.ToString();
            txtPreco.Text = LinhaSelecionada.Cells[6].Value.ToString();
            txtProduto.Text = "";
            tQuantidade.Enabled = true;
            btnAdicionar.Enabled = true;
        }

       

        

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtProduto.Enabled = false;
            txtProduto.Text = "";
            cboTipo.Enabled = false;
            cboTipo.Text = "Selecione";
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtProduto.Text = "";
            txtProduto.Focus();
            cboTipo.Enabled = false;
            cboTipo.Text = "Selecione";
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtProduto.Text = "";
            txtProduto.Focus();
            cboTipo.Enabled = false;
            cboTipo.Text = "Selecione";
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            txtProduto.Enabled = false;
            txtProduto.Text = "";
            cboTipo.Enabled = true;
            cboTipo.Text = "Selecione";
            cboTipo.Focus();
        }

        private void rdbModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtProduto.Text = "";
            txtProduto.Focus();
            cboTipo.Enabled = false;
            cboTipo.Text = "Selecione";
        }

        private void tQuantidade_Click(object sender, EventArgs e)
        {
            int vUnitario, Quantidade, sTotal;

            vUnitario = int.Parse(txtPreco.Text);
            Quantidade = int.Parse(tQuantidade.Text);
            sTotal = int.Parse(txtValorProduto.Text);

            sTotal = Quantidade * vUnitario;
            txtValorProduto.Text = Convert.ToString(sTotal);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (tQuantidade.Text == "0")
            {
                MessageBox.Show("Minimo de uma quantidade por produto!");
            }
            else
            {
                dgvVenda.Rows.Add(txtcProduto.Text, txtFabricante.Text, txtTipo.Text, txtModelo.Text, txtCor.Text, tQuantidade.Text, txtPreco.Text, txtValorProduto.Text);
                txtValorTotal.Text = dgvVenda.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToInt32(i.Cells[7].Value ?? 0)).ToString();
                dgvVenda.Enabled = true;
                btnItem.Enabled = true;
                btnCancelar.Enabled = true;
                btnFinalizar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (this.dgvVenda.SelectedRows.Count > 0)
            {
                dgvVenda.Rows.RemoveAt(this.dgvVenda.SelectedRows[0].Index);
                txtValorTotal.Text = dgvVenda.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToInt32(i.Cells[7].Value ?? 0)).ToString();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtid_Funcionario.Text == "" || txtIdCli.Text == "")
            {
                MessageBox.Show("Selecione Vendedor e  Cliente!");
            }
            else
            {
                if (dgvVenda.Rows.Count < 1)
                {
                    MessageBox.Show("Minimo de um produto para realizar venda!");
                }
                else
                {
                    for (int i = 0; i <= dgvVenda.Rows.Count - 1; i++)
                    {
                        int id_funcionario = Convert.ToInt32(txtid_Funcionario.Text);
                        int id_cliente = Convert.ToInt32(txtIdCli.Text);
                        DateTime data = DateTime.Parse(dtpData_venda.Text);
                        int col0 = Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value.ToString());
                        int col1 = Convert.ToInt32(dgvVenda.Rows[i].Cells[5].Value.ToString());
                        int col2 = Convert.ToInt32(dgvVenda.Rows[i].Cells[6].Value.ToString());
                        int col3 = Convert.ToInt32(dgvVenda.Rows[i].Cells[7].Value.ToString());

                        VendaDAO vendaBD = new VendaDAO();
                        MODEL.Venda vendaReg = new MODEL.Venda(col0, id_funcionario, id_cliente, data, col1, col2, col3);
                        vendaBD.itemVenda(vendaReg);
                    }
                }

                MessageBox.Show("Venda finalizada");

                this.Close();
                Vendas abre = new Vendas();
                abre.Show();
            }
        }
    }
}
    

