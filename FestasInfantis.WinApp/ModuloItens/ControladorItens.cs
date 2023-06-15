using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItens
{
    internal class ControladorItens : ControladorBase
    {
        private IRepositorioItens repositorioItem;
        ListagemItensControl listagemItens = new ListagemItensControl();

        public ControladorItens(IRepositorioItens repositorioItens)
        {
            repositorioItem = repositorioItens;
        }

        public override string ToolTipInserir => "Inserir Itens";

        public override string ToolTipEditar => "Editar Itens";

        public override string ToolTipExcluir => "Excluir Itens";

        public override void Editar()
        {
            Itens item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show("Selecione um item primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaItens telaItens = new TelaItens();
            int id = item.id;
            telaItens.itens = item;

            bool nomeRepetido = false;

            do
            {
                if (telaItens.ShowDialog() == DialogResult.OK)
                {
                    Itens itemEditado = telaItens.itens;

                    List<Itens> listaItens = repositorioItem.SelecionarTodos();

                    if (listaItens.Any(i => i.nomeDoItem.ToLower() == itemEditado.nomeDoItem.ToLower() && i.id != id))
                    {
                        TelaPrincipal.Instancia.AtualizarRodape("Nome já utilizado!");
                        nomeRepetido = true;
                    }
                    else
                    {
                        itemEditado.id = id;
                        repositorioItem.Editar(id, itemEditado);
                        CarregarItens();
                        nomeRepetido = false;
                    }
                }
                else
                {
                    nomeRepetido = false;
                }
            } while (nomeRepetido);
        }



        public override void Excluir()
        {
            Itens item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show("Selecione um item primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (item.contador > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape("Esse item está inserido em um tema, não é possivel excluí-lo");
                return;
            }

            DialogResult verificarExclusao = MessageBox.Show($"Deseja excluir o item {item.nomeDoItem}?", "Exclusão de Item",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificarExclusao == DialogResult.OK)
            {
                repositorioItem.Excluir(item);
                CarregarItens();
            }
        }

        public override void Inserir()
        {
            TelaItens telaItens = new TelaItens();
            bool nomeRepetido = false;

            do
            {
                if (telaItens.ShowDialog() == DialogResult.OK)
                {
                    Itens item = telaItens.itens;
                    List<Itens> listaItens = repositorioItem.SelecionarTodos();

                    if (listaItens.Any(i => i.nomeDoItem.ToLower() == item.nomeDoItem.ToLower()))
                    {
                        TelaPrincipal.Instancia.AtualizarRodape("Nome já utilizado!");
                        nomeRepetido = true;
                    }
                    else
                    {
                        repositorioItem.Inserir(item);
                        CarregarItens();
                        nomeRepetido = false;
                    }
                }
                else
                {
                    nomeRepetido = false;
                }
            } while (nomeRepetido);
        }

        public void CarregarItens()
        {
            List<Itens> item = repositorioItem.SelecionarTodos();

            listagemItens.AtualizarRegistros(item);
        }
        public Itens ObterItemSelecionado()
        {
            int id = listagemItens.ObterIdSelecionado();

            return repositorioItem.SelecionarPorId(id);
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

        public override void RealizarPagamento()
        {
            throw new NotImplementedException();
        }
    }
}