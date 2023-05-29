
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
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cursoTxt = new System.Windows.Forms.TextBox();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOportunidades = new System.Windows.Forms.Panel();
            this.gridViewOportunidades = new System.Windows.Forms.DataGridView();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVagaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remuneracaoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCandidatar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelOportunidades = new System.Windows.Forms.Label();
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
            this.labelConversas = new System.Windows.Forms.Label();
            this.listViewConversas = new System.Windows.Forms.ListView();
            this.panelMensagens = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMensagens = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opA1 = new FindTec.OpA();
            this.opB1 = new FindTec.OpB();
            this.opD1 = new FindTec.OpD();
            this.opC1 = new FindTec.OpC();
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonD);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::FindTec.Properties.Resources.botaoHome_1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 56);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
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
            // buttonD
            // 
            this.buttonD.BackgroundImage = global::FindTec.Properties.Resources.botaoSair_1;
            this.buttonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonD.ForeColor = System.Drawing.Color.Black;
            this.buttonD.Location = new System.Drawing.Point(1, 498);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(197, 34);
            this.buttonD.TabIndex = 3;
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackgroundImage = global::FindTec.Properties.Resources.botaoMensagens_1;
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonC.ForeColor = System.Drawing.Color.Black;
            this.buttonC.Location = new System.Drawing.Point(3, 392);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(197, 56);
            this.buttonC.TabIndex = 2;
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackgroundImage = global::FindTec.Properties.Resources.botaoOportunidades_1;
            this.buttonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonB.FlatAppearance.BorderSize = 0;
            this.buttonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonB.ForeColor = System.Drawing.Color.Black;
            this.buttonB.Location = new System.Drawing.Point(3, 332);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(197, 56);
            this.buttonB.TabIndex = 1;
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonA
            // 
            this.buttonA.BackgroundImage = global::FindTec.Properties.Resources.botaoPerfil_1;
            this.buttonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonA.ForeColor = System.Drawing.Color.Black;
            this.buttonA.Location = new System.Drawing.Point(3, 275);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(197, 56);
            this.buttonA.TabIndex = 0;
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.Transparent;
            this.panelPerfil.BackgroundImage = global::FindTec.Properties.Resources.telaPerfil;
            this.panelPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPerfil.Controls.Add(this.buttonUpload);
            this.panelPerfil.Controls.Add(this.label1);
            this.panelPerfil.Controls.Add(this.button2);
            this.panelPerfil.Controls.Add(this.button1);
            this.panelPerfil.Controls.Add(this.cursoTxt);
            this.panelPerfil.Controls.Add(this.telefoneTxt);
            this.panelPerfil.Controls.Add(this.emailTxt);
            this.panelPerfil.Controls.Add(this.nomeTxt);
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Location = new System.Drawing.Point(222, 15);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(755, 525);
            this.panelPerfil.TabIndex = 5;
            this.panelPerfil.Visible = false;
            this.panelPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPerfil_Paint);
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackgroundImage = global::FindTec.Properties.Resources.BotaoAlterarImagem_1;
            this.buttonUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUpload.FlatAppearance.BorderSize = 0;
            this.buttonUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.Location = new System.Drawing.Point(182, 128);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(121, 35);
            this.buttonUpload.TabIndex = 12;
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FindTec.Properties.Resources.botaoDesativarConta_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(554, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 51);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FindTec.Properties.Resources.botaoEditarDados_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(554, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 62);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.telefoneTxt.Size = new System.Drawing.Size(350, 24);
            this.telefoneTxt.TabIndex = 3;
            this.telefoneTxt.TabStop = false;
            this.telefoneTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.nomeTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.panelOportunidades.Controls.Add(this.gridViewOportunidades);
            this.panelOportunidades.Controls.Add(this.labelOportunidades);
            this.panelOportunidades.Location = new System.Drawing.Point(201, 0);
            this.panelOportunidades.Name = "panelOportunidades";
            this.panelOportunidades.Size = new System.Drawing.Size(783, 511);
            this.panelOportunidades.TabIndex = 6;
            this.panelOportunidades.Visible = false;
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
            this.panelVagaInfo.Location = new System.Drawing.Point(200, 0);
            this.panelVagaInfo.Name = "panelVagaInfo";
            this.panelVagaInfo.Size = new System.Drawing.Size(784, 511);
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
            this.panelConversas.BackColor = System.Drawing.Color.White;
            this.panelConversas.Controls.Add(this.FlowPanelConversas);
            this.panelConversas.Controls.Add(this.labelConversas);
            this.panelConversas.Controls.Add(this.listViewConversas);
            this.panelConversas.Location = new System.Drawing.Point(200, 0);
            this.panelConversas.Name = "panelConversas";
            this.panelConversas.Size = new System.Drawing.Size(784, 511);
            this.panelConversas.TabIndex = 8;
            this.panelConversas.Visible = false;
            // 
            // FlowPanelConversas
            // 
            this.FlowPanelConversas.BackColor = System.Drawing.Color.White;
            this.FlowPanelConversas.Location = new System.Drawing.Point(145, 85);
            this.FlowPanelConversas.Name = "FlowPanelConversas";
            this.FlowPanelConversas.Size = new System.Drawing.Size(450, 350);
            this.FlowPanelConversas.TabIndex = 2;
            this.FlowPanelConversas.Click += new System.EventHandler(this.FlowPanelConversas_Click);
            // 
            // labelConversas
            // 
            this.labelConversas.AutoSize = true;
            this.labelConversas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConversas.Location = new System.Drawing.Point(290, 35);
            this.labelConversas.Name = "labelConversas";
            this.labelConversas.Size = new System.Drawing.Size(116, 26);
            this.labelConversas.TabIndex = 1;
            this.labelConversas.Text = "Conversas";
            // 
            // listViewConversas
            // 
            this.listViewConversas.HideSelection = false;
            this.listViewConversas.Location = new System.Drawing.Point(145, 85);
            this.listViewConversas.Name = "listViewConversas";
            this.listViewConversas.Size = new System.Drawing.Size(450, 350);
            this.listViewConversas.TabIndex = 0;
            this.listViewConversas.UseCompatibleStateImageBehavior = false;
            this.listViewConversas.SelectedIndexChanged += new System.EventHandler(this.listViewConversas_SelectedIndexChanged);
            // 
            // panelMensagens
            // 
            this.panelMensagens.BackColor = System.Drawing.Color.White;
            this.panelMensagens.Controls.Add(this.flowLayoutPanelMensagens);
            this.panelMensagens.Controls.Add(this.btnVoltar);
            this.panelMensagens.Controls.Add(this.btnEnviar);
            this.panelMensagens.Controls.Add(this.txtMensagem);
            this.panelMensagens.Location = new System.Drawing.Point(200, 0);
            this.panelMensagens.Name = "panelMensagens";
            this.panelMensagens.Size = new System.Drawing.Size(784, 511);
            this.panelMensagens.TabIndex = 26;
            this.panelMensagens.Visible = false;
            // 
            // flowLayoutPanelMensagens
            // 
            this.flowLayoutPanelMensagens.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMensagens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMensagens.Location = new System.Drawing.Point(82, 85);
            this.flowLayoutPanelMensagens.Name = "flowLayoutPanelMensagens";
            this.flowLayoutPanelMensagens.Size = new System.Drawing.Size(630, 342);
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
            this.btnEnviar.Location = new System.Drawing.Point(659, 436);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(55, 28);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(82, 436);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(569, 28);
            this.txtMensagem.TabIndex = 5;
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
            // opA1
            // 
            this.opA1.AccessibleName = "";
            this.opA1.AutoSize = true;
            this.opA1.BackColor = System.Drawing.Color.White;
            this.opA1.Location = new System.Drawing.Point(201, 0);
            this.opA1.Name = "opA1";
            this.opA1.Size = new System.Drawing.Size(783, 511);
            this.opA1.TabIndex = 1;
            this.opA1.Load += new System.EventHandler(this.opA2_Load);
            // 
            // opB1
            // 
            this.opB1.BackColor = System.Drawing.Color.White;
            this.opB1.Location = new System.Drawing.Point(201, 0);
            this.opB1.Name = "opB1";
            this.opB1.Size = new System.Drawing.Size(783, 511);
            this.opB1.TabIndex = 2;
            this.opB1.Visible = false;
            // 
            // opD1
            // 
            this.opD1.BackColor = System.Drawing.Color.White;
            this.opD1.Location = new System.Drawing.Point(201, 0);
            this.opD1.Name = "opD1";
            this.opD1.Size = new System.Drawing.Size(783, 511);
            this.opD1.TabIndex = 4;
            this.opD1.Visible = false;
            this.opD1.Load += new System.EventHandler(this.opD1_Load);
            // 
            // opC1
            // 
            this.opC1.BackColor = System.Drawing.Color.White;
            this.opC1.Location = new System.Drawing.Point(201, 0);
            this.opC1.Name = "opC1";
            this.opC1.Size = new System.Drawing.Size(783, 511);
            this.opC1.TabIndex = 3;
            this.opC1.Visible = false;
            // 
            // Form1
            // 
            this.BackgroundImage = global::FindTec.Properties.Resources.backgroundGeral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPerfil);
            this.Controls.Add(this.opA1);
            this.Controls.Add(this.panelOportunidades);
            this.Controls.Add(this.panelVagaInfo);
            this.Controls.Add(this.opB1);
            this.Controls.Add(this.opD1);
            this.Controls.Add(this.panelConversas);
            this.Controls.Add(this.panelMensagens);
            this.Controls.Add(this.opC1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.panelConversas.PerformLayout();
            this.panelMensagens.ResumeLayout(false);
            this.panelMensagens.PerformLayout();
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
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cursoTxt;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpload;
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
        private System.Windows.Forms.Label labelConversas;
        private System.Windows.Forms.ListView listViewConversas;
        private System.Windows.Forms.Panel panelMensagens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensagem;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMensagens;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelConversas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

