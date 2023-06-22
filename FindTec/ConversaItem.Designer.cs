
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
            this.labelMensagemNaoLida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(72, 5);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 18);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelUltimaMensagem
            // 
            this.labelUltimaMensagem.AutoSize = true;
            this.labelUltimaMensagem.BackColor = System.Drawing.Color.Transparent;
            this.labelUltimaMensagem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.labelUltimaMensagem.Location = new System.Drawing.Point(71, 21);
            this.labelUltimaMensagem.MaximumSize = new System.Drawing.Size(218, 52);
            this.labelUltimaMensagem.Name = "labelUltimaMensagem";
            this.labelUltimaMensagem.Size = new System.Drawing.Size(116, 20);
            this.labelUltimaMensagem.TabIndex = 2;
            this.labelUltimaMensagem.Text = "Ultima Mensagem";
            // 
            // labelMensagemNaoLida
            // 
            this.labelMensagemNaoLida.AutoSize = true;
            this.labelMensagemNaoLida.BackColor = System.Drawing.Color.Red;
            this.labelMensagemNaoLida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemNaoLida.ForeColor = System.Drawing.Color.White;
            this.labelMensagemNaoLida.Location = new System.Drawing.Point(292, 5);
            this.labelMensagemNaoLida.MinimumSize = new System.Drawing.Size(15, 15);
            this.labelMensagemNaoLida.Name = "labelMensagemNaoLida";
            this.labelMensagemNaoLida.Size = new System.Drawing.Size(15, 15);
            this.labelMensagemNaoLida.TabIndex = 3;
            this.labelMensagemNaoLida.Text = "0";
            this.labelMensagemNaoLida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConversaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FindTec.Properties.Resources.fundoMensagemRecebida1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.labelUltimaMensagem);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMensagemNaoLida);
            this.DoubleBuffered = true;
            this.Name = "ConversaItem";
            this.Size = new System.Drawing.Size(334, 66);
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
        private System.Windows.Forms.Label labelMensagemNaoLida;
    }
}
