using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class ListagemItensControl : UserControl
    {
        public ListagemItensControl()
        {

            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
        }
        public void AtualizarRegistros(List<Itens> itens)
        {
            grid.Rows.Clear();

            foreach (Itens item in itens)
            {
                grid.Rows.Add(item.id, item.nomeDoItem, item.valor);
            }
        }
        public int ObterIdSelecionado()
        {
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
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
                    Name = "nomeDoItem",
                    HeaderText = "Item"
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

