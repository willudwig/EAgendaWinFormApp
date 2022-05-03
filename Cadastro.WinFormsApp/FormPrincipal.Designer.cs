namespace Cadastro.WinFormsApp
{
    partial class FormPrincipal
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
            System.Windows.Forms.RichTextBox rtHoje;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.buttonTarefa = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbHoje = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNota = new System.Windows.Forms.Label();
            rtHoje = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtHoje
            // 
            rtHoje.BackColor = System.Drawing.SystemColors.HighlightText;
            rtHoje.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtHoje.Location = new System.Drawing.Point(7, 361);
            rtHoje.Name = "rtHoje";
            rtHoje.Size = new System.Drawing.Size(596, 439);
            rtHoje.TabIndex = 7;
            rtHoje.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContato);
            this.panel1.Controls.Add(this.btnCompromisso);
            this.panel1.Controls.Add(this.buttonTarefa);
            this.panel1.Location = new System.Drawing.Point(5, 806);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 99);
            this.panel1.TabIndex = 0;
            // 
            // btnContato
            // 
            this.btnContato.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContato.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContato.Location = new System.Drawing.Point(604, 1);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(300, 94);
            this.btnContato.TabIndex = 4;
            this.btnContato.Text = "CONTATO";
            this.btnContato.UseVisualStyleBackColor = false;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCompromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompromisso.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompromisso.Location = new System.Drawing.Point(302, 1);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(300, 94);
            this.btnCompromisso.TabIndex = 3;
            this.btnCompromisso.Text = "COMPROMISSO";
            this.btnCompromisso.UseVisualStyleBackColor = false;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // buttonTarefa
            // 
            this.buttonTarefa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTarefa.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTarefa.Location = new System.Drawing.Point(0, 1);
            this.buttonTarefa.Name = "buttonTarefa";
            this.buttonTarefa.Size = new System.Drawing.Size(300, 94);
            this.buttonTarefa.TabIndex = 2;
            this.buttonTarefa.Text = "TAREFA";
            this.buttonTarefa.UseVisualStyleBackColor = false;
            this.buttonTarefa.Click += new System.EventHandler(this.buttonTarefa_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(609, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 439);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 271);
            this.panel2.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lbTitulo.Image")));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.Location = new System.Drawing.Point(75, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(743, 255);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Agenda Eletrônica";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHoje
            // 
            this.lbHoje.BackColor = System.Drawing.Color.Transparent;
            this.lbHoje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHoje.Location = new System.Drawing.Point(593, 13);
            this.lbHoje.Name = "lbHoje";
            this.lbHoje.Size = new System.Drawing.Size(302, 42);
            this.lbHoje.TabIndex = 4;
            this.lbHoje.Text = "Compromissos para Hoje";
            this.lbHoje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbNota);
            this.panel3.Controls.Add(this.lbHoje);
            this.panel3.Location = new System.Drawing.Point(7, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 70);
            this.panel3.TabIndex = 5;
            // 
            // lbNota
            // 
            this.lbNota.BackColor = System.Drawing.Color.Transparent;
            this.lbNota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNota.Location = new System.Drawing.Point(-4, 13);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(602, 42);
            this.lbNota.TabIndex = 5;
            this.lbNota.Text = "Nota Rápida";
            this.lbNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(918, 907);
            this.Controls.Add(rtHoje);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Agenda";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTarefa;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbHoje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNota;
    }
}