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

        // Formularios de Consulta
        Consulta.FmrConsultaCD FmrConsultaCD = new Consulta.FmrConsultaCD();
        Consulta.FmrConsultaColecao FmrConsultaColecao = new Consulta.FmrConsultaColecao();
        Consulta.FmrConsultaDVD FmrConsultaDVD = new Consulta.FmrConsultaDVD();
        Consulta.FmrConsultaFantoches FmrConsultaFantoches = new Consulta.FmrConsultaFantoches();
        Consulta.FmrConsultaLivros FmrConsultaLivros = new Consulta.FmrConsultaLivros();
        Consulta.FmrConsultaLivrosPU FmrConsultaLivrosPU = new Consulta.FmrConsultaLivrosPU();
        Consulta.FmrConsulta_Usuarios FmrConsulta_Usuarios = new Consulta.FmrConsulta_Usuarios();

        public FmrIndex()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Usuario
            Configuracao.FmrConfiguracaoCadastroUsuario FormCadastroUsuario = new Configuracao.FmrConfiguracaoCadastroUsuario();
            FormCadastroUsuario.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Funcionario
            Configuracao.FmrConfiguracaoCadastroFuncionario FormCadastroFuncionario = new Configuracao.FmrConfiguracaoCadastroFuncionario();
            FormCadastroFuncionario.Show();
        }

        private void mídiaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Midia
            Cadastros.FmrCadastroMidia FmrCadastroMidia = new Cadastros.FmrCadastroMidia();
            FmrCadastroMidia.Show();
        }

        private void cadastroDeOrigemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Origem
            Cadastros.FmrCadastroOrigem FmrCadastroOrigem = new Cadastros.FmrCadastroOrigem();
            FmrCadastroOrigem.Show();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Categoria
            Cadastros.FmrCadastroCategoria FmrCadastroCategoria = new Cadastros.FmrCadastroCategoria();
            FmrCadastroCategoria.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Emprestimo
            FmrEmprestimo FmrEmprestimo = new FmrEmprestimo();
            FmrEmprestimo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Devolução
            FmrDevolucao FmrDevolucao = new FmrDevolucao();
            FmrDevolucao.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Relatorios
            FmrRelatorios FmrRelatorios = new FmrRelatorios();
            FmrRelatorios.Show();
        }



    }
}
