using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private ListagemClienteControl listagemCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }
        public override bool FiltrarHabilitado => true;



        private Cliente ObterClienteSelecionado()
        {
            int id = listagemCliente.ObterIdSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }
        public override void Inserir()
        {
            TelaCliente telaCliente = new TelaCliente();

            if(telaCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = telaCliente.Cliente;

                List<Cliente> listaClientes = repositorioCliente.SelecionarTodos();

                if (listaClientes.Any(n => n.nome == cliente.nome))
                {
                    TelaPrincipal.Instancia.AtualizarRodape("Nome ja utilizado!");
                    Inserir();
                }

                repositorioCliente.Inserir(cliente);
                CarregarClientes();
            }
        }

        public override void Editar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            int id = 0;
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.Cliente = cliente;
            id = cliente.id;

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaCliente.Cliente.id = id;
                repositorioCliente.Editar(id, telaCliente.Cliente);

                CarregarClientes();
            }
            
        }


        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (cliente.contador > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape("Esse cliente possui um aluguel, não é possivel exclui-lo");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);

                CarregarClientes();
            }
        }

        public override void Filtrar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if(cliente.festas.Count == 0) 
            {
                TelaPrincipal.Instancia.AtualizarRodape("Esse cliente não possui nenhuma festa em seu nome!");
                return;
            }

            listagemCliente.MostrarAlugueisFeitos(cliente.festas);
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

        public override void RealizarPagamento()
        {
            throw new NotImplementedException();
        }

       
    }
}
