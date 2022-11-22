namespace CTV3_Day5.Services;
using CTV3_Day5.DTOs;
public interface IBookService
{
    public Task<BookDto?> GetBook(int id);
    public Task<List<BookDto>> GetAllBooks();
    public Task<BookDto?> AddBook(BookDto book);
    public Task<List<BookDto>> Search(string name, string publisher, string authorFist, string authrorLast);
    public Task<BookRentalDto> GetRenal(int bookId);
    public Task<BookDto> Update(int bookId, BookDto dto);
    public Task<BookDto> Replace (int bookId, BookDto dto);
    public Task<bool> Delete (int bookId);
}

