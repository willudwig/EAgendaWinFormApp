using ControleTarefas.Dominio;
using ControleTarefas.Infra.Arquivo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace Cadastro.WinFormsApp
{
    public partial class FormCompromisso : Form
    {
        int count = 0;
        const string diretorioContato = @"C:\Temp\E-Agenda\Contato.json";
        const string diretorioCompromisso = @"C:\Temp\E-Agenda\Compromisso.json";
        List<Compromisso> compsEliminados;
        RepositorioEmArquivo repoCompromisso;
        Compromisso compSelecionado;
        public FormPrincipal fPrincipal;
        List<Compromisso> compromissos;
        List<Contato> contatos;

        public FormCompromisso()
        {
            InitializeComponent();
            repoCompromisso = new();
            compsEliminados = new();
            compromissos = new();
        }

        #region Não Eventos

        private void AdicionarTextosListViewComprisso(Compromisso c)
        {
            string[] dados = new string[7];
            dados[0] = c.numero.ToString();
            dados[1] = c.assunto;
            dados[2] = c.local;
            dados[3] = c.dataInicio;
            dados[4] = c.horaInicio;
            dados[5] = c.contato.nome;
            dados[6] = c.dataFim;

            ListViewItem lvi = new(dados);
            lvFuturos.Items.Add(lvi);
        }
        private void AdicionarCompromissosHojeMenuPrincipal()
        {
        //    fPrincipal.compsHoje = compromissos.FindAll(c => Convert.ToDateTime(c.dataInicio).Equals(DateTime.Today)).ToList();
        }
        private Contato AdicionarContatoAoCompromisso()
        {
            foreach (Contato c in contatos)
            {
                if(c.nome == cbContato.Text)
                    return c;
            }

            return null;
        }
        private void VincularContato()
        {
            contatos = repoCompromisso.CarregarArquivoContato(diretorioContato);

            if (contatos == null)
            {
                contatos = new();
                RegistroRefresh();
                return;
            }
            else
                RegistroRefresh();

            for (int i = 0; i < contatos.Count; i++)
            {
               cbContato.Items.Add(contatos[i].nome);
            }
    
        }
        private bool Validar()
        {
            if (string.IsNullOrEmpty(tbAssunto.Text)) 
            {
                MessageBox.Show("O assunto não pode ser vazio", "Aviso");
                tbAssunto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbLocal.Text))
            {
                MessageBox.Show("O local não pode ser vazio", "Aviso");
                tbAssunto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(lvFuturos.Columns[3].Text))
            {
                MessageBox.Show("A data não pode ser vazia", "Aviso");
                return false;
            }

            DateTime dt = Convert.ToDateTime(dtpData.Text);
            if (dt < DateTime.Today)
            {
                MessageBox.Show("A data não pode ser anterior a hoje", "Aviso");
                return false;
            }

            dt = Convert.ToDateTime(tbHora.Text);
            if (dt < DateTime.Today)
            {
                MessageBox.Show("A hora não pode ser anterior à hora atual", "Aviso");
                return false;
            }

            if (string.IsNullOrEmpty(cbContato.Text))
            {
                MessageBox.Show("Deve haver um contato", "Aviso");
                return false;
            } 

            return true;
        }
        private void LimparTextBoxesCompromisso()
        {
            tbAssunto.Clear();
            tbLocal.Clear();
            cbContato.Text = "";
            dtpData.Text = DateTime.Now.ToString();
            tbHora.Clear();
        }
        private void DesabilitarModoEdicao()
        {
            pnModoEdicao.Visible = false;

            tbAssunto.Font = new Font(this.Font, FontStyle.Regular);
            tbAssunto.BackColor = Color.White;

            tbLocal.Font = new Font(this.Font, FontStyle.Regular);
            tbLocal.BackColor = Color.White;

            cbContato.Font = new Font(this.Font, FontStyle.Regular);
            cbContato.BackColor = Color.White;

            tbHora.Font = new Font(this.Font, FontStyle.Regular);
            tbHora.BackColor = Color.White;

            tbAssunto.Focus();
        }
        private void HabilitarModoEdicao()
        {
            pnModoEdicao.Visible = true;

            tbAssunto.Font = new Font(this.Font, FontStyle.Bold);
            tbAssunto.BackColor = Color.LightCyan;

            tbLocal.Font = new Font(this.Font, FontStyle.Bold);
            tbLocal.BackColor = Color.LightCyan;

            cbContato.Font = new Font(this.Font, FontStyle.Bold);
            cbContato.BackColor = Color.LightCyan;

            tbHora.Font = new Font(this.Font, FontStyle.Bold);
            tbHora.BackColor = Color.LightCyan;
        }
        private void PreencherTextBoxesComSelecionado(Compromisso c)
        {
            tbAssunto.Text = c.assunto;
            tbLocal.Text = c.local;
            cbContato.Text = c.contato.nome;
            dtpData.Text = c.dataInicio;
            tbHora.Text = c.horaInicio;
        }
        private void ReExibirListaFuturos(List<Compromisso> compromissos)
        {
            lvFuturos.Items.Clear();    

            foreach (Compromisso c in compromissos)
            {
                string[] dados = new string[7];
                dados[0] = c.numero.ToString();
                dados[1] = c.assunto;
                dados[2] = c.local;
                dados[3] = c.dataInicio;
                dados[4] = c.horaInicio;
                dados[5] = c.contato.nome;
                dados[6] = c.dataFim;

                ListViewItem lvi = new(dados);
                lvFuturos.Items.Add(lvi);
            }
        }
        private void ExibirEliminadosNaLista()
        {
            lvPassados.Items.Clear();

            foreach (Compromisso c in compsEliminados)
            {
                string[] dados = new string[7];
                dados[0] = c.numero.ToString();
                dados[1] = c.assunto;
                dados[2] = c.local;
                dados[3] = c.dataInicio;
                dados[4] = c.horaInicio;
                dados[5] = c.contato.nome;
                dados[6] = c.dataFim;

                ListViewItem lvi = new(dados);

                lvPassados.Items.Add(lvi);
            }
        }
        private void RegistroRefresh()
        {
            repoCompromisso.FormatarRepositorio();

            foreach (Compromisso t in compromissos)
            {
                repoCompromisso.Inserir(t);
            }
        }
        private void BuscarArquivo()
        {
            compromissos.Clear();

            compromissos = repoCompromisso.CarregarArquivoCompromisso(diretorioCompromisso);

            if (compromissos == null)
            {
                compromissos = new();
                RegistroRefresh();
                count = compromissos.Count;
                return;
            }
            else
            {
                RegistroRefresh();
                count = compromissos.Count;
            }

            ReExibirListaFuturos(compromissos);
        }

        #region Verificações

        private bool VerificarModoEdicaoAtivo()
        {
            if (pnModoEdicao.Visible.Equals(true))
                return true;
            else
                return false;
        }
        private bool VerificarInformacoesExistentes(Compromisso novoCompromisso)
        {
            return compromissos.Exists(c => c.assunto.Equals(novoCompromisso.assunto));
        }
        private bool VerificarItemSelecionado()
        {
            bool n = false;

            try
            {
                foreach (var item in lvFuturos.SelectedItems)
                    n = true;

                if (n == false)
                    MessageBox.Show("Selecione ao menos um ítem na lista", "Aviso");
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }

            return n;
        }

        #endregion

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VerificarModoEdicaoAtivo() == false)
            {
                if (Validar() == true)
                {
                    var contato = AdicionarContatoAoCompromisso();
                    Compromisso novoCompromisso = new(count, tbAssunto.Text, tbLocal.Text, dtpData.Text, tbHora.Text, contato);

                    if (VerificarInformacoesExistentes(novoCompromisso) == false)
                    {
                        compromissos.Add(novoCompromisso);
                        repoCompromisso.Inserir(novoCompromisso);

                        AdicionarTextosListViewComprisso(novoCompromisso);

                        LimparTextBoxesCompromisso();

                        AdicionarCompromissosHojeMenuPrincipal();

                        count++;
                    }
                    else
                    {
                        MessageBox.Show("O assunto já existe", "Aviso");
                        return;
                    }
                }
                else
                    return;
            }
            else
            {
                // conclui edição

                DesabilitarModoEdicao();

                Compromisso novoCompEditado = new(compSelecionado.numero, tbAssunto.Text, tbLocal.Text, dtpData.Text, tbHora.Text, compSelecionado.contato);
                compromissos.Insert(compSelecionado.numero, novoCompEditado);
                compromissos.Remove(compSelecionado);
                repoCompromisso.Editar(compSelecionado.numero, novoCompEditado);

                ReExibirListaFuturos(compromissos);

                LimparTextBoxesCompromisso();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerificarItemSelecionado() == true)
            {
                compSelecionado = compromissos.Find(c => c.numero.Equals(lvFuturos.SelectedIndices[0]));
                HabilitarModoEdicao();
                PreencherTextBoxesComSelecionado(compSelecionado);
            }
            else
                return;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (VerificarItemSelecionado() == true)
            {
                compromissos.RemoveAt(lvFuturos.SelectedIndices[0]);
                repoCompromisso.Excluir(lvFuturos.SelectedIndices[0]);
                lvFuturos.Items.RemoveAt(lvFuturos.SelectedIndices[0]);
            }
            else
                return;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer mesmo limpar a Lista de Compromissos?", "Limpar Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                lvFuturos.Items.Clear();
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            FiltroPeriodoForm janelaFiltro = new();
            janelaFiltro.ShowDialog();

            List<Compromisso> filtrados = compromissos.FindAll(c => Convert.ToDateTime(c.dataInicio) >= Convert.ToDateTime(janelaFiltro.de) && Convert.ToDateTime(c.dataInicio) <= Convert.ToDateTime(janelaFiltro.ate)).ToList();

            ReExibirListaFuturos(filtrados);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ReExibirListaFuturos(compromissos);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            repoCompromisso.GravarArquivo();

            MessageBox.Show("Repositorio gravado com sucesso", "Salvar em Arquivo", MessageBoxButtons.OK);
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            if (VerificarItemSelecionado() == true)
            {
                Compromisso compSelecionado = compromissos[lvFuturos.SelectedIndices[0]];

                compSelecionado.dataFim = DateTime.Now.ToString("g");

                if (Convert.ToDateTime(compSelecionado.dataInicio) > Convert.ToDateTime(compSelecionado.dataFim))
                {
                    MessageBox.Show("Não pode concluir antes da data registrada", "Aviso");
                    return;
                }

                compromissos.Insert(compSelecionado.numero, compSelecionado);
                compromissos.RemoveAt(lvFuturos.SelectedIndices[0]);
                repoCompromisso.Editar(compSelecionado.numero, compSelecionado);

                compsEliminados.Add(compSelecionado);

                ReExibirListaFuturos(compromissos);
            }
            else
                return;
        }

        private void btnLimparTerminadas_Click(object sender, EventArgs e)
        {
            List<Compromisso> naoEliminados = compromissos.FindAll(c => c.dataFim == null).ToList();

            ReExibirListaFuturos(naoEliminados);
        }

        private void btnPassados_Click(object sender, EventArgs e)
        {
            btnFuturos.BackColor = SystemColors.ButtonHighlight;
            btnPassados.BackColor = SystemColors.ActiveCaption;
            lvFuturos.Visible = false;
            lvPassados.Visible = true;
            pnPassados.Visible = true;

            ExibirEliminadosNaLista();
        }

        private void btnExclPassados_Click(object sender, EventArgs e)
        {
            lvPassados.Items.RemoveAt(lvPassados.SelectedIndices[0]);
        }

        private void btnLimpaPassados_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar todos os compromissos terminados?", "Excluir Compromissos Terminados", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                lvPassados.Items.Clear();

                for (int i = compromissos.Count - 1; i >= 0; i--)
                {
                    if (compromissos[i].dataFim != null)
                    {
                        compromissos.Remove(compromissos[i]);
                        repoCompromisso.Excluir(i);
                    }
                }
            }

            compsEliminados.Clear();
        }

        private void btnFuturos_Click(object sender, EventArgs e)
        {
            btnFuturos.BackColor = SystemColors.ActiveCaption;
            btnPassados.BackColor = SystemColors.ButtonHighlight;
            lvFuturos.Visible = true;
            lvPassados.Visible = false;
            pnPassados.Visible = false;

            ReExibirListaFuturos(compromissos);
        }

        private void FormCompromisso_Load(object sender, EventArgs e)
        {
            VincularContato();
            BuscarArquivo();
        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ao carregar as informações anteriores não salvas serão perdidas. Deseja Continuar?", "Carregar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                BuscarArquivo();

            else
                return;

        }

        private void FormCompromisso_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoCompromisso.GravarArquivo();
        }

        private void tbnAddContato_Click(object sender, EventArgs e)
        {
            FormContato fContato = new();
            fContato.ShowDialog();
        }
    }
}
