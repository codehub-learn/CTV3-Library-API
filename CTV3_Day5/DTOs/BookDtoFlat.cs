namespace CTV3_Day5.DTOs
{
    public class BookDtoFlat
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int AuthorId { get; set; }   
        public string? AuthorFirstName { get; set; }
        public string? AuthorLastName { get; set; }
        public string? Publisher { get; set; }
        public string? RegnerId { get; set; }

    }
}
