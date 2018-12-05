using ASC_Automation_System_Commercial.DAO;
using MySql.Data.MySqlClient;
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

            cmbCargo.DisplayMember = "descricao";
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.DataSource = pegar.RetornaLocal();
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

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root");
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "SELECT descricao FROM cargo";
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCargo.DisplayMember = "descricao";
            cmbCargo.DataSource = dt;
            cn.Close();
        }
    }
}
