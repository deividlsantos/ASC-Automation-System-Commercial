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
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }
        ClienteDAO id_end = new ClienteDAO();
        ProcurarEndereco endereco = new ProcurarEndereco();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = openFileDialog1.FileName;
                ptbImg.ImageLocation = openFileDialog1.FileName;           }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteBD = new ClienteDAO();
                string sexo = null;
                if (rdbMasc.Checked)
                {
                    sexo = rdbMasc.Text;
                }
                if (rdbFem.Checked)
                {
                    sexo = rdbFem.Text;
                }

                Cliente clienteReg = new Cliente
                {
                    Id_endereco_fk = Convert.ToInt32(txtIdEndereco.Text),
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtNascimento.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = sexo,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Foto = txtImg.Text,
                    Numero_casa = Convert.ToInt32(txtNumCasa.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.CadastrarCliente(clienteReg);                
                MessageBox.Show("Cliente cadastrado com sucesso");
                this.Close();
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoDAO enderecoBD = new EnderecoDAO();
                
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteBD = new ClienteDAO();
                string sexo = null;
                if (rdbMasc.Checked)
                {
                    sexo = rdbMasc.Text;
                }
                if (rdbFem.Checked)
                {
                    sexo = rdbFem.Text;
                }

                Cliente clienteReg = new Cliente
                {
                    Id_cliente = Convert.ToInt32(txtIdCliente.Text),
                    Id_endereco_fk = Convert.ToInt32(txtIdEndereco.Text),
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtNascimento.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = sexo,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Foto = txtImg.Text,
                    Numero_casa = Convert.ToInt32(txtNumCasa.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.Alterar(clienteReg);
                MessageBox.Show("Cliente Alterado com sucesso");
                this.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteBD = new ClienteDAO();
                string sexo = null;
                if (rdbMasc.Checked)
                {
                    sexo = rdbMasc.Text;
                }
                if (rdbFem.Checked)
                {
                    sexo = rdbFem.Text;
                }

                Cliente clienteReg = new Cliente
                {
                    Id_cliente = Convert.ToInt32(txtIdCliente.Text),
                    Id_endereco_fk = Convert.ToInt32(txtIdEndereco.Text),
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Data_nascimento = txtNascimento.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = sexo,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Foto = txtImg.Text,
                    Numero_casa = Convert.ToInt32(txtNumCasa.Text),
                    Pais = txtPais.Text,
                };
                clienteBD.Excluir(clienteReg);
                MessageBox.Show("Cliente Alterado com sucesso");
                this.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
