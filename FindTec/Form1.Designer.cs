﻿
namespace FindTec
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cursoTxt = new System.Windows.Forms.TextBox();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opA1 = new FindTec.OpA();
            this.opB1 = new FindTec.OpB();
            this.opD1 = new FindTec.OpD();
            this.opC1 = new FindTec.OpC();
            this.panel1.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonD);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 511);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aluno";
            // 
            // buttonD
            // 
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(-2, 296);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(197, 34);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "Opção D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(-2, 256);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(197, 34);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "Opção C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonB
            // 
            this.buttonB.FlatAppearance.BorderSize = 0;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(0, 216);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(197, 34);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "Opção B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonA
            // 
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(0, 176);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(197, 34);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "Opção A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panelPerfil
            // 
            this.panelPerfil.Controls.Add(this.buttonUpload);
            this.panelPerfil.Controls.Add(this.label6);
            this.panelPerfil.Controls.Add(this.button2);
            this.panelPerfil.Controls.Add(this.button1);
            this.panelPerfil.Controls.Add(this.label5);
            this.panelPerfil.Controls.Add(this.label4);
            this.panelPerfil.Controls.Add(this.label3);
            this.panelPerfil.Controls.Add(this.label2);
            this.panelPerfil.Controls.Add(this.cursoTxt);
            this.panelPerfil.Controls.Add(this.telefoneTxt);
            this.panelPerfil.Controls.Add(this.emailTxt);
            this.panelPerfil.Controls.Add(this.nomeTxt);
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Location = new System.Drawing.Point(201, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(686, 511);
            this.panelPerfil.TabIndex = 5;
            this.panelPerfil.Visible = false;
            this.panelPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPerfil_Paint);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(428, 140);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 12;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Perfil";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Desativar Conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // cursoTxt
            // 
            this.cursoTxt.Location = new System.Drawing.Point(224, 385);
            this.cursoTxt.Multiline = true;
            this.cursoTxt.Name = "cursoTxt";
            this.cursoTxt.ReadOnly = true;
            this.cursoTxt.Size = new System.Drawing.Size(234, 24);
            this.cursoTxt.TabIndex = 4;
            this.cursoTxt.TabStop = false;
            this.cursoTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Location = new System.Drawing.Point(224, 330);
            this.telefoneTxt.Multiline = true;
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(234, 24);
            this.telefoneTxt.TabIndex = 3;
            this.telefoneTxt.TabStop = false;
            this.telefoneTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(224, 280);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(234, 24);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.TabStop = false;
            this.emailTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(224, 229);
            this.nomeTxt.Multiline = true;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(234, 24);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.TabStop = false;
            this.nomeTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // opA1
            // 
            this.opA1.AccessibleName = "";
            this.opA1.AutoSize = true;
            this.opA1.BackColor = System.Drawing.Color.White;
            this.opA1.Location = new System.Drawing.Point(201, 0);
            this.opA1.Name = "opA1";
            this.opA1.Size = new System.Drawing.Size(680, 511);
            this.opA1.TabIndex = 1;
            this.opA1.Load += new System.EventHandler(this.opA2_Load);
            // 
            // opB1
            // 
            this.opB1.BackColor = System.Drawing.Color.White;
            this.opB1.Location = new System.Drawing.Point(201, 0);
            this.opB1.Name = "opB1";
            this.opB1.Size = new System.Drawing.Size(680, 511);
            this.opB1.TabIndex = 2;
            this.opB1.Visible = false;
            // 
            // opD1
            // 
            this.opD1.BackColor = System.Drawing.Color.White;
            this.opD1.Location = new System.Drawing.Point(201, 0);
            this.opD1.Name = "opD1";
            this.opD1.Size = new System.Drawing.Size(680, 511);
            this.opD1.TabIndex = 4;
            this.opD1.Visible = false;
            this.opD1.Load += new System.EventHandler(this.opD1_Load);
            // 
            // opC1
            // 
            this.opC1.BackColor = System.Drawing.Color.White;
            this.opC1.Location = new System.Drawing.Point(201, 0);
            this.opC1.Name = "opC1";
            this.opC1.Size = new System.Drawing.Size(680, 511);
            this.opC1.TabIndex = 3;
            this.opC1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelPerfil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.opA1);
            this.Controls.Add(this.opB1);
            this.Controls.Add(this.opD1);
            this.Controls.Add(this.opC1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OpA opA1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private OpB opB1;
        private OpC opC1;
        private OpD opD1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cursoTxt;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpload;
    }
}

