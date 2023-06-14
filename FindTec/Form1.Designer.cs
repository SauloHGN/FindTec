
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoMensagens = new System.Windows.Forms.Button();
            this.botaoOportunidades = new System.Windows.Forms.Button();
            this.botaoPerfil = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.botaoAlterarSenha = new System.Windows.Forms.Button();
            this.botaoAlterarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoDesativarConta = new System.Windows.Forms.Button();
            this.botaoEditarDados = new System.Windows.Forms.Button();
            this.cursoTxt = new System.Windows.Forms.TextBox();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOportunidades = new System.Windows.Forms.Panel();
            this.labelOportunidades = new System.Windows.Forms.Label();
            this.gridViewOportunidades = new System.Windows.Forms.DataGridView();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVagaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remuneracaoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCandidatar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelVagaInfo = new System.Windows.Forms.Panel();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtRemuneracao = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtEmpresaContratante = new System.Windows.Forms.TextBox();
            this.txtTituloVaga = new System.Windows.Forms.TextBox();
            this.botaoCandidatar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRemuneracao = new System.Windows.Forms.Label();
            this.labelDescricaoVaga = new System.Windows.Forms.Label();
            this.labelNomeVaga = new System.Windows.Forms.Label();
            this.labelVagaInfo = new System.Windows.Forms.Label();
            this.panelConversas = new System.Windows.Forms.Panel();
            this.FlowPanelConversas = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewConversas = new System.Windows.Forms.ListView();
            this.panelMensagens = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMensagens = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOportunidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOportunidades)).BeginInit();
            this.panelVagaInfo.SuspendLayout();
            this.panelConversas.SuspendLayout();
            this.panelMensagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FindTec.Properties.Resources.menuLateral;
            this.panel1.Controls.Add(this.botaoHome);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.botaoSair);
            this.panel1.Controls.Add(this.botaoMensagens);
            this.panel1.Controls.Add(this.botaoOportunidades);
            this.panel1.Controls.Add(this.botaoPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // botaoHome
            // 
            this.botaoHome.BackgroundImage = global::FindTec.Properties.Resources.botaoHome_1;
            this.botaoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoHome.FlatAppearance.BorderSize = 0;
            this.botaoHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botaoHome.ForeColor = System.Drawing.Color.Black;
            this.botaoHome.Location = new System.Drawing.Point(3, 217);
            this.botaoHome.Name = "botaoHome";
            this.botaoHome.Size = new System.Drawing.Size(197, 56);
            this.botaoHome.TabIndex = 14;
            this.botaoHome.UseVisualStyleBackColor = true;
            this.botaoHome.MouseEnter += new System.EventHandler(this.botaoHome_MouseEnter);
            this.botaoHome.MouseLeave += new System.EventHandler(this.botaoHome_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FindTec.Properties.Resources.imagemAluno;
            this.pictureBox2.Location = new System.Drawing.Point(59, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 115);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
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
            this.botaoSair.TabIndex = 3;
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.buttonD_Click);
            this.botaoSair.MouseEnter += new System.EventHandler(this.buttonD_MouseEnter);
            this.botaoSair.MouseLeave += new System.EventHandler(this.buttonD_MouseLeave);
            // 
            // botaoMensagens
            // 
            this.botaoMensagens.BackgroundImage = global::FindTec.Properties.Resources.botaoMensagens_1;
            this.botaoMensagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoMensagens.FlatAppearance.BorderSize = 0;
            this.botaoMensagens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoMensagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botaoMensagens.ForeColor = System.Drawing.Color.Black;
            this.botaoMensagens.Location = new System.Drawing.Point(3, 392);
            this.botaoMensagens.Name = "botaoMensagens";
            this.botaoMensagens.Size = new System.Drawing.Size(197, 56);
            this.botaoMensagens.TabIndex = 2;
            this.botaoMensagens.UseVisualStyleBackColor = true;
            this.botaoMensagens.Click += new System.EventHandler(this.button3_Click);
            this.botaoMensagens.MouseEnter += new System.EventHandler(this.buttonC_MouseEnter);
            this.botaoMensagens.MouseLeave += new System.EventHandler(this.buttonC_MouseLeave);
            // 
            // botaoOportunidades
            // 
            this.botaoOportunidades.BackgroundImage = global::FindTec.Properties.Resources.botaoOportunidades_1;
            this.botaoOportunidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoOportunidades.FlatAppearance.BorderSize = 0;
            this.botaoOportunidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoOportunidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoOportunidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botaoOportunidades.ForeColor = System.Drawing.Color.Black;
            this.botaoOportunidades.Location = new System.Drawing.Point(3, 332);
            this.botaoOportunidades.Name = "botaoOportunidades";
            this.botaoOportunidades.Size = new System.Drawing.Size(197, 56);
            this.botaoOportunidades.TabIndex = 1;
            this.botaoOportunidades.UseVisualStyleBackColor = true;
            this.botaoOportunidades.Click += new System.EventHandler(this.button2_Click_1);
            this.botaoOportunidades.MouseEnter += new System.EventHandler(this.buttonB_MouseEnter);
            this.botaoOportunidades.MouseLeave += new System.EventHandler(this.buttonB_MouseLeave);
            // 
            // botaoPerfil
            // 
            this.botaoPerfil.BackgroundImage = global::FindTec.Properties.Resources.botaoPerfil_1;
            this.botaoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoPerfil.FlatAppearance.BorderSize = 0;
            this.botaoPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botaoPerfil.ForeColor = System.Drawing.Color.Black;
            this.botaoPerfil.Location = new System.Drawing.Point(3, 275);
            this.botaoPerfil.Name = "botaoPerfil";
            this.botaoPerfil.Size = new System.Drawing.Size(197, 56);
            this.botaoPerfil.TabIndex = 0;
            this.botaoPerfil.UseVisualStyleBackColor = true;
            this.botaoPerfil.Click += new System.EventHandler(this.button1_Click_2);
            this.botaoPerfil.MouseEnter += new System.EventHandler(this.buttonA_MouseEnter);
            this.botaoPerfil.MouseLeave += new System.EventHandler(this.buttonA_MouseLeave);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.Transparent;
            this.panelPerfil.BackgroundImage = global::FindTec.Properties.Resources.telaPerfil;
            this.panelPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPerfil.Controls.Add(this.botaoAlterarSenha);
            this.panelPerfil.Controls.Add(this.botaoAlterarFoto);
            this.panelPerfil.Controls.Add(this.label1);
            this.panelPerfil.Controls.Add(this.botaoDesativarConta);
            this.panelPerfil.Controls.Add(this.botaoEditarDados);
            this.panelPerfil.Controls.Add(this.cursoTxt);
            this.panelPerfil.Controls.Add(this.telefoneTxt);
            this.panelPerfil.Controls.Add(this.emailTxt);
            this.panelPerfil.Controls.Add(this.nomeTxt);
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Location = new System.Drawing.Point(223, 15);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(755, 525);
            this.panelPerfil.TabIndex = 5;
            this.panelPerfil.Visible = false;
            this.panelPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPerfil_Paint);
            // 
            // botaoAlterarSenha
            // 
            this.botaoAlterarSenha.BackgroundImage = global::FindTec.Properties.Resources.botaoAlterarSenha_1;
            this.botaoAlterarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoAlterarSenha.FlatAppearance.BorderSize = 0;
            this.botaoAlterarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAlterarSenha.Location = new System.Drawing.Point(554, 253);
            this.botaoAlterarSenha.Name = "botaoAlterarSenha";
            this.botaoAlterarSenha.Size = new System.Drawing.Size(158, 62);
            this.botaoAlterarSenha.TabIndex = 14;
            this.botaoAlterarSenha.UseVisualStyleBackColor = true;
            this.botaoAlterarSenha.MouseEnter += new System.EventHandler(this.botaoAlterarSenha_MouseEnter);
            this.botaoAlterarSenha.MouseLeave += new System.EventHandler(this.botaoAlterarSenha_MouseLeave);
            // 
            // botaoAlterarFoto
            // 
            this.botaoAlterarFoto.BackgroundImage = global::FindTec.Properties.Resources.BotaoAlterarImagem_1;
            this.botaoAlterarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoAlterarFoto.FlatAppearance.BorderSize = 0;
            this.botaoAlterarFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoAlterarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoAlterarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAlterarFoto.Location = new System.Drawing.Point(182, 128);
            this.botaoAlterarFoto.Name = "botaoAlterarFoto";
            this.botaoAlterarFoto.Size = new System.Drawing.Size(121, 35);
            this.botaoAlterarFoto.TabIndex = 12;
            this.botaoAlterarFoto.UseVisualStyleBackColor = true;
            this.botaoAlterarFoto.Click += new System.EventHandler(this.button3_Click_1);
            this.botaoAlterarFoto.MouseEnter += new System.EventHandler(this.buttonUpload_MouseEnter);
            this.botaoAlterarFoto.MouseLeave += new System.EventHandler(this.buttonUpload_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(188, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 108);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // botaoDesativarConta
            // 
            this.botaoDesativarConta.BackgroundImage = global::FindTec.Properties.Resources.botaoDesativarConta_1;
            this.botaoDesativarConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoDesativarConta.FlatAppearance.BorderSize = 0;
            this.botaoDesativarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoDesativarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoDesativarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDesativarConta.Location = new System.Drawing.Point(548, 374);
            this.botaoDesativarConta.Name = "botaoDesativarConta";
            this.botaoDesativarConta.Size = new System.Drawing.Size(167, 51);
            this.botaoDesativarConta.TabIndex = 10;
            this.botaoDesativarConta.UseVisualStyleBackColor = true;
            this.botaoDesativarConta.Click += new System.EventHandler(this.button2_Click);
            this.botaoDesativarConta.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.botaoDesativarConta.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // botaoEditarDados
            // 
            this.botaoEditarDados.BackgroundImage = global::FindTec.Properties.Resources.botaoEditarDados_1;
            this.botaoEditarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoEditarDados.FlatAppearance.BorderSize = 0;
            this.botaoEditarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoEditarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoEditarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditarDados.Location = new System.Drawing.Point(554, 311);
            this.botaoEditarDados.Name = "botaoEditarDados";
            this.botaoEditarDados.Size = new System.Drawing.Size(158, 62);
            this.botaoEditarDados.TabIndex = 9;
            this.botaoEditarDados.UseVisualStyleBackColor = true;
            this.botaoEditarDados.Click += new System.EventHandler(this.button1_Click);
            this.botaoEditarDados.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.botaoEditarDados.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // cursoTxt
            // 
            this.cursoTxt.BackColor = System.Drawing.Color.White;
            this.cursoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cursoTxt.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cursoTxt.Location = new System.Drawing.Point(73, 466);
            this.cursoTxt.Multiline = true;
            this.cursoTxt.Name = "cursoTxt";
            this.cursoTxt.ReadOnly = true;
            this.cursoTxt.Size = new System.Drawing.Size(350, 24);
            this.cursoTxt.TabIndex = 4;
            this.cursoTxt.TabStop = false;
            this.cursoTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefoneTxt.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.telefoneTxt.Location = new System.Drawing.Point(73, 388);
            this.telefoneTxt.Multiline = true;
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(350, 20);
            this.telefoneTxt.TabIndex = 3;
            this.telefoneTxt.TextChanged += new System.EventHandler(this.telefoneTxt_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.emailTxt.Location = new System.Drawing.Point(73, 310);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(350, 24);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.TabStop = false;
            this.emailTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nomeTxt
            // 
            this.nomeTxt.BackColor = System.Drawing.Color.White;
            this.nomeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxt.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.nomeTxt.Location = new System.Drawing.Point(73, 232);
            this.nomeTxt.Multiline = true;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(350, 24);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.TabStop = false;
            this.nomeTxt.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FindTec.Properties.Resources.imagemAluno;
            this.pictureBox1.Location = new System.Drawing.Point(50, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panelOportunidades
            // 
            this.panelOportunidades.BackColor = System.Drawing.Color.White;
            this.panelOportunidades.Controls.Add(this.labelOportunidades);
            this.panelOportunidades.Controls.Add(this.gridViewOportunidades);
            this.panelOportunidades.Location = new System.Drawing.Point(223, 15);
            this.panelOportunidades.Name = "panelOportunidades";
            this.panelOportunidades.Size = new System.Drawing.Size(755, 525);
            this.panelOportunidades.TabIndex = 6;
            this.panelOportunidades.Visible = false;
            // 
            // labelOportunidades
            // 
            this.labelOportunidades.AutoSize = true;
            this.labelOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOportunidades.Location = new System.Drawing.Point(307, 63);
            this.labelOportunidades.Name = "labelOportunidades";
            this.labelOportunidades.Size = new System.Drawing.Size(154, 26);
            this.labelOportunidades.TabIndex = 0;
            this.labelOportunidades.Text = "Oportunidades";
            // 
            // gridViewOportunidades
            // 
            this.gridViewOportunidades.BackgroundColor = System.Drawing.Color.White;
            this.gridViewOportunidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewOportunidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewOportunidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewOportunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOportunidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFoto,
            this.colNomeEmpresa,
            this.NomeVagaGrid,
            this.cargoGrid,
            this.cargaHGrid,
            this.remuneracaoGrid,
            this.colCandidatar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewOportunidades.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewOportunidades.Location = new System.Drawing.Point(42, 117);
            this.gridViewOportunidades.Name = "gridViewOportunidades";
            this.gridViewOportunidades.RowHeadersVisible = false;
            this.gridViewOportunidades.Size = new System.Drawing.Size(671, 330);
            this.gridViewOportunidades.TabIndex = 19;
            this.gridViewOportunidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewOportunidades_CellContentClick);
            // 
            // colFoto
            // 
            this.colFoto.HeaderText = "";
            this.colFoto.Name = "colFoto";
            this.colFoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFoto.Width = 70;
            // 
            // colNomeEmpresa
            // 
            this.colNomeEmpresa.HeaderText = "Empresa";
            this.colNomeEmpresa.Name = "colNomeEmpresa";
            this.colNomeEmpresa.Width = 90;
            // 
            // NomeVagaGrid
            // 
            this.NomeVagaGrid.HeaderText = "Titulo Vaga";
            this.NomeVagaGrid.Name = "NomeVagaGrid";
            this.NomeVagaGrid.ReadOnly = true;
            this.NomeVagaGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeVagaGrid.Width = 125;
            // 
            // cargoGrid
            // 
            this.cargoGrid.HeaderText = "Cargo";
            this.cargoGrid.Name = "cargoGrid";
            this.cargoGrid.ReadOnly = true;
            this.cargoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cargaHGrid
            // 
            this.cargaHGrid.HeaderText = "Carga Horária";
            this.cargaHGrid.Name = "cargaHGrid";
            this.cargaHGrid.ReadOnly = true;
            this.cargaHGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // remuneracaoGrid
            // 
            this.remuneracaoGrid.HeaderText = "Remuneração";
            this.remuneracaoGrid.Name = "remuneracaoGrid";
            this.remuneracaoGrid.ReadOnly = true;
            this.remuneracaoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remuneracaoGrid.Width = 95;
            // 
            // colCandidatar
            // 
            this.colCandidatar.HeaderText = "";
            this.colCandidatar.Name = "colCandidatar";
            this.colCandidatar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCandidatar.Width = 90;
            // 
            // panelVagaInfo
            // 
            this.panelVagaInfo.BackColor = System.Drawing.Color.White;
            this.panelVagaInfo.Controls.Add(this.botaoVoltar);
            this.panelVagaInfo.Controls.Add(this.txtDescricao);
            this.panelVagaInfo.Controls.Add(this.txtCargaHoraria);
            this.panelVagaInfo.Controls.Add(this.txtRemuneracao);
            this.panelVagaInfo.Controls.Add(this.txtCargo);
            this.panelVagaInfo.Controls.Add(this.txtEmpresaContratante);
            this.panelVagaInfo.Controls.Add(this.txtTituloVaga);
            this.panelVagaInfo.Controls.Add(this.botaoCandidatar);
            this.panelVagaInfo.Controls.Add(this.label9);
            this.panelVagaInfo.Controls.Add(this.label8);
            this.panelVagaInfo.Controls.Add(this.label7);
            this.panelVagaInfo.Controls.Add(this.labelRemuneracao);
            this.panelVagaInfo.Controls.Add(this.labelDescricaoVaga);
            this.panelVagaInfo.Controls.Add(this.labelNomeVaga);
            this.panelVagaInfo.Controls.Add(this.labelVagaInfo);
            this.panelVagaInfo.Location = new System.Drawing.Point(223, 15);
            this.panelVagaInfo.Name = "panelVagaInfo";
            this.panelVagaInfo.Size = new System.Drawing.Size(755, 525);
            this.panelVagaInfo.TabIndex = 7;
            this.panelVagaInfo.Visible = false;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(78, 28);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(60, 23);
            this.botaoVoltar.TabIndex = 14;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Location = new System.Drawing.Point(309, 328);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(197, 71);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.BackColor = System.Drawing.SystemColors.Control;
            this.txtCargaHoraria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargaHoraria.Location = new System.Drawing.Point(309, 278);
            this.txtCargaHoraria.Multiline = true;
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.ReadOnly = true;
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 20);
            this.txtCargaHoraria.TabIndex = 12;
            // 
            // txtRemuneracao
            // 
            this.txtRemuneracao.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemuneracao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemuneracao.Location = new System.Drawing.Point(309, 234);
            this.txtRemuneracao.Multiline = true;
            this.txtRemuneracao.Name = "txtRemuneracao";
            this.txtRemuneracao.ReadOnly = true;
            this.txtRemuneracao.Size = new System.Drawing.Size(100, 20);
            this.txtRemuneracao.TabIndex = 11;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Location = new System.Drawing.Point(309, 197);
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(131, 20);
            this.txtCargo.TabIndex = 10;
            // 
            // txtEmpresaContratante
            // 
            this.txtEmpresaContratante.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpresaContratante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresaContratante.Location = new System.Drawing.Point(309, 154);
            this.txtEmpresaContratante.Multiline = true;
            this.txtEmpresaContratante.Name = "txtEmpresaContratante";
            this.txtEmpresaContratante.ReadOnly = true;
            this.txtEmpresaContratante.Size = new System.Drawing.Size(197, 20);
            this.txtEmpresaContratante.TabIndex = 9;
            // 
            // txtTituloVaga
            // 
            this.txtTituloVaga.BackColor = System.Drawing.SystemColors.Control;
            this.txtTituloVaga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloVaga.Location = new System.Drawing.Point(309, 108);
            this.txtTituloVaga.Multiline = true;
            this.txtTituloVaga.Name = "txtTituloVaga";
            this.txtTituloVaga.ReadOnly = true;
            this.txtTituloVaga.Size = new System.Drawing.Size(197, 20);
            this.txtTituloVaga.TabIndex = 8;
            // 
            // botaoCandidatar
            // 
            this.botaoCandidatar.Location = new System.Drawing.Point(365, 429);
            this.botaoCandidatar.Name = "botaoCandidatar";
            this.botaoCandidatar.Size = new System.Drawing.Size(84, 25);
            this.botaoCandidatar.TabIndex = 7;
            this.botaoCandidatar.Text = "Candidatar-se";
            this.botaoCandidatar.UseVisualStyleBackColor = true;
            this.botaoCandidatar.Click += new System.EventHandler(this.botaoCandidatar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Carga Horária";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Empresa Contratante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cargo:";
            // 
            // labelRemuneracao
            // 
            this.labelRemuneracao.AutoSize = true;
            this.labelRemuneracao.Location = new System.Drawing.Point(216, 240);
            this.labelRemuneracao.Name = "labelRemuneracao";
            this.labelRemuneracao.Size = new System.Drawing.Size(77, 13);
            this.labelRemuneracao.TabIndex = 3;
            this.labelRemuneracao.Text = "Remuneração:";
            // 
            // labelDescricaoVaga
            // 
            this.labelDescricaoVaga.AutoSize = true;
            this.labelDescricaoVaga.Location = new System.Drawing.Point(230, 335);
            this.labelDescricaoVaga.Name = "labelDescricaoVaga";
            this.labelDescricaoVaga.Size = new System.Drawing.Size(58, 13);
            this.labelDescricaoVaga.TabIndex = 2;
            this.labelDescricaoVaga.Text = "Descrição:";
            // 
            // labelNomeVaga
            // 
            this.labelNomeVaga.AutoSize = true;
            this.labelNomeVaga.Location = new System.Drawing.Point(257, 115);
            this.labelNomeVaga.Name = "labelNomeVaga";
            this.labelNomeVaga.Size = new System.Drawing.Size(36, 13);
            this.labelNomeVaga.TabIndex = 1;
            this.labelNomeVaga.Text = "Titulo:";
            // 
            // labelVagaInfo
            // 
            this.labelVagaInfo.AutoSize = true;
            this.labelVagaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelVagaInfo.Location = new System.Drawing.Point(287, 50);
            this.labelVagaInfo.Name = "labelVagaInfo";
            this.labelVagaInfo.Size = new System.Drawing.Size(219, 26);
            this.labelVagaInfo.TabIndex = 0;
            this.labelVagaInfo.Text = "Informações da Vaga";
            // 
            // panelConversas
            // 
            this.panelConversas.BackColor = System.Drawing.Color.Transparent;
            this.panelConversas.BackgroundImage = global::FindTec.Properties.Resources.TelaMensagemRecebida;
            this.panelConversas.Controls.Add(this.FlowPanelConversas);
            this.panelConversas.Controls.Add(this.listViewConversas);
            this.panelConversas.Location = new System.Drawing.Point(223, 15);
            this.panelConversas.Name = "panelConversas";
            this.panelConversas.Size = new System.Drawing.Size(755, 525);
            this.panelConversas.TabIndex = 8;
            this.panelConversas.Visible = false;
            // 
            // FlowPanelConversas
            // 
            this.FlowPanelConversas.BackColor = System.Drawing.Color.Transparent;
            this.FlowPanelConversas.Location = new System.Drawing.Point(207, 85);
            this.FlowPanelConversas.Name = "FlowPanelConversas";
            this.FlowPanelConversas.Size = new System.Drawing.Size(334, 409);
            this.FlowPanelConversas.TabIndex = 2;
            this.FlowPanelConversas.Click += new System.EventHandler(this.FlowPanelConversas_Click);
            // 
            // listViewConversas
            // 
            this.listViewConversas.HideSelection = false;
            this.listViewConversas.Location = new System.Drawing.Point(207, 85);
            this.listViewConversas.Name = "listViewConversas";
            this.listViewConversas.Size = new System.Drawing.Size(334, 409);
            this.listViewConversas.TabIndex = 0;
            this.listViewConversas.UseCompatibleStateImageBehavior = false;
            this.listViewConversas.SelectedIndexChanged += new System.EventHandler(this.listViewConversas_SelectedIndexChanged);
            // 
            // panelMensagens
            // 
            this.panelMensagens.BackColor = System.Drawing.Color.Transparent;
            this.panelMensagens.BackgroundImage = global::FindTec.Properties.Resources.TelaMensagem;
            this.panelMensagens.Controls.Add(this.flowLayoutPanelMensagens);
            this.panelMensagens.Controls.Add(this.btnVoltar);
            this.panelMensagens.Controls.Add(this.btnEnviar);
            this.panelMensagens.Controls.Add(this.txtMensagem);
            this.panelMensagens.Location = new System.Drawing.Point(223, 15);
            this.panelMensagens.Name = "panelMensagens";
            this.panelMensagens.Size = new System.Drawing.Size(755, 525);
            this.panelMensagens.TabIndex = 26;
            this.panelMensagens.Visible = false;
            // 
            // flowLayoutPanelMensagens
            // 
            this.flowLayoutPanelMensagens.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMensagens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMensagens.Location = new System.Drawing.Point(111, 80);
            this.flowLayoutPanelMensagens.Name = "flowLayoutPanelMensagens";
            this.flowLayoutPanelMensagens.Size = new System.Drawing.Size(525, 343);
            this.flowLayoutPanelMensagens.TabIndex = 8;
            this.flowLayoutPanelMensagens.WrapContents = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(15, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::FindTec.Properties.Resources.botaoEnviarMensagem1;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(578, 457);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(38, 37);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.MouseEnter += new System.EventHandler(this.btnEnviar_MouseEnter);
            this.btnEnviar.MouseLeave += new System.EventHandler(this.btnEnviar_MouseLeave);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtMensagem.Location = new System.Drawing.Point(153, 467);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(419, 19);
            this.txtMensagem.TabIndex = 5;
            this.txtMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarMensagem_Enter);
            // 
            // Form1
            // 
            this.BackgroundImage = global::FindTec.Properties.Resources.backgroundGeral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMensagens);
            this.Controls.Add(this.panelOportunidades);
            this.Controls.Add(this.panelVagaInfo);
            this.Controls.Add(this.panelPerfil);
            this.Controls.Add(this.panelConversas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOportunidades.ResumeLayout(false);
            this.panelOportunidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOportunidades)).EndInit();
            this.panelVagaInfo.ResumeLayout(false);
            this.panelVagaInfo.PerformLayout();
            this.panelConversas.ResumeLayout(false);
            this.panelMensagens.ResumeLayout(false);
            this.panelMensagens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoPerfil;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoMensagens;
        private System.Windows.Forms.Button botaoOportunidades;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cursoTxt;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button botaoDesativarConta;
        private System.Windows.Forms.Button botaoEditarDados;
        private System.Windows.Forms.Button botaoAlterarFoto;
        private System.Windows.Forms.Panel panelOportunidades;
        private System.Windows.Forms.Label labelOportunidades;
        private System.Windows.Forms.DataGridView gridViewOportunidades;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVagaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn remuneracaoGrid;
        private System.Windows.Forms.DataGridViewButtonColumn colCandidatar;
        private System.Windows.Forms.Panel panelVagaInfo;
        private System.Windows.Forms.Button botaoCandidatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRemuneracao;
        private System.Windows.Forms.Label labelDescricaoVaga;
        private System.Windows.Forms.Label labelNomeVaga;
        private System.Windows.Forms.Label labelVagaInfo;
        private System.Windows.Forms.TextBox txtTituloVaga;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtRemuneracao;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtEmpresaContratante;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Panel panelConversas;
        private System.Windows.Forms.Panel panelMensagens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensagem;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMensagens;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelConversas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button botaoHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoAlterarSenha;
        private System.Windows.Forms.ListView listViewConversas;
    }
}

