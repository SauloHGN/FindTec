using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTec
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            button1_Click(this, new EventArgs());
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
    }
}
