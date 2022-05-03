using System;
using System.Collections.Generic;

namespace ControleTarefas.Dominio
{
    public class Tarefa : EntidadeBase 
    {
        public string titulo;
        public List<Item> listaDeItens = new();
        public string porcentagem = "0%";
        public string prioridade;
        public string dataConclusao;
        public String dataCriacao
        {
            get { return DateTime.Now.ToString("d"); }
            set { }
        }

        public Tarefa(int numero, string titulo, string prioridade)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

    }
}
