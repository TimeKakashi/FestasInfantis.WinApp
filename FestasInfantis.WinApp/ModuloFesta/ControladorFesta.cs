using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        public ControladorFesta(IRepositorioFesta repositorioFesta, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioFesta = repositorioFesta;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        private IRepositorioFesta repositorioFesta;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private ListagemFestaControl listagemFesta;

        public override string ToolTipInserir => "Cadastrar nova Festa";

        public override string ToolTipEditar => "Editar dados da Festa";

        public override string ToolTipExcluir => "Excluir Festa";

        public override void Editar()
        {
            Festa festa = ObterFestaSelecionada();

            if(festa == null)
            {
                MessageBox.Show("Selecione uma festa primeiro!");
                return;
            }

            int id = festa.id;
            

            TelaFesta telaFesta = new TelaFesta(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());

            telaFesta.Festa = festa;

            if(telaFesta.ShowDialog() == DialogResult.OK)
            {
                telaFesta.Festa.id = id;

                repositorioFesta.Editar(id, telaFesta.Festa);
                CarregarFestas();
            }
        }

        public override void Excluir()
        {
            Festa festa = ObterFestaSelecionada();

            if(festa == null)
            {
                MessageBox.Show("Selecione um tema primeiro!");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir do cliente {festa.cliente}?", "Exclusão de Festas",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFesta.Excluir(festa);

                CarregarFestas();
            }
        }

        public override void Inserir()
        {
            TelaFesta telaFesta = new TelaFesta(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());

            if(telaFesta.ShowDialog() == DialogResult.OK)
            {
                Festa festa = telaFesta.Festa;

                repositorioFesta.Inserir(festa);
            }

            CarregarFestas();
        }

        private Festa ObterFestaSelecionada()
        {
            int id = listagemFesta.ObterIdSelecionado();

            return repositorioFesta.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (listagemFesta == null)
                listagemFesta = new ListagemFestaControl();

            CarregarFestas();
            return listagemFesta;
        }

        private void CarregarFestas()
        {
            List<Festa> festas = repositorioFesta.SelecionarTodos();

            listagemFesta.AtualizarRegistros(festas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Festas!";
        }
    }
}
