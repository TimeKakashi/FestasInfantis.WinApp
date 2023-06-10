
namespace FestaInfantil.Dominio.ModuloCompartilhado
{
        public interface IRepositorioBase<T> where T : EntidadeBase<T>
        {
            void Inserir(T tarefa);
            void Editar(int id, T tarefa);
            void Excluir(T tarefaSelecionada);
            T SelecionarPorId(int id);
            List<T> SelecionarTodos();
        }
}
