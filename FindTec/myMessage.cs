using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTec
{
    public partial class myMessage : UserControl
    {
        public myMessage(string remetente, string mensagem, string time)
        {          
            InitializeComponent();           
            this.DoubleBuffered = true;
            labelNome.Text = remetente;
            labelMensagemMy.Text = mensagem + "\n" + time;         
        }

    

        private void labelMensagemMy_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
