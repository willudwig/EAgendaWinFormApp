namespace Cadastro.WinFormsApp
{
    partial class FormTarefa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarefa));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.SeaGreen, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonLimparConcluidas = new System.Windows.Forms.Button();
            this.textBoxTarefa = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChecado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonConcluidas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.buttonAtualizarCheckList = new System.Windows.Forms.Button();
            this.buttonLimpaItens = new System.Windows.Forms.Button();
            this.labelItensTarefas = new System.Windows.Forms.Label();
            this.lvTarefa = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.lvItem = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTarefa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.Location = new System.Drawing.Point(7, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(125, 68);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar da Lista";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGravar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravar.Image")));
            this.buttonGravar.Location = new System.Drawing.Point(7, 3);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(72, 68);
            this.buttonGravar.TabIndex = 6;
            this.buttonGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonGravar, "salvar no repositório");
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(262, 103);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(164, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.Location = new System.Drawing.Point(138, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(125, 68);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir da Lista";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonLimparConcluidas
            // 
            this.buttonLimparConcluidas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimparConcluidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimparConcluidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimparConcluidas.Location = new System.Drawing.Point(399, 3);
            this.buttonLimparConcluidas.Name = "buttonLimparConcluidas";
            this.buttonLimparConcluidas.Size = new System.Drawing.Size(125, 68);
            this.buttonLimparConcluidas.TabIndex = 5;
            this.buttonLimparConcluidas.Text = "Limpar Concluídas";
            this.buttonLimparConcluidas.UseVisualStyleBackColor = false;
            this.buttonLimparConcluidas.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxTarefa
            // 
            this.textBoxTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTarefa.Location = new System.Drawing.Point(12, 30);
            this.textBoxTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTarefa.Multiline = true;
            this.textBoxTarefa.Name = "textBoxTarefa";
            this.textBoxTarefa.Size = new System.Drawing.Size(414, 33);
            this.textBoxTarefa.TabIndex = 0;
            this.textBoxTarefa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItem_KeyPress);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItem.Location = new System.Drawing.Point(9, 8);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(54, 21);
            this.labelItem.TabIndex = 7;
            this.labelItem.Text = "Tarefa:";
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCarregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCarregar.Image")));
            this.buttonCarregar.Location = new System.Drawing.Point(85, 3);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(72, 68);
            this.buttonCarregar.TabIndex = 7;
            this.buttonCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCarregar, "carregar do repositório");
            this.buttonCarregar.UseVisualStyleBackColor = false;
            this.buttonCarregar.Click += new System.EventHandler(this.buttonCarregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonGravar);
            this.panel1.Controls.Add(this.buttonCarregar);
            this.panel1.Controls.Add(this.buttonChecado);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(919, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 78);
            this.panel1.TabIndex = 9;
            // 
            // buttonChecado
            // 
            this.buttonChecado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChecado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChecado.Enabled = false;
            this.buttonChecado.Image = ((System.Drawing.Image)(resources.GetObject("buttonChecado.Image")));
            this.buttonChecado.Location = new System.Drawing.Point(229, 3);
            this.buttonChecado.Name = "buttonChecado";
            this.buttonChecado.Size = new System.Drawing.Size(72, 68);
            this.buttonChecado.TabIndex = 13;
            this.buttonChecado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonChecado, "maracar ítem como checado");
            this.buttonChecado.UseVisualStyleBackColor = false;
            this.buttonChecado.Click += new System.EventHandler(this.buttonChecado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonOrdenar);
            this.panel2.Controls.Add(this.buttonConcluidas);
            this.panel2.Controls.Add(this.buttonEditar);
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonLimparConcluidas);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel2.Location = new System.Drawing.Point(19, 574);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 78);
            this.panel2.TabIndex = 9;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOrdenar.Location = new System.Drawing.Point(268, 3);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(125, 68);
            this.buttonOrdenar.TabIndex = 18;
            this.buttonOrdenar.Text = "Ordenar Prioridade";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonConcluidas
            // 
            this.buttonConcluidas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConcluidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConcluidas.Enabled = false;
            this.buttonConcluidas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonConcluidas.Location = new System.Drawing.Point(530, 3);
            this.buttonConcluidas.Name = "buttonConcluidas";
            this.buttonConcluidas.Size = new System.Drawing.Size(125, 68);
            this.buttonConcluidas.TabIndex = 6;
            this.buttonConcluidas.Text = "Tarefas Concluídas";
            this.buttonConcluidas.UseVisualStyleBackColor = false;
            this.buttonConcluidas.Click += new System.EventHandler(this.buttonConcluidas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonAdicionarItem);
            this.panel3.Controls.Add(this.buttonAtualizarCheckList);
            this.panel3.Controls.Add(this.buttonLimpaItens);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel3.Location = new System.Drawing.Point(723, 574);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 78);
            this.panel3.TabIndex = 9;
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionarItem.Enabled = false;
            this.buttonAdicionarItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAdicionarItem.Location = new System.Drawing.Point(8, 3);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(158, 68);
            this.buttonAdicionarItem.TabIndex = 8;
            this.buttonAdicionarItem.Text = "Adicionar Ítem";
            this.buttonAdicionarItem.UseVisualStyleBackColor = false;
            this.buttonAdicionarItem.Click += new System.EventHandler(this.buttonAdicionarItem_Click);
            // 
            // buttonAtualizarCheckList
            // 
            this.buttonAtualizarCheckList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAtualizarCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtualizarCheckList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtualizarCheckList.Location = new System.Drawing.Point(336, 3);
            this.buttonAtualizarCheckList.Name = "buttonAtualizarCheckList";
            this.buttonAtualizarCheckList.Size = new System.Drawing.Size(158, 68);
            this.buttonAtualizarCheckList.TabIndex = 10;
            this.buttonAtualizarCheckList.Text = "Atualizar";
            this.buttonAtualizarCheckList.UseVisualStyleBackColor = false;
            this.buttonAtualizarCheckList.Click += new System.EventHandler(this.buttonAtualizarCheckList_Click);
            // 
            // buttonLimpaItens
            // 
            this.buttonLimpaItens.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimpaItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpaItens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpaItens.Location = new System.Drawing.Point(172, 3);
            this.buttonLimpaItens.Name = "buttonLimpaItens";
            this.buttonLimpaItens.Size = new System.Drawing.Size(158, 68);
            this.buttonLimpaItens.TabIndex = 9;
            this.buttonLimpaItens.Text = "Limpar Ítens";
            this.buttonLimpaItens.UseVisualStyleBackColor = false;
            this.buttonLimpaItens.Click += new System.EventHandler(this.buttonLimpaItens_Click);
            // 
            // labelItensTarefas
            // 
            this.labelItensTarefas.AutoSize = true;
            this.labelItensTarefas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelItensTarefas.Location = new System.Drawing.Point(720, 154);
            this.labelItensTarefas.Name = "labelItensTarefas";
            this.labelItensTarefas.Size = new System.Drawing.Size(132, 21);
            this.labelItensTarefas.TabIndex = 11;
            this.labelItensTarefas.Text = "Ítens de Tarefas ";
            // 
            // lvTarefa
            // 
            this.lvTarefa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.lvTarefa.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvTarefa.FullRowSelect = true;
            this.lvTarefa.HideSelection = false;
            this.lvTarefa.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvTarefa.Location = new System.Drawing.Point(22, 179);
            this.lvTarefa.MultiSelect = false;
            this.lvTarefa.Name = "lvTarefa";
            this.lvTarefa.Size = new System.Drawing.Size(661, 381);
            this.lvTarefa.TabIndex = 11;
            this.lvTarefa.UseCompatibleStateImageBehavior = false;
            this.lvTarefa.View = System.Windows.Forms.View.Details;
            this.lvTarefa.SelectedIndexChanged += new System.EventHandler(this.lvTarefa_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Criação";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Título";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prioridade";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Porcentagem";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data Conclusão";
            this.columnHeader9.Width = 145;
            // 
            // lvItem
            // 
            this.lvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvItem.FullRowSelect = true;
            this.lvItem.HideSelection = false;
            this.lvItem.Location = new System.Drawing.Point(723, 179);
            this.lvItem.Name = "lvItem";
            this.lvItem.Size = new System.Drawing.Size(509, 381);
            this.lvItem.TabIndex = 12;
            this.lvItem.UseCompatibleStateImageBehavior = false;
            this.lvItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ítem";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tarefa";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.Width = 90;
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrioridade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Items.AddRange(new object[] {
            "baixa",
            "normal",
            "alta"});
            this.comboPrioridade.Location = new System.Drawing.Point(12, 103);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(227, 33);
            this.comboPrioridade.TabIndex = 1;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrioridade.Location = new System.Drawing.Point(9, 80);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(82, 21);
            this.labelPrioridade.TabIndex = 16;
            this.labelPrioridade.Text = "Prioridade";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.labelPrioridade);
            this.panel4.Controls.Add(this.textBoxTarefa);
            this.panel4.Controls.Add(this.comboPrioridade);
            this.panel4.Controls.Add(this.buttonAdd);
            this.panel4.Controls.Add(this.labelItem);
            this.panel4.Location = new System.Drawing.Point(19, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 147);
            this.panel4.TabIndex = 17;
            // 
            // panelTarefa
            // 
            this.panelTarefa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTarefa.Location = new System.Drawing.Point(0, 0);
            this.panelTarefa.Name = "panelTarefa";
            this.panelTarefa.Size = new System.Drawing.Size(1250, 666);
            this.panelTarefa.TabIndex = 18;
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 666);
            this.Controls.Add(this.lvItem);
            this.Controls.Add(this.lvTarefa);
            this.Controls.Add(this.labelItensTarefas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Tarefa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTarefa_FormClosing);
            this.Load += new System.EventHandler(this.FormTarefa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonLimparConcluidas;
        private System.Windows.Forms.TextBox textBoxTarefa;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAdicionarItem;
        private System.Windows.Forms.Button buttonLimpaItens;
        private System.Windows.Forms.Label labelItensTarefas;
        private System.Windows.Forms.Button buttonAtualizarCheckList;
        private System.Windows.Forms.Button buttonChecado;
        private System.Windows.Forms.ListView lvTarefa;
        private System.Windows.Forms.ListView lvItem;
        private System.Windows.Forms.ComboBox comboPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonConcluidas;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Panel panelTarefa;
    }
}
