using FestaInfantil.Dominio.ModuloCliente;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioContato;
        private ListagemClienteControl listagemCliente;

        public ControladorCliente(RepositorioCliente repositorioCliente)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }
        private void CarregarContatos()
        {

        }
        public override UserControl ObterListagem()
        {
            if (listagemCliente == null)
                listagemCliente = new ListagemClienteControl();

            CarregarContatos();
            return listagemCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }


    }
}
