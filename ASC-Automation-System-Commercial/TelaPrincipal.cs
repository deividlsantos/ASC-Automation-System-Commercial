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

namespace ASC_Automation_System_Commercial
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        string pesquisa;
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcurarEndereco abre = new ProcurarEndereco();
            abre.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCpfCliente.Visible = true;
            txtCpfCliente.Visible = true;
            btnListaClientes.Visible = true;
            
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            pesquisa = "cpf";
            if (txtCpfCliente.Text != "")
            {
                ClienteDAO clienteBD = new ClienteDAO();
                dgvLista.DataSource = clienteBD.getCliente(pesquisa, txtCpfCliente.Text);
            }
            else
            {
                MessageBox.Show("Insira o CPF do Cliente!");
            }
        }
    }
}
