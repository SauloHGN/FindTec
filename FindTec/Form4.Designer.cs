
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoSair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textNomeC = new System.Windows.Forms.TextBox();
            this.textEmailC = new System.Windows.Forms.TextBox();
            this.textTelC = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textSenhaC = new System.Windows.Forms.TextBox();
            this.txtIndisponivel = new System.Windows.Forms.Label();
            this.cadastroCoordenador = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cadastroCoordenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FindTec.Properties.Resources.menuLateralAdministrador;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.botaoSair);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 550);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FindTec.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // botaoSair
            // 
            this.botaoSair.BackgroundImage = global::FindTec.Properties.Resources.botaoSair_1;
            this.botaoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoSair.FlatAppearance.BorderSize = 0;
            this.botaoSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botaoSair.ForeColor = System.Drawing.Color.Black;
            this.botaoSair.Location = new System.Drawing.Point(1, 495);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(197, 51);
            this.botaoSair.TabIndex = 15;
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            this.botaoSair.MouseEnter += new System.EventHandler(this.botaoSair_MouseEnter);
            this.botaoSair.MouseLeave += new System.EventHandler(this.botaoSair_MouseLeave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-2, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cadastrar Coordenador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textNomeC
            // 
            this.textNomeC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeC.Location = new System.Drawing.Point(309, 195);
            this.textNomeC.Name = "textNomeC";
            this.textNomeC.Size = new System.Drawing.Size(180, 19);
            this.textNomeC.TabIndex = 12;
            this.textNomeC.Text = "NOME COMPLETO";
            this.textNomeC.TextChanged += new System.EventHandler(this.textNomeC_TextChanged);
            this.textNomeC.Enter += new System.EventHandler(this.textNome_Enter);
            this.textNomeC.Leave += new System.EventHandler(this.textNome_Leave);
            // 
            // textEmailC
            // 
            this.textEmailC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailC.Location = new System.Drawing.Point(309, 246);
            this.textEmailC.Name = "textEmailC";
            this.textEmailC.Size = new System.Drawing.Size(180, 19);
            this.textEmailC.TabIndex = 11;
            this.textEmailC.Text = "E-MAIL";
            this.textEmailC.TextChanged += new System.EventHandler(this.textEmailC_TextChanged);
            this.textEmailC.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmailC.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textTelC
            // 
            this.textTelC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelC.Location = new System.Drawing.Point(309, 297);
            this.textTelC.Name = "textTelC";
            this.textTelC.Size = new System.Drawing.Size(180, 19);
            this.textTelC.TabIndex = 10;
            this.textTelC.Text = "TELEFONE";
            this.textTelC.TextChanged += new System.EventHandler(this.textTelC_TextChanged);
            this.textTelC.Enter += new System.EventHandler(this.textTelefone_Enter);
            this.textTelC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelC_KeyPress);
            this.textTelC.Leave += new System.EventHandler(this.textTelefone_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::FindTec.Properties.Resources.botaoCriarconta1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(324, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 52);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // textSenhaC
            // 
            this.textSenhaC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenhaC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaC.Location = new System.Drawing.Point(309, 348);
            this.textSenhaC.Name = "textSenhaC";
            this.textSenhaC.Size = new System.Drawing.Size(180, 19);
            this.textSenhaC.TabIndex = 8;
            this.textSenhaC.Text = "SENHA";
            this.textSenhaC.Enter += new System.EventHandler(this.textSenha_Enter);
            this.textSenhaC.Leave += new System.EventHandler(this.textSenha_Leave);
            // 
            // txtIndisponivel
            // 
            this.txtIndisponivel.AutoSize = true;
            this.txtIndisponivel.ForeColor = System.Drawing.Color.Red;
            this.txtIndisponivel.Location = new System.Drawing.Point(306, 381);
            this.txtIndisponivel.Name = "txtIndisponivel";
            this.txtIndisponivel.Size = new System.Drawing.Size(210, 13);
            this.txtIndisponivel.TabIndex = 14;
            this.txtIndisponivel.Text = "Email ou Telefone já estão sendo utilizados";
            this.txtIndisponivel.Visible = false;
            // 
            // cadastroCoordenador
            // 
            this.cadastroCoordenador.BackgroundImage = global::FindTec.Properties.Resources.telaCadastrarCoordenadror;
            this.cadastroCoordenador.Controls.Add(this.txtIndisponivel);
            this.cadastroCoordenador.Controls.Add(this.textSenhaC);
            this.cadastroCoordenador.Controls.Add(this.button5);
            this.cadastroCoordenador.Controls.Add(this.textTelC);
            this.cadastroCoordenador.Controls.Add(this.textEmailC);
            this.cadastroCoordenador.Controls.Add(this.textNomeC);
            this.cadastroCoordenador.Location = new System.Drawing.Point(221, 13);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cadastroCoordenador.ResumeLayout(false);
            this.cadastroCoordenador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textNomeC;
        private System.Windows.Forms.TextBox textEmailC;
        private System.Windows.Forms.TextBox textTelC;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textSenhaC;
        private System.Windows.Forms.Label txtIndisponivel;
        private System.Windows.Forms.Panel cadastroCoordenador;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}