using System;
using System.Windows.Forms;

namespace FindTec
{
    public partial class Form3 : Form
    {    
        public Form3()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);// FECHAR FRAME PRINCIPAL VOLTAR PARA A TELA
            
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // AO FECHAR O FRAME PRINCIPLA VOLTAR PARA TELA DE LOGIN
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opA1.Visible = true;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = false;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = true;
            opC1.Visible = false;
            opD1.Visible = false;        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = true;
            opD1.Visible = false;          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opA1.Visible = false;
            opB1.Visible = false;
            opC1.Visible = false;
            opD1.Visible = true;       
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColumnAprov"].Index && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {                 
                    var aluno = DadosUsuario.listaAlunos[e.RowIndex];// obtem o objeto selecionado

                    var alunoModificado = aluno;          
                    alunoModificado.Item9 = true;// definir o valor de Item9 como true na cópia
                
                    DadosUsuario.listaAlunos[e.RowIndex] = alunoModificado;// definir o objeto modificado na lista

                    foreach (var alunos in DadosUsuario.listaAlunos)
                    {
                        Console.WriteLine("Nome: " + alunos.Item2 + ", Aprovado: " + alunos.Item9);
                    }
                    
                    dataGridView1.Rows.RemoveAt(e.RowIndex);// remover a linha do DataGridView                                   

                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        dataGridView1.Refresh();// Atualiza a lista
                    }                   
                    else
                    {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColumnRecusar"].Index && e.RowIndex < DadosUsuario.listaAlunos.Count)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    DadosUsuario.listaAlunos.Remove(DadosUsuario.listaAlunos[e.RowIndex]);

                    if (DadosUsuario.listaAlunos.Count > 1)
                    {
                        dataGridView1.Refresh();// Atualiza a lista
                    }                   
                    else
                    {
                        dataGridView1.Rows.Clear();
                        LoadDataGridView();
                    }                   
                }
            }
        }
    }
}
