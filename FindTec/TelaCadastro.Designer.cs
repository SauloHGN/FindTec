
namespace FindTec
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.cadastroAluno = new System.Windows.Forms.Panel();
            this.opCurso = new System.Windows.Forms.ComboBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCadastroAluno = new System.Windows.Forms.Button();
            this.buttonCadastroEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastroEmpresa = new System.Windows.Forms.Panel();
            this.textSenhaE = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textTelE = new System.Windows.Forms.TextBox();
            this.textEmailE = new System.Windows.Forms.TextBox();
            this.textNomeE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIndisponivel = new System.Windows.Forms.Label();
            this.cadastroAluno.SuspendLayout();
            this.cadastroEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroAluno
            // 
            this.cadastroAluno.Controls.Add(this.opCurso);
            this.cadastroAluno.Controls.Add(this.textSenha);
            this.cadastroAluno.Controls.Add(this.button3);
            this.cadastroAluno.Controls.Add(this.textTelefone);
            this.cadastroAluno.Controls.Add(this.textEmail);
            this.cadastroAluno.Controls.Add(this.label6);
            this.cadastroAluno.Controls.Add(this.textNome);
            this.cadastroAluno.Controls.Add(this.label5);
            this.cadastroAluno.Controls.Add(this.label4);
            this.cadastroAluno.Controls.Add(this.label3);
            this.cadastroAluno.Controls.Add(this.label2);
            this.cadastroAluno.Location = new System.Drawing.Point(80, 109);
            this.cadastroAluno.Name = "cadastroAluno";
            this.cadastroAluno.Size = new System.Drawing.Size(425, 240);
            this.cadastroAluno.TabIndex = 0;
            this.cadastroAluno.Visible = false;
            // 
            // opCurso
            // 
            this.opCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opCurso.FormattingEnabled = true;
            this.opCurso.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Gestão Empresarial",
            "Gestão de Produção",
            "Eventos"});
            this.opCurso.Location = new System.Drawing.Point(148, 134);
            this.opCurso.Name = "opCurso";
            this.opCurso.Size = new System.Drawing.Size(198, 21);
            this.opCurso.TabIndex = 2;
            this.opCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(148, 169);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '•';
            this.textSenha.Size = new System.Drawing.Size(150, 20);
            this.textSenha.TabIndex = 1;
            this.textSenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Criar Conta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(148, 96);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(150, 20);
            this.textTelefone.TabIndex = 1;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(148, 58);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(150, 20);
            this.textEmail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Curso";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNome
            // 
            this.textNome.AccessibleName = "";
            this.textNome.Location = new System.Drawing.Point(148, 20);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(150, 20);
            this.textNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // buttonCadastroAluno
            // 
            this.buttonCadastroAluno.AccessibleName = "buttonAluno";
            this.buttonCadastroAluno.Location = new System.Drawing.Point(199, 80);
            this.buttonCadastroAluno.Name = "buttonCadastroAluno";
            this.buttonCadastroAluno.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastroAluno.TabIndex = 1;
            this.buttonCadastroAluno.Text = "Aluno";
            this.buttonCadastroAluno.UseVisualStyleBackColor = true;
            this.buttonCadastroAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCadastroEmpresa
            // 
            this.buttonCadastroEmpresa.Location = new System.Drawing.Point(287, 80);
            this.buttonCadastroEmpresa.Name = "buttonCadastroEmpresa";
            this.buttonCadastroEmpresa.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastroEmpresa.TabIndex = 1;
            this.buttonCadastroEmpresa.Text = "Empresa";
            this.buttonCadastroEmpresa.UseVisualStyleBackColor = true;
            this.buttonCadastroEmpresa.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faça seu Cadastro";
            // 
            // cadastroEmpresa
            // 
            this.cadastroEmpresa.Controls.Add(this.textSenhaE);
            this.cadastroEmpresa.Controls.Add(this.button4);
            this.cadastroEmpresa.Controls.Add(this.textTelE);
            this.cadastroEmpresa.Controls.Add(this.textEmailE);
            this.cadastroEmpresa.Controls.Add(this.textNomeE);
            this.cadastroEmpresa.Controls.Add(this.label8);
            this.cadastroEmpresa.Controls.Add(this.label9);
            this.cadastroEmpresa.Controls.Add(this.label10);
            this.cadastroEmpresa.Controls.Add(this.label11);
            this.cadastroEmpresa.Location = new System.Drawing.Point(80, 109);
            this.cadastroEmpresa.Name = "cadastroEmpresa";
            this.cadastroEmpresa.Size = new System.Drawing.Size(425, 240);
            this.cadastroEmpresa.TabIndex = 3;
            this.cadastroEmpresa.Visible = false;
            this.cadastroEmpresa.Paint += new System.Windows.Forms.PaintEventHandler(this.cadastroEmpresa_Paint);
            // 
            // textSenhaE
            // 
            this.textSenhaE.Location = new System.Drawing.Point(153, 137);
            this.textSenhaE.Name = "textSenhaE";
            this.textSenhaE.PasswordChar = '•';
            this.textSenhaE.Size = new System.Drawing.Size(129, 20);
            this.textSenhaE.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Criar Conta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textTelE
            // 
            this.textTelE.Location = new System.Drawing.Point(153, 96);
            this.textTelE.Name = "textTelE";
            this.textTelE.Size = new System.Drawing.Size(129, 20);
            this.textTelE.TabIndex = 10;
            // 
            // textEmailE
            // 
            this.textEmailE.Location = new System.Drawing.Point(153, 58);
            this.textEmailE.Name = "textEmailE";
            this.textEmailE.Size = new System.Drawing.Size(129, 20);
            this.textEmailE.TabIndex = 11;
            // 
            // textNomeE
            // 
            this.textNomeE.Location = new System.Drawing.Point(153, 20);
            this.textNomeE.Name = "textNomeE";
            this.textNomeE.Size = new System.Drawing.Size(129, 20);
            this.textNomeE.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Senha";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nome";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(48, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtIndisponivel
            // 
            this.txtIndisponivel.AutoSize = true;
            this.txtIndisponivel.ForeColor = System.Drawing.Color.Red;
            this.txtIndisponivel.Location = new System.Drawing.Point(184, 64);
            this.txtIndisponivel.Name = "txtIndisponivel";
            this.txtIndisponivel.Size = new System.Drawing.Size(210, 13);
            this.txtIndisponivel.TabIndex = 5;
            this.txtIndisponivel.Text = "Email ou Telefone já estão sendo utilizados";
            this.txtIndisponivel.Visible = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtIndisponivel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadastroEmpresa);
            this.Controls.Add(this.buttonCadastroAluno);
            this.Controls.Add(this.cadastroAluno);
            this.Controls.Add(this.cadastroEmpresa);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.cadastroAluno.ResumeLayout(false);
            this.cadastroAluno.PerformLayout();
            this.cadastroEmpresa.ResumeLayout(false);
            this.cadastroEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cadastroAluno;
        private System.Windows.Forms.Button buttonCadastroAluno;
        private System.Windows.Forms.Button buttonCadastroEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.ComboBox opCurso;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel cadastroEmpresa;
        private System.Windows.Forms.TextBox textSenhaE;
        private System.Windows.Forms.TextBox textTelE;
        private System.Windows.Forms.TextBox textEmailE;
        private System.Windows.Forms.TextBox textNomeE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtIndisponivel;
    }
}