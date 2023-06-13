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
        private Itens item;

        public Itens itens
        {
            set
            {
                tbItem.Text = value.nomeDoItem;
                tbValor.Text = value.valor;
            }
            get
            {
                return itens;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeDoItem = tbItem.Text;
            string valor = tbValor.Text;
            item = new Itens(nomeDoItem, valor);

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                DialogResult = DialogResult.None;
            }
        }

        private void Atualizar()
        {

        }
        private void popularListBoxItens(Tema temaSelecionado)
        {
            lbItens.Items.Clear();

            System.Collections.IList list = temaSelecionado.listaItens;
            for (int i = 0; i < list.Count; i++)
            {
                Tema item = (Tema)list[i];
                lbItens.Items.Add(item);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
