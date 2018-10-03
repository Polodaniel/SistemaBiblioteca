using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTeca.Cadastros
{
    public partial class FmrCadastroMidiaSubTitulo : Form
    {

        private const int TextBoxX = 5;                //Posição vertical do textbox no painel
        private const int TextBoxWidth = 100;          //Largura do textbox
        private const int TextBoxX2 = TextBoxWidth + 10; //Posição vertical do button no painel
        private int _controlY = 5;                     //Posição horizontal dos controles
        private int Limite = 1;
        private string ID = "1";

        public FmrCadastroMidiaSubTitulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Limite <= 21)
            {
                panel1.Controls.AddRange(new Control[]{

                    new TextBox
                    {
                        Location = new Point(TextBoxX, _controlY),
                        Size = new Size(100, 20),
                        Text = ID
                    },

                    new TextBox{
                        Location = new Point(TextBoxX2, _controlY),
                        Size = new Size(300, 20),
                        Text = "Nome"
                    }
                });
                ID = (Convert.ToInt32(ID) + 1).ToString();
            }
            else
                MessageBox.Show("Não é possivel mais adicionar Sub-Titulos ! " , "Erro", MessageBoxButtons.OK ,MessageBoxIcon.Error);

            Limite++;
            _controlY += 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
