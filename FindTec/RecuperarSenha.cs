using System.Windows.Forms;
using System;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace FindTec
{
    public partial class RecuperarSenha : Form
    {
        private string codigo;
        private string email;
        private string senha;
        TelaLogin login = new TelaLogin();
        public RecuperarSenha()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(RecuperarSenha_FormClosing);// USADO PARA FECHAR APLICAÇÃO
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                Console.WriteLine($"{coordenador.Item1} | {coordenador.Item2} | {coordenador.Item3} | {coordenador.Item4} | {coordenador.Item5} | {coordenador.Item6}");
            }
            Console.WriteLine("---------------------------------");
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                Console.WriteLine($"{aluno.Item1} | {aluno.Item2} | {aluno.Item3} | {aluno.Item4} | {aluno.Item5} | {aluno.Item6}| {aluno.Item7}| {aluno.Item8} |{aluno.Item9} |{aluno.Item10}");
            }
            Console.WriteLine("---------------------------------");
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                Console.WriteLine($"{empresa.Item1} | {empresa.Item2} | {empresa.Item3} | {empresa.Item4} | {empresa.Item5} | {empresa.Item6}| {empresa.Item7}| {empresa.Item8}");
            }
            Console.WriteLine("---------------------------------");
            foreach (var admin in DadosUsuario.listaAdmin)
            {
                Console.WriteLine($"{admin.Item1} | {admin.Item2} | {admin.Item3}");
            }
        }

        private void RecuperarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {         
            login.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            email = EmailRE.Text;
            VerficarEmail(email);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codigo = textCodigo.Text;
            VerificarCodigo(codigo, email);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            senha = textNewSenha.Text;
            TrocarSenha(codigo, senha);
        }

        private void TrocarSenha(string codigo, string senha)
        {
            for (int i = 0; i < DadosUsuario.listaCoordenador.Count; i++)
            {
                var coordenador = DadosUsuario.listaCoordenador;
                if (DadosUsuario.listaCoordenador[i].Item6 == codigo)
                {                  
                    DadosUsuario.listaCoordenador[i] = (
                    DadosUsuario.listaCoordenador[i].Item1,
                    DadosUsuario.listaCoordenador[i].Item2,
                    DadosUsuario.listaCoordenador[i].Item3,
                    DadosUsuario.listaCoordenador[i].Item4,
                    senha,
                    DadosUsuario.listaCoordenador[i].Item6,
                    DadosUsuario.listaCoordenador[i].Item7
                    );
                    Console.WriteLine("Senha Alterada");
                    login.Show();
                    this.Hide();
                    break;
                }
            }
            for (int i = 0; i < DadosUsuario.listaAlunos.Count; i++)
            {
                var aluno = DadosUsuario.listaAlunos;
                if (DadosUsuario.listaAlunos[i].Item8 == codigo)
                {                    

                    DadosUsuario.listaAlunos[i] = (
                    DadosUsuario.listaAlunos[i].Item1,
                    DadosUsuario.listaAlunos[i].Item2,
                    DadosUsuario.listaAlunos[i].Item3,
                    DadosUsuario.listaAlunos[i].Item4,
                    DadosUsuario.listaAlunos[i].Item5,
                    senha,
                    DadosUsuario.listaAlunos[i].Item7,
                    DadosUsuario.listaAlunos[i].Item8,
                    DadosUsuario.listaAlunos[i].Item9,
                    DadosUsuario.listaAlunos[i].Item10

                    );
                    Console.WriteLine("Senha Alterada");
                    login.Show();
                    this.Hide();
                    break;
                }
            }
            for (int i = 0; i < DadosUsuario.listaEmpresas.Count; i++)
            {
                var coordenador = DadosUsuario.listaEmpresas;
                if (DadosUsuario.listaEmpresas[i].Item7 == codigo)
                {
                    DadosUsuario.listaEmpresas[i] = (
                    DadosUsuario.listaEmpresas[i].Item1,
                    DadosUsuario.listaEmpresas[i].Item2,
                    DadosUsuario.listaEmpresas[i].Item3,
                    DadosUsuario.listaEmpresas[i].Item4,
                    senha,
                    DadosUsuario.listaEmpresas[i].Item6,
                    DadosUsuario.listaEmpresas[i].Item7,
                    DadosUsuario.listaEmpresas[i].Item8,
                    DadosUsuario.listaEmpresas[i].Item9
                    );
                    Console.WriteLine("Senha Alterada");
                    login.Show();
                    this.Hide();
                    break;
                }
            }           
        }

        private void VerficarEmail(string email)
        {
            for (int i = 0; i < DadosUsuario.listaCoordenador.Count; i++)
            {
                var coordenador = DadosUsuario.listaCoordenador;
                if (DadosUsuario.listaCoordenador[i].Item3 == email)
                {
                    string codigoF = GerarCodigo();

                    DadosUsuario.listaCoordenador[i] = (
                    DadosUsuario.listaCoordenador[i].Item1,
                    DadosUsuario.listaCoordenador[i].Item2,
                    DadosUsuario.listaCoordenador[i].Item3,
                    DadosUsuario.listaCoordenador[i].Item4,
                    DadosUsuario.listaCoordenador[i].Item5,
                    codigoF,
                    DadosUsuario.listaCoordenador[i].Item7
                    );
                    panelEmail.Visible = false;
                    panelCodigo.Visible = true;
                    Console.WriteLine("codigo: "+codigoF);
                    EnviarEmail(codigoF);
                    break;
                }
            }
            for (int i = 0; i < DadosUsuario.listaAlunos.Count; i++)
            {
                var aluno = DadosUsuario.listaAlunos;
                if (DadosUsuario.listaAlunos[i].Item3 == email)
                {
                    string codigoF = GerarCodigo();

                    DadosUsuario.listaAlunos[i] = (
                    DadosUsuario.listaAlunos[i].Item1,
                    DadosUsuario.listaAlunos[i].Item2,
                    DadosUsuario.listaAlunos[i].Item3,
                    DadosUsuario.listaAlunos[i].Item4,
                    DadosUsuario.listaAlunos[i].Item5,
                    DadosUsuario.listaAlunos[i].Item6,                                      
                    DadosUsuario.listaAlunos[i].Item7,
                    codigoF,
                    DadosUsuario.listaAlunos[i].Item9,
                    DadosUsuario.listaAlunos[i].Item10
                    );
                    panelEmail.Visible = false;
                    panelCodigo.Visible = true;
                    Console.WriteLine("codigo: " + codigoF);
                    EnviarEmail(codigoF);
                    break;
                }
            }
            for (int i = 0; i < DadosUsuario.listaEmpresas.Count; i++)
            {
                var coordenador = DadosUsuario.listaEmpresas;
                if (DadosUsuario.listaEmpresas[i].Item3 == email)
                {
                    string codigoF = GerarCodigo();

                    DadosUsuario.listaEmpresas[i] = (
                    DadosUsuario.listaEmpresas[i].Item1,
                    DadosUsuario.listaEmpresas[i].Item2,
                    DadosUsuario.listaEmpresas[i].Item3,
                    DadosUsuario.listaEmpresas[i].Item4,
                    DadosUsuario.listaEmpresas[i].Item5,
                    DadosUsuario.listaEmpresas[i].Item6,
                    codigoF,
                    DadosUsuario.listaEmpresas[i].Item8,
                    DadosUsuario.listaEmpresas[i].Item9
                    );
                    panelEmail.Visible = false;
                    panelCodigo.Visible = true;
                    Console.WriteLine("codigo: " + codigoF);
                    EnviarEmail(codigoF);
                    break;
                }
            }          
        }

        private void VerificarCodigo(string codigo, string email)
        {
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {// ListaCoordenador: (ID, NOME, EMAIL, TELEFONE, SENHA, codigo)
                if (coordenador.Item6 == codigo && coordenador.Item3 == email)
                {
                    panelCodigo.Visible = false;
                    panelNewSenha.Visible = true;                
                }
            }
            foreach (var aluno in DadosUsuario.listaAlunos)
            {// ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação)
                if (aluno.Item8 == codigo && aluno.Item3 == email)
                {
                    panelCodigo.Visible = false;
                    panelNewSenha.Visible = true;
                }
            }
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {// ListaEmpresa: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação)
                if (empresa.Item7 == codigo && empresa.Item3 == email)
                {
                    panelCodigo.Visible = false;
                    panelNewSenha.Visible = true;
                }
            }

        }
        private void EnviarEmail(string codigoF)
        {
            string remetente = "FindTec@outlook.com.br";
            string senha = "senhaforte1";
            string destinatario = EmailRE.Text;
            string assunto = "Codigo de Confirmação para Redefinir Senha";
            //string mensagem = $"O seu codigo é {codigoF}";
            //string mensagem = "";
            string mensagem = $@"<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <title>Código de Verificação</title>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            color: #333;
            padding: 20px;
            margin: 0;
            font-size: 16px;
            line-height: 1.5;
        }}
        .container {{
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 10px rgba(0,0,0,.1);
        }}
        h1 {{
            font-size: 24px;
            margin-top: 0;
        }}
        p {{
            margin-bottom: 10px;
        }}
        .code {{
            display: inline-block;
            background-color: #eee;
            padding: 10px;
            border-radius: 5px;
            font-size: 20px;
            font-weight: bold;
            color: #333;
            margin-bottom: 20px;
        }}
        .btn {{
            display: inline-block;
            background-color: #007bff;
            color: #fff;
            padding: 10px 20px;
            border-radius: 5px;
            text-decoration: none;
            margin-bottom: 20px;
            transition: background-color .2s ease;
        }}
        .btn:hover {{
            background-color: #0069d9;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <h1>Código de Verificação</h1>
        <p>Olá, recebemos uma solicitação para redefinir sua senha. Use o código abaixo para prosseguir:</p>
        <div class='code'>{codigoF}</div>
        <p>Copie o código acima e insira na página de redefinição de senha.</p>
        <p><span style='color: red;'><i>Se você não solicitou essa redefinição, pode ignorar este email.</i></span></p>
        <p>Obrigado,</p>
        <p>Equipe FindTec</p>
    </div>
</body>
</html>";



            SmtpClient cliente = new SmtpClient("smtp.office365.com", 25);
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential(remetente, senha);
            cliente.EnableSsl = true;


            // MailMessage email = new MailMessage(remetente, destinatario, assunto, mensagem);
            //email.IsBodyHtml = true;
            MailMessage email = null;
            try
            {
                email = new MailMessage(remetente, destinatario, assunto, mensagem);
                email.IsBodyHtml = true;
                // Enviar e-mail...
            }
            catch (FormatException)
            {
                panelCodigo.Visible = false;
                panelEmail.Visible = true;
                                          
                MessageBox.Show("E-mail invalido. Por favor, verifique e tente novamente.");
            }

            if (email != null)
            {
                try
                {
                    cliente.Send(email);
                    Console.WriteLine("Email enviado com sucesso!");
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine("Erro ao enviar email: " + ex.Message);
                }
            }
        }
        private string GerarCodigo()
        {
            Random random = new Random();
            StringBuilder codigo = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                // Gera um valor aleatório entre 65 e 90, que correspondem aos caracteres ASCII de A a Z
                int codigoChar = random.Next(65, 91);
                // Adiciona o caractere correspondente ao valor aleatório à string de código
                codigo.Append(Convert.ToChar(codigoChar));
            }
            return codigo.ToString();
        }
        private void RecuperarSenha_Load(object sender, EventArgs e)
        {

        }     
    }
}
