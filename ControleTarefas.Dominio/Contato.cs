
namespace ControleTarefas.Dominio
{
    public class Contato: EntidadeBase
    {
        public string nome;
        public string email;
        public string telefone;
        public string empresa;
        public string cargo;

        public Contato(int numero, string nome, string email, string telefone, string empresa, string cargo)
        {
            this.numero = numero;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.empresa = empresa;
            this.cargo = cargo;
        }
    }
}
