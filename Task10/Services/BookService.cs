using Microsoft.EntityFrameworkCore;
using Task10.Data;
using Task10.Models;

namespace Task10.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<BookService> _logger;

        public BookService(AppDbContext context,ILogger<BookService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            _logger.LogInformation("Getting all books");

            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            _logger.LogInformation("Getting book {Id}", id);

            return await _context.Books.FindAsync(id);
        }

        public async Task<Book> AddAsync(Book book)
        {
            _logger.LogInformation("Adding book");

            await _context.Books.AddAsync(book);

            await _context.SaveChangesAsync();

            return book;
        }

        public async Task<Book?> UpdateAsync(int id, Book book)
        {
            var existingBook = await _context.Books.FindAsync(id);

            if (existingBook == null)
                return null;

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;

            await _context.SaveChangesAsync();

            return existingBook;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
                return false;

            _context.Books.Remove(book);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}