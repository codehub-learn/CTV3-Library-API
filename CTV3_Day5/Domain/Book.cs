namespace CTV3_Day5.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Author Author { get; set; } = null!;
        public int AuthorId { get; set; }
        public string Publisher { get; set; } = null!;
        public Member? RentedTo { get; set; }
        public int? RentedToId { get; set; }

        public Book(string name, string publisher, Author author)
        {
            Name = name;
            Publisher = publisher;
            Author = author;
        }

        public Book() { }
    }
}
