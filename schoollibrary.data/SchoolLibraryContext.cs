using Microsoft.EntityFrameworkCore;
using schoollibrary.domain;

namespace schoollibrary.data
{
    public class SchoolLibraryContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=schoollibrary;Trusted_Connection=True;");
            
        }
    }
}