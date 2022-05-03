using ControleTarefas.Dominio;
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
    public partial class TarefasConcluidas : Form
    {
        List<Tarefa> tarefasConcluidas = new();
        public TarefasConcluidas(List<Tarefa> concluidas)
        {
            InitializeComponent();
            tarefasConcluidas = concluidas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvConcluidas.Items.Clear();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (lvConcluidas.SelectedItems == null)
            {
                MessageBox.Show("Selecione ao menos uma tarefa", "Aviso");
                return;
            }

            lvConcluidas.Items.Remove(lvConcluidas.SelectedItems[0]);
        }

        private void TarefasConcluidas_Load(object sender, EventArgs e)
        {
            lvConcluidas.Items.Clear();
            
            foreach (Tarefa t in tarefasConcluidas)
            {
                string[] dados = new string[5];
                dados[0] = t.dataCriacao;
                dados[1] = t.titulo;
                dados[2] = t.prioridade;
                dados[3] = t.porcentagem;
                dados[4] = t.dataConclusao;

                ListViewItem li = new(dados);

                lvConcluidas.Items.Add(li);
            }
        }
    }
}
