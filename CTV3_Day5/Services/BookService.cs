using CTV3_Day5.DTOs;
using CTV3_Day5.Data;
using Microsoft.EntityFrameworkCore;
using CTV3_Day5.Domain;

namespace CTV3_Day5.Services
{
    public class BookService : IBookService
    {
        private LibraryDBContext context;
        public BookService(LibraryDBContext context)
        {
            this.context = context;
        }

        public async Task<BookDto?> AddBook(BookDto bookdto)
        {
            Author? bookauthor = await context.Authors.SingleOrDefaultAsync(a => a.Id == bookdto.Author!.Id);

            if (bookauthor is null) return null;

            Book book = new Book()
            { 
                Name = bookdto.Name,
                Publisher = bookdto.Publisher,
                Author = bookauthor
            };

            context.Books.Add(book);
            await context.SaveChangesAsync();

            return book.Convert();
        }
           

        public Task<bool> Delete(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookDto>> GetAllBooks()
        {
            return await context.Books.Include(book => book.Author)
                .Select(book => book.Convert())
                .ToListAsync();
        }

        public async Task<BookDto?> GetBook(int id)
        {
            var book = await context.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);

            if (book is null) return null;

            return book.Convert();
        }
        

        public Task<BookRentalDto> GetRenal(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> Replace(int bookId, BookDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookDto>> Search(string name, string publisher, string authorFist, string authrorLast)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> Update(int bookId, BookDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
