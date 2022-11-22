namespace CTV3_Day5.Domain
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public List<Book> RentedBooks { get; set; } = null!;

        public Member (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Member() { }
    }
}
