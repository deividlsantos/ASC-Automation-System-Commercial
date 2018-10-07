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
    public partial class ProcurarEndereco : Form
    {
        public ProcurarEndereco()
        {
            InitializeComponent();
        }
        string pesquisa;
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            EnderecoDAO enderecoBD = new EnderecoDAO();
            pesquisa = "cep";
            dgvEndereco.DataSource = enderecoBD.getEndereco(pesquisa, txtCep.Text);
        }

        private void dgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (btnVerificar.Visible == true) { 
                DataGridViewRow LinhaSelecionada;
                LinhaSelecionada = dgvEndereco.CurrentRow;
                CadastrarClientes abre = new CadastrarClientes();
                abre.txtIdEndereco.Text = LinhaSelecionada.Cells[0].Value.ToString();
                abre.Show();
            }
            else
            {
                if(btnLocalizar.Visible == true)
                {
                    DataGridViewRow LinhaSelecionada;
                    LinhaSelecionada = dgvEndereco.CurrentRow;
                    CadastrarFuncionarios abre = new CadastrarFuncionarios();
                    abre.txtIdEndereco.Text = LinhaSelecionada.Cells[0].Value.ToString();
                    abre.Show();
                }
            }*/
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            EnderecoDAO enderecoBD = new EnderecoDAO();
            pesquisa = "cep";
            dgvEndereco.DataSource = enderecoBD.getEndereco(pesquisa, txtCep.Text);
        }
    }
}
