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
    public partial class FmrCadastroMidia : Form
    {
        public FmrCadastroMidia()
        {
            InitializeComponent();
        }

        private void FmrCadastroMidia_Load(object sender, EventArgs e)
        {

        }

        private void Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( Categoria.Text == "Coleção")
            {
                BotaoSubTitulo.Enabled = true;
            }
            else
            {
                BotaoSubTitulo.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BotaoSubTitulo_Click(object sender, EventArgs e)
        {
            // SubTitulos
            Cadastros.FmrCadastroMidiaSubTitulo FmrSubTitulos = new Cadastros.FmrCadastroMidiaSubTitulo();
            FmrSubTitulos.Show();
        }
    }
}
