using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class yourMessage : UserControl
    {
        public yourMessage(string remetente, string mensagem, string time)
        {
            InitializeComponent();
            labelNome.Text = remetente;
            labelMensagemYour.Text = mensagem + "\n" + time;
            labelMensagemYour.RightToLeft = RightToLeft.Yes;
        }
    }
}
