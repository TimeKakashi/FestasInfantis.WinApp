

using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
        }


        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();

            foreach (Tema tema in temas)
            {
                grid.Rows.Add(tema.id, tema.descricao, tema.valor);
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
            {

                return -1;
            }
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
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                }
            };

            grid.Columns.AddRange(colunas);
        }

    }
}
