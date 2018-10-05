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
        string email;
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
                email = txtEmail.Text;
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorEmail.SetError(txtEmail, errorMsg);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorEmail.SetError(txtEmail, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Email invalido ex: someone@example.com ";
            return false;
        }
    }
}
