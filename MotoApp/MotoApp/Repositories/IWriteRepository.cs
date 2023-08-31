using MotoApp.Entites;

namespace MotoApp.Repositories
{
    public interface IWriteRepository<in T>
    {
        void Add(T item);

        void Remove(T item);

        void Save();
    }
}