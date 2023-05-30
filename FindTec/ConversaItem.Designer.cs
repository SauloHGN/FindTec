
namespace FindTec
{
    partial class ConversaItem
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUltimaMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelNome.Location = new System.Drawing.Point(98, 5);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 18);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.MouseEnter += new System.EventHandler(this.labelNome_MouseEnter);
            this.labelNome.MouseLeave += new System.EventHandler(this.labelNome_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::FindTec.Properties.Resources.botaoAluno1;
            this.pictureBox1.Image = global::FindTec.Properties.Resources.botaoAluno1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelUltimaMensagem
            // 
            this.labelUltimaMensagem.AutoSize = true;
            this.labelUltimaMensagem.Location = new System.Drawing.Point(100, 28);
            this.labelUltimaMensagem.Name = "labelUltimaMensagem";
            this.labelUltimaMensagem.Size = new System.Drawing.Size(91, 13);
            this.labelUltimaMensagem.TabIndex = 2;
            this.labelUltimaMensagem.Text = "Ultima Mensagem";
            this.labelUltimaMensagem.MouseEnter += new System.EventHandler(this.labelUltimaMensagem_MouseEnter);
            this.labelUltimaMensagem.MouseLeave += new System.EventHandler(this.labelUltimaMensagem_MouseLeave);
            // 
            // ConversaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelUltimaMensagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNome);
            this.Name = "ConversaItem";
            this.Size = new System.Drawing.Size(350, 50);
            this.MouseEnter += new System.EventHandler(this.ConversaItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ConversaItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUltimaMensagem;
    }
}
