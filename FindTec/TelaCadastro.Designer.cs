
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
            this.textNomeE = new System.Windows.Forms.TextBox();
            this.textEmailE = new System.Windows.Forms.TextBox();
            this.textTelE = new System.Windows.Forms.TextBox();
            this.botaoCriarconta = new System.Windows.Forms.Button();
            this.textSenhaE = new System.Windows.Forms.TextBox();
            this.txtIndisponivel = new System.Windows.Forms.Label();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.cadastroEmpresa = new System.Windows.Forms.Panel();
            this.cadastroAluno = new System.Windows.Forms.Panel();
            this.txtIndisponivelA = new System.Windows.Forms.Label();
            this.botaoCriarcontaa = new System.Windows.Forms.Button();
            this.botaoVoltarA = new System.Windows.Forms.Button();
            this.botaoFecharA = new System.Windows.Forms.Button();
            this.opCurso = new System.Windows.Forms.ComboBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.cadastroEmpresa.SuspendLayout();
            this.cadastroAluno.SuspendLayout();
            this.SuspendLayout();
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
            this.textNomeE.Enter += new System.EventHandler(this.textNomeE_Enter);
            this.textNomeE.Leave += new System.EventHandler(this.textNomeE_Leave);
            // 
            // textEmailE
            // 
            this.textEmailE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textEmailE.Location = new System.Drawing.Point(232, 327);
            this.textEmailE.Name = "textEmailE";
            this.textEmailE.Size = new System.Drawing.Size(208, 19);
            this.textEmailE.TabIndex = 2;
            this.textEmailE.Text = "E-MAIL";
            this.textEmailE.Enter += new System.EventHandler(this.textEmailE_Enter);
            this.textEmailE.Leave += new System.EventHandler(this.textEmailE_Leave);
            // 
            // textTelE
            // 
            this.textTelE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textTelE.Location = new System.Drawing.Point(232, 379);
            this.textTelE.Name = "textTelE";
            this.textTelE.Size = new System.Drawing.Size(209, 19);
            this.textTelE.TabIndex = 3;
            this.textTelE.Text = "TELEFONE";
            this.textTelE.TextChanged += new System.EventHandler(this.textTelE_TextChanged);
            this.textTelE.Enter += new System.EventHandler(this.textTelE_Enter);
            this.textTelE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelE_KeyPress);
            this.textTelE.Leave += new System.EventHandler(this.textTelE_Leave);
            // 
            // botaoCriarconta
            // 
            this.botaoCriarconta.AccessibleName = "botaoCriarconta";
            this.botaoCriarconta.BackColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.BackgroundImage = global::FindTec.Properties.Resources.botaoCriarconta1;
            this.botaoCriarconta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCriarconta.CausesValidation = false;
            this.botaoCriarconta.FlatAppearance.BorderSize = 0;
            this.botaoCriarconta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCriarconta.ForeColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.Location = new System.Drawing.Point(249, 470);
            this.botaoCriarconta.Name = "botaoCriarconta";
            this.botaoCriarconta.Size = new System.Drawing.Size(161, 60);
            this.botaoCriarconta.TabIndex = 5;
            this.botaoCriarconta.UseVisualStyleBackColor = false;
            this.botaoCriarconta.Click += new System.EventHandler(this.botaoCriarconta_Click);
            this.botaoCriarconta.MouseEnter += new System.EventHandler(this.botaoCriarconta_MouseEnter);
            this.botaoCriarconta.MouseLeave += new System.EventHandler(this.botaoCriarconta_MouseLeave);
            // 
            // textSenhaE
            // 
            this.textSenhaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenhaE.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textSenhaE.Location = new System.Drawing.Point(232, 430);
            this.textSenhaE.Name = "textSenhaE";
            this.textSenhaE.Size = new System.Drawing.Size(209, 19);
            this.textSenhaE.TabIndex = 4;
            this.textSenhaE.Text = "SENHA";
            this.textSenhaE.Enter += new System.EventHandler(this.textSenhaE_Enter);
            this.textSenhaE.Leave += new System.EventHandler(this.textSenhaE_Leave);
            // 
            // txtIndisponivel
            // 
            this.txtIndisponivel.AutoSize = true;
            this.txtIndisponivel.BackColor = System.Drawing.Color.IndianRed;
            this.txtIndisponivel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIndisponivel.ForeColor = System.Drawing.Color.White;
            this.txtIndisponivel.Location = new System.Drawing.Point(204, 533);
            this.txtIndisponivel.Name = "txtIndisponivel";
            this.txtIndisponivel.Size = new System.Drawing.Size(251, 15);
            this.txtIndisponivel.TabIndex = 20;
            this.txtIndisponivel.Text = "EMAIL OU TELEFONE JÁ ESTÃO SENDO UTILIZADOS";
            this.txtIndisponivel.Visible = false;
            // 
            // botaoFechar
            // 
            this.botaoFechar.AccessibleName = "botaoFechar";
            this.botaoFechar.BackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.ForeColor = System.Drawing.Color.Transparent;
            this.botaoFechar.Image = ((System.Drawing.Image)(resources.GetObject("botaoFechar.Image")));
            this.botaoFechar.Location = new System.Drawing.Point(620, 2);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(40, 40);
            this.botaoFechar.TabIndex = 0;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.AccessibleName = "botaoVoltar";
            this.botaoVoltar.BackColor = System.Drawing.Color.Transparent;
            this.botaoVoltar.FlatAppearance.BorderSize = 0;
            this.botaoVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltar.Image = global::FindTec.Properties.Resources.botaoVoltar;
            this.botaoVoltar.Location = new System.Drawing.Point(1, 1);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(40, 40);
            this.botaoVoltar.TabIndex = 6;
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // cadastroEmpresa
            // 
            this.cadastroEmpresa.BackgroundImage = global::FindTec.Properties.Resources.CadastroEmpresa;
            this.cadastroEmpresa.Controls.Add(this.botaoVoltar);
            this.cadastroEmpresa.Controls.Add(this.botaoFechar);
            this.cadastroEmpresa.Controls.Add(this.txtIndisponivel);
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
            // cadastroAluno
            // 
            this.cadastroAluno.BackgroundImage = global::FindTec.Properties.Resources.CadastroAluno;
            this.cadastroAluno.Controls.Add(this.txtIndisponivelA);
            this.cadastroAluno.Controls.Add(this.botaoCriarcontaa);
            this.cadastroAluno.Controls.Add(this.botaoVoltarA);
            this.cadastroAluno.Controls.Add(this.botaoFecharA);
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
            this.cadastroAluno.TabIndex = 7;
            this.cadastroAluno.Visible = false;
            // 
            // txtIndisponivelA
            // 
            this.txtIndisponivelA.AutoSize = true;
            this.txtIndisponivelA.BackColor = System.Drawing.Color.IndianRed;
            this.txtIndisponivelA.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIndisponivelA.ForeColor = System.Drawing.Color.White;
            this.txtIndisponivelA.Location = new System.Drawing.Point(204, 556);
            this.txtIndisponivelA.Name = "txtIndisponivelA";
            this.txtIndisponivelA.Size = new System.Drawing.Size(251, 15);
            this.txtIndisponivelA.TabIndex = 21;
            this.txtIndisponivelA.Text = "EMAIL OU TELEFONE JÁ ESTÃO SENDO UTILIZADOS";
            this.txtIndisponivelA.Visible = false;
            // 
            // botaoCriarcontaa
            // 
            this.botaoCriarcontaa.AccessibleName = "botaoCriarconta";
            this.botaoCriarcontaa.BackColor = System.Drawing.Color.Transparent;
            this.botaoCriarcontaa.BackgroundImage = global::FindTec.Properties.Resources.botaoCriarconta1;
            this.botaoCriarcontaa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCriarcontaa.CausesValidation = false;
            this.botaoCriarcontaa.FlatAppearance.BorderSize = 0;
            this.botaoCriarcontaa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCriarcontaa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCriarcontaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCriarcontaa.ForeColor = System.Drawing.Color.Transparent;
            this.botaoCriarcontaa.Location = new System.Drawing.Point(249, 508);
            this.botaoCriarcontaa.Name = "botaoCriarcontaa";
            this.botaoCriarcontaa.Size = new System.Drawing.Size(161, 60);
            this.botaoCriarcontaa.TabIndex = 6;
            this.botaoCriarcontaa.UseVisualStyleBackColor = false;
            this.botaoCriarcontaa.Click += new System.EventHandler(this.botaoCriarcontaa_Click);
            this.botaoCriarcontaa.Enter += new System.EventHandler(this.botaoCriarcontaA_MouseEnter);
            this.botaoCriarcontaa.MouseEnter += new System.EventHandler(this.botaoCriarcontaA_MouseEnter);
            this.botaoCriarcontaa.MouseLeave += new System.EventHandler(this.botaoCriarcontaA_MouseLeave);
            // 
            // botaoVoltarA
            // 
            this.botaoVoltarA.AccessibleName = "botaoVoltar";
            this.botaoVoltarA.BackColor = System.Drawing.Color.Transparent;
            this.botaoVoltarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoVoltarA.FlatAppearance.BorderSize = 0;
            this.botaoVoltarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botaoVoltarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltarA.ForeColor = System.Drawing.Color.Transparent;
            this.botaoVoltarA.Image = global::FindTec.Properties.Resources.botaoVoltar;
            this.botaoVoltarA.Location = new System.Drawing.Point(1, 1);
            this.botaoVoltarA.Name = "botaoVoltarA";
            this.botaoVoltarA.Size = new System.Drawing.Size(40, 40);
            this.botaoVoltarA.TabIndex = 7;
            this.botaoVoltarA.UseVisualStyleBackColor = false;
            this.botaoVoltarA.Click += new System.EventHandler(this.botaoVoltarA_Click);
            // 
            // botaoFecharA
            // 
            this.botaoFecharA.AccessibleName = "botaoFechar";
            this.botaoFecharA.BackColor = System.Drawing.Color.Transparent;
            this.botaoFecharA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFecharA.FlatAppearance.BorderSize = 0;
            this.botaoFecharA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoFecharA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFecharA.ForeColor = System.Drawing.Color.Transparent;
            this.botaoFecharA.Image = ((System.Drawing.Image)(resources.GetObject("botaoFecharA.Image")));
            this.botaoFecharA.Location = new System.Drawing.Point(620, 2);
            this.botaoFecharA.Name = "botaoFecharA";
            this.botaoFecharA.Size = new System.Drawing.Size(40, 40);
            this.botaoFecharA.TabIndex = 0;
            this.botaoFecharA.UseVisualStyleBackColor = false;
            this.botaoFecharA.Click += new System.EventHandler(this.botaoFecharA_Click);
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
            this.opCurso.TabIndex = 4;
            this.opCurso.Enter += new System.EventHandler(this.opCurso_Enter);
            this.opCurso.Leave += new System.EventHandler(this.opCurso_Leave);
            // 
            // textSenha
            // 
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textSenha.Location = new System.Drawing.Point(233, 480);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(211, 19);
            this.textSenha.TabIndex = 5;
            this.textSenha.Text = "SENHA";
            this.textSenha.Enter += new System.EventHandler(this.textSenha_Enter);
            this.textSenha.Leave += new System.EventHandler(this.textSenha_Leave);
            // 
            // textTelefone
            // 
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textTelefone.Location = new System.Drawing.Point(233, 378);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(211, 19);
            this.textTelefone.TabIndex = 3;
            this.textTelefone.Text = "TELEFONE";
            this.textTelefone.TextChanged += new System.EventHandler(this.textTelefone_TextChanged);
            this.textTelefone.Enter += new System.EventHandler(this.textTelefone_Enter);
            this.textTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefone_KeyPress);
            this.textTelefone.Leave += new System.EventHandler(this.textTelefone_Leave);
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
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
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
            this.textNome.Enter += new System.EventHandler(this.textNome_Enter);
            this.textNome.Leave += new System.EventHandler(this.textNome_Leave);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 660);
            this.Controls.Add(this.cadastroAluno);
            this.Controls.Add(this.cadastroEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
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

        }

        #endregion

        public System.Windows.Forms.TextBox textNomeE;
        public System.Windows.Forms.TextBox textEmailE;
        public System.Windows.Forms.TextBox textTelE;
        public System.Windows.Forms.Button botaoCriarconta;
        public System.Windows.Forms.TextBox textSenhaE;
        private System.Windows.Forms.Label txtIndisponivel;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button botaoVoltar;
        public System.Windows.Forms.Panel cadastroEmpresa;
        public System.Windows.Forms.Panel cadastroAluno;
        public System.Windows.Forms.Button botaoCriarcontaa;
        private System.Windows.Forms.Button botaoVoltarA;
        private System.Windows.Forms.Button botaoFecharA;
        private System.Windows.Forms.ComboBox opCurso;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label txtIndisponivelA;
    }
}