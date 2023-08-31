using MotoApp.Entites;

namespace MotoApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> 
        where T : class, IEntity
    {
    }
}