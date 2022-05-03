using ControleTarefas.Dominio;
using System;
using System.Windows.Forms;

namespace Cadastro.WinFormsApp
{
    public partial class ItensForm : Form
    {
        Tarefa tarefa;
        public string textoNovoItem = "vazio";
        public string textoTarefa;
        public ItensForm(Tarefa t)
        {
            InitializeComponent();
            tarefa = t;
        }

        private void ItensForm_Load(object sender, EventArgs e)
        {
            textBoxNovoItem.Focus();
            textBoxTarefaSelec.Text = tarefa.titulo;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            VerificaCampoVazio();
        }

        private void VerificaCampoVazio()
        {
            if (textBoxNovoItem.Text == "")
            {
                MessageBox.Show("Não pode ser vazio", "Aviso");
            }
            else
            {
                textoNovoItem = textBoxNovoItem.Text;
                textoTarefa = textBoxTarefaSelec.Text;
            }

        }


    }
}
