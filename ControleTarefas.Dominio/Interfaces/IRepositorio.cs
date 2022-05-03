using ControleTarefas.Dominio.Interfaces;
using System;
using System.Collections.Generic;

namespace ControleTarefas.Dominio
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Editar(int IdSelecionado, T objeto);
        void Excluir(int IdSelecionado);
        string Inserir(T objeto);
        T SelecionarObjeto(int IdSelecionado);
        List<T> SelecionarTodos();
        bool VerificarIdExistente(int IdSelecionado);
        bool VerificarSeRegistroVazio();
        public void FormatarRepositorio();
        List<T> ObterArquivoGravado(string diretorio);
    }
}