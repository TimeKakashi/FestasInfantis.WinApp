using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class ControladorItens : ControladorBase
    {
        private IRepositorioItens repositorioItens;
        ListagemItensControl listagemItens = new ListagemItensControl();

        public ControladorItens(IRepositorioItens repositorioItens)
        {
            this.repositorioItens = repositorioItens;
        }

        public override string ToolTipInserir => "Inserir Itens";

        public override string ToolTipEditar => "Editar Itens";

        public override string ToolTipExcluir => "Excluir Itens";

        public override void Editar()
        {
            Itens item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show("Selecione um item primerio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaItens telaItens = new TelaItens();
            int id = item.id;
            telaItens.itens = item;

            if (telaItens.ShowDialog() == DialogResult.OK)
            {
                telaItens.itens.id = id;
                repositorioItens.Editar(id, telaItens.itens);
                CarregarItens();
            }
        }


        public override void Excluir()
        {
            Itens item = ObterItemSelecionado();

            DialogResult verificarExclusao = MessageBox.Show($"Deseja excluir o tema {item.nomeDoItem}?", "Exclusão de Item",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificarExclusao == DialogResult.OK)
            {
                repositorioItens.Excluir(item);
                CarregarItens();
            }
        }

        public override void Inserir()
        {
            TelaItens telaItens = new TelaItens();

            if (telaItens.ShowDialog() == DialogResult.OK)
            {
                Itens item = telaItens.itens;

                repositorioItens.Inserir(item);

                CarregarItens();
            }
        }
        public void CarregarItens()
        {
            List<Itens> itens = repositorioItens.SelecionarTodos();

            listagemItens.AtualizarRegistros(itens);
        }
        public Itens ObterItemSelecionado()
        {
            int id = listagemItens.ObterIdSelecionado();

            return repositorioItens.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (listagemItens == null)
                listagemItens = new ListagemItensControl();

            CarregarItens();
            return listagemItens;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Itens";
        }
    }
}