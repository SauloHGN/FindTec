﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {
        //MOVIMENTAR JANELA E SOMBREADO----------------------------------------------------------------------------------------------
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        //FIM DO MOVIMENTAR A JANELA E SOMBREADO ---------------------------------------------------------------------------------------------------

        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public TelaCadastro()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaCadastro_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            botaoCriarconta.Select();// INICIA COM O BOTAO CRIE SUA CONTA ATIVO

        }      

        public static bool DadosDisponiveis(string email, string telefone)
        {
            foreach (var alunos in DadosUsuario.listaAlunos)
            {
                if (alunos.Item3 == email || alunos.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var empresas in DadosUsuario.listaEmpresas)
            {
                if (empresas.Item3 == email || empresas.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if (coordenador.Item3 == email || coordenador.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var admin in DadosUsuario.listaAdmin)
            {
                if (admin.Item3 == email)
                {
                    return false;
                }
            }

            return true;
        }

        public void AcessarAdmin()
        {
            //Admin();// ACESSAR O METODO PRIVADO
            Admin();
        }      
        private void Admin()
        {
            // ADICIONAR CADASTRO DO COORDENADOR(A)
            DadosUsuario.listaAdmin.Add((0, "admin", "admin"));
        }    

        //PAINEL DA EMPRESA
        private void textNomeE_Enter(object sender, EventArgs e)
        {
            if (textNomeE.Text == "NOME COMPLETO")
            {
                textNomeE.Text = "";
            }

            txtIndisponivel.Visible = false;
        }

        private void textNomeE_Leave(object sender, EventArgs e)
        {
            if (textNomeE.Text == "")
            {
                textNomeE.Text = "NOME COMPLETO";
            }

            txtIndisponivel.Visible = false;
        }

        private void textEmailE_Enter(object sender, EventArgs e)
        {
            if (textEmailE.Text == "E-MAIL")
            {
                textEmailE.Text = "";
            }

            txtIndisponivel.Visible = false;
        }

        private void textEmailE_Leave(object sender, EventArgs e)
        {
            if (textEmailE.Text == "")
            {
                textEmailE.Text = "E-MAIL";
            }

            txtIndisponivel.Visible = false;
        }

        private void textTelE_Enter(object sender, EventArgs e)
        {
            if (textTelE.Text == "TELEFONE")
            {
                textTelE.Text = "";
            }

            txtIndisponivel.Visible = false;
        }

        private void textTelE_Leave(object sender, EventArgs e)
        {
            if (textTelE.Text == "")
            {
                textTelE.Text = "TELEFONE";
            }

            txtIndisponivel.Visible = false;
        }

        private void textSenhaE_Enter(object sender, EventArgs e)
        {
            if (textSenhaE.Text == "SENHA")
            {
                textSenhaE.Text = "";
            }

            textSenhaE.PasswordChar = '•';
        }

        private void textSenhaE_Leave(object sender, EventArgs e)
        {
            if (textSenhaE.Text == "")
            {
                textSenhaE.PasswordChar = '\0';
                textSenhaE.Text = "SENHA";
            }
        }

        private void botaoCriarconta_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta2" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta2;

            // Define a nova imagem como o background do botão
            botaoCriarconta.BackgroundImage = novaImagem;
        }

        private void botaoCriarconta_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta1" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta1;

            // Define a nova imagem como o background do botão
            botaoCriarconta.BackgroundImage = novaImagem;
        }

        private void botaoCriarconta_Click(object sender, EventArgs e)
        {
            txtIndisponivel.Visible = false;
            if (DadosDisponiveis(textEmailE.Text, textTelE.Text))
            {
                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // LISTA EMPRESA: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaEmpresas.Add((Program.id++, textNomeE.Text, textEmailE.Text, textTelE.Text, textSenhaE.Text, true, null, false));
                foreach (var empresa in DadosUsuario.listaEmpresas)
                {
                    Console.WriteLine("ID: " + empresa.Item1);
                    Console.WriteLine("Nome: " + empresa.Item2);
                    Console.WriteLine("Email: " + empresa.Item3);
                    Console.WriteLine("Telefone: " + empresa.Item4);
                    Console.WriteLine("Senha: " + empresa.Item5);
                    Console.WriteLine("Status: " + empresa.Item6);
                    Console.WriteLine("Codigo: " + empresa.Item7);
                    Console.WriteLine("Aprovação: " + empresa.Item8);
                }
                //LIMPAR TEXTO DOS CAMPOS
                textNomeE.Clear();
                textEmailE.Clear();
                textTelE.Clear();
                textSenhaE.Clear();
            }
            else
            {
                txtIndisponivel.Visible = true;
            }
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaEscolha escolha = new TelaEscolha();
            escolha.Show();
            this.Hide();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        // FIM DO PAINEL DA EMPRESA

        //PAINEL DO ALUNO
        private void textNome_Enter(object sender, EventArgs e)
        {
            if (textNome.Text == "NOME COMPLETO")
            {
                textNome.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                textNome.Text = "NOME COMPLETO";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "E-MAIL")
            {
                textEmail.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "E-MAIL";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textTelefone_Enter(object sender, EventArgs e)
        {
            if (textTelefone.Text == "TELEFONE")
            {
                textTelefone.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textTelefone_Leave(object sender, EventArgs e)
        {
            if (textTelefone.Text == "")
            {
                textTelefone.Text = "TELEFONE";
            }

            txtIndisponivelA.Visible = false;
        }

        private void opCurso_Enter(object sender, EventArgs e)
        {

        }

        private void opCurso_Leave(object sender, EventArgs e)
        {

        }

        private void textSenha_Enter(object sender, EventArgs e)
        {
            if (textSenha.Text == "SENHA")
            {
                textSenha.Text = "";
            }

            textSenha.PasswordChar = '•';
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == "")
            {
                textSenha.PasswordChar = '\0';
                textSenha.Text = "SENHA";
            }
        }                

        private void botaoCriarcontaA_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta2" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta2;

            // Define a nova imagem como o background do botão
            botaoCriarcontaa.BackgroundImage = novaImagem;
        }

        private void botaoCriarcontaA_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta1" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta1;

            // Define a nova imagem como o background do botão
            botaoCriarcontaa.BackgroundImage = novaImagem;
        }

        

        private void botaoFecharA_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        private void botaoVoltarA_Click(object sender, EventArgs e)
        {
            TelaEscolha escolha = new TelaEscolha();
            escolha.Show();
            this.Hide();
        }

        private void botaoCriarcontaa_Click(object sender, EventArgs e)
        {
            txtIndisponivelA.Visible = false;
            if (DadosDisponiveis(textEmail.Text, textTelefone.Text))
            {


                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaAlunos.Add((Program.id++, textNome.Text, textEmail.Text, textTelefone.Text, opCurso.Text, textSenha.Text, true, null, false));
                foreach (var aluno in DadosUsuario.listaAlunos)
                {
                    Console.WriteLine("ID: " + aluno.Item1);
                    Console.WriteLine("Nome: " + aluno.Item2);
                    Console.WriteLine("Email: " + aluno.Item3);
                    Console.WriteLine("Telefone: " + aluno.Item4);
                    Console.WriteLine("Curso: " + aluno.Item5);
                    Console.WriteLine("Senha: " + aluno.Item6);
                    Console.WriteLine("Status: " + aluno.Item7);
                    Console.WriteLine("Codigo: " + aluno.Item8);
                    Console.WriteLine("Aprovado: " + aluno.Item9);

                }
                // limpar os campos
                textNome.Clear();
                textEmail.Clear();
                textTelefone.Clear();
                opCurso.SelectedIndex = -1;
                textSenha.Clear();
            }
            else
            {
                txtIndisponivelA.Visible = true;
            }
        }

        // FIM DO PAINEL DO ALUNO
    }
}
