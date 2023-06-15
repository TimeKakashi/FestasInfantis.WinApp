using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloCompartilhado;
using FestaInfantil.Dominio.ModuloTema;
using System.Globalization;

namespace FestaInfantil.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {

        public bool pagamento;
        public Tema tema { get; set; }
        public Cliente cliente { get; set; }
        public string enderecoFesta { get; set; }
        public DateTime data { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFinal { get; set; }
        public decimal sinal { get; set; }
        public DateTime dataEncerramento { get; set; }
        public decimal valorEntrada { get; set; }
        public string estaPago { get; set; }
        public decimal valorTotal { get; set; }

        public Festa()
        {
            
        }
        public Festa(string enderecoFesta, Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFinal, decimal valorTotal, decimal sinal)
        {
            this.enderecoFesta = enderecoFesta;
            this.tema = tema;
            this.cliente = cliente;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.valorTotal = valorTotal;
            this.sinal = sinal / 100;
            this.valorEntrada = Math.Round(valorTotal * (1 - this.sinal), 2);
            this.estaPago = "Em aberto";
        }

        public override string[] Validar()
        {
            List<String> erros = new List<string>();

            if (cliente == null)
                erros.Add("Campo cliente está inválido!");

            if (sinal < 0.40m || sinal > 0.5m || sinal == null || !(sinal is decimal) )
                erros.Add("O campo sinal está inválido, deve ser entre 40% a 50% e um número inteiro");

            if (data < DateTime.Now)
                erros.Add("A festa não pode ser feita no passado!");

            else if (horaFinal < horaInicio)
                erros.Add("A festa não pode terminar antes de começar!");

            if (tema == null)
                erros.Add("Campo tema está inválido!");

            if(string.IsNullOrEmpty(enderecoFesta))
                erros.Add("Campo endereco está inválido!");

            if (enderecoFesta.Length < 15)
                erros.Add("Campo endereço está inválido, Adicione: Rua, Número, Cidade");


            return erros.ToArray();

        }

        public override void AtualizarInformacoes(Festa registroAtualziado)
        {
            this.tema = registroAtualziado.tema;
            this.enderecoFesta = registroAtualziado.enderecoFesta;
            this.cliente = registroAtualziado.cliente;
            this.data = registroAtualziado.data;
            this.horaInicio = registroAtualziado.horaInicio;
            this.horaFinal = registroAtualziado.horaFinal;
            this.valorTotal = registroAtualziado.valorTotal;
            this.valorEntrada = registroAtualziado.valorEntrada;
        }
    }
}
