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

        public List<Festa> FiltrarAlugueisEmAberto()
        {
            return (List<Festa>)ObterRegistros().Where(x => x.pagamento == false).ToList();
        }

        public List<Festa> FiltrarAlugueisPagos()
        {
            return (List<Festa>)ObterRegistros().Where(x => x.pagamento == true).ToList();
        }

        public List<Festa> FiltrarPorAlugueisComMesmoEndereco()
        {
            return (List<Festa>)ObterRegistros().OrderBy(x => x.enderecoFesta).ToList();
        }
    }
}
