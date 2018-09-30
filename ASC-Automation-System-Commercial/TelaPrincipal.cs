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

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvLista.CurrentRow;
            CadastrarClientes abre = new CadastrarClientes();
            abre.btnSalvar.Visible = true;
            abre.btnExcluir.Visible = true;
            abre.lblIdCliente.Visible = true;
            abre.txtIdCliente.Visible = true;
            abre.txtIdCliente.Text = LinhaSelecionada.Cells[0].Value.ToString();
            abre.txtIdEndereco.Text = LinhaSelecionada.Cells[1].Value.ToString();
            abre.txtNome.Text = LinhaSelecionada.Cells[2].Value.ToString();
            abre.txtRg.Text = LinhaSelecionada.Cells[3].Value.ToString();
            abre.txtCpf.Text = LinhaSelecionada.Cells[4].Value.ToString();
            abre.txtNascimento.Text = LinhaSelecionada.Cells[5].Value.ToString();
            abre.txtEmail.Text = LinhaSelecionada.Cells[6].Value.ToString();
            abre.txtTelefone.Text = LinhaSelecionada.Cells[7].Value.ToString();
            abre.txtCelular.Text = LinhaSelecionada.Cells[8].Value.ToString();
            if(LinhaSelecionada.Cells[9].Value.ToString() == "Feminino")
            {
                abre.rdbFem.Select();
            }
            else
            {
                abre.rdbMasc.Select();
            }
            abre.txtImg.Text = LinhaSelecionada.Cells[10].Value.ToString();
            abre.txtNumCasa.Text = LinhaSelecionada.Cells[12].Value.ToString();
            abre.txtPais.Text = LinhaSelecionada.Cells[16].Value.ToString();
            abre.Show();
            
        }
    }
}
