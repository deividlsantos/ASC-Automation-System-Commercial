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
    public partial class CadastrarFuncionarios : Form
    {
        public CadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        public void limpar()
        {
            btnSalvar.Text = "";
            btnLimpar.Text = "";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbEstado.Text = "";
            txtPais.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtDataNasc.Text = "";
            cmbSexo.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            btnVerificar.Text = "";
        }
        public void desabilitar()
        {
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            txtCep.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtPais.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtDataNasc.Enabled = false;
            cmbSexo.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            btnVerificar.Enabled = false;
        }

        public void habilitar()
        {
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            txtCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstado.Enabled = true;
            txtPais.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtDataNasc.Enabled = true;
            cmbSexo.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            btnVerificar.Enabled = true;
        }
    }
}
