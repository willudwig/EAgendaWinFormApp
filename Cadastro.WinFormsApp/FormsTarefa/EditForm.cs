using System;

using System.Windows.Forms;

namespace Cadastro.WinFormsApp
{
    public partial class EditForm : Form
    {
        public string textItem = "vazio";
        public string textPrioridade = "vazio";

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            comboPrioridade.SelectedIndex = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text != "")
                textItem = tbTitulo.Text;

            if (comboPrioridade.Text != null)
                textPrioridade = comboPrioridade.Text;
        }
    }
}
