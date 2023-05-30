
namespace FindTec
{
    partial class myMessage
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
            this.labelMensagemMy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNome.Location = new System.Drawing.Point(5, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelMensagemMy
            // 
            this.labelMensagemMy.AutoSize = true;
            this.labelMensagemMy.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelMensagemMy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemMy.ForeColor = System.Drawing.Color.White;
            this.labelMensagemMy.Location = new System.Drawing.Point(2, 20);
            this.labelMensagemMy.MaximumSize = new System.Drawing.Size(280, 350);
            this.labelMensagemMy.MinimumSize = new System.Drawing.Size(130, 30);
            this.labelMensagemMy.Name = "labelMensagemMy";
            this.labelMensagemMy.Padding = new System.Windows.Forms.Padding(0, 20, 3, 3);
            this.labelMensagemMy.Size = new System.Drawing.Size(130, 38);
            this.labelMensagemMy.TabIndex = 2;
            this.labelMensagemMy.Text = "a";
            this.labelMensagemMy.Paint += new System.Windows.Forms.PaintEventHandler(this.labelMensagemMy_Paint);
            // 
            // myMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelMensagemMy);
            this.MinimumSize = new System.Drawing.Size(0, 10);
            this.Name = "myMessage";
            this.Size = new System.Drawing.Size(600, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelMensagemMy;
    }
}
