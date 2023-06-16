using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form2 : Form
    {
        public static string nomeVaga;
        public Form2()
        {            
            InitializeComponent();
            btnVaga_Click(this, new EventArgs());//INICIAR COM O BOTÃO VAGA SELECIONADO
            button1_Click(this, new EventArgs());// INICIAR COM A "HOMEPAGE" PERFIL
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
            this.KeyDown += new KeyEventHandler(EnviarMensagem_Enter);// Enviar mensagem com Enter
            LoadMinhasVagas();
            LoadConversas();
        }

        private void EnviarMensagem_Enter(object sender, KeyEventArgs e)
        {
            //BOTÃO ENTRAR COM ENTER
            if (e.KeyCode == Keys.Enter && panelMensagens.Visible == true)
            {
                btnEnviar.PerformClick();
                e.Handled = true; // Impede que o evento de tecla "Enter" 
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
            nomeTxt.Text = user.Item2;
            emailTxt.Text = user.Item3;
            telefoneTxt.Text = user.Item4;

            //
            NomeEmpresaTextBox.Text = user.Item2;

            if (user.Item9 != null && user.Item9.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item9))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;
            
            panelAnunciarVaga.Visible = false;
            panelAlunoCadastrado.Visible = false;
            panelMinhasVagas.Visible = false;
            panelConversas.Visible = false;

            panelPerfilE.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;

            panelPerfilE.Visible = false;
            panelAlunoCadastrado.Visible = false;
            panelConversas.Visible = false;

            panelAnunciarVaga.Visible = true;
            panelAnunciarVaga.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;

            panelPerfilE.Visible = false;
            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = false;
            panelAlunoCadastrado.Visible = false;
            panelConversas.Visible = false;

            panelConversas.Visible = true; 
            panelConversas.BringToFront();
            LoadConversas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;

            panelPerfilE.Visible = false;
            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = false;
            panelAlunoCadastrado.Visible = false;
            panelConversas.Visible = false;
        }

        private void panelPerfilE_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void opD1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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
                        Image imagem = Image.FromStream(ms);

                        pictureBox1.Image = imagem;

                        var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);

                        user.Item9 = dadosImagem;

                        var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);// descobro o indece do usuario
                        if (index != -1)
                        {
                            DadosUsuario.listaEmpresas[index] = user;
                        }
                        Console.WriteLine(""+user.Item9);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

            if (result == DialogResult.Cancel)
            {
                Form2_Load(this, e);
            }

            // Se o usuário confirmou a entrada de dados, exibe o valor inserido
            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);

                if (user.Item5 == textBox.Text)
                {
                    user.Item2 = nomeTxt.Text;
                    user.Item3 = emailTxt.Text;
                    user.Item4 = telefoneTxt.Text;

                    var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(emailTxt.Text, telefoneTxt.Text, index))
                    {
                        DadosUsuario.listaEmpresas[index] = user;
                        MessageBox.Show("Dados alterados com sucesso");

                        this.Close();
                    }
                    else
                    {
                        Form2_Load(this, e);
                        MessageBox.Show("Os dados já estão em uso");
                    }
                }
                else
                {
                    Form2_Load(this, e);
                    MessageBox.Show("Senha incorreta...");
                }
            }
        }

        public bool VerificaEmailETelefone(string email, string telefone, int indiceAtual)
        {
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item3 == email || aluno.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if ((empresa.Item3 == email || empresa.Item4 == telefone) && DadosUsuario.listaEmpresas.IndexOf(empresa) != indiceAtual)
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

        private void button5_Click(object sender, EventArgs e)
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

            if (result == DialogResult.OK)
            {
                if (confirmarSenha())
                {
                    var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
                    user.Item6 = false;
                    var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1)
                    {
                        DadosUsuario.listaEmpresas[index] = user;
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

            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
                if (user.Item5 == textBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAnunciarVaga_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomeEmpresaTextBox.Text) ||
                string.IsNullOrEmpty(nomeVagaTextBox.Text) ||
                string.IsNullOrEmpty(CargaHTextBox.Text) ||
                string.IsNullOrEmpty(RemuneracaoTextBox.Text) ||
                string.IsNullOrEmpty(CursoVBox.Text) ||
                string.IsNullOrEmpty(CargoTextBox.Text) ||
                string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }
           
            string nomeEmpresa = NomeEmpresaTextBox.Text;
            string nomeVaga = nomeVagaTextBox.Text;
            int cargaHoraria = int.Parse(CargaHTextBox.Text);
            double remuneracao = double.Parse(RemuneracaoTextBox.Text);
            string cargo = CargoTextBox.Text;
            string curso = CursoVBox.Text;
            string descricao = DescricaoTextBox.Text;
            
            Vaga novaVaga = new Vaga(nomeVaga, nomeEmpresa, cargo, cargaHoraria, remuneracao, curso, descricao);
            Vaga.addVaga(novaVaga);

            nomeVagaTextBox.Clear();           
            CargoTextBox.Clear();
            CargaHTextBox.Clear();
            RemuneracaoTextBox.Clear();
            CursoVBox.SelectedIndex = -1;
            DescricaoTextBox.Clear();

            MessageBox.Show("Vaga criada com sucesso!");
        }

        private void CargaHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RemuneracaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CargaHTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVaga_Click(object sender, EventArgs e)
        {
            
            btnVaga2.BackColor = Color.Black;
            btnVaga2.ForeColor = Color.White;
            btnMinhasVagas2.BackColor = SystemColors.Control;
            btnMinhasVagas2.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = true;
            panelMinhasVagas.Visible = false;
            panelAnunciarVaga.BringToFront();
        }

        private void btnMinhasVagas_Click(object sender, EventArgs e)
        {
            btnMinhasVagas.BackColor = Color.Black;
            btnMinhasVagas.ForeColor = Color.White;
            btnVaga.BackColor = SystemColors.Control;
            btnVaga.ForeColor = Color.Black;
            btnMinhasVagas2.BackColor = Color.Black;
            btnMinhasVagas2.ForeColor = Color.White;
            btnVaga2.BackColor = SystemColors.Control;
            btnVaga2.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = true;
            panelMinhasVagas.BringToFront();
            
            LoadMinhasVagas();
        }

        private void btnCriarVaga2_Click(object sender, EventArgs e)
        {
            btnVaga.BackColor = Color.Black;
            btnVaga.ForeColor = Color.White;
            btnMinhasVagas.BackColor = SystemColors.Control;
            btnMinhasVagas.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = true;
            panelMinhasVagas.Visible = false;
            panelAnunciarVaga.BringToFront();
        }

        private void gridViewMinhasVagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCandidatos.AllowUserToAddRows = false;
            dataGridViewCandidatos.AllowUserToAddRows = false;
           
            if (e.ColumnIndex == gridViewMinhasVagas.Columns["colExibir"].Index && e.RowIndex >= 0)
            {
                Vaga vaga = Vaga.vagas[e.RowIndex];
                vaga.alteracao = false;
                nomeVaga = gridViewMinhasVagas.Rows[e.RowIndex].Cells["NomeVagaGrid"].Value.ToString();
                dataGridViewCandidatos.Rows.Clear();
                foreach (var vagas in vaga.Candidatos)
                {              
                    int idcadastrado = int.Parse(vagas);
                    var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == idcadastrado);

                    if(vaga.Candidatos.Contains(user.Item1.ToString()) && user.Item7 == true)
                    {
                        DataGridViewButtonCell botaoChat = new DataGridViewButtonCell();
                        botaoChat.Value = "Chat";

                        byte[] imageBytes = user.Item10; // bytes contendo a imagem
                        Image imagem = null;

                        if (imageBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                imagem = Image.FromStream(ms);
                            }
                        }
                        dataGridViewCandidatos.Rows.Add(imagem, user.Item2, user.Item3, user.Item4, "Chat");
                    }                
                }
                Load_Cadastrados();
                panelAlunoCadastrado.Visible = true;
                panelAlunoCadastrado.BringToFront();
            }           
        }

        public void LoadMinhasVagas()
        {
            gridViewMinhasVagas.AllowUserToAddRows = false;
            gridViewMinhasVagas.AllowUserToAddRows = false;       
            gridViewMinhasVagas.Rows.Clear();
            
            var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);  
            
            foreach(var vagas in Vaga.vagas)
            {                            
                if (user.Item2 == vagas.NomeEmpresa)
                {
                    DataGridViewButtonCell button1 = new DataGridViewButtonCell();
                    button1.Value = "+";
                    var icone = Properties.Resources.botaoAluno1;
                    if (vagas.alteracao == true)
                    {
                        icone = Properties.Resources.botaoAluno2;
                    }
                    gridViewMinhasVagas.Rows.Add(icone, vagas.NomeVaga, vagas.Cargo, vagas.cargaHoraria, vagas.remuneracao, vagas.Curso, "+");
                }              
            }
            gridViewMinhasVagas.ClearSelection();
        }

        private void dataGridViewE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//DATAGRIDVIEW CANDIDATOS
            
            if (e.ColumnIndex == dataGridViewCandidatos.Columns["colContato"].Index && e.RowIndex >= 0)
            {               
                // Obtém o usuário selecionado
                var Destinatario = DadosUsuario.listaAlunos.Find(u => u.Item3 == (dataGridViewCandidatos.Rows[e.RowIndex].Cells["colEmail"].Value.ToString()));
                //
                panelMensagens.Visible = true;
                
                panelMensagens.BringToFront();               
                int destinatario = Destinatario.Item1;
                Chat.getIdDestinatario = destinatario;
                int remetente = Program.userAtual;
                Chat.CriarChat(remetente, destinatario);
                var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));
                if(chat != null)
                {
                    Chat.LoadMensagens(panelMensagens , chat);
                }              
                LoadConversas();
            }
        }

        private void panelAlunoCadastrado_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bataoVoltar_Click(object sender, EventArgs e)
        {
            panelAlunoCadastrado.Visible = false;
            LoadMinhasVagas();
        }

        private void Load_Cadastrados()
        {

        }

        //  CRIAÇÃO DO CHAT
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Chat.EnviarMensagem(Program.userAtual, Chat.getIdDestinatario, txtMensagem.Text);
            txtMensagem.Clear();

            // Verificar qual é o chat Correto
            var chat = Chat.listaChats.FirstOrDefault(c =>
                (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));

            // Verificar se o chat foi encontrado
            if (chat != null)
            {
                Chat.LoadMensagens(panelMensagens, chat); // Passa o objeto Chat como parâmetro
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelMensagens.Visible = false;
            LoadConversas();
        }

        public void LoadConversas()
        {
            Chat.LoadGridConversas(FlowPanelConversas, FlowPanelConversas_Click);
        }

        /// <summary>
        /// NÃO REMOVA MESMO ESTANDO SEM REFERENCIA
        /// </summary>
        public event EventHandler FlowPanelConversasClick;// captura o evento
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

                Chat.LoadMensagens(panelMensagens, chat);
                // Define a visibilidade do painel de mensagens como true
                panelMensagens.Visible = true;
                panelMensagens.BringToFront();
            }
        }

        private void buttonEncerrarVaga_Click(object sender, EventArgs e)
        {
            Vaga vaga = Vaga.vagas.Find(v => v.NomeVaga == nomeVaga);
            foreach(DataGridViewRow row in dataGridViewCandidatos.Rows)// percorrer as linhas do datagridView
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[colSelecionado.Index];// obtem o valor do checkbox
                if(Convert.ToBoolean(cell.Value) == true)
                {
                    string email = row.Cells[colEmail.Index].Value.ToString();                   
                    int idDestinatario = Chat.ObterIdUsuarioPeloEmail(email);
                    Chat.CriarChat(Program.userAtual, idDestinatario);
                    Chat.EnviarMensagem(Program.userAtual, idDestinatario, "Você foi selecionado para a vaga de " +
                        $"{nomeVaga} na nossa empresa através do nosso aplicativo de vagas de emprego. Parabéns!");
                }
                else
                {
                    string email = row.Cells[colEmail.Index].Value.ToString();
                    int idDestinatario = Chat.ObterIdUsuarioPeloEmail(email);
                    Chat.CriarChat(Program.userAtual, idDestinatario);
                    Chat.EnviarMensagem(Program.userAtual, idDestinatario, "Infelizmente, não selecionamos sua candidatura " +
                        $"para a vaga de {nomeVaga}. Agradecemos pelo seu interesse e tempo dedicado ao processo seletivo.");
                }
            }
            panelAlunoCadastrado.Visible = false;          
            Vaga.vagas.Remove(vaga);
            gridViewMinhasVagas.Rows.Clear();
            LoadMinhasVagas();
            gridViewMinhasVagas.Refresh();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
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
    }
}