﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaLogin : Form
    {
        //MOVIMENTAR JANELA E SOMBREADO----------------------------------------------------------------------------------------------
        //private bool Drag;
        //private int MouseX;
        //private int MouseY;

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
                    cp.ClassStyle |= CS_DROPSHADOW;
                cp.ExStyle |= 0x02000000;
                return cp;
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

        public string tipoUser;

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            //BOTÃO ENTRAR COM ENTER
            if (e.KeyCode == Keys.Enter)
            {
                botaoEntrar.PerformClick();
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this == ActiveForm) // Verifica se o formulário atual é o TelaLogin
            {
                Environment.Exit(0);
            }
        }


        public TelaLogin()
        {                    
            InitializeComponent(); 
            botaoFechar.Select();// O PROGRAMA SE INICIA COM O BOTAO FECHAR SELECIONADO
            this.FormClosing += new FormClosingEventHandler(TelaLogin_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            KeyPreview = true;// BOTÃO ENTRAR COM ENTER
            this.KeyDown += new KeyEventHandler(Enter_KeyDown);// BOTÃO ENTRAR COM ENTER
        }

           

        private void campoEmail_Enter(object sender, EventArgs e)
        {
            if (campoEmail.Text == "E-MAIL")
            {
                campoEmail.Text = "";
            }

            avisoErrologin.Visible = false;
        }

        private void campoEmail_Leave(object sender, EventArgs e)
        {
            if (campoEmail.Text == "")
            {
                campoEmail.Text = "E-MAIL";
            }

            avisoErrologin.Visible = false;
        }     

        private void campoSenha_Enter(object sender, EventArgs e)
        {
            if (campoSenha.Text == "SENHA")
            {
                campoSenha.Text = "";
            }

            campoSenha.PasswordChar = '•';
        }

        private void campoSenha_Leave(object sender, EventArgs e)
        {
            if (campoSenha.Text == "")
            {
                campoSenha.PasswordChar = '\0';
                campoSenha.Text = "SENHA";
            }
        }        

        private void botaoEntrar_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoEntrar" do resources.resx
            Image novaImagem = Properties.Resources.botaoEntrar1;

            // Define a nova imagem como o background do botão
            botaoEntrar.BackgroundImage = novaImagem;
        }

        private void botaoEntrar_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoEntrar2" do resources.resx
            Image novaImagem = Properties.Resources.botaoEntrar2;

            // Define a nova imagem como o background do botão
            botaoEntrar.BackgroundImage = novaImagem;
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            DadosUsuario dadosUsuario = new DadosUsuario();
            string email = campoEmail.Text;
            string senha = campoSenha.Text;
            avisoErrologin.Visible = false;
            if (VerificarLogin(email, senha, this))
            {
                if (tipoUser == "aluno")
                {
                    var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
                    user.Item7 = true;
                    TelaAluno telaAluno = new TelaAluno();
                    telaAluno.Show();
                    this.Hide();
                }
                if (tipoUser == "empresa")
                {
                    var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
                    user.Item7 = true;
                    Form2 telaEmpresa = new Form2();
                    telaEmpresa.Show();
                    this.Hide();
                }
                if (tipoUser == "coordenador")
                {
                    TelaCoordenador telaCoordenador = new TelaCoordenador();
                    telaCoordenador.Show();
                    this.Hide();
                }
                if (tipoUser == "Admin")
                {
                    Form4 telaAdmin = new Form4();
                    telaAdmin.Show();
                    this.Hide();
                }


            }
            else
            {
                avisoErrologin.Visible = true;
            }
        }



        public static bool VerificarLogin(string email, string senha, TelaLogin telaLogin)
        {          
            // VERIFICAR USUARIO E SENHA PARA FAZER LOGIN
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item3 == email && aluno.Item6 == senha)
                {
                    if(aluno.Item9 == true)
                    {
                        if(aluno.Item7 == false)
                        {
                            MessageBox.Show("Bem-vindo de volta. Sua conta foi reativada");
                        }
                        telaLogin.tipoUser = "aluno";
                        Program.userAtual = aluno.Item1;// armazena o id para recuperar os dados do usuario                    
                        return true;
                    }
                    else
                    {
                        //
                        MessageBox.Show("Aguardando aprovação. Tente novamente mais tarde");
                    }

                }
            }

            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item3 == email && empresa.Item5 == senha)
                {
                    if(empresa.Item8 == true)
                    {
                        if(empresa.Item6 == false)
                        {
                            MessageBox.Show("Bem-vindo de volta. Sua conta foi reativada");
                        }
                        telaLogin.tipoUser = "empresa";
                        Program.userAtual = empresa.Item1;// armazena o id para recuperar os dados do usuario
                        return true;
                    }
                    else
                    {
                        //
                        MessageBox.Show("Aguardando aprovação. Tente novamente mais tarde");
                    }

                }
            }

            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if (coordenador.Item3 == email && coordenador.Item5 == senha)
                {
                    telaLogin.tipoUser = "coordenador";
                    Program.userAtual = coordenador.Item1;// armazena o id para recuperar os dados do usuario
                    return true;

                }
            }

            foreach (var admin in DadosUsuario.listaAdmin)
            {
                if (admin.Item2 == email && admin.Item3 == senha)
                {
                    telaLogin.tipoUser = "Admin";                  
                    return true;
                }
            }

            return false;
        }

        private void botaoCriesuaconta_Click(object sender, EventArgs e)
        {
            TelaEscolha cadastro = new TelaEscolha();
            cadastro.Show();
            this.Hide();
        }

        private void botaoCriesuaconta_MouseEnter(object sender, EventArgs e)
        {
            botaoCriesuaconta.BackgroundImage = Properties.Resources.botaoCriesuaconta1;
        }


        private void botaoCriesuaconta_MouseLeave(object sender, EventArgs e)
        {
            botaoCriesuaconta.BackgroundImage = Properties.Resources.botaoCriesuaconta2;
        }

        private void botaoEsquecisenha_Click(object sender, EventArgs e)
        {
            RecuperarSenha recuperar = new RecuperarSenha();
            recuperar.Show();
            this.Hide();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
