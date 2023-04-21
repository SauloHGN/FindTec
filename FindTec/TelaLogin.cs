using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaLogin : Form
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
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
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

        public TelaLogin()
        {                    
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaLogin_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            botaoFechar.Select();// O PROGRAMA SE INICIA COM O BOTAO FECHAR SELECIONADO
            KeyPreview = true;// BOTÃO ENTRAR COM ENTER
            this.KeyDown += new KeyEventHandler(Enter_KeyDown);// BOTÃO ENTRAR COM ENTER
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void campoEmail_Enter(object sender, EventArgs e)
        {
            if (campoEmail.Text == "E-MAIL")
            {
                campoEmail.Text = "";
            }
        }

        private void campoEmail_Leave(object sender, EventArgs e)
        {
            if (campoEmail.Text == "")
            {
                campoEmail.Text = "E-MAIL";
            }
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
            Image novaImagem = Properties.Resources.botaoEntrar;

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
                    Form1 telaAluno = new Form1();
                    telaAluno.Show();
                    this.Hide();
                }
                if (tipoUser == "empresa")
                {
                    Form2 telaEmpresa = new Form2();
                    telaEmpresa.Show();
                    this.Hide();
                }
                if (tipoUser == "coordenador")
                {
                    Form3 telaCoordenador = new Form3();
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
            UsuarioLogado user = new UsuarioLogado();
            // VERIFICAR USUARIO E SENHA PARA FAZER LOGIN
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item3 == email && aluno.Item6 == senha)
                {
                    telaLogin.tipoUser = "aluno";
                    return true;

                }
            }

            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item3 == email && empresa.Item5 == senha)
                {
                    telaLogin.tipoUser = "empresa";
                    return true;

                }
            }

            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if (coordenador.Item3 == email && coordenador.Item5 == senha)
                {
                    telaLogin.tipoUser = "coordenador";
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
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void botaoCriesuaconta_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta;

            // Define a nova imagem como o background do botão
            botaoCriesuaconta.BackgroundImage = novaImagem;
        }

        private void botaoCriesuaconta_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta2" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta2;

            // Define a nova imagem como o background do botão
            botaoCriesuaconta.BackgroundImage = novaImagem;
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
