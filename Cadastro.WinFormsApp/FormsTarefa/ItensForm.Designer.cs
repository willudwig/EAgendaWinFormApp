namespace Cadastro.WinFormsApp
{
    partial class ItensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItensForm));
            this.LabelTarefa = new System.Windows.Forms.Label();
            this.buttonMais = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNovoItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarefaSelec = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTarefa
            // 
            this.LabelTarefa.AutoSize = true;
            this.LabelTarefa.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTarefa.Location = new System.Drawing.Point(11, 13);
            this.LabelTarefa.Name = "LabelTarefa";
            this.LabelTarefa.Size = new System.Drawing.Size(51, 21);
            this.LabelTarefa.TabIndex = 0;
            this.LabelTarefa.Text = "Tarefa";
            // 
            // buttonMais
            // 
            this.buttonMais.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMais.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMais.Image = ((System.Drawing.Image)(resources.GetObject("buttonMais.Image")));
            this.buttonMais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMais.Location = new System.Drawing.Point(64, 3);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(130, 53);
            this.buttonMais.TabIndex = 1;
            this.buttonMais.Text = "Adicionar";
            this.buttonMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMais.UseVisualStyleBackColor = false;
            this.buttonMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonMais);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 56);
            this.panel1.TabIndex = 5;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(211, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(130, 53);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Cancelar";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNovoItem
            // 
            this.textBoxNovoItem.Location = new System.Drawing.Point(15, 114);
            this.textBoxNovoItem.Name = "textBoxNovoItem";
            this.textBoxNovoItem.Size = new System.Drawing.Size(374, 31);
            this.textBoxNovoItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Novo Ítem";
            // 
            // textBoxTarefaSelec
            // 
            this.textBoxTarefaSelec.Enabled = false;
            this.textBoxTarefaSelec.Location = new System.Drawing.Point(15, 37);
            this.textBoxTarefaSelec.Name = "textBoxTarefaSelec";
            this.textBoxTarefaSelec.Size = new System.Drawing.Size(374, 31);
            this.textBoxTarefaSelec.TabIndex = 8;
            // 
            // ItensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 226);
            this.Controls.Add(this.textBoxTarefaSelec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNovoItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItensForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ítens";
            this.Load += new System.EventHandler(this.ItensForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTarefa;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNovoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarefaSelec;
    }
}