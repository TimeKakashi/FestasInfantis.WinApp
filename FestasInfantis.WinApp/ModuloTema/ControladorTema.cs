using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloTema;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        ListagemTemaControl listagemTema = new ListagemTemaControl();
        public ControladorTema(IRepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir Tema";

        public override string ToolTipEditar => "Editar Tema";

        public override string ToolTipExcluir => "Excluir Tema";

        public override void Editar()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Selecione um tema primerio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTema telaTema = new TelaTema();
            int id = tema.id;
            telaTema.Tema = tema;

            if(telaTema.ShowDialog() == DialogResult.OK)
            {
                telaTema.Tema.id = id;
                repositorioTema.Editar(id, telaTema.Tema);
                CarregarTemas();
            }
        }

        public override void Excluir()
        {
            Tema tema = ObterTemaSelecionado();

            DialogResult verificarExclusao = MessageBox.Show($"Deseja excluir o tema {tema.descricao}?", "Exclusão de Temas",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(verificarExclusao == DialogResult.OK)
            {
                 repositorioTema.Excluir(tema);
                CarregarTemas();
            }
        }

        public override void Inserir()
        {
            TelaTema telaTema = new TelaTema();

            if(telaTema.ShowDialog() == DialogResult.OK)
            {
                Tema tema = telaTema.Tema;

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }
        }

        public Tema ObterTemaSelecionado()
        {
            int id = listagemTema.ObterIdSelecionado();

            return repositorioTema.SelecionarPorId(id);
        }

        public void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            
            listagemTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemTema == null)
                listagemTema = new ListagemTemaControl();

            CarregarTemas();
            return listagemTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
    }
}
