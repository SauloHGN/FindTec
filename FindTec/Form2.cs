using System;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
        private void opD1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opA1.Visible = true;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;
        }
    }
}
