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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;
            if (textNomeC.Text.ToLower().Contains("nome completo") || textEmailC.Text.ToLower().Contains("e-mail") ||
                textTelC.Text.ToLower().Contains("telefone") || textSenhaC.Text.ToLower().Contains("senha"))
            {
                txtIndisponivel.Visible = true;
                return;
            }
            else if (!IsValidEmail(textEmailC.Text))
            {
                dadosValidos = false;
                txtIndisponivel.Visible = true;
                return;
            }
            else if (!IsValidPhone(textTelC.Text))
            {
                dadosValidos = false;
                txtIndisponivel.Visible = true;
                return;
            }

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

            MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
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

        private void botaoSair_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        private void botaoSair_MouseEnter(object sender, EventArgs e)
        {
            botaoSair.BackgroundImage = Properties.Resources.botaoSair_2;
        }

        private void botaoSair_MouseLeave(object sender, EventArgs e)
        {
            botaoSair.BackgroundImage = Properties.Resources.botaoSair_1;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.botaoCriarconta2;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.botaoCriarconta1;
        }

        private void textNomeC_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNomeC.Text))
            {
                if (textNomeC.Text.ToLower() == "nome completo")
                {
                    textNomeC.Text = "NOME COMPLETO";
                    textNomeC.SelectionStart = textNomeC.Text.Length;
                    return;
                }

                string[] nomes = textNomeC.Text.Split(' ');
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

                textNomeC.Text = resultado.ToString();
                textNomeC.SelectionStart = textNomeC.Text.Length;
            }
        }

        private void textEmailC_TextChanged(object sender, EventArgs e)
        {
            string texto = textEmailC.Text;

            if (texto.ToUpper() == "E-MAIL")
            {
                textEmailC.Text = "E-MAIL";
            }
            else
            {
                textEmailC.Text = texto.ToLower();
            }

            // Definir o cursor no final do texto
            textEmailC.SelectionStart = textEmailC.Text.Length;
        }


        private bool formatandoTelefone = false;

        private void textTelC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textTelC.TextLength >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textTelC_TextChanged(object sender, EventArgs e)
        {
            if (!formatandoTelefone)
            {
                formatandoTelefone = true;

                // Remove todos os caracteres não numéricos do telefone
                string telefone = new string(textTelC.Text.Where(char.IsDigit).ToArray());

                // Verifica se o texto é igual a "TELEFONE" em maiúsculas
                if (string.Equals(textTelC.Text, "TELEFONE", StringComparison.OrdinalIgnoreCase))
                {
                    telefone = "TELEFONE";
                }
                else if (telefone.Length >= 2)
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

                textTelC.Text = telefone;
                textTelC.SelectionStart = telefone.Length;

                formatandoTelefone = false;
            }
        }

        private void textSenha_Enter(object sender, EventArgs e)
        {
            if (textSenhaC.Text == "SENHA")
            {
                textSenhaC.Text = "";
            }

            textSenhaC.PasswordChar = '•';
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenhaC.Text == "")
            {
                textSenhaC.PasswordChar = '\0';
                textSenhaC.Text = "SENHA";
            }
        }

        private void textNome_Enter(object sender, EventArgs e)
        {
            if (textNomeC.Text == "NOME COMPLETO")
            {
                textNomeC.Text = "";
            }        
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNomeC.Text == "")
            {
                textNomeC.Text = "NOME COMPLETO";
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmailC.Text == "E-MAIL")
            {
                textEmailC.Text = "";
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmailC.Text == "")
            {
                textEmailC.Text = "E-MAIL";
            }
        }

        private void textTelefone_Enter(object sender, EventArgs e)
        {
            if (textTelC.Text == "TELEFONE")
            {
                textTelC.Text = "";

            }
        }

        private void textTelefone_Leave(object sender, EventArgs e)
        {
            if (textTelC.Text == "")
            {
                    textTelC.Text = "TELEFONE";
            }
        }
    }
}
