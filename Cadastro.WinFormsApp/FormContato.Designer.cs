namespace Cadastro.WinFormsApp
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.pnModoEdicao = new System.Windows.Forms.Panel();
            this.lbModoEdicao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Agrupar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDDD = new System.Windows.Forms.Label();
            this.tbDDD = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lvContato = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnModoEdicao.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnModoEdicao);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lvContato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 727);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonGravar);
            this.panel4.Controls.Add(this.buttonCarregar);
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel4.Location = new System.Drawing.Point(731, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 78);
            this.panel4.TabIndex = 16;
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGravar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravar.Image")));
            this.buttonGravar.Location = new System.Drawing.Point(5, 3);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(72, 68);
            this.buttonGravar.TabIndex = 6;
            this.buttonGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonGravar, "gravar no repositório");
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
            this.buttonCarregar.TabIndex = 7;
            this.buttonCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCarregar, "carregar do repositório");
            this.buttonCarregar.UseVisualStyleBackColor = false;
            this.buttonCarregar.Click += new System.EventHandler(this.buttonCarregar_Click);
            // 
            // pnModoEdicao
            // 
            this.pnModoEdicao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnModoEdicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnModoEdicao.Controls.Add(this.lbModoEdicao);
            this.pnModoEdicao.Location = new System.Drawing.Point(630, 154);
            this.pnModoEdicao.Name = "pnModoEdicao";
            this.pnModoEdicao.Size = new System.Drawing.Size(265, 71);
            this.pnModoEdicao.TabIndex = 15;
            this.pnModoEdicao.Visible = false;
            // 
            // lbModoEdicao
            // 
            this.lbModoEdicao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbModoEdicao.Image = ((System.Drawing.Image)(resources.GetObject("lbModoEdicao.Image")));
            this.lbModoEdicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbModoEdicao.Location = new System.Drawing.Point(14, 1);
            this.lbModoEdicao.Name = "lbModoEdicao";
            this.lbModoEdicao.Size = new System.Drawing.Size(200, 69);
            this.lbModoEdicao.TabIndex = 16;
            this.lbModoEdicao.Text = "Modo Edição";
            this.lbModoEdicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Agrupar);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Location = new System.Drawing.Point(12, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 76);
            this.panel3.TabIndex = 14;
            // 
            // Agrupar
            // 
            this.Agrupar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Agrupar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agrupar.Location = new System.Drawing.Point(426, 9);
            this.Agrupar.Name = "Agrupar";
            this.Agrupar.Size = new System.Drawing.Size(130, 60);
            this.Agrupar.TabIndex = 10;
            this.Agrupar.Text = "Agrupar Cargo";
            this.Agrupar.UseVisualStyleBackColor = false;
            this.Agrupar.Click += new System.EventHandler(this.Agrupar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(290, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 60);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(154, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 60);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(18, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 60);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbDDD);
            this.panel2.Controls.Add(this.tbDDD);
            this.panel2.Controls.Add(this.lbCargo);
            this.panel2.Controls.Add(this.lbEmpresa);
            this.panel2.Controls.Add(this.lbTelefone);
            this.panel2.Controls.Add(this.lbMail);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Controls.Add(this.btnAddContato);
            this.panel2.Controls.Add(this.tbCargo);
            this.panel2.Controls.Add(this.tbMail);
            this.panel2.Controls.Add(this.tbEmpresa);
            this.panel2.Controls.Add(this.tbTelefone);
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 213);
            this.panel2.TabIndex = 3;
            // 
            // lbDDD
            // 
            this.lbDDD.AutoSize = true;
            this.lbDDD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDDD.Location = new System.Drawing.Point(18, 140);
            this.lbDDD.Name = "lbDDD";
            this.lbDDD.Size = new System.Drawing.Size(43, 21);
            this.lbDDD.TabIndex = 15;
            this.lbDDD.Text = "DDD";
            // 
            // tbDDD
            // 
            this.tbDDD.Location = new System.Drawing.Point(18, 163);
            this.tbDDD.Name = "tbDDD";
            this.tbDDD.Size = new System.Drawing.Size(72, 31);
            this.tbDDD.TabIndex = 2;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCargo.Location = new System.Drawing.Point(331, 74);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(52, 21);
            this.lbCargo.TabIndex = 13;
            this.lbCargo.Text = "Cargo";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpresa.Location = new System.Drawing.Point(331, 11);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(70, 21);
            this.lbEmpresa.TabIndex = 12;
            this.lbEmpresa.Text = "Empresa";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefone.Location = new System.Drawing.Point(96, 140);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(67, 21);
            this.lbTelefone.TabIndex = 11;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMail.Location = new System.Drawing.Point(18, 74);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(54, 21);
            this.lbMail.TabIndex = 10;
            this.lbMail.Text = "E-Mail";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(18, 11);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 21);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome";
            // 
            // btnAddContato
            // 
            this.btnAddContato.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContato.Location = new System.Drawing.Point(331, 158);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(245, 36);
            this.btnAddContato.TabIndex = 6;
            this.btnAddContato.Text = "Add";
            this.btnAddContato.UseVisualStyleBackColor = false;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(331, 97);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(245, 31);
            this.tbCargo.TabIndex = 5;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(18, 97);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(245, 31);
            this.tbMail.TabIndex = 1;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(331, 35);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(245, 31);
            this.tbEmpresa.TabIndex = 4;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(97, 163);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(166, 31);
            this.tbTelefone.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(18, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(245, 31);
            this.tbNome.TabIndex = 0;
            // 
            // lvContato
            // 
            this.lvContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvContato.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvContato.FullRowSelect = true;
            this.lvContato.HideSelection = false;
            this.lvContato.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvContato.Location = new System.Drawing.Point(10, 231);
            this.lvContato.Name = "lvContato";
            this.lvContato.Size = new System.Drawing.Size(885, 396);
            this.lvContato.TabIndex = 10;
            this.lvContato.UseCompatibleStateImageBehavior = false;
            this.lvContato.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-Mail";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Empresa";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cargo";
            this.columnHeader6.Width = 170;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 727);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Contato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContato_FormClosing);
            this.Load += new System.EventHandler(this.FormContato_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnModoEdicao.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ListView lvContato;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbDDD;
        private System.Windows.Forms.TextBox tbDDD;
        private System.Windows.Forms.Panel pnModoEdicao;
        private System.Windows.Forms.Label lbModoEdicao;
        private System.Windows.Forms.Button Agrupar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}