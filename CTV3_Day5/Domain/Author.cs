namespace CTV3_Day5.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Book> Books { get; set; } = null!;

        public Author (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Author() { }
    }
}
