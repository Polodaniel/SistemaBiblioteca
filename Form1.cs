using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cria o Link para o Form de Login
            FrmLogin fml = new FrmLogin();

            if (BarraLoad.Value < 100)
            {
                BarraLoad.Value += 2;
            }
            else
            {

                timer1.Enabled = false;

                fml.Show();

                this.Visible = false;
            }

        }
    }
}
