using System;
using System.Collections.Generic;

namespace ControleTarefas.Dominio.Interfaces
{
    public interface ISerializador
    {
        List<EntidadeBase> ObterArquivo(string diretorio);
        void GuardarArquivo();
    }
}
