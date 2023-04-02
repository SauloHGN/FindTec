using System;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                   
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }      
       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            opA1.Visible = true;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;
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
    }
}
