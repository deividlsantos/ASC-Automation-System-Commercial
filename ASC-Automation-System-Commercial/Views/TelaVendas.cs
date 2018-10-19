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
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void btnPesqProd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodProd.Text == "")
                {
                    MessageBox.Show("Informe o Codigo do Produto!");
                }
                else
                {
                    ProdutoDAO produto = new ProdutoDAO();
                    int codigo = Convert.ToInt32(txtCodProd.Text);
                    dgvProduto.DataSource = produto.getProduto(codigo);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
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

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvProduto.CurrentRow;
            txtIdProd.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtNomeProduto.Text = LinhaSelecionada.Cells[3].Value.ToString();
            txtValorProduto.Text = LinhaSelecionada.Cells[6].Value.ToString();

            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            double valorProduto = Convert.ToDouble(txtValorProduto.Text);
            double valorFinal;
            if (quantidade == 0)
            {
                valorFinal = valorProduto;
                txtValorTotal.Text = Convert.ToString(valorFinal);
            }
            else
            {
                valorFinal = valorProduto * quantidade;
                txtValorTotal.Text = Convert.ToString(valorFinal);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvCliente.CurrentRow;
            txtIdCli.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtNomeCliente.Text = LinhaSelecionada.Cells[2].Value.ToString();
        }
        
    }
}
