namespace CTV3_Day5.DTOs;
using CTV3_Day5.Domain;

public static class DtoConverters
{
    public static BookDto Convert(this Book book)
    {
        return new BookDto()
        {
            Id = book.Id,
            Name = book.Name,
            Publisher = book.Publisher,
            Author = new AuthorDto()
            {
                FirstName = book.Author.FirstName,
                LastName = book.Author.LastName
            }
        };
    }
}
       


