using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaEscolha : Form
    {
        public TelaEscolha()
        {
            InitializeComponent();
        }

        private void botaoAluno_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoAluno2" do resources.resx
            Image novaImagem = Properties.Resources.botaoAluno2;

            // Define a nova imagem como o background do botão
            botaoAluno.BackgroundImage = novaImagem;
        }

        private void botaoAluno_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoAluno" do resources.resx
            Image novaImagem = Properties.Resources.botaoAluno1;

            // Define a nova imagem como o background do botão
            botaoAluno.BackgroundImage = novaImagem;
        }

        private void botaoEmpresa_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoAluno2" do resources.resx
            Image novaImagem = Properties.Resources.botaoEmpresa2;

            // Define a nova imagem como o background do botão
            botaoEmpresa.BackgroundImage = novaImagem;
        }

        private void botaoEmpresa_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoAluno1" do resources.resx
            Image novaImagem = Properties.Resources.botaoEmpresa1;

            // Define a nova imagem como o background do botão
            botaoEmpresa.BackgroundImage = novaImagem;
        }

        private void botaoAluno_Click(object sender, EventArgs e)
        {

        }

        private void botaoEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Close();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin login = new TelaLogin();
            login.Show();
        }
    }
}
