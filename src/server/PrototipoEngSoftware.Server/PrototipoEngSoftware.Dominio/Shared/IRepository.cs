using System.Collections.Generic;

namespace PrototipoEngSoftware.Dominio.Shared
{
    public interface IRepository<T> where T : Entidade
    {
        bool Inserir(T entidade);
        T SelecionarPorId(int id);
        ICollection<T> SelecionarTodos();
    }
}
