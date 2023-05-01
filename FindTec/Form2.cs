using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnVaga_Click(this, new EventArgs());//INICIAR COM O BOTÃO VAGA SELECIONADO
            button1_Click(this, new EventArgs());// INICIAR COM A "HOMEPAGE" PERFIL
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA DE LOGIN
            LoadMinhasVagas();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
            nomeTxt.Text = user.Item2;
            emailTxt.Text = user.Item3;
            telefoneTxt.Text = user.Item4;

            //
            NomeEmpresaTextBox.Text = user.Item2;

            if (user.Item9 != null && user.Item9.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item9))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;

            panelPerfilE.Visible = true;
            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;

            panelPerfilE.Visible = false;
            panelAnunciarVaga.Visible = true;
            panelAnunciarVaga.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;

            panelPerfilE.Visible = false;
            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;

            panelPerfilE.Visible = false;
            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = false;
        }

        private void panelPerfilE_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void opD1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = openFileDialog.FileName;

                if (File.Exists(nomeArquivo))
                {
                    using (FileStream stream = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read))
                    {
                        byte[] dadosImagem = new byte[stream.Length];
                        stream.Read(dadosImagem, 0, (int)stream.Length);

                        MemoryStream ms = new MemoryStream(dadosImagem);
                        Image imagem = Image.FromStream(ms);

                        pictureBox1.Image = imagem;

                        var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);

                        user.Item9 = dadosImagem;

                        var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);// descobro o indece do usuario
                        if (index != -1)
                        {
                            DadosUsuario.listaEmpresas[index] = user;
                        }
                        Console.WriteLine(""+user.Item9);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            // Cria um label com a mensagem para o usuário
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Digite sua senha:" };
            prompt.Controls.Add(textLabel);

            // Cria um textBox para o usuário inserir o valor
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            prompt.Controls.Add(textBox);

            // Cria o botão "OK" para confirmar a entrada de dados
            Button confirmation = new Button() { Text = "OK", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Cancelar", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);

            // Mostra o formulário para o usuário e aguarda a entrada de dados
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            DialogResult result = prompt.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Form2_Load(this, e);
            }

            // Se o usuário confirmou a entrada de dados, exibe o valor inserido
            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);

                if (user.Item5 == textBox.Text)
                {
                    user.Item2 = nomeTxt.Text;
                    user.Item3 = emailTxt.Text;
                    user.Item4 = telefoneTxt.Text;

                    var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(emailTxt.Text, telefoneTxt.Text, index))
                    {
                        DadosUsuario.listaEmpresas[index] = user;
                        MessageBox.Show("Dados alterados com sucesso");

                        this.Close();
                    }
                    else
                    {
                        Form2_Load(this, e);
                        MessageBox.Show("Os dados já estão em uso");
                    }
                }
                else
                {
                    Form2_Load(this, e);
                    MessageBox.Show("Senha incorreta...");
                }
            }
        }

        public bool VerificaEmailETelefone(string email, string telefone, int indiceAtual)
        {
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item3 == email || aluno.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if ((empresa.Item3 == email || empresa.Item4 == telefone) && DadosUsuario.listaEmpresas.IndexOf(empresa) != indiceAtual)
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
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Você tem certeza que deseja desativar sua conta?" };
            prompt.Controls.Add(textLabel);

            Button confirmation = new Button() { Text = "Sim", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Não", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);
            DialogResult result = prompt.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (confirmarSenha())
                {
                    var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
                    user.Item6 = false;
                    var index = DadosUsuario.listaEmpresas.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1)
                    {
                        DadosUsuario.listaEmpresas[index] = user;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
            else
            {

            }
        }

        public bool confirmarSenha()
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            // Cria um label com a mensagem para o usuário
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Digite sua senha:" };
            prompt.Controls.Add(textLabel);

            // Cria um textBox para o usuário inserir o valor
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            prompt.Controls.Add(textBox);

            // Cria o botão "OK" para confirmar a entrada de dados
            Button confirmation = new Button() { Text = "OK", Left = 160, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);

            // Cria o botão "Cancelar" para cancelar a entrada de dados
            Button cancel = new Button() { Text = "Cancelar", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(cancel);

            // Mostra o formulário para o usuário e aguarda a entrada de dados
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            DialogResult result = prompt.ShowDialog();

            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);
                if (user.Item5 == textBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAnunciarVaga_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomeEmpresaTextBox.Text) ||
                string.IsNullOrEmpty(nomeVagaTextBox.Text) ||
                string.IsNullOrEmpty(CargaHTextBox.Text) ||
                string.IsNullOrEmpty(RemuneracaoTextBox.Text) ||
                string.IsNullOrEmpty(CursoVBox.Text) ||
                string.IsNullOrEmpty(CargoTextBox.Text) ||
                string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }
           
            string nomeEmpresa = NomeEmpresaTextBox.Text;
            string nomeVaga = nomeVagaTextBox.Text;
            int cargaHoraria = int.Parse(CargaHTextBox.Text);
            double remuneracao = double.Parse(RemuneracaoTextBox.Text);
            string cargo = CargoTextBox.Text;
            string curso = CursoVBox.Text;
            string descricao = DescricaoTextBox.Text;
            
            Vaga novaVaga = new Vaga(nomeVaga, nomeEmpresa, cargo, cargaHoraria, remuneracao, curso, descricao);
            Vaga.addVaga(novaVaga);

            nomeVagaTextBox.Clear();
            NomeEmpresaTextBox.Clear();
            CargoTextBox.Clear();
            CargaHTextBox.Clear();
            RemuneracaoTextBox.Clear();
            CursoVBox.SelectedIndex = -1;
            DescricaoTextBox.Clear();

            MessageBox.Show("Vaga criada com sucesso!");
        }

        private void CargaHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RemuneracaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CargaHTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVaga_Click(object sender, EventArgs e)
        {
            
            btnVaga2.BackColor = Color.Black;
            btnVaga2.ForeColor = Color.White;
            btnMinhasVagas2.BackColor = SystemColors.Control;
            btnMinhasVagas2.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = true;
            panelMinhasVagas.Visible = false;
            panelAnunciarVaga.BringToFront();
        }

        private void btnMinhasVagas_Click(object sender, EventArgs e)
        {
            btnMinhasVagas.BackColor = Color.Black;
            btnMinhasVagas.ForeColor = Color.White;
            btnVaga.BackColor = SystemColors.Control;
            btnVaga.ForeColor = Color.Black;
            btnMinhasVagas2.BackColor = Color.Black;
            btnMinhasVagas2.ForeColor = Color.White;
            btnVaga2.BackColor = SystemColors.Control;
            btnVaga2.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = false;
            panelMinhasVagas.Visible = true;
            panelMinhasVagas.BringToFront();
            
            LoadMinhasVagas();
        }

        private void btnCriarVaga2_Click(object sender, EventArgs e)
        {
            btnVaga.BackColor = Color.Black;
            btnVaga.ForeColor = Color.White;
            btnMinhasVagas.BackColor = SystemColors.Control;
            btnMinhasVagas.ForeColor = Color.Black;

            panelAnunciarVaga.Visible = true;
            panelMinhasVagas.Visible = false;
            panelAnunciarVaga.BringToFront();
        }

        private void gridViewMinhasVagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadMinhasVagas()
        {     
            gridViewMinhasVagas.Rows.Clear();
            
            var user = DadosUsuario.listaEmpresas.Find(u => u.Item1 == Program.userAtual);  
            
            foreach(var vagas in Vaga.vagas)
            {
                if(user.Item2 == vagas.NomeEmpresa)
                {
                    gridViewMinhasVagas.Rows.Add(vagas.NomeVaga, vagas.Cargo, vagas.cargaHoraria, vagas.remuneracao, vagas.Curso);
                }
                
            }
            gridViewMinhasVagas.ClearSelection();
        }
    }
}
