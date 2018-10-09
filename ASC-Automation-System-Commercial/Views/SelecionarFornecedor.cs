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
    public partial class SelecionarFornecedor : Form
    {
        public SelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dgvFornecedor.CurrentRow;

            Produto abre = new Produto();
            abre.txtFornecedor.Text = LinhaSelecionada.Cells[0].Value.ToString();
            abre.habilitarcampos();
            abre.btnQuantidade.Enabled = true;
            abre.btnCadastrar.Enabled = true;
            abre.Show();
            this.Close();
        }
    }
}
