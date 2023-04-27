namespace FindTec
{
    partial class TelaEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEscolha));
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoAluno = new System.Windows.Forms.Button();
            this.botaoEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.botaoFechar.Location = new System.Drawing.Point(619, 1);
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
            this.botaoVoltar.TabIndex = 3;
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoAluno
            // 
            this.botaoAluno.AccessibleName = "botaoAluno";
            this.botaoAluno.BackColor = System.Drawing.Color.Transparent;
            this.botaoAluno.BackgroundImage = global::FindTec.Properties.Resources.botaoAluno1;
            this.botaoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoAluno.CausesValidation = false;
            this.botaoAluno.FlatAppearance.BorderSize = 0;
            this.botaoAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAluno.ForeColor = System.Drawing.Color.Transparent;
            this.botaoAluno.Location = new System.Drawing.Point(56, 142);
            this.botaoAluno.Name = "botaoAluno";
            this.botaoAluno.Size = new System.Drawing.Size(300, 300);
            this.botaoAluno.TabIndex = 1;
            this.botaoAluno.UseVisualStyleBackColor = false;
            this.botaoAluno.Click += new System.EventHandler(this.botaoAluno_Click);
            this.botaoAluno.MouseEnter += new System.EventHandler(this.botaoAluno_MouseEnter);
            this.botaoAluno.MouseLeave += new System.EventHandler(this.botaoAluno_MouseLeave);
            // 
            // botaoEmpresa
            // 
            this.botaoEmpresa.AccessibleName = "botaoEmpresa";
            this.botaoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.botaoEmpresa.BackgroundImage = global::FindTec.Properties.Resources.botaoEmpresa1;
            this.botaoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoEmpresa.FlatAppearance.BorderSize = 0;
            this.botaoEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEmpresa.Location = new System.Drawing.Point(317, 348);
            this.botaoEmpresa.Name = "botaoEmpresa";
            this.botaoEmpresa.Size = new System.Drawing.Size(260, 260);
            this.botaoEmpresa.TabIndex = 2;
            this.botaoEmpresa.UseVisualStyleBackColor = false;
            this.botaoEmpresa.Click += new System.EventHandler(this.botaoEmpresa_Click);
            this.botaoEmpresa.MouseEnter += new System.EventHandler(this.botaoEmpresa_MouseEnter);
            this.botaoEmpresa.MouseLeave += new System.EventHandler(this.botaoEmpresa_MouseLeave);
            // 
            // TelaEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FindTec.Properties.Resources.TelaEscolha;
            this.ClientSize = new System.Drawing.Size(660, 660);
            this.Controls.Add(this.botaoEmpresa);
            this.Controls.Add(this.botaoAluno);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.botaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 660);
            this.MinimumSize = new System.Drawing.Size(660, 660);
            this.Name = "TelaEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEscolha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoAluno;
        private System.Windows.Forms.Button botaoEmpresa;
    }
}