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

        public override void Inserir()
        {
            TelaCliente telaCliente = new TelaCliente();

            if(telaCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = telaCliente.Cliente;

                repositorioCliente.Inserir(cliente);

                CarregarClientes();
            }
        }

        public override void Editar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if(cliente == null)
            {
                MessageBox.Show("Selecione um cliente primerio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int id;

            TelaCliente telaCliente = new TelaCliente();
            telaCliente.Cliente = cliente;
            id = cliente.id;

            if(telaCliente.ShowDialog() == DialogResult.OK)
            {
                telaCliente.Cliente.id = id;
                repositorioCliente.Editar(id, telaCliente.Cliente);
            }
            else
                MessageBox.Show("Operção Cancelada!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            CarregarClientes();
        }

        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            DialogResult verificarExclusao = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificarExclusao == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);

                CarregarClientes();
            }

            
        }

        public override UserControl ObterListagem()
        {
            if (listagemCliente == null)
                listagemCliente = new ListagemClienteControl();

            CarregarClientes();
            return listagemCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }

        public void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            listagemCliente.AtualizarRegistros(clientes);
        }

        public Cliente ObterClienteSelecionado()
        {
            int id = listagemCliente.ObterIdSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }


    }
}
