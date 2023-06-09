namespace FestaInfantil.Dominio.ModuloCliente
{
    public class Cliente
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, string endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }
    }
}
