﻿using System;
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

        private void btnCadasClien_Click(object sender, EventArgs e)
        {
            CadastrarClientes abre = new CadastrarClientes();
            abre.Show();
        }

        private void btnCadasFunc_Click(object sender, EventArgs e)
        {
            CadastrarFuncionarios abre = new CadastrarFuncionarios();
            abre.Show();
        }
    }
}
