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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FmrIndex fmr = new FmrIndex();

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            fmr.Show();
        }
    }
}
