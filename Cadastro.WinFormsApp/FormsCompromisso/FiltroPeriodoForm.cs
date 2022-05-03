using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.WinFormsApp
{
    public partial class FiltroPeriodoForm : Form
    {
        public string de, ate;
        public FiltroPeriodoForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            de = tbDe.Text;
            ate = tbAte.Text;
            this.Close();
        }
    }
}
