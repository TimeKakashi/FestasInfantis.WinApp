using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaAniversario.Infra.Dados.Arquivo.ModuloItens
{
    public class RepositorioItens : RepositorioArquivoBase<Itens>
    {
        public RepositorioItens(ContextoDados contextoDados) : base(contextoDados)
        {
            
        }

        protected override List<Itens> ObterRegistros()
        {
            return contextoDados.itens;
        }
    }
}
