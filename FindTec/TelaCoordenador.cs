using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCoordenador : Form
    {
        public static string motivo;
        public TelaCoordenador()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA
            buttonListAluno_Click_1(this, new EventArgs());//INICIAR COM O BOTÃO ALUNO SELECIONADO
            this.KeyDown += new KeyEventHandler(EnviarMensagem_Enter);// Enviar mensagem com Enter
            Load_gridViewOportunidades();
            LoadConversas();
            LoadGridUsuarios();
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panelPerfilC.Visible = true;
            var user = DadosUsuario.listaCoordenador.Find(u => u.Item1 == Program.userAtual);
            nomeTxt.Text = user.Item2;
            emailTxt.Text = user.Item3;
            telefoneTxt.Text = user.Item4;                   

            if (user.Item7 != null && user.Item7.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item7))
                {
                    picAvatarCoordenador1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picAvatarCoordenador1.Image = null;
            }
            LoadDataGridView();
            LoadDataViewGridE();
        }

        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            panelCadastroAprov.Visible = false;
            panelOportunidades.Visible = false;
            panelViewUsuarios.Visible = false;
            panelConversas.Visible = true;
            panelPerfilC.Visible = true;
            panelPerfilC.BringToFront();
        }

        private void botaoAprovarCadastro_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadDataGridView();
            

            panelCadastroAprov.Visible = true;
            panelPerfilC.Visible = false;
            panelOportunidades.Visible = false;
            panelConversas.Visible = false;
            panelViewUsuarios.Visible = false;
            dataGridView1.ClearSelection();
            panelCadastroAprov.BringToFront();
        }

        private void botaoVagas_Click(object sender, EventArgs e)
        {
            
            panelPerfilC.Visible = false;
            panelCadastroAprov.Visible = false;
            panelMensagens.Visible = false;
            panelConversas.Visible = false;
            panelViewUsuarios.Visible = false;
            panelOportunidades.Visible = true;
            
        }
        private void botaoMensagens_Click(object sender, EventArgs e)
        {
            
            panelPerfilC.Visible = false;
            panelCadastroAprov.Visible = false;
            panelOportunidades.Visible = false;
            panelViewUsuarios.Visible = false;
            panelConversas.Visible = true;
            panelConversas.BringToFront();
        }

        private void botaoGenrenciarUsuarios_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.Rows.Clear();
            LoadGridUsuarios();
            panelViewUsuarios.Visible = true;        
            panelViewUsuarios.BringToFront();
            dataGridViewUsuarios.ClearSelection();
        }

        private void LoadDataGridView()
        {          
            dataGridView1.AutoGenerateColumns = false;
            
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item9 == false)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = aluno.Item2;//NOME
                    row.Cells[1].Value = "Aluno";//TIPO
                    row.Cells[2].Value = aluno.Item3;//EMAIL
                    row.Cells[3].Value = aluno.Item4;//TELEFONE

                    DataGridViewButtonCell button1 = new DataGridViewButtonCell();
                    button1.Value = "Aprovar";
                    row.Cells[4] = button1;// BOTÃO APROVAR

                    DataGridViewButtonCell button2 = new DataGridViewButtonCell();
                    button2.Value = "Reprovar";
                    row.Cells[5] = button2; //BOTÃO RECUSAR

                    dataGridView1.Rows.Add(row);// ADICONA TODAS AS COLUNAS AO DATAGRIDVIEW
                }
            }         
            dataGridView1.ClearSelection();          
        }

        private void LoadDataViewGridE()
        {
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item8 == false)
                {
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridViewE);
                    row1.Cells[0].Value = empresa.Item2;//NOME
                    row1.Cells[1].Value = "Empresa";//TIPO
                    row1.Cells[2].Value = empresa.Item3;//EMAIL
                    row1.Cells[3].Value = empresa.Item4;//TELEFONE

                    DataGridViewButtonCell buttonE1 = new DataGridViewButtonCell();
                    buttonE1.Value = "Aprovar";
                    row1.Cells[4] = buttonE1;// BOTÃO APROVAR

                    DataGridViewButtonCell buttonE2 = new DataGridViewButtonCell();
                    buttonE2.Value = "Reprovar";
                    row1.Cells[5] = buttonE2; //BOTÃO RECUSAR

                    dataGridViewE.Rows.Add(row1);// ADICONA TODAS AS COLUNAS AO DATAGRIDVIEW
                }
            }
            dataGridViewE.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var type = row.Cells[1].Value.ToString();


                if (e.ColumnIndex == dataGridView1.Columns["ColumnAprov"].Index && type == "Aluno" && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {                 
                    var aluno = DadosUsuario.listaAlunos[e.RowIndex];// obtem o objeto selecionado
                                                 
                    var alunoModificado = aluno; // copiar cada propriedade do objeto original
                    alunoModificado.Item1 = aluno.Item1;
                    alunoModificado.Item2 = aluno.Item2;
                    alunoModificado.Item3 = aluno.Item3;
                    alunoModificado.Item4 = aluno.Item4;
                    alunoModificado.Item5 = aluno.Item5;
                    alunoModificado.Item6 = aluno.Item6;
                    alunoModificado.Item7 = aluno.Item7;
                    alunoModificado.Item8 = aluno.Item8;
                    alunoModificado.Item9 = true;

                    // definir o objeto modificado na lista
                    DadosUsuario.listaAlunos.Add(alunoModificado);
                    DadosUsuario.listaAlunos.Remove(aluno);
                    Console.WriteLine("" + aluno);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);// remover a linha do DataGridView                                   
                   
                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        // Atualiza a lista                       
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                    }
                        return;
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColumnRecusar"].Index && type == "Aluno" && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {                   
                    var aluno = DadosUsuario.listaAlunos[e.RowIndex];
                    DadosUsuario.listaAlunos.Remove(aluno);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    Console.WriteLine("" + aluno);
                        
                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        // Atualiza a lista
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();
                    }
                   else
                   {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                   }
                   
                    return;
                }                           
            }          
        }

        private void dataGridViewE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row1 = dataGridViewE.Rows[e.RowIndex];
                var type = row1.Cells[1].Value.ToString();

                if (e.ColumnIndex == dataGridViewE.Columns["ColumnAprovE"].Index && type == "Empresa" && e.RowIndex < DadosUsuario.listaEmpresas.Count)
                {
                   
                    var empresa = DadosUsuario.listaEmpresas[dataGridViewE.CurrentRow.Index];// obtem o objeto selecionado

                    var empresaModificada = empresa; // copiar cada propriedade do objeto original
                    empresaModificada.Item1 = empresa.Item1;
                    empresaModificada.Item2 = empresa.Item2;
                    empresaModificada.Item3 = empresa.Item3;
                    empresaModificada.Item4 = empresa.Item4;
                    empresaModificada.Item5 = empresa.Item5;
                    empresaModificada.Item6 = empresa.Item6;
                    empresaModificada.Item7 = empresa.Item7;
                    empresaModificada.Item8 = true;

                    // definir o objeto modificado na lista
                    DadosUsuario.listaEmpresas.Add(empresaModificada);
                    DadosUsuario.listaEmpresas.Remove(empresa);
                    Console.WriteLine("" + empresa);
                    dataGridViewE.Rows.RemoveAt(dataGridViewE.CurrentRow.Index);// remover a linha do DataGridView                                   

                    if (DadosUsuario.listaEmpresas.Count > 1)
                    {
                        // Atualiza a lista                       
                        dataGridViewE.Refresh();
                        dataGridViewE.ClearSelection();
                    }
                    else
                    {
                        dataGridViewE.Rows.Clear();
                        LoadDataGridView();
                    }
                    return;
                }
                else if (e.ColumnIndex == dataGridViewE.Columns["ColumnRecusarE"].Index && type == "Empresa" && e.RowIndex < DadosUsuario.listaEmpresas.Count)
                {

                    Console.WriteLine("empresa verif2");
                    var empresa = DadosUsuario.listaEmpresas[dataGridViewE.CurrentRow.Index];
                    DadosUsuario.listaEmpresas.Remove(empresa);
                    dataGridViewE.Rows.RemoveAt(dataGridViewE.CurrentRow.Index);
                    Console.WriteLine("" + empresa);

                    if (DadosUsuario.listaEmpresas.Count > 1)
                    {
                        // Atualiza a lista
                        dataGridViewE.Refresh();
                        dataGridViewE.ClearSelection();
                    }
                    else
                    {
                        dataGridViewE.Rows.Clear();
                        LoadDataGridView();
                    }
                    return;
                }
            }
        }
        private void Load_gridViewOportunidades()
        {
            gridViewOportunidades.AllowUserToAddRows = false;
            gridViewOportunidades.AllowUserToAddRows = false;
            gridViewOportunidades.Rows.Clear();

            var user = DadosUsuario.listaAlunos.Find(u => u.Item1 == Program.userAtual);

            foreach (var vagas in Vaga.vagas)
            {
                // RECUPERAR IMAGEM
                
                   byte[] imageBytes = vagas.getFoto(vagas.NomeEmpresa); // bytes contendo a imagem
                   Image imagem = null;

                   if (imageBytes != null)
                   {
                       using (MemoryStream ms = new MemoryStream(imageBytes))
                       {
                           imagem = Image.FromStream(ms);
                       }
                   }
                   DataGridViewButtonCell button1 = new DataGridViewButtonCell();
                   button1.Value = "Excluir";
                   gridViewOportunidades.Rows.Add(imagem, vagas.NomeEmpresa, vagas.NomeVaga, vagas.Cargo, vagas.cargaHoraria, vagas.remuneracao, "Excluir");
                
            }
            gridViewOportunidades.ClearSelection();
        }

        private void gridViewOportunidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridViewOportunidades.Columns["colExcluir"].Index && e.RowIndex >= 0)
            {
                string nomeVaga = gridViewOportunidades.Rows[e.RowIndex].Cells["NomeVagaGrid"].Value.ToString();
                string nomeEmpresa = gridViewOportunidades.Rows[e.RowIndex].Cells["colNomeEmpresa"].Value.ToString();
                Vaga vaga = Vaga.vagas.Find(v => v.NomeVaga == nomeVaga);

                if(Motivo())
                {
                    Vaga.vagas.Remove(vaga);
                    gridViewOportunidades.Rows.Clear();
                    Load_gridViewOportunidades();
                    dataGridView1.Refresh();                
                    int idDestinatario = Chat.ObterIdUsuarioPeloNome(nomeEmpresa);
                    Chat.CriarChat(Program.userAtual, idDestinatario);
                    Chat.EnviarMensagem(Program.userAtual, idDestinatario, "Gostaríamos de informar que a vaga de " +
                        $"{nomeVaga} que você havia cadastrado em nosso sistema infelizmente foi removida pelo seguinte motivo:" +
                        $"{motivo}");
                    LoadConversas();
                }                             
            }
        }

        private void buttonListEmpresa_Click(object sender, EventArgs e)
        {
           
            dataGridViewE.Visible = true;
            dataGridView1.Visible = false;
            dataGridViewE.Rows.Clear();
            LoadDataViewGridE();
        }

        private void buttonListAluno_Click_1(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = true;
            dataGridViewE.Visible = false;
            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private Image imagemSelecionada;
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

                        picAvatarCoordenador1.Image = imagemSelecionada;
                        picAvatarCoordenador2.Image = imagemSelecionada;


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

            if (result == DialogResult.Cancel)
            {
                Form3_Load(this, e);
            }

            // Se o usuário confirmou a entrada de dados, exibe o valor inserido
            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaCoordenador.Find(u => u.Item1 == Program.userAtual);

                if(user.Item5 == textBox.Text)
                {
                    user.Item2 = nomeTxt.Text;
                    user.Item3 = emailTxt.Text;
                    user.Item4 = telefoneTxt.Text;

                    if (emailTxt.Text.Contains("@") && emailTxt.Text.Contains(".com"))
                    {
                        user.Item3 = emailTxt.Text;
                    }
                    else
                    {
                        MessageBox.Show("E-mail inválido");
                        return;
                    }

                    if (IsPhoneNumberValid(telefoneTxt.Text))
                    {
                        user.Item4 = telefoneTxt.Text;
                    }
                    else
                    {
                        MessageBox.Show("Telefone inválido");
                        return;
                    }

                    var index = DadosUsuario.listaCoordenador.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(emailTxt.Text, telefoneTxt.Text, index))
                    {
                        DadosUsuario.listaCoordenador[index] = user;
                        MessageBox.Show("Dados alterados com sucesso");

                        this.Close();
                    }
                    else
                    {
                        Form3_Load(this, e);
                        MessageBox.Show("Os dados já estão em uso");
                    }
                }
                else
                {
                    Form3_Load(this, e);
                    MessageBox.Show("Senha incorreta...");
                }
            }
        }

        private bool IsPhoneNumberValid(string phone)
        {
            // Verifica se o telefone é válido
            // Exemplo: "(99) 9999-9999" ou "(99) 99999-9999"
            return Regex.IsMatch(phone, @"^\(\d{2}\) \d{4,5}-\d{4}$");
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
                if (empresa.Item3 == email || empresa.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if ((coordenador.Item3 == email || coordenador.Item4 == telefone) && DadosUsuario.listaCoordenador.IndexOf(coordenador) != indiceAtual)
                {
                    return false;
                }
            }          
            return true;
        }

        private bool Motivo()
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            // Cria um label com a mensagem para o usuário
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Digite o motivo da Exclusão:" };
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

            if (result == DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(textBox.Text))
                {
                    motivo = textBox.Text;
                    return true;
                }
                MessageBox.Show("É necessario preencher o campo\n para excluir a vaga.");
                
            }            
            return false;
        }

        // INICIO MENSAGENS

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
        // FIM MENSAGENS


        public void LoadGridUsuarios()
        {
            dataGridViewUsuarios.AllowUserToAddRows = false;
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                // Aluno aprovado e conta ativa
                if(aluno.Item9 == true && aluno.Item7 == true)
                {
                    DataGridViewButtonCell botaoContato = new DataGridViewButtonCell();
                    botaoContato.Value = "Contato";
                    dataGridViewUsuarios.Rows.Add(aluno.Item2, "Aluno", aluno.Item3, aluno.Item4, "Contato");
                }              
            }

            foreach(var empresa in DadosUsuario.listaEmpresas)
            {
                // Empresa Aprovada e conta ativa
                if(empresa.Item8 == true && empresa.Item6 == true)
                {
                    DataGridViewButtonCell botaoContato = new DataGridViewButtonCell();
                    botaoContato.Value = "Contato";
                    dataGridViewUsuarios.Rows.Add(empresa.Item2, "Empresa", empresa.Item3, empresa.Item4, "Contato");
                }
            }

            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                // Exibe os outros coordenadores
                if (coordenador.Item1 != Program.userAtual)
                {
                    DataGridViewButtonCell botaoContato = new DataGridViewButtonCell();
                    botaoContato.Value = "Contato";
                    dataGridViewUsuarios.Rows.Add(coordenador.Item2, "Coordenador", coordenador.Item3, coordenador.Item4, "Contato");
                }
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUsuarios.AllowUserToAddRows = false;
            

            if (e.ColumnIndex == dataGridViewUsuarios.Columns["colContato"].Index && e.RowIndex >= 0)
            {
                string tipo = dataGridViewUsuarios.Rows[e.RowIndex].Cells["colTipo"].Value.ToString();

                int idDestinatario = -999;

                if(tipo == "Aluno")
                {
                    // Obtém o usuário selecionado
                    var Destinatario = DadosUsuario.listaAlunos.Find(u => u.Item3 == (dataGridViewUsuarios.Rows[e.RowIndex].Cells["colEmail"].Value.ToString()));
                    idDestinatario = Destinatario.Item1;

                }
                else if (tipo == "Empresa")
                {
                    var Destinatario = DadosUsuario.listaEmpresas.Find(u => u.Item3 == (dataGridViewUsuarios.Rows[e.RowIndex].Cells["colEmail"].Value.ToString()));
                    idDestinatario = Destinatario.Item1;
                }
                else
                {
                    var Destinatario = DadosUsuario.listaCoordenador.Find(u => u.Item3 == (dataGridViewUsuarios.Rows[e.RowIndex].Cells["colEmail"].Value.ToString()));
                    idDestinatario = Destinatario.Item1;
                }
                        
                if(idDestinatario == -999)
                {
                    return;
                }

                //
                panelMensagens.Visible = true;
                panelMensagens.BringToFront();
                int destinatario = idDestinatario;
                Chat.getIdDestinatario = destinatario;
                int remetente = Program.userAtual;
                Chat.CriarChat(remetente, destinatario);
                var chat = Chat.listaChats.FirstOrDefault(c =>
                    (c.Remetente == Program.userAtual && c.Destinatario == Chat.getIdDestinatario) ||
                    (c.Remetente == Chat.getIdDestinatario && c.Destinatario == Program.userAtual));
                if (chat != null)
                {
                    Chat.LoadMensagens(panelMensagens, chat);
                }
                LoadConversas();
            }
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

        private void picAvatarCoordenador1_Paint(object sender, PaintEventArgs e)
        {
            // Obtém a imagem da PictureBox
            Image image = picAvatarCoordenador1.Image;

            if (image != null)
            {
                // Calcula a proporção de redimensionamento
                float ratio = (float)picAvatarCoordenador1.Height / image.Height;

                // Calcula as dimensões da imagem redimensionada
                int width = (int)(image.Width * ratio);
                int height = picAvatarCoordenador1.Height;

                // Calcula as coordenadas X e Y para centralizar a imagem
                int x = (picAvatarCoordenador1.Width - width) / 2;
                int y = (picAvatarCoordenador1.Height - height) / 2;

                // Desenha a imagem redimensionada
                e.Graphics.DrawImage(image, x, y, width, height);
            }

            // Cria uma região elíptica do mesmo tamanho que a PictureBox
            System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
            roundPath.AddEllipse(0, 0, picAvatarCoordenador1.Width - 1, picAvatarCoordenador1.Height - 1);

            // Define a região da PictureBox para a região elíptica
            picAvatarCoordenador1.Region = new System.Drawing.Region(roundPath);
        }

        private void picAvatarCoordenador2_Paint(object sender, PaintEventArgs e)
        {
            // Obtém a imagem da PictureBox
            Image image = picAvatarCoordenador2.Image;

            if (image != null)
            {
                // Calcula a proporção de redimensionamento
                float ratio = (float)picAvatarCoordenador2.Height / image.Height;

                // Calcula as dimensões da imagem redimensionada
                int width = (int)(image.Width * ratio);
                int height = picAvatarCoordenador2.Height;

                // Calcula as coordenadas X e Y para centralizar a imagem
                int x = (picAvatarCoordenador2.Width - width) / 2;
                int y = (picAvatarCoordenador2.Height - height) / 2;

                // Desenha a imagem redimensionada
                e.Graphics.DrawImage(image, x, y, width, height);
            }

            // Cria uma região elíptica do mesmo tamanho que a PictureBox
            System.Drawing.Drawing2D.GraphicsPath roundPath = new System.Drawing.Drawing2D.GraphicsPath();
            roundPath.AddEllipse(0, 0, picAvatarCoordenador2.Width - 1, picAvatarCoordenador2.Height - 1);

            // Define a região da PictureBox para a região elíptica
            picAvatarCoordenador2.Region = new System.Drawing.Region(roundPath);
        }

        private void botaoPerfil_MouseEnter(object sender, EventArgs e)
        {
            botaoPerfil.BackgroundImage = Properties.Resources.botaoPerfil_2;
        }

        private void botaoPerfil_MouseLeave(object sender, EventArgs e)
        {
            botaoPerfil.BackgroundImage = Properties.Resources.botaoPerfil_1;
        }

        private void botaoAprovarCadastro_MouseEnter(object sender, EventArgs e)
        {
            botaoAprovarCadastro.BackgroundImage = Properties.Resources.botaoAprovarCadastro2;
        }

        private void botaoAprovarCadastro_MouseLeave(object sender, EventArgs e)
        {
            botaoAprovarCadastro.BackgroundImage = Properties.Resources.botaoAprovarCadastro1;
        }

        private void botaoVagas_MouseEnter(object sender, EventArgs e)
        {
            botaoVagas.BackgroundImage = Properties.Resources.botaoVagas2;
        }

        private void botaoVagas_MouseLeave(object sender, EventArgs e)
        {
            botaoVagas.BackgroundImage = Properties.Resources.botaoVagas1;
        }

        private void botaoMensagens_MouseEnter(object sender, EventArgs e)
        {
            botaoMensagens.BackgroundImage = Properties.Resources.botaoMensagens_2;
        }

        private void botaoMensagens_MouseLeave(object sender, EventArgs e)
        {
            botaoMensagens.BackgroundImage = Properties.Resources.botaoMensagens_1;
        }

        private void botaoGerenciarusuarios_MouseEnter(object sender, EventArgs e)
        {
            botaoGerenciarUsuarios.BackgroundImage = Properties.Resources.botaoGerenciaUsuarios2;
        }

        private void botaoGerenciarusuarios_MouseLeave(object sender, EventArgs e)
        {
            botaoGerenciarUsuarios.BackgroundImage = Properties.Resources.botaoGerenciaUsuarios1;
        }

        private void botaoAlterarFoto_MouseEnter(object sender, EventArgs e)
        {
            botaoAlterarFoto.BackgroundImage = Properties.Resources.BotaoAlterarImagem_2;
        }

        private void botaoAlterarFoto_MouseLeave(object sender, EventArgs e)
        {
            botaoAlterarFoto.BackgroundImage = Properties.Resources.BotaoAlterarImagem_1;
        }

        private void botaoAlterarSenha_MouseEnter(object sender, EventArgs e)
        {
            botaoAlterarSenha.BackgroundImage = Properties.Resources.botaoAlterarSenha_2;
        }

        private void botaoAlterarSenha_MouseLeave(object sender, EventArgs e)
        {
            botaoAlterarSenha.BackgroundImage = Properties.Resources.botaoAlterarSenha_1;
        }

        private void botaoEditarDados_MouseEnter(object sender, EventArgs e)
        {
            botaoEditarDados.BackgroundImage = Properties.Resources.botaoEditarDados_2;
        }

        private void botaoEditarDados_MouseLeave(object sender, EventArgs e)
        {
            botaoEditarDados.BackgroundImage = Properties.Resources.botaoEditarDados_1;
        }

        private void botaoDesativarConta_MouseEnter(object sender, EventArgs e)
        {
            botaoDesativarConta.BackgroundImage = Properties.Resources.botaoDesativarConta_2;
        }

        private void botaoDesativarConta_MouseLeave(object sender, EventArgs e)
        {
            botaoDesativarConta.BackgroundImage = Properties.Resources.botaoDesativarConta_1;
        }

        private void botaoAlterarSenha_Click(object sender, EventArgs e)
        {
            RecuperarSenha senha = new RecuperarSenha();           
            this.Hide();
            senha.Show();
        }

        private void buttonListAluno5_MouseEnter(object sender, EventArgs e)
        {
            buttonListAluno5.BackgroundImage = Properties.Resources.botaoAl2;
        }

        private void buttonListAluno5_MouseLeave(object sender, EventArgs e)
        {
            buttonListAluno5.BackgroundImage = Properties.Resources.botaoAl1;
        }

        private void buttonListEmpresa_MouseEnter(object sender, EventArgs e)
        {
            buttonListEmpresa.BackgroundImage = Properties.Resources.botaoEm2;
        }

        private void buttonListEmpresa_MouseLeave(object sender, EventArgs e)
        {
            buttonListEmpresa.BackgroundImage = Properties.Resources.botaoEm1;
        }

        private void nomeTxt_TextChanged(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(nomeTxt.Text))
                {
                    string[] nomes = nomeTxt.Text.Split(' ');
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
                    nomeTxt.Text = resultado.ToString();
                    nomeTxt.SelectionStart = nomeTxt.Text.Length;
                }
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            string texto = emailTxt.Text;

            if (texto.ToUpper() == "E-MAIL")
            {
                emailTxt.Text = "E-MAIL";
            }
            else
            {
                emailTxt.Text = texto.ToLower();
            }

            // Definir o cursor no final do texto
            emailTxt.SelectionStart = emailTxt.Text.Length;
        }

        private bool formatandoTelefone = false;

        private void telefoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (!formatandoTelefone)
            {
                formatandoTelefone = true;

                // Remove todos os caracteres não numéricos do telefone
                string telefone = new string(telefoneTxt.Text.Where(char.IsDigit).ToArray());

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

                telefoneTxt.Text = telefone;
                telefoneTxt.SelectionStart = telefone.Length;

                formatandoTelefone = false;
            }
        }

        private void telefoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (telefoneTxt.TextLength >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
