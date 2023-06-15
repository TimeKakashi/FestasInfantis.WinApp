﻿using FestaInfantil.Dominio.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Dominio.ModuloFesta
{
    public interface IRepositorioFesta : IRepositorioBase<Festa>
    {
        public List<Festa> FiltrarAlugueisEmAberto();
        public List<Festa> FiltrarAlugueisPagos();
        public List<Festa> FiltrarPorAlugueisComMesmoEndereco();
       
    }
}
