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

        private void dgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvEndereco.CurrentRow;
            CadastrarClientes abre = new CadastrarClientes();
            abre.txtCep.Text = LinhaSelecionada.Cells[0].Value.ToString();
            abre.txtLogradouro.Text = LinhaSelecionada.Cells[1].Value.ToString();
            abre.txtBairro.Text = LinhaSelecionada.Cells[2].Value.ToString();
            abre.txtCidade.Text = LinhaSelecionada.Cells[3].Value.ToString();
            abre.cmbEstado.Text = LinhaSelecionada.Cells[4].Value.ToString();
            abre.txtCep.Enabled = true;
            abre.txtLogradouro.Enabled = true;
            abre.txtNumero.Enabled = true;
            abre.txtBairro.Enabled = true;
            abre.txtCidade.Enabled = true;
            abre.cmbEstado.Enabled = true;
            abre.txtPais.Enabled = true;
            abre.txtNome.Enabled = true;
            abre.txtNome.Enabled = true;
            abre.txtCpf.Enabled = true;
            abre.txtRg.Enabled = true;
            abre.txtDataNasc.Enabled = true;
            abre.cmbSexo.Enabled = true;
            abre.txtTelefone.Enabled = true;
            abre.txtCelular.Enabled = true;
            abre.txtEmail.Enabled = true;
            abre.btnSalvar.Enabled = true;
            abre.btnLimpar.Enabled = true;
            abre.btnNovoCliente.Enabled = false;
            abre.Show();
            this.Close();
        }
    }
}
