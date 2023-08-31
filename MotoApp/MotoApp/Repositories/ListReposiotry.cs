namespace MotoApp.Repositories
{
    using MotoApp.Entites;

    public class ListReposiotry<T> : IRepository<T>
        where T : class, IEntity, new()     //new() oznacza, że klasa musi posiadac bezparametrowy konstruktor, jeżeli klasa ma też inne konstruktory

    {
        private readonly List<T> _items = new();

        public IEnumerable<T> GetAll()
        {
           return _items.ToList();
        }

    public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            //foreach (var employee in _items)
            //{
            //    Console.WriteLine(employee);
            //}
        }

        public T CreateNewItem()
        {
            return new T();
        }
    }
}