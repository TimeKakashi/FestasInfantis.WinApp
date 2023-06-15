using FestaInfantil.Dominio.ModuloCompartilhado;


namespace FestaInfantil.Dominio.ModuloTema
{
    public class Itens : EntidadeBase<Itens>
    {
        public string nomeDoItem { get; set; }
        public decimal valor { get; set; }
        public int contador = 0;
        public bool marcado = false;

        public Itens()
        {

        }
        public Itens(string nomeDoItem, decimal valor)
        {
            this.nomeDoItem = nomeDoItem;
            this.valor = valor;
           
        }
        public override string ToString()
        {
            return nomeDoItem;
        }
        public override void AtualizarInformacoes(Itens registroAtualziado)
        {
            this.nomeDoItem  = registroAtualziado.nomeDoItem;
            this.valor = registroAtualziado.valor;
        }

        public override string[] Validar()
        {
            List<String> lista = new List<String>();

            if (string.IsNullOrEmpty(nomeDoItem))
                lista.Add("Campo Nome do item está inválido!");

            if( valor < 0)
                lista.Add("Campo Valor do item incorreto!");

            return lista.ToArray();
        }
    }
}
