using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTec
{
    public partial class ConversaItem : UserControl
    {
        public string NomeItem { get; private set; }     
        private int mensagensNaoLidas;
        public int MensagensNaoLidas
        {
            get { return mensagensNaoLidas; }
            set
            {
                mensagensNaoLidas = value;
                AtualizarMensagensNaoLidas();
            }
        }

        public ConversaItem( byte[] foto, string destinatario, string ultimaMensagem, int mensagemNaoLida)
        {
            InitializeComponent();
            NomeItem = destinatario;
            labelNome.Text = destinatario;
            labelUltimaMensagem.Text = ultimaMensagem;
            MensagensNaoLidas = mensagemNaoLida;
            AtualizarMensagensNaoLidas();
            var FotoNull = Chat.ObterIdUsuarioPeloNome(destinatario);

            byte[] imageBytes = foto; // bytes contendo a imagem
            Image imagem = null;

            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    imagem = Image.FromStream(ms); // conversão
                }
            }
            if(imagem == null)
            {
                //imagem = Properties.Resources.imagemAluno;
                var userExists = DadosUsuario.listaAlunos.Exists(u => u.Item1 == FotoNull);
                if (userExists)
                {
                    imagem = Properties.Resources.imagemAluno;
                }
                else
                {
                    userExists = DadosUsuario.listaEmpresas.Exists(u => u.Item1 == FotoNull);
                    if (userExists)
                    {
                        imagem = Properties.Resources.imagemEmpresa;
                    }
                    else
                    {
                        imagem = Properties.Resources.imagemCoordenador;
                    }
                }
            }
            pictureBox1.Image = imagem;

        }

        public void AtualizarMensagensNaoLidas()
        {
            if (MensagensNaoLidas > 0)
            {          
                labelMensagemNaoLida.Text = MensagensNaoLidas.ToString();
                labelMensagemNaoLida.Visible = true;
            }
            else
            {
                labelMensagemNaoLida.Visible = false;
            }

        }

        private void ConversaItem_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.fundoMensagemRecebida2;
            ((Control)sender).BackgroundImage = novaImagem;
        }


        private void ConversaItem_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.fundoMensagemRecebida1;
            ((Control)sender).BackgroundImage = novaImagem;
        }


        private void labelNome_MouseEnter(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.Silver;
            labelNome.BackColor = Color.Silver;
            this.BackColor = Color.Silver;
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
    }
}
