using System;
using System.Drawing;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;

            panelCadastroAprov.Visible = true;
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;

            panelCadastroAprov.Visible = false;         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;

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
                    Console.WriteLine("aluno verif1");
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
    }
}
