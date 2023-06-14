using FestaInfantil.Dominio.ModuloCompartilhado;


namespace FestaInfantil.Dominio.ModuloTema
{
    public class Itens : EntidadeBase<Itens>
    {
        public string nomeDoItem { get; set; }
        public decimal valor { get; set; }

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
                lista.Add("Campo Nome do item incorreto!");

            if(valor == null || valor == 0)
                lista.Add("Campo Nome do item incorreto!");

            return lista.ToArray();
        }
    }
}
