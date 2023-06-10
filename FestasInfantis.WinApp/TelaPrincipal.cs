using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private RepositorioItens repositorioItens = new RepositorioItens(contextoDados);
        public ControladorBase controlador { get; set; }
        private RepositorioCliente repositorioCliente = new RepositorioCliente(contextoDados);
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (controlador == null)
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            controlador.Inserir();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);

            ConfigurarTelaPrincipal();
        }

        private void ConfigurarListagem()
        {
            UserControl listagem = controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panel.Controls.Clear();

            panel.Controls.Add(listagem);
        }

        public void ConfigurarTelaPrincipal()
        {
            ConfigurarListagem();
        }
    }
}