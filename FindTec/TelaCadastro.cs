using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {
        
        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public TelaCadastro()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaCadastro_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            botaoCriarconta.Select();// INICIA COM O BOTAO CRIE SUA CONTA ATIVO

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

        private void Admin()
        {
            // ADICIONAR CADASTRO DO COORDENADOR(A)
            DadosUsuario.listaAdmin.Add((0, "admin", "admin"));
        }

        public void AcessarAdmin()
        {
            //Admin();// ACESSAR O METODO PRIVADO
            Admin();
        }      
            

        //PAINEL DA EMPRESA
        private void textNomeE_Enter(object sender, EventArgs e)
        {
            if (textNomeE.Text == "NOME COMPLETO")
            {
                textNomeE.Text = "";
            }

            txtIndisponivel.Visible = false;
        }

        private void textNomeE_Leave(object sender, EventArgs e)
        {
            if (textNomeE.Text == "")
            {
                textNomeE.Text = "NOME COMPLETO";
            }

            txtIndisponivel.Visible = false;
        }

        private void textEmailE_Enter(object sender, EventArgs e)
        {
            if (textEmailE.Text == "E-MAIL")
            {
                textEmailE.Text = "";
            }

            txtIndisponivel.Visible = false;
        }

        private void textEmailE_Leave(object sender, EventArgs e)
        {
            if (textEmailE.Text == "")
            {
                textEmailE.Text = "E-MAIL";
            }

            txtIndisponivel.Visible = false;
        }

        private void textTelE_Enter(object sender, EventArgs e)
        {
            if (textTelE.Text == "TELEFONE")
            {
                textTelE.Text = "";
            }

            txtIndisponivel.Visible = false;

            
        }

        private void textTelE_Leave(object sender, EventArgs e)
        {
            if (textTelE.Text == "")
            {
                textTelE.Text = "TELEFONE";
            }

            txtIndisponivel.Visible = false;
        }

        private bool formatandoTelefone = false;

        private void textTelE_TextChanged(object sender, EventArgs e)
        {
            if (!formatandoTelefone)
            {
                formatandoTelefone = true;

                // Remove todos os caracteres não numéricos do telefone
                string telefone = new string(textTelE.Text.Where(char.IsDigit).ToArray());

                if (telefone.Length >= 2)
                {
                    // Garante que a string tenha um comprimento mínimo antes de aplicar a formatação
                    if (telefone.Length <= 2)
                    {
                        telefone = string.Format("({0}", telefone);
                    }
                    else if (telefone.Length <= 6)
                    {
                        telefone = string.Format("({0}) {1}", telefone.Substring(0, 2), telefone.Substring(2));
                    }
                    else if (telefone.Length <= 10)
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 4), telefone.Substring(6));
                    }
                    else
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(7));
                    }
                }

                textTelE.Text = telefone;
                textTelE.SelectionStart = telefone.Length;

                formatandoTelefone = false;
            }
        }

        private void textTelE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textTelE.TextLength >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textSenhaE_Enter(object sender, EventArgs e)
        {
            if (textSenhaE.Text == "SENHA")
            {
                textSenhaE.Text = "";
            }

            textSenhaE.PasswordChar = '•';
        }

        private void textSenhaE_Leave(object sender, EventArgs e)
        {
            if (textSenhaE.Text == "")
            {
                textSenhaE.PasswordChar = '\0';
                textSenhaE.Text = "SENHA";
            }
        }        

        private void botaoCriarconta_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta2" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta2;

            // Define a nova imagem como o background do botão
            botaoCriarconta.BackgroundImage = novaImagem;
        }

        private void botaoCriarconta_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta1" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta1;

            // Define a nova imagem como o background do botão
            botaoCriarconta.BackgroundImage = novaImagem;
        }

        private void botaoCriarconta_Click(object sender, EventArgs e)
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

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaEscolha escolha = new TelaEscolha();
            escolha.Show();
            this.Hide();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        // FIM DO PAINEL DA EMPRESA

        //PAINEL DO ALUNO
        private void textNome_Enter(object sender, EventArgs e)
        {
            if (textNome.Text == "NOME COMPLETO")
            {
                textNome.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                textNome.Text = "NOME COMPLETO";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "E-MAIL")
            {
                textEmail.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "E-MAIL";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textTelefone_Enter(object sender, EventArgs e)
        {
            if (textTelefone.Text == "TELEFONE")
            {
                textTelefone.Text = "";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textTelefone_Leave(object sender, EventArgs e)
        {
            if (textTelefone.Text == "")
            {
                textTelefone.Text = "TELEFONE";
            }

            txtIndisponivelA.Visible = false;
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {
            if (!formatandoTelefone)
            {
                formatandoTelefone = true;

                // Remove todos os caracteres não numéricos do telefone
                string telefone = new string(textTelefone.Text.Where(char.IsDigit).ToArray());

                if (telefone.Length >= 2)
                {
                    // Garante que a string tenha um comprimento mínimo antes de aplicar a formatação
                    if (telefone.Length <= 2)
                    {
                        telefone = string.Format("({0}", telefone);
                    }
                    else if (telefone.Length <= 6)
                    {
                        telefone = string.Format("({0}) {1}", telefone.Substring(0, 2), telefone.Substring(2));
                    }
                    else if (telefone.Length <= 10)
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 4), telefone.Substring(6));
                    }
                    else
                    {
                        telefone = string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(7));
                    }
                }

                textTelefone.Text = telefone;
                textTelefone.SelectionStart = telefone.Length;

                formatandoTelefone = false;
            }
        }

        private void textTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textTelefone.TextLength >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            opCurso.SelectedItem = "CURSO";
        }

        private void textSenha_Enter(object sender, EventArgs e)
        {
            if (textSenha.Text == "SENHA")
            {
                textSenha.Text = "";
            }

            textSenha.PasswordChar = '•';
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == "")
            {
                textSenha.PasswordChar = '\0';
                textSenha.Text = "SENHA";
            }
        }

        

        private void botaoCriarcontaA_MouseEnter(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta2" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta2;

            // Define a nova imagem como o background do botão
            botaoCriarcontaa.BackgroundImage = novaImagem;
        }

        private void botaoCriarcontaA_MouseLeave(object sender, EventArgs e)
        {
            // Carrega a nova imagem do arquivo "botaoCriarconta1" do resources.resx
            Image novaImagem = Properties.Resources.botaoCriarconta1;

            // Define a nova imagem como o background do botão
            botaoCriarcontaa.BackgroundImage = novaImagem;
        }

        

        private void botaoFecharA_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        private void botaoVoltarA_Click(object sender, EventArgs e)
        {
            TelaEscolha escolha = new TelaEscolha();
            escolha.Show();
            this.Hide();
        }

        private void botaoCriarcontaa_Click(object sender, EventArgs e)
        {
            txtIndisponivelA.Visible = false;
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
                txtIndisponivelA.Visible = true;
            }
        }
        // FIM DO PAINEL DO ALUNO
    }
}
