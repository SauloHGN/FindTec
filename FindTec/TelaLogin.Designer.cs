
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FindTec
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.botaoCriarconta = new System.Windows.Forms.LinkLabel();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.botaoErrologin = new System.Windows.Forms.Label();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.botaoEsquecisenha = new System.Windows.Forms.LinkLabel();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoCriesuaconta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoCriarconta
            // 
            this.botaoCriarconta.AccessibleName = "botaoCriarconta";
            this.botaoCriarconta.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.AutoSize = true;
            this.botaoCriarconta.BackColor = System.Drawing.Color.White;
            this.botaoCriarconta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.botaoCriarconta.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.ForeColor = System.Drawing.Color.Transparent;
            this.botaoCriarconta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.botaoCriarconta.LinkColor = System.Drawing.Color.Black;
            this.botaoCriarconta.Location = new System.Drawing.Point(150, 442);
            this.botaoCriarconta.Name = "botaoCriarconta";
            this.botaoCriarconta.Size = new System.Drawing.Size(102, 15);
            this.botaoCriarconta.TabIndex = 4;
            this.botaoCriarconta.TabStop = true;
            this.botaoCriarconta.Text = "CRIE SUA CONTA!";
            this.botaoCriarconta.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoCriarconta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // campoSenha
            // 
            this.campoSenha.AccessibleName = "campoSenha";
            this.campoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.Location = new System.Drawing.Point(106, 323);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(211, 19);
            this.campoSenha.TabIndex = 2;
            this.campoSenha.Tag = "";
            this.campoSenha.Text = "SENHA";
            this.campoSenha.Enter += new System.EventHandler(this.campoSenha_Enter);
            this.campoSenha.Leave += new System.EventHandler(this.campoSenha_Leave);
            // 
            // campoEmail
            // 
            this.campoEmail.AccessibleName = "campoEmail";
            this.campoEmail.BackColor = System.Drawing.SystemColors.Control;
            this.campoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(106, 274);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(211, 19);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.Text = "E-MAIL";
            this.campoEmail.TextChanged += new System.EventHandler(this.campoUsuario_TextChanged);
            this.campoEmail.Enter += new System.EventHandler(this.campoEmail_Enter);
            this.campoEmail.Leave += new System.EventHandler(this.campoEmail_Leave);
            // 
            // botaoErrologin
            // 
            this.botaoErrologin.AccessibleDescription = "";
            this.botaoErrologin.AccessibleName = "botaoErrologin";
            this.botaoErrologin.AutoSize = true;
            this.botaoErrologin.BackColor = System.Drawing.Color.IndianRed;
            this.botaoErrologin.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoErrologin.ForeColor = System.Drawing.Color.White;
            this.botaoErrologin.Location = new System.Drawing.Point(124, 357);
            this.botaoErrologin.Name = "botaoErrologin";
            this.botaoErrologin.Size = new System.Drawing.Size(158, 15);
            this.botaoErrologin.TabIndex = 14;
            this.botaoErrologin.Text = "E-MAIL OU SENHA INCORRETOS";
            this.botaoErrologin.Visible = false;
            this.botaoErrologin.Click += new System.EventHandler(this.botaoErrologin_Click);
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.AccessibleName = "botaoEntrar";
            this.botaoEntrar.BackColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEntrar.BackgroundImage")));
            this.botaoEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botaoEntrar.FlatAppearance.BorderSize = 0;
            this.botaoEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEntrar.ForeColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.Location = new System.Drawing.Point(145, 375);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(113, 49);
            this.botaoEntrar.TabIndex = 3;
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
            this.botaoEntrar.MouseEnter += new System.EventHandler(this.botaoEntrar_MouseEnter);
            this.botaoEntrar.MouseLeave += new System.EventHandler(this.botaoEntrar_MouseLeave);
            // 
            // botaoEsquecisenha
            // 
            this.botaoEsquecisenha.AccessibleName = "botaoEsquecisenha";
            this.botaoEsquecisenha.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.AutoSize = true;
            this.botaoEsquecisenha.BackColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEsquecisenha.ForeColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.LinkArea = new System.Windows.Forms.LinkArea(0, 19);
            this.botaoEsquecisenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.botaoEsquecisenha.LinkColor = System.Drawing.Color.Black;
            this.botaoEsquecisenha.Location = new System.Drawing.Point(146, 467);
            this.botaoEsquecisenha.Name = "botaoEsquecisenha";
            this.botaoEsquecisenha.Size = new System.Drawing.Size(114, 15);
            this.botaoEsquecisenha.TabIndex = 5;
            this.botaoEsquecisenha.TabStop = true;
            this.botaoEsquecisenha.Text = "ESQUECI MINHA SENHA";
            this.botaoEsquecisenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoEsquecisenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recuperarS_LinkClicked);
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
            this.botaoFechar.Location = new System.Drawing.Point(358, 12);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(30, 30);
            this.botaoFechar.TabIndex = 6;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            this.botaoFechar.MouseEnter += new System.EventHandler(this.botaoFechar_MouseEnter);
            this.botaoFechar.MouseLeave += new System.EventHandler(this.botaoFechar_MouseLeave);
            // 
            // botaoCriesuaconta
            // 
            this.botaoCriesuaconta.AccessibleName = "botaoCriarconta";
            this.botaoCriesuaconta.BackColor = System.Drawing.Color.Transparent;
            this.botaoCriesuaconta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCriesuaconta.BackgroundImage")));
            this.botaoCriesuaconta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCriesuaconta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botaoCriesuaconta.FlatAppearance.BorderSize = 0;
            this.botaoCriesuaconta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCriesuaconta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCriesuaconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCriesuaconta.ForeColor = System.Drawing.Color.Transparent;
            this.botaoCriesuaconta.Location = new System.Drawing.Point(127, 423);
            this.botaoCriesuaconta.Name = "botaoCriesuaconta";
            this.botaoCriesuaconta.Size = new System.Drawing.Size(150, 41);
            this.botaoCriesuaconta.TabIndex = 4;
            this.botaoCriesuaconta.UseVisualStyleBackColor = false;
            this.botaoCriesuaconta.Click += new System.EventHandler(this.botaoCriesuaconta_Click);
            this.botaoCriesuaconta.MouseEnter += new System.EventHandler(this.botaoCriesuaconta_MouseEnter);
            this.botaoCriesuaconta.MouseLeave += new System.EventHandler(this.botaoCriesuaconta_MouseLeave);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.botaoCriesuaconta);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.botaoEsquecisenha);
            this.Controls.Add(this.botaoErrologin);
            this.Controls.Add(this.botaoCriarconta);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel botaoCriarconta;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label botaoErrologin;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.TextBox campoEmail;
        private LinkLabel botaoEsquecisenha;
        private Button botaoFechar;
        private Button botaoCriesuaconta;
    }
}