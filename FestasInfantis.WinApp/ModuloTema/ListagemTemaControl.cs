﻿using FestaInfantil.Dominio.ModuloTema;
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
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Temas> listaItens)
        {
            grid.Rows.Clear();

            foreach (Temas item in listaItens)
            {
                grid.Rows.Add(item.id, item.valor);
            }
        }
    }
}
