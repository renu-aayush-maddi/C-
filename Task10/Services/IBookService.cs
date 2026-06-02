using Task10.Models;

namespace Task10.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();

        Task<Book?> GetByIdAsync(int id);

        Task<Book> AddAsync(Book book);

        Task<Book?> UpdateAsync(int id, Book book);

        Task<bool> DeleteAsync(int id);
    }
}