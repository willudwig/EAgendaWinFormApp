using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Dominio
{
    public class Item
    {
        public string descricao, status;

        public Item(string descricao)
        {
            this.descricao = descricao;
        }
    }
}
