using schoollibrary.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.data
{
    public class BookRepository: IBookRepository
    {
        public IEnumerable<Book> GetBooksListOfSepcificAuthor(decimal authorSerial)
        {
            using (var context = new SchoolLibraryContext())
            {
                context.Database.EnsureCreated();
                var books = context.Books.ToList();
                return books;
            }
        }
    }
}
