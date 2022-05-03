namespace Cadastro.WinFormsApp
{
    partial class FiltroPeriodoForm
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
            this.tbDe = new System.Windows.Forms.MaskedTextBox();
            this.tbAte = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbate = new System.Windows.Forms.Label();
            this.lbDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDe
            // 
            this.tbDe.Location = new System.Drawing.Point(31, 49);
            this.tbDe.Mask = "00/00/0000";
            this.tbDe.Name = "tbDe";
            this.tbDe.Size = new System.Drawing.Size(150, 31);
            this.tbDe.TabIndex = 0;
            this.tbDe.ValidatingType = typeof(System.DateTime);
            // 
            // tbAte
            // 
            this.tbAte.Location = new System.Drawing.Point(212, 49);
            this.tbAte.Mask = "00/00/0000";
            this.tbAte.Name = "tbAte";
            this.tbAte.Size = new System.Drawing.Size(150, 31);
            this.tbAte.TabIndex = 1;
            this.tbAte.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbate);
            this.panel1.Controls.Add(this.lbDe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAte);
            this.panel1.Controls.Add(this.tbDe);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 113);
            this.panel1.TabIndex = 2;
            // 
            // lbate
            // 
            this.lbate.AutoSize = true;
            this.lbate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbate.Location = new System.Drawing.Point(212, 27);
            this.lbate.Name = "lbate";
            this.lbate.Size = new System.Drawing.Size(33, 21);
            this.lbate.TabIndex = 4;
            this.lbate.Text = "Até";
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDe.Location = new System.Drawing.Point(31, 27);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(29, 21);
            this.lbDe.TabIndex = 3;
            this.lbDe.Text = "De";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(21, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(243, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(183, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FiltroPeriodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 208);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FiltroPeriodoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro por Período";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbDe;
        private System.Windows.Forms.MaskedTextBox tbAte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbate;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}