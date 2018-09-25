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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Digite um usuario e uma senha");
            }
            else
            {
                try
                {
                    LoginDAO loginBD = new LoginDAO();
                    if(loginBD.logar(login:txtLogin.Text, senha: txtSenha.Text))
                    {
                        this.Close();
                        TelaPrincipal abre = new TelaPrincipal();
                        abre.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos");
                        Close();
                    }
                }
                catch(Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
