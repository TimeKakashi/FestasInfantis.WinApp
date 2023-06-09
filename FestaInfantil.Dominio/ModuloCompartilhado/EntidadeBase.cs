

namespace FestaInfantil.Dominio.ModuloCompartilhado
{
    public class EntidadeBase<T>
    {
        public int id;

        public void AtualizarInformacoes<T>(T itemAtualizado) where T : EntidadeBase<T>
        {
            throw new NotImplementedException();
        }
    }
}
