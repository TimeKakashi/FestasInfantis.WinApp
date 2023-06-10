using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaInfantil.Dominio.ModuloTema;


namespace FestaAniversario.Infra.Dados.Arquivo.ModuloItens
{
    public class RepositorioItens : RepositorioArquivoBase<Itens>, IRepositorioItens
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
