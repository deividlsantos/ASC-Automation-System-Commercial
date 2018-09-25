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

namespace ASC_Automation_System_Commercial.Views
{
    public partial class Cadastro_Produto : Form
    {
        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDAO produtoBD = new ProdutoDAO();
                Produto produtoReg = new Produto(txtTipo.Text, int.Parse(txtFornecedor.Text), txtFabricante.Text, txtModelo.Text, txtCor.Text, Double.Parse(txtPreco.Text), int.Parse(txtQuantidade.Text));

                produtoBD.produto(produtoReg);
                MessageBox.Show("Produto Cadastrado");
                

            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
