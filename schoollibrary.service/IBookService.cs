using schoollibrary.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.service
{
    public interface IBookService
    {
        List<Book> GetBooksListOfSepcificAuthor(decimal serial);
    }
}
