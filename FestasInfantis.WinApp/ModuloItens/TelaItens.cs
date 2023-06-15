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
                tbValor.Text = value.valor.ToString();
            }
            get
            {
                return item;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeDoItem = tbItem.Text;
            decimal valor;

            if (decimal.TryParse(tbValor.Text, out valor))
            {
                item = new Itens(nomeDoItem, valor);

                string[] erros = item.Validar();

                if (erros.Length > 0)
                {
                    TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                TelaPrincipal.Instancia.AtualizarRodape("Valor inválido para o campo Valor.");
                DialogResult = DialogResult.None;
            }
        }


        private void Atualizar()
        {

        }
        private void popularListBoxItens(Tema temaSelecionado)
        {
            lbItens.Items.Clear();

            List<Itens> list = temaSelecionado.listaItens;

            for (int i = 0; i < list.Count; i++)
            {
                Itens item = list[i];
                lbItens.Items.Add(item);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
