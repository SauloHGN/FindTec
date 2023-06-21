using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaEscolha : Form
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
            // Instanciando a segunda tela
            TelaCadastro cadastro = new TelaCadastro();

            // Configurando o painel "cadastroAluno" como visível e o "cadastroEmpresa" como oculto
            cadastro.cadastroAluno.Visible = true;
            cadastro.cadastroEmpresa.Visible = false;
            cadastro.cadastroAluno.BringToFront();


            // Exibindo a segunda tela
            cadastro.Show();
            this.Hide();
        }

        private void botaoEmpresa_Click(object sender, EventArgs e)
        {
            // Instanciando a segunda tela
            TelaCadastro cadastro = new TelaCadastro();

            // Configurando o painel "cadastroEmpresa como visível e o "CadastroAluno" como oculto
            cadastro.cadastroEmpresa.Visible = true;
            cadastro.cadastroAluno.Visible = false;

            // Exibindo a segunda tela
            cadastro.Show();
            this.Hide();
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
