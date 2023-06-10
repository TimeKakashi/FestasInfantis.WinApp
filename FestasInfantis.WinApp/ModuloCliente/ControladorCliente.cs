using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaInfantil.Dominio.ModuloCliente;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private ListagemClienteControl listagemCliente;

        public ControladorCliente(RepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaCliente telaCliente = new TelaCliente();

            if(telaCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = telaCliente.Cliente;

                repositorioCliente.Inserir(cliente);
            }
        }
        private void CarregarContatos()
        {

        }
        public override UserControl ObterListagem()
        {
            if (listagemCliente == null)
                listagemCliente = new ListagemClienteControl();

            CarregarContatos();
            return listagemCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }


    }
}
