using System;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaLogin_FormClosing);// USADO PARA FECHAR APLICAÇÃO
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  ABRIR TELA DE CADASTRO E ESCONDER TELA DE LOGIN
            TelaCadastro cadastro = new TelaCadastro();           
            cadastro.Show();         
            this.Hide();         
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            DadosUsuario dadosUsuario = new DadosUsuario();
            string usuario = campoUsuario.Text;
            string senha = campoSenha.Text;

            
            
        }
    }
}
