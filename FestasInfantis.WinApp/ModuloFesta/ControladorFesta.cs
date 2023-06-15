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

        public override string ToolTipPagar => "Realizar Pagamento de uma Festa";

        public override bool PagarHabilitado => true;

        public override bool FiltrarHabilitado => true;

        public override void Editar()
        {
            Festa festa = ObterFestaSelecionada();

            if (festa == null)
            {
                MessageBox.Show("Selecione uma festa primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (festa.pagamento)
            {
                TelaPrincipal.Instancia.AtualizarRodape("Essa festa está finalizada, não é possivel editá-la");
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

            if (festa == null)
            {
                MessageBox.Show("Selecione uma festa primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(festa.pagamento == false)
            {
                TelaPrincipal.Instancia.AtualizarRodape("Essa festa ainda não foi finalizada, não é possivel excluí-la");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja esssa festa?", "Exclusão de Festas",
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

        public override void Filtrar()
        {
            FiltroDeFesta telaFiltro = new FiltroDeFesta();

            if(telaFiltro.ShowDialog() == DialogResult.OK)
            {
                string status = telaFiltro.ObterStatus();

                List<Festa> listaFesta = new List<Festa>();

                if(status == "abertas")
                {
                    List<Festa> festasAbertas = repositorioFesta.FiltrarAlugueisEmAberto();
                    listagemFesta.AtualizarRegistros(festasAbertas);

                }
                else if (status == "finalizadas")
                {
                    List<Festa> festasPagas = repositorioFesta.FiltrarAlugueisPagos();
                    listagemFesta.AtualizarRegistros(festasPagas);
                }

                else if (status == "endereco")
                {
                    List<Festa> festasMesmoEndereco = repositorioFesta.FiltrarPorAlugueisComMesmoEndereco();
                    listagemFesta.AtualizarRegistros(festasMesmoEndereco);

                }

                else if (status == "todas")
                {
                    CarregarFestas();

                }
            }
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
            return "Cadastro de Festas";
        }

        public override void RealizarPagamento()
        {
            Festa festa = ObterFestaSelecionada();

            if (festa == null)
            {
                MessageBox.Show("Selecione uma festa primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (festa.pagamento)
            {
                TelaPrincipal.Instancia.AtualizarRodape("Essa festa está finalizada, não é possivel finalizá-la novamente");
                return;
            }

            if(MessageBox.Show("Deseja confirmar o pagamento?") == DialogResult.OK)
            {
                festa.pagamento = true;
                festa.estaPago = "Pago";
                festa.cliente.contador--;
                festa.tema.contador--;

                foreach (Itens item in festa.tema.itensCheck)
                {
                    item.contador--;
                }

                festa.dataEncerramento = DateTime.Now;
            }

            CarregarFestas();
        }
    }
}
