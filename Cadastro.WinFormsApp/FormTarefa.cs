using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using ControleTarefas.Dominio;
using ControleTarefas.Infra.Arquivo;

namespace Cadastro.WinFormsApp
{
    public partial class FormTarefa : Form
    {
        int count = 0;
        int indice = -1;
        
        RepositorioEmArquivo repoTarefa;
        Tarefa novatarefa;
        List<Tarefa> tarefas;
        List<Tarefa> tarefasEliminadas = new();
        const string diretorioTarefa = @"C:\Temp\E-Agenda\Tarefa.json";


        public FormTarefa()
        {
            InitializeComponent();
            repoTarefa = new();
            tarefas = new();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            repoTarefa.GravarArquivo();

            MessageBox.Show("Inserido no repositório com sucesso!", "Salvo");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (lvTarefa.SelectedItems == null)
            {
                MessageBox.Show("Selecione ao menos uma tarefa", "Aviso");
                return;
            }

            var tarefaAserRemovida = tarefas.Find(t => t.numero.Equals(lvTarefa.SelectedIndices[0]));

            tarefas.Remove(tarefaAserRemovida);

            repoTarefa.Excluir(tarefaAserRemovida.numero);

            lvTarefa.Items.Remove(lvTarefa.SelectedItems[0]);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotaoAtualizarCheckList();

            EditForm editForm = new();

            editForm.ShowDialog();

            indice = lvTarefa.SelectedIndices[0];

            if (indice == -1)
            {
                MessageBox.Show("Selecione ao menos um ítem na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tarefa tarefaAserSubstituida = tarefas[indice];

            Tarefa novaTarefaEditada = new(tarefaAserSubstituida.numero, editForm.textItem, editForm.textPrioridade);

            #region dados tarefaEditada
            novaTarefaEditada.dataCriacao = tarefaAserSubstituida.dataCriacao;
            novaTarefaEditada.porcentagem = tarefaAserSubstituida.porcentagem;
            novaTarefaEditada.listaDeItens = tarefaAserSubstituida.listaDeItens;
            novaTarefaEditada.dataConclusao = tarefaAserSubstituida.dataConclusao;
            #endregion

            lvTarefa.Items.RemoveAt(indice);
            InserirEditadoNaListView(indice, novaTarefaEditada);

            repoTarefa.Editar(indice, novaTarefaEditada);

            tarefas.Remove(tarefaAserSubstituida);
            tarefas.Insert(indice, novaTarefaEditada);
        }

        private void textBoxItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxTarefa.Text != null)
                {
                    AdicionarTarefaNaLista();
                }
                else
                    return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdicionarTarefaNaLista();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            EliminarTarefasConcluidas();
            AtualizarListViewItem(tarefasEliminadas);
   
            textBoxTarefa.Clear();
            textBoxTarefa.Focus();
            count = 0;

            ReExibirTarefasNoListView();

            DesabilitarBotaoAddItem();
        }

        private void listViewTarefa_Click(object sender, EventArgs e)
        {
            indice = lvTarefa.SelectedIndices[0];

            if (lvTarefa.Items.Count == indice)
                indice += 1;
        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ao carregar as informações anteriores não salvas serão perdidas. Deseja Continuar?", "Carregar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                BuscarArquivo();

            else
                return;
        }

        private void listBoxTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotaoAddItem();
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvTarefa.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Selecione ao menos uma tarefa", "Aviso");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }

            if (AdicionarNovoItemNaTarefa() == false)
                return;

            HabilitarBotaoChecado();
        }

        private void buttonChecado_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                foreach (var item in lvItem.SelectedItems)
                {
                    n = 1;
                }

                if (n == 0)
                {
                    MessageBox.Show("Selecione ao menos um ítem", "Aviso");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }

            MarcarItemComoChecado();

            CalcularPercentualConclusao(tarefas);

            SetarDataConclusaoTarefa();

            ReExibirTarefasNoListView();

            if (VerificarTarefaCompleta())
            {
                HabilitarBotaoLimpaConluidas();
                HabilitarBotaoTarefasConcluidas();
            }

            ReExibirItensDaTarefa();
        }

        private void buttonAtualizarCheckList_Click(object sender, EventArgs e)
        {
            ReExibirItensDaTarefa();
        }

        private void FormTarefa_Load(object sender, EventArgs e)
        {
            lvTarefa.Items.Clear();
            comboPrioridade.SelectedIndex = 0;
            BuscarArquivo();

            if (lvItem.Items.Count != 0)
                buttonChecado.Enabled = true;
        }

        private void lvTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotaoAddItem();
        }

        private void buttonConcluidas_Click(object sender, EventArgs e)
        {
            TarefasConcluidas tc = new(tarefasEliminadas);

            tc.ShowDialog();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            OrdenadorPrioridade();
        }

        private void FormTarefa_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoTarefa.GravarArquivo();
        }

        private void buttonLimpaItens_Click(object sender, EventArgs e)
        {
            if (lvItem.Items.Count != 0)
                lvItem.Items.Clear();

            else
                return;
        }


        #region Não eventos

        private void BuscarArquivo()
        {
            tarefas.Clear();

            tarefas = repoTarefa.CarregarArquivoTarefa(diretorioTarefa);

            if (tarefas == null)
            {
                tarefas = new();
                RegistroRefresh();
                count = tarefas.Count;
                return;
            }
            else
            {
                RegistroRefresh();
                count = tarefas.Count;
            }

            ReExibirTarefasNoListView();
            ReExibirItensDaTarefa();
        }

        private void RegistroRefresh()
        {
            repoTarefa.FormatarRepositorio();

            foreach(Tarefa t in tarefas)
            {
                repoTarefa.Inserir(t);
            }
        }

        private void InserirEditadoNaListView(int indice, Tarefa novaTarefaEditada)
        {
            string[] novo = new string[6];
            novo[0] = novaTarefaEditada.numero.ToString();
            novo[1] = novaTarefaEditada.dataCriacao;
            novo[2] = novaTarefaEditada.titulo;
            novo[3] = novaTarefaEditada.prioridade;
            novo[4] = novaTarefaEditada.porcentagem;
            novo[5] = novaTarefaEditada.dataConclusao;

            ListViewItem li = new(novo);

            lvTarefa.Items.Insert(indice, li);
        }

        private void MarcarItemComoChecado()
        {
            foreach (Tarefa t in tarefas)
            {
                foreach (Item item in t.listaDeItens)
                {
                    if (item.status != "checado")
                    {
                        if (item.descricao.Contains(lvItem.SelectedItems[0].Text))
                            item.status = "Checado";
                    }
                    else
                        continue;
                }
            }
        }

        private void AdicionarTarefaNaLista()
        {
            if (textBoxTarefa.Text == null)
                return;

            novatarefa = new(count, textBoxTarefa.Text, comboPrioridade.Text);

            if (VerificarNomeExistente(textBoxTarefa.Text) == true)
            {
                MessageBox.Show("Esta tarefa já existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxTarefa.Text != "")
            {
                tarefas.Add(novatarefa);
                repoTarefa.Inserir(novatarefa);
                AlimentarListViewTarefa(novatarefa);
            }
            else
                return;

            textBoxTarefa.Clear();
            textBoxTarefa.Focus();

            count++;
        }

        private void CalcularPercentualConclusao(List<Tarefa> listaTarefas)
        {
            List<Item> itensChecados;

            foreach (Tarefa t in tarefas)
            {
                itensChecados = new();

                foreach (Item item in t.listaDeItens)
                {
                    if (item.status != null)
                    {
                        itensChecados.Add(item);
                    }
                    else
                        continue;
                }

                int totalItensFeitos = itensChecados.Count;
                int todosItensTarefa = t.listaDeItens.Count;

                if (totalItensFeitos == 0)
                    t.porcentagem = "0%";

                else if (todosItensTarefa == 0)
                    return;

                else
                    t.porcentagem = "" + (totalItensFeitos * 100) / todosItensTarefa + "%";
            }
        }

        private void EliminarTarefasConcluidas()
        {
            bool algumaConcluida = VerificarTarefaCompleta();

            if (algumaConcluida)
            {
                tarefasEliminadas = tarefas.FindAll(t => t.porcentagem.Equals("100%"));

                foreach (Tarefa t in tarefasEliminadas)
                {
                    if(tarefas.Contains(t))
                        tarefas.Remove(t);
                }
            }
            else
                return;
        }

        private void ReExibirItensDaTarefa()
        {
            lvItem.Items.Clear();

            string[] itensTarefasRecebidos = new string[3];

            foreach (Tarefa t in tarefas)
            {
                foreach (var item in t.listaDeItens)
                {
                    itensTarefasRecebidos[0] = item.descricao;
                    itensTarefasRecebidos[1] = t.titulo;
                    itensTarefasRecebidos[2] = item.status;

                    ListViewItem li = new(itensTarefasRecebidos);

                    lvItem.Items.Add(li);
                }
            }
        }

        private void ReExibirTarefasNoListView()
        {
            lvTarefa.Items.Clear();

            string[] TarefasRecebidas = new string[6];

            foreach (Tarefa t in tarefas)
            {
                TarefasRecebidas[0] = t.numero.ToString();
                TarefasRecebidas[1] = t.dataCriacao;
                TarefasRecebidas[2] = t.titulo;
                TarefasRecebidas[3] = t.prioridade;
                TarefasRecebidas[4] = t.porcentagem;
                TarefasRecebidas[5] = t.dataConclusao;

                ListViewItem li = new(TarefasRecebidas);

                lvTarefa.Items.Add(li);
            }

           
        }

        private void AtualizarListViewItem(List<Tarefa> tarefasEliminadas)
        {
            //List<string> itensChecklist = new();
            //List<string> itensChecados = new();
            //List<string> novosItens = new();

            //foreach (string item in lvItem.Items)
            //{
            //    itensChecklist.Add(item);
            //}

            //foreach (string item in lvItem.CheckedItems)
            //{
            //    itensChecados.Add(item);
            //}

            //foreach (Tarefa t in tarefasEliminadas)
            //{
            //    novosItens = itensChecklist.FindAll(i => !i.Contains(t.titulo));
            //}

            //lvItem.Items.Clear();
            
            //foreach (string item in novosItens)
            //{
            //    lvItem.Items.Add(item);
            //}

            //for (int i = 0; i < lvItem.Items.Count; i++)
            //{
            //    for (int j = 0; j < itensChecados.Count; j++)
            //    {
            //        if (lvItem.Items[i].Equals(itensChecados[j]))
            //            lvItem.SetItemCheckState(i, CheckState.Checked);
            //    }
            //}

        }

        private void AlimentarListViewTarefa(Tarefa t)
        {
            string[] dados = new string[6];
            dados[0] = t.numero.ToString();
            dados[1] = t.dataCriacao;
            dados[2] = textBoxTarefa.Text;
            dados[3] = comboPrioridade.Text;
            dados[4] = t.porcentagem;
            dados[5] = t.dataConclusao;

            ListViewItem listView = new ListViewItem(dados);

            lvTarefa.Items.Add(listView);
        }

        private void AlimentarListViewItem(Item novoItem, Tarefa t)
        {
            ListViewItem listView;

            string[] dados = new string[3];
            dados[0] = novoItem.descricao;
            dados[1] = t.titulo;
            dados[2] = novoItem.status;

            listView = new(dados);
            lvItem.Items.Add(listView);
        }

        private bool AdicionarNovoItemNaTarefa()
        {
            Tarefa tarefaSelecionada = tarefas[lvTarefa.SelectedIndices[0]];

            ItensForm janelaItens = new(tarefaSelecionada);
            janelaItens.ShowDialog();

            Item novoItem = new(janelaItens.textoNovoItem);

            if (janelaItens.textoNovoItem == "vazio")
                return false;

            if (janelaItens.DialogResult == DialogResult.OK)
            {
                if (VerificarNomeExistente(novoItem.descricao) == true)
                {
                    MessageBox.Show("Este ítem já existe", "Aviso");
                    return false;
                }
                else
                {
                    tarefaSelecionada.listaDeItens.Add(novoItem);

                    tarefas[tarefaSelecionada.numero] = tarefaSelecionada;

                    AlimentarListViewItem(novoItem, tarefaSelecionada);
                }
            }
            else
                return
                    false;

            return true;
        }

        private void SetarDataConclusaoTarefa()
        {
            foreach  (Tarefa t in tarefas)
            {
                if (t.porcentagem == "100%")
                {
                    t.dataConclusao = DateTime.Now.ToString("d");
                    tarefasEliminadas.Add(t);
                }
            }
        }

        private void OrdenadorPrioridade()
        {
            List<Tarefa> altas = tarefas.FindAll(t => t.prioridade.Equals("alta"));
            List<Tarefa> normais = tarefas.FindAll(t => t.prioridade.Equals("normal"));
            List<Tarefa> baixas = tarefas.FindAll(t => t.prioridade.Equals("baixa"));

            tarefas.Clear();

            tarefas.AddRange(altas.ToArray());
            tarefas.AddRange(normais.ToArray());
            tarefas.AddRange(baixas.ToArray());

            ReExibirTarefasNoListView();
        }

        #endregion

        #region Verificações

        private bool VerificarNomeExistente(string texto)
        {
            foreach (Tarefa t in tarefas)
            {
                if (t.titulo.Equals(texto))
                {
                    return true;
                }
            }

            for (int i = 0; i < lvItem.Items.Count; i++)
            {
                if (lvItem.Items[i].Text == texto)
                {
                    return true;
                }
            }
            

            return false;
        }
        private bool VerificarTarefaCompleta()
        {
           return tarefas.Exists(t => t.porcentagem.Contains("100%"));
        }

        #endregion

        #region Habilitar/desabilitar

        private void HabilitarBotaoLimpaConluidas()
        {
            buttonLimparConcluidas.Enabled = true;
            buttonLimparConcluidas.ForeColor = Color.Black;
        }
        private void HabilitarBotaoAddItem()
        {
            buttonAdicionarItem.Enabled = true;
            buttonAdicionarItem.ForeColor = Color.Black;
        }
        private void HabilitarBotaoTarefasConcluidas()
        {
            buttonConcluidas.Enabled = true;
            buttonConcluidas.ForeColor = Color.Black;
        }
        private void HabilitarBotaoChecado()
        {
            buttonChecado.Enabled = true;
            buttonChecado.ForeColor = Color.Black;
        }
        private void HabilitarBotaoAtualizarCheckList()
        {
            buttonAtualizarCheckList.Enabled = true;
            buttonAtualizarCheckList.ForeColor = Color.Black;
        }
        private void DesabilitarBotaoAddItem()
        {
            buttonAdicionarItem.Enabled = false;
            buttonAdicionarItem.ForeColor = Color.Gray;
        }


        #endregion
    }
}
