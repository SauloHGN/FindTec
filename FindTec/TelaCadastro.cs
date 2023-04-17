using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {      
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

        public static bool DadosDisponiveis(string email, string telefone)
        {
            foreach (var alunos in DadosUsuario.listaAlunos)
            {
                if (alunos.Item3 == email || alunos.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var empresas in DadosUsuario.listaEmpresas)
            {
                if (empresas.Item3 == email || empresas.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if (coordenador.Item3 == email || coordenador.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var admin in DadosUsuario.listaAdmin)
            {
                if (admin.Item3 == email)
                {
                    return false;
                }
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIndisponivel.Visible = false;
            if (DadosDisponiveis(textEmailE.Text, textTelE.Text))
            {
                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // LISTA EMPRESA: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaEmpresas.Add((Program.id++, textNomeE.Text, textEmailE.Text, textTelE.Text, textSenhaE.Text, true, null, false));
                foreach (var empresa in DadosUsuario.listaEmpresas)
                {
                    Console.WriteLine("ID: " + empresa.Item1);
                    Console.WriteLine("Nome: " + empresa.Item2);
                    Console.WriteLine("Email: " + empresa.Item3);
                    Console.WriteLine("Telefone: " + empresa.Item4);
                    Console.WriteLine("Senha: " + empresa.Item5);
                    Console.WriteLine("Status: " + empresa.Item6);
                    Console.WriteLine("Codigo: " + empresa.Item7);
                    Console.WriteLine("Aprovação: " + empresa.Item8);
                }
                //LIMPAR TEXTO DOS CAMPOS
                textNomeE.Clear();
                textEmailE.Clear();
                textTelE.Clear();
                textSenhaE.Clear();
            }
            else
            {
                txtIndisponivel.Visible = true;
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            txtIndisponivel.Visible = false;
            if (DadosDisponiveis(textEmail.Text, textTelefone.Text))
            {


                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaAlunos.Add((Program.id++, textNome.Text, textEmail.Text, textTelefone.Text, opCurso.Text, textSenha.Text, true, null, false));
                foreach (var aluno in DadosUsuario.listaAlunos)
                {
                    Console.WriteLine("ID: " + aluno.Item1);
                    Console.WriteLine("Nome: " + aluno.Item2);
                    Console.WriteLine("Email: " + aluno.Item3);
                    Console.WriteLine("Telefone: " + aluno.Item4);
                    Console.WriteLine("Curso: " + aluno.Item5);
                    Console.WriteLine("Senha: " + aluno.Item6);
                    Console.WriteLine("Status: " + aluno.Item7);
                    Console.WriteLine("Codigo: " + aluno.Item8);
                    Console.WriteLine("Aprovado: " + aluno.Item9);

                }
                // limpar os campos
                textNome.Clear();
                textEmail.Clear();
                textTelefone.Clear();
                opCurso.SelectedIndex = -1;
                textSenha.Clear();
            }
            else
            {
                txtIndisponivel.Visible = true;
            }
        }

        public void AcessarAdmin()
        {
            //Admin();// ACESSAR O METODO PRIVADO
            Admin();
        }      
        private void Admin()
        {
            // ADICIONAR CADASTRO DO COORDENADOR(A)
            DadosUsuario.listaAdmin.Add((0, "admin", "admin"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cadastroEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }    
    }
}
