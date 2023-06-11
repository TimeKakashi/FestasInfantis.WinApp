using FestaAniversario.Infra.Dados.Arquivo.Compartilhado;
using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaAniversario.Infra.Dados.Arquivo.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private RepositorioItens repositorioItens = new RepositorioItens(contextoDados);
        public ControladorBase controlador { get; set; }
        private RepositorioCliente repositorioCliente = new RepositorioCliente(contextoDados);
        private RepositorioTemaArquivo repositorioTema = new RepositorioTemaArquivo(contextoDados);
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controlador.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);

        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.Text = controlador.ToolTipInserir;
            btnEditar.Text = controlador.ToolTipEditar;
            btnExcluir.Text = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);

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
            ConfigurarTelaPrincipal(controlador);
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
                MessageBox.Show("Selecione uma area primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            controlador.Excluir();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}