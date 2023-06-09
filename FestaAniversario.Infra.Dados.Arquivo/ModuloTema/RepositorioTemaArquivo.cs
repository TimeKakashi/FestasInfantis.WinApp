using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaAniversario.Infra.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioArquivoBase<Tema>
    {
        public RepositorioTemaArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
            
        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.temas;
        }
    }
}
