using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParms = base.CreateParams;
                handleParms.ExStyle |= 0x02000000;
                return handleParms;
            }
        }



        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public TelaCadastro()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaCadastro_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            botaoCriarconta.Select();// INICIA COM O BOTAO CRIE SUA CONTA ATIVO
            KeyPreview = true;// BOTÃO ENTRAR COM ENTER
            this.KeyDown += new KeyEventHandler(Enter_KeyDown_Cadastro);// BOTÃO ENTRAR COM ENTER
        }

        private void Enter_KeyDown_Cadastro(object sender, KeyEventArgs e)
        {
            //BOTÃO ENTRAR COM ENTER
            if (e.KeyCode == Keys.Enter && cadastroAluno.Visible == true)
            {
                botaoCriarcontaa.PerformClick();
                return;
            }
            else if(e.KeyCode == Keys.Enter && cadastroEmpresa.Visible == true)
            {
                botaoCriarconta.PerformClick();
                return;
            }
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
            DadosUsuario.listaAlunos.Add((Program.id++, "Saulo", " ", " ", "Eventos"," ", true, " ", false, null));
            DadosUsuario.listaAlunos.Add((Program.id++, "Aluno B", "b", "b", "Eventos", "b", true, " ", false, null));
            DadosUsuario.listaEmpresas.Add((Program.id++, "Empresa A", "a", "a", "a", true, "a", false, null));
            DadosUsuario.listaCoordenador.Add((Program.id++, "Nome Coordenador", "c", "c", "c", "c", null));
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
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
        }

        private void textNomeE_Leave(object sender, EventArgs e)
        {
            if (textNomeE.Text == "")
            {
                textNomeE.Text = "NOME COMPLETO";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
        }


        private void textEmailE_Enter(object sender, EventArgs e)
        {
            if (textEmailE.Text == "E-MAIL")
            {
                textEmailE.Text = "";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
        }

        private void textEmailE_Leave(object sender, EventArgs e)
        {
            if (textEmailE.Text == "")
            {
                textEmailE.Text = "E-MAIL";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
        }

        private void textTelE_Enter(object sender, EventArgs e)
        {
            if (textTelE.Text == "TELEFONE")
            {
                textTelE.Text = "";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;

            
        }

        private void textTelE_Leave(object sender, EventArgs e)
        {
            if (textTelE.Text == "")
            {
                textTelE.Text = "TELEFONE";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
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
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
        }

        private void textSenhaE_Leave(object sender, EventArgs e)
        {
            if (textSenhaE.Text == "")
            {
                textSenhaE.PasswordChar = '\0';
                textSenhaE.Text = "SENHA";
            }
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;
            txtIndisponivel.Visible = false;
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
            bool dadosValidos = true;
            txtIndisponivel.Visible = false;
            txtEmailInvalido.Visible = false;
            txtTelefoneInvalido.Visible = false;
            txtDadosInvalidos.Visible = false;

            if (textNomeE.Text.ToLower().Contains("nome") || textEmailE.Text.ToLower().Contains("email") ||
                textTelE.Text.ToLower().Contains("telefone") || textSenhaE.Text.ToLower().Contains("senha"))
            {
                dadosValidos = false;
                txtDadosInvalidos.Visible = true;
            }
            else if (!IsValidEmail(textEmailE.Text))
            {
                dadosValidos = false;
                txtEmailInvalido.Visible = true;
            }
            else if (!IsValidPhone(textTelE.Text))
            {
                dadosValidos = false;
                txtTelefoneInvalido.Visible = true;
            }
            else if (!DadosDisponiveis(textEmailE.Text, textTelE.Text))
            {
                dadosValidos = false;
                txtIndisponivel.Visible = true;
            }

            if (DadosDisponiveis(textEmailE.Text, textTelE.Text) == true && dadosValidos == true)
            {
                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // LISTA EMPRESA: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaEmpresas.Add((Program.id++, textNomeE.Text, textEmailE.Text, textTelE.Text, textSenhaE.Text, true, null, false, null));
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
                
                MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaLogin login = new TelaLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private bool IsValidEmail(string email)
        {
            // Verifica se o email é válido
            // Exemplo: "username@domain.com"
            return !string.IsNullOrEmpty(email) && new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email);
        }

        private bool IsValidPhone(string phone)
        {
            // Verifica se o telefone é válido
            // Exemplo: "(99) 9999-9999" ou "(99) 99999-9999"
            return Regex.IsMatch(phone, @"^\(\d{2}\) \d{4,5}-\d{4}$");
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
            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;

        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                textNome.Text = "NOME COMPLETO";
            }

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNome.Text))
            {
                string[] nomes = textNome.Text.Split(' ');
                StringBuilder resultado = new StringBuilder();

                foreach (string nome in nomes)
                {
                    if (resultado.Length > 0)
                        resultado.Append(" ");

                    if (nome.ToLower() == "da" || nome.ToLower() == "do" || nome.ToLower() == "das" ||
                        nome.ToLower() == "dos" || nome.ToLower() == "de" || nome.ToLower() == "e" ||
                        nome.ToLower() == "eles")
                    {
                        resultado.Append(nome.ToLower());
                    }
                    else
                    {
                        if (nome.Length > 0)
                        {
                            string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                            string restante = nome.Substring(1).ToLower();
                            resultado.Append(primeiroCaractere + restante);
                        }
                    }
                }

                textNome.Text = resultado.ToString();
                textNome.SelectionStart = textNome.Text.Length;
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "E-MAIL")
            {
                textEmail.Text = "";
            }

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "E-MAIL";
            }

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
        }

        private void textTelefone_Enter(object sender, EventArgs e)
        {
            if (textTelefone.Text == "TELEFONE")
            {
                textTelefone.Text = "";
            }

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
        }

        private void textTelefone_Leave(object sender, EventArgs e)
        {
            if (textTelefone.Text == "")
            {
                textTelefone.Text = "TELEFONE";
            }

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
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

            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == "")
            {
                textSenha.PasswordChar = '\0';
                textSenha.Text = "SENHA";
            }
            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtIndisponivel2.Visible = false;
            txtCursoInvalido.Visible = false;
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
            bool dadosValidos = true;
            txtIndisponivel2.Visible = false;
            txtEmailInvalido2.Visible = false;
            txtTelefoneInvalido2.Visible = false;
            txtDadosInvalidos2.Visible = false;
            txtCursoInvalido.Visible = false;

            if (textNome.Text.ToLower().Contains("nome") || textEmail.Text.ToLower().Contains("email") ||
                textTelefone.Text.ToLower().Contains("telefone") || textSenha.Text.ToLower().Contains("senha"))
            {
                dadosValidos = false;
                txtDadosInvalidos2.Visible = true;
            }
            else if (!IsValidEmail(textEmail.Text))
            {
                dadosValidos = false;
                txtEmailInvalido2.Visible = true;
            }
            else if (!IsValidPhone(textTelefone.Text))
            {
                dadosValidos = false;
                txtTelefoneInvalido2.Visible = true;
            }
            else if (!DadosDisponiveis(textEmail.Text, textTelefone.Text))
            {
                dadosValidos = false;
                txtIndisponivel2.Visible = true;
            }
            else if (opCurso.Text == "CURSO")
            {
                dadosValidos = false;
                txtCursoInvalido.Visible = true;
            }

            if (DadosDisponiveis(textEmail.Text, textTelefone.Text) == true && dadosValidos == true)
            {


                // ADICIONAR DADOS NA LISTA (TELA DE CADASTRO)
                // ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação)
                DadosUsuario.listaAlunos.Add((Program.id++, textNome.Text, textEmail.Text, textTelefone.Text, opCurso.Text, textSenha.Text, true, null, false, null));
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
                
                MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaLogin login = new TelaLogin();
                login.Show();
                this.Hide();
            }
            else
            {
            }
        }
        // FIM DO PAINEL DO ALUNO
    }
}
