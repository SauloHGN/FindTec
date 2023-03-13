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
            erroLogin.Visible = false;
            if(VerificarLogin(usuario, senha))
            {
                Form1 telaPrincipla = new Form1();
                telaPrincipla.Show();
                this.Hide();
            }
            else
            {
                erroLogin.Visible = true;
            }
        }

        public static bool VerificarLogin(string usuario, string senha)
        {
            // VERIFICAR USUARIO E SENHA PARA FAZER LOGIN
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if(aluno.Item2 == usuario && aluno.Item6 == senha)
                {
                    return true;
                }
            }

            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if(empresa.Item2 == usuario && empresa.Item5 == senha)
                {
                    return true;
                }
            }

            return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
