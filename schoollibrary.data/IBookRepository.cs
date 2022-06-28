using schoollibrary.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.data
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooksListOfSepcificAuthor(decimal authorSerial);
    }
}
