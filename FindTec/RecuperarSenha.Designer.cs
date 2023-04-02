
namespace FindTec
{
    partial class RecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarSenha));
            this.button1 = new System.Windows.Forms.Button();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.EmailRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNewSenha = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNewSenha = new System.Windows.Forms.TextBox();
            this.panelCodigo.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelNewSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(this.panel3);
            this.panelCodigo.Controls.Add(this.button3);
            this.panelCodigo.Controls.Add(this.textCodigo);
            this.panelCodigo.Controls.Add(this.label2);
            this.panelCodigo.Location = new System.Drawing.Point(121, 153);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(336, 109);
            this.panelCodigo.TabIndex = 15;
            this.panelCodigo.Visible = false;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(119, 42);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.button2);
            this.panelEmail.Controls.Add(this.EmailRE);
            this.panelEmail.Controls.Add(this.label1);
            this.panelEmail.Location = new System.Drawing.Point(121, 47);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(336, 100);
            this.panelEmail.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Recuperar Senha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // EmailRE
            // 
            this.EmailRE.Location = new System.Drawing.Point(99, 14);
            this.EmailRE.Name = "EmailRE";
            this.EmailRE.Size = new System.Drawing.Size(173, 20);
            this.EmailRE.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite seu Email";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 100);
            this.panel3.TabIndex = 17;
            // 
            // panelNewSenha
            // 
            this.panelNewSenha.Controls.Add(this.textNewSenha);
            this.panelNewSenha.Controls.Add(this.label3);
            this.panelNewSenha.Controls.Add(this.button4);
            this.panelNewSenha.Location = new System.Drawing.Point(121, 268);
            this.panelNewSenha.Name = "panelNewSenha";
            this.panelNewSenha.Size = new System.Drawing.Size(336, 81);
            this.panelNewSenha.TabIndex = 17;
            this.panelNewSenha.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Redefinir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nova Senha";
            // 
            // textNewSenha
            // 
            this.textNewSenha.Location = new System.Drawing.Point(110, 18);
            this.textNewSenha.Name = "textNewSenha";
            this.textNewSenha.Size = new System.Drawing.Size(123, 20);
            this.textNewSenha.TabIndex = 2;
            // 
            // RecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelNewSenha);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelCodigo);
            this.Controls.Add(this.button1);
            this.Name = "RecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RecuperarSenha_Load);
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelNewSenha.ResumeLayout(false);
            this.panelNewSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCodigo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EmailRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewSenha;
        private System.Windows.Forms.TextBox textNewSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}