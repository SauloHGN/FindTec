
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
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.avisoErrologin = new System.Windows.Forms.Label();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoCriesuaconta = new System.Windows.Forms.Button();
            this.botaoEsquecisenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoSenha
            // 
            this.campoSenha.AccessibleName = "campoSenha";
            this.campoSenha.BackColor = System.Drawing.Color.White;
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
            this.campoEmail.BackColor = System.Drawing.Color.White;
            this.campoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(106, 274);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(211, 19);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.Text = "E-MAIL";
            this.campoEmail.Enter += new System.EventHandler(this.campoEmail_Enter);
            this.campoEmail.Leave += new System.EventHandler(this.campoEmail_Leave);
            // 
            // avisoErrologin
            // 
            this.avisoErrologin.AccessibleDescription = "";
            this.avisoErrologin.AccessibleName = "avisoErrologin";
            this.avisoErrologin.AutoSize = true;
            this.avisoErrologin.BackColor = System.Drawing.Color.IndianRed;
            this.avisoErrologin.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoErrologin.ForeColor = System.Drawing.Color.White;
            this.avisoErrologin.Location = new System.Drawing.Point(124, 357);
            this.avisoErrologin.Name = "avisoErrologin";
            this.avisoErrologin.Size = new System.Drawing.Size(158, 15);
            this.avisoErrologin.TabIndex = 15;
            this.avisoErrologin.Text = "E-MAIL OU SENHA INCORRETOS";
            this.avisoErrologin.Visible = false;
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.AccessibleName = "botaoEntrar";
            this.botaoEntrar.BackColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.BackgroundImage = global::FindTec.Properties.Resources.botaoEntrar2;
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
            this.botaoFechar.Location = new System.Drawing.Point(359, 1);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(40, 40);
            this.botaoFechar.TabIndex = 0;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // botaoCriesuaconta
            // 
            this.botaoCriesuaconta.AccessibleName = "botaoCriesuaconta";
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
            // botaoEsquecisenha
            // 
            this.botaoEsquecisenha.AccessibleName = "botaoEsquecisenha";
            this.botaoEsquecisenha.BackColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEsquecisenha.FlatAppearance.BorderSize = 0;
            this.botaoEsquecisenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.botaoEsquecisenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEsquecisenha.ForeColor = System.Drawing.Color.Transparent;
            this.botaoEsquecisenha.Location = new System.Drawing.Point(122, 460);
            this.botaoEsquecisenha.Name = "botaoEsquecisenha";
            this.botaoEsquecisenha.Size = new System.Drawing.Size(162, 23);
            this.botaoEsquecisenha.TabIndex = 5;
            this.botaoEsquecisenha.Text = "ESQUECI MINHA SENHA";
            this.botaoEsquecisenha.UseVisualStyleBackColor = false;
            this.botaoEsquecisenha.Click += new System.EventHandler(this.botaoEsquecisenha_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.botaoEsquecisenha);
            this.Controls.Add(this.botaoCriesuaconta);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.avisoErrologin);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label avisoErrologin;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.TextBox campoEmail;
        private Button botaoFechar;
        private Button botaoCriesuaconta;
        private Button botaoEsquecisenha;
    }
}