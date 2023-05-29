using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form1 : Form
    {
        private Image imagemSelecionada;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
            Load_gridViewOportunidades(); // CARREGA O GRID 
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = nomeTxt.Text; //Inicia o nome do aluno grande a paritr da caixa de texto com o nome do aluno
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
            nomeTxt.Text = user.Item2;
            emailTxt.Text = user.Item3;
            telefoneTxt.Text = user.Item4;           
            cursoTxt.Text = user.Item5;
            panelPerfil.Visible = true;
            ////////
            if (user.Item10 != null && user.Item10.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item10))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            

            panelPerfil.Visible = true;
            panelOportunidades.Visible = false;
            panelConversas.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

            panelPerfil.Visible = false;
            panelOportunidades.Visible = true;
            panelConversas.Visible = false;
            panelOportunidades.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            panelPerfil.Visible = false;
            panelOportunidades.Visible = false;
            panelConversas.Visible = true;
            panelConversas.BringToFront();
            LoadConversas();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

       private void opA2_Load(object sender, EventArgs e)
       {

       }
        private void opD1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

                        pictureBox1.Image = imagemSelecionada;
                        pictureBox2.Image = imagemSelecionada;


                        var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

                        user.Item10 = dadosImagem;

                        var index = DadosUsuario.listaAlunos.FindIndex(u => u.Item1 == Program.userAtual);// descobro o indece do usuario
                        if (index != -1)
                        {
                            DadosUsuario.listaAlunos[index] = user;
                        }

                        Console.WriteLine(""+user);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                    user.Item2 = nomeTxt.Text;
                    user.Item3 = emailTxt.Text;
                    user.Item4 = telefoneTxt.Text;

                    var index = DadosUsuario.listaAlunos.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(emailTxt.Text, telefoneTxt.Text, index))
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

        private void button2_Click(object sender, EventArgs e)
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

                panelVagaInfo.Visible = true;
                panelVagaInfo.BringToFront();
            }
        }
        //FIM TABELA OPORTUNIDADES

        private void botaoCandidatar_Click(object sender, EventArgs e)
        {
            Vaga vaga = Vaga.vagas.Find(v => v.NomeVaga == txtTituloVaga.Text);
            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);
            vaga.Candidatos.Add(user.Item1.ToString());// Passa o ID PARA A LISTA DE CADASTRADOS

            MessageBox.Show("Cadastrado com sucesso!!!\n aguarde o contado da empresa contratante.");
            gridViewOportunidades.Rows.RemoveAt(gridViewOportunidades.CurrentRow.Index);
            panelVagaInfo.Visible = false;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            panelVagaInfo.Visible = false;
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

                Chat.LoadMensagens(panelMensagens, chat);
                // Define a visibilidade do painel de mensagens como true
                panelMensagens.Visible = true;
                panelMensagens.BringToFront();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelMensagens.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int idDestinatario = Chat.getIdDestinatario;
            Chat.EnviarMensagem(Program.userAtual, idDestinatario, txtMensagem.Text);
            txtMensagem.Clear();
            var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));

            Chat.LoadMensagens(panelMensagens, chat);
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

                Chat.LoadMensagens(panelMensagens, chat);
                // Define a visibilidade do painel de mensagens como true
                panelMensagens.Visible = true;
                panelMensagens.BringToFront();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
                // Obtém a imagem da PictureBox
                Image image = pictureBox1.Image;

                if (image != null)
                {
                    // Calcula a proporção de redimensionamento
                    float ratio = (float)pictureBox1.Height / image.Height;

                    // Calcula as dimensões da imagem redimensionada
                    int width = (int)(image.Width * ratio);
                    int height = pictureBox1.Height;

                    // Calcula as coordenadas X e Y para centralizar a imagem
                    int x = (pictureBox1.Width - width) / 2;
                    int y = (pictureBox1.Height - height) / 2;

                    // Desenha a imagem redimensionada
                    e.Graphics.DrawImage(image, x, y, width, height);
                }

                // Cria uma região elíptica do mesmo tamanho que a PictureBox
                System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
                roundPath.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);

                // Define a região da PictureBox para a região elíptica
                pictureBox1.Region = new System.Drawing.Region(roundPath);
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            // Obtém a imagem da PictureBox
            Image image = pictureBox2.Image;

            if (image != null)
            {
                // Calcula a proporção de redimensionamento
                float ratio = (float)pictureBox2.Height / image.Height;

                // Calcula as dimensões da imagem redimensionada
                int width = (int)(image.Width * ratio);
                int height = pictureBox2.Height;

                // Calcula as coordenadas X e Y para centralizar a imagem
                int x = (pictureBox2.Width - width) / 2;
                int y = (pictureBox2.Height - height) / 2;

                // Desenha a imagem redimensionada
                e.Graphics.DrawImage(image, x, y, width, height);
            }

            // Cria uma região elíptica do mesmo tamanho que a PictureBox
            System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
            roundPath.AddEllipse(0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);

            // Define a região da PictureBox para a região elíptica
            pictureBox2.Region = new System.Drawing.Region(roundPath);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = nomeTxt.Text;
        }

        


        

       

        /// FIM MENSAGENS
    }
}
