using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControleTarefas.Dominio;
using ControleTarefas.Infra.Arquivo;

namespace Cadastro.WinFormsApp
{
    public partial class FormContato : Form
    {
        Contato contatoSelecionado;
        int count = 0;
        List<Contato> contatos;
        RepositorioEmArquivo repoContato;
        const string diretorioContato = @"C:\Temp\E-Agenda\Contato.json";
        const string diretorioCompromisso = @"C:\Temp\E-Agenda\Compromisso.json";

        public FormContato()
        {
            InitializeComponent();
            contatos = new();
            repoContato = new();
        }

        # region Não Eventos

        private bool ValidarCadastroContato()
        {
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Campo nome não pode ser vazio", "Aviso");
                tbNome.Focus();
                return false;
            }

            if (tbNome.Text.Length <= 1)
            {
                MessageBox.Show("O nome precisa de pelo menos uma sílaba", "Aviso");
                tbNome.Focus();
                return false;
            }

            EmailAddressAttribute verificaMail = new();
            if (!verificaMail.IsValid(tbMail.Text))
            {
                MessageBox.Show("O e-mail não é válido", "Aviso");
                tbMail.Focus();
                return false;
            }

            if (!tbDDD.Text.Length.Equals(2))
            {
                MessageBox.Show("Campo DDD só aceita 2 números", "Aviso");
                tbDDD.Focus();
                return false;
            }

            if(Regex.IsMatch(tbDDD.Text, "  ^ [0-9]"))
            {
                MessageBox.Show("Campo DDD só aceita números", "Aviso");
                tbDDD.Focus();
                return false;
            }
            
            if(tbTelefone.Text.Length < 8 || tbTelefone.Text.Length > 9)
            {
                MessageBox.Show("O telefone informado não foi aceito (8 ou 9 números)", "Aviso");
                tbTelefone.Focus();
                return false;
            }

            if (Regex.IsMatch(tbTelefone.Text, "  ^ [0-9]"))
            {
                MessageBox.Show("O campo telefone só aceita números", "Aviso");
                tbTelefone.Focus();
                return false;
            }

            return true;
        }
        private void LimparTextBoxesContato()
        {
            tbNome.Clear();
            tbMail.Clear();
            tbDDD.Clear();
            tbTelefone.Clear();
            tbEmpresa.Clear();
            tbCargo.Clear();
            tbNome.Focus();
        }
        private void AdicionarTextosListViewContato(Contato c)
        {
            string[] dados = new string[7];
            dados[0] = c.numero.ToString();
            dados[1] = c.nome;
            dados[2] = c.email;
            dados[3] = c.telefone;
            dados[4] = c.empresa;
            dados[5] = c.cargo;

            ListViewItem lvi = new(dados);
            lvContato.Items.Add(lvi);
        }
        private void PreencherTextBoxesComSelecionado(Contato c)
        {
            tbNome.Text = c.nome;
            tbMail.Text = c.email;
            tbDDD.Text = c.telefone.Substring(1, 2);
            tbTelefone.Text = c.telefone.Substring(5);
            tbEmpresa.Text = c.empresa;
            tbCargo.Text = c.cargo;
        }
        private void ReExibirListaContato(List<Contato> contatos)
        {
            lvContato.Items.Clear();

            foreach (Contato c in contatos)
            {
                string[] dados = new string[7];
                dados[0] = c.numero.ToString();
                dados[1] = c.nome;
                dados[2] = c.email;
                dados[3] = c.telefone;
                dados[4] = c.empresa;
                dados[5] = c.cargo;


                ListViewItem lvi = new(dados);
                lvContato.Items.Add(lvi);
            }
        }
        private void TornaTextBoxesModoEdicao()
        {
            pnModoEdicao.Visible = true;

            tbNome.BackColor = Color.LightCyan;
            tbNome.Font = new Font(this.Font, FontStyle.Bold);

            tbMail.BackColor = Color.LightCyan;
            tbMail.Font = new Font(this.Font, FontStyle.Bold);

            tbDDD.BackColor = Color.LightCyan;
            tbDDD.Font = new Font(this.Font, FontStyle.Bold);

            tbTelefone.BackColor = Color.LightCyan;
            tbTelefone.Font = new Font(this.Font, FontStyle.Bold);

            tbEmpresa.BackColor = Color.LightCyan;
            tbEmpresa.Font = new Font(this.Font, FontStyle.Bold);

            tbCargo.BackColor = Color.LightCyan;
            tbCargo.Font = new Font(this.Font, FontStyle.Bold);
        }
        private void DesabilitarTextBoxesModoEdicao()
        {
            pnModoEdicao.Visible = false;

            tbNome.BackColor = Color.White;
            tbNome.Font = new Font(this.Font, FontStyle.Regular);

            tbMail.BackColor = Color.White;
            tbMail.Font = new Font(this.Font, FontStyle.Regular);

            tbDDD.BackColor = Color.White; 
            tbDDD.Font = new Font(this.Font, FontStyle.Regular);

            tbTelefone.BackColor = Color.White;
            tbTelefone.Font = new Font(this.Font, FontStyle.Regular);

            tbEmpresa.BackColor = Color.White;
            tbEmpresa.Font = new Font(this.Font, FontStyle.Regular);

            tbCargo.BackColor = Color.White;
            tbCargo.Font = new Font(this.Font, FontStyle.Regular);
        }
        private void RegistroRefresh()
        {
            repoContato.FormatarRepositorio();

            foreach (Contato t in contatos)
            {
                repoContato.Inserir(t);
            }
        }
        private void BuscarArquivo()
        {
            if(contatos.Count != 0)
                contatos.Clear();

            contatos = repoContato.CarregarArquivoContato(diretorioContato);

            if (contatos == null)
            {
                contatos = new();
                RegistroRefresh();
                count = contatos.Count;
                return;
            }
            else
            {
                RegistroRefresh();
                count = contatos.Count;
            }


            ReExibirListaContato(contatos);
         }

        #region Verificações

        private bool VerificarModoEdicaoAtivo()
        {
            if (pnModoEdicao.Visible.Equals(true))
                return true;
            else
                return false;
        }
        private bool VerificarInformacoesExistentes(Contato novoContato)
        {
            if (contatos == null)
                return false;

            bool verifica = contatos.Exists(c => c.nome.Equals(novoContato.nome) || c.email.Equals(novoContato.email) || c.telefone.Equals(novoContato.telefone));

            return verifica;
        }
        private bool VerificarContatoVinculadoCompromisso()
        {
            bool n = false;

            List<Compromisso> comps = repoContato.CarregarArquivoCompromisso(diretorioCompromisso);

            var contatoSelecionado = contatos[lvContato.SelectedIndices[0]];

            if (comps == null)
                return false;

            return comps.Exists(c => c.contato.nome.Equals(contatoSelecionado.nome));
        }
        private bool VerificarItemSelecionado()
        {
            bool n = false;

            try
            {
                foreach(var item in lvContato.SelectedItems)
                    n = true;

                if(n == false)
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

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            if (VerificarModoEdicaoAtivo() == false)
            {
                if (ValidarCadastroContato() == true)
                {
                    Contato novoContato = new(count, tbNome.Text, tbMail.Text, $"({tbDDD.Text}) {tbTelefone.Text}", tbEmpresa.Text, tbCargo.Text);

                    if (VerificarInformacoesExistentes(novoContato) == false)
                    {
                        contatos.Add(novoContato);
                        repoContato.Inserir(novoContato);

                        AdicionarTextosListViewContato(novoContato);

                        LimparTextBoxesContato();

                        count++;
                    }
                    else
                    {
                        MessageBox.Show("Nome, E-Mail ou Telefone já existente", "Aviso");
                        return;
                    }
                }
                else
                    return;
            }
            else 
            { 
                //conclui edição

                Contato novoContatoEditado = new(contatoSelecionado.numero, tbNome.Text, tbMail.Text, $"({tbDDD.Text}) {tbTelefone.Text}", tbEmpresa.Text, tbCargo.Text);

                contatos.Insert(contatoSelecionado.numero, novoContatoEditado);
                contatos.Remove(contatoSelecionado);
                repoContato.Editar(contatoSelecionado.numero, novoContatoEditado);

                ReExibirListaContato(contatos);

                DesabilitarTextBoxesModoEdicao();

                LimparTextBoxesContato();
            }
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            lvContato.Items.Clear();
            BuscarArquivo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Quer mesmo limpar a Lista de Contatos?", "Limpar Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
               lvContato.Items.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ( VerificarItemSelecionado() == true )
            {
                if (VerificarContatoVinculadoCompromisso() == true)
                {
                    MessageBox.Show("O contato selecionado tem vínculo com um compromisso e não pode ser excluído", "Aviso");
                    return;
                }

                else
                {
                    contatos.RemoveAt(lvContato.SelectedIndices[0]);
                    repoContato.Excluir(lvContato.SelectedIndices[0]);
                    lvContato.Items.Remove(lvContato.SelectedItems[0]);
                }
            }
            else
                return;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ( VerificarItemSelecionado() == true )
            {
                contatoSelecionado = contatos[lvContato.SelectedIndices[0]];
                TornaTextBoxesModoEdicao();
                PreencherTextBoxesComSelecionado(contatoSelecionado);
            }
            else
                return;

        }

        private void Agrupar_Click(object sender, EventArgs e)
        {
            List<Contato> agrupados = contatos.OrderBy(c => c.cargo).ToList();

            ReExibirListaContato(agrupados);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            repoContato.GravarArquivo();

            MessageBox.Show("Repositorio gravado com sucesso", "Salvar em Arquivo", MessageBoxButtons.OK);
        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ao carregar as informações anteriores não salvas serão perdidas. Deseja Continuar?", "Carregar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                BuscarArquivo();

            else
                return;
        }

        private void FormContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoContato.GravarArquivo();
        }

    }
}
