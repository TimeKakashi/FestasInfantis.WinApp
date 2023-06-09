using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private RepositorioItens repositorioItens = new RepositorioItens(contextoDados);
        public ControladorBase controladorBase { get; set; }
        private RepositorioCliente repositorioCliente = new RepositorioCliente();
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}