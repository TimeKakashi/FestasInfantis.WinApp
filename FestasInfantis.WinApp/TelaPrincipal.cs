using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloFesta;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaAniversario.Infra.Dados.Arquivo.ModuloTema;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloFesta;
using FestasInfantis.WinApp.ModuloItens;
using FestasInfantis.WinApp.ModuloTema;
using System.Windows.Forms;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private IRepositorioCliente repositorioCliente = new RepositorioCliente(contextoDados);
        private IRepositorioTema repositorioTema = new RepositorioTemaArquivo(contextoDados);
        private IRepositorioFesta repositorioFesta = new RepositorioFesta(contextoDados);
        private IRepositorioItens repositorioItens = new RepositorioItens(contextoDados);
        public ControladorBase controlador { get; set; }
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controlador.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);

        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnPagar.ToolTipText = controlador.ToolTipPagar;
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);

        }

        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();
                return telaPrincipal;
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            LBrodape.Text = mensagem;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlador.Inserir();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
            btnPagar.Visible = false;


        }

        private void festasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFesta(repositorioFesta, repositorioCliente, repositorioTema);
            ConfigurarTelaPrincipal(controlador);
            btnPagar.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlador.Excluir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlador.Editar();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema, repositorioItens);
            ConfigurarTelaPrincipal(controlador);
            btnPagar.Visible = false;

        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItens(repositorioItens);
            ConfigurarTelaPrincipal(controlador);
            btnPagar.Visible = false;
        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controlador.RealizarPagamento();
        }
    }
}