using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesTrackerUI
{
    public partial class StartupLogo : Form
    {
        public StartupLogo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Main main = new();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
        }
    }
}
