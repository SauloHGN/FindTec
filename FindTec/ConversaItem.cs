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
                imagem = Properties.Resources.botaoAluno1;
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
            labelUltimaMensagem.BackColor = Color.Silver;
            labelNome.BackColor = Color.Silver;
            this.BackColor = Color.Silver;
        }

        private void ConversaItem_MouseLeave(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.White;
            labelNome.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void labelNome_MouseEnter(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.Silver;
            labelNome.BackColor = Color.Silver;
            this.BackColor = Color.Silver;
        }

        private void labelNome_MouseLeave(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.White;
            labelNome.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void labelUltimaMensagem_MouseEnter(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.Silver;
            labelNome.BackColor = Color.Silver;
            this.BackColor = Color.Silver;
        }

        private void labelUltimaMensagem_MouseLeave(object sender, EventArgs e)
        {
            labelUltimaMensagem.BackColor = Color.White;
            labelNome.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void labelMensagemNaoLida_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMensagemNaoLida_MouseEnter(object sender, EventArgs e)
        {
            labelMensagemNaoLida.BackColor = Color.Silver;
            labelMensagemNaoLida.BackColor = Color.Silver;
            this.BackColor = Color.Silver;
        }

        private void labelMensagemNaoLida_MouseLeave(object sender, EventArgs e)
        {
            labelMensagemNaoLida.BackColor = Color.White;
            labelMensagemNaoLida.BackColor = Color.White;
            this.BackColor = Color.White;
        }
    }
}
