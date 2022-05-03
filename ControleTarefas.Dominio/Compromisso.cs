using System;

namespace ControleTarefas.Dominio
{
    public class Compromisso : EntidadeBase 
    {
        public string assunto;
        public string local;
        public string dataInicio;
        public string horaInicio;
        public Contato contato;
        public string dataFim;

        public Compromisso(int numero, string assunto, string local, string dataInicio, string horaInicio, Contato contato)
        {
            this.numero = numero;
            this.assunto = assunto;
            this.local = local;
            this.dataInicio = dataInicio;
            this.horaInicio = horaInicio;
            this.contato = contato;
        }
    }
}
