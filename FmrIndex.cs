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
    public partial class FmrIndex : Form
    {
        // Fomularios de Cadastro
        Cadastros.FmrCadastroCategoria FormCadastroCategoria = new Cadastros.FmrCadastroCategoria();
        Cadastros.FmrCadastroMidiaDigital FmrCadastroMidiaDigital = new Cadastros.FmrCadastroMidiaDigital();
        Cadastros.FmrCadastroMidiaFisica FmrCadastroMidiaFisica = new Cadastros.FmrCadastroMidiaFisica();
        Cadastros.FmrCadastroOrigem FmrCadastroOrigem = new Cadastros.FmrCadastroOrigem();

        // Formularios de Consulta
        Consulta.FmrConsultaCD FmrConsultaCD = new Consulta.FmrConsultaCD();
        Consulta.FmrConsultaColecao FmrConsultaColecao = new Consulta.FmrConsultaColecao();
        Consulta.FmrConsultaDVD FmrConsultaDVD = new Consulta.FmrConsultaDVD();
        Consulta.FmrConsultaFantoches FmrConsultaFantoches = new Consulta.FmrConsultaFantoches();
        Consulta.FmrConsultaLivros FmrConsultaLivros = new Consulta.FmrConsultaLivros();
        Consulta.FmrConsultaLivrosPU FmrConsultaLivrosPU = new Consulta.FmrConsultaLivrosPU();
        Consulta.FmrConsulta_Usuarios FmrConsulta_Usuarios = new Consulta.FmrConsulta_Usuarios();

        // Formularios do Menu Configuração
        Configuracao.FmrConfiguracaoCadastroUsuario FormCadastroUsuario = new Configuracao.FmrConfiguracaoCadastroUsuario();

        // Formulario de Pesquisa



        public FmrIndex()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario.Show();
        }

        private void FmrIndex_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria.Show();
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void dVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void livroPopUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void fantochesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void cDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaCD.Show();
        }

        private void coleçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsultaColecao.Show();
        }

        private void dVDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaDVD.Show();
        }

        private void fantochesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaFantoches.Show();
        }

        private void midiaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsultaLivros.Show();
        }

        private void mídiaDigitalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaLivrosPU.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsulta_Usuarios.Show();
        }

        private void mídiaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaDigital.Show();
        }

        private void mídiaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroMidiaFisica.Show();
        }

        private void cadastroDeOrigemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCadastroOrigem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
