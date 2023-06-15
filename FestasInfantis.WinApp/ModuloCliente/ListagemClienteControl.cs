﻿using FestaInfantil.Dominio.ModuloCliente;
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
