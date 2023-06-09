using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public Tema tema { get; set; }
        public Cliente cliente { get; set; }
        public string enderecoFesta { get; set; }
        public DateTime data { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFinal { get; set; }
        public decimal valorEntrada { get; set; }


        public Festa(string enderecoFesta, Cliente cliente, DateTime data, TimeSpan horaInicio, TimeSpan horaFinal)
        {
            this.enderecoFesta = enderecoFesta;
            this.cliente = cliente;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
        }
    }
}
