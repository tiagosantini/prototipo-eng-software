using System.Collections.Generic;

namespace PrototipoEngSoftware.Dominio.Shared
{
    public interface IRepository<T> where T : Entidade
    {
        bool Inserir(T entidade);
        bool Editar(T Entidade);
        bool Excluir(T Entidade);
        bool Existe(int id);
        T SelecionarPorId(int id);
        ICollection<T> SelecionarTodos();
    }
}
