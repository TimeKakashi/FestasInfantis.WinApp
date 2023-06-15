using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItens : Form
    {

        public TelaItens()
        {
            InitializeComponent();
            Shown += TelaItens_Shown;
        }


        private void TelaItens_Shown(object sender, EventArgs e)
        {
            tbItem.Focus();
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

          
            if (string.IsNullOrEmpty(nomeDoItem))
            {
                TelaPrincipal.Instancia.AtualizarRodape("O campo Item não pode estar vazio.");
                tbItem.Focus();
                DialogResult = DialogResult.None;
                return;
            }

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




        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
