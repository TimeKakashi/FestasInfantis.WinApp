using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
namespace FestaInfantil.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public List<Itens> listaItens { get; set; }
        public List<Itens> itensCheck { get; set; }

        public Tema()
        {
            this.listaItens = new List<Itens>();
            this.itensCheck = new List<Itens>();
        }

        public Tema(string descricao, decimal valor, List<Itens> listaItens, List<Itens> itensCheck) : this()
        {
            this.descricao = descricao;
            this.valor = valor;
            this.listaItens = listaItens;
            this.itensCheck = itensCheck;
        }

        public override string ToString()
        {
            return descricao;
        }
        public override string[] Validar()
        {
            List<String> lista = new List<String>();

            if (string.IsNullOrEmpty(descricao))
                lista.Add("O campo descricao esta incorreto!");

            return lista.ToArray();
        }

        public override void AtualizarInformacoes(Tema registroAtualziado)
        {
            this.descricao = registroAtualziado.descricao;
            this.valor = registroAtualziado.valor;
            this.listaItens = registroAtualziado.listaItens;
            this.itensCheck = registroAtualziado.itensCheck;
        }
    }
}
