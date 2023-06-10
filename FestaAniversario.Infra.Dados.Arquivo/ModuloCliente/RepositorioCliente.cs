

using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;

namespace FestaAniversario.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioCliente : RepositorioArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}
