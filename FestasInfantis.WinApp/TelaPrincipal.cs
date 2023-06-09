using FestaInfantil.Dominio.ModuloCliente;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private RepositorioCliente repositorioCliente = new RepositorioCliente();
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
        public void AtualizarBarraDeStatus(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);

        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.Text = controlador.ToolTipInserir;
            btnEditar.Text = controlador.ToolTipEditar;
            btnExcluir.Text = controlador.ToolTipExcluir;
        }


        private void clientesMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
        }


    }
}