using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaInfantil.Dominio.ModuloFesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaAniversario.Infra.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFesta : RepositorioArquivoBase<Festa>, IRepositorioFesta
    {
        public RepositorioFesta(ContextoDados contextoDados) : base(contextoDados)
        {

        }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDados.festas;
        }
    }
}
