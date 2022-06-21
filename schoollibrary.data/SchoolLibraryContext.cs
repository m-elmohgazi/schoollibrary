using Microsoft.EntityFrameworkCore;
using schoollibrary.domain;

namespace schoollibrary.data
{
    public class SchoolLibraryContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}