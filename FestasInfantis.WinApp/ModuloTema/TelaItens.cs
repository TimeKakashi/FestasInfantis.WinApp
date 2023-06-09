using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItens : Form
    {
        public TelaItens()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Atualizar()
        {

        }
        private void popularListBox(Tema temaSelecionado)
        {
            lbItens.Items.Clear();

            foreach (Itens item in temaSelecionado.listaItens)
            {
                lbItens.Items.Add(item);
            }
        }

    }
}
