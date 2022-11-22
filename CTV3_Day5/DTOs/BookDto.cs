namespace CTV3_Day5.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public int? RenterId { get; set; }
        public AuthorDto? Author { get; set; }
    }
}
