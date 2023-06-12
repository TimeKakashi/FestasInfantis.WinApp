using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class ControladorItens : ControladorBase
    {
        private RepositorioItens repositorioItens;

        public ControladorItens(RepositorioItens repositorioItens)
        {
            this.repositorioItens = repositorioItens;
        }
    }
}