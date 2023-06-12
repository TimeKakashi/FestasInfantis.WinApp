using FestaInfantil.Dominio.ModuloCompartilhado;


namespace FestaInfantil.Dominio.ModuloTema
{
    public class Itens : EntidadeBase<Itens>
    {
        public decimal valor { get; set; }

        public override void AtualizarInformacoes(Itens registroAtualziado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
