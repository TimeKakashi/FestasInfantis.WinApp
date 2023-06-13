using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
namespace FestaInfantil.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public List<Itens> listaItens { get; set; }

        public Tema()
        {
            
        }

        public Tema(string descricao, decimal valor, List<Itens> listaItens)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.listaItens = listaItens;
        }

        public override string ToString()
        {
            return descricao;
        }
        public override string[] Validar()
        {
            List<String> lista = new List<String>();

            if (descricao == null)
            {
                lista.Add("Campo descricao incorreto!");

            }

            return lista.ToArray();
        }

        public override void AtualizarInformacoes(Tema registroAtualziado)
        {
            this.descricao = registroAtualziado.descricao;
            this.listaItens = registroAtualziado.listaItens;
        }
    }
}
