namespace Task8.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        List<T> GetAll();
        T GetById(int id);
        void Update(T item);
        void Delete(int id);
    }
}