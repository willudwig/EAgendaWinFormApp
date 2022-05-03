using ControleTarefas.Dominio;
using System;
using System.Collections.Generic;


namespace ControleTarefas.Infra.Arquivo
{
    public class RepositorioEmArquivo: IRepositorio<EntidadeBase>
    {
        protected List<EntidadeBase> registro = new();
        ArquivoJson arquivo;

        public string Inserir(EntidadeBase objeto)
        {
            if ( Validar(objeto) == true )
            {
                registro.Add(objeto);

                return "válido";
            }
            else
                return "inválido";
        }
        public void Editar(int IdSelecionado, EntidadeBase objeto)
        {
            EntidadeBase obj = registro.Find(r => r.numero.Equals(IdSelecionado));

            registro[registro.IndexOf(obj)] = objeto;
        }
        public void Excluir(int IdSelecionado)
        {
            var x = registro.Find(r => r.numero.Equals(IdSelecionado));

            registro.Remove(x);
        }
        public List<EntidadeBase> SelecionarTodos()
        {
            return registro;
        }
        public EntidadeBase SelecionarObjeto(int IdSelecionado)
        {
            return registro.Find(r => r.numero.Equals(IdSelecionado));
        }
        public bool VerificarIdExistente(int IdSelecionado)
        {
            Object x = registro.Find(r => r.numero.Equals(IdSelecionado));

            if (x != null)
                return true;
            else
                return false;
        }
        public bool VerificarSeRegistroVazio()
        {
            if (registro.Count.Equals(0))
                return true;
            else
                return false;
        }
        public bool Validar(EntidadeBase objeto)
        {
            if (objeto == null)
                return false;

            else
                return true;
        }
        public List<Compromisso> CarregarArquivoCompromisso(string diretorio)
        {
            FormatarRepositorio();

            arquivo = new(registro);

            return arquivo.ObterArquivoCompromisso(diretorio);
        }
        public List<Contato> CarregarArquivoContato(string diretorio)
        {
            FormatarRepositorio();

            arquivo = new(registro);

            return arquivo.ObterArquivoContato(diretorio);
        }
        public List<Tarefa> CarregarArquivoTarefa(string diretorio)
        {
            FormatarRepositorio();

            arquivo = new(registro);

            return arquivo.ObterArquivoTarefa(diretorio);
        }
        public bool GravarArquivo()
        {
            if (registro.Count.Equals(0))
                return false;
            else
            {
                arquivo = new(registro);
                arquivo.GuardarArquivo();
                return true;
            }
        }
        public List<EntidadeBase> ObterArquivoGravado(string diretorio)
        {
            throw new NotImplementedException();
        }
        public void FormatarRepositorio()
        {
            registro.Clear();
        }
    }
}
