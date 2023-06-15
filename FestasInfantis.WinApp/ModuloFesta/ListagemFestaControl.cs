using FestaInfantil.Dominio.ModuloFesta;
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

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class ListagemFestaControl : UserControl
    {
        public ListagemFestaControl()
        {
            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
        }

        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa festa in festas)
            {
                grid.Rows.Add(festa.id, festa.cliente.nome, festa.cliente.telefone, festa.tema, festa.data, festa.valorEntrada, festa.valorTotal, festa.estaPago, festa.dataEncerramento);
            }
        }
        public int ObterIdSelecionado()
        {

            if (grid.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
                return id;
            }
            return -1;
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
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
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
                    HeaderText = "Valor Entrada"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "valorFinal",
                    HeaderText = "Valor Total"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "pgamento",
                    HeaderText = "Status Pagamento"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "dataPagamento",
                    HeaderText = "Data de Encerramento"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
