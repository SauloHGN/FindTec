using System;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form4_FormClosing);                   
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            cadastroCoordenador.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            cadastroCoordenador.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
            cadastroCoordenador.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            cadastroCoordenador.Visible = false;
        }

        private void opA1_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtIndisponivel.Visible = false;
            TelaCadastro cadastro = new TelaCadastro();
            if (TelaCadastro.DadosDisponiveis(textEmailC.Text, textTelC.Text))
            {
                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // ListaCoordenador: (ID, NOME, EMAIL, TELEFONE, SENHA, codigo)
                DadosUsuario.listaCoordenador.Add((Program.id++, textNomeC.Text, textEmailC.Text, textTelC.Text, textSenhaC.Text, null, null));
                foreach (var empresa in DadosUsuario.listaEmpresas)
                {
                    Console.WriteLine("ID: " + empresa.Item1);
                    Console.WriteLine("Nome: " + empresa.Item2);
                    Console.WriteLine("Email: " + empresa.Item3);
                    Console.WriteLine("Telefone: " + empresa.Item4);
                    Console.WriteLine("Senha: " + empresa.Item5);                  
                    Console.WriteLine("Codigo: " + empresa.Item6);
                    
                }
                //LIMPAR TEXTO DOS CAMPOS
                textNomeC.Clear();
                textEmailC.Clear();
                textTelC.Clear();
                textSenhaC.Clear();
            }
            else
            {
                txtIndisponivel.Visible = true;
            }
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

    }
}
