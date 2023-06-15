using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class ListagemClienteControl : UserControl
    {
        public ListagemClienteControl()
        {
            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cli in clientes)
            {
                grid.Rows.Add(cli.id, cli.nome, cli.endereco, cli.telefone, cli.festas.Count);
            }
        }

        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa festa in festas)
            {
                grid.Rows.Add(festa.id, festa.cliente, festa.tema, festa.data, festa.valorEntrada, festa.valorTotal, festa.estaPago);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count > 0 && grid.SelectedRows[0].Cells["id"].Value != null)
            {
                int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
                return id;
            }
            else
                return -1;
        }

        public void MostrarAlugueisFeitos(List<Festa> listaFestas)
        {
            grid.Columns.Clear();

            PopularGridFiltro();

            AtualizarRegistros(listaFestas);
        }

        private void PopularGridFiltro()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "valorEntrada",
                    HeaderText = "ValorEntrada"
                }
                   ,
                   new DataGridViewTextBoxColumn()
                {
                    Name = "valorTotal",
                    HeaderText = "Valor Total"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "statusPagamento",
                    HeaderText = "Status Pagamento"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        private void popularGrid()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "endereco",
                    HeaderText = "endereço"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                }
                   ,
                   new DataGridViewTextBoxColumn()
                {
                    Name = "quantiadeAlugada",
                    HeaderText = "Quantidade de Alugueis"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
