
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
            this.txtIndisponivel = new System.Windows.Forms.Label();
            this.cadastroEmpresa = new System.Windows.Forms.Panel();
            this.textSenhaE = new System.Windows.Forms.TextBox();
            this.botaoCriarconta = new System.Windows.Forms.Button();
            this.textTelE = new System.Windows.Forms.TextBox();
            this.textEmailE = new System.Windows.Forms.TextBox();
            this.textNomeE = new System.Windows.Forms.TextBox();
            this.cadastroAluno = new System.Windows.Forms.Panel();
            this.opCurso = new System.Windows.Forms.ComboBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.cadastroEmpresa.SuspendLayout();
            this.cadastroAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIndisponivel
            // 
            this.txtIndisponivel.AutoSize = true;
            this.txtIndisponivel.ForeColor = System.Drawing.Color.Red;
            this.txtIndisponivel.Location = new System.Drawing.Point(230, 564);
            this.txtIndisponivel.Name = "txtIndisponivel";
            this.txtIndisponivel.Size = new System.Drawing.Size(210, 13);
            this.txtIndisponivel.TabIndex = 5;
            this.txtIndisponivel.Text = "Email ou Telefone já estão sendo utilizados";
            this.txtIndisponivel.Visible = false;
            // 
            // cadastroEmpresa
            // 
            this.cadastroEmpresa.BackgroundImage = global::FindTec.Properties.Resources.CadastroEmpresa;
            this.cadastroEmpresa.Controls.Add(this.textSenhaE);
            this.cadastroEmpresa.Controls.Add(this.botaoCriarconta);
            this.cadastroEmpresa.Controls.Add(this.textTelE);
            this.cadastroEmpresa.Controls.Add(this.textEmailE);
            this.cadastroEmpresa.Controls.Add(this.textNomeE);
            this.cadastroEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroEmpresa.Location = new System.Drawing.Point(0, 0);
            this.cadastroEmpresa.Name = "cadastroEmpresa";
            this.cadastroEmpresa.Size = new System.Drawing.Size(660, 660);
            this.cadastroEmpresa.TabIndex = 0;
            this.cadastroEmpresa.Visible = false;
            // 
            // textSenhaE
            // 
            this.textSenhaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenhaE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textSenhaE.Location = new System.Drawing.Point(232, 430);
            this.textSenhaE.Name = "textSenhaE";
            this.textSenhaE.Size = new System.Drawing.Size(209, 19);
            this.textSenhaE.TabIndex = 5;
            this.textSenhaE.Text = "SENHA";
            this.textSenhaE.TextChanged += new System.EventHandler(this.textSenhaE_TextChanged);
            this.textSenhaE.Enter += new System.EventHandler(this.textSenhaE_Enter);
            this.textSenhaE.Leave += new System.EventHandler(this.textSenhaE_Leave);
            // 
            // botaoCriarconta
            // 
            this.botaoCriarconta.AccessibleName = "botaoCriarconta";
            this.botaoCriarconta.Location = new System.Drawing.Point(289, 524);
            this.botaoCriarconta.Name = "botaoCriarconta";
            this.botaoCriarconta.Size = new System.Drawing.Size(75, 23);
            this.botaoCriarconta.TabIndex = 14;
            this.botaoCriarconta.Text = "Criar Conta";
            this.botaoCriarconta.UseVisualStyleBackColor = true;
            this.botaoCriarconta.Click += new System.EventHandler(this.botaoCriarconta_Click);
            // 
            // textTelE
            // 
            this.textTelE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textTelE.Location = new System.Drawing.Point(232, 379);
            this.textTelE.Name = "textTelE";
            this.textTelE.Size = new System.Drawing.Size(209, 19);
            this.textTelE.TabIndex = 2;
            this.textTelE.Text = "TELEFONE";
            // 
            // textEmailE
            // 
            this.textEmailE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textEmailE.Location = new System.Drawing.Point(232, 327);
            this.textEmailE.Name = "textEmailE";
            this.textEmailE.Size = new System.Drawing.Size(208, 19);
            this.textEmailE.TabIndex = 1;
            this.textEmailE.Text = "E-MAIL";
            // 
            // textNomeE
            // 
            this.textNomeE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textNomeE.Location = new System.Drawing.Point(232, 276);
            this.textNomeE.Name = "textNomeE";
            this.textNomeE.Size = new System.Drawing.Size(208, 19);
            this.textNomeE.TabIndex = 1;
            this.textNomeE.Text = "NOME COMPLETO";
            // 
            // cadastroAluno
            // 
            this.cadastroAluno.BackgroundImage = global::FindTec.Properties.Resources.CadastroAluno;
            this.cadastroAluno.Controls.Add(this.opCurso);
            this.cadastroAluno.Controls.Add(this.textSenha);
            this.cadastroAluno.Controls.Add(this.textTelefone);
            this.cadastroAluno.Controls.Add(this.textEmail);
            this.cadastroAluno.Controls.Add(this.textNome);
            this.cadastroAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroAluno.Location = new System.Drawing.Point(0, 0);
            this.cadastroAluno.MaximumSize = new System.Drawing.Size(660, 660);
            this.cadastroAluno.MinimumSize = new System.Drawing.Size(660, 660);
            this.cadastroAluno.Name = "cadastroAluno";
            this.cadastroAluno.Size = new System.Drawing.Size(660, 660);
            this.cadastroAluno.TabIndex = 6;
            this.cadastroAluno.Visible = false;
            // 
            // opCurso
            // 
            this.opCurso.AccessibleName = "opCurso";
            this.opCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opCurso.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.opCurso.ForeColor = System.Drawing.Color.Black;
            this.opCurso.FormattingEnabled = true;
            this.opCurso.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Gestão Empresarial",
            "Gestão de Produção",
            "Eventos"});
            this.opCurso.Location = new System.Drawing.Point(233, 427);
            this.opCurso.Name = "opCurso";
            this.opCurso.Size = new System.Drawing.Size(211, 24);
            this.opCurso.TabIndex = 2;
            // 
            // textSenha
            // 
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textSenha.Location = new System.Drawing.Point(233, 480);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '•';
            this.textSenha.Size = new System.Drawing.Size(211, 19);
            this.textSenha.TabIndex = 5;
            this.textSenha.Text = "SENHA";
            // 
            // textTelefone
            // 
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textTelefone.Location = new System.Drawing.Point(233, 378);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(211, 19);
            this.textTelefone.TabIndex = 1;
            this.textTelefone.Text = "TELEFONE";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textEmail.Location = new System.Drawing.Point(233, 327);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(211, 19);
            this.textEmail.TabIndex = 2;
            this.textEmail.Text = "E-MAIL";
            // 
            // textNome
            // 
            this.textNome.AccessibleName = "";
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textNome.Location = new System.Drawing.Point(233, 276);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(211, 19);
            this.textNome.TabIndex = 1;
            this.textNome.Text = "NOME COMPLETO";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 660);
            this.Controls.Add(this.txtIndisponivel);
            this.Controls.Add(this.cadastroEmpresa);
            this.Controls.Add(this.cadastroAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(660, 660);
            this.MinimumSize = new System.Drawing.Size(660, 660);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.cadastroEmpresa.ResumeLayout(false);
            this.cadastroEmpresa.PerformLayout();
            this.cadastroAluno.ResumeLayout(false);
            this.cadastroAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtIndisponivel;
        public System.Windows.Forms.Panel cadastroEmpresa;
        public System.Windows.Forms.TextBox textSenhaE;
        public System.Windows.Forms.Button botaoCriarconta;
        public System.Windows.Forms.TextBox textTelE;
        public System.Windows.Forms.TextBox textEmailE;
        public System.Windows.Forms.TextBox textNomeE;
        public System.Windows.Forms.Panel cadastroAluno;
        private System.Windows.Forms.ComboBox opCurso;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
    }
}