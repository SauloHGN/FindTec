
namespace FindTec
{
    partial class yourMessage
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
            this.labelMensagemYour = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMensagemYour
            // 
            this.labelMensagemYour.AutoSize = true;
            this.labelMensagemYour.BackColor = System.Drawing.Color.DimGray;
            this.labelMensagemYour.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemYour.ForeColor = System.Drawing.Color.White;
            this.labelMensagemYour.Location = new System.Drawing.Point(3, 16);
            this.labelMensagemYour.MaximumSize = new System.Drawing.Size(280, 350);
            this.labelMensagemYour.MinimumSize = new System.Drawing.Size(130, 30);
            this.labelMensagemYour.Name = "labelMensagemYour";
            this.labelMensagemYour.Padding = new System.Windows.Forms.Padding(0, 20, 3, 3);
            this.labelMensagemYour.Size = new System.Drawing.Size(130, 38);
            this.labelMensagemYour.TabIndex = 1;
            this.labelMensagemYour.Text = "a";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.DimGray;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(3, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // yourMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelMensagemYour);
            this.Name = "yourMessage";
            this.Size = new System.Drawing.Size(525, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMensagemYour;
        private System.Windows.Forms.Label labelNome;
    }
}
