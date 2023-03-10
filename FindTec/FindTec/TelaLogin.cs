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
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  ABRIR TELA DE CADASTRO E ESCONDER TELA DE LOGIN
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.FormClosed += Cadastro_FormClosed;
            cadastro.Show();
            this.Hide();
            
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AO FECHAR A TELA DE CADASTRO RETRONAR PARA A TELA DE LOGIN              
            this.Show();
        }     
    }
}
