using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaAluno : Form
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

        private Image imagemSelecionada;
        public TelaAluno()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
            Load_gridViewOportunidades(); // CARREGA O GRID 
            LoadVagasCadastrado();
            Load += Form1_Load;
            this.KeyDown += new KeyEventHandler(EnviarMensagem_Enter);// Enviar mensagem com Enter         
        }

        private void EnviarMensagem_Enter(object sender, KeyEventArgs e)
        {
            //BOTÃO ENTRAR COM ENTER
            if (e.KeyCode == Keys.Enter && panelMensagensAluno.Visible == true)
            {
                btnEnviar.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = textNome.Text; //Inicia o nome do aluno grande a paritr da caixa de texto com o nome do aluno
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
            textNome.Text = user.Item2;
            textEmail.Text = user.Item3;
            textTelefone.Text = user.Item4;
            textCurso.Text = user.Item5;
            panelPerfilAluno.Visible = true;

            if (user.Item10 != null && user.Item10.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item10))
                {
                    picAvatarAluno1.Image = Image.FromStream(ms);
                    picAvatarAluno2.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picAvatarAluno1.Image = null;
                picAvatarAluno2.Image = null;
            }
        }
        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            panelMeusCadastrosAluno.Visible = false;
            panelPerfilAluno.Visible = true;
            panelOportunidadesAluno.Visible = false;
            panelConversasAluno.Visible = false;
        }

        private void botaoOportunidades_Click(object sender, EventArgs e)
        {
            panelMeusCadastrosAluno.Visible = false;
            panelPerfilAluno.Visible = false;
            panelOportunidadesAluno.Visible = true;
            panelConversasAluno.Visible = false;
            panelOportunidadesAluno.BringToFront();
        }

        private void botaoMensagens_Click(object sender, EventArgs e)
        {           
            panelPerfilAluno.Visible = false;
            panelMeusCadastrosAluno.Visible = false;
            panelOportunidadesAluno.Visible = false;
            panelConversasAluno.Visible = true;
            panelConversasAluno.BringToFront();
            LoadConversas();
        }

        private void botaoMeusCadastros_Click(object sender, EventArgs e)
        {
            LoadVagasCadastrado();
            panelMeusCadastrosAluno.Visible = true;
            panelPerfilAluno.Visible = false;
            panelOportunidadesAluno.Visible = false;
            panelConversasAluno.Visible = false;
            panelMeusCadastrosAluno.BringToFront();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }        

        private void botaoAlterarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = openFileDialog.FileName;

                if (File.Exists(nomeArquivo))
                {
                    using (FileStream stream = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read))
                    {
                        byte[] dadosImagem = new byte[stream.Length];
                        stream.Read(dadosImagem, 0, (int)stream.Length);

                        MemoryStream ms = new MemoryStream(dadosImagem);
                        imagemSelecionada = Image.FromStream(ms);

                        picAvatarAluno1.Image = imagemSelecionada;
                        picAvatarAluno2.Image = imagemSelecionada;


                        var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

                        user.Item10 = dadosImagem;

                        var index = DadosUsuario.listaAlunos.FindIndex(u => u.Item1 == Program.userAtual);// descobro o indece do usuario
                        if (index != -1)
                        {
                            DadosUsuario.listaAlunos[index] = user;
                        }

                        Console.WriteLine("" + user);

                    }
                }
            }
        }

        private void botaoEditarDados_Click(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            // Cria um label com a mensagem para o usuário
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Digite sua senha:" };
            prompt.Controls.Add(textLabel);

            // Cria um textBox para o usuário inserir o valor
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            textBox.UseSystemPasswordChar = true;
            textBox.PasswordChar = '•';
            prompt.Controls.Add(textBox);

            // Cria o botão "OK" para confirmar a entrada de dados
            Button confirmation = new Button() { Text = "OK", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Cancelar", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);

            // Mostra o formulário para o usuário e aguarda a entrada de dados
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            DialogResult result = prompt.ShowDialog();

            if(result == DialogResult.Cancel)
            {
                Form1_Load_1(this, e);
            }

            // Se o usuário confirmou a entrada de dados, exibe o valor inserido
            if (result == DialogResult.OK)
            {               
                var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

                if (user.Item6 == textBox.Text)
                {
                    user.Item2 = textNome.Text;
                    user.Item3 = textEmail.Text;
                    user.Item4 = textTelefone.Text;

                    var index = DadosUsuario.listaAlunos.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(textEmail.Text, textTelefone.Text, index))
                    {
                        DadosUsuario.listaAlunos[index] = user;
                        MessageBox.Show("Dados alterados com sucesso");
                        
                        this.Close();
                    }
                    else
                    {
                        Form1_Load_1(this, e);
                        MessageBox.Show("Os dados já estão em uso");
                    }
                }
                else
                {
                    Form1_Load_1(this, e);
                    MessageBox.Show("Senha incorreta...");
                }
            }
        }


        public bool VerificaEmailETelefone(string email, string telefone, int indiceAtual)
        {
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if ((aluno.Item3 == email || aluno.Item4 == telefone) && DadosUsuario.listaAlunos.IndexOf(aluno) != indiceAtual)
                {
                    return false;
                }
            }
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item3 == email || empresa.Item4 == telefone)
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
            return true;
        }

        private void botaoDesativarConta_Click(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Você tem certeza que deseja desativar sua conta?" };
            prompt.Controls.Add(textLabel);

            Button confirmation = new Button() { Text = "Sim", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Não", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);
            DialogResult result = prompt.ShowDialog();

            if(result == DialogResult.OK)
            {             
                if(confirmarSenha())
                {
                    var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
                    user.Item7 = false;
                    var index = DadosUsuario.listaAlunos.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1)
                    {
                        DadosUsuario.listaAlunos[index] = user;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
            else
            {

            }           
        }

        public bool confirmarSenha()
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            // Cria um label com a mensagem para o usuário
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Digite sua senha:" };
            prompt.Controls.Add(textLabel);

            // Cria um textBox para o usuário inserir o valor
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            textBox.UseSystemPasswordChar = true;
            textBox.PasswordChar = '•';
            prompt.Controls.Add(textBox);

            // Cria o botão "OK" para confirmar a entrada de dados
            Button confirmation = new Button() { Text = "OK", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Cancelar", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);

            // Mostra o formulário para o usuário e aguarda a entrada de dados
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            DialogResult result = prompt.ShowDialog();

            if(result == DialogResult.OK)
            {
                var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
                if (user.Item6 == textBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        // INICIO TABELA OPORTUNIDADES
        private void Load_gridViewOportunidades()
        {
            gridViewOportunidades.AllowUserToAddRows = false;
            gridViewOportunidades.AllowUserToAddRows = false;
            gridViewOportunidades.Rows.Clear();

            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

            foreach (var vagas in Vaga.vagas)
            {
                // RECUPERAR IMAGEM
                if (user.Item5 == vagas.Curso && !vagas.Candidatos.Contains(user.Item1.ToString()))
                {
                    byte [] imageBytes = vagas.getFoto(vagas.NomeEmpresa); // bytes contendo a imagem
                    Image imagem = null;

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            imagem = Image.FromStream(ms);
                        }
                    }
                    DataGridViewButtonCell button1 = new DataGridViewButtonCell();
                    button1.Value = "Detalhes";
                    gridViewOportunidades.Rows.Add(imagem, vagas.NomeEmpresa, vagas.NomeVaga, vagas.Cargo, vagas.cargaHoraria, vagas.remuneracao, "Detalhes");                   
                }
            }
            gridViewOportunidades.ClearSelection();
        }

        private void gridViewOportunidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridViewOportunidades.Columns["colCandidatar"].Index && e.RowIndex >= 0)
            {
                string nomeVaga = gridViewOportunidades.Rows[e.RowIndex].Cells["NomeVagaGrid"].Value.ToString();
                Vaga vaga = Vaga.vagas.Find(v => v.NomeVaga == nomeVaga);

                
                txtTituloVaga.Text = vaga.NomeVaga;
                txtEmpresaContratante.Text = vaga.NomeEmpresa;
                txtCargo.Text = vaga.Cargo;
                txtRemuneracao.Text = vaga.remuneracao.ToString();
                txtCargaHoraria.Text = vaga.cargaHoraria.ToString();
                txtDescricao.Text = vaga.Descricao;

                panelVagaInfoAluno.Visible = true;
                panelVagaInfoAluno.BringToFront();
            }
        }
        //FIM TABELA OPORTUNIDADES

        private void botaoCandidatar_Click(object sender, EventArgs e)
        {
            Vaga vaga = Vaga.vagas.Find(v => v.NomeVaga == txtTituloVaga.Text);
            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
            vaga.Candidatos.Add(user.Item1.ToString());// Passa o ID PARA A LISTA DE CADASTRADOS
            vaga.alteracao = true;
            MessageBox.Show("Cadastrado com sucesso!!!\n aguarde o contado da empresa contratante.");
            gridViewOportunidades.Rows.RemoveAt(gridViewOportunidades.CurrentRow.Index);
            panelVagaInfoAluno.Visible = false;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            panelVagaInfoAluno.Visible = false;
        }

        ////// INICIO MENSAGENS
        
       public void LoadConversas()
        {
            Chat.LoadGridConversas(FlowPanelConversas, FlowPanelConversas_Click);
        }

        private void listViewConversas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConversas.SelectedItems.Count > 0)
            {
                // Obtém o nome do usuário selecionado
                string nomeSelecionado = listViewConversas.SelectedItems[0].Text;
                int idDestinatario = Chat.ObterIdUsuarioPeloNome(nomeSelecionado);
                Chat.getIdDestinatario = idDestinatario;

                var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));

                Chat.LoadMensagens(panelMensagensAluno, chat);
                // Define a visibilidade do painel de mensagens como true
                panelMensagensAluno.Visible = true;
                panelMensagensAluno.BringToFront();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelMensagensAluno.Visible = false;
            LoadConversas();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int idDestinatario = Chat.getIdDestinatario;
            Chat.EnviarMensagem(Program.userAtual, idDestinatario, txtMensagem.Text);
            txtMensagem.Clear();
            var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));

            Chat.LoadMensagens(panelMensagensAluno, chat);
        }

        /// <summary>
        /// NÃO REMOVA MESMO ESTANDO SEM REFERENCIA
        /// </summary>
        public event EventHandler FlowPanelConversasClick;//
        public void OnFlowPanelConversasClick(object sender, EventArgs e)
        {
            FlowPanelConversasClick?.Invoke(sender, e);
        }

        private void FlowPanelConversas_Click(object sender, EventArgs e)
        {
            ConversaItem selectedItem = null;
            // Verifica se há um item selecionado anteriormente
            if (sender is ConversaItem clickedItem)
            {
                if (selectedItem != null)
                {
                    // Redefine a aparência do item anteriormente selecionado
                    selectedItem.BackColor = Color.Gray;
                }

                // Atualiza o item selecionado e redefine sua aparência
                selectedItem = clickedItem;
                selectedItem.BackColor = Color.White;

                // Obtém os dados do item selecionado
                string nomeSelecionado = clickedItem.NomeItem;
                int idDestinatario = Chat.ObterIdUsuarioPeloNome(nomeSelecionado);
                Chat.getIdDestinatario = idDestinatario;

                var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));

                Chat.LoadMensagens(panelMensagensAluno, chat);
                // Define a visibilidade do painel de mensagens como true
                panelMensagensAluno.Visible = true;
                panelMensagensAluno.BringToFront();
            }
        }

        private void picAvatarAluno1_Paint(object sender, PaintEventArgs e)
        {            
                // Obtém a imagem da PictureBox
                Image image = picAvatarAluno1.Image;

                if (image != null)
                {
                    // Calcula a proporção de redimensionamento
                    float ratio = (float)picAvatarAluno1.Height / image.Height;

                    // Calcula as dimensões da imagem redimensionada
                    int width = (int)(image.Width * ratio);
                    int height = picAvatarAluno1.Height;

                    // Calcula as coordenadas X e Y para centralizar a imagem
                    int x = (picAvatarAluno1.Width - width) / 2;
                    int y = (picAvatarAluno1.Height - height) / 2;

                    // Desenha a imagem redimensionada
                    e.Graphics.DrawImage(image, x, y, width, height);
                }

                // Cria uma região elíptica do mesmo tamanho que a PictureBox
                System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
                roundPath.AddEllipse(0, 0, picAvatarAluno1.Width - 1, picAvatarAluno1.Height - 1);

                // Define a região da PictureBox para a região elíptica
                picAvatarAluno1.Region = new System.Drawing.Region(roundPath);            
        }

        private void picAvatarAluno2_Paint(object sender, PaintEventArgs e)
        {
            // Obtém a imagem da PictureBox
            Image image = picAvatarAluno2.Image;

            if (image != null)
            {
                // Calcula a proporção de redimensionamento
                float ratio = (float)picAvatarAluno2.Height / image.Height;

                // Calcula as dimensões da imagem redimensionada
                int width = (int)(image.Width * ratio);
                int height = picAvatarAluno2.Height;

                // Calcula as coordenadas X e Y para centralizar a imagem
                int x = (picAvatarAluno2.Width - width) / 2;
                int y = (picAvatarAluno2.Height - height) / 2;

                // Desenha a imagem redimensionada
                e.Graphics.DrawImage(image, x, y, width, height);
            }

            // Cria uma região elíptica do mesmo tamanho que a PictureBox
            System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
            roundPath.AddEllipse(0, 0, picAvatarAluno2.Width - 1, picAvatarAluno2.Height - 1);

            // Define a região da PictureBox para a região elíptica
            picAvatarAluno2.Region = new System.Drawing.Region(roundPath);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textNome.Text;
        }      

        

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNome.Text))
            {
                string[] nomes = textNome.Text.Split(' ');
                StringBuilder resultado = new StringBuilder();

                foreach (string nome in nomes)
                {
                    if (resultado.Length > 0)
                        resultado.Append(" ");

                    if (nome.ToLower() == "da" || nome.ToLower() == "do" || nome.ToLower() == "das" ||
                        nome.ToLower() == "dos" || nome.ToLower() == "de" || nome.ToLower() == "e" ||
                        nome.ToLower() == "eles")
                    {
                        resultado.Append(nome.ToLower());
                    }
                    else
                    {
                        if (nome.Length > 0)
                        {
                            string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                            string restante = nome.Substring(1).ToLower();
                            resultado.Append(primeiroCaractere + restante);
                        }
                    }
                }

                textNome.Text = resultado.ToString();
                textNome.SelectionStart = textNome.Text.Length;
            }

        }

        private bool formatandoTelefone = false;
        private void textTelefone_TextChanged(object sender, EventArgs e)
        {
            if (!formatandoTelefone)
            {
                formatandoTelefone = true;

                // Remove todos os caracteres não numéricos do telefone
                string telefone = new string(textTelefone.Text.Where(char.IsDigit).ToArray());

                if (telefone.Length >= 2)
                {
                    // Garante que a string tenha um comprimento mínimo antes de aplicar a formatação
                    if (telefone.Length <= 2)
                    {
                        telefone = string.Format("({0}", telefone);
                    }
                    else if (telefone.Length <= 6)
                    {
                        telefone = string.Format("({0}) {1}", telefone.Substring(0, 2), telefone.Substring(2));
                    }
                    else if (telefone.Length <= 10)
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 4), telefone.Substring(6));
                    }
                    else
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(7));
                    }
                }

                textTelefone.Text = telefone;
                textTelefone.SelectionStart = telefone.Length;

                formatandoTelefone = false;
            }
        }

        private void telefoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textTelefone.TextLength >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        /// FIM MENSAGENS


        public void LoadVagasCadastrado()
        {
            gridViewVagasCadastrado.AllowUserToAddRows = false;
            gridViewVagasCadastrado.AllowUserToAddRows = false;
            gridViewVagasCadastrado.Rows.Clear();

            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

            foreach (var vagas in Vaga.vagas)
            {
                if (vagas.Candidatos.Contains(user.Item1.ToString()))
                {
                    gridViewVagasCadastrado.Rows.Add(vagas.NomeEmpresa, vagas.NomeVaga, vagas.Cargo, vagas.cargaHoraria, vagas.remuneracao, vagas.Curso);
                }
            }
            gridViewVagasCadastrado.ClearSelection();
        }

        private void botaoHome_Click(object sender, EventArgs e)
        {

        } 

        ///////////////////////// EVENTOS DE TROCAR IMAGEM DOS BOTOES //////////////////////////////
        
        private void botaoHome_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoHome_2;
            botaoHome.BackgroundImage = novaImagem;
        }

        private void botaoHome_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoHome_1;
            botaoHome.BackgroundImage = novaImagem;
        }

        private void botaoPerfil_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoPerfil_2;
            botaoPerfil.BackgroundImage = novaImagem;
        }

        private void botaoPerfil_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoPerfil_1;
            botaoPerfil.BackgroundImage = novaImagem;
        }

        private void botaoOportunidades_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoOportunidades_2;
            botaoOportunidades.BackgroundImage = novaImagem;
        }

        private void botaoOportunidades_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoOportunidades_1;
            botaoOportunidades.BackgroundImage = novaImagem;
        }

        private void botaoMensagens_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoMensagens_2;
            botaoMensagens.BackgroundImage = novaImagem;
        }

        private void botaoMensagens_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoMensagens_1;
            botaoMensagens.BackgroundImage = novaImagem;
        }

        private void botaoSair_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoSair_2;
            botaoSair.BackgroundImage = novaImagem;
        }

        private void botaoSair_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoSair_1;
            botaoSair.BackgroundImage = novaImagem;
        }

        private void botaoAlterarFoto_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.BotaoAlterarImagem_2;
            botaoAlterarFoto.BackgroundImage = novaImagem;
        }

        private void botaoAlterarFoto_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.BotaoAlterarImagem_1;
            botaoAlterarFoto.BackgroundImage = novaImagem;
        }

        private void botaoEditarDados_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEditarDados_2;
            botaoEditarDados.BackgroundImage = novaImagem;
        }

        private void botaoEditarDados_MouseLeave(object sender, EventArgs e)
        {
           Image novaImagem = Properties.Resources.botaoEditarDados_1;
            botaoEditarDados.BackgroundImage = novaImagem;
        }

        private void botaoDesativarConta_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoDesativarConta_2;
            botaoDesativarConta.BackgroundImage = novaImagem;
        }

        private void botaoDesativarConta_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoDesativarConta_1;
            botaoDesativarConta.BackgroundImage = novaImagem;
        }

        private void botaoAlterarSenha_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoAlterarSenha_2;
            botaoAlterarSenha.BackgroundImage = novaImagem;
        }

        private void botaoAlterarSenha_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoAlterarSenha_1;
            botaoAlterarSenha.BackgroundImage = novaImagem;
        }

        private void botaoMeusCadastros_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoMeusCadastros2;
            botaoMeusCadastros.BackgroundImage = novaImagem;
        }

        private void botaoMeusCadastros_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoMeusCadastros1;
            botaoMeusCadastros.BackgroundImage = novaImagem;
        }

        private void btnEnviar_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEnviarMensagem2;
            btnEnviar.BackgroundImage = novaImagem;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEnviarMensagem1;
            btnEnviar.BackgroundImage = novaImagem;
        }
    }
}
