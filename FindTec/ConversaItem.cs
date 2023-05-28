using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTec
{
    public partial class ConversaItem : UserControl
    {
        public string NomeItem { get; private set; }
        public ConversaItem(string destinatario, string ultimaMensagem)
        {
            InitializeComponent();
            NomeItem = destinatario;
            labelNome.Text = destinatario;
            labelUltimaMensagem.Text = ultimaMensagem;
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
    }
}
