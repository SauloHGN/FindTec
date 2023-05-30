using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace FindTec
{
    class Chat
    {
        public static int getIdDestinatario;
        public static int idUsuario;
        public  int Remetente { get; set; }
        public  int Destinatario { get; set; }
        public List<Mensagens> Mensagens { get; set; }

        public static List<Chat> listaChats = new List<Chat>();

        public Chat(int remetente, int destinatario)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Mensagens = new List<Mensagens>();
        }

        // Cria um novo chat entre os usuários com IDs RemetenteId e DestinatarioId
        public static void CriarChat(int remetente, int destinatario)
        {
            // Verifica se já existe
            var chat = listaChats.FirstOrDefault(c =>
            (c.Remetente == remetente && c.Destinatario == destinatario) ||
            (c.Remetente == destinatario && c.Destinatario == remetente));

            // caso não exita, cria um
            if (chat == null)
            {
                Chat novoChat = new Chat(remetente, destinatario);
                listaChats.Add(novoChat);
            }
        }

        // Envia uma mensagem do RemetenteId para o DestinatarioId no chat correspondente
        public static void EnviarMensagem(int remetente, int destinatario, string mensagem)
        {
            // Procura pelo chat entre os usuários com IDs RemetenteId e DestinatarioId
            var chat = listaChats.FirstOrDefault(c =>
            (c.Remetente == remetente && c.Destinatario == destinatario) ||
            (c.Remetente == destinatario && c.Destinatario == remetente));
         
            // Se o chat não existir
            if (chat == null)
            {
                CriarChat(remetente, destinatario);
            }

            if (string.IsNullOrEmpty(mensagem))
            {
                return;
            }
            // Adiciona a mensagem à lista de mensagens do chat
            if(chat != null)
            {
                Mensagens novaMensagem = new Mensagens
                {
                    Timestamp = DateTime.Now,
                    Text = mensagem,
                    RemetenteId = remetente
                };

                chat.Mensagens.Add(novaMensagem);
            }                   
        }

        public static void LoadGridConversas(FlowLayoutPanel FlowPanelConversas, EventHandler clickHandler)
        {
            int identificador = Program.userAtual;
            FlowPanelConversas.Controls.Clear();

            foreach (var chat in listaChats)
            {
                // Verifica se o chat envolve o usuário atual
                if (chat.Remetente == identificador || chat.Destinatario == identificador)
                {
                    int destinatarioId = (chat.Remetente == identificador) ? chat.Destinatario : chat.Remetente;
                    string destinatario = VerificarDestinatario(destinatarioId);
                    byte[] foto = obterFotoPeloID(destinatarioId);
                    UserControl itemControl;
                    
                    itemControl = new ConversaItem(foto, destinatario, chat.Mensagens.LastOrDefault()?.Text);// UserControl personalizado para exibir as informações do chat

                    itemControl.Click += clickHandler;// manipulador de click

                    FlowPanelConversas.Controls.Add(itemControl);    // Adiciona o UserControl ao FlowLayoutPanel               
                }
            }
        }
    
        public static void LoadMensagens(Panel panelMensagens, Chat chat)
        {
            FlowLayoutPanel flowLayoutPanel = panelMensagens.Controls.Find("flowLayoutPanelMensagens", true).FirstOrDefault() as FlowLayoutPanel;
            
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            if (flowLayoutPanel != null)
            {
                flowLayoutPanel.Controls.Clear();

                if (chat != null)
                {
                    foreach (var mensagem in chat.Mensagens)
                    {
                        int remetenteId = mensagem.RemetenteId;
                        string remetenteNome = chat.Remetente == remetenteId ? VerificarRemetente(chat.Remetente) : VerificarDestinatario(chat.Remetente);
                        string destinatarioNome = chat.Destinatario == getIdDestinatario ? VerificarDestinatario(chat.Destinatario) : VerificarDestinatario(chat.Destinatario);
                        UserControl messageControl;
                        string time = mensagem.Timestamp.ToString("HH:mm");

                        if (remetenteId == chat.Remetente)
                        {
                            messageControl = new myMessage(remetenteNome, mensagem.Text, time);
                        }
                        else
                        {
                            messageControl = new yourMessage(destinatarioNome, mensagem.Text, time);
                        }                        

                        flowLayoutPanel.Controls.Add(messageControl);
                        flowLayoutPanel.ScrollControlIntoView(messageControl);// acompanha a ultima mensagem adicionada
                    }
                }
            }
        }
        

        public static string VerificarRemetente(int remetente)
        {
            var aluno = DadosUsuario.listaAlunos.Find(u => u.Item1 == remetente);
            if (aluno != default)
            {
                return aluno.Item2;
            }

            var empresa = DadosUsuario.listaEmpresas.Find(u => u.Item1 == remetente);
            if (empresa != default)
            {
                return empresa.Item2;
            }

            var coordenador = DadosUsuario.listaCoordenador.Find(u => u.Item1 == remetente);
            if (coordenador != default)
            {
                return coordenador.Item2;
            }

            return string.Empty;
        }
        public static string VerificarDestinatario(int destinatario)
        {
            var aluno = DadosUsuario.listaAlunos.Find(u => u.Item1 == destinatario);
            if (aluno != default)
            {
                return aluno.Item2;
            }

            var empresa = DadosUsuario.listaEmpresas.Find(u => u.Item1 == destinatario);
            if (empresa != default)
            {
                return empresa.Item2;
            }

            var coordenador = DadosUsuario.listaCoordenador.Find(u => u.Item1 == destinatario);
            if (coordenador != default)
            {
                return coordenador.Item2;
            }

            return string.Empty;
        }
        public static int ObterIdUsuarioPeloNome(string nomeUsuario)
        {
            var aluno = DadosUsuario.listaAlunos.Find(u => u.Item2 == nomeUsuario);
            if (aluno != default)
            {
                idUsuario = aluno.Item1;
                return aluno.Item1;
            }

            var empresa = DadosUsuario.listaEmpresas.Find(u => u.Item2 == nomeUsuario);
            if (empresa != default)
            {
                idUsuario = empresa.Item1;
                return empresa.Item1;
            }

            var coordenador = DadosUsuario.listaCoordenador.Find(u => u.Item2 == nomeUsuario);
            if (coordenador != default)
            {
                idUsuario = coordenador.Item1;
                return coordenador.Item1;
            }
            // Se o usuário não for encontrado
            return -999;
        }

        public static byte[] obterFotoPeloID(int identificador)
        {
            var aluno = DadosUsuario.listaAlunos.Find(u => u.Item1 == identificador);
            if (aluno != default)
            {
                idUsuario = aluno.Item1;
                return aluno.Item10;
            }

            var empresa = DadosUsuario.listaEmpresas.Find(u => u.Item1 == identificador);
            if (empresa != default)
            {
                idUsuario = empresa.Item1;
                return empresa.Item9;
            }

            var coordenador = DadosUsuario.listaCoordenador.Find(u => u.Item1 == identificador);
            if (coordenador != default)
            {
                idUsuario = coordenador.Item1;
                return coordenador.Item7;
            }
            // Se o usuário não for encontrado
            return null;
        }

    }
}
