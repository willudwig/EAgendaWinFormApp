using ControleTarefas.Dominio;
using ControleTarefas.Infra.Arquivo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cadastro.WinFormsApp
{
    public partial class FormPrincipal : Form
    {
        FormTarefa fTarefa;
        FormCompromisso fCompromisso;
        FormContato fContato;
        public List<Compromisso> compsHoje;
        RepositorioEmArquivo repoCompromisso;
        const string diretorioCompromisso = @"C:\Temp\E-Agenda\Compromisso.json";

        public FormPrincipal()

        {
            InitializeComponent();
            fTarefa = new();
            fCompromisso = new();
            fCompromisso.fPrincipal = this;
            compsHoje = new();
            fContato = new();
            repoCompromisso = new();
            ExibirCompsParaHoje();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {
            if (fTarefa.IsDisposed == true)
            {
                fTarefa = new();
                fTarefa.Show();
            }
            else
                fTarefa.Show();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            if (fCompromisso.IsDisposed == true)
            {
                fCompromisso = new();
                fCompromisso.Show();
                fCompromisso.fPrincipal = this;
            }
            else
                fCompromisso.Show();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            if (fContato.IsDisposed == true)
            {
                fContato = new();
                fContato.Show();
            }
            else
                fContato.Show();
        }

        public void ExibirCompsParaHoje() 
        {
            richTextBox1.Clear();

            List<Compromisso> compromissos = repoCompromisso.CarregarArquivoCompromisso(diretorioCompromisso);

            if (compromissos == null)
                return;

            compsHoje = compromissos.FindAll(c => Convert.ToDateTime(c.dataInicio) == DateTime.Today);

            for (int i = 0; i < compsHoje.Count; i++)
            {
                richTextBox1.Text += compsHoje[i].assunto + "\n";
            }
        }
    }
}
