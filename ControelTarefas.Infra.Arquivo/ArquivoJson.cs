using ControleTarefas.Dominio;
using ControleTarefas.Dominio.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace ControleTarefas.Infra.Arquivo
{
    public class ArquivoJson : ISerializador
    {
        readonly List<EntidadeBase> _entidade;
        string _diretorio;
        string _tipoEntidade;


        public ArquivoJson(List<EntidadeBase> entidade)
        {
            _entidade = entidade;
            _tipoEntidade = ObterTipoEntidade();
            _diretorio = ObterDiretorio();
        }

        public void GuardarArquivo()
        {
            try
            {
                string folder = @"C:\Temp\E-Agenda\";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    _diretorio = ObterDiretorio();
                }

                var escreverNoArquivo = JsonConvert.SerializeObject(_entidade, Formatting.Indented);

                using (var writer = new StreamWriter(_diretorio))
                {
                    writer.Write(escreverNoArquivo);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Contato> ObterArquivoContato(string diretorio)
        {
            try
            {
                string pegaArquivo;
                string folder = @"C:\Temp\E-Agenda\";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    _diretorio = ObterDiretorio();
                }

                using (var reader = new StreamReader(diretorio))
                {
                    pegaArquivo = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Contato>>(pegaArquivo);
            }
            catch (System.IO.FileNotFoundException)
            {
                return null;
            }
        }
        public List<Compromisso> ObterArquivoCompromisso(string diretorio)
        {
            try
            {
                string pegaArquivo;
                string folder = @"C:\Temp\E-Agenda\";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    _diretorio = ObterDiretorio();
                }

                using (var reader = new StreamReader(diretorio))
                {
                    pegaArquivo = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Compromisso>>(pegaArquivo);
            }
            catch (System.IO.FileNotFoundException)
            {
                return null;
            }
        }
        public List<Tarefa> ObterArquivoTarefa(string diretorio)
        {
            try
            {
                string pegaArquivo;
                string folder = @"C:\Temp\E-Agenda\";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    _diretorio = ObterDiretorio();
                }

                using (var reader = new StreamReader(diretorio))
                {
                    pegaArquivo = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Tarefa>>(pegaArquivo);
            }
            catch (System.IO.FileNotFoundException)
            {
                
                return null;
            }
        }
        public List<EntidadeBase> ObterArquivo(string diretorio)
        {
            throw new NotImplementedException();
        }

        #region privados
        private string ObterDiretorio()
        {
            return @"C:\Temp\E-Agenda\" + _tipoEntidade + @".json";
        }
        private string ObterTipoEntidade()
        {
            if (_entidade.Count == 0)
                return "vazio";

            else
                return _entidade[0].GetType().Name;
        }

        #endregion

    }

}