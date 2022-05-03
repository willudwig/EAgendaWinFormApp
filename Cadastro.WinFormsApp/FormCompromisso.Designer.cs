namespace Cadastro.WinFormsApp
{
    partial class FormCompromisso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompromisso));
            this.lvFuturos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnFuturos = new System.Windows.Forms.Button();
            this.btnPassados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.lbContato = new System.Windows.Forms.Label();
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.cbContato = new System.Windows.Forms.ComboBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimparTerminadas = new System.Windows.Forms.Button();
            this.btnFinalizado = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnModoEdicao = new System.Windows.Forms.Panel();
            this.lbModoEdicao = new System.Windows.Forms.Label();
            this.lvPassados = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.pnPassados = new System.Windows.Forms.Panel();
            this.btnLimpaPassados = new System.Windows.Forms.Button();
            this.btnExclPassados = new System.Windows.Forms.Button();
            this.tbnAddContato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnModoEdicao.SuspendLayout();
            this.pnPassados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFuturos
            // 
            this.lvFuturos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvFuturos.FullRowSelect = true;
            this.lvFuturos.HideSelection = false;
            this.lvFuturos.Location = new System.Drawing.Point(25, 297);
            this.lvFuturos.Name = "lvFuturos";
            this.lvFuturos.Size = new System.Drawing.Size(1094, 367);
            this.lvFuturos.TabIndex = 11;
            this.lvFuturos.UseCompatibleStateImageBehavior = false;
            this.lvFuturos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Assunto";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Local";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hora Início";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contato";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data término";
            this.columnHeader7.Width = 170;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(422, 107);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(358, 31);
            this.dtpData.TabIndex = 3;
            // 
            // btnFuturos
            // 
            this.btnFuturos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFuturos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuturos.Location = new System.Drawing.Point(25, 263);
            this.btnFuturos.Name = "btnFuturos";
            this.btnFuturos.Size = new System.Drawing.Size(175, 34);
            this.btnFuturos.TabIndex = 14;
            this.btnFuturos.Text = "Futuros";
            this.btnFuturos.UseVisualStyleBackColor = false;
            this.btnFuturos.Click += new System.EventHandler(this.btnFuturos_Click);
            // 
            // btnPassados
            // 
            this.btnPassados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPassados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassados.Location = new System.Drawing.Point(198, 263);
            this.btnPassados.Name = "btnPassados";
            this.btnPassados.Size = new System.Drawing.Size(175, 34);
            this.btnPassados.TabIndex = 15;
            this.btnPassados.Text = "Passados";
            this.btnPassados.UseVisualStyleBackColor = false;
            this.btnPassados.Click += new System.EventHandler(this.btnPassados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbnAddContato);
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.tbHora);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lbData);
            this.panel1.Controls.Add(this.lbContato);
            this.panel1.Controls.Add(this.lbLocal);
            this.panel1.Controls.Add(this.lbAssunto);
            this.panel1.Controls.Add(this.cbContato);
            this.panel1.Controls.Add(this.tbLocal);
            this.panel1.Controls.Add(this.tbAssunto);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 214);
            this.panel1.TabIndex = 7;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHora.Location = new System.Drawing.Point(422, 149);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(44, 21);
            this.lbHora.TabIndex = 14;
            this.lbHora.Text = "Hora";
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(422, 171);
            this.tbHora.Mask = "00:00";
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(102, 31);
            this.tbHora.TabIndex = 4;
            this.tbHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(23, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(422, 83);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(42, 21);
            this.lbData.TabIndex = 11;
            this.lbData.Text = "Data";
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContato.Location = new System.Drawing.Point(422, 14);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(65, 21);
            this.lbContato.TabIndex = 10;
            this.lbContato.Text = "Contato";
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocal.Location = new System.Drawing.Point(23, 83);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(46, 21);
            this.lbLocal.TabIndex = 9;
            this.lbLocal.Text = "Local";
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAssunto.Location = new System.Drawing.Point(23, 13);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(66, 21);
            this.lbAssunto.TabIndex = 8;
            this.lbAssunto.Text = "Assunto";
            // 
            // cbContato
            // 
            this.cbContato.FormattingEnabled = true;
            this.cbContato.Location = new System.Drawing.Point(422, 35);
            this.cbContato.Name = "cbContato";
            this.cbContato.Size = new System.Drawing.Size(266, 33);
            this.cbContato.TabIndex = 2;
            this.cbContato.Text = "selecionar...";
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(23, 104);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(331, 31);
            this.tbLocal.TabIndex = 1;
            // 
            // tbAssunto
            // 
            this.tbAssunto.Location = new System.Drawing.Point(23, 35);
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(331, 31);
            this.tbAssunto.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnLimparTerminadas);
            this.panel3.Controls.Add(this.btnFinalizado);
            this.panel3.Controls.Add(this.btnAtualizar);
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Location = new System.Drawing.Point(25, 686);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 76);
            this.panel3.TabIndex = 15;
            // 
            // btnLimparTerminadas
            // 
            this.btnLimparTerminadas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparTerminadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparTerminadas.Location = new System.Drawing.Point(551, 9);
            this.btnLimparTerminadas.Name = "btnLimparTerminadas";
            this.btnLimparTerminadas.Size = new System.Drawing.Size(130, 60);
            this.btnLimparTerminadas.TabIndex = 12;
            this.btnLimparTerminadas.Text = "Limpar Terminadas";
            this.btnLimparTerminadas.UseVisualStyleBackColor = false;
            this.btnLimparTerminadas.Click += new System.EventHandler(this.btnLimparTerminadas_Click);
            // 
            // btnFinalizado
            // 
            this.btnFinalizado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizado.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizado.Image")));
            this.btnFinalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizado.Location = new System.Drawing.Point(823, 8);
            this.btnFinalizado.Name = "btnFinalizado";
            this.btnFinalizado.Size = new System.Drawing.Size(261, 60);
            this.btnFinalizado.TabIndex = 11;
            this.btnFinalizado.Text = "Marcar como Finalizado ";
            this.btnFinalizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizado.UseVisualStyleBackColor = false;
            this.btnFinalizado.Click += new System.EventHandler(this.btnFinalizado_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(687, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(130, 60);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Location = new System.Drawing.Point(415, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 60);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar por Período";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(279, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 60);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(143, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 60);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(7, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 60);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonGravar);
            this.panel4.Controls.Add(this.buttonCarregar);
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel4.Location = new System.Drawing.Point(955, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 78);
            this.panel4.TabIndex = 17;
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGravar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravar.Image")));
            this.buttonGravar.Location = new System.Drawing.Point(5, 3);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(72, 68);
            this.buttonGravar.TabIndex = 12;
            this.buttonGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonGravar, "salvar em arquivo");
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCarregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCarregar.Image")));
            this.buttonCarregar.Location = new System.Drawing.Point(83, 3);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(72, 68);
            this.buttonCarregar.TabIndex = 13;
            this.buttonCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCarregar, "carregar arquivo salvo");
            this.buttonCarregar.UseVisualStyleBackColor = false;
            this.buttonCarregar.Click += new System.EventHandler(this.buttonCarregar_Click);
            // 
            // pnModoEdicao
            // 
            this.pnModoEdicao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnModoEdicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnModoEdicao.Controls.Add(this.lbModoEdicao);
            this.pnModoEdicao.Location = new System.Drawing.Point(848, 220);
            this.pnModoEdicao.Name = "pnModoEdicao";
            this.pnModoEdicao.Size = new System.Drawing.Size(271, 71);
            this.pnModoEdicao.TabIndex = 18;
            this.pnModoEdicao.Visible = false;
            // 
            // lbModoEdicao
            // 
            this.lbModoEdicao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbModoEdicao.Image = ((System.Drawing.Image)(resources.GetObject("lbModoEdicao.Image")));
            this.lbModoEdicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbModoEdicao.Location = new System.Drawing.Point(20, 0);
            this.lbModoEdicao.Name = "lbModoEdicao";
            this.lbModoEdicao.Size = new System.Drawing.Size(211, 69);
            this.lbModoEdicao.TabIndex = 16;
            this.lbModoEdicao.Text = "Modo Edição";
            this.lbModoEdicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvPassados
            // 
            this.lvPassados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvPassados.FullRowSelect = true;
            this.lvPassados.HideSelection = false;
            this.lvPassados.Location = new System.Drawing.Point(25, 297);
            this.lvPassados.Name = "lvPassados";
            this.lvPassados.Size = new System.Drawing.Size(1094, 367);
            this.lvPassados.TabIndex = 19;
            this.lvPassados.UseCompatibleStateImageBehavior = false;
            this.lvPassados.View = System.Windows.Forms.View.Details;
            this.lvPassados.Visible = false;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nº";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Assunto";
            this.columnHeader9.Width = 170;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Local";
            this.columnHeader10.Width = 170;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Data";
            this.columnHeader11.Width = 170;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Hora Início";
            this.columnHeader12.Width = 170;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Contato";
            this.columnHeader13.Width = 170;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Data término";
            this.columnHeader14.Width = 170;
            // 
            // pnPassados
            // 
            this.pnPassados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnPassados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPassados.Controls.Add(this.btnLimpaPassados);
            this.pnPassados.Controls.Add(this.btnExclPassados);
            this.pnPassados.Location = new System.Drawing.Point(25, 686);
            this.pnPassados.Name = "pnPassados";
            this.pnPassados.Size = new System.Drawing.Size(1094, 76);
            this.pnPassados.TabIndex = 16;
            this.pnPassados.Visible = false;
            // 
            // btnLimpaPassados
            // 
            this.btnLimpaPassados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpaPassados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaPassados.Location = new System.Drawing.Point(144, 8);
            this.btnLimpaPassados.Name = "btnLimpaPassados";
            this.btnLimpaPassados.Size = new System.Drawing.Size(130, 60);
            this.btnLimpaPassados.TabIndex = 8;
            this.btnLimpaPassados.Text = "Limpar";
            this.btnLimpaPassados.UseVisualStyleBackColor = false;
            this.btnLimpaPassados.Click += new System.EventHandler(this.btnLimpaPassados_Click);
            // 
            // btnExclPassados
            // 
            this.btnExclPassados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExclPassados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExclPassados.Location = new System.Drawing.Point(8, 8);
            this.btnExclPassados.Name = "btnExclPassados";
            this.btnExclPassados.Size = new System.Drawing.Size(130, 60);
            this.btnExclPassados.TabIndex = 7;
            this.btnExclPassados.Text = "Excluir";
            this.btnExclPassados.UseVisualStyleBackColor = false;
            this.btnExclPassados.Click += new System.EventHandler(this.btnExclPassados_Click);
            // 
            // tbnAddContato
            // 
            this.tbnAddContato.Location = new System.Drawing.Point(694, 35);
            this.tbnAddContato.Name = "tbnAddContato";
            this.tbnAddContato.Size = new System.Drawing.Size(34, 33);
            this.tbnAddContato.TabIndex = 15;
            this.tbnAddContato.Text = "...";
            this.toolTip1.SetToolTip(this.tbnAddContato, "abrir tela de contatos");
            this.tbnAddContato.UseVisualStyleBackColor = true;
            this.tbnAddContato.Click += new System.EventHandler(this.tbnAddContato_Click);
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 781);
            this.Controls.Add(this.pnPassados);
            this.Controls.Add(this.lvPassados);
            this.Controls.Add(this.pnModoEdicao);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPassados);
            this.Controls.Add(this.btnFuturos);
            this.Controls.Add(this.lvFuturos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Compromisso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompromisso_FormClosing);
            this.Load += new System.EventHandler(this.FormCompromisso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnModoEdicao.ResumeLayout(false);
            this.pnPassados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvFuturos;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnFuturos;
        private System.Windows.Forms.Button btnPassados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbContato;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.ComboBox cbContato;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox tbHora;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnModoEdicao;
        private System.Windows.Forms.Label lbModoEdicao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFinalizado;
        private System.Windows.Forms.Button btnLimparTerminadas;
        private System.Windows.Forms.ListView lvPassados;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Panel pnPassados;
        private System.Windows.Forms.Button btnLimpaPassados;
        private System.Windows.Forms.Button btnExclPassados;
        private System.Windows.Forms.Button tbnAddContato;
    }
}