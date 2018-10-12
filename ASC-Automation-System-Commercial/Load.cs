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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timerLoader_Tick(object sender, EventArgs e)
        {
            if(loadBar.Value < 100)
            {
                loadBar.Value = loadBar.Value + 5;
            }
            else
            {
                timerLoader.Enabled = false;
                this.Hide();

                TelaPrincipal abre = new TelaPrincipal();
                abre.Show();
            }

        }
    }
}
