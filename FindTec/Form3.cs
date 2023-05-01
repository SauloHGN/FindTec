using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form3 : Form
    {        
        public Form3()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA
            buttonListAluno_Click_1(this, new EventArgs());//INICIAR COM O BOTÃO ALUNO SELECIONADO
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            foreach (var alunos in DadosUsuario.listaAlunos)
            {
                Console.WriteLine("Nome: " + alunos.Item2 + ", Aprovado: " + alunos.Item9);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var user = DadosUsuario.listaCoordenador.Find(u => u.Item1 == Program.userAtual);
            nomeTxt.Text = user.Item2;
            emailTxt.Text = user.Item3;
            telefoneTxt.Text = user.Item4;
            
            

            if (user.Item7 != null && user.Item7.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Item7))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }

            LoadDataGridView();
            LoadDataViewGridE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opA1.Visible = true;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;

            panelCadastroAprov.Visible = false;
            panelPerfilC.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;

            panelCadastroAprov.Visible = true;
            panelPerfilC.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;
            panelPerfilC.Visible = false;
            panelCadastroAprov.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;
            panelPerfilC.Visible = false;
            panelCadastroAprov.Visible = false;
        }    

        private void LoadDataGridView()
        {          
            dataGridView1.AutoGenerateColumns = false;
            
            foreach (var aluno in DadosUsuario.listaAlunos)
            {
                if (aluno.Item9 == false)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = aluno.Item2;//NOME
                    row.Cells[1].Value = "Aluno";//TIPO
                    row.Cells[2].Value = aluno.Item3;//EMAIL
                    row.Cells[3].Value = aluno.Item4;//TELEFONE

                    DataGridViewButtonCell button1 = new DataGridViewButtonCell();
                    button1.Value = "Aprovar";
                    row.Cells[4] = button1;// BOTÃO APROVAR

                    DataGridViewButtonCell button2 = new DataGridViewButtonCell();
                    button2.Value = "Reprovar";
                    row.Cells[5] = button2; //BOTÃO RECUSAR

                    dataGridView1.Rows.Add(row);// ADICONA TODAS AS COLUNAS AO DATAGRIDVIEW
                }
            }         
            dataGridView1.ClearSelection();          
        }

        private void LoadDataViewGridE()
        {
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item8 == false)
                {
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridViewE);
                    row1.Cells[0].Value = empresa.Item2;//NOME
                    row1.Cells[1].Value = "Empresa";//TIPO
                    row1.Cells[2].Value = empresa.Item3;//EMAIL
                    row1.Cells[3].Value = empresa.Item4;//TELEFONE

                    DataGridViewButtonCell buttonE1 = new DataGridViewButtonCell();
                    buttonE1.Value = "Aprovar";
                    row1.Cells[4] = buttonE1;// BOTÃO APROVAR

                    DataGridViewButtonCell buttonE2 = new DataGridViewButtonCell();
                    buttonE2.Value = "Reprovar";
                    row1.Cells[5] = buttonE2; //BOTÃO RECUSAR

                    dataGridViewE.Rows.Add(row1);// ADICONA TODAS AS COLUNAS AO DATAGRIDVIEW
                }
            }
            dataGridViewE.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var type = row.Cells[1].Value.ToString();


                if (e.ColumnIndex == dataGridView1.Columns["ColumnAprov"].Index && type == "Aluno" && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {                 
                    var aluno = DadosUsuario.listaAlunos[e.RowIndex];// obtem o objeto selecionado
                                                 
                    var alunoModificado = aluno; // copiar cada propriedade do objeto original
                    alunoModificado.Item1 = aluno.Item1;
                    alunoModificado.Item2 = aluno.Item2;
                    alunoModificado.Item3 = aluno.Item3;
                    alunoModificado.Item4 = aluno.Item4;
                    alunoModificado.Item5 = aluno.Item5;
                    alunoModificado.Item6 = aluno.Item6;
                    alunoModificado.Item7 = aluno.Item7;
                    alunoModificado.Item8 = aluno.Item8;
                    alunoModificado.Item9 = true;

                    // definir o objeto modificado na lista
                    DadosUsuario.listaAlunos.Add(alunoModificado);
                    DadosUsuario.listaAlunos.Remove(aluno);
                    Console.WriteLine("" + aluno);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);// remover a linha do DataGridView                                   
                   
                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        // Atualiza a lista                       
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                    }
                        return;
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColumnRecusar"].Index && type == "Aluno" && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {
                    Console.WriteLine("aluno verif2");
                    var aluno = DadosUsuario.listaAlunos[e.RowIndex];
                    DadosUsuario.listaAlunos.Remove(aluno);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    Console.WriteLine("" + aluno);
                        
                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        // Atualiza a lista
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();
                    }
                   else
                   {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                   }
                   
                    return;
                }                           
            }          
        }

        private void dataGridViewE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row1 = dataGridViewE.Rows[e.RowIndex];
                var type = row1.Cells[1].Value.ToString();

                if (e.ColumnIndex == dataGridViewE.Columns["ColumnAprovE"].Index && type == "Empresa" && e.RowIndex < DadosUsuario.listaEmpresas.Count)
                {

                    Console.WriteLine("empresa verif1");
                    var empresa = DadosUsuario.listaEmpresas[dataGridViewE.CurrentRow.Index];// obtem o objeto selecionado

                    var empresaModificada = empresa; // copiar cada propriedade do objeto original
                    empresaModificada.Item1 = empresa.Item1;
                    empresaModificada.Item2 = empresa.Item2;
                    empresaModificada.Item3 = empresa.Item3;
                    empresaModificada.Item4 = empresa.Item4;
                    empresaModificada.Item5 = empresa.Item5;
                    empresaModificada.Item6 = empresa.Item6;
                    empresaModificada.Item7 = empresa.Item7;
                    empresaModificada.Item8 = true;

                    // definir o objeto modificado na lista
                    DadosUsuario.listaEmpresas.Add(empresaModificada);
                    DadosUsuario.listaEmpresas.Remove(empresa);
                    Console.WriteLine("" + empresa);
                    dataGridViewE.Rows.RemoveAt(dataGridViewE.CurrentRow.Index);// remover a linha do DataGridView                                   

                    if (DadosUsuario.listaEmpresas.Count > 1)
                    {
                        // Atualiza a lista                       
                        dataGridViewE.Refresh();
                        dataGridViewE.ClearSelection();
                    }
                    else
                    {
                        dataGridViewE.Rows.Clear();
                        LoadDataGridView();
                    }
                    return;
                }
                else if (e.ColumnIndex == dataGridViewE.Columns["ColumnRecusarE"].Index && type == "Empresa" && e.RowIndex < DadosUsuario.listaEmpresas.Count)
                {

                    Console.WriteLine("empresa verif2");
                    var empresa = DadosUsuario.listaEmpresas[dataGridViewE.CurrentRow.Index];
                    DadosUsuario.listaEmpresas.Remove(empresa);
                    dataGridViewE.Rows.RemoveAt(dataGridViewE.CurrentRow.Index);
                    Console.WriteLine("" + empresa);

                    if (DadosUsuario.listaEmpresas.Count > 1)
                    {
                        // Atualiza a lista
                        dataGridViewE.Refresh();
                        dataGridViewE.ClearSelection();
                    }
                    else
                    {
                        dataGridViewE.Rows.Clear();
                        LoadDataGridView();
                    }
                    return;
                }
            }
        }


        private void buttonListEmpresa_Click(object sender, EventArgs e)
        {
            buttonListEmpresa.BackColor = Color.Black;
            buttonListEmpresa.ForeColor = Color.White;
            buttonListAluno5.BackColor = SystemColors.Control;
            buttonListAluno5.ForeColor = Color.Black;
            dataGridViewE.Visible = true;
            dataGridView1.Visible = false;
        }

        private void buttonListAluno_Click_1(object sender, EventArgs e)
        {
            buttonListAluno5.BackColor = Color.Black;
            buttonListAluno5.ForeColor = Color.White;
            buttonListEmpresa.BackColor = SystemColors.Control;
            buttonListEmpresa.ForeColor = Color.Black;
            dataGridView1.Visible = true;
            dataGridViewE.Visible = false;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
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

                        var user = DadosUsuario.listaCoordenador.Find(u => u.Item1 == Program.userAtual);

                        user.Item7 = dadosImagem;

                        var index = DadosUsuario.listaCoordenador.FindIndex(u => u.Item1 == Program.userAtual);// descobro o indece do usuario
                        if (index != -1)
                        {
                            DadosUsuario.listaCoordenador[index] = user;
                        }                    
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
                Form3_Load(this, e);
            }

            // Se o usuário confirmou a entrada de dados, exibe o valor inserido
            if (result == DialogResult.OK)
            {
                var user = DadosUsuario.listaCoordenador.Find(u => u.Item1 == Program.userAtual);

                if(user.Item5 == textBox.Text)
                {
                    user.Item2 = nomeTxt.Text;
                    user.Item3 = emailTxt.Text;
                    user.Item4 = telefoneTxt.Text;

                    var index = DadosUsuario.listaCoordenador.FindIndex(u => u.Item1 == Program.userAtual);
                    if (index != -1 && VerificaEmailETelefone(emailTxt.Text, telefoneTxt.Text, index))
                    {
                        DadosUsuario.listaCoordenador[index] = user;
                        MessageBox.Show("Dados alterados com sucesso");

                        this.Close();
                    }
                    else
                    {
                        Form3_Load(this, e);
                        MessageBox.Show("Os dados já estão em uso");
                    }
                }
                else
                {
                    Form3_Load(this, e);
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
                if (empresa.Item3 == email || empresa.Item4 == telefone)
                {
                    return false;
                }
            }
            foreach (var coordenador in DadosUsuario.listaCoordenador)
            {
                if ((coordenador.Item3 == email || coordenador.Item4 == telefone) && DadosUsuario.listaCoordenador.IndexOf(coordenador) != indiceAtual)
                {
                    return false;
                }
            }          
            return true;
        }

        private void CursoVBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
