namespace schoollibrary.domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public decimal Serial { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}