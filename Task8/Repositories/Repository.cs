using Task8.Interfaces;

namespace Task8.Repositories
{
    public class Repository<T> : IRepository<T> where T : class,IEntity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public T GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(T item)
        {
            T existing = GetById(item.Id);

            if (existing != null)
            {
                int index = items.IndexOf(existing);
                items[index] = item;
            }
        }

        public void Delete(int id)
        {
            T item = GetById(id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
    }
}