using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
namespace FestaInfantil.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public List<Tema> listaItens { get; set; }

        public Tema()
        {
            
        }

        public Tema(string descricao, decimal valor)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.listaItens = new List<Tema>();
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
