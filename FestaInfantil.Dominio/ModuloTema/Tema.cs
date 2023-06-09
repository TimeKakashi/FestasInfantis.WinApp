using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
namespace FestaInfantil.Dominio.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string enderecoFesta {  get; set; }
        public Cliente cliente { get; set; }
        public DateTime data { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFinal { get; set; }

        public List<Itens> listaItens { get; set; }

        public Tema()
        {
            
        }

        public Tema(string enderecoFesta, Cliente cliente, DateTime data, TimeSpan horaInicio, TimeSpan horaFinal)
        {
            this.enderecoFesta = enderecoFesta;
            this.cliente = cliente;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.listaItens = new List<Itens>();
        }
    }
}
