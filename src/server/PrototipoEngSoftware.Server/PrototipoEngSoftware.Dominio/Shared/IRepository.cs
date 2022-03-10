namespace PrototipoEngSoftware.Dominio.Shared
{
    public interface IRepository<IEntity>
    {
        bool Inserir(IEntity entidade);
    }
}
