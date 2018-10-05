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
    public partial class TelaProvisoria : Form
    {
        public TelaProvisoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal abre = new TelaPrincipal();
            abre.Show();
        }
    }
}
