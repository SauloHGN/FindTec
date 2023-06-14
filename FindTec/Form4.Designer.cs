
namespace FindTec
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.opA1 = new FindTec.OpA();
            this.opB1 = new FindTec.OpB();
            this.opC1 = new FindTec.OpC();
            this.opD1 = new FindTec.OpD();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textNomeC = new System.Windows.Forms.TextBox();
            this.textEmailC = new System.Windows.Forms.TextBox();
            this.textTelC = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textSenhaC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndisponivel = new System.Windows.Forms.Label();
            this.cadastroCoordenador = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.cadastroCoordenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FindTec.Properties.Resources.menuLateral;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 550);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-3, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Opção B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(-3, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Opção D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Opção C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-3, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Opção A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opA1
            // 
            this.opA1.Location = new System.Drawing.Point(223, 15);
            this.opA1.Name = "opA1";
            this.opA1.Size = new System.Drawing.Size(755, 525);
            this.opA1.TabIndex = 2;
            this.opA1.Load += new System.EventHandler(this.opA1_Load);
            // 
            // opB1
            // 
            this.opB1.Location = new System.Drawing.Point(223, 15);
            this.opB1.Name = "opB1";
            this.opB1.Size = new System.Drawing.Size(755, 525);
            this.opB1.TabIndex = 3;
            // 
            // opC1
            // 
            this.opC1.Location = new System.Drawing.Point(223, 15);
            this.opC1.Name = "opC1";
            this.opC1.Size = new System.Drawing.Size(755, 525);
            this.opC1.TabIndex = 4;
            // 
            // opD1
            // 
            this.opD1.Location = new System.Drawing.Point(223, 15);
            this.opD1.Name = "opD1";
            this.opD1.Size = new System.Drawing.Size(755, 525);
            this.opD1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Senha";
            // 
            // textNomeC
            // 
            this.textNomeC.Location = new System.Drawing.Point(165, 87);
            this.textNomeC.Name = "textNomeC";
            this.textNomeC.Size = new System.Drawing.Size(129, 20);
            this.textNomeC.TabIndex = 12;
            // 
            // textEmailC
            // 
            this.textEmailC.Location = new System.Drawing.Point(165, 125);
            this.textEmailC.Name = "textEmailC";
            this.textEmailC.Size = new System.Drawing.Size(129, 20);
            this.textEmailC.TabIndex = 11;
            // 
            // textTelC
            // 
            this.textTelC.Location = new System.Drawing.Point(165, 163);
            this.textTelC.Name = "textTelC";
            this.textTelC.Size = new System.Drawing.Size(129, 20);
            this.textTelC.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Criar Conta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textSenhaC
            // 
            this.textSenhaC.Location = new System.Drawing.Point(165, 204);
            this.textSenhaC.Name = "textSenhaC";
            this.textSenhaC.PasswordChar = '•';
            this.textSenhaC.Size = new System.Drawing.Size(129, 20);
            this.textSenhaC.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cadastrar Coordenador";
            // 
            // txtIndisponivel
            // 
            this.txtIndisponivel.AutoSize = true;
            this.txtIndisponivel.ForeColor = System.Drawing.Color.Red;
            this.txtIndisponivel.Location = new System.Drawing.Point(110, 241);
            this.txtIndisponivel.Name = "txtIndisponivel";
            this.txtIndisponivel.Size = new System.Drawing.Size(210, 13);
            this.txtIndisponivel.TabIndex = 14;
            this.txtIndisponivel.Text = "Email ou Telefone já estão sendo utilizados";
            this.txtIndisponivel.Visible = false;
            // 
            // cadastroCoordenador
            // 
            this.cadastroCoordenador.Controls.Add(this.txtIndisponivel);
            this.cadastroCoordenador.Controls.Add(this.label2);
            this.cadastroCoordenador.Controls.Add(this.textSenhaC);
            this.cadastroCoordenador.Controls.Add(this.button5);
            this.cadastroCoordenador.Controls.Add(this.textTelC);
            this.cadastroCoordenador.Controls.Add(this.textEmailC);
            this.cadastroCoordenador.Controls.Add(this.textNomeC);
            this.cadastroCoordenador.Controls.Add(this.label8);
            this.cadastroCoordenador.Controls.Add(this.label9);
            this.cadastroCoordenador.Controls.Add(this.label10);
            this.cadastroCoordenador.Controls.Add(this.label11);
            this.cadastroCoordenador.Location = new System.Drawing.Point(223, 15);
            this.cadastroCoordenador.Name = "cadastroCoordenador";
            this.cadastroCoordenador.Size = new System.Drawing.Size(755, 525);
            this.cadastroCoordenador.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FindTec.Properties.Resources.backgroundGeral;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cadastroCoordenador);
            this.Controls.Add(this.opB1);
            this.Controls.Add(this.opA1);
            this.Controls.Add(this.opD1);
            this.Controls.Add(this.opC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cadastroCoordenador.ResumeLayout(false);
            this.cadastroCoordenador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private OpA opA1;
        private OpB opB1;
        private OpC opC1;
        private OpD opD1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNomeC;
        private System.Windows.Forms.TextBox textEmailC;
        private System.Windows.Forms.TextBox textTelC;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textSenhaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtIndisponivel;
        private System.Windows.Forms.Panel cadastroCoordenador;
    }
}