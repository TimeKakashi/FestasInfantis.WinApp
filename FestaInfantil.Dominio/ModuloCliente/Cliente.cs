using FestaInfantil.Dominio.ModuloCompartilhado;

namespace FestaInfantil.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }

        public bool temDesconto = false;

        private Cliente cliente;

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, string endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public override string ToString()
        {
            return nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo nome esta vazio!");

            if(string.IsNullOrEmpty(telefone))
                erros.Add("O campo telefone esta vazio!");

            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo endereco esta vazio!");

            return erros.ToArray();

        }

        public override void AtualizarInformacoes(Cliente registroAtualziado)
        {
            this.nome = registroAtualziado.nome;
            this.telefone = registroAtualziado.telefone;
            this.endereco = registroAtualziado.endereco;
        }
    }
}
