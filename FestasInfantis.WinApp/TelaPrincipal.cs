using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private RepositorioItens repositorioItens = new RepositorioItens(contextoDados);
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}