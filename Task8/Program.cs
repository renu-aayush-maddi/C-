using Task8.Models;
using Task8.Repositories;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> repository = new Repository<Product>();

            Product p1 = new Product{Id = 1,Name = "Laptop",Price = 100000};
            Product p2 = new Product{Id = 2,Name = "Mouse",Price = 500};

            repository.Add(p1);
            repository.Add(p2);

            Console.WriteLine("Products After Add\n");

            Display(repository.GetAll());

            Product updated = new Product{Id = 2,Name = "Wireless Mouse",Price = 1200};

            repository.Update(updated);

            Console.WriteLine("\nProducts After Update\n");

            Display(repository.GetAll());

            repository.Delete(1);

            Console.WriteLine("\nProducts After Delete\n");

            Display(repository.GetAll());
        }

        static void Display(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id} " +$"{product.Name} " +$"{product.Price}");
            }
        }
    }
}