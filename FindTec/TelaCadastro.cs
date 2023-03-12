using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {
        private DadosUsuario dadosUsuario = new DadosUsuario();
        
        public TelaCadastro()
        {
            InitializeComponent();
            button1_Click(this, new EventArgs());//INICIAR COM O BOTÃO ALUNO SELECIONADO
            this.FormClosing += new FormClosingEventHandler(TelaCadastro_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroEmpresa.Visible = false;
            cadastroAluno.Visible = true;
            buttonCadastroAluno.BackColor = Color.Black;
            buttonCadastroAluno.ForeColor = Color.White;
            buttonCadastroEmpresa.BackColor = SystemColors.Control;
            buttonCadastroEmpresa.ForeColor = Color.Black;

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastroAluno.Visible = false;
            cadastroEmpresa.Visible = true;
            buttonCadastroEmpresa.BackColor = Color.Black;
            buttonCadastroEmpresa.ForeColor = Color.White;
            buttonCadastroAluno.BackColor = SystemColors.Control;
            buttonCadastroAluno.ForeColor = Color.Black;

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
                      
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
            // LISTA EMPRESA: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS)
            DadosUsuario.listaEmpresas.Add(Tuple.Create(0, textNomeE.Text, textEmailE.Text, textTelE.Text, textSenhaE.Text, true));
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                Console.WriteLine("ID: " + empresa.Item1);
                Console.WriteLine("Nome: " + empresa.Item2);
                Console.WriteLine("Email: " + empresa.Item3);
                Console.WriteLine("Telefone: " + empresa.Item4);              
                Console.WriteLine("Senha: " + empresa.Item5);
                Console.WriteLine("Status: " + empresa.Item6);
            }
            //LIMPAR TEXTO DOS CAMPOS
            textNomeE.Clear();
            textEmailE.Clear();
            textTelE.Clear();          
            textSenhaE.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
            // ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS)
            DadosUsuario.listaAlunos.Add(Tuple.Create(0, textNome.Text, textEmail.Text, textTelefone.Text, opCurso.Text, textSenha.Text, true));
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                Console.WriteLine("ID: " + aluno.Item1);
                Console.WriteLine("Nome: " + aluno.Item2);
                Console.WriteLine("Email: " + aluno.Item3);
                Console.WriteLine("Telefone: " + aluno.Item4);
                Console.WriteLine("Curso: " + aluno.Item5);
                Console.WriteLine("Senha: " + aluno.Item6);
                Console.WriteLine("Status: " + aluno.Item7);
            }
            // limpar os campos
            textNome.Clear();
            textEmail.Clear();
            textTelefone.Clear();
            opCurso.SelectedIndex = -1; 
            textSenha.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
