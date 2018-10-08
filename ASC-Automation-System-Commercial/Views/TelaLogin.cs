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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void listaCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginDAO pegar = new LoginDAO();

            listaCargo.DisplayMember = "descricao";
            listaCargo.ValueMember = "id_cargo";
            listaCargo.DataSource = pegar.RetornaLocal();
            //cbLocal.DisplayMember = "loc_descricao";
            //cbLocal.ValueMember = "loc_cod";
            //cbLocal.DataSource = localNegocios.RetornaLocal();
            
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Digite um usuario e uma senha");
            }
            else
            {
                try
                {
                    LoginDAO loginBD = new LoginDAO();
                    if (loginBD.logar(login: txtLogin.Text, senha: txtSenha.Text))
                    {
                        this.Close();
                        TelaPrincipal abre = new TelaPrincipal();
                        abre.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos");
                    }
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
